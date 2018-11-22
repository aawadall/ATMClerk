namespace Events
{
    /// <summary>
    /// Interface to Cash Events
    /// </summary>
    public interface ICashEvent
    {
        IEventClass GetClass();
        IEventType GetType();
        IEventDetails GetDetails();
    }
}