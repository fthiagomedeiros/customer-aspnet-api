using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CustomerService.Domain;

namespace CustomerService.Repositories
{
    public class CustomerRepositoryImpl : ICustomerRepository
    {
        private ICollection<Customer> Customers { get; set; }

        public CustomerRepositoryImpl()
        {
            Customers = new Collection<Customer>();
        }

        public Customer GetCustomer(int id)
        {
            var aCustomer = Customers.FirstOrDefault(c => c.Id == id);
            return aCustomer;
        }

        public Customer PostCustomer(Customer customer)
        {
            Customers.Add(customer);
            return customer;
        }
    }
}
