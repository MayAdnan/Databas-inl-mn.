using Inlämning.databas.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace Inlämning.databas.Repository
{
    public class AdvertisementsRepo
    {
        private static string _connString = "Data Source=localhost;Initial Catalog=AnnonsDatabas;Integrated Security=SSPI;TrustServerCertificate=True;";

        public List<Advertisement> GetAll()
        {
            var sql = "SELECT * FROM Advertisement";
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

            public void Add(Advertisement ad)
            {
                using (var connection = new SqlConnection(_connString))
                {
                    connection.Open();
                    var command = new SqlCommand("INSERT INTO Advertisement (Title, Descriptions, Price, CreateDate, CategoryID, UsersID) VALUES (@Title, @Descriptions, " +
                        "@Price, @CreateDate, @CategoryID, @UsersID)", connection);

                    command.Parameters.AddWithValue("@Title", ad.Title);
                    command.Parameters.AddWithValue("@Descriptions", ad.Descriptions);
                    command.Parameters.AddWithValue("@Price", ad.Price);
                    command.Parameters.AddWithValue("@CreateDate", ad.CreateDate);
                    command.Parameters.AddWithValue("@CategoryID", ad.CategoryID);
                    command.Parameters.AddWithValue("@UsersID", ad.UsersID);

                    command.ExecuteNonQuery();
                }
            }

            public void Update(Advertisement ad)
            {
                using (var connection = new SqlConnection(_connString))
                {
                    connection.Open();
                    var command = new SqlCommand("UPDATE Advertisement SET Title = @Title, Descriptions = @Descriptions, Price = @Price, " +
                                                 "CategoryID = @CategoryID WHERE AdvertisementID = @AdvertisementID", connection);

                    command.Parameters.AddWithValue("@Title", ad.Title);
                    command.Parameters.AddWithValue("@Descriptions", ad.Descriptions);
                    command.Parameters.AddWithValue("@Price", ad.Price);
                    command.Parameters.AddWithValue("@CategoryID", ad.CategoryID);
                    command.Parameters.AddWithValue("@AdvertisementID", ad.AdvertisementID);

                    command.ExecuteNonQuery();
                }
            }

            public void Delete(int adId)
            {
                using (var connection = new SqlConnection(_connString))
                {
                    connection.Open();
                    var command = new SqlCommand("DELETE FROM Advertisement WHERE AdvertisementID = @AdvertisementID", connection);
                    command.Parameters.AddWithValue("@AdvertisementID", adId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
