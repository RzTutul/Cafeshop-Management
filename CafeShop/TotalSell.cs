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
    public partial class TotalSell : Form
    {
        public TotalSell()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerControler m = new ManagerControler();

            m.ShowDialog();
            this.Close();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string loc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\visualstudio\CafeShop\CafeShop\Database1.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(loc);

            con.Open();

            string query = "select * from sell;";

            SqlCommand cmd = new SqlCommand(query, con);

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();



        }
    }
}
