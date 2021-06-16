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
    public partial class Board : Form
    {
        public Board()
        {
            InitializeComponent();
        }

        public Board(string user)
        {
            InitializeComponent();

            if (user == "nonstaff")
            {
                btnAdditems.Hide();
                btnRemoveitems.Hide();
                btnUpdateitems.Hide();
            }
            else if (user == "Admin")
            {
                btnAdditems.Show();
                btnRemoveitems.Show();
                btnUpdateitems.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }
    }
}
