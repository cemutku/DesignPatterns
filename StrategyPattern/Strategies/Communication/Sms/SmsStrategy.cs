using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategies
{
    public class SmsStrategy : ICommunicationStrategy
    {
        // Send Sms
        public string SendMessage(Message message)
        {
            return $"SmsStrategy - { message.MessageContent}";
        }
    }
}
