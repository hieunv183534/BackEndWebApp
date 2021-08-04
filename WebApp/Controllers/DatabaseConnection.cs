using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    /// <summary>
    /// Lớp kết nối với database bằng dapper
    /// </summary>
    public class DatabaseConnection
    {
        private static IDbConnection dbConnection = new SqlConnection("Server=DESKTOP-LNGJ4BJ\\SQLEXPRESS; User=sa; Password=123; Database=CompanyManagement");

        public static IDbConnection DbConnection
        {
            get { return dbConnection; }
        }
    }
}


