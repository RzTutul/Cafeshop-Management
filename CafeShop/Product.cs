using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            SidePanel.Height = homebutton.Height;

            SidePanel.Top = homebutton.Top;
            allFood1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            controlform f2 = new controlform();

            f2.ShowDialog();

            this.Close();
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = homebutton.Height;

            SidePanel.Top = homebutton.Top;
            allFood1.BringToFront();
        }

        private void eatbutton_Click(object sender, EventArgs e)
        {

            SidePanel.Height = eatbutton.Height;

            SidePanel.Top = eatbutton.Top;
            alliteam1.BringToFront();
        }
    }
}
