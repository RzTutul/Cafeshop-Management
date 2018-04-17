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
    public partial class AllEmployee : Form
    {
        public AllEmployee()
        {
            InitializeComponent();
        }

        private void allemployeeButton2_Click(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection(Program.loc);

            con1.Open();

            string query1 = "delete from loghistory";


            SqlCommand cmd1 = new SqlCommand(query1, con1);


            cmd1.ExecuteNonQuery();
            MessageBox.Show("Deleted !");
            employeelog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();

                ManagerControler m = new ManagerControler();

                m.ShowDialog();

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AllEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet6.employeeinfo' table. You can move, or remove it, as needed.
         //   this.employeeinfoTableAdapter.Fill(this.database1DataSet6.employeeinfo);

        }

        private void employeelogButton1_Click(object sender, EventArgs e)
        {
            try
            {
                employeelog();



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    void    employeelog()
        {

            SqlConnection con1 = new SqlConnection(Program.loc);

            con1.Open();

            string query1 = "Select id,name,loginTime,status from loghistory ;";

            SqlCommand cmd1 = new SqlCommand(query1, con1);



            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd1);

            da.Fill(dt);

            dataGridView1.DataSource = dt;


            con1.Close();
        }
    }
}
