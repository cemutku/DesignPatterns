using CommandPattern.Models;
using System.Collections.Generic;

namespace CommandPattern.Data
{
    public class ProductRepository : IProductRepository
    {
        List<Product> productStock;

        public ProductRepository()
        {
            productStock = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name="Laptop",
                    Price=20000,
                    Stock = 5
                },
                new Product
                {
                    Id = 2,
                    Name="Phone",
                    Price=10000,
                    Stock = 3
                },
                new Product
                {
                    Id = 3,
                    Name="Keyboard",
                    Price=10000,
                    Stock = 10
                }
            };
        }

        public void Add(Product product)
        {
            productStock.Add(product);
        }

        public void DecreaseStock(Product product, int stockCount)
        {
            var selectedProduct = productStock.Find(p => p.Id == product.Id);
            if (selectedProduct == null) return;

            selectedProduct.Stock -= stockCount;
        }

        public void IncreaseStock(Product product, int stockCount)
        {
            var selectedProduct = productStock.Find(p => p.Id == product.Id);
            if (selectedProduct == null) return;

            selectedProduct.Stock += stockCount;
        }

        public Product Find(int id)
        {
            return productStock.Find(p => p.Id == id);
        }

        public int GetStock(int productId)
        {
            var product = productStock.Find(p => p.Id == productId);

            if (product == null) return 0;

            return product.Stock;
        }
    }
}
