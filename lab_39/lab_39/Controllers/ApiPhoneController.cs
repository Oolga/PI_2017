using lab_39.Models;
using lab_39.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace lab_39.Controllers
{
    [Route("api/apiphone")]
    public class ApiPhoneController : ApiController
    {
        PhoneService service = new PhoneService();
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return service.GetPhones();
        }

        // GET api/<controller>/5
        public Item Get(int id)
        {
            return service.GetItemById(id);
        }

        // POST api/<controller>
        public void Post([FromBody]Item value)
        {
            service.Insert(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Item value)
        {
            service.Update(value);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}