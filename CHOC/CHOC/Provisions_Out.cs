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
    public partial class Provisions_Out : Form
    {
        Provisions theParent;

        public Provisions_Out(/*Provisions parentForm*/)
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

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 1;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnBack.BackColor = Color.Transparent;
            btnBack.BackColor = Color.FromArgb(150, Color.White);
            btnBack.FlatAppearance.BorderColor = Color.Black;
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            //Validate Inputs
            string inventoryDestination = "";//Destination name validation start
            inventoryDestination = metroTextBox1.Text;
            inventoryDestination = inventoryDestination.Replace(" ", "");
            if (inventoryDestination == "")
            {
                metroButton1.Focus();
                MessageBox.Show("Please enter outbound inventory destination");
                return;
            }//Destination name Validtion Ends

            if (metroComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a distribution type.");
            }

            theParent.updateTables();
            theParent.addtoInOutTable(metroComboBox1.SelectedItem.ToString(), metroTextBox1.Text);
            theParent.addtoProvisionsSuppTable();

            ClearAllFields();
            this.Close();
        }

        private void ClearAllFields()
        {
            metroTextBox1.Text = "";
            metroComboBox1.Items.Clear();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Provisions myprov = new Provisions();
            myprov.Visible = true;
            Close();
        }
    }
}
