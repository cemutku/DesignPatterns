using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Infrastructure.Models;
using RepositoryPattern.Infrastructure.Repositories;
using System;
using System.Collections.Generic;

namespace RepositoryPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // controller does not know about what database is being used!
        private readonly IRepository<Customer> _customerRepository;

        public CustomersController(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerRepository.All();
        }

        [HttpGet("{id}", Name = "Get")]
        public Customer Get(Guid id)
        {
            return _customerRepository.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            _customerRepository.Add(customer);
            _customerRepository.SaveChanges();
        }
    }
}