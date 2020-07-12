namespace ChainOfResponsibilityPattern.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal AmountDue { get; internal set; }
    }
}
