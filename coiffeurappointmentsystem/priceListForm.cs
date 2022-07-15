using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coiffeurappointmentsystem
{
    public partial class priceListForm : Form
    {
        public priceListForm()
        {
            InitializeComponent();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int totalPrice = 0;

            if (checkBox1.Checked==true)
            {
                totalPrice = totalPrice + 30;
            }

            if (checkBox2.Checked == true)
            {
                totalPrice = totalPrice + 20;
            }

            if (checkBox3.Checked == true)
            {
                totalPrice = totalPrice + 20;
            }

            if (checkBox4.Checked == true)
            {
                totalPrice = totalPrice + 75;
            }

            if (checkBox5.Checked == true)
            {
                totalPrice = totalPrice + 10;
            }

            if (checkBox6.Checked == true)
            {
                totalPrice = totalPrice + 15;
            }

            label20.Text = Convert.ToString(totalPrice)+"$";

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int totalPrice = 0;

            if (checkBox1.Checked == true)
            {
                totalPrice = totalPrice + 30;
            }

            if (checkBox2.Checked == true)
            {
                totalPrice = totalPrice + 20;
            }

            if (checkBox3.Checked == true)
            {
                totalPrice = totalPrice + 20;
            }

            if (checkBox4.Checked == true)
            {
                totalPrice = totalPrice + 75;
            }

            if (checkBox5.Checked == true)
            {
                totalPrice = totalPrice + 10;
            }

            if (checkBox6.Checked == true)
            {
                totalPrice = totalPrice + 15;
            }

            label20.Text = Convert.ToString(totalPrice)+"$";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int totalPrice = 0;

            if (checkBox1.Checked == true)
            {
                totalPrice = totalPrice + 30;
            }

            if (checkBox2.Checked == true)
            {
                totalPrice = totalPrice + 20;
            }

            if (checkBox3.Checked == true)
            {
                totalPrice = totalPrice + 20;
            }

            if (checkBox4.Checked == true)
            {
                totalPrice = totalPrice + 75;
            }

            if (checkBox5.Checked == true)
            {
                totalPrice = totalPrice + 10;
            }

            if (checkBox6.Checked == true)
            {
                totalPrice = totalPrice + 15;
            }

            label20.Text = Convert.ToString(totalPrice)+"$";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int totalPrice = 0;

            if (checkBox1.Checked == true)
            {
                totalPrice = totalPrice + 30;
            }

            if (checkBox2.Checked == true)
            {
                totalPrice = totalPrice + 20;
            }

            if (checkBox3.Checked == true)
            {
                totalPrice = totalPrice + 20;
            }

            if (checkBox4.Checked == true)
            {
                totalPrice = totalPrice + 75;
            }

            if (checkBox5.Checked == true)
            {
                totalPrice = totalPrice + 10;
            }

            if (checkBox6.Checked == true)
            {
                totalPrice = totalPrice + 15;
            }

            label20.Text = Convert.ToString(totalPrice)+"$";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int totalPrice = 0;

            if (checkBox1.Checked == true)
            {
                totalPrice = totalPrice + 30;
            }

            if (checkBox2.Checked == true)
            {
                totalPrice = totalPrice + 20;
            }

            if (checkBox3.Checked == true)
            {
                totalPrice = totalPrice + 20;
            }

            if (checkBox4.Checked == true)
            {
                totalPrice = totalPrice + 75;
            }

            if (checkBox5.Checked == true)
            {
                totalPrice = totalPrice + 10;
            }

            if (checkBox6.Checked == true)
            {
                totalPrice = totalPrice + 15;
            }

            label20.Text = Convert.ToString(totalPrice)+"$";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            int totalPrice = 0;

            if (checkBox1.Checked == true)
            {
                totalPrice = totalPrice + 30;
            }

            if (checkBox2.Checked == true)
            {
                totalPrice = totalPrice + 20;
            }

            if (checkBox3.Checked == true)
            {
                totalPrice = totalPrice + 20;
            }

            if (checkBox4.Checked == true)
            {
                totalPrice = totalPrice + 75;
            }

            if (checkBox5.Checked == true)
            {
                totalPrice = totalPrice + 10;
            }

            if (checkBox6.Checked == true)
            {
                totalPrice = totalPrice + 15;
            }

            label20.Text = Convert.ToString(totalPrice)+"$";
        }
    }
}
