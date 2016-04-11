namespace Comm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OpenPortButton = new System.Windows.Forms.Button();
            this.BaudrateChoose = new System.Windows.Forms.ComboBox();
            this.StopBitChoose = new System.Windows.Forms.ComboBox();
            this.DataBitChoose = new System.Windows.Forms.ComboBox();
            this.COMChoose = new System.Windows.Forms.ComboBox();
            this.CheckBitChoose = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveFilePath = new System.Windows.Forms.TextBox();
            this.ClearReceive = new System.Windows.Forms.Button();
            this.PutIntoFile = new System.Windows.Forms.CheckBox();
            this.ChooseFile = new System.Windows.Forms.Button();
            this.Hexshow = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReceiveArea = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.HexSend = new System.Windows.Forms.CheckBox();
            this.Send = new System.Windows.Forms.Button();
            this.ClearSendArea = new System.Windows.Forms.Button();
            this.SendArea = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.TextBox();
            this.ByteNum = new System.Windows.Forms.TextBox();
            this.SendFile = new System.Windows.Forms.Button();
            this.OpenSendFile = new System.Windows.Forms.Button();
            this.SendFileName = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gb1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenPortButton
            // 
            this.OpenPortButton.Location = new System.Drawing.Point(8, 150);
            this.OpenPortButton.Name = "OpenPortButton";
            this.OpenPortButton.Size = new System.Drawing.Size(126, 23);
            this.OpenPortButton.TabIndex = 0;
            this.OpenPortButton.Text = "打开串口";
            this.OpenPortButton.UseVisualStyleBackColor = true;
            this.OpenPortButton.Click += new System.EventHandler(this.OpenPort_Click);
            // 
            // BaudrateChoose
            // 
            this.BaudrateChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudrateChoose.FormattingEnabled = true;
            this.BaudrateChoose.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.BaudrateChoose.Location = new System.Drawing.Point(53, 46);
            this.BaudrateChoose.Name = "BaudrateChoose";
            this.BaudrateChoose.Size = new System.Drawing.Size(81, 20);
            this.BaudrateChoose.TabIndex = 2;
            this.BaudrateChoose.SelectedIndexChanged += new System.EventHandler(this.BaudrateChoose_SelectedIndexChanged);
            // 
            // StopBitChoose
            // 
            this.StopBitChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBitChoose.FormattingEnabled = true;
            this.StopBitChoose.Items.AddRange(new object[] {
            "1",
            "2"});
            this.StopBitChoose.Location = new System.Drawing.Point(53, 124);
            this.StopBitChoose.Name = "StopBitChoose";
            this.StopBitChoose.Size = new System.Drawing.Size(81, 20);
            this.StopBitChoose.TabIndex = 3;
            this.StopBitChoose.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // DataBitChoose
            // 
            this.DataBitChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBitChoose.FormattingEnabled = true;
            this.DataBitChoose.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.DataBitChoose.Location = new System.Drawing.Point(53, 72);
            this.DataBitChoose.Name = "DataBitChoose";
            this.DataBitChoose.Size = new System.Drawing.Size(81, 20);
            this.DataBitChoose.TabIndex = 4;
            this.DataBitChoose.SelectedIndexChanged += new System.EventHandler(this.DataBitChoose_SelectedIndexChanged);
            // 
            // COMChoose
            // 
            this.COMChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMChoose.FormattingEnabled = true;
            this.COMChoose.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.COMChoose.Location = new System.Drawing.Point(53, 20);
            this.COMChoose.Name = "COMChoose";
            this.COMChoose.Size = new System.Drawing.Size(81, 20);
            this.COMChoose.TabIndex = 5;
            this.COMChoose.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // CheckBitChoose
            // 
            this.CheckBitChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CheckBitChoose.FormattingEnabled = true;
            this.CheckBitChoose.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.CheckBitChoose.Location = new System.Drawing.Point(53, 98);
            this.CheckBitChoose.Name = "CheckBitChoose";
            this.CheckBitChoose.Size = new System.Drawing.Size(81, 20);
            this.CheckBitChoose.TabIndex = 6;
            this.CheckBitChoose.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "端  口";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "波特率";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "数据位";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "校验位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "停止位";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.COMChoose);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.OpenPortButton);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.StopBitChoose);
            this.gb1.Controls.Add(this.CheckBitChoose);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.DataBitChoose);
            this.gb1.Controls.Add(this.BaudrateChoose);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(144, 185);
            this.gb1.TabIndex = 12;
            this.gb1.TabStop = false;
            this.gb1.Text = "串口配置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveFilePath);
            this.groupBox1.Controls.Add(this.ClearReceive);
            this.groupBox1.Controls.Add(this.PutIntoFile);
            this.groupBox1.Controls.Add(this.ChooseFile);
            this.groupBox1.Controls.Add(this.Hexshow);
            this.groupBox1.Location = new System.Drawing.Point(12, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 333);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口辅助";
            // 
            // SaveFilePath
            // 
            this.SaveFilePath.Location = new System.Drawing.Point(8, 64);
            this.SaveFilePath.Name = "SaveFilePath";
            this.SaveFilePath.Size = new System.Drawing.Size(126, 21);
            this.SaveFilePath.TabIndex = 4;
            this.SaveFilePath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ClearReceive
            // 
            this.ClearReceive.Location = new System.Drawing.Point(8, 120);
            this.ClearReceive.Name = "ClearReceive";
            this.ClearReceive.Size = new System.Drawing.Size(126, 23);
            this.ClearReceive.TabIndex = 3;
            this.ClearReceive.Text = "清空接收区";
            this.ClearReceive.UseVisualStyleBackColor = true;
            this.ClearReceive.Click += new System.EventHandler(this.ClearReceive_Click);
            // 
            // PutIntoFile
            // 
            this.PutIntoFile.AutoSize = true;
            this.PutIntoFile.Location = new System.Drawing.Point(8, 42);
            this.PutIntoFile.Name = "PutIntoFile";
            this.PutIntoFile.Size = new System.Drawing.Size(108, 16);
            this.PutIntoFile.TabIndex = 2;
            this.PutIntoFile.Text = "接收数据到文件";
            this.PutIntoFile.UseVisualStyleBackColor = true;
            this.PutIntoFile.CheckedChanged += new System.EventHandler(this.PutIntoFile_CheckedChanged);
            // 
            // ChooseFile
            // 
            this.ChooseFile.Location = new System.Drawing.Point(8, 91);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(126, 23);
            this.ChooseFile.TabIndex = 1;
            this.ChooseFile.Text = "选择文件";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hexshow
            // 
            this.Hexshow.AutoSize = true;
            this.Hexshow.Location = new System.Drawing.Point(8, 20);
            this.Hexshow.Name = "Hexshow";
            this.Hexshow.Size = new System.Drawing.Size(84, 16);
            this.Hexshow.TabIndex = 0;
            this.Hexshow.Text = "16进制显示";
            this.Hexshow.UseVisualStyleBackColor = true;
            this.Hexshow.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReceiveArea);
            this.groupBox2.Location = new System.Drawing.Point(163, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 248);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收区";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ReceiveArea
            // 
            this.ReceiveArea.Location = new System.Drawing.Point(7, 19);
            this.ReceiveArea.Multiline = true;
            this.ReceiveArea.Name = "ReceiveArea";
            this.ReceiveArea.ReadOnly = true;
            this.ReceiveArea.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ReceiveArea.Size = new System.Drawing.Size(610, 223);
            this.ReceiveArea.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(163, 267);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 269);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.HexSend);
            this.tabPage1.Controls.Add(this.Send);
            this.tabPage1.Controls.Add(this.ClearSendArea);
            this.tabPage1.Controls.Add(this.SendArea);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(615, 243);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "单项发送";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // HexSend
            // 
            this.HexSend.AutoSize = true;
            this.HexSend.Location = new System.Drawing.Point(363, 218);
            this.HexSend.Name = "HexSend";
            this.HexSend.Size = new System.Drawing.Size(84, 16);
            this.HexSend.TabIndex = 4;
            this.HexSend.Text = "16进制发送";
            this.HexSend.UseVisualStyleBackColor = true;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(534, 214);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 3;
            this.Send.Text = "发送";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.button3_Click);
            // 
            // ClearSendArea
            // 
            this.ClearSendArea.Location = new System.Drawing.Point(453, 214);
            this.ClearSendArea.Name = "ClearSendArea";
            this.ClearSendArea.Size = new System.Drawing.Size(75, 23);
            this.ClearSendArea.TabIndex = 2;
            this.ClearSendArea.Text = "清空发送区";
            this.ClearSendArea.UseVisualStyleBackColor = true;
            this.ClearSendArea.Click += new System.EventHandler(this.ClearSendArea_Click);
            // 
            // SendArea
            // 
            this.SendArea.Location = new System.Drawing.Point(2, 3);
            this.SendArea.Multiline = true;
            this.SendArea.Name = "SendArea";
            this.SendArea.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.SendArea.Size = new System.Drawing.Size(610, 205);
            this.SendArea.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Time);
            this.tabPage2.Controls.Add(this.ByteNum);
            this.tabPage2.Controls.Add(this.SendFile);
            this.tabPage2.Controls.Add(this.OpenSendFile);
            this.tabPage2.Controls.Add(this.SendFileName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(615, 243);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "发送文件";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "发送时间间隔（ms）：";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "每次发送字节数：";
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(360, 42);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(100, 21);
            this.Time.TabIndex = 4;
            this.Time.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // ByteNum
            // 
            this.ByteNum.Location = new System.Drawing.Point(113, 42);
            this.ByteNum.Name = "ByteNum";
            this.ByteNum.Size = new System.Drawing.Size(100, 21);
            this.ByteNum.TabIndex = 3;
            this.ByteNum.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // SendFile
            // 
            this.SendFile.Location = new System.Drawing.Point(534, 9);
            this.SendFile.Name = "SendFile";
            this.SendFile.Size = new System.Drawing.Size(75, 23);
            this.SendFile.TabIndex = 2;
            this.SendFile.Text = "发送文件";
            this.SendFile.UseVisualStyleBackColor = true;
            this.SendFile.Click += new System.EventHandler(this.SendFile_Click);
            // 
            // OpenSendFile
            // 
            this.OpenSendFile.Location = new System.Drawing.Point(453, 9);
            this.OpenSendFile.Name = "OpenSendFile";
            this.OpenSendFile.Size = new System.Drawing.Size(75, 23);
            this.OpenSendFile.TabIndex = 1;
            this.OpenSendFile.Text = "打开文件";
            this.OpenSendFile.UseVisualStyleBackColor = true;
            this.OpenSendFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // SendFileName
            // 
            this.SendFileName.Location = new System.Drawing.Point(7, 9);
            this.SendFileName.Name = "SendFileName";
            this.SendFileName.Size = new System.Drawing.Size(440, 21);
            this.SendFileName.TabIndex = 0;
            this.SendFileName.TextChanged += new System.EventHandler(this.File_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 548);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb1);
            this.Name = "Form1";
            this.Text = "串口调试助手V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenPortButton;
        private System.Windows.Forms.ComboBox BaudrateChoose;
        private System.Windows.Forms.ComboBox StopBitChoose;
        private System.Windows.Forms.ComboBox DataBitChoose;
        private System.Windows.Forms.ComboBox COMChoose;
        private System.Windows.Forms.ComboBox CheckBitChoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.CheckBox Hexshow;
        private System.Windows.Forms.CheckBox PutIntoFile;
        private System.Windows.Forms.Button ClearReceive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ReceiveArea;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button ClearSendArea;
        private System.Windows.Forms.TextBox SendArea;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button OpenSendFile;
        private System.Windows.Forms.TextBox SendFileName;
        private System.Windows.Forms.Button SendFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox ByteNum;
        private System.Windows.Forms.Label label7;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox SaveFilePath;
        private System.Windows.Forms.CheckBox HexSend;
    }
}

