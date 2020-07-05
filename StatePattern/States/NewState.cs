using System;

namespace StatePattern.States
{
    public class NewState : BookingState
    {
        public override void Cancel(BookingContext context)
        {
            context.TransitionToState(new ClosedState($"Booking Canceled id : {context.BookingId}"));
        }

        public override void DatePassed(BookingContext context)
        {
            context.TransitionToState(new ClosedState($"Booking Expired, id : {context.BookingId}"));
        }

        public override void EnterDetails(BookingContext context, string attendee, int ticketCount)
        {
            context.Attendee = attendee;
            context.TicketCount = ticketCount;
            context.TransitionToState(new BookedState());
        }

        public override void EnterState(BookingContext context)
        {
            context.BookingId = new Random().Next();            
            Console.WriteLine($"Created new event id : {context.BookingId}");
        }
    }
}
