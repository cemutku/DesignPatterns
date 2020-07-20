using System.Collections.Generic;

namespace AdapterPattern
{
    public class ProductFileSource
    {
        public List<Product> GetProductsFromFile(string filePath)
        {
            // This is a sample product list, retrieved from a file - incompatible with client

            List<Product> products = new List<Product>
            {
                new Product() { Id = 1, Name = $"Computer from {filePath}", Price = 1000M},
                new Product() { Id = 2, Name = $"Phone    from {filePath}", Price = 2000M},
                new Product() { Id = 3, Name = $"Keyboard from {filePath}", Price = 3000M},
            };

            return products;
        }
    }
}
