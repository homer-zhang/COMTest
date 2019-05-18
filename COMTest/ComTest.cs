using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMTest
{
    public partial class ComTest : Form
    {
        SerialPort serialPort;
        public delegate void AddLog(string text);
        public ComTest()
        {
            InitializeComponent();
            serialPort = new SerialPort();

        }
        private void ComTest_Load(object sender, EventArgs e)
        {
            foreach(var prot in SerialPort.GetPortNames())
            {
                comboBox_ComList.Items.Add(prot);
            }
            if (comboBox_ComList.Items.Count > 0)
                comboBox_ComList.SelectedIndex = 0;

            comboBox_Rate.Items.Add("2400");
            comboBox_Rate.Items.Add("4800");
            comboBox_Rate.Items.Add("9600");

            comboBox_Rate.SelectedIndex = 0;

            textBox_DateBit.Text = "8";
        }

        private void ComTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
                serialPort.Close();
        }

        public void SerialDataReceived(object sender , SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            if (sp.IsOpen)
            {
                int length = sp.BytesToRead;
                byte[] data = new byte[sp.BytesToRead];
                sp.Read(data, 0, sp.BytesToRead);
                string s = Encoding.ASCII.GetString(data);
                if (data[length - 1] == 13)
                    s += "\n";
                ShowText(s);
            }
        }

        public void ShowText(string text)
        {
            if (textBox_DataRecv.InvokeRequired)
            {
                this.Invoke(new AddLog(ShowText), text);
            }
            else
            {
                textBox_DataRecv.Text += text;
            }
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();

                comboBox_ComList.Enabled = true;
                comboBox_Rate.Enabled = true;
                textBox_DateBit.Enabled = true;
                textBox_DateSend.Enabled = false;
                textBox_DataRecv.Enabled = false;
                button_Send.Enabled = false;

                button_Open.Text = "打开";
            }   
            else
            {
                try
                {
                    serialPort.PortName = comboBox_ComList.Text;
                    serialPort.BaudRate = int.Parse(comboBox_Rate.Text);
                    serialPort.DataBits = int.Parse(textBox_DateBit.Text);
                    serialPort.Handshake = Handshake.None;
                    serialPort.ReceivedBytesThreshold = 1;
                    serialPort.StopBits = StopBits.One;
 
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceived);

                    serialPort.Open();

                    comboBox_ComList.Enabled = false;
                    comboBox_Rate.Enabled = false;
                    textBox_DateBit.Enabled = false;
                    textBox_DateSend.Enabled = true;
                    textBox_DataRecv.Enabled = true;
                    button_Send.Enabled = true;

                    button_Open.Text = "关闭";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.WriteLine(textBox_DateSend.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
