using System;
using System.Collections.Generic;
using System.Text;

namespace CircuitBreaker.Breaker
{
    public class HalfOpen : State
    {
        public HalfOpen(CircuitBreaker breaker) 
            : base(breaker)
        {
        }

        public override void AcaoAposSucesso()
        {
            Console.WriteLine("Estado HalfClosed.");
            base.AcaoAposSucesso();
            this.breaker.MoveToClose();
        }
    }
}
