using Exemplo1.Parts;

namespace Exemplo1
{
    public interface IVisitor
    {
        void Visit(Keyboard keyboard);
        void Visit(Mouse mouse);
        void Visit(Monitor monitor);
        void Visit(Computer computer);
    }
}
