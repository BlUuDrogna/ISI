namespace CHOC
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDistReport = new System.Windows.Forms.Button();
            this.btnDonReport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.rbtn3Months = new System.Windows.Forms.RadioButton();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.btnItemDon = new System.Windows.Forms.Button();
            this.btnItemB = new System.Windows.Forms.Button();
            this.btnPerDon = new System.Windows.Forms.Button();
            this.btnLeastPop = new System.Windows.Forms.Button();
            this.btnPopItem = new System.Windows.Forms.Button();
            this.btnPerItem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 75);
            this.label1.TabIndex = 30;
            this.label1.Text = "Distribution";
            // 
            // btnDistReport
            // 
            this.btnDistReport.BackColor = System.Drawing.Color.Transparent;
            this.btnDistReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnDistReport.Location = new System.Drawing.Point(396, 9);
            this.btnDistReport.Name = "btnDistReport";
            this.btnDistReport.Size = new System.Drawing.Size(194, 40);
            this.btnDistReport.TabIndex = 29;
            this.btnDistReport.Text = "Distribution Report";
            this.btnDistReport.UseVisualStyleBackColor = false;
            this.btnDistReport.Click += new System.EventHandler(this.BtnDistReport_Click);
            // 
            // btnDonReport
            // 
            this.btnDonReport.BackColor = System.Drawing.Color.Transparent;
            this.btnDonReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnDonReport.Location = new System.Drawing.Point(396, 49);
            this.btnDonReport.Name = "btnDonReport";
            this.btnDonReport.Size = new System.Drawing.Size(194, 40);
            this.btnDonReport.TabIndex = 28;
            this.btnDonReport.Text = "Donations Report";
            this.btnDonReport.UseVisualStyleBackColor = false;
            this.btnDonReport.Click += new System.EventHandler(this.BtnDonReport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(578, 449);
            this.dataGridView1.TabIndex = 27;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnBack.Location = new System.Drawing.Point(629, 488);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(262, 56);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbtnYear);
            this.groupBox1.Controls.Add(this.rbtn3Months);
            this.groupBox1.Controls.Add(this.rbtnMonth);
            this.groupBox1.Controls.Add(this.btnItemDon);
            this.groupBox1.Controls.Add(this.btnItemB);
            this.groupBox1.Controls.Add(this.btnPerDon);
            this.groupBox1.Controls.Add(this.btnLeastPop);
            this.groupBox1.Controls.Add(this.btnPopItem);
            this.groupBox1.Controls.Add(this.btnPerItem);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.groupBox1.Location = new System.Drawing.Point(596, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 449);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sample reports for Merchandise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "For the last :";
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.BackColor = System.Drawing.Color.Transparent;
            this.rbtnYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbtnYear.Location = new System.Drawing.Point(211, 67);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(63, 22);
            this.rbtnYear.TabIndex = 31;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = false;
            // 
            // rbtn3Months
            // 
            this.rbtn3Months.AutoSize = true;
            this.rbtn3Months.BackColor = System.Drawing.Color.Transparent;
            this.rbtn3Months.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbtn3Months.Location = new System.Drawing.Point(112, 67);
            this.rbtn3Months.Name = "rbtn3Months";
            this.rbtn3Months.Size = new System.Drawing.Size(98, 22);
            this.rbtn3Months.TabIndex = 30;
            this.rbtn3Months.TabStop = true;
            this.rbtn3Months.Text = "3 Months";
            this.rbtn3Months.UseVisualStyleBackColor = false;
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.BackColor = System.Drawing.Color.Transparent;
            this.rbtnMonth.Checked = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbtnMonth.Location = new System.Drawing.Point(33, 67);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(75, 22);
            this.rbtnMonth.TabIndex = 29;
            this.rbtnMonth.TabStop = true;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = false;
            // 
            // btnItemDon
            // 
            this.btnItemDon.BackColor = System.Drawing.Color.Transparent;
            this.btnItemDon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnItemDon.Location = new System.Drawing.Point(33, 384);
            this.btnItemDon.Name = "btnItemDon";
            this.btnItemDon.Size = new System.Drawing.Size(262, 35);
            this.btnItemDon.TabIndex = 28;
            this.btnItemDon.Text = "Items that were donated";
            this.btnItemDon.UseVisualStyleBackColor = false;
            this.btnItemDon.Click += new System.EventHandler(this.BtnItemDon_Click);
            // 
            // btnItemB
            // 
            this.btnItemB.BackColor = System.Drawing.Color.Transparent;
            this.btnItemB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnItemB.Location = new System.Drawing.Point(33, 331);
            this.btnItemB.Name = "btnItemB";
            this.btnItemB.Size = new System.Drawing.Size(262, 35);
            this.btnItemB.TabIndex = 27;
            this.btnItemB.Text = "Items that were bought";
            this.btnItemB.UseVisualStyleBackColor = false;
            this.btnItemB.Click += new System.EventHandler(this.BtnItemB_Click);
            // 
            // btnPerDon
            // 
            this.btnPerDon.BackColor = System.Drawing.Color.Transparent;
            this.btnPerDon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnPerDon.Location = new System.Drawing.Point(33, 173);
            this.btnPerDon.Name = "btnPerDon";
            this.btnPerDon.Size = new System.Drawing.Size(262, 35);
            this.btnPerDon.TabIndex = 26;
            this.btnPerDon.Text = "How many items went out per destination";
            this.btnPerDon.UseVisualStyleBackColor = false;
            this.btnPerDon.Click += new System.EventHandler(this.BtnPerDon_Click);
            // 
            // btnLeastPop
            // 
            this.btnLeastPop.BackColor = System.Drawing.Color.Transparent;
            this.btnLeastPop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnLeastPop.Location = new System.Drawing.Point(33, 279);
            this.btnLeastPop.Name = "btnLeastPop";
            this.btnLeastPop.Size = new System.Drawing.Size(262, 35);
            this.btnLeastPop.TabIndex = 25;
            this.btnLeastPop.Text = "Least popular items";
            this.btnLeastPop.UseVisualStyleBackColor = false;
            this.btnLeastPop.Click += new System.EventHandler(this.BtnLeastPop_Click);
            // 
            // btnPopItem
            // 
            this.btnPopItem.BackColor = System.Drawing.Color.Transparent;
            this.btnPopItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnPopItem.Location = new System.Drawing.Point(33, 226);
            this.btnPopItem.Name = "btnPopItem";
            this.btnPopItem.Size = new System.Drawing.Size(262, 35);
            this.btnPopItem.TabIndex = 24;
            this.btnPopItem.Text = "Most popular items";
            this.btnPopItem.UseVisualStyleBackColor = false;
            this.btnPopItem.Click += new System.EventHandler(this.BtnPopItem_Click);
            // 
            // btnPerItem
            // 
            this.btnPerItem.BackColor = System.Drawing.Color.Transparent;
            this.btnPerItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnPerItem.Location = new System.Drawing.Point(33, 122);
            this.btnPerItem.Name = "btnPerItem";
            this.btnPerItem.Size = new System.Drawing.Size(262, 35);
            this.btnPerItem.TabIndex = 23;
            this.btnPerItem.Text = "How many items went out per item";
            this.btnPerItem.UseVisualStyleBackColor = false;
            this.btnPerItem.Click += new System.EventHandler(this.BtnPerItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDistReport);
            this.Controls.Add(this.btnDonReport);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDistReport;
        private System.Windows.Forms.Button btnDonReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.RadioButton rbtn3Months;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.Button btnItemDon;
        private System.Windows.Forms.Button btnItemB;
        private System.Windows.Forms.Button btnPerDon;
        private System.Windows.Forms.Button btnLeastPop;
        private System.Windows.Forms.Button btnPopItem;
        private System.Windows.Forms.Button btnPerItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}