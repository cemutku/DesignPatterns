using StrategyPattern.Strategies;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new Message
            {
                Id = 1,
                MessageContent = "Strategy Message",
                CommunicationStrategy = new EmailStrategy()
            };

            Console.WriteLine(message.SendMessage());
            Console.ReadKey();
        }
    }
}
