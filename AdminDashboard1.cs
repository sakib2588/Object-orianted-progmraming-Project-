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
    public partial class AdminDashboard1 : Form
    {
        public static string ID { get; set; }
        private DatabaseAccess Da { get; set; }
        public AdminDashboard1()
        {
            InitializeComponent();
            this.Da = new DatabaseAccess();
        }
        private void AdminDashboard1_Load(object sender, EventArgs e)
        {
            //lbInfo1.Text = "Welcome back, " + ID;
            this.gridSoldProduct();
            this.lnStaffNumber.Text = "00 " + this.Da.ExecuteQuery("select * from Staff").Tables[0].Rows.Count;
        } 
        private void button3_Click(object sender, EventArgs e)//////////////////////ManageStaffButtton
        {
            ManageStaff staff = new ManageStaff();
            staff.Show();
            this.Close();
        } 
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool sidebarExpand = true; 
        public void SidebarTransition_Tick(object sender, EventArgs e)
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
                    pnreport1.Width = Sidebar.Width;
                    PnStaff.Width = Sidebar.Width;
                    //panel3.Width = Sidebar.Width;
                    pnProduct.Width = Sidebar.Width;


                }
            }
            else
            {
                Sidebar.Width += 5;
                if (Sidebar.Width >= 180)
                {
                    sidebarExpand = true;
                    SidebarTransition.Stop();
                    PnDashboard.Width = Sidebar.Width;
                    PnLogOut.Width = Sidebar.Width; 
                    PnStaff.Width = Sidebar.Width;            
                    pnProduct.Width = Sidebar.Width;
                    pnreport1.Width = Sidebar.Width;

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDashboard1 admin = new AdminDashboard1();
            admin.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductInventory inventory = new ProductInventory();
            inventory.Show();
            this.Close();
        }

        private void PopulateGrid(string query, DataGridView grid)
        {
            var ds = this.Da.ExecuteQuery(query);
            grid.AutoGenerateColumns = true;
            grid.DataSource = ds.Tables[0];
        }
        /*
        private void lstSoldProduct()
        {
            string sql = "select * from SoldProduct";
            this.PopulateGrid(sql, this.lstSoldProduct);
        }*/
        private void gridSoldProduct()
        {
            string sql = "select ProductID, UserID, SaleDate, TotalAmount from Sales";
            this.PopulateGrid(sql, this.gridSoldProduct1);
        }

        private void cmbTime_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                string query = string.Empty;
                string selectedTime = cmbTime.SelectedItem.ToString();

                if (selectedTime == "Today")
                {
                    query = "SELECT COALESCE(SUM(TotalAmount), 0) AS TotalAmount FROM Sales WHERE CAST(SaleDate AS DATE) = CAST(GETDATE() AS DATE)";
                }
                else if (selectedTime == "Week")
                {
                    query = "SELECT COALESCE(SUM(TotalAmount), 0) AS TotalAmount FROM Sales WHERE DATEPART(week, SaleDate) = DATEPART(week, GETDATE()) AND DATEPART(year, SaleDate) = DATEPART(year, GETDATE())";
                }
                else if (selectedTime == "Month")
                {
                    query = "SELECT COALESCE(SUM(TotalAmount), 0) AS TotalAmount FROM Sales WHERE DATEPART(month, SaleDate) = DATEPART(month, GETDATE()) AND DATEPART(year, SaleDate) = DATEPART(year, GETDATE())";
                }

                DataSet ds = this.Da.ExecuteQuery(query);
                decimal totalAmount = ds.Tables[0].Rows.Count > 0 ? (decimal)ds.Tables[0].Rows[0]["TotalAmount"] : 0;
                lbTotalAmount.Text = "Total Amount: " + totalAmount.ToString("C");
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            this.gridSoldProduct();
        }
    }
}
