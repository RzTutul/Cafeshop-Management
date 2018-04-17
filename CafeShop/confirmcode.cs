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
    public partial class confirmcode : Form
    {
        public confirmcode()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {

            if (textbox1.Text == "ENTER CODE")
            {
                textbox1.Text = "";
            }

        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (textbox1.Text == "")
            {
                textbox1.Text = "ENTER CODE";
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "ENTER CODE" || textbox1.Text=="")
            {
                MessageBox.Show("Enter the Code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    

                    SqlConnection con = new SqlConnection(Program.loc);

                    con.Open();

                    string query = "select * from employeeinfo where e_code='" + textbox1.Text + "';";



                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader reader;

                    reader = cmd.ExecuteReader();
                    int k = 0;
                    k = Convert.ToInt32(textbox1.Text);
                    int count = 0;
                    string s_name = "";
                    while (reader.Read())
                    {
                        count++;
                        s_name = reader["name"].ToString();



                    }

                    if (count == 1)
                    {
                        this.Hide();

                        ChangePassword cp = new ChangePassword(s_name, k);

                        cp.ShowDialog();

                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Wrong code");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            login l = new login();

            l.ShowDialog();

            this.Close();
        }
    }
}
