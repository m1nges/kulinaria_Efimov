using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulinaria_Efimov.Classes
{
    public class Recipe
    {
        public int Dish_id { get; set; }
        public string Recipe_description {  get; set; }

        public Recipe(int dish_id, string recipe_description)
        {
            Dish_id = dish_id;
            Recipe_description = recipe_description;
        }
    }
}
