using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Model.Person> persons = new List<Model.Person>();

            persons.Add(new Model.Person("Robert", "Male", "Single"));
            persons.Add(new Model.Person("John", "Male", "Married"));
            persons.Add(new Model.Person("Laura", "Female", "Married"));
            persons.Add(new Model.Person("Diana", "Female", "Single"));
            persons.Add(new Model.Person("Mike", "Male", "Single"));
            persons.Add(new Model.Person("Bobby", "Male", "Single"));

            Filter.ICriteria male = new Filter.Male();
            Filter.ICriteria female = new Filter.Female();
            Filter.ICriteria single = new Filter.Single();
            Filter.ICriteria singleMale = new Filter.And(single, male);
            Filter.ICriteria singleOrFemale = new Filter.Or(single, female);

            female.MeetCriteria(persons).ForEach(p => Console.WriteLine(p.Name + " - " + p.MaritalStatus));


            Console.ReadKey();
        }
    }
}
