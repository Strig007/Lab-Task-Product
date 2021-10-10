using Shopping.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Shopping.Models
{
    public class Database
    {
        SqlConnection conn;

        public Products Products { get; set; }

        public Database()
        {
            string connString = @"Server=STRIG; Database=Ecommerce; Integrated Security=true";
            conn = new SqlConnection(connString);

            Products = new Products(conn);
        }
    }
}