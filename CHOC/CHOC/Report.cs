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
    public partial class Report : Form
    {
        public string DBFile;
        public OleDbConnection myDB;
        public string conn = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=";
        string path = "";
        string varC = "Distribution";
        public Report()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            btnDistReport.FlatStyle = FlatStyle.Flat;
            btnDistReport.FlatAppearance.BorderSize = 1;
            btnDistReport.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnDistReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnDistReport.BackColor = Color.Transparent;
            btnDistReport.BackColor = Color.FromArgb(150, Color.White);
            btnDistReport.FlatAppearance.BorderColor = Color.Black;

            btnDonReport.FlatStyle = FlatStyle.Flat;
            btnDonReport.FlatAppearance.BorderSize = 1;
            btnDonReport.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnDonReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnDonReport.BackColor = Color.Transparent;
            btnDonReport.BackColor = Color.FromArgb(150, Color.White);
            btnDonReport.FlatAppearance.BorderColor = Color.Black;

            btnItemB.FlatStyle = FlatStyle.Flat;
            btnItemB.FlatAppearance.BorderSize = 1;
            btnItemB.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnItemB.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnItemB.BackColor = Color.Transparent;
            btnItemB.BackColor = Color.FromArgb(150, Color.White);
            btnItemB.FlatAppearance.BorderColor = Color.Black;

            btnItemDon.FlatStyle = FlatStyle.Flat;
            btnItemDon.FlatAppearance.BorderSize = 1;
            btnItemDon.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnItemDon.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnItemDon.BackColor = Color.Transparent;
            btnItemDon.BackColor = Color.FromArgb(150, Color.White);
            btnItemDon.FlatAppearance.BorderColor = Color.Black;

            btnLeastPop.FlatStyle = FlatStyle.Flat;
            btnLeastPop.FlatAppearance.BorderSize = 1;
            btnLeastPop.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnLeastPop.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnLeastPop.BackColor = Color.Transparent;
            btnLeastPop.BackColor = Color.FromArgb(150, Color.White);
            btnLeastPop.FlatAppearance.BorderColor = Color.Black;

            btnPerDon.FlatStyle = FlatStyle.Flat;
            btnPerDon.FlatAppearance.BorderSize = 1;
            btnPerDon.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnPerDon.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnPerDon.BackColor = Color.Transparent;
            btnPerDon.BackColor = Color.FromArgb(150, Color.White);
            btnPerDon.FlatAppearance.BorderColor = Color.Black;

            btnPerItem.FlatStyle = FlatStyle.Flat;
            btnPerItem.FlatAppearance.BorderSize = 1;
            btnPerItem.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, Color.White);
            btnPerItem.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, Color.White);
            btnPerItem.BackColor = Color.Transparent;
            btnPerItem.BackColor = Color.FromArgb(150, Color.White);
            btnPerItem.FlatAppearance.BorderColor = Color.Black;

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

        private void button3_Click(object sender, EventArgs e)
        {
            myDB.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT M.Merchandise_name, Count(*) AS [# of Transactions], Sum(D.Quantity) AS [Amount of items out], Sum(D.Quantity*M.Merchandise_retail_price) AS [Total amount in Rand]" +
                                                            "FROM Distribution AS D INNER JOIN Merchandise AS M ON D.Merchandise_ID = M.Merchandise_ID " +
                                                            "WHERE ((D.Merchandise_ID) Is Not Null) " +
                                                            "AND (D.Distribution_Date BETWEEN DateSerial(Year(Date()), Month(Date())-1, 1) AND DateSerial(Year(Date()), Month(Date()), 0)) " +
                                                            "GROUP BY M.Merchandise_name; ", myDB);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "List");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "List";
            myDB.Close();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Merchandise_Branding myMerchBrand = new Merchandise_Branding();
            myMerchBrand.Visible = true;
            Close();
        }

        private void BtnDistReport_Click(object sender, EventArgs e)
        {
            varC = "Distribution";

            myDB.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Distribution", myDB);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "List");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "List";
            myDB.Close();

            label1.Text = varC;
        }

        private void BtnDonReport_Click(object sender, EventArgs e)
        {
            varC = "Donations";

            myDB.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Donations", myDB);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "List");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "List";
            myDB.Close();

            label1.Text = varC;
        }

        private void BtnPerItem_Click(object sender, EventArgs e)
        {
            string time_period = "";

            if (rbtnMonth.Checked == true)
            {
                time_period = "DateSerial(Year(Date()), Month(Date()) - 1, 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }
            else if (rbtn3Months.Checked == true)
            {
                time_period = "DateSerial(Year(Date()), Month(Date()) - 3, 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }
            else if (rbtnYear.Checked == true)
            {
                time_period = "DateSerial(Year(Date())-1, Month(Date()), 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }

            myDB.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT M.Merchandise_name, Count(*) AS [# of Transactions], Sum(D.Quantity) AS [Amount of items out], Sum(D.Quantity*M.Merchandise_retail_price) AS [Total amount in Rand]" +
                                                            "FROM Distribution AS D INNER JOIN Merchandise AS M ON D.Merchandise_ID = M.Merchandise_ID " +
                                                            "WHERE ((D.Merchandise_ID) Is Not Null) " +
                                                            "AND (D.Distribution_Date BETWEEN " + time_period + " ) " +
                                                            "GROUP BY M.Merchandise_name " +
                                                            "ORDER BY Sum(D.Quantity);", myDB);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "List");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "List";
            myDB.Close();
        }

        private void BtnPerDon_Click(object sender, EventArgs e)
        {
            string time_period = "";

            if (rbtnMonth.Checked == true)
            {
                time_period = "DateSerial(Year(Date()), Month(Date()) - 1, 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }
            else if (rbtn3Months.Checked == true)
            {
                time_period = "DateSerial(Year(Date()), Month(Date()) - 3, 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }
            else if (rbtnYear.Checked == true)
            {
                time_period = "DateSerial(Year(Date())-1, Month(Date()), 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }

            myDB.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT D.Distribution_Name, M.Merchandise_name, Count(*) AS [# of Transactions], Sum(D.Quantity) AS [Amount of items out], Sum(D.Quantity*M.Merchandise_retail_price) AS [Total amount in Rand]" +
                                                            "FROM Distribution AS D INNER JOIN Merchandise AS M ON D.Merchandise_ID = M.Merchandise_ID " +
                                                            "WHERE ((D.Merchandise_ID) Is Not Null) " +
                                                            "AND (D.Distribution_Date BETWEEN " + time_period + " ) " +
                                                            "GROUP BY M.Merchandise_name, D.Distribution_Name " +
                                                            "ORDER BY D.Distribution_Name, Sum(D.Quantity);", myDB);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "List");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "List";
            myDB.Close();
        }

        private void BtnPopItem_Click(object sender, EventArgs e)
        {
            string time_period = "";

            if (rbtnMonth.Checked == true)
            {
                time_period = "DateSerial(Year(Date()), Month(Date()) - 1, 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }
            else if (rbtn3Months.Checked == true)
            {
                time_period = "DateSerial(Year(Date()), Month(Date()) - 3, 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }
            else if (rbtnYear.Checked == true)
            {
                time_period = "DateSerial(Year(Date())-1, Month(Date()), 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }

            myDB.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT M.Merchandise_name, Count(*) AS [# of Transactions], Sum(D.Quantity) AS [Amount of items out] " +
                                                            "FROM Distribution AS D INNER JOIN Merchandise AS M ON D.Merchandise_ID = M.Merchandise_ID " +
                                                            "WHERE ((D.Merchandise_ID) Is Not Null) " +
                                                            "AND (D.Distribution_Date BETWEEN " + time_period + " ) " +
                                                            "GROUP BY M.Merchandise_name " +
                                                            "ORDER BY Count(*) DESC;", myDB);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "List");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "List";
            myDB.Close();
        }

        private void BtnLeastPop_Click(object sender, EventArgs e)
        {
            string time_period = "";

            if (rbtnMonth.Checked == true)
            {
                time_period = "DateSerial(Year(Date()), Month(Date()) - 1, 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }
            else if (rbtn3Months.Checked == true)
            {
                time_period = "DateSerial(Year(Date()), Month(Date()) - 3, 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }
            else if (rbtnYear.Checked == true)
            {
                time_period = "DateSerial(Year(Date())-1, Month(Date()), 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }

            myDB.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT M.Merchandise_name, Count(*) AS [# of Transactions], Sum(D.Quantity) AS [Amount of items out] " +
                                                            "FROM Distribution AS D INNER JOIN Merchandise AS M ON D.Merchandise_ID = M.Merchandise_ID " +
                                                            "WHERE ((D.Merchandise_ID) Is Not Null) " +
                                                            "AND (D.Distribution_Date BETWEEN " + time_period + " ) " +
                                                            "GROUP BY M.Merchandise_name " +
                                                            "ORDER BY Count(*) ASC;", myDB);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "List");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "List";
            myDB.Close();
        }

        private void BtnItemB_Click(object sender, EventArgs e)
        {
            string time_period = "";
            string choc = "Choc purchase";

            if (rbtnMonth.Checked == true)
            {
                time_period = "DateSerial(Year(Date()), Month(Date()) - 1, 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }
            else if (rbtn3Months.Checked == true)
            {
                time_period = "DateSerial(Year(Date()), Month(Date()) - 3, 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }
            else if (rbtnYear.Checked == true)
            {
                time_period = "DateSerial(Year(Date())-1, Month(Date()), 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }

            myDB.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Distribution", myDB);
            /*OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT M.Merchandise_name, M.Merchandise_desscription, D.Quantity, D.Distribution_Date " +
                                                            "FROM Distribution AS D INNER JOIN Merchandise AS M ON D.Merchandise_ID = M.Merchandise_ID " +
                                                            "WHERE (D.Merchandise_ID IS NOT NULL " +
                                                            "AND D.Distribution_Date BETWEEN " + time_period + " ) ", myDB);*/

            DataSet ds = new DataSet();
            adapter.Fill(ds, "List");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "List";
            myDB.Close();
        }

        private void BtnItemDon_Click(object sender, EventArgs e)
        {
            string time_period = "";

            if (rbtnMonth.Checked == true)
            {
                time_period = "DateSerial(Year(Date()), Month(Date()) - 1, 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }
            else if (rbtn3Months.Checked == true)
            {
                time_period = "DateSerial(Year(Date()), Month(Date()) - 3, 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }
            else if (rbtnYear.Checked == true)
            {
                time_period = "DateSerial(Year(Date())-1, Month(Date()), 1) AND DateSerial(Year(Date()), Month(Date()), 0)";
            }

            myDB.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Donations", myDB);
            /*OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT M.Merchandise_name, Sum(D.Quantity) AS [Amount of items bought by choc] " +
                                                            "FROM Donations AS D INNER JOIN Merchandise AS M ON D.Merchandise_ID = M.Merchandise_ID " +
                                                            "WHERE ((D.Merchandise_ID) Is Not Null) " +
                                                            "AND (D.Distribution_Date BETWEEN " + time_period + " ) ", myDB);*/
            DataSet ds = new DataSet();
            adapter.Fill(ds, "List");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "List";
            myDB.Close();
        }
    }
}
