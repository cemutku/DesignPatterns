using System.Collections.Generic;

namespace AdapterPattern
{
    public class ProductsApi
    {
        public List<Product> GetProductsFromApi()
        {
            // This is a sample product list, retrieved by using HttpClient incompatible with client

            List<Product> products = new List<Product>
            {
                new Product() { Id = 1, Name = "Computer from Product API", Price = 1000M},
                new Product() { Id = 2, Name = "Phone    from Product API", Price = 2000M},
                new Product() { Id = 3, Name = "Keyboard from Product API", Price = 3000M},
            };

            return products;
        }
    }
}
