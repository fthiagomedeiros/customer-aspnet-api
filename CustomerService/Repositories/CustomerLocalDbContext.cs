using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerService.Domain;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Repositories
{
    public class CustomerLocalDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }

        public CustomerLocalDbContext(DbContextOptions<CustomerLocalDbContext> options) 
            : base(options) {}

        public Customer GetCustomer(int id)
        {
            return Customer.FirstOrDefault(customer => customer.Id == id);
        }

        public Customer PostCustomer(Customer customer)
        {
            Customer.Add(customer);
            SaveChanges();
            return customer;
        }

        public ICollection<Customer> GetCustomers()
        {
            return Customer.ToList();
        }

        public Customer UpdateCustomer(int customerId, Customer customer)
        {
            var mCustomer = Customer.FirstOrDefault(c => c.Id == customerId);
            if (mCustomer == null) return null;

            mCustomer.Name = customer.Name;
            Customer.Update(mCustomer);
            SaveChanges();
            return mCustomer;
        }
    }
}
