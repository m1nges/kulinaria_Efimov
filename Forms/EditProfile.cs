using kulinaria_Efimov.Classes;
using kulinaria_Efimov.Model;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace kulinaria_Efimov.Forms
{
    public partial class EditProfile : Form
    {
        MainForm mainForm = new MainForm();
        UserFromDb userFromDB = new UserFromDb();
        public EditProfile()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            changeNameTb.Text = AuthorizationForm.currentUser.FirstName;
            changePatronymicTb.Text = AuthorizationForm.currentUser.Patronomic;
            changeLastNameTb.Text = AuthorizationForm.currentUser.LastName;
            changeNumTb.Text = AuthorizationForm.currentUser.Phone;
            changeDateOfBirthDtp.Value = AuthorizationForm.currentUser.DateOfBirthday;
            changeAddressTb.Text = AuthorizationForm.currentUser.Adress;
            changeEmailTb.Text = AuthorizationForm.currentUser.Email;
            changePassportSeriesTb.Text = AuthorizationForm.currentUser.PassportSeries;
            ChangePassportNumberTb.Text = AuthorizationForm.currentUser.PassportNumber;
            ChangeVidanKemTb.Text = AuthorizationForm.currentUser.PassportKemVidan;
            changeVidanDateTb.Value = AuthorizationForm.currentUser.PassportVidanDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(agreementCb.Checked) {
                if (changeNameTb.Text != "" && changeLastNameTb.Text != "")
                {
                    AuthorizationForm.currentUser.FirstName = changeNameTb.Text;
                    AuthorizationForm.currentUser.Patronomic = changePatronymicTb.Text;
                    AuthorizationForm.currentUser.LastName = changeLastNameTb.Text;
                    AuthorizationForm.currentUser.Phone = changeNumTb.Text;
                    AuthorizationForm.currentUser.DateOfBirthday = changeDateOfBirthDtp.Value;
                    AuthorizationForm.currentUser.Adress = changeAddressTb.Text;
                    AuthorizationForm.currentUser.Email = changeEmailTb.Text;
                    AuthorizationForm.currentUser.PassportSeries = changePassportSeriesTb.Text;
                    AuthorizationForm.currentUser.PassportNumber = ChangePassportNumberTb.Text;
                    AuthorizationForm.currentUser.PassportKemVidan = ChangeVidanKemTb.Text;
                    AuthorizationForm.currentUser.PassportVidanDate = changeVidanDateTb.Value;
                    userFromDB.UserUpdateProfil(AuthorizationForm.currentUser);
                    userFromDB.UpdateDataUser(AuthorizationForm.currentUser);
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Данные пользователя успешно обновлены");
                }
                else
                {
                    MessageBox.Show("Данные пользователя не были обновлены, заполните имя и фамилию");
                }
            }
            else
            {
                MessageBox.Show("Согласитесь с политикой обработки персональных данных");
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void EditProfile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string surname = changeLastNameTb.Text;
            string name = changeNameTb.Text;
            string patronymic = changePatronymicTb.Text;
            string passportSeries = changePassportSeriesTb.Text;
            string passportNumber = ChangePassportNumberTb.Text;
            string issueDate = changeVidanDateTb.Text;
            string issuingAuthority = ChangeVidanKemTb.Text;
            string address = changeAddressTb.Text;
            string username = AuthorizationForm.currentUser.Login;

            ExcelUnLoad word = new ExcelUnLoad();
            word.Soglasie(surname, name, patronymic, passportSeries, passportNumber,
                                    issueDate, issuingAuthority, address, username);
        }
    }
}
