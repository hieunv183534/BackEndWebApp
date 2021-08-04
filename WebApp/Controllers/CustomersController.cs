using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using Dapper;
using System.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    /// <summary>
    /// Api danh mục khách hàng
    /// Author: hieunv 31/07/2021
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        IDbConnection dbConnection = DatabaseConnection.DbConnection;
        /// <summary>
        /// Lấy toàn bộ danh sách khách hàng
        /// </summary>
        /// <returns>Danh sách khách hàng</returns>
        /// Author hieunv 03/08/2021
        [HttpGet]
        public IActionResult Get()
        {
            var sql = "select * from Customers";
            var customers= dbConnection.Query<Customer>(sql, commandType: CommandType.Text);
            return Ok(customers);
        }

        /// <summary>
        /// Lấy thông tin khách hàng theo id
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns>Khách hàng</returns>
        /// Author hieunv 03/08/2021
        [HttpGet("{CustomerId}")]
        public IActionResult Get(string CustomerId)
        {
            var sql = "select * from Customers where customerCode=" + CustomerId;
            var customer = dbConnection.Query(sql, commandType: CommandType.Text);
            return Ok(customer);
        }

        // GET api/<CustomersController>/5
        [HttpGet("filter")]
        public IActionResult Get([FromQuery] string FullName,[FromQuery] string PhoneNumber)
        {
            var sql = "select * from Customers where FullName= N" + FullName + " and PhoneNumber= " + PhoneNumber;
            var customers = dbConnection.Query<Customer>(sql, commandType: CommandType.Text);
            return Ok(customers);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            return Created("Add Customer",customer);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok(1);
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
