using System.Collections.Generic;
using Exemplo_1.Services;

namespace Exemplo_1.Locators
{
    public class Cache
    {
        private List<IService> services;

        public Cache()
        {
            services = new List<IService>();
        }

        public IService GetService(string servicename)
        {
            foreach(IService service in services)
            {
                if (service.GetName().ToUpper() == servicename.ToUpper())
                {
                    return service;
                }
            }
            return null;
        }

        public void AddService(IService service)
        {
            if (!services.Exists(s => s.GetName().ToUpper() == service.GetName().ToUpper()))
                services.Add(service);
        }

    }
}
