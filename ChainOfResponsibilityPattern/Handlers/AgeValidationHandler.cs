using ChainOfResponsibilityPattern.Models;
using System;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class AgeValidationHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            Console.WriteLine("Validating Age...");

            if (user.Age < 18)
            {
                throw new ArgumentException("Age is not valid");
            }

            base.Handle(user);
        }
    }
}
