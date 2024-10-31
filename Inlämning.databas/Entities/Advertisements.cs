using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning.databas.Entities
{
    public class Advertisements
    {
        public int AdvertismentID { get; set; }
        public string Title { get; set; }
        public string Descriptions { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryID { get; set; }
        public int UsersID { get; set; }

        public Advertisements(int advertismentID, string title, string descriptions, decimal price, DateTime createDate, int categoryID, int usersID)
        {
            AdvertismentID = advertismentID;
            Title = title;
            Descriptions = descriptions;
            Price = price;
            CreateDate = createDate;
            CategoryID = categoryID;
            UsersID = usersID;
        }
    }

}
