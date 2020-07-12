using ChainOfResponsibilityPattern.Models;
using System;

namespace ChainOfResponsibilityPattern.PaymentProcessors
{
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void Finalize(Order order)
        {
            Console.WriteLine("Credit Card Payment");
        }
    }
}
