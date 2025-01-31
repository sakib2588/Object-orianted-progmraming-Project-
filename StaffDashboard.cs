using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class StaffDashboard : Form
    {
        public static string UserID { get; set; }
        
        private DatabaseAccess Da { set; get; }
        public StaffDashboard()
        {
            InitializeComponent();
            this.Da = new DatabaseAccess();
        }
         private void StaffDashboard_Load(object sender, EventArgs e)
        {
            lbInfo.Text = "Welcome back, " + UserID;
            this.GridSoldProduct();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }
       
        bool sidebarExpand = true;
        private void SidebarTransition_Tick_1(object sender, EventArgs e)
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
                    pnSellProduct.Width = Sidebar.Width;
                    pnViewCart.Width = Sidebar.Width;   


                }
            }
            else
            {
                Sidebar.Width += 5;
                if (Sidebar.Width >= 170)
                {
                    sidebarExpand = true;
                    SidebarTransition.Stop();
                    PnDashboard.Width = Sidebar.Width;
                    PnLogOut.Width = Sidebar.Width;
                    pnSellProduct.Width = Sidebar.Width;
                    pnViewCart.Width = Sidebar.Width;

                }
            }
        }
        private void btnSellProduct_Click(object sender, EventArgs e)
        {
            StaffSellProduct sell = new StaffSellProduct();
            sell.Show();
            this.Close();
        } 
        private void btnViewCart_Click(object sender, EventArgs e)
        {

            ViewCart cart = new ViewCart();
            cart.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Close();
        }

        private void cmbStaffTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = string.Empty;
                string selectedTime = cmbStaffTime.SelectedItem.ToString();

                if (selectedTime == "Today")
                {
                    query = $"SELECT COALESCE(SUM(TotalAmount), 0) AS TotalAmount FROM Sales WHERE UserID = '{UserID}' AND CAST(SaleDate AS DATE) = CAST(GETDATE() AS DATE)";
                }
                else if (selectedTime == "Week")
                {
                    query = $"SELECT COALESCE(SUM(TotalAmount), 0) AS TotalAmount FROM Sales WHERE UserID = '{UserID}' AND DATEPART(week, SaleDate) = DATEPART(week, GETDATE()) AND DATEPART(year, SaleDate) = DATEPART(year, GETDATE())";
                }
                else if (selectedTime == "Month")
                {
                    query = $"SELECT COALESCE(SUM(TotalAmount), 0) AS TotalAmount FROM Sales WHERE UserID = '{UserID}' AND DATEPART(month, SaleDate) = DATEPART(month, GETDATE()) AND DATEPART(year, SaleDate) = DATEPART(year, GETDATE())";
                }

                DataSet ds = this.Da.ExecuteQuery(query);
                decimal totalAmount = ds.Tables[0].Rows.Count > 0 ? (decimal)ds.Tables[0].Rows[0]["TotalAmount"] : 0;
                lbTotalAmount.Text = "Total Amount: " + totalAmount.ToString("C");
            }
            catch (Exception ex)
            {
                // Handle exception
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void PopulateGrid(string query, DataGridView grid)
        {
            var ds = this.Da.ExecuteQuery(query);
            grid.AutoGenerateColumns = true;
            grid.DataSource = ds.Tables[0];
        }
        private void GridSoldProduct()
        {
            string query = $@"
                SELECT 
                    ProductID, 
                    SellingPrice AS Price, 
                    SaleDate, 
                    ProductName 
                FROM 
                    Sales 
                WHERE 
                    UserID = '{UserID}';
            ";
            PopulateGrid(query, Grid);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            this.GridSoldProduct();
        }
    }
}
