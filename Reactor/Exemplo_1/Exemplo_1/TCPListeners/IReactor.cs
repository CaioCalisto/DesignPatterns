
namespace Exemplo_1.TCPListeners
{
    public interface IReactor
    {
        void RegisterHandle(IEventHandler eventHandler);
        void RemoveHandle(IEventHandler eventHandler);
        void HandleEvents();
    }
}
