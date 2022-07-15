using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace coiffeurappointmentsystem
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-301P5S3\\MSSQLSERVERR;Initial Catalog=coiffeurAppointmentSystem;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            textBox1.ForeColor = Color.FromArgb(0, 192, 192);

            panel2.ForeColor = Color.White;
            textBox2.ForeColor = Color.White;

            panel4.ForeColor = Color.White;
            textBox3.ForeColor = Color.White;

            panel5.ForeColor = Color.White;
            textBox4.ForeColor = Color.White;

            panel6.ForeColor = Color.White;
            textBox5.ForeColor = Color.White;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            textBox2.ForeColor = Color.FromArgb(0, 192, 192);

            panel1.ForeColor = Color.White;
            textBox1.ForeColor = Color.White;

            panel4.ForeColor = Color.White;
            textBox3.ForeColor = Color.White;

            panel5.ForeColor = Color.White;
            textBox4.ForeColor = Color.White;

            panel6.ForeColor = Color.White;
            textBox5.ForeColor = Color.White;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            panel4.BackColor = Color.FromArgb(0, 192, 192);
            textBox3.ForeColor = Color.FromArgb(0, 192, 192);

            panel2.ForeColor = Color.White;
            textBox2.ForeColor = Color.White;

            panel1.ForeColor = Color.White;
            textBox1.ForeColor = Color.White;

            panel5.ForeColor = Color.White;
            textBox4.ForeColor = Color.White;

            panel6.ForeColor = Color.White;
            textBox5.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            panel5.BackColor = Color.FromArgb(0, 192, 192);
            textBox4.ForeColor = Color.FromArgb(0, 192, 192);

            panel2.ForeColor = Color.White;
            textBox2.ForeColor = Color.White;

            panel1.ForeColor = Color.White;
            textBox1.ForeColor = Color.White;

            panel4.ForeColor = Color.White;
            textBox3.ForeColor = Color.White;

            panel6.ForeColor = Color.White;
            textBox5.ForeColor = Color.White;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            panel6.BackColor = Color.FromArgb(0, 192, 192);
            textBox5.ForeColor = Color.FromArgb(0, 192, 192);

            panel2.ForeColor = Color.White;
            textBox2.ForeColor = Color.White;

            panel1.ForeColor = Color.White;
            textBox1.ForeColor = Color.White;

            panel5.ForeColor = Color.White;
            textBox4.ForeColor = Color.White;

            panel4.ForeColor = Color.White;
            textBox3.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into customer (name,surname,phoneNumber,username,password)values (@names, @surnames, @phoneNumbers, @usernames, @passwords)" ,con);
            cmd.Parameters.AddWithValue("@names", textBox4.Text);
            cmd.Parameters.AddWithValue("@surnames", textBox5.Text);
            cmd.Parameters.AddWithValue("@phoneNumbers", textBox3.Text);
            cmd.Parameters.AddWithValue("@usernames", textBox1.Text);
            cmd.Parameters.AddWithValue("@passwords", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your registration has been completed, you can now log in.");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }
    }
}
