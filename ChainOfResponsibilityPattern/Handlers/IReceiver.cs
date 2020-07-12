namespace ChainOfResponsibilityPattern.Handlers
{
    public interface IReceiver<T> where T : class
    {
        void Handle(T request);
    }
}
