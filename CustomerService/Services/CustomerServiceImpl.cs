using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerService.Domain;
using CustomerService.Repositories;

namespace CustomerService.Services
{
    public class CustomerServiceImpl : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerServiceImpl(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer GetCustomer(int id)
        {
            return _customerRepository.GetCustomer(id);
        }

        public Customer PostCustomer(Customer customer)
        {
            return _customerRepository.PostCustomer(customer);
        }
    }
}
