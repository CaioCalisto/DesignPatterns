using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Filter
{
    public interface ICriteria
    {
        List<Model.Person> MeetCriteria(List<Model.Person> persons);
    }
}
