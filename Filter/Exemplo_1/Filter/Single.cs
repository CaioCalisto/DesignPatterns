﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Filter
{
    public class Single : ICriteria
    {
        public List<Model.Person> MeetCriteria(List<Model.Person> persons)
        {
            List<Model.Person> personssingle = new List<Model.Person>();

            foreach (Model.Person person in persons)
                if (person.MaritalStatus.ToUpper() == "SINGLE")
                    personssingle.Add(person);

            return personssingle;
        }
    }
}
