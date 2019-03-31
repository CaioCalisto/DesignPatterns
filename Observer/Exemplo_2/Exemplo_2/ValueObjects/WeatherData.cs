using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_2.ValueObjects
{
    public class WeatherData
    { 
        public float Temperature { get; }
        public float Humidity { get; }
        public float Pressure { get; }

        public WeatherData(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }

    }
}
