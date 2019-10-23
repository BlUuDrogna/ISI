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
    public partial class Carebags : Form
    {
        public Carebags()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            btnDBMnge.FlatStyle = FlatStyle.Flat;
            btnDBMnge.FlatAppearance.BorderSize = 1;
            btnDBMnge.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnDBMnge.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnDBMnge.BackColor = Color.Transparent;
            btnDBMnge.BackColor = Color.FromArgb(150, Color.White);
            btnDBMnge.FlatAppearance.BorderColor = Color.Black;

            btnDonorMnge.FlatStyle = FlatStyle.Flat;
            btnDonorMnge.FlatAppearance.BorderSize = 1;
            btnDonorMnge.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnDonorMnge.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnDonorMnge.BackColor = Color.Transparent;
            btnDonorMnge.BackColor = Color.FromArgb(150, Color.White);
            btnDonorMnge.FlatAppearance.BorderColor = Color.Black;

            btnItemManage.FlatStyle = FlatStyle.Flat;
            btnItemManage.FlatAppearance.BorderSize = 1;
            btnItemManage.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnItemManage.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnItemManage.BackColor = Color.Transparent;
            btnItemManage.BackColor = Color.FromArgb(150, Color.White);
            btnItemManage.FlatAppearance.BorderColor = Color.Black;

            btnManageCB.FlatStyle = FlatStyle.Flat;
            btnManageCB.FlatAppearance.BorderSize = 1;
            btnManageCB.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnManageCB.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnManageCB.BackColor = Color.Transparent;
            btnManageCB.BackColor = Color.FromArgb(150, Color.White);
            btnManageCB.FlatAppearance.BorderColor = Color.Black;

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 1;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnBack.BackColor = Color.Transparent;
            btnBack.BackColor = Color.FromArgb(150, Color.White);
            btnBack.FlatAppearance.BorderColor = Color.Black;
        }

        private void Carebags_Load(object sender, EventArgs e)
        {

        }

        private void BtnDonorMnge_Click(object sender, EventArgs e)
        {
            Donor_management myDonMan = new Donor_management();
            myDonMan.Show();
            Visible = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Inventory myInventory = new Inventory();
            myInventory.Visible = true;
            Close();
        }

        private void BtnCBMnge_Click(object sender, EventArgs e)
        {
            DistributionManagement myDBMan = new DistributionManagement();
            myDBMan.Show();
            Visible = false;
        }

        private void BtnItemManage_Click(object sender, EventArgs e)
        {
            Item_management myItmMag = new Item_management();
            myItmMag.Show();
            Visible = false;
        }

        private void BtnManageCB_Click(object sender, EventArgs e)
        {
            CarebagManagement myCBMnge = new CarebagManagement();
            myCBMnge.Show();
            Visible = false;
        }
    }
}
