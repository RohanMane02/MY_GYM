using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mygym
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(textBoxusername.Text=="admin" && textBoxpassword.Text == "admin")
            {
                Form1 fa=new Form1();
                fa.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("please enter valid details", "valid data", MessageBoxButtons.OK);

                textBoxusername.Clear();
                textBoxpassword.Clear();
            }
        }
    }
}
