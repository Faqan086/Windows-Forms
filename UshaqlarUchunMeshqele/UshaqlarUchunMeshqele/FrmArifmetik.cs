using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UshaqlarUchunMeshqele
{
    public partial class FrmArifmetik : Form
    {
        public FrmArifmetik()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int puan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }

        private void FrmArifmetik_Load(object sender, EventArgs e)
        {

            label6.Visible = false;
            pictureBox1.Visible = false;
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.Clear();
            pictureBox1.Visible = false;

            int a = rastgele.Next(1, 10);
            int b = rastgele.Next(1, 10);
            int c = rastgele.Next(1, 5);

            label1.Text = a.ToString();
            label2.Text = b.ToString();

            if (c == 1)
            {
                label3.Text = "+";
            }
            if (c == 2)
            {
                label3.Text = "-";
            }
            if (c == 3)
            {
                label3.Text = "*";
            }
            if (c == 4)
            {
                label3.Text = "/";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;
            pictureBox1.Visible = true;

            int yanit;
            if (label3.Text == "+")
            {
                yanit = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text);
                label6.Text = yanit.ToString();
            }
            if (label3.Text == "-")
            {
                yanit = Convert.ToInt32(label1.Text) - Convert.ToInt32(label2.Text);
                label6.Text = yanit.ToString();
            }
            if (label3.Text == "*")
            {
                yanit = Convert.ToInt32(label1.Text) * Convert.ToInt32(label2.Text);
                label6.Text = yanit.ToString();
            }
            if (label3.Text == "/")
            {
                yanit = Convert.ToInt32(label1.Text) / Convert.ToInt32(label2.Text);
                label6.Text = yanit.ToString();
            }
            if (label6.Text == textBox1.Text)
            {

                pictureBox1.ImageLocation = (@"C:\Users\Faqan Aliyev\Documents\Visual Studio 2013\Projects\UshaqlarUchunMeshqele\tebrik.GIF");

                puan = puan + 10;
                label8.Text = puan.ToString();
            }
            else
            {

                pictureBox1.ImageLocation = (@"C:\Users\Faqan Aliyev\Documents\Visual Studio 2013\Projects\UshaqlarUchunMeshqele\regret.gif");
            }
        }

        private void btnAnaSayfa_Click_1(object sender, EventArgs e)
        {
            FrmAnaForm AnaSayfa = new FrmAnaForm();
            AnaSayfa.Show();
            this.Hide();
        }
    }
}
