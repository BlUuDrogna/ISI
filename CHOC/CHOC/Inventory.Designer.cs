namespace CHOC
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProvisions = new System.Windows.Forms.Button();
            this.btnM_B = new System.Windows.Forms.Button();
            this.btnGP = new System.Windows.Forms.Button();
            this.btnDonors = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 294);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnProvisions
            // 
            this.btnProvisions.BackColor = System.Drawing.Color.SkyBlue;
            this.btnProvisions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvisions.Location = new System.Drawing.Point(318, 183);
            this.btnProvisions.Name = "btnProvisions";
            this.btnProvisions.Size = new System.Drawing.Size(183, 52);
            this.btnProvisions.TabIndex = 11;
            this.btnProvisions.Text = "Provisions";
            this.btnProvisions.UseVisualStyleBackColor = false;
            this.btnProvisions.Click += new System.EventHandler(this.BtnProvisions_Click);
            // 
            // btnM_B
            // 
            this.btnM_B.BackColor = System.Drawing.Color.SkyBlue;
            this.btnM_B.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM_B.Location = new System.Drawing.Point(318, 68);
            this.btnM_B.Name = "btnM_B";
            this.btnM_B.Size = new System.Drawing.Size(183, 52);
            this.btnM_B.TabIndex = 10;
            this.btnM_B.Text = "Merchandise and Branding";
            this.btnM_B.UseVisualStyleBackColor = false;
            this.btnM_B.Click += new System.EventHandler(this.BtnM_B_Click);
            // 
            // btnGP
            // 
            this.btnGP.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGP.Location = new System.Drawing.Point(318, 10);
            this.btnGP.Name = "btnGP";
            this.btnGP.Size = new System.Drawing.Size(183, 52);
            this.btnGP.TabIndex = 9;
            this.btnGP.Text = "General Products";
            this.btnGP.UseVisualStyleBackColor = false;
            this.btnGP.Click += new System.EventHandler(this.BtnGP_Click);
            // 
            // btnDonors
            // 
            this.btnDonors.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDonors.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonors.Location = new System.Drawing.Point(318, 126);
            this.btnDonors.Name = "btnDonors";
            this.btnDonors.Size = new System.Drawing.Size(183, 52);
            this.btnDonors.TabIndex = 8;
            this.btnDonors.Text = "Donors";
            this.btnDonors.UseVisualStyleBackColor = false;
            this.btnDonors.Click += new System.EventHandler(this.BtnDonors_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(318, 240);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(183, 52);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(509, 311);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProvisions);
            this.Controls.Add(this.btnM_B);
            this.Controls.Add(this.btnGP);
            this.Controls.Add(this.btnDonors);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProvisions;
        private System.Windows.Forms.Button btnM_B;
        private System.Windows.Forms.Button btnGP;
        private System.Windows.Forms.Button btnDonors;
        private System.Windows.Forms.Button btnBack;
    }
}