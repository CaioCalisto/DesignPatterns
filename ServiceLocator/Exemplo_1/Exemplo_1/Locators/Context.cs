using Exemplo_1.Services;

namespace Exemplo_1.Locators
{
    public class Context
    {
        public IService Lookup(string servicename)
        {
            if (servicename.ToUpper() == "SERVICE1")
                return new Services.Service1();
            else if (servicename.ToUpper() == "SERVICE2")
                return new Services.Service2();

            return null;
        }
    }
}
