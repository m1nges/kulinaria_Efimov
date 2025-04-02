using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulinaria_Efimov.Model
{
    public class DbConnection
    {
        public string connectionStr;

        public DbConnection()
        {
            connectionStr = "Host=localhost;Port=5050; Username = postgres; Password = 1;Database = kulinaria_Efimov";
        }
        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionStr);
        }

        public void OpenConnection(NpgsqlConnection connection)
        {
            try
            {
                connection.Open();
                Console.WriteLine("Соединение с базой данных установлено.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при подключении: {ex.Message}");
            }
        }

        public void CloseConnection(NpgsqlConnection connection)
        {
            connection.Close();
            Console.WriteLine("Соединение с базой данных закрыто.");
        }
    }
}
