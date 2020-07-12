using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.PaymentProcessors
{
    public interface IPaymentProcessor
    {
        void Finalize(Order order);
    }
}
