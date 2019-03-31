using Exemplo_1.Operations;

namespace Exemplo_1
{
    public class Context
    {
        private IOperation operation;

        public Context(IOperation operation)
        {
            this.operation = operation;
        }

        public int DoOperation(int n1, int n2)
        {
            return operation.DoOperation(n1, n2);
        }

    }
}
