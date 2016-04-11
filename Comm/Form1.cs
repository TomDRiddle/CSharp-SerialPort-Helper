using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;


namespace Comm
{
    
    public partial class Form1 : Form
    {
        static bool PortIsOpen = false;
        public Form1()
        {
            InitializeComponent();
            CheckBitChoose.Text = "NONE";
            StopBitChoose.Text = "1";
            DataBitChoose.Text = "8";
            BaudrateChoose.Text = "115200";
            SaveFilePath.Visible = false;
            ChooseFile.Visible = false;
            CheckForIllegalCrossThreadCalls = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                SaveFileDialog savefilepath = new SaveFileDialog();
                savefilepath.Filter = "(*.txt)|*.txt|(*.*)|*.*";
                savefilepath.AddExtension = true;
                if (savefilepath.ShowDialog() == DialogResult.OK)
                {
                    SaveFilePath.Text = savefilepath.FileName;
                }           
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
  
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] sendbuff = new byte[1];
            if (PortIsOpen==true)
            {
                if(SendArea.Text!="")
                {
                    try
                    {
                        if (!HexSend.Checked)
                        {
                            serialPort1.Write(SendArea.Text);
                            //字符发送
                        }
                        else
                        {
                            for(int i=0;i<(SendArea.Text.Length-SendArea.Text.Length%2)/2;i++)
                            {
                                sendbuff[0] = Convert.ToByte(SendArea.Text.Substring(i * 2, 2), 16);
                                serialPort1.Write(sendbuff, 0, 1);
                            }
                            if(SendArea.Text.Length%2!=0)
                            {
                                sendbuff[0] = Convert.ToByte(SendArea.Text.Substring(SendArea.Text.Length - SendArea.Text.Length % 2, SendArea.Text.Length % 2));
                                serialPort1.Write(sendbuff, 0, 1);
                            }
                            //十六进制发送，先分开每两位一组发送，如果为奇数位，则最后一位单独发送
                            string temp = SendArea.Text;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("发送数据错误");
                        serialPort1.Close();
                        PortIsOpen = false;
                        OpenPortButton.Text = "打开串口";
                    }
                }
      
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFilePath = new OpenFileDialog();
            OpenFilePath.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            OpenFilePath.AddExtension = true;
            if (OpenFilePath.ShowDialog() == DialogResult.OK)
            {
                SendFileName.Text = OpenFilePath.FileName;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void File_TextChanged(object sender, EventArgs e)
        {

        }

        private void BaudrateChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DataBitChoose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OpenPort_Click(object sender, EventArgs e)
        {
            int PortBaudrate, PortDataBits;
            Parity PortParity;
            StopBits PortStopBits;
            if (!PortIsOpen)
            {
                PortBaudrate = Convert.ToInt32(BaudrateChoose.Text);
                PortDataBits = Convert.ToInt32(DataBitChoose.Text);
                PortParity = (Parity)Enum.Parse(typeof(Parity), CheckBitChoose.Text);
                PortStopBits = (StopBits)Enum.Parse(typeof(StopBits), StopBitChoose.Text);
                //获取串口设置
                try
                {
                    serialPort1.PortName = COMChoose.Text;
                    serialPort1.BaudRate = PortBaudrate;
                    serialPort1.DataBits = PortDataBits;
                    serialPort1.Parity = PortParity;
                    serialPort1.StopBits = PortStopBits;
                    //设置串口
                }
                catch
                {
                    MessageBox.Show("串口设置错误");
                    PortIsOpen = false;
                    OpenPortButton.Text = "打开串口";
                    return;
                }

                try
                {
                    serialPort1.Open();
                    PortIsOpen = true;
                    OpenPortButton.Text = "关闭串口";
                }
                catch
                {
                    MessageBox.Show("打开串口失败，请检查串口是否被占用");
                    PortIsOpen = false;
                    OpenPortButton.Text = "打开串口";
                }
            }
            else
            {
                serialPort1.Close();
                PortIsOpen = false;
                OpenPortButton.Text = "打开串口";
            }
        }

        private void ClearReceive_Click(object sender, EventArgs e)
        {
            ReceiveArea.Clear();
        }

        private void ClearSendArea_Click(object sender, EventArgs e)
        {
            SendArea.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PutIntoFile_CheckedChanged(object sender, EventArgs e)
        {
            if(PutIntoFile.Checked)
            {
                SaveFilePath.Visible = true;
                ChooseFile.Visible = true;
            }
            else
            {
                SaveFilePath.Visible = false;
                ChooseFile.Visible = false;
            }
        }
        private void Port_DataRecevied(object sender,SerialDataReceivedEventArgs e)
        {
            //串口接收事件
            if(!PutIntoFile.Checked)
            {
                if (!Hexshow.Checked)
                {
                    string str = serialPort1.ReadExisting();
                    ReceiveArea.AppendText(str);
                    //正常接收
                }
                else
                {
                    byte data;
                    data = (byte)serialPort1.ReadByte();
                    string datareceive = Convert.ToString(data, 16).ToUpper();
                    ReceiveArea.AppendText("0x" + (datareceive.Length == 1 ? "0" + datareceive : " "));
                    //十六进制接收，分开，填“0x”
                }
            }
            else
            {
                //接收到文件，方式同上
                if (!Hexshow.Checked)
                {
                    string datareceive = serialPort1.ReadExisting();
                    File.AppendAllText(SaveFilePath.Text, datareceive);
                }
                else
                {
                    byte data;
                    data = (byte)serialPort1.ReadByte();
                    string datareceive = Convert.ToString(data, 16).ToUpper();
                    File.AppendAllText(SaveFilePath.Text, "0x" + (datareceive.Length == 1 ? "0" + datareceive : " "));
                }
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(Port_DataRecevied);
            //接收事件委托
        }

        private void SendFile_Click(object sender, EventArgs e)
        {
            //从文件发送
            int SendBit = Convert.ToInt32(ByteNum.Text);
            int WaitTime = Convert.ToInt32(Time.Text);
            int i;
            byte[] str = File.ReadAllBytes(SendFileName.Text);
            try
            {
                for (i = 0; i < (str.Length/SendBit); i++)
                {
                    serialPort1.Write(str, i , SendBit);
                    Thread.Sleep(WaitTime);
                }
                serialPort1.Write(str, i, str.Length - (str.Length / SendBit) * SendBit);
            }
            catch
            {
                MessageBox.Show("发送数据错误");
                serialPort1.Close();
                PortIsOpen = false;
                OpenPortButton.Text = "打开串口";
            }
            
        }
    }
}
