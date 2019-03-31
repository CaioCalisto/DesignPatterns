using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Logs
{
    public class Email : Log
    {
        public override void GerarLog(int error)
        {
            if (error == 2)
            {
                Console.WriteLine("Gerando log no Email");
            }
            else
                base.Sucessor.GerarLog(error);
        }
    }
}
