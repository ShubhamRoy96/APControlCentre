using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace APControlCentre.Model
{



    class DataSender
    {
        static ManualResetEvent dataReceived;
        static ManualResetEvent dataProcessed;
        static Queue<string> dataQ;
        static SerialPort port;        

        public DataSender(SerialPort serialPort)
        {
            dataReceived = new ManualResetEvent(false);
            dataProcessed = new ManualResetEvent(true);
            dataQ = new Queue<string>();
            port = serialPort;
            if (port != null && !port.IsOpen)
            {
                port.Open();
            }
            Task.Run(() => ProcessQ());
        }

        internal static void Enqueue(string data)
        {
            while (true)
            {                
                if (!string.IsNullOrWhiteSpace(data))
                {
                    dataQ.Enqueue(data);
                    break;
                }
            }
            if (dataQ.Count > 0)
            {
                dataProcessed.WaitOne();
                dataReceived.Set();
            }

        }

        static void ProcessQ()
        {
            while (true)
            {
                dataReceived.WaitOne();
                if (dataQ.Count > 0 && port.IsOpen)
                {
                    port.Write(dataQ.Dequeue());
                    dataProcessed.Set();

                }
            }
        }
    }
}
