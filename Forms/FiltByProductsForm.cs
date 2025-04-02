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
    public partial class FiltByProductsForm : Form
    {
        public List<Classes.Bludo> bludos = new List<Classes.Bludo>();
        BludaFromDB bludaFromDB = new BludaFromDB();
        ProductsFromDB productsFromDB = new ProductsFromDB();
        public List<Classes.ProductsClass> products = new List<Classes.ProductsClass>();
        public FiltByProductsForm()
        {
            InitializeComponent();
            showDishesDgv.Columns[0].DataPropertyName = "Id_bluda";
            showDishesDgv.Columns[1].DataPropertyName = "Bludo_Image";
            showDishesDgv.Columns[2].DataPropertyName = "Bludo_name";
            showDishesDgv.Columns[3].DataPropertyName = "Category";
            showDishesDgv.Columns[4].DataPropertyName = "Osnova";
            showDishesDgv.Columns[5].DataPropertyName = "Dish_weight";
            showDishesDgv.Columns[0].Visible = false;

            productFiltrDgv.Columns["productFiltrDgv_id"].DataPropertyName = "ProductId";
            productFiltrDgv.Columns["productFiltrDgv_ProductName"].DataPropertyName = "ProductName";
            productFiltrDgv.Columns["productFiltDgv_Protein"].DataPropertyName = "Protein";
            productFiltrDgv.Columns["productFiltDgv_Fat"].DataPropertyName = "Fat";
            productFiltrDgv.Columns["productFiltDgv_Carbs"].DataPropertyName = "Carbs";


            productFiltrDgv.Columns["productFiltrDgv_id"].Visible = false;
            productFiltrDgv.Columns["productFiltDgv_Fat"].Visible = false;
            productFiltrDgv.Columns["productFiltDgv_Carbs"].Visible = false;
            productFiltrDgv.Columns["productFiltDgv_Protein"].Visible = false;
        }

        private void ViewAllBludos()
        {
            bludos = bludaFromDB.LoadBludos();
            showDishesDgv.DataSource = bludos;
        }

        private void ViewAllProducts()
        {
            products = productsFromDB.LoadProducts();
            productFiltrDgv.DataSource = products;
        }

        private void FiltByProductsForm_Load(object sender, EventArgs e)
        {
            ViewAllBludos();
            ViewAllProducts();
        }

        private void includeSearchBtn_Click(object sender, EventArgs e)
        {
            var selectedProductIds = GetSelectedProductIds(true);
            if (selectedProductIds.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы один продукт для фильтрации.");
                return;
            }

            var filteredBludos = bludaFromDB.FiltrBludosByProducts(selectedProductIds, true);
            showDishesDgv.DataSource = filteredBludos;
        }

        private List<int> GetSelectedProductIds(bool include)
        {
            var selectedProductIds = new List<int>();
            foreach (DataGridViewRow row in productFiltrDgv.Rows)
            {
                if (Convert.ToBoolean(row.Cells["productFiltrDgv_Include"].Value) == include)
                {
                    selectedProductIds.Add(Convert.ToInt32(row.Cells["productFiltrDgv_id"].Value));
                }
            }
            return selectedProductIds;
        }

        private void notIncludeSearchBtn_Click(object sender, EventArgs e)
        {
            var selectedProductIds = GetSelectedProductIds(true);
            if (selectedProductIds.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы один продукт для фильтрации.");
                return;
            }

            var filteredBludos = bludaFromDB.FiltrBludosByProducts(selectedProductIds, false);
            showDishesDgv.DataSource = filteredBludos;
        }
    }
}
