using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace kulinaria_Efimov.Forms
{
    public partial class Captcha : Form
    {
        private string text = String.Empty;
        public Captcha()
        {
            InitializeComponent();
        }

        private void Captcha_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();
            Bitmap result = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(result);
            g.Clear(Color.LightBlue);

            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            text = string.Empty;

            Brush[] colors = { Brushes.Black, Brushes.Red, Brushes.RoyalBlue, Brushes.Green };
            Font font = new Font("Comfortaa", 23, FontStyle.Strikeout);

            int startX = 10;
            int startY = 10;

            for (int i = 0; i < 5; ++i)
            {
                text += ALF[rnd.Next(ALF.Length)];
                float angle = rnd.Next(-15, 15);
                int offsetX = rnd.Next(-5, 15); 
                int offsetY = rnd.Next(-5, 15); 

                g.TranslateTransform(startX + offsetX, startY + offsetY);
                g.RotateTransform(angle);
                g.DrawString(text[i].ToString(), font, colors[rnd.Next(colors.Length)], 50, 50);
                g.ResetTransform();

                startX += 30;
            }

            g.DrawLine(Pens.Black, new Point(0, 0), new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black, new Point(0, Height - 1), new Point(Width - 1, 0));

            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToUpper() == this.text)
            {
                MessageBox.Show("Верно!");
                textBox1.Clear();
                this.Close();
            }

            else
            {
                MessageBox.Show("Ошибка!");
                textBox1.Clear();
            }
                
        }

        private void Captcha_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
