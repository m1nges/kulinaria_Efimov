using kulinaria_Efimov.Classes;
using kulinaria_Efimov.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kulinaria_Efimov.Model
{
    public class ProductsFromDB
    {
        DbConnection conn = new DbConnection();
        public List<Classes.ProductsClass> LoadProducts()
        {
            List<Classes.ProductsClass> products = new List<Classes.ProductsClass>();
            NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * FROM public.products order by \"Product_id\"";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        products.Add(new Classes.ProductsClass((int)reader[0], reader[1].ToString(), (int)reader[2], (int)reader[3], (int)reader[4]));
                    }
                }
                reader.Close();
                return products;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return products;
            }
            finally
            {
                connection.Close();
            }
        }
        public void AddProduct(string productName, int protein, int fat,int carbs)
        {
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(conn.connectionStr))
                {
                    connect.Open();
                    string sqlExp = "insert into products(\"Product_name\", \"Protein\", \"Fat\", \"Carbs\")\r\n" +
                        "values\r\n(@product_name, @protein, @fat, @carbs);";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect))
                    {
                        cmd.Parameters.AddWithValue("@product_name", productName);
                        cmd.Parameters.AddWithValue("@protein", protein);
                        cmd.Parameters.AddWithValue("@fat", fat);
                        cmd.Parameters.AddWithValue("@carbs", carbs);
                        cmd.ExecuteNonQuery();
                    }


                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool DeleteProduct(int productId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr))
                {
                    connection.Open();

                    string checkUsageQuery = "SELECT COUNT(*) FROM sostav_blud WHERE \"product_id\" = @productId";
                    using (NpgsqlCommand checkCmd = new NpgsqlCommand(checkUsageQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@productId", productId);
                        int usageCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (usageCount > 0)
                        {
                            MessageBox.Show("Невозможно удалить продукт, так как он используется в одном или нескольких блюдах.");
                            return false;
                        }
                    }

                    string sqlQuery = "DELETE FROM products WHERE \"Product_id\" = @productId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ошибка при удалении продукта: " + ex.Message);
                return false;
            }
        }

    }
}
