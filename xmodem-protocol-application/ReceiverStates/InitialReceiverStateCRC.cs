using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.ComponentModel;

namespace xmodem_protocol_application.ReceiverStates
{
    public class InitialReceiverStateCRC : ReceiverState
    {
        private int packetNumber = 0;
        private int receiverTimeoutMillisec = 10000;
        private int receiverMaxRetriesCount = 6;
        private volatile bool receivingData = false;
        private Form1 form;
        private BackgroundWorker backgroundWorker = new BackgroundWorker();
        private void startSendingRequest(object sender, DoWorkEventArgs e)
        {
            byte[] writeBuffer = new byte[1];
            writeBuffer[0] = Form1.C;
            form.writeToReceiverConsole("BW C sent.");
            int counter = 0;
            while (counter < receiverMaxRetriesCount)
            {
                if (receivingData)
                    return;

                form.serialPort2.Write(writeBuffer, 0, 1);
                Thread.Sleep(receiverTimeoutMillisec);
                counter++;
            }
        }

        public override void handleSignal(Form1 form1, byte signal)
        {
            if (signal == Form1.SOH)
            {
                receivingData = true;
                form1.writeToReceiverConsole("SOH received.");

                packetNumber = form1.serialPort2.ReadByte();
                if (packetNumber + form1.serialPort2.ReadByte() != 0xff)
                {
                    sendSignal(Form1.NAK);
                    form1.writeToReceiverConsole("Wrong packet number - NAK sent.");
                    form1.serialPort2.DiscardInBuffer();
                    return;
                }
                byte[] readBuffer = new byte[130];
                int readBytesNumber = form.serialPort2.Read(readBuffer, 0, readBuffer.Length);

                CRC16ReceiverCalculator calculator = new CRC16ReceiverCalculator();
                byte[] readBufferToCalculate = new byte[readBytesNumber - 2];
                Array.Copy(readBuffer, 0, readBufferToCalculate, 0, readBytesNumber - 2);

                byte[] crcCheckSumReceiver = calculator.ComputeCRCChecksumBytes(readBufferToCalculate);

                if (crcCheckSumReceiver[0] != readBuffer[readBytesNumber - 2] || crcCheckSumReceiver[1] != readBuffer[readBytesNumber - 1])
                {
                    sendSignal(Form1.NAK);
                    form1.writeToReceiverConsole("Wrong checksum - NAK sent.");
                    form1.serialPort2.DiscardInBuffer();
                    return;
                }
                else
                {
                    form1.OutputFile.Write(readBuffer, 0, readBytesNumber - 2);
                    sendSignal(Form1.ACK);
                    form1.writeToReceiverConsole("ACK sent.");
                }
            }
            else if (signal == Form1.EOT)
            {
                form1.writeToReceiverConsole("EOT received.");
                sendSignal(Form1.ACK);
                form1.writeToReceiverConsole("ACK sent.");
                form1.OutputFile.Close();
                form1.serialPort2.Close();
            }
        }

        public void sendSignal(byte signal)
        {
            byte[] writeBuffer = new byte[1];
            writeBuffer[0] = signal;
            form.serialPort2.Write(writeBuffer, 0, writeBuffer.Length);
        }

        public override void initialize(Form1 form1)
        {
            form = form1;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += startSendingRequest;
            backgroundWorker.RunWorkerAsync();
        }
    }    
}
