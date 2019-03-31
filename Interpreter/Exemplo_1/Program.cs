using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo_1.Conversor;

namespace Exemplo_1
{
    /*
       Dada uma linguagem, ele será interpretada
       Utilizar:
       - quando a gramatica é simples
       - eficiencia não é uma preocupacao
     */
    class Program
    {
        static void Main(string[] args)
        {
            string roman = "MCMXLIV";
            Conversor.Contexto context = new Conversor.Contexto(roman);

            List<Expressao> expressao = new List<Expressao>();
            expressao.Add(new ThousandExpressao());
            expressao.Add(new HundredExpressao());
            expressao.Add(new TenExpressao());
            expressao.Add(new OneExpressao());

            for (int i = 0; i < expressao.Count; i++ )
            {
                expressao[i].Interpreter(context);
            }

            Console.WriteLine("O numero cardinal é " + context.Output);
            
            Console.ReadKey();
        }
    }
}
