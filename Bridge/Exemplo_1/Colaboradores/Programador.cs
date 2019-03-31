using System; 
using Exemplo_1.Tarefa;

namespace Exemplo_1.Colaboradores
{
    public class Programador : IColaborador
    {
        private ITarefa tarefa;

        public Programador(ITarefa tarefa)
        {
            this.tarefa = tarefa;
        }

        public void Produz()
        {
            Console.WriteLine("Programador trabalhando");
            this.tarefa.Realiza();
        }

        public void RecebeTarefa(ITarefa tarefa)
        {
            this.tarefa = tarefa;
        }
    }
}
