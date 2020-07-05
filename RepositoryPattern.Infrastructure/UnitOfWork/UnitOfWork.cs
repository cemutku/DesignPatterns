using RepositoryPattern.Infrastructure.Models;
using RepositoryPattern.Infrastructure.Repositories;

namespace RepositoryPattern.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SampleContext _context;

        public UnitOfWork(SampleContext context)
        {
            _context = context;
        }

        private IRepository<Customer> customerRepository;
        public IRepository<Customer> CustomerRepository
        {
            get
            {
                if (customerRepository == null)
                {
                    customerRepository = new CustomerRepository(_context);
                }

                return customerRepository;
            }
        }

        private IRepository<Product> productRepository;
        public IRepository<Product> ProductRepository
        {
            get
            {
                if (productRepository == null)
                {
                    productRepository = new ProductRepository(_context);
                }

                return productRepository;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
