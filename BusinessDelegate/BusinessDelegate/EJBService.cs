using System; 

namespace BusinessDelegate
{
    public class EJBService : IBusinessService
    {
        public void doProcessing()
        {
            Console.WriteLine("Processing task by invoking EJB Service");
        }
    }
}
