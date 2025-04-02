using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulinaria_Efimov.Classes
{
    public class SostavBlud
    {
        public int Dish_id { get; set; }
        public string Product_name{ get; set; }
        public int Weight { get; set; }

        public SostavBlud(int dish_id, string product_name, int weight) 
        {
            Dish_id = dish_id;
            Product_name = product_name;
            Weight = weight;
        }
    }
}
