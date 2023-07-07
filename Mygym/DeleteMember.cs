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
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do ypu want to delete please confirm?","Delete Data",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-5S8NVV2\\SQLEXPRESS; database=gym; integrated security=true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Delete from NewMember where MID=" + txtSearch.Text + "";
                SqlDataAdapter Da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                //Da.Fill(ds);
                Da.Fill(ds);
              //  dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                this.Activate();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-5S8NVV2\\SQLEXPRESS; database=gym; integrated security=true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from NewMember ";
                SqlDataAdapter Da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                //Da.Fill(ds);
                Da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void DeleteMember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-5S8NVV2\\SQLEXPRESS; database=gym; integrated security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NewMember ";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            //Da.Fill(ds);
            Da.Fill(ds);
           dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
