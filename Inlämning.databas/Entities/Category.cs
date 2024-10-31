using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning.databas.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public Category(int categoryID, string name)
        {
            CategoryID = categoryID;
            Name = name;
        }
    }
}
