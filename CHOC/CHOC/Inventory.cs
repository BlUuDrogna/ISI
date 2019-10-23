using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHOC
{
    public partial class Inventory : Form
    {

        public Inventory()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            btnDonors.FlatStyle = FlatStyle.Flat;
            btnDonors.FlatAppearance.BorderSize = 1;
            btnDonors.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnDonors.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnDonors.BackColor = Color.Transparent;
            btnDonors.BackColor = Color.FromArgb(150, Color.White);
            btnDonors.FlatAppearance.BorderColor = Color.Black;

            btnGP.FlatStyle = FlatStyle.Flat;
            btnGP.FlatAppearance.BorderSize = 1;
            btnGP.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnGP.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnGP.BackColor = Color.Transparent;
            btnGP.BackColor = Color.FromArgb(150, Color.White);
            btnGP.FlatAppearance.BorderColor = Color.Black;

            btnM_B.FlatStyle = FlatStyle.Flat;
            btnM_B.FlatAppearance.BorderSize = 1;
            btnM_B.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnM_B.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnM_B.BackColor = Color.Transparent;
            btnM_B.BackColor = Color.FromArgb(150, Color.White);
            btnM_B.FlatAppearance.BorderColor = Color.Black;

            btnProvisions.FlatStyle = FlatStyle.Flat;
            btnProvisions.FlatAppearance.BorderSize = 1;
            btnProvisions.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnProvisions.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnProvisions.BackColor = Color.Transparent;
            btnProvisions.BackColor = Color.FromArgb(150, Color.White);
            btnProvisions.FlatAppearance.BorderColor = Color.Black;

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 1;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnBack.BackColor = Color.Transparent;
            btnBack.BackColor = Color.FromArgb(150, Color.White);
            btnBack.FlatAppearance.BorderColor = Color.Black;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Home myHome = new Home();
            myHome.Visible = true;
            Close();
        }

        private void BtnM_B_Click(object sender, EventArgs e)
        {
            Merchandise_Branding myMerhBrand = new Merchandise_Branding();
            myMerhBrand.Show();
            Visible = false;
        }

        private void BtnGP_Click(object sender, EventArgs e)
        {
            Carebags myCarebags = new Carebags();
            myCarebags.Show();
            Visible = false;
        }

        private void BtnDonors_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will be added in a later version.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnProvisions_Click(object sender, EventArgs e)
        {
            Provisions myprov = new Provisions();
            myprov.Show();
            Visible = false;
        }
    }
}
