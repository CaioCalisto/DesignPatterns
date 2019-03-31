
namespace Exemplo_1.Logs
{
    public abstract class Log
    {
        protected Log Sucessor;

        public void SetSucessor(Log sucessor)
        {
            Sucessor = sucessor;
        }

        public abstract void GerarLog(int error);
    }
}
