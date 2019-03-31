using System; 
using Exemplo_2.ValueObjects;

namespace Exemplo_2
{
    public class WeatherDataProvider: IDisposable
    {
        public event EventHandler<WeatherDataEventArgs> RaiseWeatherDataChangedEvent;

        protected virtual void OnRaiseWeatherDataChangedEvent(WeatherDataEventArgs ev)
        {
            EventHandler<WeatherDataEventArgs> handler = RaiseWeatherDataChangedEvent;

            if (handler != null)
                handler(this, ev);
        }

        public void NotifyDisplays(float temperature, float humidity, float pressure)
        {
            OnRaiseWeatherDataChangedEvent(new WeatherDataEventArgs(new WeatherData(temperature, humidity, pressure)));
        }

        public void Dispose()
        {
            if(RaiseWeatherDataChangedEvent != null)
            {
                foreach(EventHandler<WeatherDataEventArgs> item in RaiseWeatherDataChangedEvent.GetInvocationList())
                {
                    RaiseWeatherDataChangedEvent -= item;
                }
            }
        }

    }
}
