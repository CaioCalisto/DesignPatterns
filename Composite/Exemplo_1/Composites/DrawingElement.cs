
namespace Exemplo_1.Composites
{
    public abstract class DrawingElement
    {
        protected string name;

        public DrawingElement(string name)
        {
            this.name = name;
        }

        public abstract void Add(DrawingElement element);
        public abstract void Remove(DrawingElement element);
        public abstract void Display(int id);

    }
}
