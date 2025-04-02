using kulinaria_Efimov.Classes;
using kulinaria_Efimov.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kulinaria_Efimov.Forms
{
    public partial class AddBludo : Form
    {
        CategoryFromDB catFromDB = new CategoryFromDB();
        BaseFromDB baseFromDb = new BaseFromDB();
        string picFileName = "picture.jpg";
        ProductsFromDB ProductsFromDB = new ProductsFromDB();
        BludaFromDB bludaFromDB = new BludaFromDB();

        public AddBludo()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"../../Images/picture.jpg");
            dataGridView1.AllowUserToAddRows = false;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                picFileName = Path.GetFileName(openFileDialog.FileName);
                string distinPath = @"../../images/" + picFileName;

                if (!File.Exists(distinPath))
                {
                    fileInfo.CopyTo(distinPath);
                }
                pictureBox1.Image = Image.FromFile(distinPath);
            }
        }

        private void AddBludo_Load(object sender, EventArgs e)
        {
            comboBoxCat_Load();
            comboBoxProduct_Load();
            cmbBase_Load();
        }

        private void comboBoxCat_Load()
        {
            comboBoxCat.DataSource = catFromDB.LoadCategories();
            comboBoxCat.DisplayMember = "CategoryName";
            comboBoxCat.ValueMember = "Category_id";
        }

        private void comboBoxProduct_Load()
        {
            comboBoxProduct.DataSource = ProductsFromDB.LoadProducts();
            comboBoxProduct.DisplayMember = "ProductName";
            comboBoxProduct.ValueMember = "ProductId";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!DublicateRows(comboBoxProduct.Text))
            {
                dataGridView1.Rows.Add(comboBoxProduct.Text, weightTb2.Text);
            }
        }

        private bool DublicateRows(string selectProduct)
        {
            bool isDublicate = false;

            for(int i = 0;i < dataGridView1.Rows.Count;i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null && dataGridView1.Rows[i].Cells[0].Value.ToString() == selectProduct)
                {
                    isDublicate = true;
                    MessageBox.Show("Такой продукт уже есть в списке!");
                    break;
                }
            }
            return isDublicate;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows !=null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void cmbBase_Load()
        {
            comboBoxOsn.DataSource = baseFromDb.LoadBase();
            comboBoxOsn.DisplayMember = "Base_name";
            comboBoxOsn.ValueMember = "Base_id";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string picPath = @"../../images/"+ picFileName;

            Bludo newBludo = new Bludo(
                0,
                dishNameTb.Text,
                comboBoxCat.Text,
                comboBoxOsn.Text,
                Convert.ToInt32(weightTb.Text), 
                picPath 
            );


            List<SostavBlud> sostavBl = new List<SostavBlud>();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                var cell0 = dataGridView1.Rows[i].Cells[0].Value;
                var cell1 = dataGridView1.Rows[i].Cells[1].Value;

                if (cell0 == null || cell1 == null)
                {
                    MessageBox.Show($"Строка {i + 1} содержит пустые значения. Проверьте данные.");
                    continue; 
                }
                sostavBl.Add(new SostavBlud(
                    0,
                    dataGridView1.Rows[i].Cells[0].Value.ToString(), 
                    Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) 
                ));
            }

            bludaFromDB.AddNewBludo(
                newBludo, 
                sostavBl,
                (int)comboBoxCat.SelectedValue,
                (int)comboBoxOsn.SelectedValue,
                picPath 
            );
            DialogResult = DialogResult.OK;
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }
    }
}
