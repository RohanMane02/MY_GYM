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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            String equipname=txtEquipmentName.Text;
            String edescription =txtDescription.Text;
            String muse=txtMuscleUse.Text;
            String dadate=dateTimePickerDeliveryDate.Text;
            Int64 cost=Int64.Parse(txtCost.Text);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-5S8NVV2\\SQLEXPRESS; database=gym; integrated security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Equipmenet (EquipName,Edescription ,Muse ,Dadate ,cost ) values('" + equipname + "', '" + edescription + "','" + muse + "','" + dadate + "'," + cost + ")";
            //  SqlDataAdapter Da = new SqlDataAdapter(cmd);
            SqlDataAdapter Da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            //Da.Fill(ds);
            Da.Fill(ds);
            MessageBox.Show("Data Save");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEquipmentName.Clear();
            txtDescription.Clear();
            txtMuscleUse.Clear();
            dateTimePickerDeliveryDate.Value = DateTime.Now;
            txtCost.Clear();
        }

        private void btnViewEquipments_Click(object sender, EventArgs e)
        {
            NewEqipment nw=new NewEqipment();
            nw.Show();

        }
    }
}
