using System.Net.Sockets;

namespace Exemplo_1.TCPListeners
{
    public interface IEventHandler
    {
        void HandleEvent(byte[] data);
        TcpListener GetHandler();
    }
}
