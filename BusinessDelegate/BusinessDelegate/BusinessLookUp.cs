
namespace BusinessDelegate
{
    public class BusinessLookUp
    {
        public IBusinessService getBusinessService(string serviceType)
        {
            if (serviceType.ToUpper() == "EJB")
                return new EJBService();
            else
                return new JMSService();
        }
    }
}
