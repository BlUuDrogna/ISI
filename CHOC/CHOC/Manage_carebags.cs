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
    public partial class CarebagManagement : Form
    {
        OleDbConnection myConnection;
        public string DBFile = Directory.GetCurrentDirectory() + "/CHOC.accdb";
        public string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source =";
        public int globalCounter = 0;
        public object[] ItemArr;
        public int totalAvailable = 0;
        public const string carebag = "Carebags";

        public CarebagManagement()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.FlatAppearance.BorderSize = 1;
            btnAddItem.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnAddItem.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnAddItem.BackColor = Color.Transparent;
            btnAddItem.BackColor = Color.FromArgb(150, Color.White);
            btnAddItem.FlatAppearance.BorderColor = Color.Black;

            btnRemoveItem.FlatStyle = FlatStyle.Flat;
            btnRemoveItem.FlatAppearance.BorderSize = 1;
            btnRemoveItem.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnRemoveItem.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnRemoveItem.BackColor = Color.Transparent;
            btnRemoveItem.BackColor = Color.FromArgb(150, Color.White);
            btnRemoveItem.FlatAppearance.BorderColor = Color.Black;

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

        private void ManageCBBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ItemArr = new object[listView1.Items.Count];
                listView1.Items.CopyTo(ItemArr, 0);
                myConnection.Open();


                for (int i = 0; i < ItemArr.Length; i++)
                {

                    string itemName = (listView1.Items[i].SubItems[0].Text);
                    int qty = int.Parse(listView1.Items[i].SubItems[1].Text);
                    int totalQty = int.Parse(listView1.Items[i].SubItems[2].Text);

                    if ((qty * int.Parse(txtCBNum.Text) > totalQty))
                    {

                        throw new Exception("Insufficient " + itemName + " to create a carebag");
                    }
                    else
                    {
                        OleDbCommand cmd = new OleDbCommand($"UPDATE General_Items SET Stock_Level = Stock_Level - " + (qty * int.Parse(txtCBNum.Text)) + " WHERE Item_Name = '" + itemName + "'", myConnection);
                        cmd.ExecuteNonQuery();
                    }
                }
                myConnection.Close();

                myConnection.Open();
                //assumes that carebags are already in existance in the DB
                OleDbCommand cmdUpdate = new OleDbCommand($"UPDATE General_Items SET Stock_Level = Stock_Level + " + (int.Parse(txtCBNum.Text)) + " WHERE Item_Name = '" + carebag + "'", myConnection);
                cmdUpdate.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Carebags Successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //this.Close();
                clearAll();
            }
            catch (Exception ex)
            {
                myConnection.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Carebags myCarebags = new Carebags();
            myCarebags.Visible = true;
            Close();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    cbxItemQty.Show();
                    label3.Show();
                }
                else
                {
                    cbxItemQty.Hide();
                    label3.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbxItemQty.Items.Clear();
                myConnection.Open();
                var level = "";
                using (OleDbCommand command = new OleDbCommand($@"SELECT Stock_Level FROM General_Items WHERE Item_Name = '" + cbxItems.SelectedItem + "'", myConnection))
                {

                    //whenever you want to get some data from the database
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            level = (reader["Stock_level"].ToString());

                        }
                    }
                }
                myConnection.Close();
                int levelQty = int.Parse(level);
                totalAvailable = levelQty;

                for (int i = 0; i <= levelQty; i++)
                {
                    cbxItemQty.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                var itemQty = "1";
                var item = cbxItems.SelectedItem.ToString();

                if (checkBox1.Checked)
                {
                    itemQty = cbxItemQty.SelectedItem.ToString();
                }

                ListViewItem lvi = new ListViewItem(item.ToString());
                lvi.SubItems.Add(itemQty.ToString());
                lvi.SubItems.Add(totalAvailable.ToString());
                listView1.Items.Add(lvi);
                globalCounter++;
                cbxItems.Text = "";
                cbxItemQty.Text = "";
                checkBox1.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.SelectedItems[0].Remove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Constructormethod()
        {
            cbxItemQty.Items.Clear();
            cbxItems.Items.Clear();
            label3.Hide();
            cbxItemQty.Hide();
            myConnection = new OleDbConnection(connectionString + DBFile);
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
        public void clearAll()
        {
            cbxItemQty.Items.Clear();
            cbxItems.Text = "";
            checkBox1.Checked = false;
            listView1.Items.Clear();
            txtCBNum.Text = null;
        }

    }
}

