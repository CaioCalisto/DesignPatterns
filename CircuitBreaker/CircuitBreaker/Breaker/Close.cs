using System;
using System.Collections.Generic;
using System.Text;

namespace CircuitBreaker.Breaker
{
    public class Close : State
    {
        public Close(CircuitBreaker breaker) 
            : base(breaker)
        {
            this.breaker.ResetContadorFalhas();
        }

        public override void AcaoAposObterException(Exception ex)
        {
            base.AcaoAposObterException(ex);
            Console.WriteLine($"Exception Obtido em Estado CLOSED. Numero atual de Falhas {this.breaker.NumeroAtualDeFalhas}");
            if (this.breaker.LimiteFalhaAlcancado)
                this.breaker.MoveToOpen();
        }

    }
}
