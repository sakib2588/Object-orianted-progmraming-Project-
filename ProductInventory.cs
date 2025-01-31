using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProductInventory : Form
    {  
        private DatabaseAccess Da { get; set; }
       
        private bool sidebarExpand = true;

        public ProductInventory()
        {
            InitializeComponent();
            this.Da = new DatabaseAccess();
        }

        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            Sidebar.Width += sidebarExpand ? -5 : 5;
            if (Sidebar.Width <= 75 || Sidebar.Width >= 180)
            {
                sidebarExpand = !sidebarExpand;
                SidebarTransition.Stop();
                AdjustPanelWidths(Sidebar.Width);
            }
        }

        private void AdjustPanelWidths(int width)
        {
            PnDashboard.Width = width;
            PnLogOut.Width = width;
            panel4.Width = width;
            PnStaff.Width = width;
            panel2.Width = width;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AdminDashboard1 adminDashboard1 = new AdminDashboard1();
            adminDashboard1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ManageStaff staff = new ManageStaff();
            staff.Show();
            this.Close();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenForm(Form form)
        {
            form.Show();
            this.Close();
        }

        private void PopulateGrid(string query, DataGridView grid)
        {
            var ds = this.Da.ExecuteQuery(query);
            grid.AutoGenerateColumns = true;
            grid.DataSource = ds.Tables[0];
        }

        private void btnMotherboardViewProduct_Click(object sender, EventArgs e)
        {
            PopulateGridMotherboard();
            this.AutoMotherboardSerialGenerate();
            this.ClearAllTxtFromMotherboard();
            this.AutoProductIdGenerate();
            SelectLastRow(this.gridMotherboard); // Select last row
        }

        private void btnProcessorViewProduct_Click(object sender, EventArgs e)
        {
            PopulateGridProcessor();
            this.ClearAllTxtFromProcessor();
            this.AutoProcessorSerialGenerate();
            this.AutoProductIdGenerate();
            SelectLastRow(this.GridProcessorTable); // Select last row
        }

        private void btnMonitorViewProduct_Click(object sender, EventArgs e)
        {
            PopulateGridMonitor();
            this.ClearAllTxtFromMonitor();
            this.AutoMonitorSerialGenerate();
            this.AutoProductIdGenerate();
            SelectLastRow(this.GridMonitorTable); // Select last row
        }

        private void btnGpuViewProduct_Click(object sender, EventArgs e)
        {
            PopulateGridGpu();
            this.ClearAllTxtFromGpu();
            this.AutoGpuSerialGenerate();
            this.AutoProductIdGenerate();
            SelectLastRow(this.GridGpuTable); // Select last row
        }

        private void btnRamViewPrduct_Click(object sender, EventArgs e)
        {
            PopulateGridRam();
            this.ClearAllTxtFromRam();
            this.AutoRamSerialGenerate();
            this.AutoProductIdGenerate();
            SelectLastRow(this.GridRamTable); // Select last row
        }

        private void btnPowerSupplyViewProduct_Click(object sender, EventArgs e)
        {
            PopulateGridPowerSupply();
            this.ClearAllTxtFromPowerSupply();
            this.AutoPowerSupplySerialGenerate();
            this.AutoProductIdGenerate();
            SelectLastRow(this.GridPowerSupplyTable); // Select last row
        }

        private void btnCasingView_Click(object sender, EventArgs e)
        {
            PopulateGridCasing();
            this.ClearAllTxtFromCasing();
            this.AutoCasingSerialGenerate();
            this.AutoProductIdGenerate();
            SelectLastRow(this.gridCasingTable); // Select last row
        }

        private void SelectLastRow(DataGridView grid)
        {
            if (grid.Rows.Count > 0)
            {
                int lastRowIndex = grid.Rows.Count - 1;
                grid.Rows[lastRowIndex].Selected = true;
                grid.FirstDisplayedScrollingRowIndex = lastRowIndex;
            }
        }

        private void btnSsdView_Click(object sender, EventArgs e)
        {
            PopulateGridSsd();
            this.ClearAllTxtFromSsd();
            this.AutoSsdSerialGenerate();
            this.AutoProductIdGenerate();
            this.GridSsdTable.ClearSelection(); // Clear selection
        }
        private bool IsValidMotherboard()
        {
            if (string.IsNullOrEmpty(this.cmbMotherboardBrand.Text) || string.IsNullOrEmpty(this.cmbMotherboardCPUsocket.Text) || string.IsNullOrEmpty(this.txtMotherboardstockQuantity.Text) || string.IsNullOrEmpty(this.txtMotherboardrestockPrice.Text) || string.IsNullOrEmpty(this.txtMotherboardsellingPrice.Text) || string.IsNullOrEmpty(this.cmbMotherboardFromFactor.Text) || string.IsNullOrEmpty(this.txtMotherboardproductName.Text) || this.cmbMotherboardBrand.SelectedIndex == -1 || this.cmbMotherboardCPUsocket.SelectedIndex == -1 || this.cmbMotherboardCategory.SelectedIndex == -1 || this.cmbMotherboardFromFactor.SelectedIndex == -1 || this.cmbMotherboardNumberOfCore.SelectedIndex == -1 || this.cmbMotherboardRamType.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsValidProcessor()
        {
            if (string.IsNullOrEmpty(this.cmbProcessorBrand.Text) || string.IsNullOrEmpty(this.cmbProcessorSocket.Text) || string.IsNullOrEmpty(this.txtProcessorStockQuantity.Text) || string.IsNullOrEmpty(this.txtProcessorRestockPrice.Text) || string.IsNullOrEmpty(this.txtProcessorSellingPrice.Text) || string.IsNullOrEmpty(this.txtProcessorProductName.Text) || this.cmbProcessorBrand.SelectedIndex == -1 || this.cmbProcessorCategory.SelectedIndex == -1 || this.cmbProcessorNumberOfCore.SelectedIndex == -1 || this.cmbProcessorSocket.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsValidMonitor()
        {
            if (string.IsNullOrEmpty(this.cmbMonitorBrand.Text) || string.IsNullOrEmpty(this.cmbMonitorPanelType.Text) || string.IsNullOrEmpty(this.cmbMonitorRsolution.Text) || string.IsNullOrEmpty(this.cmbMonitorscreenSize.Text) || string.IsNullOrEmpty(this.cmbMonitorRefreshRate.Text) || string.IsNullOrEmpty(this.txtMonitorStockQuantity.Text) || string.IsNullOrEmpty(this.txtMonitorRestockPrice.Text) || string.IsNullOrEmpty(this.txtMonitorSellingPrice.Text) || string.IsNullOrEmpty(this.txtMonitorProductName.Text) || this.cmbMonitorBrand.SelectedIndex == -1 || this.cmbMonitorCategory.SelectedIndex == -1 || this.cmbMonitorPanelType.SelectedIndex == -1 || this.cmbMonitorRsolution.SelectedIndex == -1 || this.cmbMonitorscreenSize.SelectedIndex == -1 || this.cmbMonitorRefreshRate.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsValidGpu()
        {
            if (string.IsNullOrEmpty(this.cmbGpuBrand.Text) || string.IsNullOrEmpty(this.cmbGpuChipset.Text) || string.IsNullOrEmpty(this.cmbGpuMemoryType.Text) || string.IsNullOrEmpty(this.txtGpuStockQuantity.Text) || string.IsNullOrEmpty(this.txtGpuRestockPrice.Text) || string.IsNullOrEmpty(this.txtGpuSellingPrice.Text) || string.IsNullOrEmpty(this.txtGpuProductName.Text) || this.cmbGpuBrand.SelectedIndex == -1 || this.cmbGpuCategory.SelectedIndex == -1 || this.cmbGpuChipset.SelectedIndex == -1 || this.cmbGpuMemoryType.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsValidRam()
        {
            if (string.IsNullOrEmpty(this.cmbRamBrand.Text) || string.IsNullOrEmpty(this.cmbRamMemoryType.Text) || string.IsNullOrEmpty(this.txtRamStockQuantity.Text) || string.IsNullOrEmpty(this.txtRamResotckPrice.Text) || string.IsNullOrEmpty
                (this.txtRamSellingPrice.Text) || string.IsNullOrEmpty(this.txtRamProductName.Text) || this.cmbRamBrand.SelectedIndex == -1 || this.cmbRamCategory.SelectedIndex == -1 || this.cmbRamMemoryType.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsValidPowerSupply()
        {
            if (string.IsNullOrEmpty(this.cmbPowerSupplyBrand.Text) || string.IsNullOrEmpty(this.cmbPowerSupplyModular.Text) || string.IsNullOrEmpty(this.cmbPowerSupplyWattage.Text) || string.IsNullOrEmpty(this.cmbPowerSupplyEfficiency.Text) || string.IsNullOrEmpty(this.txtPowerSupplyStockQuantity.Text) || string.IsNullOrEmpty(this.txtPowerSupplyRestockPrice.Text) || string.IsNullOrEmpty(this.txtPowerSupplySellingPrice.Text) || string.IsNullOrEmpty(this.txtPowerSupplyProductName.Text) || this.cmbPowerSupplyBrand.SelectedIndex == -1 || this.cmbPowerSupplyCategory.SelectedIndex == -1 || this.cmbPowerSupplyEfficiency.SelectedIndex == -1 || this.cmbPowerSupplyModular.SelectedIndex == -1 || this.cmbPowerSupplyWattage.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsValidCasing()
        {
            if (string.IsNullOrEmpty(this.cmbCasingBrand.Text) || string.IsNullOrEmpty(this.cmbCasingColor.Text) || string.IsNullOrEmpty(this.cmbCasingType.Text) || string.IsNullOrEmpty
                (this.cmbCasingMotherboardType.Text) || string.IsNullOrEmpty(this.cmbCasingSidePanel.Text) || string.IsNullOrEmpty(this.txtCasingStockQuantity.Text) || string.IsNullOrEmpty(this.txtCasingRestockPrice.Text) || string.IsNullOrEmpty(this.txtCasingSellingPrice.Text) || string.IsNullOrEmpty(this.txtCasingProductName.Text) || this.cmbCasingBrand.SelectedIndex == -1 || this.cmbCasingCategory.SelectedIndex == -1 || this.cmbCasingColor.SelectedIndex == -1 || this.cmbCasingMotherboardType.SelectedIndex == -1 || this.cmbCasingSidePanel.SelectedIndex == -1 || this.cmbCasingType.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsValidSsd()
        {
            if (string.IsNullOrEmpty(this.cmbSsdBrand.Text) || string.IsNullOrEmpty(this.cmbSsdInterfaceType.Text) || string.IsNullOrEmpty(this.cmbSsdCapacity.Text) || string.IsNullOrEmpty(this.cmbSsdReadSpeed.Text) || string.IsNullOrEmpty(this.txtSsdStockQuantity.Text) || string.IsNullOrEmpty(this.txtSsdRestockPrice.Text) || string.IsNullOrEmpty
                (this.txtSsdSellingPrice.Text) || string.IsNullOrEmpty(this.txtSsdProductName.Text) || this.cmbSsdBrand.SelectedIndex == -1 || this.cmbSsdCategory.SelectedIndex == -1 || this.cmbSsdCapacity.SelectedIndex == -1 || this.cmbSsdInterfaceType.SelectedIndex == -1 || this.cmbSsdReadSpeed.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ClearAllTxtFromMotherboard()
        {
            this.txtMotherboardstockQuantity.Text = "";
            this.txtMotherboardrestockPrice.Text = "";
            this.txtMotherboardsellingPrice.Text = "";
            this.txtMotherboardproductName.Text = "";
            this.cmbMotherboardRamType.SelectedIndex = -1;
            this.cmbMotherboardNumberOfCore.SelectedIndex = -1;
            this.cmbMotherboardBrand.SelectedIndex = -1;
            this.cmbMotherboardCPUsocket.SelectedIndex = -1;
            this.cmbMotherboardFromFactor.SelectedIndex = -1;
            this.cmbMotherboardCategory.SelectedIndex = -1; 
            this.AutoMotherboardSerialGenerate();
            this.AutoProductIdGenerate();
        }
        private void ClearAllTxtFromProcessor()
        {
            this.txtProcessorStockQuantity.Text = "";
            this.txtProcessorRestockPrice.Text = "";
            this.txtProcessorSellingPrice.Text = "";
            this.txtProcessorProductName.Text = "";
            this.cmbProcessorBrand.SelectedIndex = -1;
            this.cmbProcessorSocket.SelectedIndex = -1;
            this.cmbProcessorNumberOfCore.SelectedIndex = -1;
            this.cmbProcessorCategory.SelectedIndex = -1;
            this.cmbProcessorClockSpeed.SelectedIndex = -1;
            //this.txtProcessorProductID.Text = "";
            this.AutoProductIdGenerate();
            this.AutoProcessorSerialGenerate();
        }
        private void ClearAllTxtFromMonitor()
        {
            this.txtMonitorStockQuantity.Text = "";
            this.txtMonitorRestockPrice.Text = "";
            this.txtMonitorSellingPrice.Text = "";
            this.txtMonitorProductName.Text = "";
            this.cmbMonitorBrand.SelectedIndex = -1;
            this.cmbMonitorPanelType.SelectedIndex = -1;
            this.cmbMonitorRsolution.SelectedIndex = -1;
            this.cmbMonitorscreenSize.SelectedIndex = -1;
            this.cmbMonitorRefreshRate.SelectedIndex = -1;
            this.cmbMonitorCategory.SelectedIndex = -1;
            this.AutoMonitorSerialGenerate();
            this.AutoProductIdGenerate();

        }
        private void ClearAllTxtFromGpu()
        {
            this.txtGpuStockQuantity.Text = "";
            this.txtGpuRestockPrice.Text = "";
            this.txtGpuSellingPrice.Text = "";
            this.txtGpuProductName.Text = "";
            this.cmbGpuBrand.SelectedIndex = -1;
            this.cmbGpuChipset.SelectedIndex = -1;
            this.cmbGpuMemoryType.SelectedIndex = -1;
            this.cmbGpuCategory.SelectedIndex = -1;
            this.cmbGpuMaxResolution.SelectedIndex = -1;
            this.cmbGpuMemory.SelectedIndex = -1;
            this.AutoProductIdGenerate();
            this.AutoGpuSerialGenerate();

        }
        private void ClearAllTxtFromRam()
        {
            this.txtRamStockQuantity.Text = "";
            this.txtRamResotckPrice.Text = "";
            this.txtRamSellingPrice.Text = "";
            this.txtRamProductName.Text = "";
            this.cmbRamBrand.SelectedIndex = -1;
            this.cmbRamMemoryType.SelectedIndex = -1;
            this.cmbRamCategory.SelectedIndex = -1;
            this.cmbRamBusSpeed.SelectedIndex = -1;
            this.cmbRamOtherFeature.SelectedIndex = -1;
            this.cmbRamCapacity.SelectedIndex = -1;
            this.AutoRamSerialGenerate();
            this.AutoProductIdGenerate();
        }
        private void ClearAllTxtFromPowerSupply()
        {
            this.txtPowerSupplyStockQuantity.Text = "";
            this.txtPowerSupplyRestockPrice.Text = "";
            this.txtPowerSupplySellingPrice.Text = "";
            this.txtPowerSupplyProductName.Text = "";
            this.cmbPowerSupplyBrand.SelectedIndex = -1;
            this.cmbPowerSupplyModular.SelectedIndex = -1;
            this.cmbPowerSupplyCategory.SelectedIndex = -1;
            this.cmbPowerSupplyEfficiency.SelectedIndex = -1;
            this.cmbPowerSupplyWattage.SelectedIndex = -1;
            this.AutoProductIdGenerate();
            this.AutoPowerSupplySerialGenerate();


        }
        private void ClearAllTxtFromCasing()
        {
            this.txtCasingStockQuantity.Text = "";
            this.txtCasingRestockPrice.Text = "";
            this.txtCasingSellingPrice.Text = "";
            this.txtCasingProductName.Text = "";
            this.cmbCasingBrand.SelectedIndex = -1;
            this.cmbCasingColor.SelectedIndex = -1;
            this.cmbCasingType.SelectedIndex = -1;
            this.cmbCasingMotherboardType.SelectedIndex = -1;
            this.cmbCasingSidePanel.SelectedIndex = -1;
            this.cmbCasingCategory.SelectedIndex = -1; 
            this.AutoCasingSerialGenerate();
            this.AutoProductIdGenerate();

        }
        private void ClearAllTxtFromSsd()
        {
            this.txtSsdStockQuantity.Text = "";
            this.txtSsdRestockPrice.Text = "";
            this.txtSsdSellingPrice.Text = "";
            this.txtSsdProductName.Text = "";
            this.cmbSsdBrand.SelectedIndex = -1;
            this.cmbSsdInterfaceType.SelectedIndex = -1;
            this.cmbSsdCategory.SelectedIndex = -1;
            this.cmbSsdCapacity.SelectedIndex = -1;
            this.cmbSsdReadSpeed.SelectedIndex = -1;
            this.AutoSsdSerialGenerate();
            this.AutoProductIdGenerate();

        }

        private void PopulateGridMotherboard()
        {
            string query = @"
                SELECT 
                    p.ProductID,
                    p.ProductName,
                    p.Category,
                    p.SellingPrice,
                    p.RestockPrice,
                    p.DateAdded,
                    p.StockQuantity,
                    m.MSerial,
                    m.Brand,
                    m.CpuSocket,
                    m.NumberOfCores,
                    m.RamType,
                    m.FormFactor
                FROM 
                    Product p
                JOIN 
                    Motherboard m 
                ON 
                    p.ProductID = m.ProductID
                ";
            PopulateGrid(query, this.gridMotherboard);
        }

        private void PopulateGridProcessor()
        {
            string query = @"
                    SELECT 
                        p.ProductID,
                        p.ProductName,
                        p.Category,
                        p.SellingPrice,
                        p.RestockPrice,
                        p.DateAdded,
                        p.StockQuantity,
                        pr.PSerial,
                        pr.Brand,
                        pr.Socket,
                        pr.NumberOfCores,
                        pr.ClockSpeed
                    FROM 
                        Product p
                    JOIN 
                        Processor pr 
                    ON 
                        p.ProductID = pr.ProductID;";
            PopulateGrid(query, this.GridProcessorTable);
        }

        private void PopulateGridMonitor()
        {
            string query = @"
                    SELECT 
                        p.ProductID,
                        p.ProductName,
                        p.Category,
                        p.SellingPrice,
                        p.RestockPrice,
                        p.DateAdded,
                        p.StockQuantity,
                        m.MonitorSerial,
                        m.Brand,
                        m.PanelType,
                        m.Resolution,
                        m.ScreenSize,
                        m.RefreshRate
                    FROM 
                        Product p
                    JOIN 
                        Monitor m 
                    ON 
                        p.ProductID = m.ProductID;";
            PopulateGrid(query, this.GridMonitorTable);
        }

        private void PopulateGridGpu()
        {
            string query = @"
                    SELECT 
                        p.ProductID,
                        p.ProductName,
                        p.Category,
                        p.SellingPrice,
                        p.RestockPrice,
                        p.DateAdded,
                        p.StockQuantity,
                        g.GSerial,
                        g.Brand,
                        g.Chipset,
                        g.Memory,
                        g.MemoryType,
                        g.MaxResolution
                    FROM 
                        Product p
                    JOIN 
                        GPU g 
                    ON 
                        p.ProductID = g.ProductID;";
            PopulateGrid(query, this.GridGpuTable);
        }

        private void PopulateGridRam()
        {
            string query = @"
                    SELECT 
                        p.ProductID,
                        p.ProductName,
                        p.Category,
                        p.SellingPrice,
                        p.RestockPrice,
                        p.DateAdded,
                        p.StockQuantity,
                        r.RSerial,
                        r.Brand,
                        r.Capacity,
                        r.MemoryType,
                        r.BusSpeed,
                        r.OtherFeatures
                    FROM 
                        Product p
                    JOIN 
                        RAM r 
                    ON 
                        p.ProductID = r.ProductID;";
            PopulateGrid(query, this.GridRamTable);
        }

        private void PopulateGridPowerSupply()
        {
            string query = @"
                    SELECT 
                        p.ProductID,
                        p.ProductName,
                        p.Category,
                        p.SellingPrice,
                        p.RestockPrice,
                        p.DateAdded,
                        p.StockQuantity,
                        ps.PSSerial,
                        ps.Brand,
                        ps.Modular,
                        ps.Wattage,
                        ps.Efficiency
                    FROM 
                        Product p
                    JOIN 
                        PowerSupply ps 
                    ON 
                        p.ProductID = ps.ProductID;";
            PopulateGrid(query, this.GridPowerSupplyTable);
        }

        private void PopulateGridCasing()
        {
            string query = @"
                    SELECT 
                        p.ProductID,
                        p.ProductName,
                        p.Category,
                        p.SellingPrice,
                        p.RestockPrice,
                        p.DateAdded,
                        p.StockQuantity,
                        c.CASerial,
                        c.Brand,
                        c.Color,
                        c.Type,
                        c.MotherboardType,
                        c.SidePanel
                    FROM 
                        Product p
                    JOIN 
                        Casing c 
                    ON 
                        p.ProductID = c.ProductID;";
            PopulateGrid(query, this.gridCasingTable);
        }

        private void PopulateGridSsd()
        {
            //PopulateGridSsd will show the data of the SSD table in the grid
            string query = @"
                    SELECT 
                        p.ProductID,
                        p.ProductName,
                        p.Category,
                        p.SellingPrice,
                        p.RestockPrice,
                        p.DateAdded,
                        p.StockQuantity,
                        s.SSDSerial,
                        s.Brand,
                        s.InterfaceType,
                        s.Capacity,
                        s.ReadSpeed
                    FROM 
                        Product p
                    JOIN 
                        SSD s 
                    ON 
                        p.ProductID = s.ProductID;";
            PopulateGrid(query, this.GridSsdTable);

        }

       
        private void btnMotherboardUpdateProduct_Click(object sender, EventArgs e)
        {
            //if i press this button the product information will be updated or added
            try
            {
                if (IsValidMotherboard())
                {
                    // Check if the product already exists
                    var checkSql = "SELECT COUNT(*) FROM Product WHERE ProductID = '" + this.txtMotherboardproductID.Text + "';";
                    var ds = this.Da.ExecuteQuery(checkSql);
                    int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());

                    if (count == 1)
                    {
                        // Update Product table
                        var sql = @"UPDATE Product 
                                    SET ProductName = '" + this.txtMotherboardproductName.Text + "', Category = '" + this.cmbMotherboardCategory.Text +
                                    "', SellingPrice = " + this.txtMotherboardsellingPrice.Text + ", RestockPrice = " + this.txtMotherboardrestockPrice.Text +
                                    ", StockQuantity = " + this.txtMotherboardstockQuantity.Text + " WHERE ProductID = '" + this.txtMotherboardproductID.Text + "';";

                        int updateCount = this.Da.ExecuteDMLQuery(sql);
                        if (updateCount == 1)
                        {
                            // Update Motherboard table
                            var sql2 = @"UPDATE Motherboard 
                                         SET Brand = '" + this.cmbMotherboardBrand.Text + "', CpuSocket = '" + this.cmbMotherboardCPUsocket.Text +
                                         "', NumberOfCores = '" + this.cmbMotherboardNumberOfCore.Text + "', RamType = '" + this.cmbMotherboardRamType.Text +
                                         "', FormFactor = '" + this.cmbMotherboardFromFactor.Text + "' WHERE MSerial = '" + this.txtMotherboardmSerial.Text + "';";

                            int updateCount2 = this.Da.ExecuteDMLQuery(sql2);
                            if (updateCount2 == 1)
                            {
                                MessageBox.Show("Data Updated Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update Motherboard table");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Product table");
                        }
                    }
                    else
                    {
                        // Insert into Product table
                        var sql = @"INSERT INTO Product (ProductID, ProductName, Category, SellingPrice, RestockPrice, StockQuantity, DateAdded) 
                                    VALUES ('" + this.txtMotherboardproductID.Text + "','" + this.txtMotherboardproductName.Text + "', '" + this.cmbMotherboardCategory.Text + "', " + this.txtMotherboardsellingPrice.Text + ", " + this.txtMotherboardrestockPrice.Text + ", " + this.txtMotherboardstockQuantity.Text + ", GETDATE());";

                        int insertCount = this.Da.ExecuteDMLQuery(sql);
                        if (insertCount == 1)
                        {
                            // Insert into Motherboard table
                            var sql2 = @"INSERT INTO Motherboard (MSerial, ProductID, Brand, CpuSocket, NumberOfCores, RamType, FormFactor) 
                                         VALUES ('" + this.txtMotherboardmSerial.Text + "','" + this.txtMotherboardproductID.Text + "', '" + this.cmbMotherboardBrand.Text + "', '" + this.cmbMotherboardCPUsocket.Text + "', '" + this.cmbMotherboardNumberOfCore.Text + "', '" + this.cmbMotherboardRamType.Text + "', '" + this.cmbMotherboardFromFactor.Text + "');";

                            int insertCount2 = this.Da.ExecuteDMLQuery(sql2);
                            if (insertCount2 == 1)
                            {
                                MessageBox.Show("Data Added Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add to Motherboard table");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to add to Product table");
                        }
                    }

                    this.PopulateGridMotherboard();
                    this.ClearAllTxtFromMotherboard();
                }
                else
                {
                    MessageBox.Show("Please fill all required fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void btnProcessorUpdateProduct_Click(object sender, EventArgs e)
        {
            //if i press this button the product information will be updated or added
            try
            {
                if (IsValidProcessor())
                {
                    // Check if the product already exists
                    var checkSql = "SELECT COUNT(*) FROM Product WHERE ProductID = '" + this.txtProcessorProductID.Text + "';";
                    var ds = this.Da.ExecuteQuery(checkSql);
                    int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    if (count == 1)
                    {
                        // Update Product table
                        var sql = @"UPDATE Product 
                                    SET ProductName = '" + this.txtProcessorProductName.Text + "', Category = '" + this.cmbProcessorCategory.Text +
                                    "', SellingPrice = " + this.txtProcessorSellingPrice.Text + ", RestockPrice = " + this.txtProcessorRestockPrice.Text +
                                    ", StockQuantity = " + this.txtProcessorStockQuantity.Text + " WHERE ProductID = '" + this.txtProcessorProductID.Text + "';";
                        int updateCount = this.Da.ExecuteDMLQuery(sql);
                        if (updateCount == 1)
                        {
                            // Update Processor table
                            var sql2 = @"UPDATE Processor 
                                         SET Brand = '" + this.cmbProcessorBrand.Text + "', Socket = '" + this.cmbProcessorSocket.Text +
                                         "', NumberOfCores = '" + this.cmbProcessorNumberOfCore.Text + "', ClockSpeed = '" + this.cmbProcessorClockSpeed.Text +
                                         "' WHERE PSerial = '" + this.txtProcessorpSerial.Text + "';";
                            int updateCount2 = this.Da.ExecuteDMLQuery(sql2);
                            if (updateCount2 == 1)
                            {
                                MessageBox.Show("Data Updated Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update Processor table");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Product table");
                        }
                    }
                    else
                    {
                        // Insert into Product table
                        var sql = @"INSERT INTO Product (ProductID, ProductName, Category, SellingPrice, RestockPrice, StockQuantity, DateAdded) 
                                    VALUES ('" + this.txtProcessorProductID.Text + "','" + this.txtProcessorProductName.Text + "', '" + this.cmbProcessorCategory.Text + "', " + this.txtProcessorSellingPrice.Text + ", " + this.txtProcessorRestockPrice.Text + ", " + this.txtProcessorStockQuantity.Text + ", GETDATE());";
                        int insertCount = this.Da.ExecuteDMLQuery(sql);
                        if (insertCount == 1)
                        {
                            // Insert into Processor table
                            var sql2 = @"INSERT INTO Processor (PSerial, ProductID, Brand, Socket, NumberOfCores, ClockSpeed) 
                                         VALUES ('" + this.txtProcessorpSerial.Text + "','" + this.txtProcessorProductID.Text + "', '" + this.cmbProcessorBrand.Text + "', '" + this.cmbProcessorSocket.Text + "', '" + this.cmbProcessorNumberOfCore.Text + "', '" + this.cmbProcessorClockSpeed.Text + "');";
                            int insertCount2 = this.Da.ExecuteDMLQuery(sql2);
                            if (insertCount2 == 1)
                            {
                                MessageBox.Show("Data Added Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add to Processor table");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to add to Product table");
                        }

                    }
                    this.PopulateGridProcessor();
                    this.ClearAllTxtFromProcessor();
                }
                else
                {
                    MessageBox.Show("Please fill all required fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnMonitorProductUpdate_Click(object sender, EventArgs e)
        {
            //if i press this button the product information will be updated or added
            try
            {
                if (IsValidMonitor())
                {
                    // Check if the product already exists
                    var checkSql = "SELECT COUNT(*) FROM Product WHERE ProductID = '" + this.txtMonitorProductID.Text + "';";
                    var ds = this.Da.ExecuteQuery(checkSql);
                    int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    if (count == 1)
                    {
                        // Update Product table
                        var sql = @"UPDATE Product 
                                    SET ProductName = '" + this.txtMonitorProductName.Text + "', Category = '" + this.cmbMonitorCategory.Text +
                                    "', SellingPrice = " + this.txtMonitorSellingPrice.Text + ", RestockPrice = " + this.txtMonitorRestockPrice.Text +
                                    ", StockQuantity = " + this.txtMonitorStockQuantity.Text + " WHERE ProductID = '" + this.txtMonitorProductID.Text + "';";
                        int updateCount = this.Da.ExecuteDMLQuery(sql);
                        if (updateCount == 1)
                        {
                            // Update Monitor table
                            var sql2 = @"UPDATE Monitor 
                                         SET Brand = '" + this.cmbMonitorBrand.Text + "', PanelType = '" + this.cmbMonitorPanelType.Text +
                                         "', Resolution = '" + this.cmbMonitorRsolution.Text + "', ScreenSize = '" + this.cmbMonitorscreenSize.Text +
                                         "', RefreshRate = '" + this.cmbMonitorRefreshRate.Text + "' WHERE MonitorSerial = '" + this.txtmonitorSerial.Text + "';";
                            int updateCount2 = this.Da.ExecuteDMLQuery(sql2);
                            if (updateCount2 == 1)
                                
                            {
                                MessageBox.Show("Data Updated Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update Monitor table");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Product table");
                        }
                    }
                    else
                    {
                        // Insert into Product table
                        var sql = @"INSERT INTO Product (ProductID, ProductName, Category, SellingPrice, RestockPrice, StockQuantity, DateAdded) 
                                    VALUES ('" + this.txtMonitorProductID.Text + "','" + this.txtMonitorProductName.Text + "', '" + this.cmbMonitorCategory.Text + "', " + this.txtMonitorSellingPrice.Text + ", " + this.txtMonitorRestockPrice.Text + ", " + this.txtMonitorStockQuantity.Text + ", GETDATE());";
                        int insertCount = this.Da.ExecuteDMLQuery(sql);
                        if (insertCount == 1)
                        {
                            // Insert into Monitor table
                            var sql2 = @"INSERT INTO Monitor (MonitorSerial, ProductID, Brand, PanelType, Resolution, ScreenSize, RefreshRate) 
                                         VALUES ('" + this.txtmonitorSerial.Text + "','" + this.txtMonitorProductID.Text + "', '" + this.cmbMonitorBrand.Text + "', '" + this.cmbMonitorPanelType.Text + "', '" + this.cmbMonitorRsolution.Text + "', '" + this.cmbMonitorscreenSize.Text + "', '" + this.cmbMonitorRefreshRate.Text + "');";
                            int insertCount2 = this.Da.ExecuteDMLQuery(sql2);
                            if (insertCount2 == 1)
                            {
                                MessageBox.Show("Data Added Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add to Monitor table");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to add to Product table");
                        }

                    }
                    this.PopulateGridMonitor();
                    this.ClearAllTxtFromMonitor();
                }
                else
                {
                    MessageBox.Show("Please fill all required fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnGpuUpdateProduct_Click(object sender, EventArgs e)
        {
            //if i press this button the product information will be updated or added
            try
            {
                if (IsValidGpu())
                {
                    // Check if the product already exists
                    var checkSql = "SELECT COUNT(*) FROM Product WHERE ProductID = '" + this.txtGpuProductID.Text + "';";
                    var ds = this.Da.ExecuteQuery(checkSql);
                    int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    if (count == 1)
                    {
                        // Update Product table
                        var sql = @"UPDATE Product 
                                    SET ProductName = '" + this.txtGpuProductName.Text + "', Category = '" + this.cmbGpuCategory.Text +
                                    "', SellingPrice = " + this.txtGpuSellingPrice.Text + ", RestockPrice = " + this.txtGpuRestockPrice.Text +
                                    ", StockQuantity = " + this.txtGpuStockQuantity.Text + " WHERE ProductID = '" + this.txtGpuProductID.Text + "';";
                        int updateCount = this.Da.ExecuteDMLQuery(sql);
                        if (updateCount == 1)
                        {
                            // Update GPU table
                            var sql2 = @"UPDATE GPU 
                                         SET Brand = '" + this.cmbGpuBrand.Text + "', Chipset = '" + this.cmbGpuChipset.Text +
                                         "', Memory = '" + this.cmbGpuMemory.Text + "', MemoryType = '" + this.cmbGpuMemoryType.Text +
                                         "', MaxResolution = '" + this.cmbGpuMaxResolution.Text + "' WHERE GSerial = '" + this.txtGPUGSerial.Text + "';";
                            int updateCount2 = this.Da.ExecuteDMLQuery(sql2);
                            if (updateCount2 == 1)
                            {
                                MessageBox.Show("Data Updated Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update GPU table");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Product table");
                        }
                    }
                    else
                    {
                        // Insert into Product table
                        var sql = @"INSERT INTO Product (ProductID, ProductName, Category, SellingPrice, RestockPrice, StockQuantity, DateAdded) 
                                    VALUES ('" + this.txtGpuProductID.Text + "','" + this.txtGpuProductName.Text + "', '" + this.cmbGpuCategory.Text + "', " + this.txtGpuSellingPrice.Text + ", " + this.txtGpuRestockPrice.Text + ", " + this.txtGpuStockQuantity.Text + ", GETDATE());";
                        int insertCount = this.Da.ExecuteDMLQuery(sql);
                        // Insert into GPU table
                        if (insertCount == 1)
                        {
                            var sql2 = @"INSERT INTO GPU (GSerial, ProductID, Brand, Chipset, Memory, MemoryType, MaxResolution) 
                                         VALUES ('" + this.txtGPUGSerial.Text + "','" + this.txtGpuProductID.Text + "', '" + this.cmbGpuBrand.Text + "', '" + this.cmbGpuChipset.Text + "', '" + this.cmbGpuMemory.Text + "', '" + this.cmbGpuMemoryType.Text + "', '" + this.cmbGpuMaxResolution.Text + "');";
                            int insertCount2 = this.Da.ExecuteDMLQuery(sql2);
                            if (insertCount2 == 1)
                            {
                                MessageBox.Show("Data Added Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add to GPU table");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to add to Product table");
                        }

                    }
                    this.PopulateGridMonitor();
                    this.ClearAllTxtFromMonitor();
                }
                else
                {
                    MessageBox.Show("Please fill all required fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnRamUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidRam())
                {
                    var checkSql = "SELECT COUNT(*) FROM Product WHERE ProductID = '" + this.btnRamProductID.Text + "';";
                    var ds = this.Da.ExecuteQuery(checkSql);
                    int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    if (count == 1)
                    {
                        var sql = @"UPDATE Product 
                                    SET ProductName = '" + this.txtRamProductName.Text + "', Category = '" + this.cmbRamCategory.Text +
                                    "', SellingPrice = " + this.txtRamSellingPrice.Text + ", RestockPrice = " + this.txtRamResotckPrice.Text +
                                    ", StockQuantity = " + this.txtRamStockQuantity.Text + " WHERE ProductID = '" + this.btnRamProductID.Text + "';";
                        int updateCount = this.Da.ExecuteDMLQuery(sql);
                        if (updateCount == 1)
                        {
                            var sql2 = @"UPDATE RAM 
                                         SET Brand = '" + this.cmbRamBrand.Text + "', MemoryType = '" + this.cmbRamMemoryType.Text +
                                         "', Capacity = '" + this.cmbRamCapacity.Text + "', BusSpeed = '" + this.cmbRamBusSpeed.Text +
                                         "', OtherFeatures = '" + this.cmbRamOtherFeature.Text + "' WHERE RSerial = '" + this.btnRamRserial.Text + "';";
                            int updateCount2 = this.Da.ExecuteDMLQuery(sql2);
                            if (updateCount2 == 1)
                            {
                                MessageBox.Show("Data Updated Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update RAM table");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Product table");
                        }
                    }
                    
                    else
                    {
                        // Insert into Product table
                        var sql = @"INSERT INTO Product (ProductID, ProductName, Category, SellingPrice, RestockPrice, StockQuantity, DateAdded) 
                                    VALUES ('" + this.btnRamProductID.Text + "','" + this.txtRamProductName.Text + "', '" + this.cmbRamCategory.Text + "', " + this.txtRamSellingPrice.Text + ", " + this.txtRamResotckPrice.Text + ", " + this.txtRamStockQuantity.Text + ", GETDATE());";
                        int insertCount = this.Da.ExecuteDMLQuery(sql);
                        // Insert into RAM table
                        if (insertCount == 1)
                        {
                            var sql2 = @"INSERT INTO RAM (RSerial, ProductID, Brand, MemoryType, Capacity, BusSpeed, OtherFeatures) 
                                         VALUES ('" + this.btnRamRserial.Text + "','" + this.btnRamProductID.Text + "', '" + this.cmbRamBrand.Text + "', '" + this.cmbRamMemoryType.Text + "', '" + this.cmbRamCapacity.Text + "', '" + this.cmbRamBusSpeed.Text + "', '" + this.cmbRamOtherFeature.Text + "');";
                            int insertCount2 = this.Da.ExecuteDMLQuery(sql2);
                            if (insertCount2 == 1)
                            {
                                MessageBox.Show("Data Added Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add to RAM table");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to add to Product table");
                        }
                    }
                    this.PopulateGridRam();
                    this.ClearAllTxtFromRam();
                }
                else
                {
                    MessageBox.Show("Please fill all required fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnPowerSupplyUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidPowerSupply())
                {
                    var checkSql = "SELECT COUNT(*) FROM Product WHERE ProductID = '" + this.txtPowerSupplyProductID.Text + "';";
                    var ds = this.Da.ExecuteQuery(checkSql);
                    int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    if (count == 1)
                    {
                        var sql = @"UPDATE Product 
                                    SET ProductName = '" + this.txtPowerSupplyProductName.Text + "', Category = '" + this.cmbPowerSupplyCategory.Text +
                                    "', SellingPrice = " + this.txtPowerSupplySellingPrice.Text + ", RestockPrice = " + this.txtPowerSupplyRestockPrice.Text +
                                    ", StockQuantity = " + this.txtPowerSupplyStockQuantity.Text + " WHERE ProductID = '" + this.txtPowerSupplyProductID.Text + "';";
                        int updateCount = this.Da.ExecuteDMLQuery(sql);
                        if (updateCount == 1)
                        {
                            var sql2 = @"UPDATE PowerSupply 
                                         SET Brand = '" + this.cmbPowerSupplyBrand.Text + "', Modular = '" + this.cmbPowerSupplyModular.Text +
                                         "', Wattage = '" + this.cmbPowerSupplyWattage.Text + "', Efficiency = '" + this.cmbPowerSupplyEfficiency.Text +
                                         "' WHERE PSSerial = '" + this.txtPowerSupplySerial.Text + "';";
                            int updateCount2 = this.Da.ExecuteDMLQuery(sql2);
                            if (updateCount2 == 1)
                            {
                                MessageBox.Show("Data Updated Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update PowerSupply table");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Product table");
                        }
                    }
                    else
                    {
                        // Insert into Product table
                        var sql = @"INSERT INTO Product (ProductID, ProductName, Category, SellingPrice, RestockPrice, StockQuantity, DateAdded) 
                                    VALUES ('" + this.txtPowerSupplyProductID.Text + "','" + this.txtPowerSupplyProductName.Text + "', '" + this.cmbPowerSupplyCategory.Text + "', " + this.txtPowerSupplySellingPrice.Text + ", " + this.txtPowerSupplyRestockPrice.Text + ", " + this.txtPowerSupplyStockQuantity.Text + ", GETDATE());";
                        int insertCount = this.Da.ExecuteDMLQuery(sql);
                        if (insertCount == 1)
                        {
                            // Insert into PowerSupply table
                            var sql2 = @"INSERT INTO PowerSupply (PSSerial, ProductID, Brand, Modular, Wattage, Efficiency) 
                                         VALUES ('" + this.txtPowerSupplySerial.Text + "','" + this.txtPowerSupplyProductID.Text + "', '" + this.cmbPowerSupplyBrand.Text + "', '" + this.cmbPowerSupplyModular.Text + "', '" + this.cmbPowerSupplyWattage.Text + "', '" + this.cmbPowerSupplyEfficiency.Text + "');";
                            int insertCount2 = this.Da.ExecuteDMLQuery(sql2);
                            if (insertCount2 == 1)
                            {
                                MessageBox.Show("Data Added Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add to PowerSupply table");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to add to Product table");
                        }
                    }
                    this.PopulateGridPowerSupply();
                    this.ClearAllTxtFromPowerSupply();
                }
                else
                {
                    MessageBox.Show("Please fill all required fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnCasingUptade_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidCasing())
                {
                    var checkSql = "SELECT COUNT(*) FROM Product WHERE ProductID = '" + this.txtCasingProductID.Text + "';";
                    var ds = this.Da.ExecuteQuery(checkSql);
                    int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    if (count == 1)
                    {
                        // Update Product table
                        var sql = @"UPDATE Product 
                                    SET ProductName = '" + this.txtCasingProductName.Text + "', Category = '" + this.cmbCasingCategory.Text +
                                    "', SellingPrice = " + this.txtCasingSellingPrice.Text + ", RestockPrice = " + this.txtCasingRestockPrice.Text +
                                    ", StockQuantity = " + this.txtCasingStockQuantity.Text + " WHERE ProductID = '" + this.txtCasingProductID.Text + "';";
                        int updateCount = this.Da.ExecuteDMLQuery(sql);
                        if (updateCount == 1)
                        {
                            // Update Casing table
                            var sql2 = @"UPDATE Casing 
                                         SET Brand = '" + this.cmbCasingBrand.Text + "', Color = '" + this.cmbCasingColor.Text +
                                         "', Type = '" + this.cmbCasingType.Text + "', MotherboardType = '" + this.cmbCasingMotherboardType.Text +
                                         "', SidePanel = '" + this.cmbCasingSidePanel.Text + "' WHERE CASerial = '" + this.txtCasingSerial.Text + "';";
                            int updateCount2 = this.Da.ExecuteDMLQuery(sql2);
                            if (updateCount2 == 1)
                            {
                                MessageBox.Show("Data Updated Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update Casing table");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Product table");
                        }
                    }
                    else
                    {
                        // Insert into Product table
                        var sql = @"INSERT INTO Product (ProductID, ProductName, Category, SellingPrice, RestockPrice, StockQuantity, DateAdded) 
                                    VALUES ('" + this.txtCasingProductID.Text + "','" + this.txtCasingProductName.Text + "', '" + this.cmbCasingCategory.Text + "', " + this.txtCasingSellingPrice.Text + ", " + this.txtCasingRestockPrice.Text + ", " + this.txtCasingStockQuantity.Text + ", GETDATE());";
                        int insertCount = this.Da.ExecuteDMLQuery(sql);
                        if (insertCount == 1)
                        {
                            // Insert into Casing table
                            var sql2 = @"INSERT INTO Casing (CASerial, ProductID, Brand, Color, Type, MotherboardType, SidePanel) 
                                         VALUES ('" + this.txtCasingSerial.Text + "','" + this.txtCasingProductID.Text + "', '" + this.cmbCasingBrand.Text + "', '" + this.cmbCasingColor.Text + "', '" + this.cmbCasingType.Text + "', '" + this.cmbCasingMotherboardType.Text + "', '" + this.cmbCasingSidePanel.Text + "');";
                            int insertCount2 = this.Da.ExecuteDMLQuery(sql2);
                            if (insertCount2 == 1)
                            {
                                MessageBox.Show("Data Added Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add to Casing table");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to add to Product table");
                        }
                    }
                    this.PopulateGridCasing();
                    this.ClearAllTxtFromCasing();
                }
                else
                {
                    MessageBox.Show("Please fill all required fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnSsdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidSsd())
                {
                    var checkSql = "SELECT COUNT(*) FROM Product WHERE ProductID = '" + this.txtSsdProductID.Text + "';";
                    var ds = this.Da.ExecuteQuery(checkSql);
                    int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    if (count == 1)
                    {
                        var sql = @"UPDATE Product 
                                    SET ProductName = '" + this.txtSsdProductName.Text + "', Category = '" + this.cmbSsdCategory.Text +
                                    "', SellingPrice = " + this.txtSsdSellingPrice.Text + ", RestockPrice = " + this.txtSsdRestockPrice.Text +
                                    ", StockQuantity = " + this.txtSsdStockQuantity.Text + " WHERE ProductID = '" + this.txtSsdProductID.Text + "';";
                        int updateCount = this.Da.ExecuteDMLQuery(sql);
                        if (updateCount == 1)
                        {
                            var sql2 = @"UPDATE SSD 
                                         SET Brand = '" + this.cmbSsdBrand.Text + "', InterfaceType = '" + this.cmbSsdInterfaceType.Text +
                                         "', Capacity = '" + this.cmbSsdCapacity.Text + "', ReadSpeed = '" + this.cmbSsdReadSpeed.Text +
                                         "' WHERE SSDSerial = '" + this.txtSsdSerial.Text + "';";
                            int updateCount2 = this.Da.ExecuteDMLQuery(sql2);
                            if (updateCount2 == 1)
                            {
                                MessageBox.Show("Data Updated Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update SSD table");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Product table");
                        }
                    }
                    else
                    {
                        // Insert into Product table
                        var sql = @"INSERT INTO Product (ProductID, ProductName, Category, SellingPrice, RestockPrice, StockQuantity, DateAdded) 
                                    VALUES ('" + this.txtSsdProductID.Text + "','" + this.txtSsdProductName.Text + "', '" + this.cmbSsdCategory.Text + "', " + this.txtSsdSellingPrice.Text + ", " + this.txtSsdRestockPrice.Text + ", " + this.txtSsdStockQuantity.Text + ", GETDATE());";
                        int insertCount = this.Da.ExecuteDMLQuery(sql);
                        if (insertCount == 1)
                        /// Insert into SSD table
                        {
                            var sql2 = @"INSERT INTO SSD (SSDSerial, ProductID, Brand, InterfaceType, Capacity, ReadSpeed) 
                                         VALUES ('" + this.txtSsdSerial.Text + "','" + this.txtSsdProductID.Text + "', '" + this.cmbSsdBrand.Text + "', '" + this.cmbSsdInterfaceType.Text + "', '" + this.cmbSsdCapacity.Text + "', '" + this.cmbSsdReadSpeed.Text + "');";
                            int insertCount2 = this.Da.ExecuteDMLQuery(sql2);
                            if (insertCount2 == 1)
                            {
                                MessageBox.Show("Data Added Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add to SSD table");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to add to Product table");
                        }
                    }
                    this.PopulateGridSsd();
                    this.ClearAllTxtFromSsd();
                }
                else
                {
                    MessageBox.Show("Please fill all required fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void gridMotherboard_DoubleClick(object sender, EventArgs e)
        {
            //if we double click on any row of the grid then the data of that row will be shown in the textboxes and comboboxes
            this.txtMotherboardproductName.Text = this.gridMotherboard.CurrentRow.Cells["ProductName"].Value.ToString();
            this.cmbMotherboardCategory.Text = this.gridMotherboard.CurrentRow.Cells["Category"].Value.ToString();
            this.txtMotherboardsellingPrice.Text = this.gridMotherboard.CurrentRow.Cells["SellingPrice"].Value.ToString();
            this.txtMotherboardrestockPrice.Text = this.gridMotherboard.CurrentRow.Cells["RestockPrice"].Value.ToString();
            this.txtMotherboardstockQuantity.Text = this.gridMotherboard.CurrentRow.Cells["StockQuantity"].Value.ToString();
            this.cmbMotherboardBrand.Text = this.gridMotherboard.CurrentRow.Cells["Brand"].Value.ToString();
            this.cmbMotherboardCPUsocket.SelectedItem = this.gridMotherboard.CurrentRow.Cells["CpuSocket"].Value.ToString();
            this.cmbMotherboardNumberOfCore.Text = this.gridMotherboard.CurrentRow.Cells["NumberOfCores"].Value.ToString();
            this.cmbMotherboardRamType.Text = this.gridMotherboard.CurrentRow.Cells["RamType"].Value.ToString();
            this.cmbMotherboardFromFactor.Text = this.gridMotherboard.CurrentRow.Cells["FormFactor"].Value.ToString();
            this.txtMotherboardproductID.Text = this.gridMotherboard.CurrentRow.Cells["ProductID"].Value.ToString();    
            this.txtMotherboardmSerial.Text = this.gridMotherboard.CurrentRow.Cells["MSerial"].Value.ToString();

        }
        private void GridProcessorTable_DoubleClick(object sender, EventArgs e)
        {
            //if we double click on any row of the grid then the data of that row will be shown in the textboxes and comboboxes
            this.txtProcessorProductName.Text = this.GridProcessorTable.CurrentRow.Cells["ProductName"].Value.ToString();
            this.cmbProcessorCategory.Text = this.GridProcessorTable.CurrentRow.Cells["Category"].Value.ToString();
            this.txtProcessorSellingPrice.Text = this.GridProcessorTable.CurrentRow.Cells["SellingPrice"].Value.ToString();
            this.txtProcessorRestockPrice.Text = this.GridProcessorTable.CurrentRow.Cells["RestockPrice"].Value.ToString();
            this.txtProcessorStockQuantity.Text = this.GridProcessorTable.CurrentRow.Cells["StockQuantity"].Value.ToString();
            this.cmbProcessorBrand.Text = this.GridProcessorTable.CurrentRow.Cells["Brand"].Value.ToString();
            this.cmbProcessorSocket.Text = this.GridProcessorTable.CurrentRow.Cells["Socket"].Value.ToString();
            this.cmbProcessorNumberOfCore.Text = this.GridProcessorTable.CurrentRow.Cells["NumberOfCores"].Value.ToString();
            this.cmbProcessorClockSpeed.Text = this.GridProcessorTable.CurrentRow.Cells["ClockSpeed"].Value.ToString();
            this.txtProcessorProductID.Text = this.GridProcessorTable.CurrentRow.Cells["ProductID"].Value.ToString();
            this.txtProcessorpSerial.Text = this.GridProcessorTable.CurrentRow.Cells["PSerial"].Value.ToString();


        }

        private void GridMonitorTable_DoubleClick(object sender, EventArgs e)
        {
            this.txtMonitorProductName.Text = this.GridMonitorTable.CurrentRow.Cells["ProductName"].Value.ToString();
            this.cmbMonitorCategory.Text = this.GridMonitorTable.CurrentRow.Cells["Category"].Value.ToString();
            this.txtMonitorSellingPrice.Text = this.GridMonitorTable.CurrentRow.Cells["SellingPrice"].Value.ToString();
            this.txtMonitorRestockPrice.Text = this.GridMonitorTable.CurrentRow.Cells["RestockPrice"].Value.ToString();
            this.txtMonitorStockQuantity.Text = this.GridMonitorTable.CurrentRow.Cells["StockQuantity"].Value.ToString();
            this.cmbMonitorBrand.SelectedItem = this.GridMonitorTable.CurrentRow.Cells["Brand"].Value.ToString();
            this.cmbMonitorPanelType.SelectedItem = this.GridMonitorTable.CurrentRow.Cells["PanelType"].Value.ToString();
            this.cmbMonitorRsolution.SelectedItem = this.GridMonitorTable.CurrentRow.Cells["Resolution"].Value.ToString();
            this.cmbMonitorscreenSize.SelectedItem = this.GridMonitorTable.CurrentRow.Cells["ScreenSize"].Value.ToString();
            this.cmbMonitorRefreshRate.SelectedItem = this.GridMonitorTable.CurrentRow.Cells["RefreshRate"].Value.ToString();
            this.txtmonitorSerial.Text = this.GridMonitorTable.CurrentRow.Cells["MonitorSerial"].Value.ToString();
            this.txtMonitorProductID.Text = this.GridMonitorTable.CurrentRow.Cells["ProductID"].Value.ToString();

        }

        private void GridGpuTable_DoubleClick(object sender, EventArgs e)
        {
            //if we double click on any row of the grid then the data of that row will be shown in the textboxes and comboboxes
            this.txtGpuProductName.Text = this.GridGpuTable.CurrentRow.Cells["ProductName"].Value.ToString();
            this.cmbGpuCategory.Text = this.GridGpuTable.CurrentRow.Cells["Category"].Value.ToString();
            this.txtGpuSellingPrice.Text = this.GridGpuTable.CurrentRow.Cells["SellingPrice"].Value.ToString();
            this.txtGpuRestockPrice.Text = this.GridGpuTable.CurrentRow.Cells["RestockPrice"].Value.ToString();
            this.txtGpuStockQuantity.Text = this.GridGpuTable.CurrentRow.Cells["StockQuantity"].Value.ToString();
            this.cmbGpuBrand.SelectedItem = this.GridGpuTable.CurrentRow.Cells["Brand"].Value.ToString();
            this.cmbGpuChipset.SelectedItem = this.GridGpuTable.CurrentRow.Cells["Chipset"].Value.ToString();
            this.cmbGpuMemoryType.SelectedItem = this.GridGpuTable.CurrentRow.Cells["MemoryType"].Value.ToString();
            this.cmbGpuMaxResolution.SelectedItem = this.GridGpuTable.CurrentRow.Cells["MaxResolution"].Value.ToString();
            this.cmbGpuMemory.SelectedItem = this.GridGpuTable.CurrentRow.Cells["Memory"].Value.ToString();
            this.txtGPUGSerial.Text = this.GridGpuTable.CurrentRow.Cells["GSerial"].Value.ToString();
            this.txtGpuProductID.Text = this.GridGpuTable.CurrentRow.Cells["ProductID"].Value.ToString();

        }

        private void GridRamTable_DoubleClick(object sender, EventArgs e)
        {
            //if we double click on any row of the grid then the data of that row will be shown in the textboxes and comboboxes
            this.txtRamProductName.Text = this.GridRamTable.CurrentRow.Cells["ProductName"].Value.ToString();
            this.cmbRamCategory.Text = this.GridRamTable.CurrentRow.Cells["Category"].Value.ToString();
            this.txtRamSellingPrice.Text = this.GridRamTable.CurrentRow.Cells["SellingPrice"].Value.ToString();
            this.txtRamResotckPrice.Text = this.GridRamTable.CurrentRow.Cells["RestockPrice"].Value.ToString();
            this.txtRamStockQuantity.Text = this.GridRamTable.CurrentRow.Cells["StockQuantity"].Value.ToString();
            this.cmbRamBrand.SelectedItem = this.GridRamTable.CurrentRow.Cells["Brand"].Value.ToString();
            this.cmbRamMemoryType.SelectedItem = this.GridRamTable.CurrentRow.Cells["MemoryType"].Value.ToString();
            this.cmbRamBusSpeed.SelectedItem = this.GridRamTable.CurrentRow.Cells["BusSpeed"].Value.ToString();
            this.cmbRamCapacity.SelectedItem = this.GridRamTable.CurrentRow.Cells["Capacity"].Value.ToString();
            this.cmbRamOtherFeature.SelectedItem = this.GridRamTable.CurrentRow.Cells["OtherFeatures"].Value.ToString();
            this.btnRamRserial.Text = this.GridRamTable.CurrentRow.Cells["RSerial"].Value.ToString();
            this.btnRamProductID.Text = this.GridRamTable.CurrentRow.Cells["ProductID"].Value.ToString();
        }

        private void gridCasingTable_DoubleClick(object sender, EventArgs e)
        {
            //if we double click on any row of the grid then the data of that row will be shown in the textboxes and comboboxes
            this.txtCasingProductName.Text = this.gridCasingTable.CurrentRow.Cells["ProductName"].Value.ToString();
            this.txtCasingSellingPrice.Text = this.gridCasingTable.CurrentRow.Cells["SellingPrice"].Value.ToString();
            this.txtCasingRestockPrice.Text = this.gridCasingTable.CurrentRow.Cells["RestockPrice"].Value.ToString();
            this.txtCasingStockQuantity.Text = this.gridCasingTable.CurrentRow.Cells["StockQuantity"].Value.ToString();
            this.cmbCasingBrand.Text = this.gridCasingTable.CurrentRow.Cells["Brand"].Value.ToString();
            this.cmbCasingColor.Text = this.gridCasingTable.CurrentRow.Cells["Color"].Value.ToString();
            this.cmbCasingType.Text = this.gridCasingTable.CurrentRow.Cells["Type"].Value.ToString();
            this.cmbCasingMotherboardType.Text = this.gridCasingTable.CurrentRow.Cells["MotherboardType"].Value.ToString();
            this.cmbCasingSidePanel.Text = this.gridCasingTable.CurrentRow.Cells["SidePanel"].Value.ToString();
            this.cmbCasingCategory.SelectedItem = this.gridCasingTable.CurrentRow.Cells["Category"].Value.ToString();
            this.txtCasingProductID.Text = this.gridCasingTable.CurrentRow.Cells["ProductID"].Value.ToString();
            this.txtCasingSerial.Text = this.gridCasingTable.CurrentRow.Cells["CASerial"].Value.ToString(); 

        }

        private void GridPowerSupplyTable_DoubleClick(object sender, EventArgs e)
        {
            //if we double click on any row of the grid then the data of that row will be shown in the textboxes and comboboxes
            this.txtPowerSupplyProductName.Text = this.GridPowerSupplyTable.CurrentRow.Cells["ProductName"].Value.ToString();
            this.cmbPowerSupplyCategory.Text = this.GridPowerSupplyTable.CurrentRow.Cells["Category"].Value.ToString();
            this.txtPowerSupplySellingPrice.Text = this.GridPowerSupplyTable.CurrentRow.Cells["SellingPrice"].Value.ToString();
            this.txtPowerSupplyRestockPrice.Text = this.GridPowerSupplyTable.CurrentRow.Cells["RestockPrice"].Value.ToString();
            this.txtPowerSupplyStockQuantity.Text = this.GridPowerSupplyTable.CurrentRow.Cells["StockQuantity"].Value.ToString();
            this.cmbPowerSupplyBrand.Text = this.GridPowerSupplyTable.CurrentRow.Cells["Brand"].Value.ToString();
            this.cmbPowerSupplyModular.Text = this.GridPowerSupplyTable.CurrentRow.Cells["Modular"].Value.ToString();
            this.cmbPowerSupplyWattage.Text = this.GridPowerSupplyTable.CurrentRow.Cells["Wattage"].Value.ToString();
            this.cmbPowerSupplyEfficiency.Text = this.GridPowerSupplyTable.CurrentRow.Cells["Efficiency"].Value.ToString();
            this.txtPowerSupplyProductID.Text = this.GridPowerSupplyTable.CurrentRow.Cells["ProductID"].Value.ToString();
            this.txtPowerSupplySerial.Text = this.GridPowerSupplyTable.CurrentRow.Cells["PSSerial"].Value.ToString();   

        }

        private void GridSsdTable_DoubleClick(object sender, EventArgs e)
        {
            //if we double click on any row of the grid then the data of that row will be shown in the textboxes and comboboxes
            this.txtSsdProductName.Text = this.GridSsdTable.CurrentRow.Cells["ProductName"].Value.ToString();
            this.cmbSsdCategory.SelectedItem = this.GridSsdTable.CurrentRow.Cells["Category"].Value.ToString();
            this.txtSsdSellingPrice.Text = this.GridSsdTable.CurrentRow.Cells["SellingPrice"].Value.ToString();
            this.txtSsdRestockPrice.Text = this.GridSsdTable.CurrentRow.Cells["RestockPrice"].Value.ToString();
            this.txtSsdStockQuantity.Text = this.GridSsdTable.CurrentRow.Cells["StockQuantity"].Value.ToString();
            this.cmbSsdBrand.SelectedItem = this.GridSsdTable.CurrentRow.Cells["Brand"].Value.ToString();
            this.cmbSsdInterfaceType.Text = this.GridSsdTable.CurrentRow.Cells["InterfaceType"].Value.ToString();
            this.cmbSsdCapacity.SelectedItem = this.GridSsdTable.CurrentRow.Cells["Capacity"].Value.ToString();
            this.cmbSsdReadSpeed.Text = this.GridSsdTable.CurrentRow.Cells["ReadSpeed"].Value.ToString();
            this.txtSsdProductID.Text = this.GridSsdTable.CurrentRow.Cells["ProductID"].Value.ToString();   
            this.txtSsdSerial.Text = this.GridSsdTable.CurrentRow.Cells["SSDSerial"].Value.ToString();  
        }

        private void btnMotherboardDeleteProduct_Click(object sender, EventArgs e)
        {
            //if we click on delete button then the selected row will be deleted from the database and my grid will be updated
            try
            {
                if (this.gridMotherboard.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var id = this.gridMotherboard.CurrentRow.Cells["ProductID"].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + id + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                var sql = "delete from Product where ProductID = '" + id + "'; delete from Motherboard where ProductID = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count > 0)
                {
                    MessageBox.Show(id.ToUpper() + " has been removed from the list.");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed");
                }

                this.PopulateGridMotherboard();
                this.ClearAllTxtFromMotherboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnProcessorDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.GridProcessorTable.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var id = this.GridProcessorTable.CurrentRow.Cells["ProductID"].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + id + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                var sql = "delete from Product where ProductID = '" + id + "'; delete from Processor where ProductID = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count > 0)
                {
                    MessageBox.Show(id.ToUpper() + " has been removed from the list.");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnMonitorDeleteProduct_Click(object sender, EventArgs e)
        {
            //if we click on delete button then the selected row will be deleted from the database and my grid will be updated
            try
            {
                if (this.GridMonitorTable.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var id = this.GridMonitorTable.CurrentRow.Cells["ProductID"].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + id + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                var sql = "delete from Product where ProductID = '" + id + "'; delete from Monitor where ProductID = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count > 0)
                {
                    MessageBox.Show(id.ToUpper() + " has been removed from the list.");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed");
                }
                this.PopulateGridMonitor();
                this.ClearAllTxtFromMonitor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGpuDeleteProduct_Click(object sender, EventArgs e)
        {
            //if we click on delete button then the selected row will be deleted from the database and my grid will be updated
            try
            {
                if (this.GridGpuTable.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var id = this.GridGpuTable.CurrentRow.Cells["ProductID"].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + id + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                var sql = "delete from Product where ProductID = '" + id + "'; delete from GPU where ProductID = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count > 0)
                {
                    MessageBox.Show(id.ToUpper() + " has been removed from the list.");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed");
                }
                this.PopulateGridGpu();
                this.ClearAllTxtFromGpu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRamDeleteProduct_Click(object sender, EventArgs e)
        {
            //if we click on delete button then the selected row will be deleted from the database and my grid will be updated
            try
            {
                if (this.GridRamTable.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var id = this.GridRamTable.CurrentRow.Cells["ProductID"].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + id + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                var sql = "delete from Product where ProductID = '" + id + "'; delete from RAM where ProductID = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count > 0)
                {
                    MessageBox.Show(id.ToUpper() + " has been removed from the list.");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed");
                }
                this.PopulateGridRam();
                this.ClearAllTxtFromRam();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnPowerSupplyDeleteProduct_Click(object sender, EventArgs e)
        {
            //if we click on delete button then the selected row will be deleted from the database and my grid will be updated
            try
            {
                if (this.GridPowerSupplyTable.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var id = this.GridPowerSupplyTable.CurrentRow.Cells["ProductID"].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + id + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                var sql = "delete from Product where ProductID = '" + id + "'; delete from PowerSupply where ProductID = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count > 0)
                {
                    MessageBox.Show(id.ToUpper() + " has been removed from the list.");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed");
                }
                this.PopulateGridPowerSupply();
                this.ClearAllTxtFromPowerSupply();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCasingDelete_Click(object sender, EventArgs e)
        {
            //if we click on delete button then the selected row will be deleted from the database and my grid will be updated
            try
            {
                if (this.gridCasingTable.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var id = this.gridCasingTable.CurrentRow.Cells["ProductID"].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + id + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                var sql = "delete from Product where ProductID = '" + id + "'; delete from Casing where ProductID = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count > 0)
                {
                    MessageBox.Show(id.ToUpper() + " has been removed from the list.");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed");
                }
                this.PopulateGridCasing();
                this.ClearAllTxtFromCasing();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSsdDelete_Click(object sender, EventArgs e)
        {
            //if we click on delete button then the selected row will be deleted from the database and my grid will be updated
            try
            {
                if (this.GridSsdTable.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var id = this.GridSsdTable.CurrentRow.Cells["ProductID"].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + id + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                var sql = "delete from Product where ProductID = '" + id + "'; delete from SSD where ProductID = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);
                if (count > 0)
                {
                    MessageBox.Show(id.ToUpper() + " has been removed from the list.");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed");
                }
                this.PopulateGridSsd();
                this.ClearAllTxtFromSsd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AutoProductIdGenerate()
        {
            try
            {
                var sql = "SELECT * FROM Product ORDER BY ProductID DESC;";
                var ds = this.Da.ExecuteQuery(sql);
                var dt = ds.Tables[0];
                int rowCount = dt.Rows.Count;
                if (rowCount > 0)
                {
                    // Extract numeric part from ProductID (e.g., PRD021 -> 21)
                    string lastProductId = dt.Rows[0]["ProductID"].ToString();
                    int id = int.Parse(lastProductId.Substring(3)); // Skip 'PRD' and parse the number
                    string newProductId = "PRD" + (id + 1).ToString("D3"); // Format to keep leading zeros

                    this.txtMotherboardproductID.Text = newProductId;
                    this.txtProcessorProductID.Text = newProductId;
                    this.txtMonitorProductID.Text = newProductId;
                    this.txtGpuProductID.Text = newProductId;
                    this.btnRamProductID.Text = newProductId;
                    this.txtPowerSupplyProductID.Text = newProductId;
                    this.txtCasingProductID.Text = newProductId;
                    this.txtSsdProductID.Text = newProductId;
                }
                else
                {
                    this.txtMotherboardproductID.Text = "PRD001";
                    this.txtProcessorProductID.Text = "PRD001";
                    this.txtMonitorProductID.Text = "PRD001";
                    this.txtGpuProductID.Text = "PRD001";
                    this.btnRamProductID.Text = "PRD001";
                    this.txtPowerSupplyProductID.Text = "PRD001";
                    this.txtCasingProductID.Text = "PRD001";
                    this.txtSsdProductID.Text = "PRD001";
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: Invalid data format. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       
        private void AutoMotherboardSerialGenerate()
        {
            try
            {
                var sql = "SELECT * FROM Motherboard ORDER BY MSerial DESC;";
                var ds = this.Da.ExecuteQuery(sql);
                var dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    string lastSerial = dt.Rows[0]["MSerial"].ToString();
                    int serialNumber = int.Parse(lastSerial.Substring(2)); // Skip 'MB' and parse the number
                    string newSerial = "MB" + (serialNumber + 1).ToString("D3"); // Format to keep leading zeros
                    this.txtMotherboardmSerial.Text = newSerial;
                }
                else
                {
                    this.txtMotherboardmSerial.Text = "MB001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AutoProcessorSerialGenerate()
        {
            try
            {
                var sql = "SELECT * FROM Processor ORDER BY PSerial DESC;";
                var ds = this.Da.ExecuteQuery(sql);
                var dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    string lastSerial = dt.Rows[0]["PSerial"].ToString();
                    int serialNumber = int.Parse(lastSerial.Substring(2)); // Skip 'PR' and parse the number
                    string newSerial = "PR" + (serialNumber + 1).ToString("D3"); // Format to keep leading zeros
                    this.txtProcessorpSerial.Text = newSerial;
                }
                else
                {
                    this.txtProcessorpSerial.Text = "PR001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AutoMonitorSerialGenerate()
        {
            try
            {
                var sql = "SELECT * FROM Monitor ORDER BY MonitorSerial DESC;";
                var ds = this.Da.ExecuteQuery(sql);
                var dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    string lastSerial = dt.Rows[0]["MonitorSerial"].ToString();
                    int serialNumber = int.Parse(lastSerial.Substring(3)); // Skip 'MON' and parse the number
                    string newSerial = "MON" + (serialNumber + 1).ToString("D3"); // Format to keep leading zeros
                    this.txtmonitorSerial.Text = newSerial;
                }
                else
                {
                    this.txtmonitorSerial.Text = "MON001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AutoGpuSerialGenerate()
        {
            try
            {
                var sql = "SELECT * FROM GPU ORDER BY GSerial DESC;";
                var ds = this.Da.ExecuteQuery(sql);
                var dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    string lastSerial = dt.Rows[0]["GSerial"].ToString();
                    int serialNumber = int.Parse(lastSerial.Substring(3)); // Skip 'GP' and parse the number
                    string newSerial = "GPU" + (serialNumber + 1).ToString("D3"); // Format to keep leading zeros
                    this.txtGPUGSerial.Text = newSerial;
                }
                else
                {
                    this.txtGPUGSerial.Text = "GPU001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AutoRamSerialGenerate()
        {
            try
            {
                var sql = "SELECT * FROM RAM ORDER BY RSerial DESC;";
                var ds = this.Da.ExecuteQuery(sql);
                var dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    string lastSerial = dt.Rows[0]["RSerial"].ToString();
                    int serialNumber = int.Parse(lastSerial.Substring(3)); // Skip 'RM' and parse the number
                    string newSerial = "RAM" + (serialNumber + 1).ToString("D3"); // Format to keep leading zeros
                    this.btnRamRserial.Text = newSerial;
                }
                else
                {
                    this.btnRamRserial.Text = "RAM001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AutoPowerSupplySerialGenerate()
        {
            try
            {
                var sql = "SELECT * FROM PowerSupply ORDER BY PSSerial DESC;";
                var ds = this.Da.ExecuteQuery(sql);
                var dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    string lastSerial = dt.Rows[0]["PSSerial"].ToString();
                    int serialNumber = int.Parse(lastSerial.Substring(2)); // Skip 'PS' and parse the number
                    string newSerial = "PS" + (serialNumber + 1).ToString("D3"); // Format to keep leading zeros
                    this.txtPowerSupplySerial.Text = newSerial;
                }
                else
                {
                    this.txtPowerSupplySerial.Text = "PS001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AutoCasingSerialGenerate()
        {
            try
            {
                var sql = "SELECT * FROM Casing ORDER BY CASerial DESC;";
                var ds = this.Da.ExecuteQuery(sql);
                var dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    string lastSerial = dt.Rows[0]["CASerial"].ToString();
                    int serialNumber = int.Parse(lastSerial.Substring(3)); // Skip 'CS' and parse the number
                    string newSerial = "CAS" + (serialNumber + 1).ToString("D3"); // Format to keep leading zeros
                    this.txtCasingSerial.Text = newSerial;
                }
                else
                {
                    this.txtCasingSerial.Text = "CAS001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AutoSsdSerialGenerate()
        {
            try
            {
                var sql = "SELECT * FROM SSD ORDER BY SSDSerial DESC;";
                var ds = this.Da.ExecuteQuery(sql);
                var dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    string lastSerial = dt.Rows[0]["SSDSerial"].ToString();
                    int serialNumber = int.Parse(lastSerial.Substring(3)); // Skip 'SS' and parse the number
                    string newSerial = "SSD" + (serialNumber + 1).ToString("D3"); // Format to keep leading zeros
                    this.txtSsdSerial.Text = newSerial;
                }
                else
                {
                    this.txtSsdSerial.Text = "SSD001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       
    }
}
