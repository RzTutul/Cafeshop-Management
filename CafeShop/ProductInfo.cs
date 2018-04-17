using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CafeShop
{
    public partial class ProductInfo : Form
    {
        public int inc = 0, takacolector=0,quantity, pri = 0;
       public string namel = "Name", Quantityl = "    Quantity", pricel = "Price",labtotal="Total";
   
        public ProductInfo(string s_value)
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();

            homeSlide1.BringToFront();
            panel1.Visible = false;
            toolStrip1.Visible = false;
            MessageboxPanel.Visible = false;
            namelabel.Text = s_value;
            managermsg();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            this.timelabel1.Text = dt.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();

            richTextBox1.AppendText("          INFINITY CAFE SHOP" + Environment.NewLine + Environment.NewLine);

            richTextBox1.AppendText(".........................................................................." + Environment.NewLine);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files(*.text)|*.text|All files(*.*)|*.*";


            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))

                    sw.WriteLine(richTextBox1.Text);
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void toolStripSeparator_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            int one = r.Next(0, 255);
            int two = r.Next(0, 255);
            int three = r.Next(0, 255);
            int four = r.Next(0, 255);

            logo.ForeColor = Color.FromArgb(one, two, three, four);

      /*      

            if (logo.Left < 800)
            {
                logo.Left = logo.Left + 1;

            }
            else
            {
                logo.Left = -logo.Width;
            }
            */

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
              e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black,new PointF  (0, 0));
           
        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            richTextBox1.AppendText("          INFINTY CAFE SHOP" + Environment.NewLine + Environment.NewLine);

            richTextBox1.AppendText(".........................................................................." + Environment.NewLine);
            richTextBox1.AppendText(namel + "\t\t\t" + Quantityl + "\t" + pricel+ Environment.NewLine);
        }

        private void homebutton1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = homebutton1.Height;
            SidePanel.Top = homebutton1.Top;
            homeSlide1.BringToFront();
            panel1.Visible = false;
            toolStrip1.Visible =false;
        }

        private void eatbutton2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = eatbutton2.Height;
            SidePanel.Top = eatbutton2.Top;

            tabControl1.BringToFront();
            panel1.Visible = true;
            toolStrip1.Visible = true;


        }
      
        private void incrementButton_Click(object sender, EventArgs e)
        {
            try
            {

                showtotal.Text = (Convert.ToInt32(showtotal.Text) + 1).ToString();
                pricelabel1.Text = (Convert.ToInt32(pricelabel1.Text) + 40).ToString();
                inc= (Convert.ToInt32(showtotal.Text) + 0);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void decrementButton_Click(object sender, EventArgs e)
        {
            if (inc>1)
            {
               
                showtotal.Text = (Convert.ToInt32(showtotal.Text) - 1).ToString();
                pricelabel1.Text = (Convert.ToInt32(pricelabel1.Text) - 40).ToString();
                inc--;
            }
         
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void newIteambutton3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = newIteambutton3.Height;
            SidePanel.Top = newIteambutton3.Top;
            alliteam1.BringToFront();
        }

        private void massagebutton7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = massagebutton7.Height;
            SidePanel.Top = massagebutton7.Top;
            MessageboxPanel.Visible = true;
        }

        private void button89_Click(object sender, EventArgs e)
        {
            MessageboxPanel.Visible = false;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            messageBox.Clear();

            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "delete  from managerbox";



            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

        }

        private void otherSell_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please Fill the Box", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    richTextBox1.AppendText(textBox1.Text + "\t\t\t" + textBox2.Text + '\t' + textBox3.Text + Environment.NewLine);


                    takacolector = takacolector + Convert.ToInt32(textBox3.Text);
                    totaltaka.Text = Convert.ToString(takacolector);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
               
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int incc = 0;
        private void button5_Click(object sender, EventArgs e)
        {
          
            label5.Text =(Convert.ToInt32(label5.Text)+50).ToString();
            label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();

            incc = (Convert.ToInt32(label2.Text) + 0);
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (incc > 1 )
            {

                label5.Text = (Convert.ToInt32(label5.Text) - 50).ToString();
                label2.Text = (Convert.ToInt32(label2.Text) - 1).ToString();
                incc--;
            }
        }

        int i3 = 0;
        private void button10_Click(object sender, EventArgs e)
        {
           
           
            label10.Text = (Convert.ToInt32(label10.Text) + 60).ToString();
            label7.Text = (Convert.ToInt32(label7.Text) + 1).ToString();
            i3++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (i3 > 1)
            {

                label10.Text = (Convert.ToInt32(label10.Text) - 60).ToString();
                label7.Text = (Convert.ToInt32(label7.Text) - 1).ToString();
                i3--;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(label9.Text + "\t\t" + label7.Text + '\t' + label10.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label10.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label7.Text = "1";
            label10.Text = "60";
            i3 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label9.Text + "','" + label7.Text + "','" + label10.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

        }
        int i4=0;
        private void button13_Click(object sender, EventArgs e)
        {

        
            label15.Text = (Convert.ToInt32(label15.Text)+40).ToString();
            label12.Text = (Convert.ToInt32(label12.Text)+1).ToString();

            i4++;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (i4>=1)
            {
                label15.Text =( Convert.ToInt32(label15.Text) - 40).ToString();
                label12.Text = (Convert.ToInt32(label12.Text) - 1).ToString();
                i4--;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(label14.Text + "\t\t\t" + label12.Text + '\t' + label15.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label15.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label12.Text = "1";
            label15.Text = "40";
            i4 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label14.Text + "','" + label12.Text + "','" + label15.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        int i5 = 0;
        private void button16_Click(object sender, EventArgs e)
        {



            label22.Text = (Convert.ToInt32(label22.Text) + 80).ToString();
            label18.Text = (Convert.ToInt32(label18.Text) + 1).ToString();

            i5++;

         
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (i5 >= 1 )
            {
                label22.Text = (Convert.ToInt32(label22.Text) - 80).ToString();
                label18.Text = (Convert.ToInt32(label18.Text) - 1).ToString();
                i5--;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(label21.Text + "\t\t" + label18.Text + '\t' + label22.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label22.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label18.Text = "1";
            label22.Text = "80";
            i5 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label21.Text + "','" + label18.Text + "','" + label22.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(label26.Text + "\t\t\t" + label24.Text + '\t' + label27.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label27.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label24.Text = "1";
            label27.Text = "50";

            i6 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label26.Text + "','" + label24.Text + "','" + label27.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

        }
        int i6=0;
        private void button19_Click(object sender, EventArgs e)
        {

        
         


            label27.Text = (Convert.ToInt32(label27.Text) + 50).ToString();
            label24.Text = (Convert.ToInt32(label24.Text) + 1).ToString();

            i6++;

        }

        private void button20_Click(object sender, EventArgs e)
        {

            if (i6 >= 1)
            {
                label27.Text = (Convert.ToInt32(label27.Text) - 50).ToString();
                label24.Text = (Convert.ToInt32(label24.Text) - 1).ToString();

                i6--;
            }
        }
        int i7=0;
        private void button22_Click(object sender, EventArgs e)
        {
      

            label32.Text = (Convert.ToInt32(label32.Text) + 60).ToString();
            label29.Text = (Convert.ToInt32(label29.Text) + 1).ToString();

            i7++;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (i7 >= 1)
            {
                label32.Text = (Convert.ToInt32(label32.Text) - 60).ToString();
                label29.Text = (Convert.ToInt32(label29.Text) - 1).ToString();

                i7--;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(label31.Text + "\t\t\t" + label29.Text + '\t' + label32.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label32.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label29.Text = "1";
            label32.Text = "60";
            i7 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label31.Text + "','" + label29.Text + "','" + label32.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        private void button27_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(label36.Text + "\t\t\t" + label34.Text + '\t' + label37.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label37.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label34.Text = "1";
            label37.Text = "75";
         
          i8=0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label36.Text + "','" + label34.Text + "','" + label37.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        int i8 = 0;
        private void button25_Click(object sender, EventArgs e)
        {
   
         

            label37.Text = (Convert.ToInt32(label37.Text) + 75).ToString();
            label34.Text = (Convert.ToInt32(label34.Text) + 1).ToString();

            i8++;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (i8 >= 1)
            {
                label37.Text = (Convert.ToInt32(label37.Text) - 75).ToString();
                label34.Text = (Convert.ToInt32(label34.Text) - 1).ToString();

                i8--;
            }
        }
        int i9 = 0;

        private void button52_Click(object sender, EventArgs e)
        {
          
            label82.Text = (Convert.ToInt32(label82.Text) + 300).ToString();
            label79.Text = (Convert.ToInt32(label79.Text) + 1).ToString();

            i9++;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (i9 >= 1)
            {
                label82.Text = (Convert.ToInt32(label82.Text) - 300).ToString();
                label79.Text = (Convert.ToInt32(label79.Text) - 1).ToString();

                i9--;
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(label81.Text + "\t\t\t" + label79.Text + '\t' + label82.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label82.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label79.Text = "1";
            label82.Text = "300";
            i9= 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label81.Text + "','" + label79.Text + "','" + label82.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(label106.Text + "\t\t\t\t" + label104.Text + '\t' + label107.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label107.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label104.Text = "1";
            label107.Text = "250";
            i10 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label106.Text + "','" + label104.Text + "','" + label107.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }
        int i10=0;

        private void button67_Click(object sender, EventArgs e)
        {
         


            label107.Text = (Convert.ToInt32(label107.Text) + 250).ToString();
            label104.Text = (Convert.ToInt32(label104.Text) + 1).ToString();

            i10++;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (i10 >= 1 )
            {

                label107.Text = (Convert.ToInt32(label107.Text) - 250).ToString();
                label104.Text = (Convert.ToInt32(label104.Text) - 1).ToString();

                i10--;
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(label91.Text + "\t\t\t" + label89.Text + '\t' + label92.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label92.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label89.Text = "1";
            label92.Text = "400";
            i11 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label91.Text + "','" + label89.Text + "','" + label92.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

        }
        int i11=0;
        private void button58_Click(object sender, EventArgs e)
        {
     

            label92.Text = (Convert.ToInt32(label92.Text) + 400).ToString();
            label89.Text = (Convert.ToInt32(label89.Text) + 1).ToString();

            i11++;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (i11 >= 1)
            {
                label92.Text = (Convert.ToInt32(label92.Text) - 400).ToString();
                label89.Text = (Convert.ToInt32(label89.Text) - 1).ToString();

                i11--;
            }
        
        }

        private void button63_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(label96.Text + "\t\t" + label94.Text + '\t' + label97.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label97.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label94.Text = "1";
            label97.Text = "1050";
            i12 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label96.Text + "','" + label94.Text + "','" + label97.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }
        int i12 = 0;
        private void button61_Click(object sender, EventArgs e)
        {
      

            label97.Text = (Convert.ToInt32(label97.Text) + 1050).ToString();
            label94.Text = (Convert.ToInt32(label94.Text) + 1).ToString();

            i12++;
        }

        private void button62_Click(object sender, EventArgs e)
        {

            if (i12 >= 1)
            {
                label97.Text = (Convert.ToInt32(label97.Text) - 1050).ToString();
                label94.Text = (Convert.ToInt32(label94.Text) - 1).ToString();

                i12--;
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(label101.Text + "\t\t\t" + label99.Text + '\t' + label102.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label102.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label99.Text = "1";
            label102.Text = "700";
            i13 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label101.Text + "','" + label99.Text + "','" + label102.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        int i13 = 0;
        private void button64_Click(object sender, EventArgs e)
        {
          


            label102.Text = (Convert.ToInt32(label102.Text) + 700).ToString();
            label99.Text = (Convert.ToInt32(label99.Text) + 1).ToString();

            i13++;
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (i13 >=1)
            {
                label102.Text = (Convert.ToInt32(label102.Text) - 700).ToString();
                label99.Text = (Convert.ToInt32(label99.Text) - 1).ToString();

                i13--;
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(label86.Text + "\t\t\t" + label84.Text + '\t' + label87.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label87.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label84.Text = "1";
            label87.Text = "450";
            i14 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label86.Text + "','" + label84.Text + "','" + label87.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }
        int i14 = 0;
        private void button55_Click(object sender, EventArgs e)
        {
            

            label87.Text = (Convert.ToInt32(label87.Text) + 450).ToString();
            label84.Text = (Convert.ToInt32(label84.Text) + 1).ToString();

            i14++;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (i14 >= 1 )
            {
                label87.Text = (Convert.ToInt32(label87.Text) - 450).ToString();
                label84.Text = (Convert.ToInt32(label84.Text) - 1).ToString();

                i14--;
            }
        }

        private void button72_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(label111.Text + "\t\t\t" + label109.Text + '\t' + label112.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label112.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label109.Text = "1";
            label112.Text = "375";
            i15 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label111.Text + "','" + label109.Text + "','" + label112.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }
        int i15 = 0;
        private void button70_Click(object sender, EventArgs e)
        {

        


            label112.Text = (Convert.ToInt32(label112.Text) + 375).ToString();
            label109.Text = (Convert.ToInt32(label109.Text) + 1).ToString();

            i15++;
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (i15 >= 1 )
            {
                label112.Text = (Convert.ToInt32(label112.Text) - 375).ToString();
                label109.Text = (Convert.ToInt32(label109.Text) - 1).ToString();

                i15--;
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(label116.Text + "\t\t\t\t" + label114.Text + '\t' + label117.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label117.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label114.Text = "1";
            label117.Text = "300";
            i16 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label116.Text + "','" + label114.Text + "','" + label117.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        int i16=0;
        private void button73_Click(object sender, EventArgs e)
        {

         

            label117.Text = (Convert.ToInt32(label117.Text) + 300).ToString();
            label114.Text = (Convert.ToInt32(label114.Text) + 1).ToString();

            i16++;
        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (i16 >= 1)
            {
                label117.Text = (Convert.ToInt32(label117.Text) - 300).ToString();
                label114.Text = (Convert.ToInt32(label114.Text) -1).ToString();

                i16--;
            }
        }

        int i17 = 0;
        private void button28_Click(object sender, EventArgs e)
        {

            label42.Text = (Convert.ToInt32(label42.Text) + 20).ToString();
            label39.Text = (Convert.ToInt32(label39.Text) + 1).ToString();

            i17++;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (i17 >= 1)
            {

                label42.Text = (Convert.ToInt32(label42.Text) - 20).ToString();
                label39.Text = (Convert.ToInt32(label39.Text) - 1).ToString();

                i17--;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(label41.Text + "\t\t\t" + label39.Text + '\t' + label42.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label42.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label39.Text = "1";
            label42.Text = "20";
            i17 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label41.Text + "','" + label39.Text + "','" + label42.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }
        int i18 = 0;
        private void button31_Click(object sender, EventArgs e)
        {

            label47.Text = (Convert.ToInt32(label47.Text) + 35).ToString();
            label44.Text = (Convert.ToInt32(label44.Text) + 1).ToString();

            i18++;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (i18 >= 1)
            {

                label47.Text = (Convert.ToInt32(label47.Text) - 35).ToString();
                label44.Text = (Convert.ToInt32(label44.Text) - 1).ToString();

                i18--;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(label46.Text + "\t\t\t\t" + label44.Text + '\t' + label47.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label47.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label44.Text = "1";
            label47.Text = "35";
            i18 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label46.Text + "','" + label44.Text + "','" + label47.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }
        int i19 = 0;
        private void button34_Click(object sender, EventArgs e)
        {
            label52.Text = (Convert.ToInt32(label52.Text) + 35).ToString();
            label49.Text = (Convert.ToInt32(label49.Text) + 1).ToString();

            i19++;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(label51.Text + "\t\t\t\t" + label49.Text + '\t' + label52.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label52.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label49.Text = "1";
            label52.Text = "35";
            i19 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label51.Text + "','" + label49.Text + "','" + label52.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (i19 >= 1)
            {

                label52.Text = (Convert.ToInt32(label52.Text) - 35).ToString();
                label49.Text = (Convert.ToInt32(label49.Text) - 1).ToString();

                i19--;
            }
        }
        int i20 = 0;
        private void button37_Click(object sender, EventArgs e)
        {
            label57.Text = (Convert.ToInt32(label57.Text) + 65).ToString();
            label54.Text = (Convert.ToInt32(label54.Text) + 1).ToString();

            i20++;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (i20 >= 1)
            {

                label57.Text = (Convert.ToInt32(label57.Text) - 65).ToString();
                label54.Text = (Convert.ToInt32(label54.Text) - 1).ToString();

                i20--;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(label56.Text + "\t\t\t\t" + label54.Text + '\t' + label57.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label57.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label54.Text = "1";
            label57.Text = "65";
            i20 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label56.Text + "','" + label54.Text + "','" + label57.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }
        int i21 = 0;
        private void button40_Click(object sender, EventArgs e)
        {

            label62.Text = (Convert.ToInt32(label62.Text) + 65).ToString();
            label59.Text = (Convert.ToInt32(label59.Text) + 1).ToString();

            i21++;
        }

        private void button41_Click(object sender, EventArgs e)
        {

            if (i21 >= 1)
            {

                label62.Text = (Convert.ToInt32(label62.Text) - 65).ToString();
                label59.Text = (Convert.ToInt32(label59.Text) - 1).ToString();

                i21--;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(label61.Text + "\t\t\t" + label59.Text + '\t' + label62.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label62.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label59.Text = "1";
            label62.Text = "65";
            i21 = 0;

            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label61.Text + "','" + label59.Text + "','" + label62.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        int i22 = 0;
        private void button43_Click(object sender, EventArgs e)
        {
            label67.Text = (Convert.ToInt32(label67.Text) + 30).ToString();
            label64.Text = (Convert.ToInt32(label64.Text) + 1).ToString();

            i22++;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (i22 >= 1)
            {

                label67.Text = (Convert.ToInt32(label67.Text) - 30).ToString();
                label64.Text = (Convert.ToInt32(label64.Text) - 1).ToString();

                i22--;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(label66.Text + "\t\t\t\t" + label64.Text + '\t' + label67.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label67.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label64.Text = "1";
            label67.Text = "30";
            i22 = 0;


            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label66.Text + "','" + label64.Text + "','" + label67.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }
        int i23 = 0;
        private void button46_Click(object sender, EventArgs e)
        {
            label72.Text = (Convert.ToInt32(label72.Text) + 100).ToString();
            label69.Text = (Convert.ToInt32(label69.Text) + 1).ToString();

            i23++;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (i23 >= 1)
            {

                label72.Text = (Convert.ToInt32(label72.Text) - 100).ToString();
                label69.Text = (Convert.ToInt32(label69.Text) - 1).ToString();

                i23--;
            }
        }
        int i24 = 0;
        private void button49_Click(object sender, EventArgs e)
        {
            label77.Text = (Convert.ToInt32(label77.Text) + 120).ToString();
            label74.Text = (Convert.ToInt32(label74.Text) + 1).ToString();

            i24++;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (i24 >= 1)
            {

                label77.Text = (Convert.ToInt32(label77.Text) - 120).ToString();
                label74.Text = (Convert.ToInt32(label74.Text) - 1).ToString();

                i24--;
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(label76.Text + "\t\t\t" + label74.Text + '\t' + label77.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label77.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label74.Text = "1";
            label77.Text = "120";
            i24 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label76.Text + "','" + label74.Text + "','" + label77.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        private void button48_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(label71.Text + "\t\t\t\t" + label69.Text + '\t' + label72.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label72.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label69.Text = "1";
            label72.Text = "100";
            i23 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label71.Text + "','" + label69.Text + "','" + label72.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }
        int i25 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            label122.Text = (Convert.ToInt32(label122.Text) + 80).ToString();
            label119.Text = (Convert.ToInt32(label119.Text) + 1).ToString();

            i25++;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (i25 >= 1)
            {

                label122.Text = (Convert.ToInt32(label122.Text) - 80).ToString();
                label119.Text = (Convert.ToInt32(label119.Text) - 1).ToString();

                i25--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(label121.Text + "\t\t\t\t" + label119.Text + '\t' + label122.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label122.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label119.Text = "1";
            label122.Text = "80";
            i25 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label121.Text + "','" + label119.Text + "','" + label122.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        int i26 = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            label127.Text = (Convert.ToInt32(label127.Text) + 60).ToString();
            label124.Text = (Convert.ToInt32(label124.Text) + 1).ToString();

            i26++;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (i26 >= 1)
            {


                label127.Text = (Convert.ToInt32(label127.Text) - 60).ToString();
                label124.Text = (Convert.ToInt32(label124.Text) - 1).ToString();

                i26--;
            }
        }

        private void button76_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(label126.Text + "\t\t\t" + label124.Text + '\t' + label127.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label127.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label124.Text = "1";
            label127.Text = "60";
            i26 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label126.Text + "','" + label124.Text + "','" + label127.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }
        int i27 = 0;
        private void button77_Click(object sender, EventArgs e)
        {

            label132.Text = (Convert.ToInt32(label132.Text) + 70).ToString();
            label129.Text = (Convert.ToInt32(label129.Text) + 1).ToString();

            i27++;
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (i27 >= 1)
            {

                label132.Text = (Convert.ToInt32(label132.Text) - 70).ToString();
                label129.Text = (Convert.ToInt32(label129.Text) - 1).ToString();

                i27--;
            }
        }

        private void button79_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(label131.Text + "\t\t\t\t" + label129.Text + '\t' + label132.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label127.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label129.Text = "1";
            label132.Text = "70";
            i27 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label131.Text + "','" + label129.Text + "','" + label132.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }
        int i28 = 0;
        private void button80_Click(object sender, EventArgs e)
        {
            label137.Text = (Convert.ToInt32(label137.Text) + 50).ToString();
            label134.Text = (Convert.ToInt32(label134.Text) + 1).ToString();

            i28++;
        }

        private void button81_Click(object sender, EventArgs e)
        {
            if (i28 >= 1)
            {
                label137.Text = (Convert.ToInt32(label137.Text) - 50).ToString();
                label134.Text = (Convert.ToInt32(label134.Text) - 1).ToString();

                i28--;
            }
        }
        int i29 = 0;
        private void button83_Click(object sender, EventArgs e)
        {
            label142.Text = (Convert.ToInt32(label142.Text) + 100).ToString();
            label139.Text = (Convert.ToInt32(label139.Text) + 1).ToString();

            i29++;
        }

        private void button84_Click(object sender, EventArgs e)
        {
            if (i29 >= 1)
            {
                label142.Text = (Convert.ToInt32(label142.Text) - 100).ToString();
                label139.Text = (Convert.ToInt32(label139.Text) - 1).ToString();

                i29--;
            }
        }

        private void button82_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(label136.Text + "\t\t\t\t" + label134.Text + '\t' + label137.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label137.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label134.Text = "1";
            label137.Text = "50";
            i28 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label136.Text + "','" + label134.Text + "','" + label137.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        private void button85_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(label141.Text + "\t\t\t" + label139.Text + '\t' + label142.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label142.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label139.Text = "1";
            label142.Text = "100";
            i29 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label141.Text + "','" + label139.Text + "','" + label142.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }
        int i30=0;
        private void button86_Click(object sender, EventArgs e)
        {
            label147.Text = (Convert.ToInt32(label147.Text) + 120).ToString();
            label144.Text = (Convert.ToInt32(label144.Text) + 1).ToString();

            i30++;
        }

        private void button87_Click(object sender, EventArgs e)
        {

            if (i30 >= 1)
            {
                label147.Text = (Convert.ToInt32(label147.Text) - 120).ToString();
                label144.Text = (Convert.ToInt32(label144.Text) - 1).ToString();

                i30--;
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(label146.Text + "\t\t\t" + label144.Text + '\t' + label147.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label147.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label144.Text = "1";
            label147.Text = "120";
            i30 = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label146.Text + "','" + label144.Text + "','" + label147.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ProductInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
         //   logout();
            login l = new login();
            l.ShowDialog();
            
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.loc);

                con.Open();

                string query = "insert into messagebox(name,msg) values('" + namelabel.Text + "', '" + messageBox.Text + "');";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Send Massage", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText( label4.Text+ "\t\t\t" + label2.Text + '\t' + label5.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(label5.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            label2.Text = "1";
            label5.Text = "50";
            incc = 0;
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + label4.Text + "','" + label2.Text + "','" + label5.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            richTextBox1.AppendText("          INFINTY CAFE SHOP" + Environment.NewLine + Environment.NewLine);

            richTextBox1.AppendText(".........................................................................." + Environment.NewLine);
            richTextBox1.AppendText("Name" + "\t\t\t" + "     Quantity" + "\t" + "Price" + Environment.NewLine);
        }

        private void totalbutton_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("............................................................................................." + Environment.NewLine);

            richTextBox1.AppendText("Total Price " + "\t\t\t" + quantity + "\t" + takacolector + Environment.NewLine + Environment.NewLine + Environment.NewLine);
        }

        private void receiptbutton_Click(object sender, EventArgs e)
        {

            
           
            richTextBox1.AppendText(Environment.NewLine + Environment.NewLine + Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine + Environment.NewLine + Environment.NewLine);

            richTextBox1.AppendText("\t\t" + "<<<THANK YOU>>>");
            richTextBox1.AppendText(Environment.NewLine + Environment.NewLine + Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine + Environment.NewLine + Environment.NewLine);

            richTextBox1.AppendText(timelabel1.Text);


        }

        private void buybutton4_Click(object sender, EventArgs e)
        {

            richTextBox1.AppendText(burgarlabel.Text + "\t\t" + showtotal.Text + '\t' + pricelabel1.Text + Environment.NewLine);


            takacolector = takacolector + Convert.ToInt32(pricelabel1.Text);
            totaltaka.Text = Convert.ToString(takacolector);
            showtotal.Text = "1";
            pricelabel1.Text = "40";
            inc = 0;

            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into sell(pro_name,pro_quantity,pro_price) values('" + burgarlabel.Text + "','" + showtotal.Text + "','" + pricelabel1.Text + "');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        void logout()
        {
            try
            {
                SqlConnection con3 = new SqlConnection(Program.loc);

                con3.Open();

                string query3 = "insert into loghistory(name,loginTime,status) values('" + namelabel.Text + "' ,'" + timelabel1.Text + "','Logout');";


                SqlCommand cmd3 = new SqlCommand(query3, con3);

                cmd3.ExecuteNonQuery();

                login l = new login();
                l.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void managermsg()
        {

            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "select * from managerbox";



            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            string s = "";
            while(reader.Read())
            {
                s = reader["msg"].ToString();
            }

            messageBox.Text = s;



        }
    }
}
