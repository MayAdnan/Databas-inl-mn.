using Inlämning.databas.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning.databas.Repository
{
    public class CategoryRepo
    {
        public List<Category> GetList ()
        {
            //motsvarar listan som gjordes för instructor, kolla demo 

            string sql = "Select CategoryID , Name FROM Category";

            DataTable data = DataContext.ExecuteQueryReturnTable(sql, new List<SqlParameter>());
            //Data måste mapas 

            List<Category> category = new List<Category>();
            foreach (DataRow row in data.Rows)
            {
                category.Add(new Category(
                    (int)row["CategoryID"],
                    row["Name"].ToString()));
            }
            return category;
        }
    }
}
