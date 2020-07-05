using CommandPattern.Models;
using System.Collections.Generic;

namespace CommandPattern.Data
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        public Dictionary<int, (Product Product, int Quantity)> LineItems
            = new Dictionary<int, (Product product, int Quantity)>();

        public void Add(Product product)
        {
            if (LineItems.ContainsKey(product.Id))
            {
                IncreaseQuantity(product);
            }
            else
            {
                LineItems.Add(product.Id, (product, 1));
            }
        }

        public (Product Product, int Quantity) Get(int productId)
        {
            if (LineItems.ContainsKey(productId))
            {
                return LineItems[productId];
            }

            return (default, default);
        }

        public void IncreaseQuantity(Product product)
        {
            if (LineItems.ContainsKey(product.Id))
            {
                var lineItem = LineItems[product.Id];
                LineItems[product.Id] = (lineItem.Product, lineItem.Quantity + 1);
            }
            else
            {
                throw new KeyNotFoundException($"Key with {product.Id} not found");
            }
        }

        public void DecreaseQuantity(Product product)
        {
            if (LineItems.ContainsKey(product.Id))
            {
                var lineItem = LineItems[product.Id];

                if (lineItem.Quantity == 1)
                {
                    LineItems.Remove(product.Id);
                }
                else
                {
                    LineItems[product.Id] = (lineItem.Product, lineItem.Quantity - 1);
                }
            }
            else
            {
                throw new KeyNotFoundException($"Key with {product.Id} not found");
            }
        }

        public void RemoveAll(Product product)
        {
            LineItems.Remove(product.Id);
        }
    }
}
