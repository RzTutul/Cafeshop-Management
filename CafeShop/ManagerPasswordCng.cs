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
    public partial class ManagerPasswordCng : Form
    {
        public ManagerPasswordCng()
        {
            InitializeComponent();
        }

        private void backbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerControler mc = new ManagerControler();

            mc.ShowDialog();

            this.Close();
        }


        private void saveButton_Click_1(object sender, EventArgs e)
        {

            string loc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\visualstudio\CafeShop\CafeShop\Database1.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(loc);

            con.Open();

            string query = "select * from manager where pass='"+Textbox1.Text+"';";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            int count = 0;
            while(reader.Read())
            {
                count++;
            }

            if (count == 1)
            {
                if (Textbox1.Text == "" || Textbox2.Text == "")
                {
                    MessageBox.Show("FILL THE BOX", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    string loc1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\visualstudio\CafeShop\CafeShop\Database1.mdf;Integrated Security=True";

                    SqlConnection con1 = new SqlConnection(loc1);

                    con1.Open();

                    string query1 = "update manager set pass='" + Textbox2.Text + "' where pass='" + Textbox1.Text + "';";

                    SqlCommand cmd1 = new SqlCommand(query1, con1);

                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Saved");

                    this.Hide();
                    ManagerControler mc = new ManagerControler();
                    mc.ShowDialog();
                    this.Close();


                }
            }

            else
            {
                MessageBox.Show("Old Password is Wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

           
        }

        private void Textbox1_Enter(object sender, EventArgs e)
        {
            if (Textbox1.Text == "Old Password")
            {
                Textbox1.Text = "";
            }
        }

        private void Textbox1_Leave(object sender, EventArgs e)
        {
            if (Textbox1.Text == "")
            {
                Textbox1.Text = "Old Password";
            }
        }

        private void Textbox2_Enter(object sender, EventArgs e)
        {
            if (Textbox2.Text == "New Password")
            {
                Textbox2.Text = "";
            }
        }

        private void Textbox2_Leave(object sender, EventArgs e)
        {
            if (Textbox2.Text == "")
            {
                Textbox2.Text = "New Password";
            }
        }

    }
}
