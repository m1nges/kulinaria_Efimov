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

namespace kulinaria_Efimov.Forms
{
    public partial class ManageUser : Form
    {
        public List<Classes.User> user = new List<Classes.User>();
        UserFromDb ufdb = new UserFromDb();
        public ManageUser()
        {
            InitializeComponent();
        }
        public void ViewAllUsers()
        {
            user = ufdb.GetAllUsers();
            userInfoDGV.DataSource = user;
            userInfoDGV.Columns["UserId"].Visible = false;
            userInfoDGV.Columns["Phone"].Visible = false;
            userInfoDGV.Columns["DateOfBirthday"].Visible = false;  
            userInfoDGV.Columns["Login"].Visible = false;  
            userInfoDGV.Columns["Password"].Visible = false;
            userInfoDGV.Columns["Adress"].Visible = false;
            userInfoDGV.Columns["Email"].Visible = false;
            userInfoDGV.Columns["PassportSeries"].Visible = false;
            userInfoDGV.Columns["PassportNumber"].Visible = false;
            userInfoDGV.Columns["PassportKemVidan"].Visible = false;
            userInfoDGV.Columns["PassportVidanDate"].Visible = false;
            userInfoDGV.Columns["RoleId"].Visible = true;  

            userInfoDGV.Columns["FirstName"].HeaderText = "Имя";
            userInfoDGV.Columns["LastName"].HeaderText = "Фамилия";
            userInfoDGV.Columns["Patronomic"].HeaderText = "Отчество";
            userInfoDGV.Columns["RoleId"].HeaderText = "Роль";
        }

        public void ManageUser_Load(object sender, EventArgs e)
        {
                ViewAllUsers();
        }

        private void userInfoDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = userInfoDGV.Rows[e.RowIndex];
            string firstName = row.Cells["FirstName"].Value.ToString();
            string patronymic = row.Cells["Patronomic"].Value.ToString();
            string lastName = row.Cells["LastName"].Value.ToString();

            int roleId = -1;
            int.TryParse(row.Cells["RoleId"].Value.ToString(), out roleId);

            string phone = row.Cells["Phone"].Value.ToString();
            string address = row.Cells["Adress"].Value.ToString();
            changeNameTb.Text = firstName;
            changePatronymicTb.Text = patronymic;
            changeLastNameTb.Text = lastName;
            changeNumTb.Text = phone;
            changeAddressTb.Text = address;
            switch (roleId - 1)
            {
                case 0:
                    comboBox1.SelectedIndex = 0;
                    break;
                case 1:
                    comboBox1.SelectedIndex = 1;
                    break;
                case 2:
                    comboBox1.SelectedIndex = 2; 
                    break;
                default:
                    comboBox1.SelectedIndex = -1; 
                    break;
            }
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            if (userInfoDGV.SelectedRows.Count > 0)
            {
                var selectedRow = userInfoDGV.SelectedRows[0];
                int userId = Convert.ToInt32(selectedRow.Cells["UserId"].Value);

                int newRoleId = comboBox1.SelectedIndex + 1;
                ufdb.UpdateUserRole(userId, newRoleId);
                ViewAllUsers();
            }
            else
            {
                MessageBox.Show("Выберите пользователя для изменения роли.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm(this);
            rf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (userInfoDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пользователя для удаления.");
                return;
            }

            int userId = Convert.ToInt32(userInfoDGV.SelectedRows[0].Cells["UserID"].Value);

            bool success = ufdb.DeleteUser(userId);

            if (success)
            {
                MessageBox.Show("Пользователь успешно удален.");
                ViewAllUsers();
            }
            else
            {
                MessageBox.Show("Не удалось удалить пользователя.");
            }
        }
    }
}
