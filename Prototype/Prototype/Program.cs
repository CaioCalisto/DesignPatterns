using System;

namespace Prototype
{
    class Program
    {
        /*
         Especifica o tipo de objeto a criar usando usando clone, copiando do protótipo
         
         Quando usar:
            - quando as classes para instanciar são especificadas em run-time (ex: dynamic loading)
            - para evitar criar hierarquia de classes igualar com hierarquia de produtos
            - quando as instâncias de uma classe podem ter uma das únicas combinações 
                de estados diferentes. Pode ser mais conveniente instalar um número correspondente 
                de protótipos e cloná-los em vez de instanciar a classe manualmente, cada um com 
                seu proprio estado
        */
        static void Main(string[] args)
        {
            //Concrete1 classe1 = new Concrete1("1");
            //Concrete1 clone1 = (Concrete1)classe1.Clone();

            //Concrete2 classe2 = new Concrete2("2");
            //Concrete2 clone2 = (Concrete2)classe2.Clone();

            OtherExample.ColorManager manager = new OtherExample.ColorManager();
            manager["red"] = new OtherExample.Color(255, 0, 0);
            manager["green"] = new OtherExample.Color(0, 255, 0);
            manager["blue"] = new OtherExample.Color(0, 0, 255);

            manager["angry"] = new OtherExample.Color(255, 54, 0);
            manager["peace"] = new OtherExample.Color(128, 211, 128);
            manager["flame"] = new OtherExample.Color(211, 34, 20);

            OtherExample.Color color1 = manager["red"].Clone() as OtherExample.Color;
            OtherExample.Color color2 = manager["peace"].Clone() as OtherExample.Color;
            OtherExample.Color color3 = manager["green"].Clone() as OtherExample.Color;

            manager["green"].SetGreen(999);

            Console.WriteLine(color1);
            Console.WriteLine(color2);
            Console.WriteLine(color3);
            Console.Write(manager["green"]);

            Console.ReadKey();
        }
    }
}
