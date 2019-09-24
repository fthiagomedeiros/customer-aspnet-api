using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerService.Domain;

namespace CustomerService.Services
{
    public interface ICustomerService
    {
        ICollection<Customer> GetCustomers();
        Customer GetCustomer(int id);
        Customer PostCustomer(Customer customer);
        Customer UpdateCustomer(int customerId, Customer customer);
    }
}
