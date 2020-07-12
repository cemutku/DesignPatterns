using ChainOfResponsibilityPattern.Models;
using System;
using System.Collections.Generic;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class PaymentHandler
    {
        private readonly IList<IReceiver<Order>> _receivers;

        public PaymentHandler(params IReceiver<Order>[] receivers)
        {
            _receivers = receivers;
        }

        public virtual void Handle(Order order)
        {
            foreach (var receiver in _receivers)
            {
                Console.WriteLine($"Executing: {receiver.GetType().Name}");

                if (order.AmountDue > 0)
                {
                    receiver.Handle(order);
                }
                else
                {
                    break;
                }
            }

            if (order.AmountDue > 0)
            {
                throw new ArgumentException("Insufficient payment");
            }
            else
            {
                Console.WriteLine("Order is ready for shippment");
            }
        }

        public void SetNext(IReceiver<Order> next)
        {
            _receivers.Add(next);
        }
    }
}
