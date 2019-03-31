using System;

namespace Exemplo_1.Composites
{
    public class Primitive : DrawingElement
    {
        public Primitive(string name)
            : base(name)
        { }

        public override void Add(DrawingElement element)
        {
            Console.WriteLine("Cannot add to a PrimitiveElement");
        }

        public override void Remove(DrawingElement element)
        {
            Console.WriteLine("Cannot remove from a PrimitiveElement");
        }

        public override void Display(int id)
        {
            Console.WriteLine(string.Format("{0} - {1}", id, name));
        }
    }
}
