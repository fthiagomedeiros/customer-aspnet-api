using CustomerService.Domain;
using CustomerService.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerService.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            var customer = _customerService.GetCustomers();

            return Ok(customer);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var customer = _customerService.GetCustomer(id);
            if (customer == null) return NotFound();

            return Ok(customer);
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            if (IsModelInvalid()) return BadRequest();
            var aCustomer = _customerService.PostCustomer(customer);

            return Ok(aCustomer);

        }

        // PUT api/<controller>/5
        [HttpPut("{customerId}")]
        public IActionResult Put(int customerId, [FromBody] Customer customer)
        {
            if (IsModelInvalid()) return BadRequest();

            var customerToUpdate = _customerService.UpdateCustomer(customerId, customer);
            if (customer == null) return NotFound();

            return Ok(customerToUpdate);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
        }

        private bool IsModelInvalid()
        {
            return !ModelState.IsValid;
        }
    }
}
