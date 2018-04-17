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
    public partial class ChangePassword : Form
    {
        public int k;
        public ChangePassword(string str_value,int a)
        {
            InitializeComponent();

            label1.Text = str_value;

            k = a;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Textbox1.Text == "")
            {
                MessageBox.Show("Please Insert New Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
         

                SqlConnection con = new SqlConnection(Program.loc);

                con.Open();

                string query = "insert into emp_pass(name,password) values('" + label1.Text + "','" + Textbox1.Text + "');";


                SqlCommand cmd = new SqlCommand(query, con);


                cmd.ExecuteNonQuery();


                MessageBox.Show("Sucessfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                delete();

                this.Hide();

                login l = new login();
                    l.ShowDialog();
                this.Close();
            }

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

    void delete()
        {


            SqlConnection con = new SqlConnection(Program.loc);

            con.Open();

            string query = "delete from employeeinfo where e_code='" + k + "';";


            SqlCommand cmd = new SqlCommand(query, con);


            cmd.ExecuteNonQuery();

        }
  


    }
}
