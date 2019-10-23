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
    public partial class Item_management : Form
    {
        private int stockCount;

        OleDbConnection myConnection;
        public string DBFile = Directory.GetCurrentDirectory() + "/CHOC.accdb";
        public string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source =";

        public Item_management()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            txtItemName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtItemName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtItemDescr.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtItemDescr.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtItemPrice.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtItemPrice.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtItemQTY.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtItemQTY.AutoCompleteSource = AutoCompleteSource.CustomSource;
            NamesAutoload();

            btnAddItems.FlatStyle = FlatStyle.Flat;
            btnAddItems.FlatAppearance.BorderSize = 1;
            btnAddItems.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnAddItems.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnAddItems.BackColor = Color.Transparent;
            btnAddItems.BackColor = Color.FromArgb(150, Color.White);
            btnAddItems.FlatAppearance.BorderColor = Color.Black;

            btnDeleteItems.FlatStyle = FlatStyle.Flat;
            btnDeleteItems.FlatAppearance.BorderSize = 1;
            btnDeleteItems.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnDeleteItems.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnDeleteItems.BackColor = Color.Transparent;
            btnDeleteItems.BackColor = Color.FromArgb(150, Color.White);
            btnDeleteItems.FlatAppearance.BorderColor = Color.Black;

            btnViewItems.FlatStyle = FlatStyle.Flat;
            btnViewItems.FlatAppearance.BorderSize = 1;
            btnViewItems.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnViewItems.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnViewItems.BackColor = Color.Transparent;
            btnViewItems.BackColor = Color.FromArgb(150, Color.White);
            btnViewItems.FlatAppearance.BorderColor = Color.Black;

            btnUpdateItems.FlatStyle = FlatStyle.Flat;
            btnUpdateItems.FlatAppearance.BorderSize = 1;
            btnUpdateItems.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnUpdateItems.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnUpdateItems.BackColor = Color.Transparent;
            btnUpdateItems.BackColor = Color.FromArgb(150, Color.White);
            btnUpdateItems.FlatAppearance.BorderColor = Color.Black;

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 1;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnBack.BackColor = Color.Transparent;
            btnBack.BackColor = Color.FromArgb(150, Color.White);
            btnBack.FlatAppearance.BorderColor = Color.Black;

        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {

            myConnection = new OleDbConnection(connectionString + DBFile);
            myConnection.Open();

            OleDbCommand cmd = new OleDbCommand($"SELECT Item_Name From General_Items WHERE Item_Name LIKE '%{txtItemName.Text}%'", myConnection);
            OleDbDataReader read = cmd.ExecuteReader();
            read.Read();
            if (read.HasRows)
            {
                MessageBox.Show("This item already exists, stock level has been updated");
                stockCount = StockLevel(stockCount) + int.Parse(txtItemQTY.Text);

                myConnection.Open();
                OleDbCommand cmdInsert = new OleDbCommand($"UPDATE General_Items SET Item_Name = '{txtItemName.Text}', Item_Description = '{txtItemDescr.Text}', Item_Price = '{txtItemPrice.Text}', Stock_Level = '{stockCount}' WHERE Item_Name = '{txtItemName.Text}'", myConnection);
                cmdInsert.ExecuteNonQuery();
            }
            else
            {
                read.Close();
                OleDbCommand cmdInsert = new OleDbCommand($"INSERT INTO General_Items (Item_Name, Item_Description, Item_Price, Stock_Level) VALUES('{txtItemName.Text}', '{txtItemDescr.Text}', '{txtItemPrice.Text}', '{txtItemQTY.Text}')", myConnection);
                cmdInsert.ExecuteNonQuery();
                txtItemName.Clear();
                txtItemDescr.Clear();
                txtItemPrice.Clear();
                txtItemQTY.Clear();
            }

            myConnection.Close();
            myConnection.ResetState();
            NamesAutoload();


        }

        private int StockLevel(int stockAmnt)
        {
            myConnection.Close();
            myConnection.Open();
            OleDbCommand cmdAmnt = new OleDbCommand($"SELECT Stock_Level From General_Items WHERE Item_Name LIKE '%{txtItemName.Text}%'", myConnection);
            OleDbDataReader read = cmdAmnt.ExecuteReader();
            read.Read();
            stockAmnt = int.Parse(read[0].ToString());
            myConnection.Close();
            return stockAmnt;

        }

        private void BtnUpdateItem_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectionString + DBFile);
            myConnection.Open();
            OleDbCommand cmd = new OleDbCommand($"SELECT Item_Name From General_Items WHERE Item_Name LIKE '%{txtItemName.Text}%'", myConnection);
            OleDbDataReader read = cmd.ExecuteReader();
            read.Read();
            if (read.HasRows)
            {

                OleDbCommand cmdInsert = new OleDbCommand($"UPDATE General_Items SET Item_Name = '{txtItemName.Text}', Item_Description = '{txtItemDescr.Text}', Item_Price = '{txtItemPrice.Text}', Stock_Level = '{txtItemQTY.Text}' WHERE Item_Name = '{txtItemName.Text}'", myConnection);
                cmdInsert.ExecuteNonQuery();
                read.Close();
                txtItemName.Clear();
                txtItemDescr.Clear();
                txtItemPrice.Clear();
                txtItemQTY.Clear();
            }
            else
            {
                MessageBox.Show("This item does not exist");

            }

            myConnection.Close();


        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectionString + DBFile);
            myConnection.Open();
            OleDbCommand cmd = new OleDbCommand($"SELECT Item_Name From General_Items WHERE Item_Name LIKE '%{txtItemName.Text}%'", myConnection);
            OleDbDataReader read = cmd.ExecuteReader();
            read.Read();
            if (read.HasRows)
            {

                OleDbCommand cmdDelete = new OleDbCommand($"DELETE FROM General_Items WHERE Item_Name = '{txtItemName.Text}'", myConnection);
                cmdDelete.ExecuteNonQuery();
                read.Close();
                txtItemName.Clear();
                txtItemDescr.Clear();
                txtItemPrice.Clear();
                txtItemQTY.Clear();
            }
            else
            {
                MessageBox.Show("This item does not exist");

            }

            myConnection.Close();
        }

        private void TxtItemName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Enter)
                    selectItem(sender);
            }


            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectItem(object sender)
        {
            // We use a substitute textbox so this method can be used both for update and delete
            try
            {

                TextBox t = (sender as TextBox);
                if (t.Text != "")
                {
                    myConnection.Open();
                    OleDbCommand cmd = new OleDbCommand($"SELECT * FROM General_Items WHERE Item_Name LIKE '%{t.Text}%'", myConnection);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (t.Name == "txtItemName")
                        {
                            txtItemName.Text = reader["Item_Name"].ToString();
                            txtItemDescr.Text = reader["Item_Description"].ToString();
                            txtItemPrice.Text = reader["Item_Price"].ToString();
                            txtItemQTY.Text = reader["Stock_Level"].ToString();
                        }

                    }

                    myConnection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string[] SuggestNames()
        {
            myConnection = new OleDbConnection(connectionString + DBFile);
            myConnection.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Item_Name FROM General_Items", myConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> names = new List<string>();
            while (reader.Read())
            {
                names.Add(reader[0].ToString());
            }
            myConnection.Close();
            if (names.Count > 0)
                return names.ToArray();
            else return null;
        }
        private void NamesAutoload()
        {

            // Load names into textboxes
            string[] arr = SuggestNames();

            if (arr != null)
            {
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                collection.AddRange(arr);

                txtItemName.AutoCompleteCustomSource = collection;
                txtItemDescr.AutoCompleteCustomSource = collection;
                txtItemPrice.AutoCompleteCustomSource = collection;
                txtItemQTY.AutoCompleteCustomSource = collection;
            }
        }

        private void Item_management_Load(object sender, EventArgs e)
        {

        }


        private void BtnViewItems_Click(object sender, EventArgs e)
        {
            All_Items_Form itemsForm = new All_Items_Form();
            itemsForm.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Carebags myCarebags = new Carebags();
            myCarebags.Visible = true;
            Close();
        }
    }
}
