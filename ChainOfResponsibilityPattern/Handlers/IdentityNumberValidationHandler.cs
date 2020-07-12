using ChainOfResponsibilityPattern.Models;
using System;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class IdentityNumberValidationHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            Console.WriteLine("Validating IdentityNumber...");

            if (user.IdentityNumber.Length < 10)
            {
                throw new ArgumentException("IdentityNumber is not valid");
            }

            base.Handle(user);
        }
    }
}
