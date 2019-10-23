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
using System.IO;

namespace CHOC
{
    public partial class Donor_management : Form
    {
        public string DBFile = Directory.GetCurrentDirectory() + "/General Products.mdb";
        public string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        DataSet ds;
        OleDbDataAdapter adapter;
        OleDbConnection myConnection;
        string currentID;
        public int updateTemp = 0;
        public Boolean editCheck = false;

        public Donor_management()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 1;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BackColor = Color.FromArgb(150, Color.White);
            btnAdd.FlatAppearance.BorderColor = Color.Black;

            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 1;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackColor = Color.FromArgb(150, Color.White);
            btnDelete.FlatAppearance.BorderColor = Color.Black;

            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.FlatAppearance.BorderSize = 1;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnEdit.BackColor = Color.Transparent;
            btnEdit.BackColor = Color.FromArgb(150, Color.White);
            btnEdit.FlatAppearance.BorderColor = Color.Black;

            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 1;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.BackColor = Color.FromArgb(150, Color.White);
            btnUpdate.FlatAppearance.BorderColor = Color.Black;

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 1;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnBack.BackColor = Color.Transparent;
            btnBack.BackColor = Color.FromArgb(150, Color.White);
            btnBack.FlatAppearance.BorderColor = Color.Black;
        }

        private void Donor_management_Load(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectionString + DBFile);
            getRecords();
            myConnection.Open();

            using (OleDbCommand command = new OleDbCommand($"SELECT Item_Name FROM General_Items ORDER BY Item_name ASC", myConnection))
            {

                //whenever you want to get some data from the database
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbxItems.Items.Add(reader["Item_Name"].ToString());
                    }
                }
            }
            myConnection.Close();
            
        }

        public void getRecords() //Populates the datagridview with the data in the donations table
        {
            myConnection.Open();
            ds = new DataSet();
            adapter = new OleDbDataAdapter("SELECT * FROM [General_Donations]", myConnection);
            adapter.Fill(ds, "[General_Donations]");

            dgvDonorRecords.DataSource = ds.Tables[0];
            myConnection.Close();
        }

        private void Donor_management_Load_1(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            myConnection = new OleDbConnection(connectionString + DBFile);
            getRecords();
            myConnection.Open();

            using (OleDbCommand command = new OleDbCommand($"SELECT Item_Name FROM General_Items ORDER BY Item_name ASC", myConnection))
            {

                //whenever you want to get some data from the database
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbxItems.Items.Add(reader["Item_Name"].ToString());
                    }
                }
            }
            myConnection.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            myConnection.Open();
            DateTime donationDate = monthCalendar1.SelectionStart;

            if (cbxItems.SelectedItem == null)
            {
                MessageBox.Show("Please select an item name");
                myConnection.Close();
                return;
            }
            String itemName = cbxItems.SelectedItem.ToString();


            if (string.IsNullOrEmpty(tbxDonorName.Text.ToString()))
            {
                MessageBox.Show("Please insert a donor name");
                myConnection.Close();
                return;
            }
            String donorName = tbxDonorName.Text.ToString();


            if (cbxCategoryTypes.SelectedItem == null)
            {
                MessageBox.Show("Please select a category name");
                myConnection.Close();
                return;
            }
            String categoryType = cbxCategoryTypes.SelectedItem.ToString();

            int donationQuantity = Convert.ToInt32(nudQuantity.Value);
            if (donationQuantity < 0)
            {
                MessageBox.Show("Donation amount cannot be negative");
                myConnection.Close();
                return;
            }
            else if (donationQuantity == 0)
            {
                MessageBox.Show("Donation amount must be more than 0");
                myConnection.Close();
                return;
            }

            ds = new DataSet();
            adapter = new OleDbDataAdapter("INSERT into [General_Donations] ([Donor_Date],[Donor_Category],[Donor_Name],[Item_Name],[Qty_Received]) VALUES " + "('" + donationDate + "','" + categoryType + "','" + donorName + "','" + itemName + "','" + donationQuantity + "')", myConnection);
            adapter.Fill(ds, "General_Donations");
            OleDbCommand updateItems = new OleDbCommand($"UPDATE General_Items SET Stock_Level = Stock_Level+'" + donationQuantity + "' WHERE Item_Name = '" + itemName + "'", myConnection);
            updateItems.ExecuteNonQuery();
            myConnection.Close();
            nudQuantity.Value = 0;
            tbxDonorName.Clear();
            cbxCategoryTypes.SelectedIndex = -1;
            cbxItems.SelectedIndex = -1;
            getRecords();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            myConnection.Open();
            int i = dgvDonorRecords.CurrentRow.Index;
            currentID = dgvDonorRecords[0, i].Value.ToString();
            int donationQuantity = Convert.ToInt32(dgvDonorRecords[5, i].Value);
            string itemName = dgvDonorRecords[4, i].Value.ToString();

            ds = new DataSet();
            adapter = new OleDbDataAdapter("DELETE from [General_Donations] where Donor_ID = " + currentID, myConnection);
            adapter.Fill(ds, "General_Donations");
            OleDbCommand deleteItems = new OleDbCommand($"UPDATE General_Items SET Stock_Level = Stock_Level-'" + donationQuantity + "' WHERE Item_Name = '" + itemName + "'", myConnection);
            deleteItems.ExecuteNonQuery();
            myConnection.Close();
            nudQuantity.Value = 0;
            tbxDonorName.Clear();
            cbxCategoryTypes.SelectedIndex = -1;
            cbxItems.SelectedIndex = -1;
            getRecords();
        }

        private void BtnEdit_Click_1(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            int i = dgvDonorRecords.CurrentRow.Index;
            updateTemp = i;
            currentID = dgvDonorRecords[0, i].Value.ToString();

            if (cbxCategoryTypes.Items.Contains(dgvDonorRecords[2, i].Value.ToString()))
                cbxCategoryTypes.SelectedItem = dgvDonorRecords[2, i].Value.ToString();

            if (cbxItems.Items.Contains(dgvDonorRecords[4, i].Value.ToString()))
                cbxItems.SelectedItem = dgvDonorRecords[4, i].Value.ToString();

            tbxDonorName.Text = dgvDonorRecords[3, i].Value.ToString();
            nudQuantity.Value = Convert.ToInt32(dgvDonorRecords[5, i].Value);
            editCheck = true;
            btnUpdate.Visible = true;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (editCheck == false)
            {
                MessageBox.Show("You have to select a row to edit before you can update it");
                return;
            }
            myConnection.Open();
            int oldDonationQuantity = Convert.ToInt32(dgvDonorRecords[5, updateTemp].Value);
            DateTime donationDate = monthCalendar1.SelectionStart;

            if (string.IsNullOrEmpty(cbxItems.SelectedItem.ToString()))
            {
                MessageBox.Show("Please select an item name");
                myConnection.Close();
                return;
            }
            String itemName = cbxItems.SelectedItem.ToString();


            if (string.IsNullOrEmpty(tbxDonorName.Text.ToString()))
            {
                MessageBox.Show("Please insert a donor name");
                myConnection.Close();
                return;
            }
            String donorName = tbxDonorName.Text.ToString();


            if (string.IsNullOrEmpty(cbxCategoryTypes.SelectedItem.ToString()))
            {
                MessageBox.Show("Please select a category name");
                myConnection.Close();
                return;
            }
            String categoryType = cbxCategoryTypes.SelectedItem.ToString();

            int newDonationQuantity = Convert.ToInt32(nudQuantity.Value);
            if (newDonationQuantity < 0)
            {
                MessageBox.Show("Donation amount cannot be negative");
                myConnection.Close();
                return;
            }
            else if (newDonationQuantity == 0)
            {
                MessageBox.Show("Donation amount must be more than 0");
                myConnection.Close();
                return;
            }

            ds = new DataSet();
            adapter = new OleDbDataAdapter("update [General_Donations] set [Donor_Date] ='" + donationDate + "', [Donor_Category] ='" + categoryType + "',[Donor_Name] ='" + donorName + "',[Item_Name] = '" + itemName + "',[Qty_Received]='" + newDonationQuantity + "' where Donor_ID=" + currentID, myConnection);
            int temp = newDonationQuantity - oldDonationQuantity;
            adapter.Fill(ds, "General_Donations");
            OleDbCommand updateItems = new OleDbCommand($"UPDATE [General_Items] SET Stock_Level = Stock_Level+'" + temp + "' WHERE Item_Name = '" + itemName + "'", myConnection);
            updateItems.ExecuteNonQuery();
            myConnection.Close();
            nudQuantity.Value = 0;
            tbxDonorName.Clear();
            cbxCategoryTypes.SelectedIndex = -1;
            cbxItems.SelectedIndex = -1;
            editCheck = false;
            getRecords();
            btnEdit.Visible = true;
            btnUpdate.Visible = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Carebags myCarebags = new Carebags();
            myCarebags.Visible = true;
            Close();
        }
    }
}
