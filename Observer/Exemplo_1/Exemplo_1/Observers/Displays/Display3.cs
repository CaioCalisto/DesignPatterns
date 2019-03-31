using System;

namespace Exemplo_1.Observers.Displays
{
    public class Display3 : IObserver, IDisplay
    {
        private float pressure;
        private ISubject subject;

        public Display3(ISubject subject)
        {
            this.subject = subject;
            this.subject.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine(string.Format("Display 1- The Air Pressure is {0}", pressure));
        }
    }
}
