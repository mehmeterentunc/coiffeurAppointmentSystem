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
    public partial class contactForm : Form
    {
        public contactForm()
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

        private void button10_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/maps/place/Sinanpa%C5%9Fa,+S%C3%BCleyman+Seba+Cd.,+Be%C5%9Fikta%C5%9F%2F%C4%B0stanbul/@41.0423954,28.9984721,17z/data=!3m1!4b1!4m5!3m4!1s0x14cab79fd885af7b:0xdee1dfb4bc580b54!8m2!3d41.0426143!4d28.99958");
        }
    }
}
