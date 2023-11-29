using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagingANewspaper.Controllers
{
    [Route("api/Writers")]
    [ApiController]
    public class WriterController : ControllerBase
    {
        private DataWriter dataWriter;
        public DesignerController(DataWriter dd)
        {
            dataWriter = dd;
        }
        // GET: api/<Worker>
        [HttpGet]
        public IEnumerable<Writer> Get()
        {
            return dataWriter._Writers;
        }

        // GET api/<Worker>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Writer writer;
            writer = dataWriter._Writers.Find(i => i.Id== id);
            if (writer != null) {
                return Ok(writer);
            }
            return NotFound();
        }

        // POST api/<Worker>
        [HttpPost]
        public void Post([FromBody] Writer value)
        {
            dataWriter._Writers.Add(value);


        }

        // PUT api/<Worker>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Writer value)
        {
            Writer writer;
            writer = dataWriter._Writers.Find(i => i.Id == id);
            if (writer != null)
            {
                writer.Adress=value.Adress; 
                writer.Name=value.Name;
                writer.Phone=value.Phone;
                writer.Salary=value.Salary;
                writer.TWriter=value.TWriter;  
                writer.Priority=value.Priority;
                return Ok(writer);  
            }
            return NotFound();
        }

        // DELETE api/<Worker>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Writer writer;
            writer = dataWriter._Writers.Find(i => i.Id == id);
            if (writer != null)
            {
               dataWriter._Writers.Remove(writer);
               return Ok(writer);

            }
            return NotFound();

        }
    }
}
