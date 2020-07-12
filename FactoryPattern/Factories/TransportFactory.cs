using FactoryPattern.Business;

namespace FactoryPattern.Factories
{
    public abstract class TransportFactory
    {
        public abstract ITransport CreateTransport(string name);
    }
}
