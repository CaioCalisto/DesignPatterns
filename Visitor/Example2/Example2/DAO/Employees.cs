using Example2.Employees;
using Example2.Taxes;
using System.Collections.Generic;
using System.Linq;

namespace Example2.DAO
{
    public class Employees
    {
        private List<Employee> employees;

        public Employees()
        {
            this.employees = new List<Employee>();
        }

        public void Add(string name, double grossSalary)
        {
            this.employees.Add(new Employee(name, grossSalary));
        }

        public void Detach(string name)
        {
            Employee employee = this.employees.Where(e => e.Name == name).FirstOrDefault();
            if (employee != null)
                this.employees.Remove(employee);
        }

        public void AcceptDeduction(IVisitor deduction)
        {
            foreach (Employee employee in this.employees)
                employee.Accept(deduction);
        }

        public List<Employee> GetEmployees()
        {
            return this.employees;
        }
    }
}
