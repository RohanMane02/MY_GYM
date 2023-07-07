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
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void NewMember_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            String fname = txtFirstName.Text;
            String lname = txtLastName.Text;
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
            Int64 mobile=Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String joindate=dateTimePickerJoinDate.Text;
            String gymtime=comboBoxGymTime.Text;
            String address=txtAddress.Text;
            String memebership=comboBoxMembership.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-5S8NVV2\\SQLEXPRESS; database=gym; integrated security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into NewMember (Fname,Lname ,Gender ,Dob ,Mobile ,Email ,JoinDate ,GymTime,Maddress ,MembershipTime ) values('" + fname+ "', '" + lname + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + joindate + "','" + gymtime + "','" + address + "','" + memebership + "')";
            //  SqlDataAdapter Da = new SqlDataAdapter(cmd);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            //Da.Fill(ds);
            Da.Fill(ds);
            MessageBox.Show("Data Save");


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtMobile.Clear();
            txtEmail.Clear();

            comboBoxGymTime.ResetText();
           comboBoxMembership.ResetText();

            txtAddress.Clear();

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;
        }
    }
}
