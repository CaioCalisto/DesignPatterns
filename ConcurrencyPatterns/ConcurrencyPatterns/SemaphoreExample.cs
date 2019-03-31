using System;
using System.Threading;

namespace ConcurrencyPatterns
{
    public class SemaphoreExample
    {
        static Thread[] threads = new Thread[10];
        static Semaphore semaphore = new Semaphore(3, 3);

        public static void Test()
        {
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(Execute);
                threads[i].Name = "thread_" + i;
                threads[i].Start();
            }
        }

        private static void Execute()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is WAITING");
            semaphore.WaitOne();
            Console.WriteLine($"{Thread.CurrentThread.Name} ENTERS");
            Thread.Sleep(700);
            Console.WriteLine($"{Thread.CurrentThread.Name} is LEAVING");
            semaphore.Release();
        }


    }
}
