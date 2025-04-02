using kulinaria_Efimov.Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kulinaria_Efimov.Model
{
    public class BludaFromDB
    {
        DbConnection conn = new DbConnection();
        public List<Classes.Bludo> LoadBludos()
        {
            List<Classes.Bludo> bludos = new List<Classes.Bludo>();
            NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "select id_bluda, bludo_name, vidi_blud.\"vid bluda\", osnova.\"Dish_base_on\", dish_weight, bludo_image\r\n" +
                    "from public.bluda\r\n" +
                    "join vidi_blud on bluda.dish_id = vidi_blud.\"Nomer vida bluda\"\r\njoin osnova on bluda.dish_base_on = osnova.\"Id_osnovi\"" +
                    "order by id_bluda";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        bludos.Add(new Classes.Bludo((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), (int)reader[4], reader[5].ToString()));
                    }
                }
                reader.Close();
                return bludos;
            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return bludos;
            }
            finally
            {
                connection.Close();
            }
        }
        public List<Classes.Bludo> FiltrBludosByCategory(int categoryId)
        {
            List<Classes.Bludo> filteredBludos = new List<Classes.Bludo>();
            NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "select id_bluda, bludo_name, vidi_blud.\"vid bluda\", osnova.\"Dish_base_on\", dish_weight, bludo_image " +
                                "from public.bluda " +
                                "join vidi_blud on bluda.dish_id = vidi_blud.\"Nomer vida bluda\" " +
                                "join osnova on bluda.dish_base_on = osnova.\"Id_osnovi\" " +
                                "where bluda.dish_id = @categoryId";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@categoryId", categoryId);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        filteredBludos.Add(new Classes.Bludo((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), (int)reader[4], reader[5].ToString()));
                    }
                }
                reader.Close();
                return filteredBludos;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return filteredBludos;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Classes.Bludo> SearchBludos(string tbxSearch)
        {
            List<Classes.Bludo> allBludos = LoadBludos();
            List<Classes.Bludo> bludoSearch = new List<Classes.Bludo>();

            foreach (Bludo item in allBludos)
            {
                if (item.Bludo_name.StartsWith(tbxSearch) || item.Osnova.StartsWith(tbxSearch))
                {
                    bludoSearch.Add(item);
                }
            }
            return bludoSearch;
        }

        public List<Classes.Bludo> FiltrBludosByCategoryAndSearch(int categoryId, string startsWith)
        {
            List<Classes.Bludo> filteredBludos = new List<Classes.Bludo>();
            NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT id_bluda, bludo_name, vidi_blud.\"vid bluda\", osnova.\"Dish_base_on\", dish_weight, bludo_image " +
                    "FROM public.bluda " +
                    "JOIN vidi_blud ON bluda.dish_id = vidi_blud.\"Nomer vida bluda\" " +
                    "JOIN osnova ON bluda.dish_base_on = osnova.\"Id_osnovi\" " +
                    $"WHERE bluda.dish_id = @categoryId AND bludo_name like \'{startsWith}%\';";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@categoryId", categoryId);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        filteredBludos.Add(new Classes.Bludo((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), (int)reader[4], reader[5].ToString()));
                    }
                }
                reader.Close();
                return filteredBludos;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return filteredBludos;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Classes.SostavBlud> LoadSostav(int dish_id)
        {
            List<Classes.SostavBlud> sostavBlud = new List<Classes.SostavBlud>();
            NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "select sostav_blud.dish_id, products.\"Product_name\", weight from sostav_blud " +
                    "join products on products.\"Product_id\" = sostav_blud.product_id " +
                    "join bluda on bluda.id_bluda = sostav_blud.dish_id " +
                    "where sostav_blud.dish_id = @id_bluda";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@id_bluda", dish_id);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sostavBlud.Add(new Classes.SostavBlud((int)reader[0], reader[1].ToString(), (int)reader[2]));
                    }
                }
                reader.Close();
                return sostavBlud;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return sostavBlud;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Classes.Recipe> LoadRecipes()
        {
            List<Classes.Recipe> recipe = new List<Classes.Recipe>();
            NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "select id_bluda, recipe from recipes ";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        recipe.Add(new Classes.Recipe((int)reader[0], reader[1].ToString()));
                    }
                }
                reader.Close();
                return recipe;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return recipe;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Classes.Recipe> AddRecipeByDishId(int dish_id, string recipe_desc)
        {
            List<Classes.Recipe> recipe = new List<Classes.Recipe>();
            NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "insert into recipes(id_bluda, recipe)" +
                    "values(@dish_id, @recipe)";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@dish_id", dish_id);
                command.Parameters.AddWithValue("@recipe", recipe_desc);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        recipe.Add(new Classes.Recipe((int)reader[0], reader[1].ToString()));
                    }
                }
                reader.Close();
                return recipe;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return recipe;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Classes.Recipe> UpdateRecipeByDishId(int dish_id, string recipe_desc)
        {
            List<Classes.Recipe> recipe = new List<Classes.Recipe>();
            NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "update recipes " +
                    "set recipe = @recipe " +
                    "where id_bluda = @dish_id";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@dish_id", dish_id);
                command.Parameters.AddWithValue("@recipe", recipe_desc);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        recipe.Add(new Classes.Recipe((int)reader[0], reader[1].ToString()));
                    }
                }
                reader.Close();
                return recipe;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return recipe;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Classes.SostavBlud> DeleteRecipeByDishId(int dish_id)
        {
            int affectedRows = 0;
            List<Classes.SostavBlud> sostavBlud = new List<Classes.SostavBlud>();
            NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "delete from recipes " +
                    "where id_bluda = @id_bluda";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@id_bluda", dish_id);
                affectedRows = command.ExecuteNonQuery();
                if(affectedRows == 0)
                {
                    MessageBox.Show("Вы выбрали продукт без рецепта, удаление невозможно");
                }
                else if(affectedRows == 1) 
                {
                    MessageBox.Show("Рецепт успешно удален");
                }
                NpgsqlDataReader reader = command.ExecuteReader();
                reader.Close();
                return sostavBlud;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return sostavBlud;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Classes.SostavBlud> DeleteBludo(int dish_id)
        {
            List<Classes.SostavBlud> sostavBlud = new List<Classes.SostavBlud>();
            NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "delete from bluda " +
                    "where id_bluda = @id_bluda";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@id_bluda", dish_id);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sostavBlud.Add(new Classes.SostavBlud((int)reader[0], reader[1].ToString(), (int)reader[2]));
                    }
                }
                reader.Close();
                return sostavBlud;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return sostavBlud;
            }
            finally
            {
                connection.Close();
            }
        }


        public void AddNewBludo(Bludo newBludo, List<SostavBlud> sostavBludas, int idCategoriya, int idBase, string picPath)
        {
            NpgsqlConnection connect = new NpgsqlConnection(conn.connectionStr);
            connect.Open();
            NpgsqlTransaction transaction = connect.BeginTransaction();
            NpgsqlCommand cmd = connect.CreateCommand();
            cmd.Transaction = transaction;
            try
            {
                cmd.CommandText = "insert into bluda(bludo_name, dish_id, dish_base_on, dish_weight, bludo_image) " +
                            "values(@bludoName, @catId, @osnova, @weight, @picPath)";


                cmd.Parameters.AddWithValue("@bludoName", newBludo.Bludo_name);
                cmd.Parameters.AddWithValue("@catId", idCategoriya);
                cmd.Parameters.AddWithValue("@osnova", idBase);
                cmd.Parameters.AddWithValue("@weight", newBludo.Dish_weight);
                cmd.Parameters.AddWithValue("@picPath", picPath);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select MAX(id_bluda) from bluda";
                int idBluda = Convert.ToInt32(cmd.ExecuteScalar());
                MessageBox.Show(idBluda.ToString());

                for (int i = 0; i < sostavBludas.Count; i++)
                {
                    cmd.CommandText = $"insert into sostav_blud (dish_id, product_id, weight) " +
                                    $"values ({idBluda}, (select products.\"Product_id\" from products where \"Product_name\" = '{sostavBludas[i].Product_name}'), {sostavBludas[i].Weight})";
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show($"Блюдо добавлено!");
                transaction.Commit();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
            }
        }

        public List<Classes.Bludo> FiltrBludosByProducts(List<int> productIds, bool include)
        {
            List<Classes.Bludo> filteredBludos = new List<Classes.Bludo>();
            NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr);
            try
            {
                connection.Open();
                StringBuilder sql = new StringBuilder(
                    "SELECT DISTINCT bluda.id_bluda, bludo_name, dish_weight, bludo_image " +
                    "FROM public.bluda " +
                    "JOIN sostav_blud ON bluda.id_bluda = sostav_blud.dish_id " +
                    "JOIN products ON sostav_blud.product_id = products.\"Product_id\" ");

                if (include)
                {
                    sql.Append("WHERE ");
                    for (int i = 0; i < productIds.Count; i++)
                    {
                        sql.Append($"sostav_blud.product_id = @productId{i}");
                        if (i < productIds.Count - 1)
                            sql.Append(" OR ");
                    }
                }
                else
                {
                    sql.Append("WHERE bluda.id_bluda NOT IN (SELECT DISTINCT dish_id FROM sostav_blud WHERE ");
                    for (int i = 0; i < productIds.Count; i++)
                    {
                        sql.Append($"product_id = @productId{i}");
                        if (i < productIds.Count - 1)
                            sql.Append(" OR ");
                    }
                    sql.Append(")");
                }

                NpgsqlCommand command = new NpgsqlCommand(sql.ToString(), connection);
                for (int i = 0; i < productIds.Count; i++)
                {
                    command.Parameters.AddWithValue($"@productId{i}", productIds[i]);
                }

                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        filteredBludos.Add(new Classes.Bludo(
                            (int)reader[0], // id_bluda
                            reader[1].ToString(), // bludo_name
                            null, // osnova (удалено)
                            null, // vid bluda (удалено)
                            (int)reader[2], // dish_weight
                            reader[3].ToString() // bludo_image
                        ));
                    }
                }
                reader.Close();
                return filteredBludos;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return filteredBludos;
            }
            finally
            {
                connection.Close();
            }
        }




        public bool DishIdExists(int dish_id)
        {
            bool exists = false;
            NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "select exists(select 1 from bluda where id_bluda = @dish_id)";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@dish_id", dish_id);
                exists = (bool)command.ExecuteScalar();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка проверки ID блюда: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return exists;
        }



    }
}
