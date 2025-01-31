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
    public partial class Report : Form
    {
        private DatabaseAccess Da { get; set; }

        public Report()
        {
            InitializeComponent();
            this.Da = new DatabaseAccess();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ManageStaff staff = new ManageStaff();
            staff.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AdminDashboard1 admin = new AdminDashboard1();
            admin.Show();
            this.Close();
        }

        private void btnShowSell_Click(object sender, EventArgs e)
        {
            PopulategridAllSoleProduct();
            if (gridSoldProduct.Rows.Count > 0)
            {
                gridSoldProduct.ClearSelection();
            }
        }

        private void PopulateGrid(string query, DataGridView grid)
        {
            var ds = this.Da.ExecuteQuery(query);
            grid.AutoGenerateColumns = true;
            grid.DataSource = ds.Tables[0];
        }

        private void PopulategridAllSoleProduct()
        {
            string query = @"Select * from Sales;";
            this.PopulateGrid(query, this.gridSoldProduct);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        private void Report_Load_1(object sender, EventArgs e)
        {
            this.PopulategridAllSoleProduct();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ProductInventory product = new ProductInventory();
            product.Show();
            this.Close();
        }
    }


}

