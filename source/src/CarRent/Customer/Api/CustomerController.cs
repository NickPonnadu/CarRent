﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.Customer.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<CustomerResponse> Get()
        {
            var customers = new List<CustomerResponse>
            {
                new() { Id = Guid.NewGuid(), Name = "Nick", CustomerNr = 01, Address = "Test 1" }
            };
            return customers;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(Guid id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] CustomerRequest value)
        {
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] CustomerRequest value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
