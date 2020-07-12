using ChainOfResponsibilityPattern.Models;
using ChainOfResponsibilityPattern.PaymentProcessors;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class InvoiceHandler : IReceiver<Order>
    {
        private InvoicePaymentProcessor invoicePaymentProcessor { get; }
            = new InvoicePaymentProcessor();
        public void Handle(Order order)
        {
            invoicePaymentProcessor.Finalize(order);
        }
    }
}
