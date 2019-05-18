using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xmodem_protocol_application.TransmitterStates
{
    public class InitialTransmitterState : TransmitterState
    {
        public override void handleSignal(Form1 form1, byte signal)
        {
            if (signal == Form1.NAK || signal == Form1.C)
            {
                if (form1.checkSumChoice)
                    form1.StateTransmitter = new SendingTransmitterState();
                else
                    form1.StateTransmitter = new SendingTransmitterStateCRC();
            }        
        }

        public override void initialize(Form1 form1)
        {
            form1.writeToTransmitterConsole("New state - initial.");
            return;
        }
    }
}
