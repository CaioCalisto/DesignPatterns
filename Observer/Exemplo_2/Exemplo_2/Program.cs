using System;

namespace Exemplo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherDataProvider provider = new WeatherDataProvider();

            //Este são um observadores
            Subscribers.CurrentConditionsDisplay currentConditionsDisplay = new Subscribers.CurrentConditionsDisplay(provider);
            Subscribers.ForecastDisplay forecastDisplay = new Subscribers.ForecastDisplay(provider);

            //Eles desejam observar
            currentConditionsDisplay.Subscribe();
            forecastDisplay.Subscribe();

            provider.NotifyDisplays(40, 78, 3);
            Console.WriteLine();
            provider.NotifyDisplays(42, 67, 5);
            Console.WriteLine();
            provider.NotifyDisplays(45, 72, 7);
            Console.WriteLine();
            provider.NotifyDisplays(44, 71, 2);
            Console.WriteLine();

            provider.Dispose();



            Console.ReadKey();
        }
         

    }
}
