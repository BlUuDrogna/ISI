namespace CHOC
{
    partial class Carebags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carebags));
            this.btnDonorMnge = new System.Windows.Forms.Button();
            this.btnDBMnge = new System.Windows.Forms.Button();
            this.btnManageCB = new System.Windows.Forms.Button();
            this.btnItemManage = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDonorMnge
            // 
            this.btnDonorMnge.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDonorMnge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonorMnge.Location = new System.Drawing.Point(318, 12);
            this.btnDonorMnge.Name = "btnDonorMnge";
            this.btnDonorMnge.Size = new System.Drawing.Size(183, 52);
            this.btnDonorMnge.TabIndex = 15;
            this.btnDonorMnge.Text = "Donor Management";
            this.btnDonorMnge.UseVisualStyleBackColor = false;
            this.btnDonorMnge.Click += new System.EventHandler(this.BtnDonorMnge_Click);
            // 
            // btnDBMnge
            // 
            this.btnDBMnge.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDBMnge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBMnge.Location = new System.Drawing.Point(318, 186);
            this.btnDBMnge.Name = "btnDBMnge";
            this.btnDBMnge.Size = new System.Drawing.Size(183, 52);
            this.btnDBMnge.TabIndex = 14;
            this.btnDBMnge.Text = "Distribution Management";
            this.btnDBMnge.UseVisualStyleBackColor = false;
            this.btnDBMnge.Click += new System.EventHandler(this.BtnCBMnge_Click);
            // 
            // btnManageCB
            // 
            this.btnManageCB.BackColor = System.Drawing.Color.SkyBlue;
            this.btnManageCB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCB.Location = new System.Drawing.Point(318, 70);
            this.btnManageCB.Name = "btnManageCB";
            this.btnManageCB.Size = new System.Drawing.Size(183, 52);
            this.btnManageCB.TabIndex = 13;
            this.btnManageCB.Text = "Create a carebag";
            this.btnManageCB.UseVisualStyleBackColor = false;
            this.btnManageCB.Click += new System.EventHandler(this.BtnManageCB_Click);
            // 
            // btnItemManage
            // 
            this.btnItemManage.BackColor = System.Drawing.Color.SkyBlue;
            this.btnItemManage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemManage.Location = new System.Drawing.Point(318, 128);
            this.btnItemManage.Name = "btnItemManage";
            this.btnItemManage.Size = new System.Drawing.Size(183, 52);
            this.btnItemManage.TabIndex = 12;
            this.btnItemManage.Text = "Item Management";
            this.btnItemManage.UseVisualStyleBackColor = false;
            this.btnItemManage.Click += new System.EventHandler(this.BtnItemManage_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(318, 244);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(183, 52);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 294);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Carebags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(509, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDonorMnge);
            this.Controls.Add(this.btnDBMnge);
            this.Controls.Add(this.btnManageCB);
            this.Controls.Add(this.btnItemManage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Carebags";
            this.Text = "Carebags";
            this.Load += new System.EventHandler(this.Carebags_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDonorMnge;
        private System.Windows.Forms.Button btnDBMnge;
        private System.Windows.Forms.Button btnManageCB;
        private System.Windows.Forms.Button btnItemManage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}