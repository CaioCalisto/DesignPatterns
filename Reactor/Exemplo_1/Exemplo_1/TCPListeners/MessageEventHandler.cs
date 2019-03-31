using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Exemplo_1.TCPListeners
{
    /*
    Now we have the concrete implementation of the IEventHandler, which creates an instance of our TcpListener handle. 
    It also has methods for returning the Handle and handling the event for a message arriving.
    */

    public class MessageEventHandler : IEventHandler
    {
        private readonly TcpListener _listener;

        public MessageEventHandler(IPAddress ipadrress, int port)
        {
            _listener = new TcpListener(ipadrress, port);
        }

        public void HandleEvent(byte[] data)
        {
            string message = Encoding.UTF8.GetString(data);
        }

        public TcpListener GetHandler()
        {
            return _listener;
        }
    }
}
