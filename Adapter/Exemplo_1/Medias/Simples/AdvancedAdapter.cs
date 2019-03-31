using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Medias.Simples
{
    public class AdvancedAdapter : IAdvanced
    {
        private ISimple simplemedia;

        public AdvancedAdapter(ISimple simplemedia)
        {
            this.simplemedia = simplemedia;
        }

        public void Play()
        {
            simplemedia.Play();
            Console.WriteLine("It is playing as advanced but it is simple!");
        }
    }
}
