namespace Store_Management_System
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.SalesReport = new System.Windows.Forms.Button();
            this.StoreProducts = new System.Windows.Forms.Button();
            this.btnFormAddProd = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.SalesReport);
            this.panelMenu.Controls.Add(this.StoreProducts);
            this.panelMenu.Controls.Add(this.btnFormAddProd);
            this.panelMenu.Controls.Add(this.btnNewOrder);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 613);
            this.panelMenu.TabIndex = 4;
            // 
            // SalesReport
            // 
            this.SalesReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalesReport.FlatAppearance.BorderSize = 0;
            this.SalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalesReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.SalesReport.Image = ((System.Drawing.Image)(resources.GetObject("SalesReport.Image")));
            this.SalesReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesReport.Location = new System.Drawing.Point(0, 260);
            this.SalesReport.Name = "SalesReport";
            this.SalesReport.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.SalesReport.Size = new System.Drawing.Size(220, 60);
            this.SalesReport.TabIndex = 8;
            this.SalesReport.Text = " Sales Report";
            this.SalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SalesReport.UseVisualStyleBackColor = true;
            this.SalesReport.Click += new System.EventHandler(this.SalesReport_Click_1);
            // 
            // StoreProducts
            // 
            this.StoreProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.StoreProducts.FlatAppearance.BorderSize = 0;
            this.StoreProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StoreProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.StoreProducts.Image = ((System.Drawing.Image)(resources.GetObject("StoreProducts.Image")));
            this.StoreProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StoreProducts.Location = new System.Drawing.Point(0, 200);
            this.StoreProducts.Name = "StoreProducts";
            this.StoreProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.StoreProducts.Size = new System.Drawing.Size(220, 60);
            this.StoreProducts.TabIndex = 7;
            this.StoreProducts.Text = " Store Products";
            this.StoreProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StoreProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StoreProducts.UseVisualStyleBackColor = true;
            this.StoreProducts.Click += new System.EventHandler(this.StoreProducts_Click_1);
            // 
            // btnFormAddProd
            // 
            this.btnFormAddProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormAddProd.FlatAppearance.BorderSize = 0;
            this.btnFormAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormAddProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFormAddProd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFormAddProd.Image = ((System.Drawing.Image)(resources.GetObject("btnFormAddProd.Image")));
            this.btnFormAddProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormAddProd.Location = new System.Drawing.Point(0, 140);
            this.btnFormAddProd.Name = "btnFormAddProd";
            this.btnFormAddProd.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFormAddProd.Size = new System.Drawing.Size(220, 60);
            this.btnFormAddProd.TabIndex = 6;
            this.btnFormAddProd.Text = " Add Product";
            this.btnFormAddProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormAddProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormAddProd.UseVisualStyleBackColor = true;
            this.btnFormAddProd.Click += new System.EventHandler(this.btnFormAddProd_Click_1);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewOrder.FlatAppearance.BorderSize = 0;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNewOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnNewOrder.Image")));
            this.btnNewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewOrder.Location = new System.Drawing.Point(0, 80);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnNewOrder.Size = new System.Drawing.Size(220, 60);
            this.btnNewOrder.TabIndex = 5;
            this.btnNewOrder.Text = " New Order";
            this.btnNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 5;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(928, 80);
            this.panelTitleBar.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(392, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(94, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(928, 533);
            this.panelDesktopPanel.TabIndex = 6;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 613);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelMenu;
        private Panel panelLogo;
        private Button SalesReport;
        private Button StoreProducts;
        private Button btnFormAddProd;
        private Button btnNewOrder;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelDesktopPanel;
    }
}