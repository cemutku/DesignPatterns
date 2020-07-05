using System;

namespace RepositoryPattern.Infrastructure.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }        
    }
}
