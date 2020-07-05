using StatePattern.States;

namespace StatePattern
{
    public class BookingContext
    {
        public int BookingId { get; set; }
        public int TicketCount { get; internal set; }
        public string Attendee { get; internal set; }

        private BookingState curremtState;

        public BookingContext()
        {
            TransitionToState(new NewState());
        }

        public void TransitionToState(BookingState state)
        {
            curremtState = state;
            curremtState.EnterState(this);
        }

        public void SubmitDetails(string attendee, int ticketCount)
        {
            curremtState.EnterDetails(this, attendee, ticketCount);
        }

        public void Cancel()
        {
            curremtState.Cancel(this);
        }

        public void DatePassed()
        {
            curremtState.DatePassed(this);
        }
    }
}
