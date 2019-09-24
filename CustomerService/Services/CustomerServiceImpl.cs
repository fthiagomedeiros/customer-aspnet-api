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
        public ICollection<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }

        public Customer GetCustomer(int id)
        {
            return _customerRepository.GetCustomer(id);
        }

        public Customer PostCustomer(Customer customer)
        {
            return _customerRepository.PostCustomer(customer);
        }

        public Customer UpdateCustomer(int customerId, Customer customer)
        {
            var mCustomer = _customerRepository.UpdateCustomer(customerId, customer);
            return mCustomer;
        }
    }
}
