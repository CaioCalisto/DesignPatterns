using Exemplo_1.Locators;
using Exemplo_1.Services;

namespace Exemplo_1
{
    public class Locator
    {
        private static Cache cache = new Cache();
        
        public static IService GetService(string servicename)
        {
            IService service = cache.GetService(servicename);
            if (service != null)
                return service;
            else
                return AddNewService(servicename);
        }

        private static IService AddNewService(string servicename)
        {
            Context context = new Context();
            IService service = context.Lookup(servicename);
            cache.AddService(service);
            return service;
        }

    }
}
