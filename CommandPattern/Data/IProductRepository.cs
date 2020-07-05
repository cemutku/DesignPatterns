using CommandPattern.Models;

namespace CommandPattern.Data
{
    public interface IProductRepository
    {
        void Add(Product product);
        void DecreaseStock(Product product, int stockCount);
        Product Find(int id);
        int GetStock(int productId);
        void IncreaseStock(Product product, int stockCount);
    }
}