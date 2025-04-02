using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulinaria_Efimov.Classes
{
    public class ProductsClass
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Protein { get; set; }
        public int Fat {  get; set; }
        public int Carbs { get; set; }
        public ProductsClass(int productid, string productName, int protein,int fat, int carbs)
        {
            ProductId = productid;
            ProductName = productName;
            Protein = protein;
            Fat = fat;
            Carbs = carbs;
        }
    }
}
