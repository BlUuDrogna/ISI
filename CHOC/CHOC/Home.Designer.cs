namespace CHOC
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnFinancials = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.btnLogistics = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInventory.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnInventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInventory.Location = new System.Drawing.Point(424, 12);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(244, 64);
            this.btnInventory.TabIndex = 13;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // btnFinancials
            // 
            this.btnFinancials.BackColor = System.Drawing.Color.Transparent;
            this.btnFinancials.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFinancials.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFinancials.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnFinancials.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnFinancials.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinancials.ForeColor = System.Drawing.Color.Black;
            this.btnFinancials.Location = new System.Drawing.Point(424, 226);
            this.btnFinancials.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinancials.Name = "btnFinancials";
            this.btnFinancials.Size = new System.Drawing.Size(244, 64);
            this.btnFinancials.TabIndex = 12;
            this.btnFinancials.Text = "Financial Management";
            this.btnFinancials.UseVisualStyleBackColor = false;
            this.btnFinancials.Click += new System.EventHandler(this.BtnFinancials_Click);
            // 
            // btnHR
            // 
            this.btnHR.BackColor = System.Drawing.Color.Transparent;
            this.btnHR.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnHR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnHR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHR.Location = new System.Drawing.Point(424, 155);
            this.btnHR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(244, 64);
            this.btnHR.TabIndex = 11;
            this.btnHR.Text = "Human Resources";
            this.btnHR.UseVisualStyleBackColor = false;
            this.btnHR.Click += new System.EventHandler(this.BtnHR_Click);
            // 
            // btnLogistics
            // 
            this.btnLogistics.BackColor = System.Drawing.Color.Transparent;
            this.btnLogistics.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnLogistics.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogistics.Location = new System.Drawing.Point(424, 84);
            this.btnLogistics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogistics.Name = "btnLogistics";
            this.btnLogistics.Size = new System.Drawing.Size(244, 64);
            this.btnLogistics.TabIndex = 10;
            this.btnLogistics.Text = "Logistics";
            this.btnLogistics.UseVisualStyleBackColor = false;
            this.btnLogistics.Click += new System.EventHandler(this.BtnLogistics_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(424, 298);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(244, 64);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(679, 383);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFinancials);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.btnLogistics);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Home";
            this.Text = "CHOC Home";
            this.Activated += new System.EventHandler(this.Home_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnFinancials;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Button btnLogistics;
        private System.Windows.Forms.Button btnExit;
    }
}

