using System;
using System.Collections.Generic;
using System.Text;

namespace CircuitBreaker.Breaker
{
    public class Open : State
    {
        private readonly DateTime dataHoraStateFoiAcionado;

        public Open(CircuitBreaker breaker) 
            : base(breaker)
        {
            this.breaker.ResetContadorFalhas();
            this.dataHoraStateFoiAcionado = DateTime.UtcNow;
        }
          
        public override void ExecutarAcao()
        {
            base.ExecutarAcao();
            Console.WriteLine($"Estado CLOSED. Aguardando Timeout {this.breaker.TimeOut}. " +
                $"Tempo Corrido: {DateTime.UtcNow - dataHoraStateFoiAcionado}");
            if (DateTime.UtcNow >= this.dataHoraStateFoiAcionado + this.breaker.TimeOut)
            {
                Console.WriteLine($"Estado CLOSED. Timeout Alcancado");
                this.breaker.MoveToHalfClose();
            }
        }
         



    }
}
