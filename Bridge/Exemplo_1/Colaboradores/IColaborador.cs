using Exemplo_1.Tarefa;

namespace Exemplo_1.Colaboradores
{
    public interface IColaborador
    {
        void Produz();
        void RecebeTarefa(ITarefa tarefa);
    }
}
