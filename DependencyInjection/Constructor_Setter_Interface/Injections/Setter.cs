using Constructor_Setter_Interface.Classes;

namespace Constructor_Setter_Interface.Injections
{
    public class Setter
    {
        public IChild child { get; set; }

        public void RealizarTarefa()
        {
            child.RealizarTarefa();
        }



    }
}
