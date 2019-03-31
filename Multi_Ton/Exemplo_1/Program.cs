using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    /*
     The Multiton design pattern is an extension of the singleton pattern. It ensures that a limited number of instances 
     of a class can exist by specifying a key for each instance and allowing only a single object to be created for each
     of those keys
    */
    class Program
    {
        static void Main(string[] args)
        {
            Camera cam1a = Camera.GetCamera(1);
            Camera cam1b = Camera.GetCamera(1);
            Camera cam2a = Camera.GetCamera(2);
            Camera cam2b = Camera.GetCamera(2);
            Camera cam3a = Camera.GetCamera(3); // NULL
            Camera cam3b = Camera.GetCamera(3); // NULL

            Console.WriteLine(cam1a.HardwareID);
            Console.WriteLine(cam1b.HardwareID);
            Console.WriteLine(cam2a.HardwareID);
            Console.WriteLine(cam2b.HardwareID);

            Console.ReadKey();
        }
    }
}
