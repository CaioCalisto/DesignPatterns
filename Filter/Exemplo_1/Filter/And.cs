using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Filter
{
    public class And : ICriteria
    {
        private ICriteria criteria;
        private ICriteria othercriteria;

        public And(ICriteria criteria, ICriteria othercriteria)
        {
            this.criteria = criteria;
            this.othercriteria = othercriteria;
        }

        public List<Model.Person> MeetCriteria(List<Model.Person> persons)
        {
            List<Model.Person> firstcriteria = criteria.MeetCriteria(persons);
            return othercriteria.MeetCriteria(firstcriteria);
        }
    }
}
