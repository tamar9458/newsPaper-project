using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Controllers
{
    [Route("api/Workers")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        static List<Worker> Workers { get; set; } = new List<Worker>();
        // GET: api/<Worker>
        [HttpGet]
        public IEnumerable<Worker> Get()
        {
            return Workers;
        }

        // GET api/<Worker>/5
        [HttpGet("{id}")]
        public Worker Get(int id)
        {
            Worker worker;
            worker = Workers.Find(i => i.Id== id);
            if (worker != null) {
                return worker;
            }
            return null;
        }

        // POST api/<Worker>
        [HttpPost]
        public void Post([FromBody] Worker value)
        {
            Workers.Add(value);

        }

        // PUT api/<Worker>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Worker value)
        {
            Worker worker;
            worker = Workers.Find(i => i.Id == id);
            if (worker != null)
            {
                worker.Adress=value.Adress; 
                worker.Name=value.Name;
                worker.Pon=value.Pon;
                worker.Salary=value.Salary;
            }
        }

        // DELETE api/<Worker>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Worker worker;
            worker = Workers.Find(i => i.Id == id);
            if (worker != null)
            {
               Workers.Remove(worker);
            }

        }
    }
}
