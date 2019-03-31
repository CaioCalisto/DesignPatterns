using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Logs
{
    public class Txt : Log
    {
        public override void GerarLog(int error)
        {
            if (error == 1)
            {
                Console.WriteLine("Gerando log no TXT");
            }
            else
                base.Sucessor.GerarLog(error);
        }
    }
}
