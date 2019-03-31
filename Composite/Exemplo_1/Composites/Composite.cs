using System;
using System.Collections.Generic;

namespace Exemplo_1.Composites
{
    public class Composite : DrawingElement
    {
        private List<DrawingElement> elements;
        public Composite(string name)
            : base(name)
        {
            elements = new List<DrawingElement>();
        }

        public override void Add(DrawingElement element)
        {
            elements.Add(element);
        }

        public override void Remove(DrawingElement element)
        {
            elements.Remove(element);
        }

        public override void Display(int id)
        {
            Console.WriteLine(string.Format("{0} - {1}", id, name));

            foreach(DrawingElement e in elements)
            {
                e.Display(id + 2);
            }
        }


    }
}
