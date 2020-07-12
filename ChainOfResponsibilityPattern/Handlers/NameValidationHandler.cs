using ChainOfResponsibilityPattern.Models;
using System;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class NameValidationHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            Console.WriteLine("Validating Name...");

            if (user.Name.Length <= 1)
            {
                throw new ArgumentException("Name is not valid");
            }

            base.Handle(user);
        }
    }
}
