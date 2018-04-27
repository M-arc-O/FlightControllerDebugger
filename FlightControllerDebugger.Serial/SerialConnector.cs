using FlightControllerDebugger.Entities.DebugConnectorSettings;
using FlightControllerDebugger.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightControllerDebugger.Serial
{
    public class SerialConnector : IDebugConnector
    {
        private ISerialPort _Port;
        public ISerialPort DI_Port
        {
            get
            {
                if (_Port == null)
                {
                    _Port = new SerialPortWrapper();
                }
                return _Port;
            }
            set { _Port = value; }
        }

        public event EventHandler<object> MessageReceived;

        public void Initialize(DebugConnectorSettingsBase settings)
        {

        }

        public bool Open()
        {
            throw new NotImplementedException();
        }

        public bool Send()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
