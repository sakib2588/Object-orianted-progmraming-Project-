using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class StaffSellProduct : Form
    {
        public static string UserID { get; set; }
        private DatabaseAccess Da { get; set; }

        public StaffSellProduct()
        {
            InitializeComponent();
            this.Da = new DatabaseAccess();
        }

        protected void SidebarTransition_Tick(object sender, EventArgs e)
        {
            pnSellProduct.Width = Sidebar.Width;
            pnViewCart.Width = Sidebar.Width;
            PnLogOut.Width = Sidebar.Width;
            PnDashboard.Width = Sidebar.Width;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        private void StaffSellProduct_Load(object sender, EventArgs e)
        {
            lbUserID.Text = "Welcome back, " + UserID;
            DisplaySessionID();
            PopulategridProduct();
            if (gridProduct.Rows.Count > 0)
            {
                gridProduct.ClearSelection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaffDashboard staff = new StaffDashboard();
            staff.Show();
            this.Close();
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            ViewCart view = new ViewCart();
            view.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Close();
        }

        private void gridProduct_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtProductID.Text = this.gridProduct.CurrentRow.Cells["ProductID"].Value.ToString();
                this.txtproductName.Text = this.gridProduct.CurrentRow.Cells["ProductName"].Value.ToString();
                this.txtBrand.Text = this.gridProduct.CurrentRow.Cells["Brand"].Value.ToString();
                this.txtsellingPrice.Text = this.gridProduct.CurrentRow.Cells["Price"].Value.ToString();
                this.txtstockQuantity.Text = "1";
                this.cmbSearchCategory.Text = this.gridProduct.CurrentRow.Cells["Category"].Value.ToString();
                this.txtProductSearch.Text = this.gridProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void PopulateGrid(string query, DataGridView grid)
        {
            var ds = this.Da.ExecuteQuery(query);
            grid.AutoGenerateColumns = true;
            grid.DataSource = ds.Tables[0];
        }

        private void PopulategridProduct()
        {
            try
            {
                string query = @"
                        SELECT 
                            P.ProductID, 
                            P.Category, 
                            P.ProductName, 
                            P.SellingPrice AS Price, 
                            P.StockQuantity AS Quantity, 
                            COALESCE(M.Brand, Pr.Brand, R.Brand, G.Brand, PS.Brand, Mo.Brand, S.Brand, C.Brand) AS Brand
                        FROM Product P
                        LEFT JOIN Motherboard M ON P.ProductID = M.ProductID
                        LEFT JOIN Processor Pr ON P.ProductID = Pr.ProductID
                        LEFT JOIN RAM R ON P.ProductID = R.ProductID
                        LEFT JOIN GPU G ON P.ProductID = G.ProductID
                        LEFT JOIN PowerSupply PS ON P.ProductID = PS.ProductID
                        LEFT JOIN Monitor Mo ON P.ProductID = Mo.ProductID
                        LEFT JOIN SSD S ON P.ProductID = S.ProductID
                        LEFT JOIN Casing C ON P.ProductID = C.ProductID;
                    ";
                PopulateGrid(query, this.gridProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while populating the product grid: " + ex.Message);
            }
        }

        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                string query = @"
                        SELECT 
                            P.ProductID, 
                            P.Category, 
                            P.ProductName, 
                            P.SellingPrice AS Price, 
                            P.StockQuantity AS Quantity, 
                            COALESCE(M.Brand, Pr.Brand, R.Brand, G.Brand, PS.Brand, Mo.Brand, S.Brand, C.Brand) AS Brand
                        FROM Product P
                        LEFT JOIN Motherboard M ON P.ProductID = M.ProductID
                        LEFT JOIN Processor Pr ON P.ProductID = Pr.ProductID
                        LEFT JOIN RAM R ON P.ProductID = R.ProductID
                        LEFT JOIN GPU G ON P.ProductID = G.ProductID
                        LEFT JOIN PowerSupply PS ON P.ProductID = PS.ProductID
                        LEFT JOIN Monitor Mo ON P.ProductID = Mo.ProductID
                        LEFT JOIN SSD S ON P.ProductID = S.ProductID
                        LEFT JOIN Casing C ON P.ProductID = C.ProductID
                        WHERE P.Category = '" + this.cmbSearchCategory.Text + "';";
                PopulateGrid(query, this.gridProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ClearAllTxt()
        {
            this.txtProductID.Text = "";
            this.txtproductName.Text = "";
            this.txtBrand.Text = "";
            this.txtsellingPrice.Text = "";
            this.txtstockQuantity.Text = "";
            this.cmbSearchCategory.Text = "";
            this.txtProductSearch.Text = "";
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = @"SELECT * FROM Product WHERE ProductName LIKE '%" + this.txtProductSearch.Text + "%';";
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.gridProduct.DataSource = ds.Tables[0];
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            PopulategridProduct();
            if (gridProduct.Rows.Count > 0)
            {
                gridProduct.ClearSelection();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAllTxt();
        }

        private string GetSessionID()
        {
            var sql = "SELECT SessionID FROM CartSession WHERE UserID = '" + UserID + "' ORDER BY DateCreated DESC OFFSET 0 ROWS FETCH FIRST 1 ROW ONLY;";
            DataSet ds = this.Da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows[0]["SessionID"].ToString();
            }
            else
            {
                MessageBox.Show("No active session found for the user.");
                return null;
            }
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            try
            {
                string sessionID = GetSessionID();
                if (sessionID == null)
                {
                    return;
                }

                string id = this.gridProduct.CurrentRow.Cells["ProductID"].Value.ToString();
                int availableQuantity = Convert.ToInt32(this.gridProduct.CurrentRow.Cells["StockQuantity"].Value);
                int requestedQuantity = Convert.ToInt32(this.txtstockQuantity.Text);

                if (availableQuantity < requestedQuantity)
                {
                    MessageBox.Show("Not Enough Product");
                    return;
                }

                if (availableQuantity > 0)
                {
                    this.Da.ExecuteDMLQuery($"UPDATE Product SET StockQuantity = {availableQuantity - requestedQuantity} WHERE ProductID='{id}';");
                }
                else
                {
                    MessageBox.Show("No product available for current selection");
                    return;
                }

                string sqlCart = $"SELECT * FROM CartItems WHERE ProductID='{id}' AND SessionID='{sessionID}'";
                DataSet dsCart = this.Da.ExecuteQuery(sqlCart);

                if (dsCart.Tables[0].Rows.Count == 1)
                {
                    int previousQuantity = Convert.ToInt32(dsCart.Tables[0].Rows[0]["Quantity"]);
                    int newQuantity = previousQuantity + requestedQuantity;
                    string updateSql = $"UPDATE CartItems SET Quantity = {newQuantity} WHERE ProductID = '{id}' AND SessionID='{sessionID}';";
                    this.Da.ExecuteDMLQuery(updateSql);
                }
                else
                {
                    string insertSql = $"INSERT INTO CartItems (SessionID, ProductID, ProductName, Brand, SellingPrice, Quantity) " +
                                       $"VALUES('{sessionID}', '{this.txtProductID.Text}', '{this.txtproductName.Text}', '{this.txtBrand.Text}', {this.txtsellingPrice.Text}, {requestedQuantity});";
                    this.Da.ExecuteDMLQuery(insertSql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("First Select a Product " + ex.Message);
            }
        }

        private void DisplaySessionID()
        {
            string sessionID = GetSessionID();
            if (sessionID != null)
            {
                txtSession.Text = sessionID;
            }
        }
    }

}

