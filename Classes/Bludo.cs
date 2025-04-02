using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulinaria_Efimov.Classes
{
    public class Bludo
    {
        public int Id_bluda {  get; set; }
        public string Bludo_name {  get; set; }
        public string Category { get; set; }
        public string Osnova { get; set; }
        public int Dish_weight { get; set; }
        public Image Bludo_Image { get; set; }

        public Bludo(int id_bluda, string bludo_name, string category, string osnova, int dish_weight, string image)
        {
            Id_bluda = id_bluda;
            Bludo_name = bludo_name;
            Category = category;
            Osnova = osnova;
            Dish_weight = dish_weight;
            if (image != "")
                Bludo_Image = Image.FromFile(image);
            else
                Bludo_Image = Image.FromFile("../../Images/picture.jpg");
        }
    }
}
