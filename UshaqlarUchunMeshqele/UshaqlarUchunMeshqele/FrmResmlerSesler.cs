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
    public partial class FrmResmlerSesler : Form
    {
        public FrmResmlerSesler()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Faqan Aliyev\Documents\Visual Studio 2013\Projects\UshaqlarUchunMeshqele\dog.mp3";
        }

        private void FrmResmlerSesler_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Faqan Aliyev\Documents\Visual Studio 2013\Projects\UshaqlarUchunMeshqele\sheep.wav";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Faqan Aliyev\Documents\Visual Studio 2013\Projects\UshaqlarUchunMeshqele\cat.mp3";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Faqan Aliyev\Documents\Visual Studio 2013\Projects\UshaqlarUchunMeshqele\duck.wav";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Faqan Aliyev\Documents\Visual Studio 2013\Projects\UshaqlarUchunMeshqele\cow.mp3";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Faqan Aliyev\Documents\Visual Studio 2013\Projects\UshaqlarUchunMeshqele\cock.mp3";
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            FrmAnaForm AnaSayfa = new FrmAnaForm();
            AnaSayfa.Show();
            this.Hide();
        }

        private void FrmResmlerSesler_Load_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
        }
    }
}

