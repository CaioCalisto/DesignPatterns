
namespace Exemplo_1.Observers
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
        void SetMeasurements(float temperature, float humidity, float pressure);
    }
}
