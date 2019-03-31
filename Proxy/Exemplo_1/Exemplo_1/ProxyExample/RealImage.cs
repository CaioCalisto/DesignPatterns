using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.ProxyExample
{
    public class RealImage : IImage
    {
        private string name;

        public RealImage(string name)
        {
            this.name = name;
            LoadImageFromDisk(name);
        }

        public void Display()
        {
            Console.WriteLine($"Displaying {name}");
        }

        private void LoadImageFromDisk(string name)
        {
            Console.WriteLine($"Loading {name}");
        }

    }
}
