using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    /*
       Define uma dependencia 1-Muitos assim quando 1 objeto muda, seus
       dependentes são notificados e atualizados

       Quando usar:
        - quando a abstração tem 2 aspectos, um depende do outro. Encapsulando
            estes aspectos em objetos separados deixa voce reusá-los independetemente
        - quando uma mudança em um objeto requer mudanças em outros, e voce
            não sabe quantos objetos precisam ser mudados
        - quando um objeto deveria ser ter permissão de notificar outros sem
            acoplamentos
     */
    class Program
    {
        static void Main(string[] args)
        {
            Observers.ISubject weather = new Observers.Subjects.WeatherData();
            Observers.Displays.IDisplay display1 = new Observers.Displays.Display1(weather);
            Observers.Displays.IDisplay display2 = new Observers.Displays.Display2(weather);
            Observers.Displays.IDisplay display3 = new Observers.Displays.Display3(weather);

            weather.SetMeasurements(80, 90, 30);
            Console.WriteLine();
            weather.SetMeasurements(65, 82, 45);
            Console.WriteLine();
            weather.SetMeasurements(75, 87, 38);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
