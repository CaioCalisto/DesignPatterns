using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    public class Main
    {
        private Medias.IAdvanced advancedmedia;

        public Main(Medias.IAdvanced advancedmedia)
        {
            this.advancedmedia = advancedmedia;
        }

        public void PlayAdvancedMedia()
        {
            this.advancedmedia.Play();
        }

    }
}
