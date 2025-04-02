using kulinaria_Efimov.Classes;
using kulinaria_Efimov.Model;
using System;
using System.Windows.Forms;

namespace kulinaria_Efimov.Forms
{
    public partial class ChangePassword : Form
    {
        UserFromDb userFromDB = new UserFromDb();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oldPassTb.Text))
            {
                MessageBox.Show("Введите старый пароль.");
                return;
            }

            if (string.IsNullOrEmpty(newPassTb.Text) || string.IsNullOrEmpty(confirmPassTb.Text))
            {
                MessageBox.Show("Введите новый пароль и подтвердите его.");
                return;
            }
            string hashedOldPassword = Verification.GetSHA512Hash(oldPassTb.Text);
            if (hashedOldPassword != AuthorizationForm.currentUser.Password)
            {
                MessageBox.Show("Неверный старый пароль.");
                return;
            }
            if (!userFromDB.CheckPassword(newPassTb.Text, confirmPassTb.Text))
            {
                return; 
            }

            string hashedNewPassword = Verification.GetSHA512Hash(newPassTb.Text);
            try
            {
                AuthorizationForm.currentUser.Password = hashedNewPassword;
                userFromDB.UpdateUserPassword(AuthorizationForm.currentUser.UserId, hashedNewPassword);
                MessageBox.Show("Пароль успешно изменен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении пароля: " + ex.Message);
            }
        }
    }
}
