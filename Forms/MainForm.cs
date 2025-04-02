using kulinaria_Efimov.Classes;
using kulinaria_Efimov.Forms;
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
using System.Windows.Forms.VisualStyles;

namespace kulinaria_Efimov
{
    public partial class MainForm : Form
    {
        public List<Classes.Bludo> bludos = new List<Classes.Bludo>();
        BludaFromDB bludaFromDB = new BludaFromDB();
        public static List<Classes.Category> categories = new List<Classes.Category>();
        CategoryFromDB categoryFromDB = new CategoryFromDB();
        List<Classes.SostavBlud> sostavBlud = new List<Classes.SostavBlud>();
        int selectedIndexRow = -1;
        bool noSelectedRows = true;
        int allBludosCount = 0;
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.Columns[0].DataPropertyName = "Id_bluda";
            dataGridView1.Columns[1].DataPropertyName = "Bludo_Image";
            dataGridView1.Columns[2].DataPropertyName = "Bludo_name";
            dataGridView1.Columns[3].DataPropertyName = "Category";
            dataGridView1.Columns[4].DataPropertyName = "Osnova";
            dataGridView1.Columns[5].DataPropertyName = "Dish_weight";
            dataGridView1.Columns[0].Visible= false;
        }

        

        void ClearSostavBluda()
        {
            listBoxSostavBluda.Items.Clear();
            lblNameOfBludo.Text = "";
        }

        private void ViewAllBludos()
        {
            bludos = bludaFromDB.LoadBludos();
            allBludosCount = bludos.Count;
            CalcWeight(bludos);
            dataGridView1.DataSource = bludos;
            OutCountOfDishes(allBludosCount);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ViewAllBludos();

            categories = categoryFromDB.LoadCategories();
            categories.Insert(0, new Classes.Category(0, "All"));
            chooseCat_comboB.DataSource = categories;

            chooseCat_comboB.DisplayMember = "CategoryName";
            chooseCat_comboB.ValueMember = "Category_id";


            switch (AuthorizationForm.currentUser.RoleId)
            {
                case 1:
                    пользователиToolStripMenuItem.Visible = true;
                    break;
                case 2:
                    добавитьБлюдаToolStripMenuItem.Visible = false;
                    удалитьБлюдоToolStripMenuItem.Visible = false;
                    break;
                case 3:
                    добавитьБлюдаToolStripMenuItem.Visible = false;
                    break;
            }
            fIOToolStripMenuItem.Text = AuthorizationForm.currentUser.FirstName + " " + AuthorizationForm.currentUser.LastName;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSostavBluda();
            if (chooseCat_comboB.SelectedIndex == 0)
            {
                ViewAllBludos();
            }
            else
            {
                bludos = bludaFromDB.FiltrBludosByCategory(Convert.ToInt32(chooseCat_comboB.SelectedValue));
                CalcWeight(bludos);
                dataGridView1.DataSource = bludos;
                int countSearchAndFilteredDishes = dataGridView1.RowCount;
                OutCountOfDishes(countSearchAndFilteredDishes);
            }
        }

        private void OutCountOfDishes(int countFilteredDishes)
        {
            counterLbl.Text = $"{countFilteredDishes} из {allBludosCount}";
        }

        private void searchDish_tb_TextChanged(object sender, EventArgs e)
        {
            ClearSostavBluda();
            if (chooseCat_comboB.SelectedIndex > 0)
            {
                int categoryId = Convert.ToInt32(chooseCat_comboB.SelectedValue);
                string searchText = searchDish_tb.Text;

                bludos = bludaFromDB.FiltrBludosByCategoryAndSearch(categoryId, searchText);
                CalcWeight(bludos);
                dataGridView1.DataSource = bludos;
                int countSearchAndFilteredDishes = dataGridView1.RowCount;
                OutCountOfDishes(countSearchAndFilteredDishes);
            }
            else
            {
                List<Bludo> searchedBludo = bludaFromDB.SearchBludos(searchDish_tb.Text);
                CalcWeight(searchedBludo);
                dataGridView1.DataSource = searchedBludo;
                int countSearchAndFilteredDishes = dataGridView1.RowCount;
                OutCountOfDishes(countSearchAndFilteredDishes);
            }
        }

        private void fIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void редактироватьПрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            DialogResult result = editProfile.ShowDialog();
            if (result == DialogResult.OK)
            {
                fIOToolStripMenuItem.Text = AuthorizationForm.currentUser.FirstName + " " + AuthorizationForm.currentUser.LastName;
            }
        }

        private void сменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm.currentUser = null;
            AuthorizationForm authForm = new AuthorizationForm();
            authForm.Show();
            this.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm.currentUser = null;
            MessageBox.Show("Вы вышли из системы.");
            Application.Exit();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser();
            manageUser.Show();
        }

        private void добавитьПродуктToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProducts ap = new AddProducts();
            ap.Show();
        }

        private void просмотрПродуктовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void удалитьПродуктToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void CalcWeight(List<Bludo> bludos)
        {
            foreach(Bludo bludo in bludos)
            {
                bludo.Dish_weight = 0;
                sostavBlud = bludaFromDB.LoadSostav(bludo.Id_bluda);
                foreach(SostavBlud ingredient in sostavBlud)
                {
                    bludo.Dish_weight += ingredient.Weight;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndexRow = dataGridView1.CurrentRow.Index;
            sostavBlud = bludaFromDB.LoadSostav(bludos[selectedIndexRow].Id_bluda);
            PrintSostavBluda(sostavBlud, bludos[selectedIndexRow].Bludo_name);
        }

        public void PrintSostavBluda(List<Classes.SostavBlud> sostavBlud, string bludoName)
        {
            ClearSostavBluda();
            lblNameOfBludo.Text = bludoName;

            foreach (SostavBlud sostavBl in sostavBlud)
            {
                listBoxSostavBluda.Items.Add(sostavBl.Product_name + ", " + sostavBl.Weight);
            }
        }

        private void удалитьБлюдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedIndexRow = dataGridView1.CurrentRow.Index;

            if (selectedIndexRow == 0 && noSelectedRows == true)
            {
                MessageBox.Show("Выберите блюда!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Удалить " + bludos[selectedIndexRow].Bludo_name + " ?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if(dialogResult == DialogResult.Yes)
                {
                    bludaFromDB.DeleteBludo(bludos[selectedIndexRow].Id_bluda);
                    ViewAllBludos();
                }
            }
        }

        private void добавитьБлюдаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBludo addBludo = new AddBludo();
            DialogResult dialogResult = addBludo.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ViewAllBludos();
            }
        }

        private void просмотрРецептовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecipesForm recipesForm = new RecipesForm();
            recipesForm.Show();
        }

        private void поискПоКритериямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltByProductsForm filtByProductsForm = new FiltByProductsForm();
            filtByProductsForm.Show();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells[4].Value) > 200)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
