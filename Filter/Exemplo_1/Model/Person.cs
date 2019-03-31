using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Model
{
    public class Person
    {
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public string MaritalStatus { get; private set; }

        public Person(string name, string gender, string maritalstatus)
        {
            Name = name;
            Gender = gender;
            MaritalStatus = maritalstatus;
        }

    }
}
