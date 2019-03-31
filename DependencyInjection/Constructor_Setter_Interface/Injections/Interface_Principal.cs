using Constructor_Setter_Interface.Classes;

namespace Constructor_Setter_Interface.Injections
{
    public class Interface_Principal : Interface
    {
        private IChild child;

        public void InjetarDependencia(IChild child)
        {
            this.child = child;
        }

        public void RealizarTarefa()
        {
            this.child.RealizarTarefa();
        }

    }
}
