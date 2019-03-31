using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Filter
{
    public class Male : ICriteria
    {
        public List<Model.Person> MeetCriteria(List<Model.Person> persons)
        {
            List<Model.Person> personsmale = new List<Model.Person>();

            foreach (Model.Person person in persons)
                if (person.Gender.ToUpper() == "MALE")
                    personsmale.Add(person);

            return personsmale;
        }
    }
}
