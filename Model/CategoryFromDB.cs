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
    public class CategoryFromDB
    {
        DbConnection conn = new DbConnection();
        public List<Classes.Category> LoadCategories()
        {
            List<Classes.Category> categories = new List<Classes.Category>();
            NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT \"Nomer vida bluda\", \"vid bluda\" FROM public.vidi_blud";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        categories.Add(new Classes.Category((int)reader[0], reader[1].ToString()));
                    }
                }
                reader.Close();
                return categories;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return categories;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
