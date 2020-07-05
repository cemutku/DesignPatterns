using System;

namespace Singleton
{
    // source : https://csharpindepth.com/articles/singleton
    public sealed class Singleton
    {
        // we do not need to check if it is null with Lazy<T>
        // thread-safe
        public static readonly Lazy<Singleton> _lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance
        {
            get
            {                
                Logger.Log("Instance called.");
                return _lazy.Value;
            }
        }

        private Singleton()
        {
            Logger.Log("Constructor invoked.");
        }
    }
}
