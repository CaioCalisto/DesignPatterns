using Example2.Employees;

namespace Example2.Taxes
{
    public interface IVisitor
    {
        void Calculate(Element element);
    }
}
