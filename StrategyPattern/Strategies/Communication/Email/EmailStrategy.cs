namespace StrategyPattern.Strategies
{
    public class EmailStrategy : ICommunicationStrategy
    {
        // Send Email
        public string SendMessage(Message message)
        {
            return $"EmailStrategy - { message.MessageContent}";
        }
    }
}
