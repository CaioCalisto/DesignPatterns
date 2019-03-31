using System;

namespace Exemplo_1
{
    /*
      Desacopla a abstração de sua implementação e então eles 
      podem variar independentemente

      Quando usar:
       - voce quer evitar uma ligação obrigatoria entre a abstração
            e a implementação. Isso pode ser o caso, por exemplo, quando 
            a implementação deve selecionar em run-time
       - ambas as abstrações e implementações devem ser extendivel por subclasses.
       - mudanças na implementação da abstração não devem impactar o cliente
       - voce quer esconder a implementação da abstração do seu cliente
       - 
    */
    class Program
    {
        static void Main(string[] args)
        {
            Tarefa.ITarefa tarefaDoProgramador = new Tarefa.ProgramacaoJava();
            Colaboradores.IColaborador programador = new Colaboradores.Programador(tarefaDoProgramador);
            programador.Produz();

            programador.RecebeTarefa(new Tarefa.ProgramacaoRubi());
            programador.Produz();

            Tarefa.ITarefa tarefaDoHomologador = new Tarefa.TestesAutomatizados();
            Colaboradores.IColaborador homologador = new Colaboradores.Homologador(tarefaDoHomologador);
            homologador.Produz();

            homologador.RecebeTarefa(new Tarefa.ProgramacaoRubi());
            homologador.Produz();

            Console.ReadKey();
        }
    }
}
