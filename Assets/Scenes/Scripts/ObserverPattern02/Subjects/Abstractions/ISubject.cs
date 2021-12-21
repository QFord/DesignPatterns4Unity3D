using WeatherStation.Observers;

namespace WeatherStation.Subjects
{
    /// <summary>
    /// The Subject knows its Observers and provides an interface for adding or removing any number of Observer objects.
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Register/Attach/Add an observer to the subject.
        /// </summary>
        /// <param name="o"></param>
        void RegisterObserver(IObserver o);

        /// <summary>
        /// Unregister/Remove/Detach an observer from the subject.
        /// </summary>
        /// <param name="o"></param>
        void RemoveObserver(IObserver o);

        void NotifyObservers();
    }
}
