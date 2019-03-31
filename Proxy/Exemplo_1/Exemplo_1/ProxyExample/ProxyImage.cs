using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.ProxyExample
{
    public class ProxyImage : IImage
    {
        private string name;
        private RealImage realImage;

        public ProxyImage(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            if (realImage == null)
                realImage = new RealImage(this.name);

            realImage.Display();
        }
    }
}
