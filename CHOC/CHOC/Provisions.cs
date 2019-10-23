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
using System.Globalization;

namespace CHOC
{
    public partial class Provisions : Form
    {
        string itemName;
        string itemDescrip;
        string sql = "";
        static string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProvisionsDB.mdb";
        //static string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProvisionsDB.mdb";
        OleDbConnection connect = new OleDbConnection(connection);
        int finalQty;

        string updsql;
        string selectsql;

        public Provisions()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            BtnAddToList.FlatStyle = FlatStyle.Flat;
            BtnAddToList.FlatAppearance.BorderSize = 1;
            BtnAddToList.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            BtnAddToList.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            BtnAddToList.BackColor = Color.Transparent;
            BtnAddToList.BackColor = Color.FromArgb(150, Color.White);
            BtnAddToList.FlatAppearance.BorderColor = Color.Black;

            btnCreateItem.FlatStyle = FlatStyle.Flat;
            btnCreateItem.FlatAppearance.BorderSize = 1;
            btnCreateItem.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnCreateItem.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnCreateItem.BackColor = Color.Transparent;
            btnCreateItem.BackColor = Color.FromArgb(150, Color.White);
            btnCreateItem.FlatAppearance.BorderColor = Color.Black;

            btnMonthlyReport.FlatStyle = FlatStyle.Flat;
            btnMonthlyReport.FlatAppearance.BorderSize = 1;
            btnMonthlyReport.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnMonthlyReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnMonthlyReport.BackColor = Color.Transparent;
            btnMonthlyReport.BackColor = Color.FromArgb(150, Color.White);
            btnMonthlyReport.FlatAppearance.BorderColor = Color.Black;

            btnReportAllStock.FlatStyle = FlatStyle.Flat;
            btnReportAllStock.FlatAppearance.BorderSize = 1;
            btnReportAllStock.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnReportAllStock.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnReportAllStock.BackColor = Color.Transparent;
            btnReportAllStock.BackColor = Color.FromArgb(150, Color.White);
            btnReportAllStock.FlatAppearance.BorderColor = Color.Black;

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 1;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnBack.BackColor = Color.Transparent;
            btnBack.BackColor = Color.FromArgb(150, Color.White);
            btnBack.FlatAppearance.BorderColor = Color.Black;

            metroButton2.FlatStyle = FlatStyle.Flat;
            metroButton2.FlatAppearance.BorderSize = 1;
            metroButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            metroButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            metroButton2.BackColor = Color.Transparent;
            metroButton2.BackColor = Color.FromArgb(150, Color.White);
            metroButton2.FlatAppearance.BorderColor = Color.Black;

            metroButton4.FlatStyle = FlatStyle.Flat;
            metroButton4.FlatAppearance.BorderSize = 1;
            metroButton4.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            metroButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            metroButton4.BackColor = Color.Transparent;
            metroButton4.BackColor = Color.FromArgb(150, Color.White);
            metroButton4.FlatAppearance.BorderColor = Color.Black;
        }

        public void addItemToDB(string itemName1, string itemDescr, double price, int quantity)
        {
            sql = "INSERT INTO Provisions_Current_Stock (Item_Name,Item_Description,Retail_Price,Stock_Level) VALUES ('" + itemName1 + "','" + itemDescr + "'," + price + "," + 0 + ")";


            OleDbCommand mang = new OleDbCommand(sql, connect);
            mang.ExecuteNonQuery();
            Current_List.Items.Add(" Item: " + itemName1 + " (" + itemDescr + ")" + " Quantity = " + quantity);
            MessageBox.Show("The Item has been Added successfully");

            sql = "SELECT Item_Name AS Name, Item_Description AS Description, Stock_Level AS Quantity FROM Provisions_Current_Stock";  //SQL command to display table in gridview1


            using (OleDbDataAdapter adapt = new OleDbDataAdapter(sql, connect))
            {
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.ReadOnly = true;
            }
        }



        private void Provisions_Load(object sender, EventArgs e)
        {

            sql = "SELECT Item_Name AS Name, Item_Description AS Description, Stock_Level AS Quantity FROM Provisions_Current_Stock";  //SQL command to display table in gridview1

            connect.ConnectionString = connection;
            connect.Open(); // open connection to database


            using (OleDbDataAdapter adapt = new OleDbDataAdapter(sql, connect))
            {
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.ReadOnly = true;
            }

            itemName = dataGridView1.Rows[0].Cells["Name"].FormattedValue.ToString();
            itemDescrip = dataGridView1.Rows[0].Cells["Description"].FormattedValue.ToString();
        }

        private void Provisions_FormClosed(object sender, FormClosedEventArgs e)
        {
            //close connection to database
            connect.Close();
        }

        private void BtnAddToList_Click_1(object sender, EventArgs e)
        {
            //Current_List.Items.Add(itemName + " quantity = " + numericUpDown1.Value);
            string toAdd = " Item: " + itemName + " (" + itemDescrip + ")";
            bool foundDup = false;

            for (int i = 0; i < Current_List.Items.Count; i++)
            {
                Current_List.SelectedIndex = i;
                string line = Current_List.Items[Current_List.SelectedIndex].ToString();
                line = line.Substring(0, line.IndexOf(")") + 1);
                //MessageBox.Show(line);

                if (toAdd == line)
                {
                    foundDup = true;
                    string line2 = Current_List.Items[Current_List.SelectedIndex].ToString();
                    int copiedQty = Convert.ToInt32(line2.Substring(line2.IndexOf('=') + 2)); //string manipulation to get the items quantity from string
                    //MessageBox.Show(copiedQty);
                    Current_List.Items.RemoveAt(i); // Remove items quantity from string

                    int newQty = copiedQty + Convert.ToInt32(numericUpDown1.Value); // add new numericUpDown1 value to current numericUpDown value

                    Current_List.Items.Add(toAdd + " Quantity = " + newQty);
                    break;
                }
            }

            if (foundDup == false)
            {
                Current_List.Items.Add(toAdd + " Quantity = " + numericUpDown1.Value);
            }



        }

        public void updateTables()
        {
            foreach (string lines in Current_List.Items)
            {
                finalQty = Convert.ToInt32(lines.Substring(lines.IndexOf('=') + 2));

                //MessageBox.Show(finalLine);
                string finItemName = lines.Substring(7, (lines.IndexOf("(") - 7) - 1);

                string finItemDescr = lines.Substring(lines.IndexOf('(') + 1, lines.IndexOf(')') - lines.IndexOf('(') - 1);


                //MessageBox.Show(finalQty.ToString());

                updsql = "UPDATE Provisions_Current_Stock SET Stock_Level = Provisions_Current_Stock.Stock_Level - " + finalQty + " WHERE Item_Name = '" + finItemName + "'AND Item_Description = '" + finItemDescr + "'";

                OleDbCommand mang2 = new OleDbCommand(updsql, connect);
                mang2.ExecuteNonQuery();
                //MessageBox.Show("The Item quantity have been successfully updated");

                selectsql = "SELECT Item_Name AS Name, Item_Description AS Description, Stock_Level AS Quantity FROM Provisions_Current_Stock";  //SQL command to display table in gridview1


                using (OleDbDataAdapter adapt = new OleDbDataAdapter(selectsql, connect))
                {
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.ReadOnly = true;
                }

                //MessageBox.Show(finItemName);
                //MessageBox.Show(finItemDescr);
            }



        }

        public void addtoInOutTable(string distType, string distName)
        {
            DateTime datetime = new DateTime();
            datetime = DateTime.Now;
            string inputType = "Distributed";
            sql = "INSERT INTO Provisions_In_Out(Date_Received, Stakeholder_Type, Stakeholder_Name, Input_Type) VALUES('" + datetime + "','" + distType + "','" + distName + "','" + inputType + "')";

            OleDbCommand mang3 = new OleDbCommand(sql, connect);
            //mang3.Parameters.AddWithValue("@date", DateTime.Now);
            mang3.ExecuteNonQuery();
            //MessageBox.Show("Provisions In Out table have been successfully updated");
        }

        public void addtoProvisionsSuppTable()
        {
            for (int i = 0; i < Current_List.Items.Count; i++)
            {
                Current_List.SelectedIndex = i;
                string finalLine = Current_List.Items[Current_List.SelectedIndex].ToString();
                finalQty = Convert.ToInt32(finalLine.Substring(finalLine.IndexOf('=') + 2)); //string manipulation to get the items quantity from string

                string finItemName = finalLine.Substring(7, (finalLine.IndexOf("(") - 7) - 1);

                string finItemDescr = finalLine.Substring(finalLine.IndexOf('(') + 1, finalLine.IndexOf(')') - finalLine.IndexOf('(') - 1);

                DateTime tempDT = DateTime.Now;
                DateTime datetime = new DateTime(tempDT.Year, tempDT.Month, tempDT.Day, tempDT.Hour, tempDT.Minute, tempDT.Second);

                string sql = "SELECT ID FROM Provisions_Current_Stock WHERE ( Item_Name = '" + finItemName + "' AND Item_Description = '" + finItemDescr + "')";

                string stockID;
                using (OleDbDataAdapter adapt = new OleDbDataAdapter(sql, connect))
                {
                    DataSet dstemp = new DataSet();
                    adapt.Fill(dstemp);

                    DataRow item = dstemp.Tables[0].Rows[0];
                    stockID = item["ID"].ToString();
                }

                string sql2 = "SELECT TOP 1 ID FROM Provisions_In_Out ORDER BY ID DESC";
                //string sql2 = "SELECT ID FROM Provisions_In_Out WHERE Date_Received = #" + datetime + "#";

                //MessageBox.Show(datetime.ToString());

                string inOut_ID;
                using (OleDbDataAdapter adapt = new OleDbDataAdapter(sql2, connect))
                {
                    OleDbCommandBuilder combuild = new OleDbCommandBuilder(adapt);
                    DataSet dstemp = new DataSet();
                    adapt.Fill(dstemp);

                    DataRow item2 = dstemp.Tables[0].Rows[0];
                    inOut_ID = item2["ID"].ToString();

                }

                //MessageBox.Show(inOut_ID);
                //MessageBox.Show(stockID);
                //MessageBox.Show(finalQty.ToString());

                string insertSQL = "INSERT INTO Provisions_Support_Table(Stock_ID, In_Out_ID, Quantity) VALUES(" + stockID + "," + inOut_ID + "," + finalQty + ")";

                OleDbCommand mang3 = new OleDbCommand(insertSQL, connect);
                mang3.ExecuteNonQuery();
                //MessageBox.Show("Provisions_Support_Table has been updated successfully");
                //MessageBox.Show("The Items have been removed from Provisions Inventory");
                //Current_List.Items.Clear();

            }
            Current_List.Items.Clear();
        }

        private void DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //get content of selected cells in the datagridview
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentCell.Selected = true;
                itemName = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                itemDescrip = dataGridView1.Rows[e.RowIndex].Cells["Description"].FormattedValue.ToString();
            }//end if statement

            lblname.Text = "Item Name: " + itemName;
        }

        private void MetroButton4_Click_1(object sender, EventArgs e)
        {
            ProvisionsDonor provDon = new ProvisionsDonor();
            provDon.Show();
            Visible = false;
        }

        private void MetroButton2_Click_1(object sender, EventArgs e)
        {
            Provisions_Out provOut = new Provisions_Out();
            provOut.Show();
            Visible = false;
        }

        private void BtnCreateItem_Click_1(object sender, EventArgs e)
        {
            Provisions_Create_Item createItem = new Provisions_Create_Item();
            createItem.Show();
            Visible = false;
        }

        //#################################################################################################
        public void addListBoxItemsToDB()
        {
            foreach (string lines in Current_List.Items)
            {
                finalQty = Convert.ToInt32(lines.Substring(lines.IndexOf('=') + 2));

                //MessageBox.Show(finalLine);
                string finItemName = lines.Substring(7, (lines.IndexOf("(") - 7) - 1);

                string finItemDescr = lines.Substring(lines.IndexOf('(') + 1, lines.IndexOf(')') - lines.IndexOf('(') - 1);


                //MessageBox.Show(finalQty.ToString());

                updsql = "UPDATE Provisions_Current_Stock SET Stock_Level = Provisions_Current_Stock.Stock_Level + " + finalQty + " WHERE Item_Name = '" + finItemName + "'AND Item_Description = '" + finItemDescr + "'";

                OleDbCommand mang2 = new OleDbCommand(updsql, connect);
                mang2.ExecuteNonQuery();
                //MessageBox.Show("The Item quantity have been successfully updated");

                selectsql = "SELECT Item_Name AS Name, Item_Description AS Description, Stock_Level AS Quantity FROM Provisions_Current_Stock";  //SQL command to display table in gridview1


                using (OleDbDataAdapter adapt = new OleDbDataAdapter(selectsql, connect))
                {
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.ReadOnly = true;
                }

                //MessageBox.Show(finItemName);
                //MessageBox.Show(finItemDescr);
            }
        }



        public void addDonerNameAndType(string donerType, string donerName)
        {
            DateTime datetime = new DateTime();
            datetime = DateTime.Now;
            string inputType = "Donation";
            sql = "INSERT INTO Provisions_In_Out(Date_Received, Stakeholder_Type, Stakeholder_Name, Input_Type) VALUES('" + datetime + "','" + donerType + "','" + donerName + "','" + inputType + "')";

            OleDbCommand addToDonerTable = new OleDbCommand(sql, connect);
            //mang3.Parameters.AddWithValue("@date", DateTime.Now);
            addToDonerTable.ExecuteNonQuery();
            //MessageBox.Show("Provisions In Out table have been successfully updated");
        }


        public void addToProvisionSupport()
        {
            for (int i = 0; i < Current_List.Items.Count; i++)
            {
                Current_List.SelectedIndex = i;
                string finalLine = Current_List.Items[Current_List.SelectedIndex].ToString();
                finalQty = Convert.ToInt32(finalLine.Substring(finalLine.IndexOf('=') + 2)); //string manipulation to get the items quantity from string
                //MessageBox.Show(finalQty.ToString());

                string finItemName = finalLine.Substring(7, (finalLine.IndexOf("(") - 7) - 1);

                string finItemDescr = finalLine.Substring(finalLine.IndexOf('(') + 1, finalLine.IndexOf(')') - finalLine.IndexOf('(') - 1);

                DateTime tempDT = DateTime.Now;
                DateTime datetime = new DateTime(tempDT.Year, tempDT.Month, tempDT.Day, tempDT.Hour, tempDT.Minute, tempDT.Second);

                string sql = "SELECT ID FROM Provisions_Current_Stock WHERE ( Item_Name = '" + finItemName + "' AND Item_Description = '" + finItemDescr + "')";

                string stockID;
                using (OleDbDataAdapter adapt = new OleDbDataAdapter(sql, connect))
                {
                    DataSet dstemp = new DataSet();
                    adapt.Fill(dstemp);

                    DataRow item = dstemp.Tables[0].Rows[0];
                    stockID = item["ID"].ToString();
                }

                //string sql2 = "SELECT ID FROM Provisions_In_Out WHERE Date_Received = #" + datetime + "#";
                string sql2 = "SELECT TOP 1 ID FROM Provisions_In_Out ORDER BY ID DESC";

                //MessageBox.Show(datetime.ToString());

                string inOut_ID;
                using (OleDbDataAdapter adapt = new OleDbDataAdapter(sql2, connect))
                {
                    OleDbCommandBuilder combuild = new OleDbCommandBuilder(adapt);
                    DataSet dstemp = new DataSet();
                    adapt.Fill(dstemp);

                    DataRow item2 = dstemp.Tables[0].Rows[0];
                    inOut_ID = item2["ID"].ToString();
                }

                //MessageBox.Show(inOut_ID);
                //MessageBox.Show(stockID);
                //MessageBox.Show(finalQty.ToString());

                string insertSQL = "INSERT INTO Provisions_Support_Table(Stock_ID, In_Out_ID, Quantity) VALUES(" + stockID + "," + inOut_ID + "," + finalQty + ")";

                OleDbCommand mang3 = new OleDbCommand(insertSQL, connect);
                mang3.ExecuteNonQuery();
                //MessageBox.Show("Provisions_Support_Table has been updated successfully");
                //MessageBox.Show("The Items have been Added to the Provisions Inventory");
            }

            Current_List.Items.Clear();
        }

        private void RadiobuttonAnyTime_Click(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Enabled = false;
            datetimePickerEndDate.Enabled = false;
        }

        private void RadiobtnSpecifyTime_Click(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Enabled = true;
            datetimePickerEndDate.Enabled = true;
        }

        private void RadiobtnAnyDonationCategory_Click(object sender, EventArgs e)
        {
            comboboxDonationCategory.Enabled = false;
            updateDonorInNames();
        }

        private void RadiobtnSpecificCategory_Click(object sender, EventArgs e)
        {
            comboboxDonationCategory.Enabled = true;
            updateDonorInNames();
        }

        private void RadiobtnAnyDonor_Click(object sender, EventArgs e)
        {
            comboboxSpecifyDonor.Enabled = false;
        }

        private void MetroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 1)
            {
                updateDonorInNames();
                updateDistributionNames();
                updateMonthsPresentInDB();
                comboboxDonationCategory.SelectedIndex = 0;
                comboboxDistributionCategory.SelectedIndex = 0;
            }
        }

        private void RbSpecifyDonor_Click(object sender, EventArgs e)
        {
            comboboxSpecifyDonor.Enabled = true;
        }

        private void ComboboxDonationCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDonorInNames();
        }

        private void RbAllTimeOut_Click(object sender, EventArgs e)
        {
            datetimePickerEndOut.Enabled = false;
            dateTimePickerStartOut.Enabled = false;
        }

        private void RbApecifyTimeOut_Click(object sender, EventArgs e)
        {
            datetimePickerEndOut.Enabled = true;
            dateTimePickerStartOut.Enabled = true;
        }

        private void RbAnyCategoryOut_Click(object sender, EventArgs e)
        {
            comboboxDistributionCategory.Enabled = false;
            updateDistributionNames();
        }

        private void RbSpecifyCategoryOut_Click(object sender, EventArgs e)
        {
            comboboxDistributionCategory.Enabled = true;
            updateDistributionNames();
        }

        private void ComboboxDistributionCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDistributionNames();
        }

        private void RbAnyDonorOut_Click(object sender, EventArgs e)
        {
            comboboxDistributionName.Enabled = false;
        }

        private void RbSpecifyDonorOut_Click(object sender, EventArgs e)
        {
            comboboxDistributionName.Enabled = true;
        }

        public class MonthAndYear
        {
            public int Month { get; set; }
            public string Year { get; set; }
        }

        private void updateMonthsPresentInDB()
        {
            var l = new List<MonthAndYear>();

            comboboxMonthlyReport.Items.Clear();
            sql = "SELECT DISTINCT Month(io.Date_Received) AS inMonth, Year(io.Date_Received) AS inYear" +
                " FROM Provisions_In_Out io";

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connect))
            {
                DataSet dstemp = new DataSet();
                adapter.Fill(dstemp);

                foreach (DataRow c in dstemp.Tables[0].Rows)
                {
                    l.Add(new MonthAndYear() { Month = int.Parse(c["inMonth"].ToString()), Year = c["inYear"].ToString() });
                }
            }

            MonthAndYear[] sorted = l.OrderByDescending(f => f.Year).ThenByDescending(i => i.Month).ToArray();
            for (int I = 0; I < sorted.Length; I++)
            {
                string line = "";

                line = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(sorted[I].Month);
                line += "   " + sorted[I].Year;

                comboboxMonthlyReport.Items.Add(line);
            }

            if (comboboxMonthlyReport.Items.Count != 0)
            {
                comboboxMonthlyReport.SelectedIndex = 0;
            }
        }

        private void updateDonorInNames()
        {
            comboboxSpecifyDonor.Items.Clear();
            if (radiobtnAnyDonationCategory.Checked == true)
            {
                comboboxSpecifyDonor.Items.Clear();
                sql = "SELECT DISTINCT Stakeholder_Name FROM Provisions_In_Out pi WHERE pi.Input_Type = 'Donation' ORDER BY Stakeholder_Name ASC";

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connect))
                {
                    DataSet dstemp = new DataSet();
                    adapter.Fill(dstemp);

                    foreach (DataRow c in dstemp.Tables[0].Rows)
                    {
                        comboboxSpecifyDonor.Items.Add(c["Stakeholder_Name"].ToString());
                    }
                }
            }
            else
            {
                comboboxSpecifyDonor.Items.Clear();
                sql = "SELECT DISTINCT Stakeholder_Name FROM Provisions_In_Out pi WHERE (pi.Input_Type = 'Donation' AND pi.Stakeholder_Type = '" + comboboxDonationCategory.Text + "') ORDER BY Stakeholder_Name ASC";

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connect))
                {
                    DataSet dstemp = new DataSet();
                    adapter.Fill(dstemp);

                    foreach (DataRow c in dstemp.Tables[0].Rows)
                    {
                        comboboxSpecifyDonor.Items.Add(c["Stakeholder_Name"].ToString());
                    }
                }
            }
            if (comboboxSpecifyDonor.Items.Count != 0)
            {
                comboboxSpecifyDonor.SelectedIndex = 0;
            }
        }

        private void BtnGenerateReceivedReport_Click(object sender, EventArgs e)
        {
            Provisions_Report reportPage = new Provisions_Report();

            sql = "SELECT io.ID, io.Date_Received, io.Stakeholder_Type, io.Stakeholder_Name" +
                " FROM Provisions_In_Out io" +
                " WHERE(io.Input_Type = 'Donation'";

            if (radiobtnSpecifyTime.Checked == true)
            {
                DateTime strt = new DateTime();
                strt = dateTimePickerStartDate.Value;
                string strtDate = strt.ToString("yyyy/MM/dd 00:00:00");

                strt = datetimePickerEndDate.Value;
                string endDateOut = strt.ToString("yyyy/MM/dd 23:59:59");

                sql += " AND io.Date_Received >= #" + strtDate + "# AND io.Date_Received <= #" + endDateOut + "#";
            }

            if (radiobtnSpecificCategory.Checked == true)
            {
                sql += " AND Stakeholder_Type = '" + comboboxDonationCategory.Text + "'";
            }

            if (rbSpecifyDonor.Checked == true)
            {
                sql += " AND Stakeholder_Name = '" + comboboxSpecifyDonor.Text + "'";
            }

            sql += ") ORDER BY Date_Received ASC";

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connect))
            {
                DataSet dstemp = new DataSet();
                adapter.Fill(dstemp);
                string reportHeading = "Report on Donations";

                if (radiobtnSpecificCategory.Checked == true)
                {
                    if (rbSpecifyDonor.Checked == true)
                    {
                        reportHeading += " from " + comboboxSpecifyDonor.Text + " (Donor Type: " + comboboxDonationCategory.Text + ")";
                    }
                    else
                    {
                        reportHeading += " from Donation Type " + comboboxDonationCategory.Text;
                    }
                }
                else if (rbSpecifyDonor.Checked == true)
                {
                    DataRow temp;
                    temp = dstemp.Tables[0].Rows[0];
                    reportHeading += " from " + comboboxSpecifyDonor.Text + " (Donor Type: " + temp["Stakeholder_Type"].ToString() + ")";
                }
                reportPage.addItem(reportHeading);

                if (radiobtnSpecifyTime.Checked == true)
                {
                    reportPage.addItem("   Between " + dateTimePickerStartDate.Text + " and " + datetimePickerEndDate.Text);
                }
                reportPage.addItem("");

                foreach (DataRow c in dstemp.Tables[0].Rows)
                {
                    reportPage.addItem("__________________________________________________________");
                    string add = "Donation By " + c["Stakeholder_Name"].ToString() + " (Donor Type: " + c["Stakeholder_Type"].ToString() + ")";
                    reportPage.addItem(add);
                    string line = c["Date_Received"].ToString();
                    add = "Date: " + line.Substring(0, line.IndexOf(" "));
                    reportPage.addItem(add);
                    reportPage.addItem("Items:");
                    int itemID = int.Parse(c["ID"].ToString());

                    string inSQL = "SELECT cs.Item_Name, cs.Item_Description, cs.Retail_Price, st.Quantity" +
                    " FROM Provisions_Support_Table st, Provisions_Current_Stock cs" +
                    " WHERE ((cs.ID = st.Stock_ID) AND (In_Out_ID = " + itemID + "))";

                    using (OleDbDataAdapter itemAdapter = new OleDbDataAdapter(inSQL, connect))
                    {
                        DataSet dsItems = new DataSet();
                        itemAdapter.Fill(dsItems);
                        double donationWorth = 0.0;

                        foreach (DataRow item in dsItems.Tables[0].Rows)
                        {
                            double quantity = double.Parse(item["Quantity"].ToString());
                            double worthPerItem = double.Parse(item["Retail_Price"].ToString());
                            double itemTotalWorth = quantity * worthPerItem;
                            donationWorth += itemTotalWorth;
                            string inAdd = "\t" + item["Item_Name"].ToString() + " (" + item["Item_Description"] + ") * " + item["Quantity"].ToString() + "\t(Worth R" + itemTotalWorth + ")";
                            reportPage.addItem(inAdd);
                        }
                        reportPage.addItem("Total Worth of Donation: R" + donationWorth);

                    }

                    reportPage.addItem("");
                }
            }

            reportPage.ShowDialog();
        }

        private void updateDistributionNames()
        {
            comboboxDistributionName.Items.Clear();
            if (rbAnyCategoryOut.Checked == true)
            {
                sql = "SELECT DISTINCT Stakeholder_Name FROM Provisions_In_Out pi WHERE pi.Input_Type = 'Distributed' ORDER BY Stakeholder_Name ASC";

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connect))
                {
                    DataSet dstemp = new DataSet();
                    adapter.Fill(dstemp);

                    foreach (DataRow c in dstemp.Tables[0].Rows)
                    {
                        comboboxDistributionName.Items.Add(c["Stakeholder_Name"].ToString());
                    }
                }
            }
            else
            {
                comboboxDistributionName.Items.Clear();
                sql = "SELECT DISTINCT Stakeholder_Name FROM Provisions_In_Out pi WHERE (pi.Input_Type = 'Distributed' AND pi.Stakeholder_Type = '" + comboboxDistributionCategory.Text + "') ORDER BY Stakeholder_Name ASC";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connect))
                {
                    DataSet dstemp = new DataSet();
                    adapter.Fill(dstemp);

                    foreach (DataRow c in dstemp.Tables[0].Rows)
                    {
                        comboboxDistributionName.Items.Add(c["Stakeholder_Name"].ToString());
                    }
                }
            }
            if (comboboxDistributionName.Items.Count != 0)
            {
                comboboxDistributionName.SelectedIndex = 0;
            }
        }

        private void BtnGenerateDistributedReport_Click(object sender, EventArgs e)
        {
            Provisions_Report reportPage = new Provisions_Report();

            sql = "SELECT io.ID, io.Date_Received, io.Stakeholder_Type, io.Stakeholder_Name" +
                " FROM Provisions_In_Out io" +
                " WHERE(io.Input_Type = 'Distributed'";

            if (rbApecifyTimeOut.Checked == true)
            {
                DateTime strt = new DateTime();
                strt = dateTimePickerStartOut.Value;
                string strtDate = strt.ToString("yyyy/MM/dd 00:00:00");

                strt = datetimePickerEndOut.Value;
                string endDateOut = strt.ToString("yyyy/MM/dd 23:59:59");

                sql += " AND io.Date_Received >= #" + strtDate + "# AND io.Date_Received <= #" + endDateOut + "#";
            }

            if (rbSpecifyCategoryOut.Checked == true)
            {
                sql += " AND Stakeholder_Type = '" + comboboxDistributionCategory.Text + "'";
            }

            if (rbSpecifyDonorOut.Checked == true)
            {
                sql += " AND Stakeholder_Name = '" + comboboxDistributionName.Text + "'";
            }

            sql += ") ORDER BY Date_Received ASC";

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connect))
            {
                DataSet dstemp = new DataSet();
                adapter.Fill(dstemp);

                string reportHeading = "Report on Distributions";

                if (rbSpecifyCategoryOut.Checked == true)
                {
                    if (rbSpecifyDonorOut.Checked == true)
                    {
                        reportHeading += " to " + comboboxDistributionName.Text + " (Distribution Type: " + comboboxDistributionCategory.Text + ")";
                    }
                    else
                    {
                        reportHeading += " to Distribution Type " + comboboxDistributionCategory.Text;
                    }
                }
                else if (rbSpecifyDonorOut.Checked == true)
                {
                    DataRow temp;
                    temp = dstemp.Tables[0].Rows[0];
                    reportHeading += " to " + comboboxDistributionName.Text + " (Distribution Type: " + temp["Stakeholder_Type"].ToString() + ")";
                }
                reportPage.addItem(reportHeading);

                if (rbApecifyTimeOut.Checked == true)
                {
                    reportPage.addItem("   Between " + dateTimePickerStartOut.Text + " and " + datetimePickerEndOut.Text);
                }
                reportPage.addItem("");





                foreach (DataRow c in dstemp.Tables[0].Rows)
                {
                    reportPage.addItem("__________________________________________________________");
                    string add = "Distributed To " + c["Stakeholder_Name"].ToString() + " (Distribution Type: " + c["Stakeholder_Type"] + ")";
                    reportPage.addItem(add);
                    string line = c["Date_Received"].ToString();
                    add = "Date: " + line.Substring(0, line.IndexOf(" "));
                    reportPage.addItem(add);
                    reportPage.addItem("Items:");
                    int itemID = int.Parse(c["ID"].ToString());

                    string inSQL = "SELECT cs.Item_Name, cs.Item_Description, cs.Retail_Price, st.Quantity" +
                    " FROM Provisions_Support_Table st, Provisions_Current_Stock cs" +
                    " WHERE ((cs.ID = st.Stock_ID) AND (In_Out_ID = " + itemID + "))";

                    using (OleDbDataAdapter itemAdapter = new OleDbDataAdapter(inSQL, connect))
                    {
                        DataSet dsItems = new DataSet();
                        itemAdapter.Fill(dsItems);
                        double donationWorth = 0.0;

                        foreach (DataRow item in dsItems.Tables[0].Rows)
                        {
                            double quantity = double.Parse(item["Quantity"].ToString());
                            double worthPerItem = double.Parse(item["Retail_Price"].ToString());
                            double itemTotalWorth = quantity * worthPerItem;
                            donationWorth += itemTotalWorth;
                            string inAdd = "\t" + item["Item_Name"].ToString() + " (" + item["Item_Description"] + ")\t* " + item["Quantity"].ToString() + "\t(Worth R" + itemTotalWorth + ")";
                            reportPage.addItem(inAdd);
                        }
                        reportPage.addItem("Total Worth of Distribution: R" + donationWorth);
                    }
                    reportPage.addItem("");
                }
            }

            reportPage.ShowDialog();
        }

        private void BtnReportAllStock_Click(object sender, EventArgs e)
        {
            Provisions_Report reportPage = new Provisions_Report();
            reportPage.addItem("Report on Provisions Stock on Hand");
            reportPage.addItem("   On " + DateTime.Now.ToString("yyyy/MM/dd"));

            string inSQL = "SELECT Item_Name, Item_Description, Retail_Price, Stock_Level" +
                " From Provisions_Current_Stock ORDER BY Item_Name ASC";


            reportPage.addItem("__________________________________________________________");

            using (OleDbDataAdapter itemAdapter = new OleDbDataAdapter(inSQL, connect))
            {
                DataSet dsItems = new DataSet();
                itemAdapter.Fill(dsItems);

                foreach (DataRow item in dsItems.Tables[0].Rows)
                {
                    double quantity = double.Parse(item["Stock_Level"].ToString());
                    double worthPerItem = double.Parse(item["Retail_Price"].ToString());
                    double itemTotalWorth = quantity * worthPerItem;

                    reportPage.addItem(item["Item_Name"].ToString() + " (" + item["Item_Description"] + ") | Total Value : R" + itemTotalWorth);
                    reportPage.addItem("\tStock Level: " + quantity);
                    reportPage.addItem("\tRetail Price: R" + worthPerItem);
                    reportPage.addItem("");
                }

            }
            reportPage.Show();
        }

        private void BtnMonthlyReport_Click(object sender, EventArgs e)
        {
            Provisions_Report reportPage = new Provisions_Report();
            reportPage.addItem("Monthly report of " + comboboxMonthlyReport.Text);

            sql = "SELECT io.ID, io.Date_Received, io.Stakeholder_Type, io.Stakeholder_Name, Input_Type" +
                " FROM Provisions_In_Out io" +
                " WHERE(";

            string inputDate = comboboxMonthlyReport.Text;
            string monthname = inputDate.Substring(0, inputDate.IndexOf(" "));


            int yearNr = int.Parse(inputDate.Substring(inputDate.LastIndexOf(" ") + 1));
            int iMonthNo = Convert.ToDateTime("01-" + monthname + "-2011").Month;
            int dayCount = DateTime.DaysInMonth(yearNr, iMonthNo);

            DateTime strt = new DateTime(yearNr, iMonthNo, 1);
            DateTime endd = new DateTime(yearNr, iMonthNo, dayCount);

            string strtDate = strt.ToString("yyyy/MM/dd 00:00:00");
            string endDateOut = endd.ToString("yyyy/MM/dd 23:59:59");

            sql += " io.Date_Received >= #" + strtDate + "# AND io.Date_Received <= #" + endDateOut + "#";
            sql += ") ORDER BY Date_Received ASC";

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connect))
            {
                DataSet dstemp = new DataSet();
                adapter.Fill(dstemp);

                foreach (DataRow c in dstemp.Tables[0].Rows)
                {
                    reportPage.addItem("__________________________________________________________");
                    string add = "";
                    if (c["Input_Type"].ToString() == "Distributed")
                    {
                        add += "Distributed To ";
                    }
                    else
                    {
                        add += "Donation From ";
                    }

                    add += c["Stakeholder_Name"].ToString() + " (Distribution Type: " + c["Stakeholder_Type"].ToString() + ")";
                    reportPage.addItem(add);
                    string line = c["Date_Received"].ToString();
                    add = "Date: " + line.Substring(0, line.IndexOf(" "));
                    reportPage.addItem(add);
                    reportPage.addItem("Items:");
                    int itemID = int.Parse(c["ID"].ToString());

                    string inSQL = "SELECT cs.Item_Name, cs.Item_Description, cs.Retail_Price, st.Quantity" +
                    " FROM Provisions_Support_Table st, Provisions_Current_Stock cs" +
                    " WHERE ((cs.ID = st.Stock_ID) AND (In_Out_ID = " + itemID + "))";

                    using (OleDbDataAdapter itemAdapter = new OleDbDataAdapter(inSQL, connect))
                    {
                        DataSet dsItems = new DataSet();
                        itemAdapter.Fill(dsItems);
                        double donationWorth = 0.0;

                        foreach (DataRow item in dsItems.Tables[0].Rows)
                        {
                            double quantity = double.Parse(item["Quantity"].ToString());
                            double worthPerItem = double.Parse(item["Retail_Price"].ToString());
                            double itemTotalWorth = quantity * worthPerItem;
                            donationWorth += itemTotalWorth;
                            string inAdd = "\t" + item["Item_Name"].ToString() + " (" + item["Item_Description"] + ")\t* " + item["Quantity"].ToString() + "\t(Worth R" + itemTotalWorth + ")";

                            reportPage.addItem(inAdd);
                        }
                        reportPage.addItem("Total Worth of Distribution: R" + donationWorth);

                    }

                    reportPage.addItem("");
                }
            }

            reportPage.ShowDialog();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Inventory myInventory = new Inventory();
            myInventory.Visible = true;
            Close();
        }

        private void MetroTabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddToList_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreateItem_Click(object sender, EventArgs e)
        {

        }

        private void Lblname_Click(object sender, EventArgs e)
        {

        }
    }
}
