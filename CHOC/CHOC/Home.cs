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
    public partial class Home : Form
    {        
        public Home()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.FlatAppearance.BorderSize = 1;
            btnInventory.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnInventory.BackColor = Color.Transparent;
            btnInventory.BackColor = Color.FromArgb(150, Color.White);
            btnInventory.FlatAppearance.BorderColor = Color.Black;

            btnFinancials.FlatStyle = FlatStyle.Flat;
            btnFinancials.FlatAppearance.BorderSize = 1;
            btnFinancials.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnFinancials.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnFinancials.BackColor = Color.Transparent;
            btnFinancials.BackColor = Color.FromArgb(150, Color.White);
            btnFinancials.FlatAppearance.BorderColor = Color.Black;

            btnLogistics.FlatStyle = FlatStyle.Flat;
            btnLogistics.FlatAppearance.BorderSize = 1;
            btnLogistics.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnLogistics.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnLogistics.BackColor = Color.Transparent;
            btnLogistics.BackColor = Color.FromArgb(150, Color.White);
            btnLogistics.FlatAppearance.BorderColor = Color.Black;

            btnHR.FlatStyle = FlatStyle.Flat;
            btnHR.FlatAppearance.BorderSize = 1;
            btnHR.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, Color.White);
            btnHR.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnHR.BackColor = Color.Transparent;
            btnHR.BackColor = Color.FromArgb(150, Color.White);
            btnHR.FlatAppearance.BorderColor = Color.Black;

            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 1;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, Color.White);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnExit.BackColor = Color.Transparent;
            btnExit.BackColor = Color.FromArgb(150, Color.White);
            btnExit.FlatAppearance.BorderColor = Color.Black;

        }

        private void BtnFinancials_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will be added in a later version.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            Inventory myInventory = new Inventory();
            Visible = false;
            myInventory.Show();            
        }

        private void BtnLogistics_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will be added in a later version.", "Notification", MessageBoxButtons.OK,  MessageBoxIcon.Information);
        }

        private void BtnHR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will be added in a later version.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }
    }
}
