using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulinaria_Efimov.Classes
{
    public class Category
    {
        public int Category_id {  get; set; }
        public string CategoryName { get; set; }

        public Category (int category_id, string categoryName)
        {
            Category_id = category_id;
            CategoryName = categoryName;
        }
    }
}
