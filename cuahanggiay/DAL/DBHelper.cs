﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DBHelper
    {
        //câu lệnh kết nối sql server
        private static string connectionString = "Data Source=LAPTOP-9PJO29SJ\\SQLEXPRESS;Initial Catalog=cuahang_bangiay;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
