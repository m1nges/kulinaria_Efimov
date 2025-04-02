using kulinaria_Efimov.Classes;
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
    public partial class Products : Form
    {
        public List<Classes.ProductsClass> products = new List<Classes.ProductsClass>();
        ProductsFromDB productsFromDB = new ProductsFromDB();

        public Products()
        {
            InitializeComponent();
            dataGridView1.Columns[0].DataPropertyName = "ProductId";
            dataGridView1.Columns[1].DataPropertyName = "ProductName";
            dataGridView1.Columns[2].DataPropertyName = "Protein";
            dataGridView1.Columns[3].DataPropertyName = "Fat";
            dataGridView1.Columns[4].DataPropertyName = "Carbs";
            dataGridView1.Columns[0].Visible = false;

        }

        private void Products_Load(object sender, EventArgs e)
        {
            ViewAllProducts();
        }

        public void ViewAllProducts()
        {
            products = productsFromDB.LoadProducts();
            dataGridView1.DataSource = products;
            dataGridView1.Columns[0].DataPropertyName = "ProductId";
            dataGridView1.Columns[1].DataPropertyName = "ProductName";
            dataGridView1.Columns[2].DataPropertyName = "Protein";
            dataGridView1.Columns[3].DataPropertyName = "Fat";
            dataGridView1.Columns[4].DataPropertyName = "Carbs";
            dataGridView1.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProducts ap = new AddProducts();
            ap.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите продукт для удаления.");
                return;
            }
            var selectedRow = dataGridView1.SelectedRows[0];

            string productName = selectedRow.Cells["Column1"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show(
                $"Вы действительно хотите удалить продукт \"{productName}\"?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                int productId = Convert.ToInt32(selectedRow.Cells["Column0"].Value);

                bool success = productsFromDB.DeleteProduct(productId);

                if (success)
                {
                    MessageBox.Show("Продукт успешно удален.");
                    ViewAllProducts();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить продукт.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<ProductsClass> products = productsFromDB.LoadProducts(); // Ваш метод загрузки продуктов
            ExcelUnLoad exporter = new ExcelUnLoad();
            exporter.ExportProductsToExcel(products);
        }
    }
}
