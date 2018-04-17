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
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            loaddata();
        }

    

 

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
               

                SqlConnection con = new SqlConnection(Program.loc);

                con.Open();

                string query = "insert into employeeinfo(id,name,e_date,e_time,e_code) values('" + Textbox1.Text + "','" + Textbox2.Text + "','" + Textbox3.Text + "','" + Textbox4.Text + "','"+Textbox5.Text+"')";

                SqlCommand cmd = new SqlCommand(query, con);



                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved", "Messagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Textbox1.Text = "";
                Textbox2.Text = "";
                Textbox3.Text = "";
                Textbox4.Text = "";
                Textbox5.Text = "";
                loaddata();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       void loaddata()
        {

            SqlConnection con1 = new SqlConnection(Program.loc);

            con1.Open();

            string query1 = "Select id as ID,name as Name,e_date as Join_Date,e_time as Duity_Time,e_code as Login_Code,e_no as No from employeeinfo ;";

            SqlCommand cmd1 = new SqlCommand(query1, con1);

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd1);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con1.Close();
        }

        private void Textbox1_Enter_1(object sender, EventArgs e)
        {
            if (Textbox1.Text == "ID")
            {
                Textbox1.Text = "";
            }
        }

        private void Textbox1_Leave(object sender, EventArgs e)
        {

            if (Textbox1.Text == "")
            {
                Textbox1.Text = "ID";
            }
        }

        private void Textbox2_Enter(object sender, EventArgs e)
        {
            if (Textbox2.Text == "Name")
            {
                Textbox2.Text = "";
            }
        }

        private void Textbox2_Leave(object sender, EventArgs e)
        {
            if (Textbox2.Text == "")
            {
                Textbox2.Text = "Name";
            }
        }

        private void Textbox3_Enter(object sender, EventArgs e)
        {
            if (Textbox3.Text == "Join Date   ex. dd-mm-yyyy")
            {
                Textbox3.Text = "";
            }
        }

        private void Textbox3_Leave(object sender, EventArgs e)
        {
            if (Textbox3.Text == "")
            {
                 Textbox3.Text = "Join Date   ex. dd-mm-yyyy";
            }
        }

        private void Textbox4_Enter(object sender, EventArgs e)
        {
            if (Textbox4.Text == "Duty Time        ex. Day/Night")
            {
                Textbox4.Text = "";
            }
        }

        private void Textbox4_Leave(object sender, EventArgs e)
        {
            if (Textbox4.Text =="" )
            {
                Textbox4.Text = "Duty Time        ex. Day/Night";
            }
        }

        private void Textbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerControler e1 = new ManagerControler();
            e1.ShowDialog();
            this.Close();

        }

        private void Textbox5_Enter(object sender, EventArgs e)
        {
            if(Textbox5.Text== "Login Code")
            {
                Textbox5.Text = "";
            }
        }

        private void Textbox5_Leave(object sender, EventArgs e)
        {
            if (Textbox5.Text == "")
            {
                Textbox5.Text = "Login Code";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.loc);
                int i;
                i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from employeeinfo where e_no=" + i + "";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Textbox1.Text = dr["id"].ToString();
                    Textbox2.Text = dr["name"].ToString();
                    Textbox3.Text = dr["e_date"].ToString();
                    Textbox4.Text = dr["e_time"].ToString();
                    Textbox5.Text = dr["e_code"].ToString();

                }
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con1 = new SqlConnection(Program.loc);

                con1.Open();

                string query = "update employeeinfo set id='" + Textbox1.Text + "',name='" + Textbox2.Text + "',e_date='" + Textbox3.Text + "',e_time='" + Textbox4.Text + "' where id='" + Textbox1.Text + "'";



                SqlCommand cmd1 = new SqlCommand(query, con1);

                cmd1.ExecuteNonQuery();

                MessageBox.Show("Updated!");
                loaddata();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con1 = new SqlConnection(Program.loc);

                con1.Open();

                string query = "delete from employeeinfo where id='" + Textbox1.Text + "'";



                SqlCommand cmd1 = new SqlCommand(query, con1);

                cmd1.ExecuteNonQuery();

                MessageBox.Show("Deleted!");
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
