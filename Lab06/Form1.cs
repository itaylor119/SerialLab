using System;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using CRC_Lib_Framework;

/*
Name: Ian Taylor
Lab: 6
Date: 4/28/2022
Sources:
https://docs.microsoft.com/en-us/dotnet/api/system.bitconverter.tochar?view=net-6.0
https://stackoverflow.com/questions/15729873/filenotfound-when-i-use-image-fromfile
https://docs.microsoft.com/en-us/dotnet/api/system.io.file.createtext?view=net-6.0
https://stackoverflow.com/questions/816566/how-do-you-get-the-current-project-directory-from-c-sharp-code-when-creating-a-c
*/

namespace Lab06
{
    public partial class Form1 : Form
    {
        private static readonly char NAK = (char)21;
        private static readonly char FF = (char)12;
        private static readonly char ACK = (char)6;
        private static readonly char ENQ = (char)5;
        private static readonly char EOT = (char)4;
        private static readonly char SOH = (char)1;

        private bool acked = false;
        private int stopBits = 1;

        private static char crc_char;
        private static int bytes = 0;

        private static StreamWriter writeStream;

        Queue<byte[]> packets = new Queue<byte[]>();

        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            ToolStripMenuItem[] items = new ToolStripMenuItem[ports.Length];
            for (int i = 0; i < ports.Length; i++)
            {
                Debug.WriteLine(ports[i]);
                ToolStripMenuItem item = new ToolStripMenuItem()
                {
                    Text = ports[i],
                    Name = ports[i]
                };
                items[i] = item;
                Debug.WriteLine(items.Length);
            }
            pORTToolStripMenuItem.DropDownItems.AddRange(items);
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            hexBox.Clear();
            asciiBox.Clear();
            sendLabel.Text = "waiting";
            recvLabel.Text = "waiting";
            connIcon.Image = Properties.Resources.StatusAnnotation_No_16xLG;
            readLabel.Text = openFileDialog.FileName;
            if (openFileDialog.FileName == "")
            {
                readLabel.Text = "no file";
            }
        }

        private void fileSelect_Click(object sender, EventArgs e)
        {
            string path = string.Empty;

            using (openFileDialog)
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    path = openFileDialog.FileName;
                    readLabel.Text = openFileDialog.FileName;

                }
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            char[] packet = new char[7];
            byte[] crcBytes = new byte[7];
            Stream fileStream = null;

            //Read the contents of the file into a stream
            try
            {
                fileStream = openFileDialog.OpenFile();
            }
            catch
            {
                fileStream = null;
            }

                using (StreamReader reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    sendLabel.Text = "sending";

                    // PACKET CREATION

                    packet[0] = SOH;
                    for (int i = 0; i < 5; i++)
                    {
                        if (!reader.EndOfStream)
                        {
                            packet[i+1] = (char)reader.Read();
                            bytes++;
                            readLabel.Text = "read " + bytes + " bytes";
                        }
                        else if (reader.EndOfStream && i != 4)
                        {
                            packet[i + 1] = FF;
                            bytes = 0;
                        }
                        else if (reader.EndOfStream && i == 4)
                        {
                            packet[i + 1] = EOT;
                            bytes = 0;
                        }
                    }
                    //reader.ReadBlock(packet, 1, 5); // read 5 chars into packet
                    packet[6] = (char)0;
                    Encoding.ASCII.GetBytes(packet, 0, packet.Length,
                    crcBytes, 0); /* transfer the text from packet into the 
                    array of bytes starting at the first location in the array */

                    CRC_Lib_Framework.CRC_Lib.CRC_Class crc = new CRC_Lib_Framework.CRC_Lib.CRC_Class(crcBytes); // Create CRC

                    byte crc_value = crc.get_CRC(); // Get created CRC value

                    char crc_char = (char)crc_value;

                    byte[] buffer = Encoding.ASCII.GetBytes(packet);

                    byte[] ackBuffer = new byte[1];

                    buffer[6] = crc_value;

                    // COM SENDING

                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Write(buffer, 0, 7);
                        sendLabel.Text = "waiting for ack...";
                        int tries = 0;
                        while(acked == false && tries <= 3)
                        {
                            Thread.Sleep(500);
                            if (serialPort1.IsOpen)
                            {
                                serialPort1.Read(ackBuffer, 0, 1);
                                if (ackBuffer[0] == ACK)
                                {
                                    acked = true;
                                    recvLabel.Text = "ACK received";
                                    connIcon.Image = Properties.Resources.StatusAnnotations_Complete_and_ok_32xLG_color;
                                }
                                else if (ackBuffer[0] != ACK)
                                {
                                    tries++;
                                    connIcon.Image = Properties.Resources.StatusAnnotation_No_16xLG;
                                }
                            }
                        }
                        acked = false;
                    }

                    
                    foreach(char c in packet)
                    {
                        Debug.WriteLine(c);
                    }
                    
                }

                sendLabel.Text = "sent";
                reader.Close();
                fileStream.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Not really possible for this event to be fired if it's not open, but let's test anyway.
            if (serialPort1.IsOpen)
            {
                //connIcon.Image = Properties.Resources.StatusAnnotations_Complete_and_ok_32xLG_color;
                Encoding encoder = Encoding.ASCII;
                byte[] original = new byte[7];
                serialPort1.Read(original, 0, 7);
                string tempMsg = encoder.GetString(original);
                    //serialPort1.ReadExisting();

                if (tempMsg == ACK.ToString())
                {
                    acked = true;
                }

                System.Threading.Thread.Sleep(500);
                byte[] crcBytes = new byte[7];
                string ascii = ProcessMessage(0, tempMsg);

                //encoder.GetBytes(tempMsg, 0, tempMsg.Length, crcBytes, 0);

                CRC_Lib_Framework.CRC_Lib.CRC_Class crc = new CRC_Lib_Framework.CRC_Lib.CRC_Class(original); // Create CRC

                byte crc_value = crc.get_CRC(); // Get created CRC value

                crc_char = (char)crc_value;

                Debug.WriteLine(crc_char + " " + crc_value);

                for (int i = 0; i < tempMsg.Length; i++)
                {
                    if (tempMsg[i] > 31 && tempMsg[i] < 127 && i % 6 != 0)
                    {
                        writeStream.Write(tempMsg[i]);
                    }
                }

                asciiBox.Invoke(new EventHandler(delegate
                {
                    
                    // TODO: Fix CRC value (not 0 on read)
                    if (crc_char == 0)
                    {
                        recvLabel.Text = "received";
                        serialPort1.Write(ACK.ToString());
                        asciiBox.AppendText(ascii);
                    }
                    else if (crc_char != 0 && original[0] != ACK)
                    {
                        recvLabel.Text = "CRC Error";
                        //connIcon.Image = Properties.Resources.StatusAnnotation_No_16xLG;
                    }
                    else if (acked == true)
                    {
                        recvLabel.Text = "ACK received";
                    }
                }));

                hexBox.Invoke(new EventHandler(delegate
                {
                    System.Threading.Thread.Sleep(500);
                    //byte[] crcBytes = new byte[7];
                    string hex = ProcessMessage(1, tempMsg);

                    //encoder.GetBytes(tempMsg, 0, tempMsg.Length, crcBytes, 0); /* transfer the text from packet into the array of bytes starting at the first location in the array */

                    //CRC_Lib_Framework.CRC_Lib.CRC_Class crc = new CRC_Lib_Framework.CRC_Lib.CRC_Class(original); // Create CRC

                    //byte crc_value = crc.get_CRC(); // Get created CRC value

                    //char crc_char = (char)crc_value;

                    //Debug.WriteLine(crc_char + " " + crc_value);

                    if (crc_char == 0)
                    {
                        recvLabel.Text = "received";
                        serialPort1.Write(ACK.ToString());
                        hexBox.AppendText(hex);
                    }
                    else if (crc_char != 0 && original[0] != ACK)
                    {
                        recvLabel.Text = "CRC Error";
                        connIcon.Image = Properties.Resources.StatusAnnotation_No_16xLG;
                    }
                    else if (acked == true)
                    {
                        recvLabel.Text = "ACK received";
                    }
                }));
                
            }
            else
            {
                MessageBox.Show("Serial port must be opened before reading data.");
            }
        }

        private void wordSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private string ProcessMessage(int display, string tempMsg)
        {
            ushort SOH = 0;
            ushort len = 0;
            string msg = "";
            int crc = -1;

            //tempMsg = serialPort1.ReadExisting(); // Need to read one at a time?

            bool found = false;

            //connIcon.Image = Properties.Resources.StatusAnnotations_Complete_and_ok_32xLG_color;

            for (int i = 0; i < tempMsg.Length; i++)
            {
                found = false;
                if (stopBits == 1 && i == (tempMsg.Length - 1))
                {
                    if (display == 0)
                    {
                        switch ((int)tempMsg[i])
                        {
                            case 5:
                                msg = msg + "ENQ";
                                found = true;
                                break;
                            case 6:
                                msg = msg + "ACK";
                                found = true;
                                break;
                            case 21:
                                msg = msg + "NAK";
                                found = true;
                                break;
                            case 1:
                                msg = msg + "SOH";
                                found = true;
                                break;
                            case 4:
                                msg = msg + "EOT";
                                found = true;
                                break;
                            case 10:
                                msg = msg + "LF";
                                found = true;
                                break;
                            case 13:
                                msg = msg + "CR";
                                found = true;
                                break;
                            default:
                                break;
                        }

                    }
                    if (found == false)
                    {
                        msg = msg + string.Format("0x{0:X}", ((int)tempMsg[i]));
                    }
                }
                else if (stopBits == 2 && (i == (tempMsg.Length - 1) || i == (tempMsg.Length - 2)))
                {
                    if (display == 0)
                    {
                        switch ((int)tempMsg[i])
                        {
                            case 5:
                                msg = msg + "ENQ";
                                found = true;
                                break;
                            case 6:
                                msg = msg + "ACK";
                                found = true;
                                break;
                            case 21:
                                msg = msg + "NAK";
                                found = true;
                                break;
                            case 1:
                                msg = msg + "SOH";
                                found = true;
                                break;
                            case 4:
                                msg = msg + "EOT";
                                found = true;
                                break;
                            case 10:
                                msg = msg + "LF";
                                found = true;
                                break;
                            case 13:
                                msg = msg + "CR";
                                found = true;
                                break;
                            default:
                                break;
                        }

                    }
                    if (found == false)
                    {
                        msg = msg + string.Format("0x{0:X}", ((int)tempMsg[i]));
                    }
                }
                else if (tempMsg[i] >= 32 && tempMsg[i] <= 126 && display == 0 && i > 0)
                {
                    msg += tempMsg[i];
                }
                else
                {
                    if (display == 0)
                    {
                        switch ((int)tempMsg[i])
                        {
                            case 5:
                                msg = msg + "ENQ";
                                found = true;
                                break;
                            case 6:
                                msg = msg + "ACK";
                                found = true;
                                break;
                            case 21:
                                msg = msg + "NAK";
                                found = true;
                                break;
                            case 1:
                                msg = msg + "SOH";
                                found = true;
                                break;
                            case 4:
                                msg = msg + "EOT";
                                found = true;
                                break;
                            case 10:
                                msg = msg + "LF";
                                found = true;
                                break;
                            case 13:
                                msg = msg + "CR";
                                found = true;
                                break;
                            default:
                                break;
                        }

                    }
                    if (found == false)
                    {
                        msg = msg + string.Format("0x{0:X}", ((int)tempMsg[i]));
                    }
                }
            }
            return msg;
        }

        private void pORTToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            serialPort1.PortName = e.ClickedItem.Text;
            portLabel.Text = ("Port " + e.ClickedItem.Text + ":");
        }

        private void openPortBtn_Click(object sender, EventArgs e)
        {
            if (portLabel.Text == "Port NONE:")
            { return; }
            else
            {
                try { serialPort1.Open(); }
                catch { };
                closePortBtn.Enabled = true;
                openPortBtn.Enabled = false;
            }

            try
            {
                writeStream = File.CreateText(System.IO.Path.GetFullPath("c:\\output.txt"));
            }
            catch
            { }
        }

        private void closePortBtn_Click(object sender, EventArgs e)
        {
            if (portLabel.Text == "Port NONE:")
            { return; }
            else
            {
                try { serialPort1.Close(); }
                catch { };
                closePortBtn.Enabled = false;
                openPortBtn.Enabled = true;
            }

            try
            {
                writeStream.Close();
            }
            catch { }
        }

        private void baud1200_Click(object sender, EventArgs e)
        {
            baud2400.Checked = false;
            baud4800.Checked = false;
            baud9600.Checked = false;
            baud1200.Checked = true;
            serialPort1.BaudRate = 1200;
        }

        private void baud2400_Click(object sender, EventArgs e)
        {
            baud2400.Checked = true;
            baud4800.Checked = false;
            baud9600.Checked = false;
            baud1200.Checked = false;
            serialPort1.BaudRate = 2400;
        }

        private void baud4800_Click(object sender, EventArgs e)
        {
            baud2400.Checked = false;
            baud4800.Checked = true;
            baud9600.Checked = false;
            baud1200.Checked = false;
            serialPort1.BaudRate = 4800;
        }

        private void baud9600_Click(object sender, EventArgs e)
        {
            baud2400.Checked = false;
            baud4800.Checked = false;
            baud9600.Checked = true;
            baud1200.Checked = false;
            serialPort1.BaudRate = 9600;
        }

        private void noneParity_Click(object sender, EventArgs e)
        {
            noneParity.Checked = true;
            oddParity.Checked = false;
            evenParity.Checked = false;
            serialPort1.Parity = System.IO.Ports.Parity.None;
        }

        private void oddParity_Click(object sender, EventArgs e)
        {
            noneParity.Checked = false;
            oddParity.Checked = true;
            evenParity.Checked = false;
            serialPort1.Parity = System.IO.Ports.Parity.Odd;
        }

        private void evenParity_Click(object sender, EventArgs e)
        {
            noneParity.Checked = false;
            oddParity.Checked = false;
            evenParity.Checked = true;
            serialPort1.Parity = System.IO.Ports.Parity.Even;
        }

        private void oneBitStop_Click(object sender, EventArgs e)
        {
            oneBitStop.Checked = true;
            twoBitStop.Checked = false;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            stopBits = 1;
        }

        private void twoBitStop_Click(object sender, EventArgs e)
        {
            oneBitStop.Checked = false;
            twoBitStop.Checked = true;
            serialPort1.StopBits = System.IO.Ports.StopBits.Two;
            stopBits = 2;
        }
    }
}
