using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Controllers
{
    [Route("api/Products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static List<Product>Products { get; set; } = new List<Product> ();
        // GET: api/<Prodact>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return Products;
        }

        // GET api/<Prodact>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            Product product = new Product() ;
            product= Products.Find(i=>i.Id==id);
            if (product!=null)
            {
                return product;
            }
            return null;
        }

        // POST api/<Prodact>
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            Products.Add(value);
        }

        // PUT api/<Prodact>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            Product product;
            product = Products.Find(i => i.Id == id);
            if (product != null)
            {
                product.Name=value.Name;
                product.Price=value.Price;
            }
     
        }

        // DELETE api/<Prodact>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Product product;
            product = Products.Find(i => i.Id == id);
            Products.Remove(product);

        }
    }
}
