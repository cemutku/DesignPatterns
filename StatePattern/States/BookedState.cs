using System;

namespace StatePattern.States
{
    public class BookedState : BookingState
    {
        public override void Cancel(BookingContext context)
        {
            context.TransitionToState(new ClosedState($"Booking canceled id : {context.BookingId}"));
        }

        public override void DatePassed(BookingContext context)
        {
            context.TransitionToState(new ClosedState("We hope you enjoyed!"));
        }

        public override void EnterDetails(BookingContext context, string attendee, int ticketCount)
        {

        }

        public override void EnterState(BookingContext context)
        {
            Console.WriteLine($"Event with id {context.BookingId} is booked Attendee : {context.Attendee} Ticket Count : {context.TicketCount}");
        }
    }
}
