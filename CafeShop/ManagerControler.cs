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
    public partial class ManagerControler : Form
    {
        public ManagerControler()
        {
            InitializeComponent();


            messageread();
        }

        private void empbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeInfo e1 = new EmployeeInfo();
            e1.ShowDialog();

            this.Close();
        }

        private void empinfobutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllEmployee e2 = new AllEmployee();
            e2.ShowDialog();
            this.Close();
        }

        private void probutton_Click(object sender, EventArgs e)
        {
           

            SqlConnection con1 = new SqlConnection(Program.loc);

            con1.Open();

            string query1 = "select * from manager";


            SqlCommand cmd1 = new SqlCommand(query1, con1);

            SqlDataReader reader1;

            reader1 = cmd1.ExecuteReader();

            string s_name = "";

            while (reader1.Read())
            {
               

                s_name = reader1["name"].ToString();
            }
           

                this.Hide();
            ProductInfo p = new ProductInfo(s_name);
            p.ShowDialog();
            
                this.Close();


            }
        

        private void sellbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TotalSell s = new TotalSell();

            s.ShowDialog();

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerPasswordCng mpc = new ManagerPasswordCng();
            mpc.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
                if(label1.Visible ==false )
                 {
                     label4.Visible = true;
                     label1.Visible = true;
                 }
               else  if (label1.Visible == true)
                 {
                     label4.Visible = false;
                     label1.Visible = false;
                 }

        }

        private void ManagerControler_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label1.Visible = false;
        }

        private void ManagerControler_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            login l = new login();
            l.ShowDialog();
            this.Close();
        }

        private void ManagerControler_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want exit?", "EXIT", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
               
            }
            else
            {
                Dispose(true);
                this.Hide();
                login l = new login();

                l.ShowDialog();
              

            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "insert into managerbox(msg) values('"+richTextBox1.Text+"');";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Message Send!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        void messageread()
        {
        
                SqlConnection con = new SqlConnection(Program.loc);

                con.Open();

                string query = "select * from messagebox";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                string name = "";
            string msg = "";
                while (reader.Read())
                {
                    name = reader["name"].ToString();

                msg = reader["msg"].ToString();
                }
                label5.Text = name;
            richTextBox1.Text = msg;

                con.Close();
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "delete from messagebox";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

      
    }
}
