namespace CHOC
{
    partial class UpdateMerchandise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMerchandise));
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.udStock = new System.Windows.Forms.NumericUpDown();
            this.txtMerchDes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMerchName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.udMerchID = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.udMerchPrice = new System.Windows.Forms.NumericUpDown();
            this.btnMerch = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnDelete = new System.Windows.Forms.RadioButton();
            this.rbtnUpdate = new System.Windows.Forms.RadioButton();
            this.rbtnInsert = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMerchID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMerchPrice)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 70);
            this.label4.TabIndex = 36;
            this.label4.Text = "Merchandise";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnDelete.Location = new System.Drawing.Point(349, 407);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 41);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(201, 407);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 41);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.udStock);
            this.groupBox1.Controls.Add(this.txtMerchDes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMerchName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.udMerchID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.udMerchPrice);
            this.groupBox1.Location = new System.Drawing.Point(12, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 206);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label3.Location = new System.Drawing.Point(144, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Stock level:";
            // 
            // udStock
            // 
            this.udStock.Enabled = false;
            this.udStock.Location = new System.Drawing.Point(250, 171);
            this.udStock.Name = "udStock";
            this.udStock.Size = new System.Drawing.Size(153, 20);
            this.udStock.TabIndex = 38;
            // 
            // txtMerchDes
            // 
            this.txtMerchDes.Enabled = false;
            this.txtMerchDes.Location = new System.Drawing.Point(250, 103);
            this.txtMerchDes.Name = "txtMerchDes";
            this.txtMerchDes.Size = new System.Drawing.Size(261, 20);
            this.txtMerchDes.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.Location = new System.Drawing.Point(34, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Merchandise description:";
            // 
            // txtMerchName
            // 
            this.txtMerchName.Enabled = false;
            this.txtMerchName.Location = new System.Drawing.Point(250, 64);
            this.txtMerchName.Name = "txtMerchName";
            this.txtMerchName.Size = new System.Drawing.Size(261, 20);
            this.txtMerchName.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label12.Location = new System.Drawing.Point(80, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 18);
            this.label12.TabIndex = 34;
            this.label12.Text = "Merchandise name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label7.Location = new System.Drawing.Point(103, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Merchandise_ID:";
            // 
            // udMerchID
            // 
            this.udMerchID.Enabled = false;
            this.udMerchID.Location = new System.Drawing.Point(250, 29);
            this.udMerchID.Name = "udMerchID";
            this.udMerchID.Size = new System.Drawing.Size(153, 20);
            this.udMerchID.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label6.Location = new System.Drawing.Point(38, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "Merchandise retail price:";
            // 
            // udMerchPrice
            // 
            this.udMerchPrice.Enabled = false;
            this.udMerchPrice.Location = new System.Drawing.Point(250, 136);
            this.udMerchPrice.Name = "udMerchPrice";
            this.udMerchPrice.Size = new System.Drawing.Size(153, 20);
            this.udMerchPrice.TabIndex = 28;
            // 
            // btnMerch
            // 
            this.btnMerch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnMerch.Location = new System.Drawing.Point(12, 73);
            this.btnMerch.Name = "btnMerch";
            this.btnMerch.Size = new System.Drawing.Size(246, 35);
            this.btnMerch.TabIndex = 32;
            this.btnMerch.Text = "Merchandise";
            this.btnMerch.UseVisualStyleBackColor = true;
            this.btnMerch.Click += new System.EventHandler(this.BtnMerch_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnBrand.Location = new System.Drawing.Point(295, 73);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(237, 35);
            this.btnBrand.TabIndex = 31;
            this.btnBrand.Text = "Branding";
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.Click += new System.EventHandler(this.BtnBrand_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.rbtnDelete);
            this.groupBox3.Controls.Add(this.rbtnUpdate);
            this.groupBox3.Controls.Add(this.rbtnInsert);
            this.groupBox3.Location = new System.Drawing.Point(12, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 75);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Select action:";
            // 
            // rbtnDelete
            // 
            this.rbtnDelete.AutoSize = true;
            this.rbtnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbtnDelete.Location = new System.Drawing.Point(357, 37);
            this.rbtnDelete.Name = "rbtnDelete";
            this.rbtnDelete.Size = new System.Drawing.Size(78, 22);
            this.rbtnDelete.TabIndex = 34;
            this.rbtnDelete.Text = "Delete";
            this.rbtnDelete.UseVisualStyleBackColor = true;
            this.rbtnDelete.CheckedChanged += new System.EventHandler(this.RbtnDelete_CheckedChanged);
            // 
            // rbtnUpdate
            // 
            this.rbtnUpdate.AutoSize = true;
            this.rbtnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbtnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnUpdate.Location = new System.Drawing.Point(208, 37);
            this.rbtnUpdate.Name = "rbtnUpdate";
            this.rbtnUpdate.Size = new System.Drawing.Size(84, 22);
            this.rbtnUpdate.TabIndex = 33;
            this.rbtnUpdate.Text = "Update";
            this.rbtnUpdate.UseVisualStyleBackColor = true;
            this.rbtnUpdate.CheckedChanged += new System.EventHandler(this.RbtnUpdate_CheckedChanged);
            // 
            // rbtnInsert
            // 
            this.rbtnInsert.AutoSize = true;
            this.rbtnInsert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rbtnInsert.Location = new System.Drawing.Point(51, 37);
            this.rbtnInsert.Name = "rbtnInsert";
            this.rbtnInsert.Size = new System.Drawing.Size(73, 22);
            this.rbtnInsert.TabIndex = 32;
            this.rbtnInsert.Text = "Insert";
            this.rbtnInsert.UseVisualStyleBackColor = true;
            this.rbtnInsert.CheckedChanged += new System.EventHandler(this.RbtnInsert_CheckedChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnInsert.Location = new System.Drawing.Point(53, 407);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(142, 41);
            this.btnInsert.TabIndex = 29;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnBack.Location = new System.Drawing.Point(201, 454);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 41);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UpdateMerchandise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(546, 501);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMerch);
            this.Controls.Add(this.btnBrand);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateMerchandise";
            this.Text = "Update Merchandise";
            this.Load += new System.EventHandler(this.UpdateMerchandise_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMerchID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMerchPrice)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown udStock;
        private System.Windows.Forms.TextBox txtMerchDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMerchName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown udMerchID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown udMerchPrice;
        private System.Windows.Forms.Button btnMerch;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnDelete;
        private System.Windows.Forms.RadioButton rbtnUpdate;
        private System.Windows.Forms.RadioButton rbtnInsert;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}