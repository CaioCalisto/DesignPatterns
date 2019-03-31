using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrencyPatterns
{
    class Program
    {
        static Mutex mutex;

        static void Main(string[] args)
        {
            //TestandoBalking();  
            //SemaphoreExample.Test();
            TestandoMutex();

            Console.ReadKey();
        }

        // Para testar o MUTEX deve-se abrir o projeto 2x e executar
        public static void TestandoMutex()
        {
            if (!IsSingleInstance())
                Console.WriteLine("Existe Mais de uma instância em execução");
            else
                Console.WriteLine("Existe somente Uma instância em Execução");
        }

        private static bool IsSingleInstance()
        {
            try
            {
                // Tenta abrir um mutex existente
                Mutex.OpenExisting("CalistoApp");
            }
            catch
            {
                // se não existir um mutex ocorre uma exceção
                mutex = new Mutex(true, "CalistoApp");
                return true;
            }
            // Nao existe mais de 1 instancia
            return false;
        }
          
        public static void TestandoBalking()
        {
            DateTime dt = DateTime.Now;

            while (dt.AddMinutes(5) > DateTime.Now)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(1000));
                Console.WriteLine("While: Tentando novamente.");
                ExecutarAssincrono();
            }
        }

        static async void ExecutarAssincrono()
        {
            Balking balking = Balking.GetInstance();
            await Task.Run(() => balking.Execute() );
        }
    }
}
