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
    public partial class AuthorizationForm : Form
    {
        int authCounter = 0;
        Captcha captcha = new Captcha();
        UserFromDb userFromDB = new UserFromDb();
        public static User currentUser { get; set; } = null;
        public AuthorizationForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text != "" && textBox2.Text != ""))
            {
                MessageBox.Show("Введите данные"); return;
            }
            else
            {
                currentUser = userFromDB.GetUser(textBox1.Text, textBox2.Text);
                if (currentUser != null)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
            }
            authCounter++;
            if(authCounter >= 2 && currentUser == null)
            {
                captcha.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(this);
            registrationForm.Show();
            this.Hide();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(AuthorizationForm_KeyDown);
        }

        private void AuthorizationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
