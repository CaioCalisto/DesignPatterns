using System;
using System.Collections.Generic;
using System.Text;

namespace CircuitBreaker.Breaker
{
    public class CircuitBreaker
    {
        #region Variaveis
        private State actualState;
        private Exception ultimaExcecao;
        public int NumeroAtualDeFalhas { get; private set; }
        public int NumeroLimiteDeFalhas { get; private set; }
        public TimeSpan TimeOut { get; private set; }
        #endregion

        #region Constructor
        public CircuitBreaker(int numeroLimiteDeFalhase, TimeSpan timeOut)
        {
            this.NumeroLimiteDeFalhas = numeroLimiteDeFalhase;
            this.TimeOut = timeOut;
            MoveToClose();
        }
        #endregion

        #region MetodosControle
        public void AcrescentarContadorFalhas()
        {
            this.NumeroAtualDeFalhas++;
        }

        public void ResetContadorFalhas()
        {
            this.NumeroAtualDeFalhas = 0;
        }
        #endregion

        #region TestesBooleano
        public bool StateIsOpen
        {
            get { return this.actualState is Open; }
        }

        public bool StateIsClosed
        {
            get { return this.actualState is Close; }
        }

        public bool StateIsHalfClosed
        {
            get { return this.actualState is HalfOpen; }
        }

        public bool LimiteFalhaAlcancado
        {
            get { return NumeroAtualDeFalhas >= NumeroLimiteDeFalhas; }
        }
        #endregion

        #region MoverState
        public void MoveToOpen()
        {
            this.actualState = new Open(this);
        }

        public void MoveToClose()
        {
            this.actualState = new Close(this);
        }

        public void MoveToHalfClose()
        {
            this.actualState = new HalfOpen(this);
        }
        #endregion

        public void RunProcess(Action action)
        {
            this.actualState.ExecutarAcao();
            if (this.StateIsOpen)
                return;

            try
            {
                action();
            }
            catch(Exception ex)
            {
                this.ultimaExcecao = ex;
                this.actualState.AcaoAposObterException(ex);
                return;
            }
            this.actualState.AcaoAposSucesso();
        }

    }
}
