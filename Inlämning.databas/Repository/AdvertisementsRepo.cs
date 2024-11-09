using Inlämning.databas.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Inlämning.databas.Repository
{
    public class AdvertisementsRepo
    {
        private static string _connString = "Data Source=localhost;Initial Catalog=AnnonsDatabas;Integrated Security=SSPI;TrustServerCertificate=True;";

        public List<Advertisement> GetAll()
        {
            string sql = "SELECT * FROM Advertisement";
            var dataTable = DataContext.ExecuteQueryReturnTable(sql, null);
            var advertisements = new List<Advertisement>();

            foreach (DataRow row in dataTable.Rows)
            {
                var ad = new Advertisement(
                    Convert.ToInt32(row["AdvertisementID"]),
                    row["Title"].ToString(),
                    row["Descriptions"].ToString(),
                    Convert.ToDecimal(row["Price"]),
                    Convert.ToDateTime(row["CreateDate"]),
                    Convert.ToInt32(row["CategoryID"]),
                    Convert.ToInt32(row["UsersID"])
                );
                advertisements.Add(ad);
            }

            return advertisements;
        }
        public List<Advertisement> Sort(string sort)
        {
            string sql = "Select * from Advertisement";

            switch (sort)
            {
                case "Price":
                    sql += " Order by Price asc";
                    break;

                case "Date":
                    sql += " Order by CreateDate desc";
                    break;
            }
            var dataTable = DataContext.ExecuteQueryReturnTable(sql, null);
            var advertisements = new List<Advertisement>();

            foreach (DataRow row in dataTable.Rows)
            {
                var ad = new Advertisement(
                    Convert.ToInt32(row["AdvertisementID"]),
                    row["Title"].ToString(),
                    row["Descriptions"].ToString(),
                    Convert.ToDecimal(row["Price"]),
                    Convert.ToDateTime(row["CreateDate"]),
                    Convert.ToInt32(row["CategoryID"]),
                    Convert.ToInt32(row["UsersID"])
                );

                advertisements.Add(ad);
            }

            return advertisements;
        }
        public List<Advertisement> SearchAd(string title, int? categoryID = null)
        {
            string sql = "Select * From Advertisement Where 1=1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(title))
            {
                sql += " AND Title Like @Title";
                parameters.Add(new SqlParameter("@Title", "%" + title + "%"));
            }

            if (categoryID.HasValue)
            {
                sql += " And CategoryID = @CategoryID";
                parameters.Add(new SqlParameter("@CategoryID", categoryID.Value));
            }

            DataTable dataTable = DataContext.ExecuteQueryReturnTable(sql, parameters);

            List<Advertisement> advertisements = new List<Advertisement>();
            foreach (DataRow row in dataTable.Rows)
            {
                advertisements.Add(new Advertisement(
                    Convert.ToInt32(row["AdvertisementID"]),
                    row["Title"].ToString(),
                    row["Descriptions"].ToString(),
                    Convert.ToDecimal(row["Price"]),
                    Convert.ToDateTime(row["CreateDate"]),
                    Convert.ToInt32(row["CategoryID"]),
                    Convert.ToInt32(row["UsersID"])
                    ));
            }

            return advertisements;
        }
        public Advertisement GetAdByID(int adId)
        {
            string sql = "Select * from Advertisement WHERE AdvertisementID = @AdvertisementID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                new SqlParameter("@AdvertisementID", adId);
            }

            DataTable dataTable = DataContext.ExecuteQueryReturnTable(sql, parameters);

            if (dataTable.Rows.Count == 0)
                return null;

            DataRow row = dataTable.Rows[0];
            return new Advertisement(
                Convert.ToInt32(row["AdvertisementID"]),
                row["Title"].ToString(),
                row["Descriptions"].ToString(),
                Convert.ToDecimal(row["Price"]),
                Convert.ToDateTime(row["CreateDate"]),
                Convert.ToInt32(row["CategoryID"]),
                Convert.ToInt32(row["UsersID"])
            );
        }

        public void Add(Advertisement ad)
        {
            string sql = ("INSERT INTO Advertisement (Title, Descriptions, Price, CreateDate, CategoryID, UsersID) VALUES (@Title, @Descriptions, " +
                        "@Price, @CreateDate, @CategoryID, @UsersID)");
            List<SqlParameter> parameters = new List<SqlParameter>
                    {
                        new SqlParameter("@Title", ad.Title),
                        new SqlParameter("@Descriptions", ad.Descriptions),
                        new SqlParameter("@Price", ad.Price),
                        new SqlParameter("@CreateDate", ad.CreateDate),
                        new SqlParameter("@CategoryID", ad.CategoryID),
                        new SqlParameter("@UsersID", ad.UsersID)
                    };
            DataContext.ExecuteNonQuery(sql, parameters);
        }
        public void Update(Advertisement ad)
        {
            {
                var existingAd = GetAdByID(ad.AdvertisementID);
                if (existingAd != null && existingAd.UsersID != ad.UsersID)
                {
                    MessageBox.Show("Du har inte behörighet att uppdatera andras annonser");
                    return; 
                }

                string sql = ("UPDATE Advertisement SET Title = @Title, Descriptions = @Descriptions, Price = @Price, " +
                                                 "CategoryID = @CategoryID WHERE AdvertisementID = @AdvertisementID");
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Title", ad.Title),
                    new SqlParameter("@Descriptions", ad.Descriptions),
                    new SqlParameter("@Price", ad.Price),
                    new SqlParameter("@CategoryID", ad.CategoryID),
                    new SqlParameter("@AdvertisementID", ad.AdvertisementID)
                };

                DataContext.ExecuteNonQuery(sql, parameters);
            }
        }
        public void Delete(Advertisement ad)
        {
            {
                var existingAd = GetAdByID(ad.AdvertisementID);
                if (existingAd != null && existingAd.UsersID != ad.UsersID)
                {
                    MessageBox.Show("Du har inte behörighet att ta bort andras annonser");
                    return;
                }
                string sql = "Delete from Advertisement where AdvertisementID = @AdvertisementID";
      
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@AdvertisementID", ad.AdvertisementID)
                };

                DataContext.ExecuteNonQuery(sql, parameters);

            }
        }

    }
}
