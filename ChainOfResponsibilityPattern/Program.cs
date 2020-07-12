using ChainOfResponsibilityPattern.Handlers;
using ChainOfResponsibilityPattern.Models;
using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1 Validation Handlers

            Console.WriteLine("Example 1 is running (IHandler)...\n");

            try
            {
                User user = new User
                {
                    Age = 30,
                    IdentityNumber = "1232",
                    Name = "C"
                };

                var handler = new IdentityNumberValidationHandler();

                handler.SetNext(new AgeValidationHandler())
                    .SetNext(new NameValidationHandler());

                handler.Handle(user);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error : {ex.Message}\n");
            }

            Console.WriteLine("Example 1 is finished (IHandler)...\n");

            #endregion

            Console.WriteLine("***********************************\n");

            #region Example 2 Payment Handlers
            
            Console.WriteLine("Example 2 is running (IReceiver)...\n");
            
            try
            {
                Order order = new Order()
                {
                    Id = 1,
                    AmountDue = 10M,
                };

                var handler = new PaymentHandler(
                    new CreditCardHandler(),
                    new InvoiceHandler()
                );

                handler.Handle(order);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error : {ex.Message}\n");
            }

            Console.WriteLine("Example 2 is finished (IReceiver)...");

            #endregion
        }
    }
}
