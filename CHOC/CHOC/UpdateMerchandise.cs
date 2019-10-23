using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CHOC
{
    public partial class UpdateMerchandise : Form
    {
        public string DBFile;
        public OleDbConnection myDB;
        public string conn = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=";
        string path = "";
        string varC = "";

        public UpdateMerchandise()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            btnBrand.FlatStyle = FlatStyle.Flat;
            btnBrand.FlatAppearance.BorderSize = 1;
            btnBrand.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnBrand.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnBrand.BackColor = Color.Transparent;
            btnBrand.BackColor = Color.FromArgb(150, Color.White);
            btnBrand.FlatAppearance.BorderColor = Color.Black;

            btnMerch.FlatStyle = FlatStyle.Flat;
            btnMerch.FlatAppearance.BorderSize = 1;
            btnMerch.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnMerch.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnMerch.BackColor = Color.Transparent;
            btnMerch.BackColor = Color.FromArgb(150, Color.White);
            btnMerch.FlatAppearance.BorderColor = Color.Black;

            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 1;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.BackColor = Color.FromArgb(150, Color.White);
            btnUpdate.FlatAppearance.BorderColor = Color.Black;

            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 1;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackColor = Color.FromArgb(150, Color.White);
            btnDelete.FlatAppearance.BorderColor = Color.Black;

            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.FlatAppearance.BorderSize = 1;
            btnInsert.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnInsert.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnInsert.BackColor = Color.Transparent;
            btnInsert.BackColor = Color.FromArgb(150, Color.White);
            btnInsert.FlatAppearance.BorderColor = Color.Black;

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 1;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnBack.BackColor = Color.Transparent;
            btnBack.BackColor = Color.FromArgb(150, Color.White);
            btnBack.FlatAppearance.BorderColor = Color.Black;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
            myDB = new OleDbConnection(conn + path);

        }

        private void BtnMerch_Click(object sender, EventArgs e)
        {
            rbtnInsert.Checked = false;
            rbtnUpdate.Checked = false;
            rbtnDelete.Checked = false;

            label4.Text = "Merchandise";
            label7.Text = "Merchandise_ID:";
            label12.Text = "Merchandise name:";
            label2.Text = "Merchandise description:";
            label6.Text = "Merchandise retail price:";
            varC = "Merchandise";

            label2.Enabled = false;
            label3.Enabled = false;
            label6.Enabled = false;
            label12.Enabled = false;
            label7.Enabled = false;

            txtMerchDes.Enabled = false;
            txtMerchName.Enabled = false;
            udStock.Enabled = false;
            udMerchPrice.Enabled = false;
            udMerchID.Enabled = false;

            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            rbtnInsert.Enabled = true;
            rbtnUpdate.Enabled = true;
            rbtnDelete.Enabled = true;
        }

        private void BtnBrand_Click(object sender, EventArgs e)
        {
            rbtnInsert.Checked = false;
            rbtnUpdate.Checked = false;
            rbtnDelete.Checked = false;

            label4.Text = "Branding";
            label7.Text = "Branding_ID:";
            label12.Text = "Branding name:";
            label2.Text = "Branding description:";
            label6.Text = "Branding retail price:";
            varC = "Branding";

            label2.Enabled = false;
            label3.Enabled = false;
            label6.Enabled = false;
            label12.Enabled = false;
            label7.Enabled = false;

            txtMerchDes.Enabled = false;
            txtMerchName.Enabled = false;
            udStock.Enabled = false;
            udMerchPrice.Enabled = false;
            udMerchID.Enabled = false;

            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            rbtnInsert.Enabled = true;
            rbtnUpdate.Enabled = true;
            rbtnDelete.Enabled = true;
        }

        private void RbtnDelete_CheckedChanged(object sender, EventArgs e)
        {
            label7.Enabled = true;

            udMerchID.Enabled = true;

            btnDelete.Enabled = true;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;

            rbtnInsert.Enabled = false;
            rbtnUpdate.Enabled = false;
        }

        private void RbtnInsert_CheckedChanged(object sender, EventArgs e)
        {
            label2.Enabled = true;
            label3.Enabled = true;
            label6.Enabled = true;
            label12.Enabled = true;

            txtMerchDes.Enabled = true;
            txtMerchName.Enabled = true;
            udStock.Enabled = true;
            udMerchPrice.Enabled = true;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            rbtnUpdate.Enabled = false;
            rbtnDelete.Enabled = false;
        }

        private void RbtnUpdate_CheckedChanged(object sender, EventArgs e)
        {
            label2.Enabled = true;
            label3.Enabled = true;
            label6.Enabled = true;
            label12.Enabled = true;

            txtMerchDes.Enabled = true;
            txtMerchName.Enabled = true;
            udStock.Enabled = true;
            udMerchPrice.Enabled = true;
            udMerchID.Enabled = true;

            btnUpdate.Enabled = true;
            btnInsert.Enabled = false;
            btnDelete.Enabled = false;

            rbtnInsert.Enabled = false;
            rbtnDelete.Enabled = false;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            rbtnInsert.Checked = false;

            string name = txtMerchName.Text;
            string description = txtMerchDes.Text;

            int id = (int)udMerchID.Value;
            int stock = (int)udStock.Value;
            int price = (int)udMerchPrice.Value;
            DateTime today = DateTime.Today;
            string date = today.ToString();

            if (varC == "Merchandise")
            {
                myDB.Open();
                string myquery = "INSERT INTO Merchandise(Merchandise_name,Merchandise_description,Merchandise_retail_price, Stock_level)VALUES('" + name + "','" + description + "','" + price + "'," + stock + ")";
                OleDbCommand cmdI = new OleDbCommand(myquery, myDB);
                cmdI.ExecuteNonQuery();
                MessageBox.Show("Merchandise donation entered");

                myDB.Close();
            }
            else if (varC == "Branding")
            {
                myDB.Open();
                string myquery = "INSERT INTO Branding(Branding_name,Branding_description,Branding_retail_price, Stock_level)VALUES('" + name + "','" + description + "','" + price + "'," + stock + ")";
                OleDbCommand cmdI = new OleDbCommand(myquery, myDB);
                cmdI.ExecuteNonQuery();
                MessageBox.Show("Merchandise donation entered");

                myDB.Close();
            }

            /*
              myDB.Open();

              String name = textBox1.Text.ToString();
              String description = textBox2.Text.ToString();


              String myquery = "INSERT INTO Branding(Item_name,Item_description)VALUES('" + name + "','" + description + "')";
              OleDbCommand cmd = new OleDbCommand(myquery, myDB);
              cmd.ExecuteNonQuery();

              MessageBox.Show("Data saved successfuly...!");
              DataSet ds = new DataSet();
              adapter.Fill(ds, "List");
              dataGridView1.DataSource = ds;
              dataGridView1.DataMember = "List";
              myDB.Close();*/

            label2.Enabled = false;
            label3.Enabled = false;
            label6.Enabled = false;
            label12.Enabled = false;
            label7.Enabled = false;

            txtMerchDes.Enabled = false;
            txtMerchName.Enabled = false;
            udStock.Enabled = false;
            udMerchPrice.Enabled = false;
            udMerchID.Enabled = false;
            btnInsert.Enabled = false;

            rbtnInsert.Enabled = true;
            rbtnUpdate.Enabled = true;
            rbtnDelete.Enabled = true;

            txtMerchDes.Text = "";
            txtMerchName.Text = "";
            udStock.Value = 0;
            udMerchPrice.Value = 0;
            udMerchID.Value = 0;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            rbtnUpdate.Checked = false;

            string name = txtMerchName.Text;
            string description = txtMerchDes.Text;

            int id = (int)udMerchID.Value;
            int stock = (int)udStock.Value;
            int price = (int)udMerchPrice.Value;
            DateTime today = DateTime.Today;
            string date = today.ToString();

            if (varC == "Merchandise")
            {
                myDB.Open();
                //string myquery = "INSERT INTO Merchandise(Merchandise_name,Merchandise_description,Merchandise_retail_price, Stock_level)VALUES('" + name + "','" + description + "','" + price + "'," + stock + ")";
                string myquery = "UPDATE Merchandise SET Merchandise_name = '" + name + "', Merchandise_description= '" + description + "', Merchandise_retail_price = " + price + ", Stock_level = " + stock + " WHERE Merchandise_ID = " + id + "";
                OleDbCommand cmdI = new OleDbCommand(myquery, myDB);
                cmdI.ExecuteNonQuery();
                MessageBox.Show("Merchandise donation entered");

                myDB.Close();
            }
            else if (varC == "Branding")
            {
                myDB.Open();
                string myquery = "UPDATE Branding SET Branding_name = '" + name + "', Branding_description= '" + description + "', Branding_retail_price = " + price + ", Stock_level = " + stock + " WHERE Branding_ID = " + id + "";
                OleDbCommand cmdI = new OleDbCommand(myquery, myDB);
                cmdI.ExecuteNonQuery();
                MessageBox.Show("Merchandise donation entered");

                myDB.Close();
            }


            label2.Enabled = false;
            label3.Enabled = false;
            label6.Enabled = false;
            label12.Enabled = false;
            label7.Enabled = false;

            txtMerchDes.Enabled = false;
            txtMerchName.Enabled = false;
            udStock.Enabled = false;
            udMerchPrice.Enabled = false;
            udMerchID.Enabled = false;

            btnUpdate.Enabled = false;

            rbtnInsert.Enabled = true;
            rbtnUpdate.Enabled = true;
            rbtnDelete.Enabled = true;

            txtMerchDes.Text = "";
            txtMerchName.Text = "";
            udStock.Value = 0;
            udMerchPrice.Value = 0;
            udMerchID.Value = 0;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            rbtnDelete.Checked = false;


            string name = txtMerchName.Text;
            string description = txtMerchDes.Text;

            int id = (int)udMerchID.Value;
            int stock = (int)udStock.Value;
            int price = (int)udMerchPrice.Value;
            DateTime today = DateTime.Today;
            string date = today.ToString();

            if (varC == "Merchandise")
            {
                myDB.Open();
                string myquery = "DELETE FROM Merchandise WHERE Merchandise_ID = " + id + "";
                OleDbCommand cmdI = new OleDbCommand(myquery, myDB);
                cmdI.ExecuteNonQuery();
                MessageBox.Show("Merchandise donation entered");

                myDB.Close();
            }
            else if (varC == "Branding")
            {
                myDB.Open();
                string myquery = "DELETE FROM Branding WHERE Branding_ID = " + id + "";
                OleDbCommand cmdI = new OleDbCommand(myquery, myDB);
                cmdI.ExecuteNonQuery();
                MessageBox.Show("Merchandise donation entered");

                myDB.Close();
            }

            label2.Enabled = false;
            label3.Enabled = false;
            label6.Enabled = false;
            label12.Enabled = false;
            label7.Enabled = false;

            txtMerchDes.Enabled = false;
            txtMerchName.Enabled = false;
            udStock.Enabled = false;
            udMerchPrice.Enabled = false;
            udMerchID.Enabled = false;

            rbtnInsert.Enabled = true;
            rbtnUpdate.Enabled = true;
            rbtnDelete.Enabled = true;

            btnDelete.Enabled = false;

            txtMerchDes.Text = "";
            txtMerchName.Text = "";
            udStock.Value = 0;
            udMerchPrice.Value = 0;
            udMerchID.Value = 0;
        }

        private void UpdateMerchandise_Load(object sender, EventArgs e)
        {
            label2.Enabled = false;
            label3.Enabled = false;
            label6.Enabled = false;
            label12.Enabled = false;
            label7.Enabled = false;

            txtMerchDes.Enabled = false;
            txtMerchName.Enabled = false;
            udStock.Enabled = false;
            udMerchPrice.Enabled = false;
            udMerchID.Enabled = false;

            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtMerchDes.Text = "";
            txtMerchName.Text = "";
            udStock.Value = 0;
            udMerchPrice.Value = 0;
            udMerchID.Value = 0;
        }
    }
}
