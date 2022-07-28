
namespace Lab06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.portLabel = new System.Windows.Forms.ToolStripLabel();
            this.openPortBtn = new System.Windows.Forms.ToolStripButton();
            this.closePortBtn = new System.Windows.Forms.ToolStripButton();
            this.portConfigDrop = new System.Windows.Forms.ToolStripDropDownButton();
            this.pORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baud1200 = new System.Windows.Forms.ToolStripMenuItem();
            this.baud2400 = new System.Windows.Forms.ToolStripMenuItem();
            this.baud4800 = new System.Windows.Forms.ToolStripMenuItem();
            this.baud9600 = new System.Windows.Forms.ToolStripMenuItem();
            this.parityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneParity = new System.Windows.Forms.ToolStripMenuItem();
            this.oddParity = new System.Windows.Forms.ToolStripMenuItem();
            this.evenParity = new System.Windows.Forms.ToolStripMenuItem();
            this.wordSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopBitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneBitStop = new System.Windows.Forms.ToolStripMenuItem();
            this.twoBitStop = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendBtn = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.hexTitle = new System.Windows.Forms.Label();
            this.hexBox = new System.Windows.Forms.TextBox();
            this.asciiTitle = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.asciiBox = new System.Windows.Forms.TextBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.readLabelTitle = new System.Windows.Forms.ToolStripLabel();
            this.readLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sendLabelTitle = new System.Windows.Forms.ToolStripLabel();
            this.sendLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.recvLabelTitle = new System.Windows.Forms.ToolStripLabel();
            this.recvLabel = new System.Windows.Forms.ToolStripLabel();
            this.connIcon = new System.Windows.Forms.ToolStripButton();
            this.connLabelTitle = new System.Windows.Forms.ToolStripLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSelect,
            this.toolStripSeparator1,
            this.portLabel,
            this.openPortBtn,
            this.closePortBtn,
            this.portConfigDrop,
            this.clearBtn,
            this.toolStripSeparator2,
            this.sendBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(745, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileSelect
            // 
            this.fileSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileSelect.Image = ((System.Drawing.Image)(resources.GetObject("fileSelect.Image")));
            this.fileSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileSelect.Name = "fileSelect";
            this.fileSelect.Size = new System.Drawing.Size(89, 24);
            this.fileSelect.Text = "Select File...";
            this.fileSelect.Click += new System.EventHandler(this.fileSelect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // portLabel
            // 
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(83, 24);
            this.portLabel.Text = "Port NONE:";
            // 
            // openPortBtn
            // 
            this.openPortBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openPortBtn.Image = ((System.Drawing.Image)(resources.GetObject("openPortBtn.Image")));
            this.openPortBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openPortBtn.Name = "openPortBtn";
            this.openPortBtn.Size = new System.Drawing.Size(49, 24);
            this.openPortBtn.Text = "Open";
            this.openPortBtn.ToolTipText = "Opens the port.";
            this.openPortBtn.Click += new System.EventHandler(this.openPortBtn_Click);
            // 
            // closePortBtn
            // 
            this.closePortBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.closePortBtn.Enabled = false;
            this.closePortBtn.Image = ((System.Drawing.Image)(resources.GetObject("closePortBtn.Image")));
            this.closePortBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closePortBtn.Name = "closePortBtn";
            this.closePortBtn.Size = new System.Drawing.Size(49, 24);
            this.closePortBtn.Text = "Close";
            this.closePortBtn.ToolTipText = "Closes the port.";
            this.closePortBtn.Click += new System.EventHandler(this.closePortBtn_Click);
            // 
            // portConfigDrop
            // 
            this.portConfigDrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.portConfigDrop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pORTToolStripMenuItem,
            this.dataRateToolStripMenuItem,
            this.parityToolStripMenuItem,
            this.wordSizeToolStripMenuItem,
            this.stopBitsToolStripMenuItem});
            this.portConfigDrop.Image = ((System.Drawing.Image)(resources.GetObject("portConfigDrop.Image")));
            this.portConfigDrop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.portConfigDrop.Name = "portConfigDrop";
            this.portConfigDrop.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.portConfigDrop.Size = new System.Drawing.Size(44, 24);
            this.portConfigDrop.Text = "Config";
            this.portConfigDrop.ToolTipText = "Port config";
            // 
            // pORTToolStripMenuItem
            // 
            this.pORTToolStripMenuItem.Name = "pORTToolStripMenuItem";
            this.pORTToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.pORTToolStripMenuItem.Text = "PORT";
            this.pORTToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.pORTToolStripMenuItem_DropDownItemClicked);
            // 
            // dataRateToolStripMenuItem
            // 
            this.dataRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baud1200,
            this.baud2400,
            this.baud4800,
            this.baud9600});
            this.dataRateToolStripMenuItem.Name = "dataRateToolStripMenuItem";
            this.dataRateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataRateToolStripMenuItem.Text = "Data Rate...";
            // 
            // baud1200
            // 
            this.baud1200.Name = "baud1200";
            this.baud1200.Size = new System.Drawing.Size(224, 26);
            this.baud1200.Text = "1200";
            this.baud1200.Click += new System.EventHandler(this.baud1200_Click);
            // 
            // baud2400
            // 
            this.baud2400.Name = "baud2400";
            this.baud2400.Size = new System.Drawing.Size(224, 26);
            this.baud2400.Text = "2400";
            this.baud2400.Click += new System.EventHandler(this.baud2400_Click);
            // 
            // baud4800
            // 
            this.baud4800.Checked = true;
            this.baud4800.CheckState = System.Windows.Forms.CheckState.Checked;
            this.baud4800.Name = "baud4800";
            this.baud4800.Size = new System.Drawing.Size(224, 26);
            this.baud4800.Text = "4800";
            this.baud4800.Click += new System.EventHandler(this.baud4800_Click);
            // 
            // baud9600
            // 
            this.baud9600.Name = "baud9600";
            this.baud9600.Size = new System.Drawing.Size(224, 26);
            this.baud9600.Text = "9600";
            this.baud9600.Click += new System.EventHandler(this.baud9600_Click);
            // 
            // parityToolStripMenuItem
            // 
            this.parityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneParity,
            this.oddParity,
            this.evenParity});
            this.parityToolStripMenuItem.Name = "parityToolStripMenuItem";
            this.parityToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.parityToolStripMenuItem.Text = "Parity...";
            // 
            // noneParity
            // 
            this.noneParity.Checked = true;
            this.noneParity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noneParity.Name = "noneParity";
            this.noneParity.Size = new System.Drawing.Size(224, 26);
            this.noneParity.Text = "none";
            this.noneParity.Click += new System.EventHandler(this.noneParity_Click);
            // 
            // oddParity
            // 
            this.oddParity.Name = "oddParity";
            this.oddParity.Size = new System.Drawing.Size(224, 26);
            this.oddParity.Text = "odd";
            this.oddParity.Click += new System.EventHandler(this.oddParity_Click);
            // 
            // evenParity
            // 
            this.evenParity.Name = "evenParity";
            this.evenParity.Size = new System.Drawing.Size(224, 26);
            this.evenParity.Text = "even";
            this.evenParity.Click += new System.EventHandler(this.evenParity_Click);
            // 
            // wordSizeToolStripMenuItem
            // 
            this.wordSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitsToolStripMenuItem});
            this.wordSizeToolStripMenuItem.Name = "wordSizeToolStripMenuItem";
            this.wordSizeToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.wordSizeToolStripMenuItem.Text = "Word Size...";
            this.wordSizeToolStripMenuItem.Click += new System.EventHandler(this.wordSizeToolStripMenuItem_Click);
            // 
            // bitsToolStripMenuItem
            // 
            this.bitsToolStripMenuItem.Checked = true;
            this.bitsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bitsToolStripMenuItem.Name = "bitsToolStripMenuItem";
            this.bitsToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.bitsToolStripMenuItem.Text = "8 bits";
            // 
            // stopBitsToolStripMenuItem
            // 
            this.stopBitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneBitStop,
            this.twoBitStop});
            this.stopBitsToolStripMenuItem.Name = "stopBitsToolStripMenuItem";
            this.stopBitsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stopBitsToolStripMenuItem.Text = "Stop Bits...";
            // 
            // oneBitStop
            // 
            this.oneBitStop.Checked = true;
            this.oneBitStop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.oneBitStop.Name = "oneBitStop";
            this.oneBitStop.Size = new System.Drawing.Size(224, 26);
            this.oneBitStop.Text = "1 bit";
            this.oneBitStop.Click += new System.EventHandler(this.oneBitStop_Click);
            // 
            // twoBitStop
            // 
            this.twoBitStop.Name = "twoBitStop";
            this.twoBitStop.Size = new System.Drawing.Size(224, 26);
            this.twoBitStop.Text = "2 bits";
            this.twoBitStop.Click += new System.EventHandler(this.twoBitStop_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.clearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(106, 24);
            this.clearBtn.Text = "Clear Displays";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // sendBtn
            // 
            this.sendBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sendBtn.Image = ((System.Drawing.Image)(resources.GetObject("sendBtn.Image")));
            this.sendBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(29, 24);
            this.sendBtn.Text = "sendBtn";
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.hexTitle);
            this.splitContainer1.Panel1.Controls.Add(this.hexBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.asciiTitle);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Panel2.Controls.Add(this.asciiBox);
            this.splitContainer1.Size = new System.Drawing.Size(745, 376);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 1;
            // 
            // hexTitle
            // 
            this.hexTitle.AutoSize = true;
            this.hexTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hexTitle.Location = new System.Drawing.Point(12, 3);
            this.hexTitle.Name = "hexTitle";
            this.hexTitle.Size = new System.Drawing.Size(169, 28);
            this.hexTitle.TabIndex = 1;
            this.hexTitle.Text = "Hexadecimal View";
            // 
            // hexBox
            // 
            this.hexBox.Location = new System.Drawing.Point(3, 37);
            this.hexBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hexBox.Multiline = true;
            this.hexBox.Name = "hexBox";
            this.hexBox.Size = new System.Drawing.Size(242, 290);
            this.hexBox.TabIndex = 0;
            // 
            // asciiTitle
            // 
            this.asciiTitle.AutoSize = true;
            this.asciiTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.asciiTitle.Location = new System.Drawing.Point(12, 3);
            this.asciiTitle.Name = "asciiTitle";
            this.asciiTitle.Size = new System.Drawing.Size(104, 28);
            this.asciiTitle.TabIndex = 3;
            this.asciiTitle.Text = "ASCII View";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Location = new System.Drawing.Point(0, 351);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(493, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // asciiBox
            // 
            this.asciiBox.Location = new System.Drawing.Point(3, 37);
            this.asciiBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.asciiBox.Multiline = true;
            this.asciiBox.Name = "asciiBox";
            this.asciiBox.Size = new System.Drawing.Size(487, 290);
            this.asciiBox.TabIndex = 1;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readLabelTitle,
            this.readLabel,
            this.toolStripSeparator3,
            this.sendLabelTitle,
            this.sendLabel,
            this.toolStripSeparator4,
            this.recvLabelTitle,
            this.recvLabel,
            this.connIcon,
            this.connLabelTitle});
            this.toolStrip3.Location = new System.Drawing.Point(0, 376);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(745, 27);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // readLabelTitle
            // 
            this.readLabelTitle.Name = "readLabelTitle";
            this.readLabelTitle.Size = new System.Drawing.Size(46, 24);
            this.readLabelTitle.Text = "Read:";
            // 
            // readLabel
            // 
            this.readLabel.Name = "readLabel";
            this.readLabel.Size = new System.Drawing.Size(51, 24);
            this.readLabel.Text = "no file";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // sendLabelTitle
            // 
            this.sendLabelTitle.Name = "sendLabelTitle";
            this.sendLabelTitle.Size = new System.Drawing.Size(45, 24);
            this.sendLabelTitle.Text = "Send:";
            // 
            // sendLabel
            // 
            this.sendLabel.Name = "sendLabel";
            this.sendLabel.Size = new System.Drawing.Size(58, 24);
            this.sendLabel.Text = "waiting";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // recvLabelTitle
            // 
            this.recvLabelTitle.Name = "recvLabelTitle";
            this.recvLabelTitle.Size = new System.Drawing.Size(63, 24);
            this.recvLabelTitle.Text = "Receive:";
            // 
            // recvLabel
            // 
            this.recvLabel.Name = "recvLabel";
            this.recvLabel.Size = new System.Drawing.Size(58, 24);
            this.recvLabel.Text = "waiting";
            // 
            // connIcon
            // 
            this.connIcon.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.connIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.connIcon.Image = global::Lab06.Properties.Resources.StatusAnnotation_No_16xLG;
            this.connIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connIcon.Name = "connIcon";
            this.connIcon.Size = new System.Drawing.Size(29, 24);
            this.connIcon.Text = "toolStripButton1";
            // 
            // connLabelTitle
            // 
            this.connLabelTitle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.connLabelTitle.Name = "connLabelTitle";
            this.connLabelTitle.Size = new System.Drawing.Size(87, 24);
            this.connLabelTitle.Text = "Connection:";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 403);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "COM File Send/Receive";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton fileSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripLabel portLabel;
        private System.Windows.Forms.ToolStripButton openPortBtn;
        private System.Windows.Forms.ToolStripButton closePortBtn;
        private System.Windows.Forms.ToolStripDropDownButton portConfigDrop;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox hexBox;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.TextBox asciiBox;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel readLabelTitle;
        private System.Windows.Forms.ToolStripLabel readLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel sendLabelTitle;
        private System.Windows.Forms.ToolStripLabel sendLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel recvLabelTitle;
        private System.Windows.Forms.ToolStripLabel recvLabel;
        private System.Windows.Forms.ToolStripButton clearBtn;
        private System.Windows.Forms.Label hexTitle;
        private System.Windows.Forms.Label asciiTitle;
        private System.Windows.Forms.ToolStripButton connIcon;
        private System.Windows.Forms.ToolStripLabel connLabelTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton sendBtn;
        private System.Windows.Forms.ToolStripMenuItem dataRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordSizeToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripMenuItem baud1200;
        private System.Windows.Forms.ToolStripMenuItem baud2400;
        private System.Windows.Forms.ToolStripMenuItem baud4800;
        private System.Windows.Forms.ToolStripMenuItem baud9600;
        private System.Windows.Forms.ToolStripMenuItem noneParity;
        private System.Windows.Forms.ToolStripMenuItem oddParity;
        private System.Windows.Forms.ToolStripMenuItem evenParity;
        private System.Windows.Forms.ToolStripMenuItem bitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopBitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneBitStop;
        private System.Windows.Forms.ToolStripMenuItem twoBitStop;
        private System.Windows.Forms.ToolStripMenuItem pORTToolStripMenuItem;
    }
}

