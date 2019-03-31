using System; 

namespace BusinessDelegate
{
    public class JMSService : IBusinessService
    {
        public void doProcessing()
        {
            Console.WriteLine("Processing task by invoking JMS Service");
        }
    }
}
