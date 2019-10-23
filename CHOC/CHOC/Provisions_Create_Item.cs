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
    public partial class Provisions_Create_Item : Form
    {
        Provisions theParent;

        public Provisions_Create_Item(/*Provisions parentForm*/)
        {
            InitializeComponent();
            //theParent = parentForm;

            StartPosition = FormStartPosition.CenterScreen;

            btnClearFields.FlatStyle = FlatStyle.Flat;
            btnClearFields.FlatAppearance.BorderSize = 1;
            btnClearFields.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnClearFields.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnClearFields.BackColor = Color.Transparent;
            btnClearFields.BackColor = Color.FromArgb(150, Color.White);
            btnClearFields.FlatAppearance.BorderColor = Color.Black;

            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.FlatAppearance.BorderSize = 1;
            btnConfirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnConfirm.BackColor = Color.Transparent;
            btnConfirm.BackColor = Color.FromArgb(150, Color.White);
            btnConfirm.FlatAppearance.BorderColor = Color.Black;

            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 1;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackColor = Color.FromArgb(150, Color.White);
            btnCancel.FlatAppearance.BorderColor = Color.Black;
        }


        private void Provisions_Create_Item_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Provisions myprov = new Provisions();
            myprov.Visible = true;
            Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            //Validate Inputs
            string itemName = "";//Item name validation start
            itemName = txtName.Text;
            itemName = itemName.Replace(" ", "");
            double itemPrice = 0.0;
            if (itemName == "")
            {
                txtName.Focus();
                MessageBox.Show("Please type a Name for the Item");
                return;
            }                   //Item name Validtion Ends
            try                 //Item Price Validation Start
            {
                itemPrice = double.Parse(txtItemPrice.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please type a Price for the item.\nType the price in the following format\n\nE.g.\n14.99");
                return;
            }                   //Item Price Validation End

            //Description not validated, may be empty
            //Quantity will always be int because of the control

            //The Provisions form will add the new item to the Database and GUI
            theParent.addItemToDB(txtName.Text, txtItemDescripotion.Text, itemPrice, (int)numStockQuantity.Value);

            ClearAllFields();
        }

        private void BtnClearFields_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            txtName.Text = "";
            txtItemDescripotion.Text = "";
            txtItemPrice.Text = "";
            numStockQuantity.Value = 1;
        }


    }
}
