using Example2.Taxes;

namespace Example2.Employees
{
    public class Employee : Element
    {
        public string Name { get; set; }
        public double GrossSalary { get; set; }
        public double NetSalary { get; private set; }

        public Employee(string name, double grossSalary)
        {
            this.Name = name;
            this.GrossSalary = grossSalary;
            this.NetSalary = grossSalary;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Calculate(this);
        }

        public void Deduct(double amount)
        {
            this.NetSalary -= amount;
        }
        
    }
}
