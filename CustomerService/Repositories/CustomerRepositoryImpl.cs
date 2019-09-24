using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CustomerService.Domain;

namespace CustomerService.Repositories
{
    public class CustomerRepositoryImpl : ICustomerRepository
    {
        private ICollection<Customer> Customers { get; }

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

        public ICollection<Customer> GetCustomers()
        {
            return Customers;
        }

        public Customer UpdateCustomer(int customerId, Customer customer)
        {
            for (var position = 0; position < Customers.Count; )
            {
                var theCustomer = Customers.ElementAt(position);

                if (theCustomer.Id != customerId) continue;
                Customers.ElementAt(position).name = customer.name;
                return Customers.ElementAt(position);

            }
            return null;
        }
    }
}
