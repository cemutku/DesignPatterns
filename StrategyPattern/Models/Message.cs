using StrategyPattern.Strategies;

namespace StrategyPattern
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageContent { get; set; }
        public ICommunicationStrategy CommunicationStrategy { get; set; }
        public string SendMessage()
        {
            if (CommunicationStrategy != null)
            {
                return CommunicationStrategy.SendMessage(this);
            }

            return string.Empty;
        }
    }
}
