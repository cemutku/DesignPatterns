using CommandPattern.Models;

namespace CommandPattern.Data
{
    public interface IShoppingCartRepository
    {
        void Add(Product product);
        void DecreaseQuantity(Product product);
        (Product Product, int Quantity) Get(int productId);
        void IncreaseQuantity(Product product);
        void RemoveAll(Product product);
    }
}