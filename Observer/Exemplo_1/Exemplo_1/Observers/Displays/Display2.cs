using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Observers.Displays
{
    public class Display2 : IObserver, IDisplay
    {
        private float temperature;
        private float pressure;
        private ISubject subject;

        public Display2(ISubject subject)
        {
            this.subject = subject;
            this.subject.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine(string.Format("Display 1- Temperature:{0}, Pressure:{1}", temperature, pressure));
        }
    }
}
