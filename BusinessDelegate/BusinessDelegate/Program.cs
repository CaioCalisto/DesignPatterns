using System;

namespace BusinessDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessDelegate businessDeletate = new BusinessDelegate();
            businessDeletate.SetService("EJB");

            Client client = new Client(businessDeletate);
            client.DoTask();

            businessDeletate.SetService("JMS");
            client.DoTask();

            Console.ReadKey();
        }
    }
}
