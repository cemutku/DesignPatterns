using FactoryPattern.Factories;
using System;

namespace FactoryPattern.Business
{
    public class Mail
    {
        private readonly string _mailItem;
        private readonly TransportFactory _transportFactory;

        public Mail(string mailItem, TransportFactory transportFactory)
        {
            _mailItem = mailItem;
            _transportFactory = transportFactory;
        }
        public void DeliverMail()
        {
            Console.WriteLine("Preparing mail delivery plan...");
            var transport = _transportFactory.CreateTransport(_mailItem);

            var deliveryPlan = transport.Deliver();
            Console.WriteLine($"Mail sent via {deliveryPlan}");
        }
    }
}
