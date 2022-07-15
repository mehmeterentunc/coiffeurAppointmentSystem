using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace coiffeurappointmentsystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        
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
            panel1.BackColor = Color.FromArgb(0,192,192);
            textBox1.ForeColor = Color.FromArgb(0, 192, 192);

            panel2.ForeColor = Color.White;
            textBox2.ForeColor = Color.White;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            textBox2.ForeColor = Color.FromArgb(0, 192, 192);

            panel1.ForeColor = Color.White;
            textBox1.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            register register = new register();
            register.Show();
            this.Hide();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-301P5S3\\MSSQLSERVERR;Initial Catalog=coiffeurAppointmentSystem;Integrated Security=True");
        
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select*from customer where username='" +textBox1.Text + "'And password='" +textBox2.Text+ "' ");
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is wrong");
            }
            con.Close();
        }

        
    }
}

