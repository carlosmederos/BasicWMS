using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BasicWMS.Data;
using BasicWMS.Model;

namespace BasicWMS.Controllers
{
    public class ProductApiController : ApiController
    {
        private readonly BasicWmsContext _context;

        public ProductApiController()
        {
            _context = new BasicWmsContext();
        }

        // GET api/<controller>
        public IEnumerable<Product> Get()
        {
            var products = _context.ProductSet.AsEnumerable();
            return products;
        }

        // GET api/<controller>/5
        public Product Get(int id)
        {
            var product = _context.ProductSet.FirstOrDefault(p => p.Id == id);
            return product;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}