namespace StatePattern.States
{
    public abstract class BookingState
    {        
        public abstract void EnterState(BookingContext context);
        public abstract void Cancel(BookingContext context);
        public abstract void DatePassed(BookingContext context);
        public abstract void EnterDetails(BookingContext context, string attendee, int ticketCount);
    }
}
