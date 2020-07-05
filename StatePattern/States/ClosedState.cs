using System;

namespace StatePattern.States
{
    public class ClosedState : BookingState
    {
        private string reasonClosed;

        public ClosedState(string reason)
        {
            reasonClosed = reason;
        }

        public override void Cancel(BookingContext context)
        {            
            Console.WriteLine($"Invalid action for closed state id : {context.BookingId}");
        }

        public override void DatePassed(BookingContext context)
        {            
            Console.WriteLine($"Invalid action for closed state id : {context.BookingId}");
        }

        public override void EnterDetails(BookingContext context, string attendee, int ticketCount)
        {
            Console.WriteLine($"Invalid action for closed state id : {context.BookingId}");
        }

        public override void EnterState(BookingContext context)
        {
            Console.WriteLine($"Event ({context.BookingId}) closed : {reasonClosed} for {context.Attendee} ");
        }
    }
}
