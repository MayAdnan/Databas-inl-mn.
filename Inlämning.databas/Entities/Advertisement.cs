using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning.databas.Entities
{
    public class Advertisement
    {
        public int AdvertisementID { get; set; }
        public string Title { get; set; }
        public string Descriptions { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryID { get; set; }
        public int UsersID { get; set; }

        public Advertisement(int advertisementID, string title, string descriptions, decimal price, DateTime createDate, int categoryID, int usersID)
        {
            AdvertisementID = advertisementID;
            Title = title;
            Descriptions = descriptions;
            Price = price;
            CreateDate = createDate;
            CategoryID = categoryID;
            UsersID = usersID;
        }
        public override string ToString()
        {
            return $"{Title} , {Price:C} , {CreateDate:yyyy-MM-dd}";
        }

    }
}



