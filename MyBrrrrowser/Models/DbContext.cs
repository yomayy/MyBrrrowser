using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MyBrrrrowser.Models
{
    class DbContext
    {
        private string conn_str;
        private SqlConnection conn;



        public List<Category> Categories { get; set; }
        public List<Site> Sites { get; set; }

        public DbContext()
        {
            Categories = new List<Category>();
            Sites = new List<Site>();
            conn_str = ConfigurationManager.ConnectionStrings["conn1"].ConnectionString;
            conn = new SqlConnection(conn_str);
            Load();
        }

        private void Load()
        {
            
            

            conn.Open();
            string query1 = "select * from Categories";

            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while(reader1.Read())
            {
                Categories.Add(new Category()
                {
                    Id = (int)reader1["Id"],
                    Name = reader1["Name"].ToString()
                });
            }
            conn.Close();

            conn.Open();
            string query2 = "select * from Sites";

            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while(reader2.Read())
            {
                Sites.Add(new Site()
                {
                    Id = (int)reader2["Id"],
                    Name = reader2["Name"].ToString(),
                    Address = reader2["Address"].ToString(),
                    CategoryId = (int)reader2["CategoryId"]
                });
            }

            conn.Close();
            
        }

        public void Save()
        {

        }

    }
}
