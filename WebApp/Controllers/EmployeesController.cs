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
    /// <summary>
    /// Api danh mục nhân viên
    /// Author hieunv (06/08/2021)
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        IDbConnection dbConnection = DatabaseConnection.DbConnection;
        /// <summary>
        /// Lấy toàn bộ danh sách nhân viên
        /// </summary>
        /// <returns>Danh sách khách hàng</returns>
        /// Author hieunv 06/08/2021
        [HttpGet]
        public IActionResult Get()
        {
            var sql = "select * from Employees";
            var employees = dbConnection.Query<Employees>(sql);

            var response = StatusCode(200, employees);
            //List<Employees> employees = new List<Employees>();
            //for (int i = 1; i <= 100; i++)
            //{
            //    Employees employee = new Employees(i, RandomProperty.NewIdentityNumber(), RandomProperty.NewPositionId(), RandomProperty.NewSalary(),
            //        RandomProperty.NewJoinDate(), RandomProperty.NewWorkStatus(), RandomProperty.NewFullName(), RandomProperty.NewDOB(),
            //        RandomProperty.NewGender(), RandomProperty.NewAddress(), RandomProperty.NewEmail(), RandomProperty.NewPhoneNumber());
            //    employees.Add(employee);
            //}


            return response;

        }

        /// <summary>
        /// Lấy thông tin nhân viên theo id
        /// </summary>
        /// <param name="EmployeeId"></param>
        /// <returns>Nhân viên</returns>
        /// Author hieunv 06/08/2021
        [HttpGet("{EmployeeId}")]
        public IActionResult Get(int EmployeeId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@EmployeeId", EmployeeId);
            var sql = $"select * from Employees where EmployeeId= @EmployeeId";
            var employee = dbConnection.QueryFirstOrDefault(sql, param: parameters);
            return Ok(employee);
        }

        /// <summary>
        /// Lấy mã nhân viên mới
        /// </summary>
        /// <returns>mã nhân viên lớn nhất có trong csdl</returns>
        [HttpGet("NewEmployeeId")]
        public IActionResult Get(string a)
        {
            var sql = "select top 1 EmployeeId from Employees order by EmployeeId desc";
            var employee = dbConnection.QueryFirstOrDefault(sql);
            var newEmployeeId = employee.EmployeeId + 1;
            return Ok(newEmployeeId);
        }


        /// <summary>
        /// Thêm mới một nhân viên vào database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>số hàng được thêm thành công</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Employees employee)
        {
            /// complete sql String
            var colNames = string.Empty;
            var colParams = string.Empty;
            // đọc từng property
            var properties = employee.GetType().GetProperties();

            DynamicParameters parameters = new DynamicParameters();
            // duyệt từng property

            foreach (var prop in properties)
            {
                // lấy tên prop
                var propName = prop.Name;


                // lấy value prop
                var propValue = prop.GetValue(employee);

                // lấy kiểu prop
                var propType = prop.PropertyType;

                parameters.Add($"@{propName}", propValue);

                colNames += $"{propName},";
                colParams += $"@{propName},";

            }
            colNames = colNames.Remove(colNames.Length - 1, 1);
            colParams = colParams.Remove(colParams.Length - 1, 1);

            var sql = $"insert into Employees({colNames}) values( {colParams} ) ";
            var rowAffects = dbConnection.Execute(sql, param: parameters);

            var response = StatusCode(200, rowAffects);
            return response;
        }


        /// <summary>
        /// Cập nhật một khách hàng với CustomerId trước
        /// </summary>
        /// <param name="id"> lấy từ route</param>
        /// <param name="customer"> lấy từ body</param>
        /// <returns>1 nếu sửa thành công và 0 là ngược lại</returns>
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Employees employee)
        {
            /// complete sql String
            var cols = string.Empty;
            // đọc từng property
            var properties = employee.GetType().GetProperties();

            DynamicParameters parameters = new DynamicParameters();
            // duyệt từng property

            foreach (var prop in properties)
            {
                // lấy tên prop
                var propName = prop.Name;


                // lấy value prop
                var propValue = prop.GetValue(employee);

                // lấy kiểu prop
                var propType = prop.PropertyType;

                parameters.Add($"@{propName}", propValue);

                cols += $" { propName } = @{propName},";

            }
            cols = cols.Remove(cols.Length - 1, 1);
            var sql = $"update Employees set {cols} where EmployeeId = {id}";
            var rowAffects = dbConnection.Execute(sql, param: parameters);

            var response = StatusCode(200, rowAffects);
            return response;
        }

        /// <summary>
        /// Xóa một nhân viên theo CustomerId
        /// </summary>
        /// <param name="id"></param>
        /// <returns>1 nếu xóa thành công và 0 là ngược lại</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var sql = $"delete from Employees where EmployeeId = {id}";
            var rowAffects = dbConnection.Execute(sql);
            var response = StatusCode(200, rowAffects);
            return response;
        }
    }
}
