using System;
using System.Threading;

namespace ConcurrencyPatterns
{
    // Only executes an action on an object when the object is in a 
    // particular state
    public class Balking
    {
        private static Balking instance;
        private bool jobInProgress;

        private Balking()
        { }

        public static Balking GetInstance()
        {
            if (instance == null)
                instance = new Balking();

            return instance;
        }

        public void Execute()
        {
            if (jobInProgress == true)
                return;

            jobInProgress = true;
            Console.WriteLine("Executando ação: BALKING");
            Thread.Sleep(TimeSpan.FromMinutes(1));
            jobInProgress = false;
        }




    }
}
