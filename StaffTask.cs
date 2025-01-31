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
    public partial class StaffTask : Form
    {
        public StaffTask()
        {
            InitializeComponent();
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

        private void button5_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaffTask task = new StaffTask();
            task.Show();
            this.Close();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            MenuTransition.Start();
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            ViewCart sell = new ViewCart();
            sell.Show();
            this.Close();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
           // SellProduct inventory = new SellProduct();
           // inventory.Show();
            this.Close();
        }
        bool menuExpand = false;
        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {

                ProductMenu.Height += 10;
                if (ProductMenu.Height >= 115)
                {
                    MenuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                ProductMenu.Height -= 10;
                if (ProductMenu.Height <= 44)
                {
                    MenuTransition.Stop(); menuExpand = false;
                }
            }
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
                    PnStaff.Width = Sidebar.Width;
                    ProductMenu.Width = Sidebar.Width;
                    ProductMenu.Height = 44; // Set ProductMenu height to 53
                    Product.Enabled = false; // Disable Product button
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
                    PnStaff.Width = Sidebar.Width;
                    ProductMenu.Width = Sidebar.Width;
                    Product.Enabled = true; // Enable Product button
                    Sell.Visible = true; // Show Add Product button
                    Inventory.Visible = true; // Show Remove Product button
                }
            }
        }
    }

}
