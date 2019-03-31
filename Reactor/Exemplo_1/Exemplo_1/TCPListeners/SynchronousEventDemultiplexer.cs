using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace Exemplo_1.TCPListeners
{
    /*
    Here we have the concrete implemenation of the Synchronous Event Demultiplexer, which returns TcpListeners 
    which are ready to be PROCESSED.
    */

    public class SynchronousEventDemultiplexer : ISynchronousEventDemultiplexer
    {
        public IList<TcpListener> Select(ICollection<TcpListener> listeners)
        {
            var tcpListeners =
                new List<TcpListener>(from listener in listeners
                                      where listener.Pending()
                                      select listener);
            return tcpListeners;

        }
    }
}
