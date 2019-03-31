using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1
{
    public class PrepareCaffeine
    {
        private Beverage.Caffeine beverage;

        public PrepareCaffeine(Beverage.Caffeine beverage)
        {
            this.beverage = beverage;
        }

        public void Prepare()
        {
            beverage.PrepareRecipe();
        }



    }
}
