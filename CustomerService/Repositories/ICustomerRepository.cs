using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerService.Domain;

namespace CustomerService.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int id);
        Customer PostCustomer(Customer customer);
        ICollection<Customer> GetCustomers();
        Customer UpdateCustomer(int customerId, Customer customer);
    }
}
