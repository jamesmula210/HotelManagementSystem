using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContinue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Board bd = new Board("nonstaff");
            bd.Show();
            this.Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "jamesCafe" && txtPassword.Text == "passmula")
            {
                Board bd = new Board("Admin");
                bd.Show();
                bd.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
