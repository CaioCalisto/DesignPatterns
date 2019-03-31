using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    /*
     Converte uma interface in outra interface que o cliente espera
     Adapter deixa as classes trabalharem juntas mesmo não tendo interface compativel

     Quando usar:
       - voce quer usar uma classe existente, e sua interface não 
            corresponde com a interface que voce precisa
       - voce quer criar uma classe reutilizavel que coopera com 
            uma classe não relacionada, e sua classe não necessariamente
            tem interface compativel
       - voce precisa usar varias subclasses existente, mas não 
            consegue deixar todas elas em uma unica interface
    */
    class Program
    {
        static void Main(string[] args)
        {
            Medias.IAdvanced mp4 = new Medias.Advances.MP4();
            Medias.IAdvanced vlc = new Medias.Advances.VLC();
            Medias.IAdvanced k7 = new Medias.Simples.AdvancedAdapter(new Medias.Simples.K7());

            Main radio1 = new Main(mp4);
            Main radio2 = new Main(vlc);
            Main radio3 = new Main(k7);

            radio1.PlayAdvancedMedia();
            radio2.PlayAdvancedMedia();
            radio3.PlayAdvancedMedia();

            Console.ReadKey();
        }
    }
}
