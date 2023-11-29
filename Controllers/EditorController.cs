﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagingANewspaper.Controllers
{
    [Route("api/Editors")]
    [ApiController]
    public class EditorController : ControllerBase
    {
        // GET: api/<Customer>
        private DataEditors dataEditors;
        public DesignerController(DataEditors dd)
        {
            dataEditors = dd;
        }
        [HttpGet]
        public IEnumerable<Editor> Get()
        {
            return dataEditors._Editors;
        }

        // GET api/<Customer>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Editor editor = new Editor();
            editor = dataEditors._Editors.Find(i => i.Id == id);
            if (editor != null)
            {
                return Ok(editor);
            }
            return NotFound();
        }

        // POST api/<Customer>
        [HttpPost]
        public void Post([FromBody] Editor value)
        {
            dataEditors._Editors.Add(value);
        }

        // PUT api/<Customer>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Editor value)
        {
            Editor editor;
            editor = dataEditors._Editors.Find(i => i.Id == id);
            if (editor != null)
            {
                editor.Name = value.Name;
                editor.Phone= value.Phone;
                editor.Adress= value.Adress;
                editor.TEditor= value.TEditor;  
                editor.Priority= value.Priority;
                return Ok(editor);
            }
            return NotFound();
        }

        // DELETE api/<Customer>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Editor editor;
            editor = dataEditors._Editors.Find(i => i.Id == id);
            if (editor != null)
            {
                dataEditors._Editors.Remove(editor);
                return Ok(editor);

            }
            return NotFound();
        }
    }
}
