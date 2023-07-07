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
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            String fname=txtFname.Text;
            String lname=txtLname.Text;

            String gender = "";
            bool ischecked = radioButton1.Checked;
            if (ischecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String joindate = dateTimePickerJOINDate.Text;
            String state=txtState.Text;
            String city=txtCity.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-5S8NVV2\\SQLEXPRESS; database=gym; integrated security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into NewStaff (Fname,Lname ,Gender ,Dob ,Mobile ,Email ,JoinDate ,State,City  ) values('" + fname + "', '" + lname + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + joindate + "','" + state + "','" + city + "')";
            //  SqlDataAdapter Da = new SqlDataAdapter(cmd);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            //Da.Fill(ds);
            Da.Fill(ds);
            MessageBox.Show("Data Save");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtMobile.Clear();
            txtEmail.Clear();

           

            txtState.Clear();
            txtCity.Clear();

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJOINDate.Value = DateTime.Now;
        }
    }
}
