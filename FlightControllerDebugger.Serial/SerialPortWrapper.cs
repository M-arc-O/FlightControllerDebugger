using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightControllerDebugger.Serial
{
    public class SerialPortWrapper: SerialPort, ISerialPort
    {
        public SerialPortWrapper() : base() { }
        public SerialPortWrapper(IContainer container) : base(container) { }
        public SerialPortWrapper(string portName) : base(portName) { }
        public SerialPortWrapper(string portName, int baudRate) : base(portName, baudRate) { }
        public SerialPortWrapper(string portName, int baudRate, Parity parity) : base(portName, baudRate, parity) { }
        public SerialPortWrapper(string portName, int baudRate, Parity parity, int dataBits) : base(portName, baudRate, parity, dataBits) { }
        public SerialPortWrapper(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits) : base(portName, baudRate, parity, dataBits, stopBits) { }

        public new string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }

        void ISerialPort.Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
