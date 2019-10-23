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
    public partial class Merchandise_Branding : Form
    {
        public string DBFile;
        public OleDbConnection myDB;
        public string conn = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=";
        string path = "";
        string varC = "Merchandise";
        public Merchandise_Branding()
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

            btnDon.FlatStyle = FlatStyle.Flat;
            btnDon.FlatAppearance.BorderSize = 1;
            btnDon.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnDon.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnDon.BackColor = Color.Transparent;
            btnDon.BackColor = Color.FromArgb(150, Color.White);
            btnDon.FlatAppearance.BorderColor = Color.Black;

            btnIn.FlatStyle = FlatStyle.Flat;
            btnIn.FlatAppearance.BorderSize = 1;
            btnIn.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnIn.BackColor = Color.Transparent;
            btnIn.BackColor = Color.FromArgb(150, Color.White);
            btnIn.FlatAppearance.BorderColor = Color.Black;

            btnOut.FlatStyle = FlatStyle.Flat;
            btnOut.FlatAppearance.BorderSize = 1;
            btnOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnOut.BackColor = Color.Transparent;
            btnOut.BackColor = Color.FromArgb(150, Color.White);
            btnOut.FlatAppearance.BorderColor = Color.Black;

            btnMerch.FlatStyle = FlatStyle.Flat;
            btnMerch.FlatAppearance.BorderSize = 1;
            btnMerch.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnMerch.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnMerch.BackColor = Color.Transparent;
            btnMerch.BackColor = Color.FromArgb(150, Color.White);
            btnMerch.FlatAppearance.BorderColor = Color.Black;

            btnIsrtUpdate.FlatStyle = FlatStyle.Flat;
            btnIsrtUpdate.FlatAppearance.BorderSize = 1;
            btnIsrtUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnIsrtUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnIsrtUpdate.BackColor = Color.Transparent;
            btnIsrtUpdate.BackColor = Color.FromArgb(150, Color.White);
            btnIsrtUpdate.FlatAppearance.BorderColor = Color.Black;

            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.FlatAppearance.BorderSize = 1;
            btnReport.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnReport.BackColor = Color.Transparent;
            btnReport.BackColor = Color.FromArgb(150, Color.White);
            btnReport.FlatAppearance.BorderColor = Color.Black;

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

            btnIn.Enabled = false;
            btnOut.Enabled = false;
            btnDon.Enabled = false;
        }

        private void Merchandise_Branding_Load(object sender, EventArgs e)
        {
            myDB.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Merchandise", myDB);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "List");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "List";
            myDB.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Inventory myInv = new Inventory();
            myInv.Visible = true;
            Close();
        }

        private void BtnIsrtUpdate_Click(object sender, EventArgs e)
        {
            UpdateMerchandise myUpdateMerch = new UpdateMerchandise();
            myUpdateMerch.Show();
            Visible = false;
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            Report newReport = new Report();
            newReport.Show();
            Visible = false;
        }

        private void BtnBrand_Click(object sender, EventArgs e)
        {
            myDB.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Branding", myDB);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "List");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "List";
            myDB.Close();

            label1.Text = "Branding";
            label2.Text = "Branding_ID:";
            label7.Text = "Branding_ID:";
            label11.Text = "Branding_ID:";
            varC = "Branding";
        }

        private void BtnMerch_Click(object sender, EventArgs e)
        {
            myDB.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Merchandise", myDB);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "List");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "List";
            myDB.Close();

            label1.Text = "Merchandise";
            label2.Text = "Merchandise_ID:";
            label7.Text = "Merchandise_ID:";
            label11.Text = "Merchandise_ID:";
            varC = "Merchandise";
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            string source = "";
            int id = (int)udMerchIn.Value;
            int qty = (int)udQuanIn.Value;
            DateTime today = DateTime.Today;
            string date = today.ToString();

            switch (cboSourceIn.SelectedIndex)
            {
                case 0:
                    source = "Choc purchase";
                    break;
                case 1:
                    source = "Return from distribution";
                    break;
            }

            if (varC == "Merchandise")
            {
                myDB.Open();
                string myquery = "INSERT INTO Distribution(Distribution_Date,Distribution_Category,Distribution_Name, Quantity,Merchandise_ID,Branding_ID)VALUES('" + date + "','" + source + "','" + "Items inserted into" + "'," + qty + "," + id + "," + "Null" + ")";
                OleDbCommand cmdI = new OleDbCommand(myquery, myDB);
                cmdI.ExecuteNonQuery();
                MessageBox.Show("Merchandise donation entered");

                string myquery1 = "UPDATE Merchandise SET Stock_Level = Merchandise.Stock_Level + " + qty + " WHERE Merchandise_ID = " + id + "";
                OleDbCommand cmdU = new OleDbCommand(myquery1, myDB);
                cmdU.ExecuteNonQuery();
                MessageBox.Show("Merchandise entered");

                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Merchandise", myDB);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "List";
                myDB.Close();
            }
            else if (varC == "Branding")
            {
                myDB.Open();
                string myquery = "INSERT INTO Distribution(Distribution_Date,Distribution_Category,Distribution_Name, Quantity,Merchandise_ID,Branding_ID)VALUES('" + date + "','" + source + "','" + "Items inserted into" + "'," + qty + "," + "Null" + "," + id + ")";
                OleDbCommand cmd = new OleDbCommand(myquery, myDB);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Branding donation entered");

                string myquery1 = "UPDATE Branding SET Stock_Level = Branding.Stock_Level + " + qty + " WHERE Branding_ID = " + id + "";
                OleDbCommand cmdU = new OleDbCommand(myquery1, myDB);
                cmdU.ExecuteNonQuery();
                MessageBox.Show("Branding entered");

                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Branding", myDB);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "List";
                myDB.Close();
            }

            udQuanIn.Value = 0;
            udMerchIn.Value = 0;
            cboSourceIn.SelectedIndex = -1;

            btnIn.Enabled = false;
        }

        private void BtnOut_Click(object sender, EventArgs e)
        {
            string distribution_type = "";
            int id = (int)udMerchOut.Value;
            int qty = (int)udQuanOut.Value;
            DateTime today = DateTime.Today;
            string date = today.ToString();
            string distribution_name = txtDistNameOut.Text;

            switch (cboDistTypeOut.SelectedIndex)
            {
                case 0:
                    distribution_type = "Choc house";
                    break;
                case 1:
                    distribution_type = "Event";
                    break;
                case 2:
                    distribution_type = "Practical support";
                    break;
                case 3:
                    distribution_type = "Hospital";
                    break;
            }

            if (varC == "Merchandise")
            {
                myDB.Open();
                string myquery = "INSERT INTO Distribution(Distribution_Date,Distribution_Category,Distribution_Name, Quantity,Merchandise_ID,Branding_ID)VALUES('" + date + "','" + distribution_type + "','" + distribution_name + "'," + qty + "," + id + "," + "Null" + ")";
                OleDbCommand cmdI = new OleDbCommand(myquery, myDB);
                cmdI.ExecuteNonQuery();
                MessageBox.Show("Merchandise donation entered");

                string myquery1 = "UPDATE Merchandise SET Stock_Level = Merchandise.Stock_Level - " + qty + " WHERE Merchandise_ID = " + id + "";
                OleDbCommand cmdU = new OleDbCommand(myquery1, myDB);
                cmdU.ExecuteNonQuery();
                MessageBox.Show("Merchandise entered");

                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Merchandise", myDB);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "List";
                myDB.Close();
            }
            else if (varC == "Branding")
            {
                myDB.Open();
                string myquery = "INSERT INTO Distribution(Distribution_Date,Distribution_Category,Distribution_Name, Quantity,Merchandise_ID,Branding_ID)VALUES('" + date + "','" + distribution_type + "','" + distribution_name + "'," + qty + "," + "Null" + "," + id + ")";
                OleDbCommand cmd = new OleDbCommand(myquery, myDB);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Branding donation entered");

                string myquery1 = "UPDATE Branding SET Stock_Level = Branding.Stock_Level - " + qty + " WHERE Branding_ID = " + id + "";
                OleDbCommand cmdU = new OleDbCommand(myquery1, myDB);
                cmdU.ExecuteNonQuery();
                MessageBox.Show("Branding entered");

                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Branding", myDB);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "List";
                myDB.Close();
            }


            udMerchOut.Value = 0;
            udQuanOut.Value = 0;
            cboDistTypeOut.SelectedIndex = -1;
            txtDistNameOut.Text = "";
            btnOut.Enabled = false;
        }

        private void BtnDon_Click(object sender, EventArgs e)
        {
            string donor_name = txtDnrName.Text.ToString();
            string category = "";
            int id = (int)udMerchDon.Value;
            int qty = (int)udQuanDon.Value;
            DateTime today = DateTime.Today;
            string date = today.ToString();

            switch (cboCatDon.SelectedIndex)
            {
                case 0:
                    category = "Individual";
                    break;
                case 1:
                    category = "Corporate";
                    break;
                case 2:
                    category = "School";
                    break;
                case 3:
                    category = "Community";
                    break;
                case 4:
                    category = "Church";
                    break;
                case 5:
                    category = "Choc Purchase";
                    break;
            }

            if (varC == "Merchandise")
            {
                myDB.Open();
                string myquery = "INSERT INTO Donations(Donation_Date,Donation_Category,Donation_Donor_Name, Quantity,Merchandise_ID,Branding_ID)VALUES('" + date + "','" + category + "','" + donor_name + "'," + qty + "," + id + "," + "Null" + ")";
                //MessageBox.Show("INSERT INTO Donations(Donation_Date,Donation_Category,Donation_Donor_Name, Quantity,Merchandise_ID,Branding_ID)VALUES('" + date + "','" + category + "','" + donor_name + "'," + qty + "," + id + "," + "Null" + ")");
                OleDbCommand cmdI = new OleDbCommand(myquery, myDB);
                cmdI.ExecuteNonQuery();
                MessageBox.Show("Merchandise donation entered");

                string myquery1 = "UPDATE Merchandise SET Stock_Level = Merchandise.Stock_Level + " + qty + " WHERE Merchandise_ID = " + id + "";
                //MessageBox.Show("INSERT INTO Donations(Donation_Date,Donation_Category,Donation_Donor_Name, Quantity,Merchandise_ID,Branding_ID)VALUES('" + date + "','" + category + "','" + donor_name + "'," + qty + "," + id + "," + "Null" + ")");
                OleDbCommand cmdU = new OleDbCommand(myquery1, myDB);
                cmdU.ExecuteNonQuery();
                MessageBox.Show("Merchandise donation entered");

                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Merchandise", myDB);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "List";
                myDB.Close();
            }
            else if (varC == "Branding")
            {
                myDB.Open();
                string myquery = "INSERT INTO Donations(Donation_Date,Donation_Category,Donation_Donor_Name, Quantity,Merchandise_ID,Branding_ID)VALUES('" + date + "','" + category + "','" + donor_name + "'," + qty + "," + "Null" + "," + id + ")";
                OleDbCommand cmd = new OleDbCommand(myquery, myDB);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Branding donation entered");

                string myquery1 = "UPDATE Branding SET Stock_Level = Branding.Stock_Level + " + qty + " WHERE Branding_ID = " + id + "";
                OleDbCommand cmdU = new OleDbCommand(myquery1, myDB);
                cmdU.ExecuteNonQuery();
                MessageBox.Show("Branding entered");

                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Branding", myDB);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "List";
                myDB.Close();
            }


            udQuanDon.Value = 0;
            udMerchDon.Value = 0;
            cboCatDon.SelectedIndex = -1;
            txtDnrName.Text = "";
            btnDon.Enabled = false;
        }

        private void CboSourceIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnIn.Enabled = true;
        }

        private void CboDistTypeOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOut.Enabled = true;
        }

        private void CboCatDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDon.Enabled = true;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchKey = txtSearch.Text;

            if (varC == "Merchandise")
            {
                myDB.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Merchandise WHERE Merchandise_name LIKE '%" + searchKey + "%'", myDB);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "List";
                myDB.Close();
            }
            else if (varC == "Branding")
            {
                myDB.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Branding WHERE Branding_name LIKE '%" + searchKey + "%'", myDB);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "List";
                myDB.Close();
            }
        }
    }
}
