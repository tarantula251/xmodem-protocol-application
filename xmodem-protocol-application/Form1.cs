using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;
using System.Threading;
using xmodem_protocol_application.TransmitterStates;
using xmodem_protocol_application.ReceiverStates;

namespace xmodem_protocol_application
{
    public partial class Form1 : Form
    {
        public static byte ACK = 6;
        public static byte CAN = 24;
        public static byte EOT = 4;
        public static byte NAK = 21;
        public static byte SOH = 1;
        public static byte C = (byte) 'C';
        public int receiverTimeoutMillisec = 10000;
        public int receiverMaxRetriesCount = 6;
        public bool checkSumChoice = false;
        public bool crcChoice = false;
        private FileStream inputFile = null;
        public FileStream InputFile
        {
            get
            {
                return inputFile;
            }

            set
            {
                inputFile = value;               
            }

        }
        private FileStream outputFile = null;
        public FileStream OutputFile
        {
            get
            {
                return outputFile;
            }

            set
            {
                outputFile = value;
            }

        }

        private TransmitterState transmitterState = new InitialTransmitterState();
        public TransmitterState StateTransmitter
        {
            get
            {
                return transmitterState;
            }

            set
            {
                transmitterState = value;
                transmitterState.initialize(this);
            }
        }
        private ReceiverState receiverState = new InitialReceiverState();
        public ReceiverState StateReceiver
        {
            get
            {
                return receiverState;
            }

            set
            {
                receiverState = value;
                receiverState.initialize(this);
            }
        }

        public void writeToTransmitterConsole(String data)
        {
            this.Invoke((MethodInvoker)delegate
            {
                listBoxReceivedDataPort1.Items.Add(data);
            });
        }

        public void writeToReceiverConsole(String data)
        {
            this.Invoke((MethodInvoker)delegate
            {
                listBoxReceivedDataPort2.Items.Add(data);
            });
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenConnection1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = textBoxPort1.Text;
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    listBoxReceivedDataPort1.Items.Add("Port " + serialPort1.PortName + " is open.");
                }
            }
            catch (System.ArgumentException exception)
            {
                listBoxReceivedDataPort1.Items.Add(exception.Message);
            }
        }

        private void buttonOpenConnection2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort2.PortName = textBoxPort2.Text;
                serialPort2.Open();
                if (serialPort2.IsOpen)
                {
                    receiverState.initialize(this);
                    listBoxReceivedDataPort2.Items.Add("Port " + serialPort2.PortName + " is open.");
                }
            }
            catch (System.ArgumentException exception)
            {
                listBoxReceivedDataPort2.Items.Add(exception.Message);
            }
        }


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            transmitterState.handleSignal(this, (byte) serialPort1.ReadByte());
        }    

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            receiverState.handleSignal(this, (byte)serialPort2.ReadByte());
        }

        private void buttonBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                textBoxInputData1.Text = openFileDialog.FileName;
                inputFile = new FileStream(textBoxInputData1.Text, FileMode.Open);
            }
        }

        private void buttonBrowseData2_Click(object sender, EventArgs e)
        {
            SaveFileDialog openFileDialog = new SaveFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxInputData2.Text = openFileDialog.FileName;
                outputFile = new FileStream(textBoxInputData2.Text, FileMode.OpenOrCreate);                
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                checkSumChoice = true;
            else
                checkSumChoice = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                crcChoice = true;
            else
                crcChoice = false;
        }
    }
}

