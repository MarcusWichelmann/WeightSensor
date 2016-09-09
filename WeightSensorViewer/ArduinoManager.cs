using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WeightSensorViewer
{
    class ArduinoManager
    {
        public event WeightReceivedEventHandler WeightReceived;

        public delegate void WeightReceivedEventHandler(WeightReceivedEventArgs e);

        private SerialPort serialPort = new SerialPort();
        private Thread readThread;

        public void Connect(string portName)
        {
            if(serialPort.IsOpen)
                serialPort.Close();

            serialPort.PortName = portName;
            serialPort.BaudRate = 19200;

            serialPort.Open();

            if(readThread == null || !readThread.IsAlive)
            {
                readThread = new Thread(new ThreadStart(ReadData));
                readThread.Start();
            }
        }

        public void Disconnect()
        {
            if(serialPort.IsOpen)
                serialPort.Close();

            if(readThread != null && readThread.IsAlive)
                readThread.Join(500);
        }

        private void ReadData()
        {
            while(serialPort.IsOpen)
            {
                try
                {
                    string line = serialPort.ReadTo("\r\n");
                    ProcessData(line);
                }
                catch
                {
                    // Fehler sind z.B. beim Portwechsel normal.
                }
            }
        }

        private void ProcessData(string data)
        {
            double weight;
            if(!double.TryParse(data, NumberStyles.Float, new CultureInfo("en-US"), out weight))
                return;

            WeightReceived?.Invoke(new WeightReceivedEventArgs(weight));
        }
    }

    public class WeightReceivedEventArgs
    {
        public double Weight { get; }

        public WeightReceivedEventArgs(double weight)
        {
            Weight = weight;
        }
    }
}
