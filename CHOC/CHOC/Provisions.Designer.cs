namespace CHOC
{
    partial class Provisions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Provisions));
            this.metroTabControl1 = new System.Windows.Forms.TabControl();
            this.tbDon = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAddToList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.metroButton2 = new System.Windows.Forms.Button();
            this.Current_List = new System.Windows.Forms.ListBox();
            this.metroButton4 = new System.Windows.Forms.Button();
            this.tbReport = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnReportAllStock = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnMonthlyReport = new System.Windows.Forms.Button();
            this.comboboxMonthlyReport = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboboxDistributionName = new System.Windows.Forms.ComboBox();
            this.rbSpecifyDonorOut = new System.Windows.Forms.RadioButton();
            this.rbAnyDonorOut = new System.Windows.Forms.RadioButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbApecifyTimeOut = new System.Windows.Forms.RadioButton();
            this.rbAllTimeOut = new System.Windows.Forms.RadioButton();
            this.datetimePickerEndOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartOut = new System.Windows.Forms.DateTimePicker();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.comboboxDistributionCategory = new System.Windows.Forms.ComboBox();
            this.rbSpecifyCategoryOut = new System.Windows.Forms.RadioButton();
            this.rbAnyCategoryOut = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboboxSpecifyDonor = new System.Windows.Forms.ComboBox();
            this.rbSpecifyDonor = new System.Windows.Forms.RadioButton();
            this.radiobtnAnyDonor = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboboxDonationCategory = new System.Windows.Forms.ComboBox();
            this.radiobtnSpecificCategory = new System.Windows.Forms.RadioButton();
            this.radiobtnAnyDonationCategory = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radiobtnSpecifyTime = new System.Windows.Forms.RadioButton();
            this.radiobuttonAnyTime = new System.Windows.Forms.RadioButton();
            this.datetimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            this.tbDon.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.tbReport.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tbDon);
            this.metroTabControl1.Controls.Add(this.tbReport);
            this.metroTabControl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 12);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(852, 370);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.MetroTabControl1_SelectedIndexChanged_1);
            // 
            // tbDon
            // 
            this.tbDon.Controls.Add(this.groupBox12);
            this.tbDon.Controls.Add(this.groupBox13);
            this.tbDon.Location = new System.Drawing.Point(4, 27);
            this.tbDon.Name = "tbDon";
            this.tbDon.Padding = new System.Windows.Forms.Padding(3);
            this.tbDon.Size = new System.Drawing.Size(844, 339);
            this.tbDon.TabIndex = 0;
            this.tbDon.Text = "Provision Donation/Distribution";
            this.tbDon.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.numericUpDown1);
            this.groupBox12.Controls.Add(this.dataGridView1);
            this.groupBox12.Controls.Add(this.BtnAddToList);
            this.groupBox12.Controls.Add(this.label4);
            this.groupBox12.Controls.Add(this.btnCreateItem);
            this.groupBox12.Controls.Add(this.lblname);
            this.groupBox12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.groupBox12.Location = new System.Drawing.Point(3, 13);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(451, 325);
            this.groupBox12.TabIndex = 30;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Select Existing Item";
            this.groupBox12.Enter += new System.EventHandler(this.GroupBox12_Enter);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(325, 203);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 178);
            this.dataGridView1.TabIndex = 25;
            // 
            // BtnAddToList
            // 
            this.BtnAddToList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.BtnAddToList.Location = new System.Drawing.Point(221, 240);
            this.BtnAddToList.Name = "BtnAddToList";
            this.BtnAddToList.Size = new System.Drawing.Size(165, 48);
            this.BtnAddToList.TabIndex = 28;
            this.BtnAddToList.Text = "Add to current list";
            this.BtnAddToList.UseVisualStyleBackColor = true;
            this.BtnAddToList.Click += new System.EventHandler(this.BtnAddToList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label4.Location = new System.Drawing.Point(243, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Quantity";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnCreateItem.Location = new System.Drawing.Point(50, 240);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(165, 48);
            this.btnCreateItem.TabIndex = 28;
            this.btnCreateItem.Text = "Create new item";
            this.btnCreateItem.UseVisualStyleBackColor = true;
            this.btnCreateItem.Click += new System.EventHandler(this.BtnCreateItem_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblname.Location = new System.Drawing.Point(6, 205);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(102, 18);
            this.lblname.TabIndex = 27;
            this.lblname.Text = "Item Name: ";
            this.lblname.Click += new System.EventHandler(this.Lblname_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.metroButton2);
            this.groupBox13.Controls.Add(this.Current_List);
            this.groupBox13.Controls.Add(this.metroButton4);
            this.groupBox13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.groupBox13.Location = new System.Drawing.Point(460, 13);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(378, 325);
            this.groupBox13.TabIndex = 31;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Current List";
            this.groupBox13.Enter += new System.EventHandler(this.GroupBox13_Enter);
            // 
            // metroButton2
            // 
            this.metroButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.metroButton2.Location = new System.Drawing.Point(199, 205);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(165, 48);
            this.metroButton2.TabIndex = 28;
            this.metroButton2.Text = "Remove current list to inventory";
            this.metroButton2.UseVisualStyleBackColor = true;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // Current_List
            // 
            this.Current_List.FormattingEnabled = true;
            this.Current_List.ItemHeight = 18;
            this.Current_List.Location = new System.Drawing.Point(6, 19);
            this.Current_List.Name = "Current_List";
            this.Current_List.Size = new System.Drawing.Size(372, 166);
            this.Current_List.TabIndex = 26;
            // 
            // metroButton4
            // 
            this.metroButton4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.metroButton4.Location = new System.Drawing.Point(28, 205);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(165, 48);
            this.metroButton4.TabIndex = 28;
            this.metroButton4.Text = "Add current list to inventory";
            this.metroButton4.UseVisualStyleBackColor = true;
            this.metroButton4.Click += new System.EventHandler(this.MetroButton4_Click);
            // 
            // tbReport
            // 
            this.tbReport.Controls.Add(this.groupBox3);
            this.tbReport.Controls.Add(this.groupBox2);
            this.tbReport.Controls.Add(this.groupBox1);
            this.tbReport.Location = new System.Drawing.Point(4, 27);
            this.tbReport.Name = "tbReport";
            this.tbReport.Padding = new System.Windows.Forms.Padding(3);
            this.tbReport.Size = new System.Drawing.Size(844, 339);
            this.tbReport.TabIndex = 1;
            this.tbReport.Text = "Report";
            this.tbReport.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox11);
            this.groupBox3.Controls.Add(this.groupBox10);
            this.groupBox3.Location = new System.Drawing.Point(564, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 294);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other Reports";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnReportAllStock);
            this.groupBox11.Location = new System.Drawing.Point(7, 131);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(260, 75);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "All Stock On Hand";
            // 
            // btnReportAllStock
            // 
            this.btnReportAllStock.Location = new System.Drawing.Point(11, 23);
            this.btnReportAllStock.Name = "btnReportAllStock";
            this.btnReportAllStock.Size = new System.Drawing.Size(237, 35);
            this.btnReportAllStock.TabIndex = 3;
            this.btnReportAllStock.Text = "Report on Current Stock";
            this.btnReportAllStock.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnMonthlyReport);
            this.groupBox10.Controls.Add(this.comboboxMonthlyReport);
            this.groupBox10.Controls.Add(this.label5);
            this.groupBox10.Location = new System.Drawing.Point(7, 20);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(260, 105);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Monthly Report";
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.Location = new System.Drawing.Point(10, 64);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(237, 35);
            this.btnMonthlyReport.TabIndex = 2;
            this.btnMonthlyReport.Text = "Generate Montly Report";
            this.btnMonthlyReport.UseVisualStyleBackColor = true;
            // 
            // comboboxMonthlyReport
            // 
            this.comboboxMonthlyReport.FormattingEnabled = true;
            this.comboboxMonthlyReport.Location = new System.Drawing.Point(10, 37);
            this.comboboxMonthlyReport.Name = "comboboxMonthlyReport";
            this.comboboxMonthlyReport.Size = new System.Drawing.Size(237, 26);
            this.comboboxMonthlyReport.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select a Month";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Location = new System.Drawing.Point(285, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report on Distributed Items";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboboxDistributionName);
            this.groupBox7.Controls.Add(this.rbSpecifyDonorOut);
            this.groupBox7.Controls.Add(this.rbAnyDonorOut);
            this.groupBox7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(6, 212);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(260, 75);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Select Specific Distribuion Name";
            // 
            // comboboxDistributionName
            // 
            this.comboboxDistributionName.FormattingEnabled = true;
            this.comboboxDistributionName.Location = new System.Drawing.Point(6, 42);
            this.comboboxDistributionName.Name = "comboboxDistributionName";
            this.comboboxDistributionName.Size = new System.Drawing.Size(247, 25);
            this.comboboxDistributionName.TabIndex = 10;
            // 
            // rbSpecifyDonorOut
            // 
            this.rbSpecifyDonorOut.AutoSize = true;
            this.rbSpecifyDonorOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbSpecifyDonorOut.Location = new System.Drawing.Point(130, 19);
            this.rbSpecifyDonorOut.Name = "rbSpecifyDonorOut";
            this.rbSpecifyDonorOut.Size = new System.Drawing.Size(123, 22);
            this.rbSpecifyDonorOut.TabIndex = 11;
            this.rbSpecifyDonorOut.TabStop = true;
            this.rbSpecifyDonorOut.Text = "Specify time";
            this.rbSpecifyDonorOut.UseVisualStyleBackColor = true;
            // 
            // rbAnyDonorOut
            // 
            this.rbAnyDonorOut.AutoSize = true;
            this.rbAnyDonorOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnyDonorOut.Location = new System.Drawing.Point(39, 19);
            this.rbAnyDonorOut.Name = "rbAnyDonorOut";
            this.rbAnyDonorOut.Size = new System.Drawing.Size(84, 22);
            this.rbAnyDonorOut.TabIndex = 10;
            this.rbAnyDonorOut.TabStop = true;
            this.rbAnyDonorOut.Text = "All time";
            this.rbAnyDonorOut.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Controls.Add(this.rbApecifyTimeOut);
            this.groupBox9.Controls.Add(this.rbAllTimeOut);
            this.groupBox9.Controls.Add(this.datetimePickerEndOut);
            this.groupBox9.Controls.Add(this.dateTimePickerStartOut);
            this.groupBox9.Location = new System.Drawing.Point(6, 20);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(260, 105);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Select Time Period";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "From:";
            // 
            // rbApecifyTimeOut
            // 
            this.rbApecifyTimeOut.AutoSize = true;
            this.rbApecifyTimeOut.Location = new System.Drawing.Point(130, 15);
            this.rbApecifyTimeOut.Name = "rbApecifyTimeOut";
            this.rbApecifyTimeOut.Size = new System.Drawing.Size(123, 22);
            this.rbApecifyTimeOut.TabIndex = 5;
            this.rbApecifyTimeOut.TabStop = true;
            this.rbApecifyTimeOut.Text = "Specify time";
            this.rbApecifyTimeOut.UseVisualStyleBackColor = true;
            // 
            // rbAllTimeOut
            // 
            this.rbAllTimeOut.AutoSize = true;
            this.rbAllTimeOut.Location = new System.Drawing.Point(39, 15);
            this.rbAllTimeOut.Name = "rbAllTimeOut";
            this.rbAllTimeOut.Size = new System.Drawing.Size(84, 22);
            this.rbAllTimeOut.TabIndex = 4;
            this.rbAllTimeOut.TabStop = true;
            this.rbAllTimeOut.Text = "All time";
            this.rbAllTimeOut.UseVisualStyleBackColor = true;
            // 
            // datetimePickerEndOut
            // 
            this.datetimePickerEndOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.datetimePickerEndOut.Location = new System.Drawing.Point(53, 69);
            this.datetimePickerEndOut.Name = "datetimePickerEndOut";
            this.datetimePickerEndOut.Size = new System.Drawing.Size(200, 20);
            this.datetimePickerEndOut.TabIndex = 3;
            // 
            // dateTimePickerStartOut
            // 
            this.dateTimePickerStartOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePickerStartOut.Location = new System.Drawing.Point(53, 43);
            this.dateTimePickerStartOut.Name = "dateTimePickerStartOut";
            this.dateTimePickerStartOut.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartOut.TabIndex = 2;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.comboboxDistributionCategory);
            this.groupBox8.Controls.Add(this.rbSpecifyCategoryOut);
            this.groupBox8.Controls.Add(this.rbAnyCategoryOut);
            this.groupBox8.Location = new System.Drawing.Point(6, 131);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(260, 75);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Select Distribution Category";
            // 
            // comboboxDistributionCategory
            // 
            this.comboboxDistributionCategory.FormattingEnabled = true;
            this.comboboxDistributionCategory.Location = new System.Drawing.Point(7, 42);
            this.comboboxDistributionCategory.Name = "comboboxDistributionCategory";
            this.comboboxDistributionCategory.Size = new System.Drawing.Size(247, 26);
            this.comboboxDistributionCategory.TabIndex = 9;
            // 
            // rbSpecifyCategoryOut
            // 
            this.rbSpecifyCategoryOut.AutoSize = true;
            this.rbSpecifyCategoryOut.Location = new System.Drawing.Point(130, 19);
            this.rbSpecifyCategoryOut.Name = "rbSpecifyCategoryOut";
            this.rbSpecifyCategoryOut.Size = new System.Drawing.Size(123, 22);
            this.rbSpecifyCategoryOut.TabIndex = 9;
            this.rbSpecifyCategoryOut.TabStop = true;
            this.rbSpecifyCategoryOut.Text = "Specify time";
            this.rbSpecifyCategoryOut.UseVisualStyleBackColor = true;
            // 
            // rbAnyCategoryOut
            // 
            this.rbAnyCategoryOut.AutoSize = true;
            this.rbAnyCategoryOut.Location = new System.Drawing.Point(39, 19);
            this.rbAnyCategoryOut.Name = "rbAnyCategoryOut";
            this.rbAnyCategoryOut.Size = new System.Drawing.Size(84, 22);
            this.rbAnyCategoryOut.TabIndex = 8;
            this.rbAnyCategoryOut.TabStop = true;
            this.rbAnyCategoryOut.Text = "All time";
            this.rbAnyCategoryOut.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report on Received Items";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboboxSpecifyDonor);
            this.groupBox6.Controls.Add(this.rbSpecifyDonor);
            this.groupBox6.Controls.Add(this.radiobtnAnyDonor);
            this.groupBox6.Location = new System.Drawing.Point(7, 212);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(260, 75);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Select Specific Donor";
            // 
            // comboboxSpecifyDonor
            // 
            this.comboboxSpecifyDonor.FormattingEnabled = true;
            this.comboboxSpecifyDonor.Location = new System.Drawing.Point(6, 42);
            this.comboboxSpecifyDonor.Name = "comboboxSpecifyDonor";
            this.comboboxSpecifyDonor.Size = new System.Drawing.Size(247, 26);
            this.comboboxSpecifyDonor.TabIndex = 12;
            // 
            // rbSpecifyDonor
            // 
            this.rbSpecifyDonor.AutoSize = true;
            this.rbSpecifyDonor.Location = new System.Drawing.Point(128, 19);
            this.rbSpecifyDonor.Name = "rbSpecifyDonor";
            this.rbSpecifyDonor.Size = new System.Drawing.Size(123, 22);
            this.rbSpecifyDonor.TabIndex = 13;
            this.rbSpecifyDonor.TabStop = true;
            this.rbSpecifyDonor.Text = "Specify time";
            this.rbSpecifyDonor.UseVisualStyleBackColor = true;
            // 
            // radiobtnAnyDonor
            // 
            this.radiobtnAnyDonor.AutoSize = true;
            this.radiobtnAnyDonor.Location = new System.Drawing.Point(37, 19);
            this.radiobtnAnyDonor.Name = "radiobtnAnyDonor";
            this.radiobtnAnyDonor.Size = new System.Drawing.Size(84, 22);
            this.radiobtnAnyDonor.TabIndex = 12;
            this.radiobtnAnyDonor.TabStop = true;
            this.radiobtnAnyDonor.Text = "All time";
            this.radiobtnAnyDonor.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboboxDonationCategory);
            this.groupBox5.Controls.Add(this.radiobtnSpecificCategory);
            this.groupBox5.Controls.Add(this.radiobtnAnyDonationCategory);
            this.groupBox5.Location = new System.Drawing.Point(7, 131);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(260, 75);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Donation Category";
            // 
            // comboboxDonationCategory
            // 
            this.comboboxDonationCategory.FormattingEnabled = true;
            this.comboboxDonationCategory.Location = new System.Drawing.Point(6, 42);
            this.comboboxDonationCategory.Name = "comboboxDonationCategory";
            this.comboboxDonationCategory.Size = new System.Drawing.Size(247, 26);
            this.comboboxDonationCategory.TabIndex = 8;
            // 
            // radiobtnSpecificCategory
            // 
            this.radiobtnSpecificCategory.AutoSize = true;
            this.radiobtnSpecificCategory.Location = new System.Drawing.Point(128, 19);
            this.radiobtnSpecificCategory.Name = "radiobtnSpecificCategory";
            this.radiobtnSpecificCategory.Size = new System.Drawing.Size(123, 22);
            this.radiobtnSpecificCategory.TabIndex = 7;
            this.radiobtnSpecificCategory.TabStop = true;
            this.radiobtnSpecificCategory.Text = "Specify time";
            this.radiobtnSpecificCategory.UseVisualStyleBackColor = true;
            // 
            // radiobtnAnyDonationCategory
            // 
            this.radiobtnAnyDonationCategory.AutoSize = true;
            this.radiobtnAnyDonationCategory.Location = new System.Drawing.Point(37, 19);
            this.radiobtnAnyDonationCategory.Name = "radiobtnAnyDonationCategory";
            this.radiobtnAnyDonationCategory.Size = new System.Drawing.Size(84, 22);
            this.radiobtnAnyDonationCategory.TabIndex = 6;
            this.radiobtnAnyDonationCategory.TabStop = true;
            this.radiobtnAnyDonationCategory.Text = "All time";
            this.radiobtnAnyDonationCategory.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.radiobtnSpecifyTime);
            this.groupBox4.Controls.Add(this.radiobuttonAnyTime);
            this.groupBox4.Controls.Add(this.datetimePickerEndDate);
            this.groupBox4.Controls.Add(this.dateTimePickerStartDate);
            this.groupBox4.Location = new System.Drawing.Point(7, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 105);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Time Period";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "From:";
            // 
            // radiobtnSpecifyTime
            // 
            this.radiobtnSpecifyTime.AutoSize = true;
            this.radiobtnSpecifyTime.Location = new System.Drawing.Point(128, 19);
            this.radiobtnSpecifyTime.Name = "radiobtnSpecifyTime";
            this.radiobtnSpecifyTime.Size = new System.Drawing.Size(123, 22);
            this.radiobtnSpecifyTime.TabIndex = 3;
            this.radiobtnSpecifyTime.TabStop = true;
            this.radiobtnSpecifyTime.Text = "Specify time";
            this.radiobtnSpecifyTime.UseVisualStyleBackColor = true;
            // 
            // radiobuttonAnyTime
            // 
            this.radiobuttonAnyTime.AutoSize = true;
            this.radiobuttonAnyTime.Location = new System.Drawing.Point(37, 19);
            this.radiobuttonAnyTime.Name = "radiobuttonAnyTime";
            this.radiobuttonAnyTime.Size = new System.Drawing.Size(84, 22);
            this.radiobuttonAnyTime.TabIndex = 2;
            this.radiobuttonAnyTime.TabStop = true;
            this.radiobuttonAnyTime.Text = "All time";
            this.radiobuttonAnyTime.UseVisualStyleBackColor = true;
            // 
            // datetimePickerEndDate
            // 
            this.datetimePickerEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.datetimePickerEndDate.Location = new System.Drawing.Point(54, 69);
            this.datetimePickerEndDate.Name = "datetimePickerEndDate";
            this.datetimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.datetimePickerEndDate.TabIndex = 1;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(54, 43);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnBack.Location = new System.Drawing.Point(3, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Provisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 424);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.metroTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Provisions";
            this.Text = "Provisions";
            this.Load += new System.EventHandler(this.Provisions_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tbDon.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.tbReport.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl metroTabControl1;
        private System.Windows.Forms.TabPage tbDon;
        private System.Windows.Forms.TabPage tbReport;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button metroButton2;
        private System.Windows.Forms.Button metroButton4;
        private System.Windows.Forms.Button BtnAddToList;
        private System.Windows.Forms.Button btnCreateItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ListBox Current_List;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btnReportAllStock;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnMonthlyReport;
        private System.Windows.Forms.ComboBox comboboxMonthlyReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox comboboxDistributionName;
        private System.Windows.Forms.RadioButton rbSpecifyDonorOut;
        private System.Windows.Forms.RadioButton rbAnyDonorOut;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton rbApecifyTimeOut;
        private System.Windows.Forms.RadioButton rbAllTimeOut;
        private System.Windows.Forms.DateTimePicker datetimePickerEndOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartOut;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox comboboxDistributionCategory;
        private System.Windows.Forms.RadioButton rbSpecifyCategoryOut;
        private System.Windows.Forms.RadioButton rbAnyCategoryOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboboxSpecifyDonor;
        private System.Windows.Forms.RadioButton rbSpecifyDonor;
        private System.Windows.Forms.RadioButton radiobtnAnyDonor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboboxDonationCategory;
        private System.Windows.Forms.RadioButton radiobtnSpecificCategory;
        private System.Windows.Forms.RadioButton radiobtnAnyDonationCategory;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radiobtnSpecifyTime;
        private System.Windows.Forms.RadioButton radiobuttonAnyTime;
        private System.Windows.Forms.DateTimePicker datetimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}