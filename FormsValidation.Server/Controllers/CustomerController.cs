using FormsValidation.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsValidation.Server.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        [HttpGet]
        public ActionResult<List<Customer>> Get()
        {
            var customers = new List<Customer>() {
                new Customer() { Code ="555-0", Name="Foo", Description="Foo Desc", Active=true, NextVisitDate=DateTime.Now.AddDays(3)},
                new Customer() { Code ="555-1", Name="Foo-1", Description="Foo Desc-1", Active=true, NextVisitDate=DateTime.Now.AddMonths(1)},
                new Customer() { Code ="555-2", Name="Foo-2", Description="Foo Desc-2", Active=true, NextVisitDate=DateTime.Now.AddDays(5)},
            };

            return Ok(customers);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            if (ModelState.IsValid)
                return StatusCode(201);
                //return Created(Url.RouteUrl(customer.Id), customer.Id);
            else
                return BadRequest();
        }
    }
}
