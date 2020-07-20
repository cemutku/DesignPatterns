using AdapterPattern.Adapters;
using System.Text;

namespace AdapterPattern
{
    public class ProductService
    {
        private readonly IProductSourceAdapter _productSourceAdapter;

        public ProductService(IProductSourceAdapter productSourceAdapter)
        {
            _productSourceAdapter = productSourceAdapter;
        }

        public string ListProducts()
        {
            var products = _productSourceAdapter.GetProducts();

            var sb = new StringBuilder();
            int nameWidth = 30;

            sb.AppendLine($"{"NAME".PadRight(nameWidth)}   {"Price"}");

            foreach (var product in products)
            {
                sb.AppendLine($"{product.Name.PadRight(nameWidth)}   {product.Price}");
            }

            return sb.ToString();
        }
    }
}
