using kulinaria_Efimov.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kulinaria_Efimov.Forms
{
    public partial class AddProducts : Form
    {
        ProductsFromDB productsFromDB = new ProductsFromDB();
        Products products = new Products();
        public AddProducts()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            productsFromDB.AddProduct(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            MessageBox.Show("Продукт успешно добавлен");
        }

        private void AddProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            products.ViewAllProducts();
        }
    }
}
