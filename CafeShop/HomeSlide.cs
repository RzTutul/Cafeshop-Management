using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop
{
    public partial class HomeSlide : UserControl
    {
        public HomeSlide()
        {
            InitializeComponent();
            timer1.Start();
          
        }

        public int imgnumber = 1;

        public void loadImg()
        {
            if(imgnumber ==6)
            {
                imgnumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"image\{0}.jpg", imgnumber);

            imgnumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadImg();


        }

       
    }
}
