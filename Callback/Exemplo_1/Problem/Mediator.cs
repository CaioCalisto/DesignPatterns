
namespace Exemplo_1.Problem
{
    public abstract class Mediator
    {
        public event Notificacao EventoNotificacao;

        protected void Notificar(string msg)
        {
            if (EventoNotificacao != null)
                EventoNotificacao.Invoke(msg);
        }


    }
}
