using System; 
using Exemplo_2.ValueObjects;

namespace Exemplo_2.Subscribers
{
    public class CurrentConditionsDisplay
    {
        private WeatherData data;
        private WeatherDataProvider provider;

        public CurrentConditionsDisplay(WeatherDataProvider provider)
        {
            this.provider = provider;
        }

        private void Handle(object sender, WeatherDataEventArgs arg)
        {
            data = arg.data;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            Console.WriteLine($"Current Condition: " +
                $"Temp: {data.Temperature} | Humidity: {data.Humidity} | Pressure: {data.Pressure}");
        }

        public void Subscribe()
        {
            provider.RaiseWeatherDataChangedEvent += Handle;
        }

        public void Unsubscribe()
        {
            provider.RaiseWeatherDataChangedEvent -= Handle;
        }

    }
}
