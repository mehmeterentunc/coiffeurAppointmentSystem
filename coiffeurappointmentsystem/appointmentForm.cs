using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coiffeurappointmentsystem
{
    public partial class appointmentForm : Form
    {
        public appointmentForm()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridView1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            appointmentForm appointmentForm = new appointmentForm();
            appointmentForm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hairdressersForm hairdressersForm = new hairdressersForm();
            hairdressersForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            priceListForm priceListForm = new priceListForm();
            priceListForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            aboutForm aboutForm = new aboutForm();
            aboutForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contactForm contactForm = new contactForm();
            contactForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-301P5S3\\MSSQLSERVERR;Initial Catalog=coiffeurAppointmentSystem;Integrated Security=True");
        private void appointmentForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select*from hairdressers",conn);
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["name"]);
            }
            conn.Close();

            



        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into appointment (Name,Surname,Date,DateTime,Hairdressers,Process,PhoneNumber)  values(@names,@surnames,@times,@times2,@hairdressers,@processs,@phoneNumbers)", conn);

            cmd.Parameters.AddWithValue("@names", textBox1.Text);
            cmd.Parameters.AddWithValue("@surnames", textBox2.Text);
            cmd.Parameters.AddWithValue("@phoneNumbers", textBox3.Text);
            cmd.Parameters.AddWithValue("@times", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@times2", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@hairdressers",comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@processs", textBox5.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Your appointment has been created.");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();

        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        public void show(string values)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(values,conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            show("Select*from appointment");
        }

        public void DatagridviewSetting(DataGridView datagridview)
        {
            datagridview.RowHeadersVisible = false;
            datagridview.BorderStyle = BorderStyle.None;
            datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50,50,50);
            datagridview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45,45,45);
            datagridview.DefaultCellStyle.SelectionForeColor = Color.White;
            datagridview.EnableHeadersVisualStyles = false;
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40,40,40);
            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        
    }
}
