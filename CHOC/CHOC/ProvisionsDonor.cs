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
    public partial class ProvisionsDonor : Form
    {
        Provisions theParent;
        public ProvisionsDonor(/*Provisions parentForm*/)
        {
            InitializeComponent();
            //theParent = parentForm;

            StartPosition = FormStartPosition.CenterScreen;

            metroButton1.FlatStyle = FlatStyle.Flat;
            metroButton1.FlatAppearance.BorderSize = 1;
            metroButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            metroButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            metroButton1.BackColor = Color.Transparent;
            metroButton1.BackColor = Color.FromArgb(150, Color.White);
            metroButton1.FlatAppearance.BorderColor = Color.Black;

            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 1;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackColor = Color.FromArgb(150, Color.White);
            btnCancel.FlatAppearance.BorderColor = Color.Black;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Provisions myprov = new Provisions();
            myprov.Visible = true;
            Close();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            //Validate Inputs
            string inventoryDonor = "";//Donor name validation start
            inventoryDonor = metroTextBox1.Text;
            inventoryDonor = inventoryDonor.Replace(" ", "");
            if (inventoryDonor == "")
            {
                metroButton1.Focus();
                MessageBox.Show("Please enter name of donor");
                return;
            }//Donor name Validtion Ends
        }

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            //Validate Inputs
            string inventoryDonor = "";//Donor name validation start
            inventoryDonor = metroTextBox1.Text;
            inventoryDonor = inventoryDonor.Replace(" ", "");
            if (inventoryDonor == "")
            {
                metroButton1.Focus();
                MessageBox.Show("Please enter name of donor");
                return;
            }//Donor name Validtion Ends

            theParent.addListBoxItemsToDB();
            theParent.addDonerNameAndType(metroComboBox1.Text, metroTextBox1.Text);
            theParent.addToProvisionSupport();
            this.Close();
        }
    }
}
