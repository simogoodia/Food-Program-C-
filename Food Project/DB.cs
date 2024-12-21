using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Food_Project
{
    internal class DB
    {
        public static string fileName = "Food.accdb";
        public static OleDbConnection conn = new OleDbConnection($@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SIMOGOODIA\source\repos\Food Project\Food Project\{fileName};Persist Security Info=True");
        public static OleDbCommand cmd = new OleDbCommand("", conn);

        public static void Open()
        {
            if (conn.State == ConnectionState.Closed)  conn.Open();
        }
        public static void Close()
        {
            if (conn.State == ConnectionState.Open) conn.Close();
        }
        public static void ChangeFileName(string newName)
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.ConnectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SIMOGOODIA\source\repos\Food Project\Food Project\{newName};Persist Security Info=True";
            }
        }
        public static void Run(string sql)
        {
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public static DataTable GetData(string select)
        {
            DataTable tbl = new DataTable();
            cmd.CommandText = select;
            tbl.Load(cmd.ExecuteReader());
            return tbl;
        }


    }
}
