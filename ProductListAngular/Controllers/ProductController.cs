using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace ProductListAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductBusinessLogic _productBL;
        public ProductController(IProductBusinessLogic productBL)
        {
            _productBL = productBL;
        }
        // GET api/values
        [HttpGet]
        [Produces("application/json", Type = typeof(Product))]
        public ActionResult Get()
        {
            return new JsonResult(_productBL.GetProducts());
            
        }


        [HttpGet("[action]")]
        public IEnumerable<Product> GetProducts()
        {
            return _productBL.GetProducts();

        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
