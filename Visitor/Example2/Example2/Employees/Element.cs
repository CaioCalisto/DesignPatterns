using Example2.Taxes;

namespace Example2.Employees
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
