using System.Collections.Generic;

namespace AdapterPattern.Adapters
{
    public interface IProductSourceAdapter
    {
        IEnumerable<Product> GetProducts();
    }
}
