using System;

namespace Exemplo_1.Observers.Displays
{
    public class Display1 : IObserver, IDisplay
    {
        private float temperature;
        private float humidity;
        private ISubject subject;

        public Display1(ISubject subject)
        {
            this.subject = subject;
            this.subject.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine(string.Format("Display 1- Temperature:{0}, Humidity:{1}", temperature, humidity));
        }
    }
}
