using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Logs
{
    public class DB : Log
    {
        public override void GerarLog(int error)
        {
            if (error == 0)
            {
                Console.WriteLine("Gerando log no DB");
            }
            else
                base.Sucessor.GerarLog(error);
        }
    }
}
