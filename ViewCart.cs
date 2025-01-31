using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ViewCart : Form
    {
         private DatabaseAccess Da { get; set; }
        public static string UserID { get; set; }
        public ViewCart()
        {
            InitializeComponent();
            this.Da = new DatabaseAccess();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaffDashboard staff = new StaffDashboard();
            staff.Show();
            this.Close();
        }
        bool sidebarExpand = true;
        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                Sidebar.Width -= 5;
                if (Sidebar.Width <= 75)
                {
                    sidebarExpand = false;
                    SidebarTransition.Stop();
                    PnDashboard.Width = Sidebar.Width;
                    PnLogOut.Width = Sidebar.Width;
                    //PnReport.Width = Sidebar.Width;
                    pnSellProduct.Width = Sidebar.Width;
                    pnViewCart.Width = Sidebar.Width;


                }
            }
            else
            {
                Sidebar.Width += 5;
                if (Sidebar.Width >= 160)
                {
                    sidebarExpand = true;
                    SidebarTransition.Stop();
                    PnDashboard.Width = Sidebar.Width;
                    PnLogOut.Width = Sidebar.Width;
                    //PnReport.Width = Sidebar.Width;
                    pnViewCart.Width = Sidebar.Width;
                    pnSellProduct.Width = Sidebar.Width;

                }
            }
        }
        private void SellProduct_Load(object sender, EventArgs e)
        {
            lbUserID.Text = "Welcome back, " + UserID;
            DisplaySessionID();
            this.ShowCart();
            if (gridCartItems.Rows.Count > 0)
            {
                gridCartItems.ClearSelection();
            }
        }
        private void btnSellProduct_Click(object sender, EventArgs e)
        {
            StaffSellProduct sell = new StaffSellProduct();
            sell.Show();
            this.Close();
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Close();
        }
        private void PopulateGrid(string query, DataGridView grid)
        {
            var ds = this.Da.ExecuteQuery(query);
            grid.AutoGenerateColumns = true;
            grid.DataSource = ds.Tables[0];
        }
        private void PopulategridProduct()
        {
            string query = @"Select * from CartItems;";
            this.PopulateGrid(query, this.gridCartItems);
        }
        private void ShowCart()
        {
            PopulategridProduct();
            if (gridCartItems.Rows.Count > 0)
            {
                gridCartItems.ClearSelection();
            }
        }
        private string selectedProductId;
        private int selectedQuantity;
        private void btnShowCart_Click(object sender, EventArgs e)
        {
            this.ShowCart();
        }
        private void GridCartItems_Click(object sender, EventArgs e)
        {

            if (gridCartItems.SelectedRows.Count > 0)
            {
                selectedProductId = gridCartItems.SelectedRows[0].Cells["ProductID"].Value.ToString();
                selectedQuantity = int.Parse(gridCartItems.SelectedRows[0].Cells["Quantity"].Value.ToString());
            }
        }

        private void BtnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedProductId))
            {
                // Remove the item from CartItems table
                string deleteQuery = $"DELETE FROM CartItems WHERE ProductID = '{selectedProductId}'";
                this.Da.ExecuteDMLQuery(deleteQuery);

                // Update the stock quantity in Product table
                string updateQuery = $"UPDATE Product SET StockQuantity = StockQuantity + {selectedQuantity} WHERE ProductID = '{selectedProductId}'";
                this.Da.ExecuteDMLQuery(updateQuery);

                // Refresh the grid
                this.ShowCart();
            }
        }
        private string GenerateNewSessionID()
        {
            try
            {
                var sql = "SELECT * FROM CartSession ORDER BY SessionID DESC;";
                var ds = this.Da.ExecuteQuery(sql);
                var dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    string lastSerial = dt.Rows[0]["SessionID"].ToString();
                    int serialNumber = int.Parse(lastSerial.Substring(8)); // Skip 'session-' and parse the number
                    string newSerial = "session-" + (serialNumber + 1).ToString("D3"); // Format to keep leading zeros
                    return newSerial;
                }
                else
                {
                    return "session-001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
        

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (!rbcash.Checked && !rbCredit.Checked)
                {
                    MessageBox.Show("Please select a payment method.");
                    return;
                }

                if (gridCartItems.Rows.Count == 0)
                {
                    MessageBox.Show("No items in cart.");
                    return;
                }

                if (string.IsNullOrEmpty(UserID))
                {
                    MessageBox.Show("User is not logged in.");
                    return;
                }

                string sessionID = GetSessionID();
                if (string.IsNullOrEmpty(sessionID))
                {
                    MessageBox.Show("Session ID is missing.");
                    return;
                }

                string paymentMethod = rbcash.Checked ? "Cash" : "Credit";

                // Validate each cart item before processing
                foreach (DataGridViewRow row in gridCartItems.Rows)
                {
                    // Skip null or empty rows
                    if (row.IsNewRow) continue;

                    // Comprehensive null/empty checks for critical fields
                    string productId = row.Cells["ProductID"]?.Value?.ToString();
                    string productName = row.Cells["ProductName"]?.Value?.ToString();
                    string brand = row.Cells["Brand"]?.Value?.ToString();
                    string sellingPrice = row.Cells["SellingPrice"]?.Value?.ToString();
                    string quantity = row.Cells["Quantity"]?.Value?.ToString();

                    if (string.IsNullOrEmpty(productId) ||
                        string.IsNullOrEmpty(productName) ||
                        string.IsNullOrEmpty(sellingPrice) ||
                        string.IsNullOrEmpty(quantity))
                    {
                        MessageBox.Show($"Invalid item found: Product ID {productId ?? "N/A"}. Please check your cart.");
                        return;
                    }

                    // Insert sale record
                    string query = $"INSERT INTO Sales (UserID, ProductID, ProductName, Brand, SellingPrice, Quantity, SaleDate, PaymentMethod, SessionID) " +
                                   $"VALUES('{UserID}', '{productId}', '{productName}', '{brand ?? ""}', '{sellingPrice}', '{quantity}', '{DateTime.Now:yyyy-MM-dd}', '{paymentMethod}', '{sessionID}')";
                    this.Da.ExecuteDMLQuery(query);
                }

                // Clear cart after payment
                string deleteQuery = $"DELETE FROM CartItems WHERE SessionID = '{sessionID}'";
                this.Da.ExecuteDMLQuery(deleteQuery);

                // Generate new session ID and insert
                string newSessionID = GenerateNewSessionID();
                string insertSessionQuery = $"INSERT INTO CartSession (SessionID, UserID, DateCreated) VALUES ('{newSessionID}', '{UserID}', '{DateTime.Now:yyyy-MM-dd HH:mm:ss}')";
                this.Da.ExecuteDMLQuery(insertSessionQuery);

                // Refresh the grid
                this.ShowCart();
                MessageBox.Show("Payment successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private string GetSessionID()
        {
            var sql = "SELECT SessionID FROM CartSession WHERE UserID = '" + UserID + "' ORDER BY DateCreated DESC OFFSET 0 ROWS FETCH FIRST 1 ROW ONLY;";
            DataSet ds = this.Da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                string sessionID = ds.Tables[0].Rows[0]["SessionID"].ToString();
                return sessionID;
            }
            else
            {
                MessageBox.Show("No active session found for the user.");
                return null;
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
