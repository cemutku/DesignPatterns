using System.Linq;
using System.Threading;
using Xunit;
using Xunit.Abstractions;

namespace Singleton
{
    public class SingletonInstance
    {
        private readonly ITestOutputHelper _output;

        public SingletonInstance(ITestOutputHelper output)
        {
            _output = output;
            Logger.Clear();
        }

        [Fact]
        public void CallsConstructorOnceGivenThreeInstanceCalls()
        {
            Logger.DelayMilliseconds = 10;

            var instance1 = Singleton.Instance;
            Thread.Sleep(1);
            var instance2 = Singleton.Instance;
            Thread.Sleep(1);
            var instance3 = Singleton.Instance;
            Thread.Sleep(3);

            var log = Logger.Output();

            Assert.Equal(3, log.Count(log => log.Contains("Instance")));

            Logger.Output().ToList().ForEach(l => _output.WriteLine(l));
        }
    }
}
