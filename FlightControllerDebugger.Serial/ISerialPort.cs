using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightControllerDebugger.Serial
{
    public interface ISerialPort: IDisposable
    {
        Handshake Handshake { get; set; }
        Encoding Encoding { get; set; }
        bool DtrEnable { get; set; }
        bool CtsHolding { get; }
        bool DiscardNull { get; set; }
        int DataBits { get; set; }
        bool IsOpen { get; }
        bool DsrHolding { get; }
        string NewLine { get; set; }
        int ReadBufferSize { get; set; }
        byte ParityReplace { get; set; }
        string PortName { get; set; }
        bool CDHolding { get; }
        int ReadTimeout { get; set; }
        int ReceivedBytesThreshold { get; set; }
        bool RtsEnable { get; set; }
        StopBits StopBits { get; set; }
        int WriteBufferSize { get; set; }
        int WriteTimeout { get; set; }
        Parity Parity { get; set; }
        int BytesToRead { get; }
        int BaudRate { get; set; }
        bool BreakState { get; set; }
        Stream BaseStream { get; }
        int BytesToWrite { get; }

        event SerialErrorReceivedEventHandler ErrorReceived;
        event SerialDataReceivedEventHandler DataReceived;
        event SerialPinChangedEventHandler PinChanged;

        string[] GetPortNames();
        void Close();
        void DiscardInBuffer();
        void DiscardOutBuffer();
        void Open();
        int Read(byte[] buffer, int offset, int count);
        int Read(char[] buffer, int offset, int count);
        int ReadByte();
        int ReadChar();
        string ReadExisting();
        string ReadLine();
        string ReadTo(string value);
        void Write(byte[] buffer, int offset, int count);
        void Write(string text);
        void Write(char[] buffer, int offset, int count);
        void WriteLine(string text);
        void Dispose(bool disposing);
    }
}
