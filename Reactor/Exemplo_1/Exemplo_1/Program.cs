using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Exemplo_1.TCPListeners;

namespace Exemplo_1
{
    /*
    The Reactor Pattern is a design pattern for synchronous demultiplexing and dispatching of concurrently 
    arriving events. It receives incoming messages/requests/connections from multiple concurrent clients and 
    processes these messages sequentially using event handlers
    
    The purpose of the Reactor design pattern is to avoid the common problem of creating a thread for each incoming 
    message/request/connection. It receives events from a set of handles and distributes them sequentially to the 
    corresponding event handlers. Thus, the application using the Reactor need only use one thread to handle concurrently 
    arriving events.

    Basically the Reactor pattern allows an application to handle concurrent events while retaining the simplicity of 
    single-threading
    */

    class Program
    {
        static void Main(string[] args)
        {
            IEventHandler client1 = new MessageEventHandler(IPAddress.Parse("192.168.0.108"), 123);
            IEventHandler client2 = new MessageEventHandler(IPAddress.Parse("234.234.234.234"), 123);
            IEventHandler client3 = new MessageEventHandler(IPAddress.Parse("345.345.345.345"), 123);

            ISynchronousEventDemultiplexer synchronousEventDemultiplexer = new SynchronousEventDemultiplexer();

            Reactor dispatcher = new Reactor(synchronousEventDemultiplexer);

            dispatcher.RegisterHandle(client1);
            dispatcher.RegisterHandle(client2);
            dispatcher.RegisterHandle(client3);

            dispatcher.HandleEvents();

        }
    }
}
