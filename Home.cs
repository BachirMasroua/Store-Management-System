namespace Store_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        public void displayForm(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(frm);
            this.panelDesktopPanel.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void btnNewOrder_Click_1(object sender, EventArgs e)
        {    
            NewOrder neworder = new NewOrder();
            displayForm(neworder);
            lblTitle.Text = "NEW ORDER";
        }

        private void btnFormAddProd_Click_1(object sender, EventArgs e)
        {
            
            AddProducts addproducts = new AddProducts();
            displayForm(addproducts);
            lblTitle.Text = "ADD PRODUCT";
        }

        private void StoreProducts_Click_1(object sender, EventArgs e)
        {
            
            StoreProducts storeproducts = new StoreProducts();
            displayForm(storeproducts);
            lblTitle.Text = "STORE PRODUCTS";
        }

        private void SalesReport_Click_1(object sender, EventArgs e)
        {           
            SalesReportForm salesReportForm = new SalesReportForm();
            displayForm(salesReportForm);
            lblTitle.Text = "SALES REPORT";
        }
    }
}