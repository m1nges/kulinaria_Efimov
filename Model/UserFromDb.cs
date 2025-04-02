using kulinaria_Efimov.Classes;
using kulinaria_Efimov.Forms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kulinaria_Efimov.Model
{
    public class UserFromDb
    {
        DbConnection conn = new DbConnection();
        Captcha captcha = new Captcha();
        public User GetUser(string login, string password)
        {
            User user = null;

            try
            {
                NpgsqlConnection connect = new NpgsqlConnection(conn.connectionStr);

                {
                    connect.Open();
                    string sqlExp = "select user_id, first_name, last_name, patronymic, date_of_birth, login, password, phone, adress, datauser.email, datauser.passport_series, datauser.passport_number, datauser.kem_vidan_passport, datauser.vidan_date, role_id from users" +
                        " left join datauser using(user_id) " +
                        "WHERE login = @login;";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("login", login);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        if (password != "")
                        {
                            if (Verification.VerifySHA512Hash(password, (string)reader["Password"]))
                            {
                                user = new User(reader.GetInt32(0),
                                reader.IsDBNull(1) ? null : reader.GetString(1), reader.IsDBNull(2) ? null : reader.GetString(2),
                                reader.IsDBNull(3) ? null : reader.GetString(3), reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4),
                                reader.IsDBNull(5) ? null : reader.GetString(5), reader.IsDBNull(6) ? null : reader.GetString(6),
                                reader.IsDBNull(7) ? null : reader.GetString(7), reader.IsDBNull(8) ? null : reader.GetString(8),
                                reader.IsDBNull(9) ? null : reader.GetString(9),
                                reader.IsDBNull(10) ? null : reader.GetString(10),
                                reader.IsDBNull(11) ? null : reader.GetString(11),
                                reader.IsDBNull(12) ? null : reader.GetString(12),
                                reader.IsDBNull(13) ? DateTime.Now : reader.GetDateTime(13),
                                reader.IsDBNull(14) ? 0 : reader.GetInt32(14));
                            }
                            else
                            {
                                MessageBox.Show("Неверный пароль!");

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нет такого пользователя");
                    }
                    return user;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return user;
            }
        }


        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = @"
                SELECT user_id, first_name, last_name, patronymic, date_of_birth, login, password, phone, adress, 
                       email, passport_series, passport_number, kem_vidan_passport, vidan_date, role_id
                FROM users 
                LEFT JOIN datauser USING(user_id) 
                ORDER BY users.user_id";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sqlQuery, connection))
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User(
                                reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                                reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                                reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                                reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                                ParseDateTime(reader, 4),
                                reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                                reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                                reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                                reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                                reader.IsDBNull(9) ? string.Empty : reader.GetString(9),
                                reader.IsDBNull(10) ? string.Empty : reader.GetString(10),
                                reader.IsDBNull(11) ? string.Empty : reader.GetString(11),
                                reader.IsDBNull(12) ? string.Empty : reader.GetString(12),
                                ParseDateTime(reader, 13),
                                reader.IsDBNull(14) ? 0 : reader.GetInt32(14)
                            ));
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Ошибка базы данных: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Общая ошибка: " + ex.Message);
                }
            }
            return users;
        }

        private DateTime ParseDateTime(NpgsqlDataReader reader, int columnIndex)
        {
            if (reader.IsDBNull(columnIndex))
                return DateTime.MinValue;

            string dateString = reader[columnIndex].ToString();
            if (DateTime.TryParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                return parsedDate;
            }
            return DateTime.MinValue;
        }




        public bool DeleteUser(int userId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(conn.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "DELETE FROM users WHERE user_id = @userId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ошибка при удалении пользователя: " + ex.Message);
                return false;
            }
        }
        public bool CheckPassword(string password, string passRepeat)
        {
            if (password.Length < 6)
            {
                MessageBox.Show("Длина пароля не может быть короче 6 символов");
                return false;
            }
            else
            {
                bool f, f1, f2;
                f = f1 = f2 = false;
                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsDigit(password[i])) { f1 = true; }
                    if (Char.IsUpper(password[i])) { f2 = true; }
                    if (f1 && f2) { break; }
                }
                if (!(f1 && f2))
                {
                    MessageBox.Show("Пароль должен содержать хотя бы одну цифру и одну заглавную букву!");
                    return f1 && f2;
                }
                else
                {
                    string simbol = "!@#$^";
                    for (int i = 0; i < password.Length; i++)
                    {
                        for (int j = 0; j < simbol.Length; j++)
                        {
                            if (password[i] == simbol[j]) { f = true; break; }
                        }
                    }
                }
                if (!f) MessageBox.Show("Пароль должен содержать один из символов !@#$^");
                if ((password == passRepeat) && f) return true; else { MessageBox.Show("Неверно подтвержден пароль"); return false; }

            }
        }
        public bool CheckUser(string login)
        {
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(conn.connectionStr))
                {
                    connect.Open();
                    string sqlExp = "SELECT login from Users where login=@login";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("@login", login);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Такой логин уже есть"); return false;
                    }
                    else
                    {
                        reader.Close();
                        return true;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message); return false;
            }
        }
        public void UserAdd(string login, string password, string firstName, string lastName, string email)
        {
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(conn.connectionStr))
                {
                    connect.Open();
                    string hashedPassword = Verification.GetSHA512Hash(password);
                    string sqlExp = "INSERT INTO users (login, password, first_Name,last_Name, patronymic, date_of_birth, phone, adress) values" +
                        "(@login, @password, @firstName, @lastName, null, null, null, null);" +
                        "update datauser " +
                        "set email = @email " +
                        "WHERE user_id = (SELECT MAX(user_id) FROM datauser);";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UserUpdateProfil(User user)
        {
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(conn.connectionStr))
                {
                    connect.Open();
                    string sqlExp = "UPDATE users SET first_name = @firstName, last_name = @lastName, patronymic = @patronymic, " +
                                    "date_of_birth = @dateOfBirth, phone = @phone, adress = @adress " +
                                    "WHERE user_id = @userId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect))
                    {
                        cmd.Parameters.AddWithValue("@firstName", user.FirstName);
                        cmd.Parameters.AddWithValue("@lastName", user.LastName);
                        cmd.Parameters.AddWithValue("@patronymic", user.Patronomic);
                        cmd.Parameters.AddWithValue("@dateOfBirth", user.DateOfBirthday);
                        cmd.Parameters.AddWithValue("@phone", user.Phone);
                        cmd.Parameters.AddWithValue("@adress", user.Adress);
                        cmd.Parameters.AddWithValue("@userId", user.UserId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ошибка при обновлении данных пользователя: " + ex.Message);
            }
        }

        public void UpdateUserPassword(int userId, string newPassword)
        {
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(conn.connectionStr))
                {
                    connect.Open();
                    string sqlExp = "UPDATE users SET password=@newPassword WHERE user_id=@userId";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect))
                    {
                        cmd.Parameters.AddWithValue("@newPassword", newPassword);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ошибка при обновлении пароля: " + ex.Message);
            }
        }

        public void UpdateUserRole(int userId, int newRoleId)
        {
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(conn.connectionStr))
                {
                    connect.Open();
                    string sqlExp = "UPDATE users SET role_id = @newRoleId WHERE user_id = @userId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect))
                    {
                        cmd.Parameters.AddWithValue("@newRoleId", newRoleId);
                        cmd.Parameters.AddWithValue("@userId", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Роль пользователя успешно обновлена!");
                        }
                        else
                        {
                            MessageBox.Show("Роль не обновлена. Возможно, пользователь с таким ID не найден или роль не изменилась.");
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ошибка при обновлении роли пользователя: " + ex.Message);
            }
        }

        public void UpdateDataUser(User user)
        {
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(conn.connectionStr))
                {
                    connect.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("CALL public.update_datauser(@p_user_id, @p_email, @p_passport_series, @p_passport_number, @p_kem_vidan_passport, @p_vidan_date)", connect))
                    {
                        cmd.Parameters.AddWithValue("@p_user_id", NpgsqlTypes.NpgsqlDbType.Integer, user.UserId);
                        cmd.Parameters.AddWithValue("@p_email", NpgsqlTypes.NpgsqlDbType.Varchar, user.Email ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@p_passport_series", NpgsqlTypes.NpgsqlDbType.Varchar, user.PassportSeries ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@p_passport_number", NpgsqlTypes.NpgsqlDbType.Varchar, user.PassportNumber ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@p_kem_vidan_passport", NpgsqlTypes.NpgsqlDbType.Varchar, user.PassportKemVidan ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@p_vidan_date", NpgsqlTypes.NpgsqlDbType.Date, user.PassportVidanDate);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ошибка при обновлении данных в таблице DataUser: " + ex.Message);
            }
        }


    }
}
