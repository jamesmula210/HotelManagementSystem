using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class UHola : UserControl
    {
        public UHola()
        {
            InitializeComponent();
        }

        int num = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                labelJames.Location = new Point(20, 180);
                labelJames.ForeColor = Color.Coral;
                num++;
            }
            else if (num == 1)
            {
                labelJames.Location = new Point(40, 180);
                labelJames.ForeColor = Color.Orange;
                num++;
            }
            else if (num == 2)
            {
                labelJames.Location = new Point(60, 180);
                labelJames.ForeColor = Color.Aqua;
                num = 0;
            }

            else if (num == 0)
            {
                labelIs.Location = new Point(60, 180);
                labelIs.ForeColor = Color.Red;
                num++;
            }
            else if (num == 1)
            {
                labelIs.Location = new Point(40, 180);
                labelIs.ForeColor = Color.Azure;
                num++;
            }
            else if (num == 2)
            {
                labelIs.Location = new Point(20, 180);
                labelIs.ForeColor = Color.Beige;
                num = 0;
            }

            else if (num == 0)
            {
                labelReal.Location = new Point(20, 180);
                labelReal.ForeColor = Color.Bisque;
                num++;
            }
            else if (num == 1)
            {
                labelReal.Location = new Point(40, 180);
                labelReal.ForeColor = Color.BlueViolet;
                num++;
            }
            else if (num == 2)
            {
                labelReal.Location = new Point(60, 180);
                labelReal.ForeColor = Color.DarkGreen;
                num = 0;
            }

            else if (num == 0)
            {
                labelDeal.Location = new Point(60, 180);
                labelDeal.ForeColor = Color.DarkOrange;
                num++;
            }
            else if (num == 1)
            {
                labelDeal.Location = new Point(40, 180);
                labelDeal.ForeColor = Color.DarkSeaGreen;
                num++;
            }
            else if (num == 2)
            {
                labelDeal.Location = new Point(20, 180);
                labelDeal.ForeColor = Color.DodgerBlue;
                num = 0;
            }
               
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UHola_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
