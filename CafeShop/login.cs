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
    public partial class login : Form
    {
   
        public login()
        {
            InitializeComponent();
           
            banutexbox2.isPassword = true;
            StartPosition = FormStartPosition.CenterScreen;

            timer1.Start();

            timer2.Start();
        }
        
        
        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
           

            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "Select * from manager where name='" + bnutextbox1.Text + "' and pass='" + banutexbox2.Text + "';";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader;

            reader = cmd.ExecuteReader() ;

          

            int count = 0;

            while (reader.Read())
            {
                count++;

            }
            if (count == 1)
            {
                try
                {
                    this.Hide();

                    ManagerControler mc = new ManagerControler();

                    mc.ShowDialog();

                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
               
                SqlConnection con1 = new SqlConnection(Program.loc);

                con1.Open();

                string query1 = "select * from emp_pass where name='" + bnutextbox1.Text + "' and password='" + banutexbox2.Text + "' ; ";


                SqlCommand cmd1 = new SqlCommand(query1, con1);

                SqlDataReader reader1;

                reader1 = cmd1.ExecuteReader();

                int count1 = 0;
                string s_name = "";

                while (reader1.Read())
                {
                    count1++;

                    s_name = reader1["name"].ToString();
                }
                if (count1 == 1)
                {
               //   loginhistory();

                    this.Hide();
                  

               ProductInfo f1 = new ProductInfo(s_name);

                   f1.ShowDialog();

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            
        }





        }


        private void bnutextbox1_Enter(object sender, EventArgs e)
        {
            if(bnutextbox1.Text=="User Name")
            {
                bnutextbox1.Text = "";
            }
        }


            

    

        private void banutexbox2_Enter(object sender, EventArgs e)
        {
            if(banutexbox2.Text=="Password")
            {
                banutexbox2.Text = "";
            }
        }

        private void bnutextbox1_Leave(object sender, EventArgs e)
        {
            if (bnutextbox1.Text == "")
            {
                bnutextbox1.Text = "User Name";
            }
        }



        private void banutexbox2_Leave_1(object sender, EventArgs e)
        {
            if (banutexbox2.Text == "")
            {
                banutexbox2.Text = "Password";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            confirmcode cp = new confirmcode();

            cp.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            this.Timelabel3.Text = dt.ToString();

            Random r = new Random();

            int one = r.Next(0, 255);
            int two = r.Next(0, 255);
            int three  = r.Next(0, 255);
            int four  = r.Next(0, 255);

            welcomelabel.ForeColor = Color.FromArgb(one, two, three, four);


            Random r1 = new Random();

            int one1 = r1.Next(0, 255);
            int two1 = r1.Next(0, 255);
            int three1 = r1.Next(0, 255);
            int four1 = r1.Next(0, 255);

            label2.ForeColor = Color.FromArgb(four1,three1,two1,one1);


        }

        void loginhistory()
        {
            try
            {


                SqlConnection con3 = new SqlConnection(Program.loc);

                con3.Open();

                string query3 = "insert into loghistory(name,loginTime,status) values('"+ bnutextbox1.Text+ "' ,'" + Timelabel3.Text + "','Login');";


                SqlCommand cmd3 = new SqlCommand(query3, con3);

                cmd3.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (welcomelabel.Left < 600)
            {
                welcomelabel.Left = welcomelabel.Left + 1;

            }
            else
            {
                welcomelabel.Left = -welcomelabel.Width;
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
