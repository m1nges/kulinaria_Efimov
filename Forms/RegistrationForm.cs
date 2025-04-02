using kulinaria_Efimov.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kulinaria_Efimov.Forms
{
    public partial class RegistrationForm : Form
    {
        UserFromDb userFromDB = new UserFromDb();
        private Form parentForm;
        private static Random rnd = new Random();
        public RegistrationForm(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void regBtn_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || emailTb.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля!");
                return;
            }

            bool rez = userFromDB.CheckPassword(textBox4.Text, textBox5.Text);
            if (!rez) return;
            else
            {
                if (userFromDB.CheckUser(textBox3.Text))
                {
                    userFromDB.UserAdd(textBox3.Text, textBox4.Text, textBox1.Text, textBox2.Text, emailTb.Text);
                    SendMail();
                }
                else return;
            }

            if (parentForm is AuthorizationForm)
            {
                AuthorizationForm authorizationForm = new AuthorizationForm();
                authorizationForm.Show();
            }
            else if (parentForm is ManageUser)
            {
                ManageUser manageUserForm = parentForm as ManageUser;
                manageUserForm.ViewAllUsers(); 
            }


            this.Close();
        }

        public static string GeneratePassword()
        {
            const string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";
            const string specialChars = "!@#$%^";
            const string allChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^";

            Random rndLength = new Random();
            char[] password = new char[rndLength.Next(8, 16)];

            password[0] = uppercaseLetters[rnd.Next(uppercaseLetters.Length)];
            password[1] = digits[rnd.Next(digits.Length)];
            password[2] = specialChars[rnd.Next(specialChars.Length)];

            for (int i = 3; i < password.Length; i++)
            {
                password[i] = allChars[rnd.Next(allChars.Length)];
            }

            ShuffleArray(password);

            return new string(password);
        }

        private static void ShuffleArray(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int j = rnd.Next(array.Length);
                char temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        private void SendMail()
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("egorka201806@yandex.ru", "m1nge's Restaurant Authorization");
            // кому отправляем
            MailAddress to = new MailAddress($"{emailTb.Text}");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Ваши данные для авторизации в m1nge's Restaurant";
            // текст письма
            m.Body = $"<h2>Ваш логин: {textBox3.Text}<br>Ваш пароль: {textBox4.Text}</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("egorka201806@yandex.ru", "dcfdboifdvnikcod");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void generatePassBtn_Click(object sender, EventArgs e)
        {
            textBox4.Text = GeneratePassword();
            textBox5.Text = textBox4.Text;
        }
    }
}
