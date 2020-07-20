using System.Collections.Generic;

namespace AdapterPattern.Adapters
{
    public class ProductApiSourceAdapter : IProductSourceAdapter
    {
        private readonly ProductsApi _productsApi;

        public ProductApiSourceAdapter(ProductsApi productsApi)
        {
            _productsApi = productsApi;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productsApi.GetProductsFromApi();
        }
    }
}
