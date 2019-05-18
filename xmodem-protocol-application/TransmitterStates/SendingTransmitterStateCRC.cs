using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace xmodem_protocol_application.TransmitterStates
{
    class SendingTransmitterStateCRC : TransmitterState
    {
        private bool endOfFile = false;
        private byte packetCounter = 1;
        private byte[] buffer = new byte[128];
        private int inputBytesCount = 0;

        private void sendDataPackage(Form1 form1, FileStream fileStream)
        {
            byte[] writeBuffer = new byte[inputBytesCount + 5];
            writeBuffer[0] = Form1.SOH;
            writeBuffer[1] = packetCounter;
            writeBuffer[2] = unchecked((byte)(~packetCounter));
            Array.Copy(buffer, 0, writeBuffer, 3, inputBytesCount);
          
            byte[] dataBufferToCalculate = new byte[inputBytesCount];
            Array.Copy(buffer, 0, dataBufferToCalculate, 0, inputBytesCount);

            CRC16TransmitterCalculator calculator = new CRC16TransmitterCalculator();

            byte[] crcCheckSumTransmitter = calculator.ComputeCRCChecksumBytes(dataBufferToCalculate);

            writeBuffer[writeBuffer.Length - 2] = crcCheckSumTransmitter[0];
            writeBuffer[writeBuffer.Length - 1] = crcCheckSumTransmitter[1];
            form1.serialPort1.Write(writeBuffer, 0, writeBuffer.Length);
        }

        private void getNextPackage(Form1 form1)
        {
            inputBytesCount = form1.InputFile.Read(buffer, 0, 128);

            if (inputBytesCount <= 0)
            {
                byte[] writeBuffer = new byte[1];
                writeBuffer[0] = Form1.EOT;
                form1.serialPort1.Write(writeBuffer, 0, 1);
                form1.writeToTransmitterConsole("End of file - sending EOT.");
                endOfFile = true;
            }
            ++packetCounter;
        }

        public override void initialize(Form1 form1)
        {
            form1.writeToTransmitterConsole("New state - sending.");
            getNextPackage(form1);
            sendDataPackage(form1, form1.InputFile);

        }

        public override void handleSignal(Form1 form1, byte signal)
        {
            if (signal == Form1.ACK)
            {
                form1.writeToTransmitterConsole("Received ACK - sending next package.");
                getNextPackage(form1);
                if (!endOfFile)
                    sendDataPackage(form1, form1.InputFile);
                else
                {
                    form1.StateTransmitter = new InitialTransmitterState();
                    form1.InputFile.Close();
                }
            }
            else if (signal == Form1.NAK)
            {
                form1.writeToTransmitterConsole("Received NAK - resending package.");
                sendDataPackage(form1, form1.InputFile);
            }
            else if (signal == Form1.CAN)
            {
                form1.writeToTransmitterConsole("Received CAN - aborting sending.");
                form1.StateTransmitter = new InitialTransmitterState();
                form1.InputFile.Close();
            }
        }


    }
}
