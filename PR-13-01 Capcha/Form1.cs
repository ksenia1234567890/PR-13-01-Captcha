using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PR_13_01_Capcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int count = 0;

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entrance_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=cxNTVJas;Database=users");
            string query = "select login from users where login=@login and password=@password";
            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("@login", Tlogin.Text);
            cmd.Parameters.AddWithValue("@password", Tpassword.Text);
            con.Open();
            string logintext = (string)cmd.ExecuteScalar();
            con.Close();
            if (logintext == Tlogin.Text)
            {
                MessageBox.Show("Вы авторизовались");
            }
            if (logintext != Tlogin.Text)
            {
                count++;
            }
            if (count == 3)
            {
                Capcha fr = new Capcha();
                fr.Show();
                this.Hide();
            }
        }
    }
}
