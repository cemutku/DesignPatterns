using RepositoryPattern.Infrastructure.Models;
using RepositoryPattern.Infrastructure.Repositories;

namespace RepositoryPattern.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Customer> CustomerRepository { get; }
        IRepository<Product> ProductRepository { get; }

        void SaveChanges();
    }
}
