using System.Collections.Generic;

namespace Exemplo_1
{
    public class CustomerStore
    {
        private static List<string> names = new List<string>()
        { 
            "Rob", "Joe", "Julie"
        };

        public static DB.Customer GetCustomer(string name)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].ToUpper() == name.ToUpper())
                    return new DB.RealCustomer(name);
            }
            return new DB.NullCustomer();
        }



    }
}
