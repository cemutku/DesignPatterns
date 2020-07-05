namespace StrategyPattern.Strategies
{
    // This gives us the promise of how to implement our concrete implementations
    public interface ICommunicationStrategy
    {
        public string SendMessage(Message message);
    }
}
