using System;
using System.Threading;

namespace CircuitBreaker
{
    public class Servico
    {
        private Breaker.CircuitBreaker circuitBreaker;

        public Servico()
        {
            this.circuitBreaker = new Breaker.CircuitBreaker(10, TimeSpan.FromSeconds(10));
        }

        public void TestandoServico()
        {
            bool executar = true;
            while (executar == true)
            {
                this.circuitBreaker.RunProcess(() => { ChamarServico(); });
                Thread.Sleep(TimeSpan.FromMilliseconds(500));
            }
        }

        private void ChamarServico()
        {
            Console.WriteLine("Chamando Serviço!");
            if (!this.circuitBreaker.StateIsHalfClosed)
                throw new NotImplementedException();
        }

    }
}
