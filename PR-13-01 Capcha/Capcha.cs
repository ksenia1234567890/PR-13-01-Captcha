using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_13_01_Capcha
{
    public partial class Capcha : Form
    {
        public string text = "";

        public Capcha()
        {
            InitializeComponent();
        }
        private string CreateLabel()
        {
            Random rnd = new Random();

            // Генерация текста

            string text = "";
            string alphabet = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
            {
                text += alphabet[rnd.Next(alphabet.Length)];
            }
            return text;
        }

        private Bitmap CreateImage(int Width, int Height, string text)
        {
            Random rnd = new Random();
            Bitmap bmp = new Bitmap(Width, Height);

            Brush[] colors = { Brushes.Black, Brushes.Red, Brushes.RoyalBlue, Brushes.Green };
            Graphics g = Graphics.FromImage((Image)bmp);

            // Фон картинки

            g.Clear(Color.Gray);

            // Рисование текста

            g.DrawString(text, new Font("Arial", 60), colors[rnd.Next(colors.Length)], new PointF(0, 40));
            g.DrawLine(Pens.Black, 0, 80, 400, 80);
            
            return bmp;
        }

        private void input_Click(object sender, EventArgs e)
        {
            try
            {
                if(Tcaptcha.Text!=text)
                {
                    text = CreateLabel();
                    pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height, text);

                }
                if(Tcaptcha.Text==text)
                {
                    MessageBox.Show("Комбинация введена верно");
                    Form1 fr = new Form1();
                    fr.Show();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Capcha_Load(object sender, EventArgs e)
        {
            text = CreateLabel();
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height, text);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Close();

        }
    }
}
