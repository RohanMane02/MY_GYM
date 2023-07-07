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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(b==true){
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\USER\Downloads\img2.png");
                
            }

            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\USER\Downloads\img1.png");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\USER\Downloads\img1.png");

        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMember na = new NewMember();
            na.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStaff nb = new NewStaff();
            nb.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMember ma = new SearchMember();
            ma.Show();

        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMember dl = new DeleteMember();
            dl.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Do you want to close","close",MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();

            }
            else
            {
                MessageBox.Show("welcome back", "welcome", MessageBoxButtons.OK);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to logout","Log OUT",MessageBoxButtons.OKCancel,MessageBoxIcon.Error) == DialogResult.OK)
            {
                this.Close();
                Login lg = new Login();
                    lg.Show();
            }
        }
    }
}
