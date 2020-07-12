using FactoryPattern.Business;

namespace FactoryPattern.Factories
{
    public class AirTransportFactory : TransportFactory
    {
        public override ITransport CreateTransport(string name)
        {
            return new Airplane();
        }
    }
}
