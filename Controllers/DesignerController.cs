using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagingANewspaper.Controllers
{
    [Route("api/_Designers")]
    [ApiController]
    public class DesignerController : ControllerBase
    {
        // GET: api/<Customer>
        
        private DataDesigner dataDesigner;
        public DesignerController(DataDesigner dd)
        {
            dataDesigner = dd;
        }
        [HttpGet]
        public IEnumerable<Designer> Get()
        {
            return dataDesigner._Designers;
        }

        // GET api/<Customer>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Designer designer = new Designer();
            designer = dataDesigner._Designers.Find(i => i.Id == id);
            if (designer != null)
            {
                return Ok(designer);
            }
            return NotFound();
        }

        // POST api/<Customer>
        [HttpPost]
        public void Post([FromBody] Designer value)
        {
            dataDesigner._Designers.Add(value);
        }

        // PUT api/<Customer>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Designer value)
        {
            Designer designer;
            designer = dataDesigner._Designers.Find(i => i.Id == id);
            if (designer != null)
            {
                designer.Name = value.Name;
                designer.Phone= value.Phone;
                designer.Adress= value.Adress;
                designer.IsDesigningAi= value.IsDesigningAi;
                designer.Priority= value.Priority;
                return Ok(designer);

            }
            return NotFound();

        }

        // DELETE api/<Customer>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Designer designer;
            designer = dataDesigner._Designers.Find(i => i.Id == id);
            if (designer != null)
            {
                dataDesigner._Designers.Remove(designer);
                return Ok(designer);

            }
            return NotFound();
        }
    }
}
