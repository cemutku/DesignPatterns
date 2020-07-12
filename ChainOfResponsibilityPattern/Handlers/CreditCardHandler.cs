using ChainOfResponsibilityPattern.Models;
using ChainOfResponsibilityPattern.PaymentProcessors;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class CreditCardHandler : IReceiver<Order>
    {
        private CreditCardPaymentProcessor creditCardPaymentProcessor { get; }
            = new CreditCardPaymentProcessor();
        public void Handle(Order order)
        {
            creditCardPaymentProcessor.Finalize(order);
        }
    }
}
