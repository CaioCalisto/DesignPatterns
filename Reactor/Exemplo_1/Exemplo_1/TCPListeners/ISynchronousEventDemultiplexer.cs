using System.Collections.Generic;
using System.Net.Sockets;

namespace Exemplo_1.TCPListeners
{
    public interface ISynchronousEventDemultiplexer
    {
        IList<TcpListener> Select(ICollection<TcpListener> listeners);
    }
}
