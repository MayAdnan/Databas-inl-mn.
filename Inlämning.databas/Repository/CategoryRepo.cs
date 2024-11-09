using Inlämning.databas.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Inlämning.databas.Repository
{
    public class CategoryRepo
    {
        public List<Category> GetList ()
        {
            string sql = "Select CategoryID , Name FROM Category";

            DataTable data = DataContext.ExecuteQueryReturnTable(sql, new List<SqlParameter>());
           
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
