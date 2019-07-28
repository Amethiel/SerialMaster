using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialMaster
{
    public partial class SerialMaster : Form
    {
        public delegate void DataReceiveEventHandler(byte[] data);
        public event DataReceiveEventHandler dataReceived;

        private static SerialPort serialPort;

        public SerialMaster()
        {
            InitializeComponent();
        }

        public byte[] HexStringToArray(string str)
        {
            byte[] bytes = new byte[str.Length / 2];

            for(int i = 0; i < str.Length / 2; i++ )
            {
                bytes[i] = (byte)Convert.ToInt32(str.Substring(i * 2, 2), 16);
            }
            return bytes;
        }

        private bool validataText(string text)
        {
            return Regex.IsMatch(text, "^([a-fA-F0-9]{2})*$");
        }

        private void OnBtnSend_Click(object sender, EventArgs e)
        {
            string text = txtSend.Text;
            if (validataText(text))
            {
                SetStatus("正在发送数据...");

                byte[] buffer = HexStringToArray(text);
                serialPort.Write(buffer, 0, buffer.Length);
                SetStatus("数据已发送");
            }
            else
            {
                SetStatus("要发送的数据不合法，请改正");
            }
        }

        private void SerialMaster_Load(object sender, EventArgs e)
        {
            SetStatus("正在初始化...");

            cbName.Items.AddRange(SerialPort.GetPortNames());
            cbName.SelectedIndex = 0;
            cbBaudRate.SelectedItem = "9600";
            cbDataBits.SelectedItem = "8";
            cbStopBits.SelectedIndex = 0;
            cbParity.SelectedIndex = 0;
            cbHandshake.SelectedIndex = 0;
            cbEncoding.SelectedIndex = 0;

            dataReceived += OnDataReceived;
            SetStatus("就绪");
        }

        private void OnDataReceived(byte[] data)
        {
            foreach (byte singleByte in data)
            {
                txtReceive.Text += singleByte.ToString("X2");
            }
        }

        private void receiveData(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] buffer = new byte[serialPort.BytesToRead];
            serialPort.Read(buffer, 0, buffer.Length);

            Invoke(dataReceived, buffer);
        }

        private void UpdateUI(bool isOpen)
        {
            btnOpen.Enabled = !isOpen;
            btnClose.Enabled = isOpen;

            cbName.Enabled = !isOpen;
            cbBaudRate.Enabled = !isOpen;
            cbDataBits.Enabled = !isOpen;
            cbStopBits.Enabled = !isOpen;
            cbParity.Enabled = !isOpen;
            cbHandshake.Enabled = !isOpen;
            cbEncoding.Enabled = !isOpen;

            gbSendData.Enabled = isOpen;
            gbReceiveData.Enabled = isOpen;

            if (isOpen)
            {
                SetStatus("端口已打开，正在接收数据...");
            }
            else
            {
                SetStatus("端口已关闭");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            serialPort = new SerialPort();
            serialPort.PortName = (string)cbName.SelectedItem;
            serialPort.BaudRate = int.Parse((string)cbBaudRate.SelectedItem);
            serialPort.DataBits = int.Parse((string)cbDataBits.SelectedItem);
            if (cbStopBits.SelectedIndex == 2)
            {
                serialPort.StopBits = StopBits.Two;
            }
            else if (cbStopBits.SelectedIndex == 1)
            {
                serialPort.StopBits = StopBits.OnePointFive;
            }
            else
            {
                serialPort.StopBits = StopBits.One;
            }
            serialPort.Parity = (Parity)cbParity.SelectedIndex;
            serialPort.Handshake = (Handshake)cbHandshake.SelectedIndex;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(receiveData);

            try
            {
                serialPort.Open();

                UpdateUI(true);
            }
            catch(Exception exception)
            {
                SetStatus("串口打开失败：" + exception.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if ((serialPort != null) && serialPort.IsOpen)
            {
                serialPort.Close();
            }

            UpdateUI(false);
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtReceive.Text, true);
            SetStatus("已将接收区域的数据复制到系统剪贴板");
        }

        private void timerStatusChanged_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = "就绪";
        }

        private void SetStatus(string msg)
        {
            timerStatusChanged.Stop();
            lblStatus.Text = msg;
            timerStatusChanged.Start();
        }

        private void btnClearSendText_Click(object sender, EventArgs e)
        {
            txtSend.Clear();
        }

        private void btnClearReceiveText_Click(object sender, EventArgs e)
        {
            txtReceive.Clear();
        }

        private void OnTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && !e.Alt && !e.Shift && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

    }
}
