using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            DAO.Employees employeeList = new DAO.Employees();
            employeeList.Add("Caio", 1000);
            employeeList.Add("Natalia", 1400);

            employeeList.AcceptDeduction(new Taxes.Tax1());
            employeeList.AcceptDeduction(new Taxes.Tax2());

            foreach(var employee in employeeList.GetEmployees())
            {
                Console.WriteLine($"\nName: {employee.Name}, Gross: {employee.GrossSalary}, Net: {employee.NetSalary}");
            }

            Console.ReadKey();
        }
    }
}
