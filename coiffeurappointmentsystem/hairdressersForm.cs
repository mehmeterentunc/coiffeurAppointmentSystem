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
    public partial class hairdressersForm : Form
    {
        public hairdressersForm()
        {
            InitializeComponent();
        }
       
        private void button7_Click_1(object sender, EventArgs e)
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

        private void hairdressersForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Adem Kansız");
            comboBox1.Items.Add("Sefa Kansız");
            comboBox1.Items.Add("Gökhan Kurnaz");

            label6.Text = "He is the founder of barber. He is the most experienced hairdresser " +
                   "of barber with 25 years of experience. He got his mastership certificate when he was just 17 " +
                   "years old.He is now 54 years old";
            pictureBox9.ImageLocation = "D:\\User\\İndirilenler\\ademkansiz.jpg";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Adem Kansız")
            {
                label6.Text = "He is the founder of barber. He is the most experienced hairdresser " +
                    "of barber with 25 years of experience. He got his mastership certificate when he was just 17 " +
                    "years old.He is now 54 years old";
                pictureBox9.ImageLocation = "D:\\User\\İndirilenler\\ademkansiz.jpg";
            }                


            else if (comboBox1.Text == "Sefa Kansız") 
            {
                label6.Text = "He is 21 years old. He learned the business from his master and uncle, " +
                    "Adem Kansız. He can do new fashion haircuts very well. He improves himself day by day. His future is bright.";
                pictureBox9.ImageLocation = "D:\\User\\İndirilenler\\sefakansiz.jpg";
            }

            else if (comboBox1.Text == "Gökhan Kurnaz")
            {
                label6.Text = "He is 51 years old. He is a friend of Adem Kansız from the hairdressing school. His success " +
                    "at school has always attracted attention. Since he has been doing this job for a long time, he is experienced " +
                    "and gives trainings.";
                pictureBox9.ImageLocation = "D:\\User\\İndirilenler\\gokhankurnaz.jpg";
            }
        }
    }
}
