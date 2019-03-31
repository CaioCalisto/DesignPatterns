using System;
using System.Collections.Generic;
using System.Text;
using Exemplo_2.ValueObjects;

namespace Exemplo_2.Subscribers
{
    public class ForecastDisplay
    {
        private WeatherData data;
        private WeatherDataProvider provider;

        public ForecastDisplay(WeatherDataProvider provider)
        {
            this.provider = provider;
        }

        private void Handle(object sender, WeatherDataEventArgs args)
        {
            this.data = args.data;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            Console.WriteLine($"Forecast: " +
                $"Temp: {data.Temperature} | Humidity: {data.Humidity}");
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
