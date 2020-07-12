using FactoryPattern.Business;

namespace FactoryPattern.Factories
{
    public class RoadTransportFactory : TransportFactory
    {
        public override ITransport CreateTransport(string name)
        {
            return new Truck();
        }
    }
}
