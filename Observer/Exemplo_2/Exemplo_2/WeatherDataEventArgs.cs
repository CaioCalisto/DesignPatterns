using System;
using Exemplo_2.ValueObjects;

namespace Exemplo_2
{
    public class WeatherDataEventArgs : EventArgs
    {
        public WeatherData data { get; }

        public WeatherDataEventArgs(WeatherData data)
        {
            this.data = data;
        }

    }
}
