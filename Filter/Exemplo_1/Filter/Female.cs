using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Filter
{
    public class Female: ICriteria
    {
        public List<Model.Person> MeetCriteria(List<Model.Person> persons)
        {
            List<Model.Person> personsfemale = new List<Model.Person>();

            foreach (Model.Person person in persons)
                if (person.Gender.ToUpper() == "FEMALE")
                    personsfemale.Add(person);

            return personsfemale;
        }
    }
}
