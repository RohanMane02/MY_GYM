using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mygym
{
    public partial class NewEqipment : Form
    {
        public NewEqipment()
        {
            InitializeComponent();
        }

        private void NewEqipment_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-5S8NVV2\\SQLEXPRESS; database=gym; integrated security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Equipmenet";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            Da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
