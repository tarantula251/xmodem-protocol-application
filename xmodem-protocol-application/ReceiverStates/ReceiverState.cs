using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xmodem_protocol_application.ReceiverStates
{
    public abstract class ReceiverState
    {
        public abstract void handleSignal(Form1 form1, byte signal);
        public abstract void initialize(Form1 form1);
    }
}
