using System;
using System.Threading;

namespace ConcurrencyPatterns
{
    public class Printer
    {
        public void Print(int idDocument)
        {
            Console.WriteLine($"Printing document {idDocument}");
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
    }
}
