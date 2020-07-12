namespace FactoryPattern.Business
{
    public class Airplane : ITransport
    {
        public string Deliver()
        {
            return "Air Transportation - Airplane";
        }
    }
}
