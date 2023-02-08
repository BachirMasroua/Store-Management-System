namespace Store_Management_System
{
    partial class AddProducts
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
            this.Product_Name = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.Description = new System.Windows.Forms.Label();
            this.InitialPrice = new System.Windows.Forms.TextBox();
            this.SellingPrice = new System.Windows.Forms.TextBox();
            this.labelSellingPrice = new System.Windows.Forms.Label();
            this.labelInitialPrice = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSize = true;
            this.Product_Name.Location = new System.Drawing.Point(69, 84);
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Size = new System.Drawing.Size(104, 20);
            this.Product_Name.TabIndex = 0;
            this.Product_Name.Text = "Product Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(69, 107);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(427, 388);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(69, 225);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(302, 120);
            this.richTextBoxDescription.TabIndex = 3;
            this.richTextBoxDescription.Text = "";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(69, 202);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(85, 20);
            this.Description.TabIndex = 4;
            this.Description.Text = "Description";
            // 
            // InitialPrice
            // 
            this.InitialPrice.Location = new System.Drawing.Point(531, 149);
            this.InitialPrice.Name = "InitialPrice";
            this.InitialPrice.Size = new System.Drawing.Size(125, 27);
            this.InitialPrice.TabIndex = 5;
            // 
            // SellingPrice
            // 
            this.SellingPrice.Location = new System.Drawing.Point(727, 149);
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.Size = new System.Drawing.Size(125, 27);
            this.SellingPrice.TabIndex = 6;
            // 
            // labelSellingPrice
            // 
            this.labelSellingPrice.AutoSize = true;
            this.labelSellingPrice.Location = new System.Drawing.Point(727, 126);
            this.labelSellingPrice.Name = "labelSellingPrice";
            this.labelSellingPrice.Size = new System.Drawing.Size(90, 20);
            this.labelSellingPrice.TabIndex = 7;
            this.labelSellingPrice.Text = "Selling Price";
            // 
            // labelInitialPrice
            // 
            this.labelInitialPrice.AutoSize = true;
            this.labelInitialPrice.Location = new System.Drawing.Point(531, 126);
            this.labelInitialPrice.Name = "labelInitialPrice";
            this.labelInitialPrice.Size = new System.Drawing.Size(82, 20);
            this.labelInitialPrice.TabIndex = 8;
            this.labelInitialPrice.Text = "Initial Price";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(632, 276);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(125, 27);
            this.Quantity.TabIndex = 9;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(632, 253);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(65, 20);
            this.labelQuantity.TabIndex = 10;
            this.labelQuantity.Text = "Quantity";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(792, 38);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(94, 29);
            this.Close.TabIndex = 11;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 453);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.labelInitialPrice);
            this.Controls.Add(this.labelSellingPrice);
            this.Controls.Add(this.SellingPrice);
            this.Controls.Add(this.InitialPrice);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Product_Name);
            this.Name = "AddProducts";
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Product_Name;
        private TextBox textBoxName;
        private Button btnAdd;
        private RichTextBox richTextBoxDescription;
        private Label Description;
        private TextBox InitialPrice;
        private TextBox SellingPrice;
        private Label labelSellingPrice;
        private Label labelInitialPrice;
        private TextBox Quantity;
        private Label labelQuantity;
        private Button Close;
    }
}