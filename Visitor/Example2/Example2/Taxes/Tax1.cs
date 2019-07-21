using Example2.Employees;

namespace Example2.Taxes
{
    public class Tax1 : IVisitor
    {
        public void Calculate(Element element)
        {
            Employee employee = element as Employee;
            double deduction = employee.GrossSalary;
            if (employee.GrossSalary < 600)
            {
                deduction = deduction * 0.10;
                employee.Deduct(deduction);
            }
            else
            {
                deduction = deduction * 0.12;
                employee.Deduct(deduction);
            }
        }
    }
}
