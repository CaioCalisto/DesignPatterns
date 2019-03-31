using System; 

namespace Exemplo_1
{
    /*
      Encapsular a requisição como 1 objeto, permitindo parametrizar clientes com 
      diferentes requisições e filas, suportando a operação REFAZER
       
     */
    class Program
    {
        static void Main(string[] args)
        {
            Commands.LightOFF lightOff = new Commands.LightOFF() { IsRunning = false };
            Commands.LightON lightOn = new Commands.LightON() { IsRunning = false };
            Commands.RadioON radioOn = new Commands.RadioON() { IsRunning = false };
            Commands.RadioOFF radioOff = new Commands.RadioOFF() { IsRunning = false };
            Commands.Open openGarage = new Commands.Open() { IsRunning = false };
            Commands.Close closeGarage = new Commands.Close() { IsRunning = false };

            RemoteControl control = new RemoteControl();
            control.SetCommand(0, lightOn, lightOff);
            control.SetCommand(1, radioOn, radioOff);
            control.SetCommand(2, openGarage, closeGarage);

            control.PressButton(1);
            control.PressButton(2);
            control.UnpressButton(1);
            control.PressButton(0);
            control.UnpressButton(2);
            control.UnpressButton(0);
            control.UnpressButton(0);
            control.PressButton(1);
            control.PressButton(1);

            Console.ReadKey();
        }
    }
}
