namespace FactoryPattern.Business
{
    public class Truck : ITransport
    {
        public string Deliver()
        {
            return "Road Transportation - Truck";
        }
    }
}
