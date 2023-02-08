namespace Store_Management_System
{
    partial class NewOrder
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
            this.TabCtrl = new System.Windows.Forms.TabControl();
            this.Items = new System.Windows.Forms.TabPage();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelProdId = new System.Windows.Forms.Label();
            this.ProdId = new System.Windows.Forms.TextBox();
            this.Customer = new System.Windows.Forms.TabPage();
            this.submitOrder = new System.Windows.Forms.Button();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.labeldollar = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.labelNumberOfProducts = new System.Windows.Forms.Label();
            this.NbOfProducts = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.TabCtrl.SuspendLayout();
            this.Items.SuspendLayout();
            this.Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // TabCtrl
            // 
            this.TabCtrl.Controls.Add(this.Items);
            this.TabCtrl.Controls.Add(this.Customer);
            this.TabCtrl.Location = new System.Drawing.Point(34, 33);
            this.TabCtrl.Name = "TabCtrl";
            this.TabCtrl.SelectedIndex = 0;
            this.TabCtrl.Size = new System.Drawing.Size(271, 380);
            this.TabCtrl.TabIndex = 0;
            // 
            // Items
            // 
            this.Items.Controls.Add(this.Quantity);
            this.Items.Controls.Add(this.buttonAddItem);
            this.Items.Controls.Add(this.labelQuantity);
            this.Items.Controls.Add(this.labelProdId);
            this.Items.Controls.Add(this.ProdId);
            this.Items.Location = new System.Drawing.Point(4, 29);
            this.Items.Name = "Items";
            this.Items.Padding = new System.Windows.Forms.Padding(3);
            this.Items.Size = new System.Drawing.Size(263, 347);
            this.Items.TabIndex = 0;
            this.Items.Text = "Items";
            this.Items.UseVisualStyleBackColor = true;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(67, 166);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(125, 27);
            this.Quantity.TabIndex = 2;
            this.Quantity.Text = "1";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(81, 266);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(94, 29);
            this.buttonAddItem.TabIndex = 1;
            this.buttonAddItem.Text = "Add";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(67, 143);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(65, 20);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelProdId
            // 
            this.labelProdId.AutoSize = true;
            this.labelProdId.Location = new System.Drawing.Point(67, 44);
            this.labelProdId.Name = "labelProdId";
            this.labelProdId.Size = new System.Drawing.Size(79, 20);
            this.labelProdId.TabIndex = 2;
            this.labelProdId.Text = "Product ID";
            // 
            // ProdId
            // 
            this.ProdId.Location = new System.Drawing.Point(67, 67);
            this.ProdId.Name = "ProdId";
            this.ProdId.Size = new System.Drawing.Size(125, 27);
            this.ProdId.TabIndex = 1;
            // 
            // Customer
            // 
            this.Customer.Controls.Add(this.submitOrder);
            this.Customer.Controls.Add(this.labelPhoneNumber);
            this.Customer.Controls.Add(this.labelLastName);
            this.Customer.Controls.Add(this.labelFirstName);
            this.Customer.Controls.Add(this.phoneNumber);
            this.Customer.Controls.Add(this.lastName);
            this.Customer.Controls.Add(this.firstName);
            this.Customer.Location = new System.Drawing.Point(4, 29);
            this.Customer.Name = "Customer";
            this.Customer.Padding = new System.Windows.Forms.Padding(3);
            this.Customer.Size = new System.Drawing.Size(263, 347);
            this.Customer.TabIndex = 1;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            // 
            // submitOrder
            // 
            this.submitOrder.Location = new System.Drawing.Point(86, 282);
            this.submitOrder.Name = "submitOrder";
            this.submitOrder.Size = new System.Drawing.Size(94, 29);
            this.submitOrder.TabIndex = 2;
            this.submitOrder.Text = "Submit";
            this.submitOrder.UseVisualStyleBackColor = true;
            this.submitOrder.Click += new System.EventHandler(this.submitOrder_Click);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(72, 180);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(108, 20);
            this.labelPhoneNumber.TabIndex = 3;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(72, 84);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(79, 20);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(72, 19);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(80, 20);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "First Name";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(72, 203);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(125, 27);
            this.phoneNumber.TabIndex = 2;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(72, 107);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(125, 27);
            this.lastName.TabIndex = 2;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(72, 42);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(125, 27);
            this.firstName.TabIndex = 2;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(311, 62);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowHeadersWidth = 51;
            this.dataGridViewItems.RowTemplate.Height = 29;
            this.dataGridViewItems.Size = new System.Drawing.Size(576, 318);
            this.dataGridViewItems.TabIndex = 1;
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(693, 393);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(78, 20);
            this.labelTotalCost.TabIndex = 2;
            this.labelTotalCost.Text = "Total Cost:";
            // 
            // labeldollar
            // 
            this.labeldollar.AutoSize = true;
            this.labeldollar.Location = new System.Drawing.Point(870, 393);
            this.labeldollar.Name = "labeldollar";
            this.labeldollar.Size = new System.Drawing.Size(17, 20);
            this.labeldollar.TabIndex = 3;
            this.labeldollar.Text = "$";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Location = new System.Drawing.Point(777, 393);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(17, 20);
            this.Cost.TabIndex = 4;
            this.Cost.Text = "0";
            // 
            // labelNumberOfProducts
            // 
            this.labelNumberOfProducts.AutoSize = true;
            this.labelNumberOfProducts.Location = new System.Drawing.Point(330, 393);
            this.labelNumberOfProducts.Name = "labelNumberOfProducts";
            this.labelNumberOfProducts.Size = new System.Drawing.Size(146, 20);
            this.labelNumberOfProducts.TabIndex = 5;
            this.labelNumberOfProducts.Text = "Number of products:";
            // 
            // NbOfProducts
            // 
            this.NbOfProducts.AutoSize = true;
            this.NbOfProducts.Location = new System.Drawing.Point(482, 393);
            this.NbOfProducts.Name = "NbOfProducts";
            this.NbOfProducts.Size = new System.Drawing.Size(17, 20);
            this.NbOfProducts.TabIndex = 5;
            this.NbOfProducts.Text = "0";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(793, 27);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(94, 29);
            this.Close.TabIndex = 7;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 453);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.NbOfProducts);
            this.Controls.Add(this.labelNumberOfProducts);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.labeldollar);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.TabCtrl);
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.TabCtrl.ResumeLayout(false);
            this.Items.ResumeLayout(false);
            this.Items.PerformLayout();
            this.Customer.ResumeLayout(false);
            this.Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl TabCtrl;
        private TabPage Items;
        private Button buttonAddItem;
        private Label labelQuantity;
        private Label labelProdId;
        private TextBox ProdId;
        private TabPage Customer;
        private DataGridView dataGridViewItems;
        private TextBox Quantity;
        private Button submitOrder;
        private Label labelPhoneNumber;
        private Label labelLastName;
        private Label labelFirstName;
        private TextBox phoneNumber;
        private TextBox lastName;
        private TextBox firstName;
        private Label labelTotalCost;
        private Label labeldollar;
        private Label Cost;
        private Label labelNumberOfProducts;
        private Label NbOfProducts;
        private Button Close;
    }
}