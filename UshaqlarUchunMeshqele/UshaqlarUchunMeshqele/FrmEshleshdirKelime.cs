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
    public partial class FrmEshleshdirKelime : Form
    {
        public FrmEshleshdirKelime()
        {
            InitializeComponent();
        }

        private void FrmEshleshdirKelime_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Pishik";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text = "It";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label1.Text = "At";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Qush";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Inek";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            label2.Text = "Dog";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            label2.Text = "Cow";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            label2.Text = "Bird";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            label2.Text = "Horse";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            label2.Text = "Cat";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (label1.Text == "Pishik" && label2.Text == "Cat")
            {
                button1.Enabled = false;
                button6.Enabled = false;
                button1.BackColor = Color.Yellow;
                button6.BackColor = Color.Yellow;
            }
            if (label1.Text == "It" && label2.Text == "Dog")
            {
                button2.Enabled = false;
                button10.Enabled = false;
                button2.BackColor = Color.Yellow;
                button10.BackColor = Color.Yellow;
            }
            if (label1.Text == "At" && label2.Text == "Horse")
            {
                button3.Enabled = false;
                button7.Enabled = false;
                button3.BackColor = Color.Yellow;
                button7.BackColor = Color.Yellow;
            }
            if (label1.Text == "Qush" && label2.Text == "Bird")
            {
                button4.Enabled = false;
                button8.Enabled = false;
                button4.BackColor = Color.Yellow;
                button8.BackColor = Color.Yellow;
            }
            if (label1.Text == "Inek" && label2.Text == "Cow")
            {
                button5.Enabled = false;
                button9.Enabled = false;
                button5.BackColor = Color.Yellow;
                button9.BackColor = Color.Yellow;
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
