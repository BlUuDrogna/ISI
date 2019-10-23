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
    public partial class DistributionManagement : Form
    {
        public string DBFile = Directory.GetCurrentDirectory() + "/General Products.mdb";
        public string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        OleDbConnection connecting;
        DataSet ds;
        OleDbDataAdapter adapter;


        public DistributionManagement()
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

            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.FlatAppearance.BorderSize = 1;
            btnLoad.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnLoad.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnLoad.BackColor = Color.Transparent;
            btnLoad.BackColor = Color.FromArgb(150, Color.White);
            btnLoad.FlatAppearance.BorderColor = Color.Black;

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



        public void getRecords()
        {
            connecting = new OleDbConnection(connectionString + DBFile);
            connecting.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connecting;
            string Query = "select * from General_Distribution ";
            command.CommandText = Query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            connecting.Close();
        }



        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getRecords();
            connecting.Open();
            DateTime donationDate = monthCalendar1.SelectionStart;

            if (string.IsNullOrEmpty(textDistributionName.Text.ToString()))
            {
                MessageBox.Show("Please insert a distibution name ");
                connecting.Close();
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please insert a Value");
                connecting.Close();
                return;
            }
            if (string.IsNullOrEmpty(textQuantityDistribution.Text.ToString()))
            {
                MessageBox.Show("Please insert a value");
                connecting.Close();
                return;
            }


            string DisName = textDistributionName.Text.ToString();
            string ItemName = comboBox1.SelectedItem.ToString();
            int Quantity = int.Parse(textQuantityDistribution.Text);

            using (OleDbCommand command = new OleDbCommand($"SELECT Stock_Level FROM General_Items WHERE Item_Name = '" + ItemName + "'", connecting))
            {


                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int Quantity2 = int.Parse(textQuantityDistribution.Text);
                        string test3 = reader["Stock_Level"].ToString();
                        int test4 = int.Parse(test3);
                        if (Quantity2 > test4)
                        {
                            MessageBox.Show("Not enough stock to do the distribution");
                            connecting.Close();
                            return;
                        }
                        else
                        {

                            ds = new DataSet();
                            adapter = new OleDbDataAdapter("INSERT into [General_Distribution] ([D_Date],[D_Name],[Item_Name],[D_Qty]) VALUES " + "('" + donationDate + "','" + DisName + "','" + ItemName + "','" + Quantity + "')", connecting);
                            adapter.Fill(ds, "General_Distribution");

                            OleDbCommand updateItems = new OleDbCommand($"UPDATE General_Items SET Stock_Level = Stock_Level-'" + Quantity + "' WHERE Item_Name = '" + ItemName + "'", connecting);
                            updateItems.ExecuteNonQuery();
                        }
                    }
                }
            }
            connecting.Close();
            getRecords();

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            getRecords();

        }

        private void DistributionManagement_Load(object sender, EventArgs e)
        {
            connecting = new OleDbConnection(connectionString + DBFile);
            getRecords();
            connecting.Open();

            using (OleDbCommand command = new OleDbCommand($"SELECT Item_Name FROM General_Items ORDER BY Item_name ASC", connecting))
            {


                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["Item_Name"].ToString());
                    }
                }
            }
            connecting.Close();
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            getRecords();
            connecting.Open();
            string DisName = textDistributionName.Text.ToString();


            using (OleDbCommand command = new OleDbCommand($"SELECT D_Qty FROM General_Distribution ", connecting))
            {


                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        textQuantityDistribution.Text = reader["D_Qty"].ToString();
                        string verander = textQuantityDistribution.Text;
                        OleDbCommand deleteItems = new OleDbCommand($"UPDATE General_Items SET Stock_Level = Stock_Level+'" + verander + "' WHERE Item_Name = '" + DisName + "'", connecting);
                        deleteItems.ExecuteNonQuery();

                    }
                }
            }


            OleDbCommand cmdDelete = new OleDbCommand($"DELETE FROM General_Distribution WHERE D_Name = '{textDistributionName.Text}'", connecting);
            cmdDelete.ExecuteNonQuery();


            getRecords();
            connecting.Close();
            getRecords();
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            connecting = new OleDbConnection(connectionString + DBFile);
            connecting.Open();
            OleDbCommand cmd = new OleDbCommand($"SELECT D_Name From General_Distribution WHERE D_Name LIKE '%{textDistributionName.Text}%'", connecting);
            OleDbDataReader read = cmd.ExecuteReader();
            DateTime donationDate = monthCalendar1.SelectionStart;
            read.Read();

            if (read.HasRows)
            {

                OleDbCommand cmdInsert = new OleDbCommand($"UPDATE General_Distribution SET D_Date = '{donationDate}', D_Name = '{textDistributionName.Text}', Item_Name = '{comboBox1.SelectedItem}', D_Qty = '{textQuantityDistribution.Text}' WHERE D_Name = '{textDistributionName.Text}'", connecting);
                cmdInsert.ExecuteNonQuery();
                read.Close();

            }
            else
            {
                MessageBox.Show("This item does not exist");

            }
            getRecords();
            connecting.Close();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Carebags myCarebags = new Carebags();
            myCarebags.Visible = true;
            Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
