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
    public partial class RecipesForm : Form
    {
        Recipe currentRecipe = null;
        BludaFromDB bludaFromDB = new BludaFromDB();
        List<Classes.SostavBlud> sostavBlud = new List<Classes.SostavBlud>();
        List<Classes.Bludo> bludos = new List<Classes.Bludo>();
        List<Classes.Recipe> recipes = new List<Classes.Recipe>();
        int dish_id = 0;
        int real_dish_id;
        public RecipesForm()
        {
            InitializeComponent();
        }

        private void Recipes_Load(object sender, EventArgs e)
        {
            PrintSostavBluda(sostavBlud);

        }

        public void PrintSostavBluda(List<Classes.SostavBlud> sostavBlud)
        {
            currentRecipe = null;
            if(dish_id > 0)
            {
                butLeft.Visible = true;
            }
            else
            {
                butLeft.Visible = false;
            }
            bludos = bludaFromDB.LoadBludos();
            recipes = bludaFromDB.LoadRecipes();
            real_dish_id = bludos[dish_id].Id_bluda;
            lbxSostav.Items.Clear();
            lblBlName.Text = bludos[dish_id].Bludo_name;

            if (dish_id < 0 || dish_id >= bludos.Count)
            {
                MessageBox.Show($"Индекс {dish_id} выходит за пределы списка блюд.");
                return;
            }

            sostavBlud = bludaFromDB.LoadSostav(real_dish_id);

            foreach (var recipe in recipes)
            {
                if (recipe.Dish_id == real_dish_id)
                {
                    currentRecipe = recipe;
                    break;
                }
            }

            if (currentRecipe != null)
            {
                txbRecept.Text = currentRecipe.Recipe_description;
            }
            else
            {
                txbRecept.Text = "Рецепт отсутствует.";
            }

            foreach (var item in sostavBlud)
            {
                lbxSostav.Items.Add(item.Product_name + ", " + item.Weight);
            }
        }

        void CheckDishExistForRight()
        {
            do
            {
                dish_id++;

                if (dish_id >= bludos.Count)
                {
                    dish_id = 0;
                }

            } while (!bludaFromDB.DishIdExists(bludos[dish_id].Id_bluda));

            PrintSostavBluda(sostavBlud);

        }

        void CheckDishExistForLeft()
        {
            do
            {
                dish_id--;
                if (dish_id >= bludos.Count)
                {
                    dish_id = 0;
                }

            } while (!bludaFromDB.DishIdExists(bludos[dish_id].Id_bluda));

            PrintSostavBluda(sostavBlud);

        }

        private void butRight_Click(object sender, EventArgs e)
        {
            CheckDishExistForRight();
        }

        private void butLeft_Click(object sender, EventArgs e)
        {
            CheckDishExistForLeft();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            
            if (currentRecipe == null) {
                AddRecipes addRecipes = new AddRecipes(real_dish_id, "add");
                DialogResult dialogResult = addRecipes.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    PrintSostavBluda(sostavBlud);
                }
            }
            else
            {
                MessageBox.Show("У этого блюда уже есть рецепт!");
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            if (currentRecipe != null)
            {
                AddRecipes addRecipes = new AddRecipes(real_dish_id, "edit");
                DialogResult dialogResult = addRecipes.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    PrintSostavBluda(sostavBlud);
                }
            }
            else
            {
                MessageBox.Show("Выбрано блюдо без рецепта! Сначала добавьте рецепт");
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            bludaFromDB.DeleteRecipeByDishId(real_dish_id);
            PrintSostavBluda(sostavBlud);
        }

        private void butBack_Click(object sender, EventArgs e)
        {

        }
    }
}
