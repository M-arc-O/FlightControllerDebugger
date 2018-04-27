using FlightControllerDebugger.Entities.DebugConnectorSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightControllerDebugger.Entities.Interfaces
{
    public interface IDebugConnector: IDisposable
    {
        event EventHandler<object> MessageReceived;

        void Initialize(DebugConnectorSettingsBase settings);

        bool Open();

        bool Send();

        void Close();
    }
}
