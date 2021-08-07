using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerTypesController : ControllerBase
    {

        IDbConnection dbConnection = DatabaseConnection.DbConnection;

        // GET: api/<CustomerTypesController>
        [HttpGet]
        public IActionResult Get()
        {
            var sql = "select * from CustomerTypes";
            var customerTypes = dbConnection.Query<CustomerTypes>(sql);

            return Ok(customerTypes);
        }

        //// GET api/<CustomerTypesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<CustomerTypesController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<CustomerTypesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<CustomerTypesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
