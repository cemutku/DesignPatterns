using System.Collections.Generic;

namespace AdapterPattern.Adapters
{
    public class ProductFileSourceAdapter : IProductSourceAdapter
    {
        private readonly ProductFileSource _productFileSource;
        private string _fileName;

        public ProductFileSourceAdapter(string fileName, ProductFileSource productFileSource)
        {
            _fileName = fileName;
            _productFileSource = productFileSource;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productFileSource.GetProductsFromFile(_fileName);
        }
    }
}
