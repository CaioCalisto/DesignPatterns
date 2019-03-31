using System;

namespace Exemplo_1
{
    /*
      Usa compartilhamento para suportar grande numero de 
      objetos pequenos eficientemente

      Quando usar:
       - Quando a aplicação tem grande numero de objetos
       - custo de armazenamento alto 
       - muitos stados dos objetos podem ser extrínseco
       - muitos grupos de objetos podem ser recolocados por outros
       - a aplicação nao depende do ID do objeto.
    */
    class Program
    {
        static void Main(string[] args)
        {
            string letters = "AB";
            char[] chars = letters.ToCharArray();

            Flyweights.CharacterFactory factory = new Flyweights.CharacterFactory();

            int pointsize = 10;

            foreach (char c in chars)
            {
                pointsize++;
                Flyweights.Character character = factory.GetCharacted(c);
                character.Display(pointsize);
            }

            Console.ReadKey();
        }
    }
}
