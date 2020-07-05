using RepositoryPattern.Infrastructure.Models;
using System.Linq;

namespace RepositoryPattern.Infrastructure.Repositories
{
    // we can override functionality in the repository to make sure that we include referenced entities and optionally eagerly load them
    public class ProductRepository : Repository<Product>
    {
        // after that we can now define a ProductRepository 
        // with below code have all the generic properties, we can override methods if we want
        // We have all the methods (add, update, get, find, save for product)
        public ProductRepository(SampleContext context) : base(context)
        {
        }

        public override Product Update(Product entity)
        {
            var product = _context.Products
                .Single(p => p.Id == entity.Id);

            product.Name = entity.Name;
            product.Price = entity.Price;

            return base.Update(product);
        }
    }
}
