namespace CHOC
{
    partial class Item_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_management));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnDeleteItems = new System.Windows.Forms.Button();
            this.btnUpdateItems = new System.Windows.Forms.Button();
            this.btnViewItems = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtItemQTY = new System.Windows.Forms.TextBox();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.txtItemDescr = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label3.Location = new System.Drawing.Point(98, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label4.Location = new System.Drawing.Point(72, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity:";
            // 
            // btnAddItems
            // 
            this.btnAddItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnAddItems.Location = new System.Drawing.Point(12, 125);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(165, 48);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Item";
            this.btnAddItems.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItems
            // 
            this.btnDeleteItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnDeleteItems.Location = new System.Drawing.Point(185, 125);
            this.btnDeleteItems.Name = "btnDeleteItems";
            this.btnDeleteItems.Size = new System.Drawing.Size(165, 48);
            this.btnDeleteItems.TabIndex = 2;
            this.btnDeleteItems.Text = "Delete Item";
            this.btnDeleteItems.UseVisualStyleBackColor = true;
            // 
            // btnUpdateItems
            // 
            this.btnUpdateItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnUpdateItems.Location = new System.Drawing.Point(12, 179);
            this.btnUpdateItems.Name = "btnUpdateItems";
            this.btnUpdateItems.Size = new System.Drawing.Size(165, 48);
            this.btnUpdateItems.TabIndex = 2;
            this.btnUpdateItems.Text = "Update Item";
            this.btnUpdateItems.UseVisualStyleBackColor = true;
            // 
            // btnViewItems
            // 
            this.btnViewItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnViewItems.Location = new System.Drawing.Point(185, 179);
            this.btnViewItems.Name = "btnViewItems";
            this.btnViewItems.Size = new System.Drawing.Size(165, 48);
            this.btnViewItems.TabIndex = 2;
            this.btnViewItems.Text = "View Item";
            this.btnViewItems.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnBack.Location = new System.Drawing.Point(101, 233);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 48);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // txtItemQTY
            // 
            this.txtItemQTY.Location = new System.Drawing.Point(158, 100);
            this.txtItemQTY.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemQTY.Name = "txtItemQTY";
            this.txtItemQTY.Size = new System.Drawing.Size(192, 20);
            this.txtItemQTY.TabIndex = 11;
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(158, 70);
            this.txtItemPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(192, 20);
            this.txtItemPrice.TabIndex = 10;
            // 
            // txtItemDescr
            // 
            this.txtItemDescr.Location = new System.Drawing.Point(158, 40);
            this.txtItemDescr.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemDescr.Name = "txtItemDescr";
            this.txtItemDescr.Size = new System.Drawing.Size(192, 20);
            this.txtItemDescr.TabIndex = 9;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(158, 10);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(192, 20);
            this.txtItemName.TabIndex = 8;
            // 
            // Item_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(365, 291);
            this.Controls.Add(this.txtItemQTY);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.txtItemDescr);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewItems);
            this.Controls.Add(this.btnUpdateItems);
            this.Controls.Add(this.btnDeleteItems);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Item_management";
            this.Text = "Item_management";
            this.Load += new System.EventHandler(this.Item_management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnDeleteItems;
        private System.Windows.Forms.Button btnUpdateItems;
        private System.Windows.Forms.Button btnViewItems;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtItemQTY;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.TextBox txtItemDescr;
        private System.Windows.Forms.TextBox txtItemName;
    }
}