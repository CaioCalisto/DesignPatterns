
namespace Exemplo_1.Commands
{
    public interface ICommand
    {
        bool IsRunning { get; set; }
        void Execute();
    }
}
