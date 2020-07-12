using FactoryPattern.Business;
using FactoryPattern.Factories;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Mail Delivery");

            Mail mail = new Mail("Mail Items", new RoadTransportFactory());
            mail.DeliverMail();

            //Mail mail = new Mail("Mail Items", new AirTransportFactory());
            //mail.DeliverMail();
        }
    }
}
