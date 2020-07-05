using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State Design Pattern Example");
            Console.WriteLine("Creating event for John Doe...");

            BookingContext contextJohn = new BookingContext();
            contextJohn.SubmitDetails("John Doe", 1);

            Console.WriteLine("Closing event...");
            contextJohn.DatePassed();

            Console.WriteLine("****************************************************");            
            
            Console.WriteLine("Creating event for Jane Doe...");

            BookingContext contextJane = new BookingContext();
            contextJane.SubmitDetails("Jane Doe", 2);

            Console.WriteLine("Canceling event...");
            contextJane.Cancel();
        }
    }
}
