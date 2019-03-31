using System;
using System.Collections.Generic;
using System.Text;

namespace CircuitBreaker.Breaker
{
    public abstract class State
    {
        protected CircuitBreaker breaker;

        public State(CircuitBreaker breaker)
        {
            this.breaker = breaker;
        }

        public virtual void AcaoAposSucesso()
        { }

        public virtual void ExecutarAcao()
        { }
         
        public virtual void AcaoAposObterException(Exception ex)
        {
            this.breaker.AcrescentarContadorFalhas();
        }

    }
}
