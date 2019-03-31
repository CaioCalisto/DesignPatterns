using System; 
using Exemplo_1.Tarefa;

namespace Exemplo_1.Colaboradores
{
    public class Homologador : IColaborador
    {
        private ITarefa tarefa;

        public Homologador(ITarefa tarefa)
        {
            this.tarefa = tarefa;
        }

        public void Produz()
        {
            Console.WriteLine("Homologador trabalhando");
            this.tarefa.Realiza();
        }

        public void RecebeTarefa(ITarefa tarefa)
        {
            this.tarefa = tarefa;
        }
    }
}
