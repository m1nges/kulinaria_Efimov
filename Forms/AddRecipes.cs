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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kulinaria_Efimov.Forms
{
    public partial class AddRecipes : Form
    {
        BludaFromDB bludaFromDB = new BludaFromDB();
        List<Classes.Recipe> recipes = new List<Classes.Recipe>();
        List<Classes.Bludo> bludos = new List<Classes.Bludo>();
        Recipe currentRecipe = null;
        int realDishId;
        string indicator = "";

        public AddRecipes(int dish_id, string indicator)
        {
            InitializeComponent();
            this.realDishId = dish_id;
            this.indicator = indicator;
            
            LoadRecipeById(dish_id);
        }

        private void cmbBludo_Load(int dish_id)
        {
            bludos = bludaFromDB.LoadBludos();
            cmbBluds.DataSource = bludos;
            cmbBluds.DisplayMember = "Bludo_name";
            cmbBluds.ValueMember = "Id_bluda";

            Classes.Bludo selectedBludo = null;
            foreach (var bludo in bludos)
            {
                if (bludo.Id_bluda == dish_id)
                {
                    selectedBludo = bludo;
                    break;
                }
            }

            // Установка выбранного значения
            if (selectedBludo != null)
            {
                cmbBluds.SelectedValue = selectedBludo.Id_bluda;
                Console.WriteLine($"Выбрано блюдо: {selectedBludo.Bludo_name}");
            }
            else
            {
                MessageBox.Show($"Блюдо с ID {dish_id} не найдено!");
                cmbBluds.SelectedIndex = -1;
            }

        }


        public void LoadRecipeById(int dish_id)
        {
            recipes = bludaFromDB.LoadRecipes();

            foreach (var recipe in recipes)
            {
                if (recipe.Dish_id == dish_id)
                {
                    currentRecipe = recipe;
                    break;
                }
            }
            if (currentRecipe != null)
            {
                textBox1.Text = currentRecipe.Recipe_description;
            }
            else
            {
                textBox1.Text = "Рецепт отсутствует.";
            }
            cmbBludo_Load(dish_id);
        }

        private void AddRecipes_Load(object sender, EventArgs e)
        {
            if (indicator == "edit")
            {
                button1.Text = "Обновить";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(indicator == "add")
            {
                bludaFromDB.AddRecipeByDishId(realDishId, textBox1.Text.ToString());
            }
            else
            {
                bludaFromDB.UpdateRecipeByDishId(realDishId, textBox1.Text.ToString());
            }
            DialogResult = DialogResult.OK;
        }
    }
}
