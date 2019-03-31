using System;
using Constructor_Setter_Interface.Classes;
using Constructor_Setter_Interface.Injections;

namespace Constructor_Setter_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IChild child = new Child();

            Console.WriteLine("Using Construtor: ");
            Constructor construtor = new Constructor(child);
            construtor.RealizarTarefa();

            Console.WriteLine("Using Setter: ");
            Setter setter = new Setter();
            setter.child = child;
            setter.RealizarTarefa();

            Console.WriteLine("Using interface");
            Interface interf = new Interface_Principal();
            interf.InjetarDependencia(child);
            interf.RealizarTarefa();

            Console.ReadKey();
        }
    }
}
