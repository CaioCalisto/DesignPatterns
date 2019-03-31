using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Conversor
{
    public abstract class Expressao
    {
        public abstract string One();
        public abstract string Four();
        public abstract string Five();
        public abstract string Nine();
        public abstract int Multiplier();

        public void Interpreter(Contexto contexto)
        {
            if (contexto.Input.Length == 0)
                return;

            if (contexto.Input.StartsWith(Nine()))
            {
                contexto.Output = contexto.Output + (9 * Multiplier());
                contexto.Input = contexto.Input.Substring(2);
            }
            else if (contexto.Input.StartsWith(Four()))
            {
                contexto.Output = contexto.Output + (4 * Multiplier());
                contexto.Input = contexto.Input.Substring(2);
            }
            else if (contexto.Input.StartsWith(Five()))
            {
                contexto.Output = contexto.Output + (5 * Multiplier());
                contexto.Input = contexto.Input.Substring(1);
            }

            while (contexto.Input.StartsWith(One()))
            {
                contexto.Output = contexto.Output + (1 * Multiplier());
                contexto.Input = contexto.Input.Substring(1);
            }
        }

    }
}
