﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Baitap01
{
    class DBConnect
    {
        static SqlConnection sqlcon;
        static string strcon = @"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True";
        public static bool updateData(string sql)
        {
            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(sql, sqlcon);
            int r = cmd.ExecuteNonQuery();
            sqlcon.Close();
            if (r > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
