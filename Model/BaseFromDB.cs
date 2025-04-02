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
    public class BaseFromDB
    {
        DbConnection conn = new DbConnection();
        public List<Base> LoadBase()
        {
            List<Classes.Base> osnova = new List<Classes.Base>();
            NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT \"Id_osnovi\", \"Dish_base_on\" from osnova";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        osnova.Add(new Base((int)reader[0], reader[1].ToString()));
                    }
                }
                reader.Close();
                return osnova;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return osnova;
            }
            finally { connection.Close(); }
        }
    }
}
