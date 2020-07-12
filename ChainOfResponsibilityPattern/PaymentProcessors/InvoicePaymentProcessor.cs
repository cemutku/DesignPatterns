using ChainOfResponsibilityPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.PaymentProcessors
{
    public class InvoicePaymentProcessor : IPaymentProcessor
    {
        public void Finalize(Order order)
        {
            Console.WriteLine("Invoice created and emailed");
        }
    }
}
