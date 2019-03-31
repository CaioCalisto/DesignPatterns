using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Filter
{
    public class Or : ICriteria
    {
        private ICriteria criteria;
        private ICriteria othercriteria;

        public Or(ICriteria criteria, ICriteria othercriteria)
        {
            this.criteria = criteria;
            this.othercriteria = othercriteria;
        }

        public List<Model.Person> MeetCriteria(List<Model.Person> persons)
        {
            List<Model.Person> firstcriteria = criteria.MeetCriteria(persons);
            List<Model.Person> secondcriteria = othercriteria.MeetCriteria(persons);

            foreach(Model.Person person in secondcriteria)
            {
                if (!firstcriteria.Contains(person))
                    firstcriteria.Add(person);
            }

            return firstcriteria;
        }
    }
}
