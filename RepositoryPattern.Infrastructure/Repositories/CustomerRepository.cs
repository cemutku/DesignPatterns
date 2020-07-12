using RepositoryPattern.Infrastructure.Models;
using System.Linq;

namespace RepositoryPattern.Infrastructure.Repositories
{
    public class CustomerRepository : Repository<Customer>
    {
        // We have all the methods (add, update, get, find, save for customer)
        public CustomerRepository(SampleContext context) : base(context)
        {
        }

        public override Customer Update(Customer entity)
        {
            var customer = _context.Cutomers
                .Single(c => c.Id == entity.Id);

            customer.Name = entity.Name;
            customer.Surname = entity.Surname;
            customer.Age = entity.Age;

            return base.Update(customer);
        }

        public Customer Test()
        {
            return new Customer();
        }
    }
}
