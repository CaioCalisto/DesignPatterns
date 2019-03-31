using Constructor_Setter_Interface.Classes;

namespace Constructor_Setter_Interface.Injections
{
    public class Constructor
    {
        private IChild child;

        public Constructor(IChild child)
        {
            this.child = child;
        }

        public void RealizarTarefa()
        {
            this.child.RealizarTarefa();
        }
    }
}
