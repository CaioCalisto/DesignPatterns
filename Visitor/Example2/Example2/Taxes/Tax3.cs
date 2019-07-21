using Example2.Employees;

namespace Example2.Taxes
{
    public class Tax3 : IVisitor
    {
        public void Calculate(Element element)
        {
            Employee employee = element as Employee;
            double deduction = employee.GrossSalary;
            if (employee.GrossSalary < 800)
            {
                deduction = deduction * 0.15;
                employee.Deduct(deduction);
            }
            else
            {
                deduction = deduction * 0.18;
                employee.Deduct(deduction);
            }
        }
    }
}
