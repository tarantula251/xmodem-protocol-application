using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xmodem_protocol_application.TransmitterStates
{
    class CRC16TransmitterCalculator
    {
        const ushort polynomial = 0xA001;
        ushort[] table = new ushort[256];

        public ushort ComputeCRCChecksum(byte[] bytes)
        {
            ushort crc = 0;
            for (int i = 0; i < bytes.Length; ++i)
            {
                byte index = (byte)(crc ^ bytes[i]);
                crc = (ushort)((crc >> 8) ^ table[index]);
            }
            return crc;
        }

        public byte[] ComputeCRCChecksumBytes(byte[] bytes)
        {           
            ushort crc = ComputeCRCChecksum(bytes);        
            byte[] result = BitConverter.GetBytes(crc);
            return BitConverter.GetBytes(crc);
        }

        public CRC16TransmitterCalculator()
        {
            ushort value;
            ushort temp;
            for (ushort i = 0; i < table.Length; ++i)
            {
                value = 0;
                temp = i;
                for (byte j = 0; j < 8; ++j)
                {
                    if (((value ^ temp) & 0x0001) != 0)
                    {
                        value = (ushort)((value >> 1) ^ polynomial);
                    }
                    else
                    {
                        value >>= 1;
                    }
                    temp >>= 1;
                }
                table[i] = value;
            }
        }
    }
}
