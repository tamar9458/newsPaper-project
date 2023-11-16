using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Controllers
{
    [Route("api/Customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<Customer>
        static List<Customer> Customers { get; set; } = new List<Customer>();
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return Customers;
        }

        // GET api/<Customer>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            Customer customer = new Customer();
            customer = Customers.Find(i => i.Id == id);
            if (customer != null)
            {
                return customer;
            }
            return null;
        }

        // POST api/<Customer>
        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            Customers.Add(value);
        }

        // PUT api/<Customer>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value)
        {
            Customer customer;
            customer = Customers.Find(i => i.Id == id);
            if (customer != null)
            {
                customer.Name = value.Name;
                customer.Pon= value.Pon;
                customer.Adress= value.Adress;
            }

        }

        // DELETE api/<Customer>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Customer customer;
            customer = Customers.Find(i => i.Id == id);
            if (customer != null)
            {
                Customers.Remove(customer);
            }
        }
    }
}
