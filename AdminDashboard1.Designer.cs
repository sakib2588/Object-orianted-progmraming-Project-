namespace WindowsFormsApp1
{
    partial class AdminDashboard1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.PnDashboard = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pnProduct = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.PnStaff = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pnreport1 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.PnLogOut = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.lbInfo1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuTransition = new System.Windows.Forms.Timer(this.components);
            this.SidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.lostPanel5 = new ReaLTaiizor.Controls.LostPanel();
            this.lnStaffNumber = new System.Windows.Forms.Label();
            this.foxLabel7 = new ReaLTaiizor.Controls.FoxLabel();
            this.lostPanel3 = new ReaLTaiizor.Controls.LostPanel();
            this.cmbTime = new ReaLTaiizor.Controls.CrownComboBox();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.foxLabel5 = new ReaLTaiizor.Controls.FoxLabel();
            this.lostPanel7 = new ReaLTaiizor.Controls.LostPanel();
            this.gridSoldProduct1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.btnRefresh = new ReaLTaiizor.Controls.Button();
            this.Sidebar.SuspendLayout();
            this.PnDashboard.SuspendLayout();
            this.pnProduct.SuspendLayout();
            this.PnStaff.SuspendLayout();
            this.pnreport1.SuspendLayout();
            this.PnLogOut.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.lostPanel5.SuspendLayout();
            this.lostPanel3.SuspendLayout();
            this.lostPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSoldProduct1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Sidebar.Controls.Add(this.PnDashboard);
            this.Sidebar.Controls.Add(this.pnProduct);
            this.Sidebar.Controls.Add(this.PnStaff);
            this.Sidebar.Controls.Add(this.pnreport1);
            this.Sidebar.Controls.Add(this.PnLogOut);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Sidebar.Location = new System.Drawing.Point(0, 37);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Sidebar.Size = new System.Drawing.Size(239, 863);
            this.Sidebar.TabIndex = 3;
            // 
            // PnDashboard
            // 
            this.PnDashboard.Controls.Add(this.button2);
            this.PnDashboard.Location = new System.Drawing.Point(3, 33);
            this.PnDashboard.Name = "PnDashboard";
            this.PnDashboard.Size = new System.Drawing.Size(236, 46);
            this.PnDashboard.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-14, -20);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(260, 86);
            this.button2.TabIndex = 5;
            this.button2.Text = "                    Dashboard";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnProduct
            // 
            this.pnProduct.Controls.Add(this.btnInventory);
            this.pnProduct.Location = new System.Drawing.Point(3, 85);
            this.pnProduct.Name = "pnProduct";
            this.pnProduct.Size = new System.Drawing.Size(236, 46);
            this.pnProduct.TabIndex = 7;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(-14, -20);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(277, 86);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "                    Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnStaff
            // 
            this.PnStaff.Controls.Add(this.button3);
            this.PnStaff.Location = new System.Drawing.Point(3, 137);
            this.PnStaff.Name = "PnStaff";
            this.PnStaff.Size = new System.Drawing.Size(253, 46);
            this.PnStaff.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-12, -21);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(303, 86);
            this.button3.TabIndex = 5;
            this.button3.Text = "                    Staff";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnreport1
            // 
            this.pnreport1.Controls.Add(this.btnReport);
            this.pnreport1.Location = new System.Drawing.Point(3, 189);
            this.pnreport1.Name = "pnreport1";
            this.pnreport1.Size = new System.Drawing.Size(236, 46);
            this.pnreport1.TabIndex = 7;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(-14, -20);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(277, 86);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "                    Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.button4_Click);
            // 
            // PnLogOut
            // 
            this.PnLogOut.Controls.Add(this.button5);
            this.PnLogOut.Location = new System.Drawing.Point(3, 241);
            this.PnLogOut.Name = "PnLogOut";
            this.PnLogOut.Size = new System.Drawing.Size(236, 46);
            this.PnLogOut.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-14, -20);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(277, 86);
            this.button5.TabIndex = 5;
            this.button5.Text = "                    Log out";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.lbInfo1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 37);
            this.panel1.TabIndex = 2;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.Black;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = false;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1461, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Black;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Black;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 2;
            // 
            // lbInfo1
            // 
            this.lbInfo1.AutoSize = true;
            this.lbInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo1.Location = new System.Drawing.Point(97, 10);
            this.lbInfo1.Name = "lbInfo1";
            this.lbInfo1.Size = new System.Drawing.Size(50, 20);
            this.lbInfo1.TabIndex = 1;
            this.lbInfo1.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MenuTransition
            // 
            this.MenuTransition.Interval = 10;
            // 
            // SidebarTransition
            // 
            this.SidebarTransition.Interval = 4;
            this.SidebarTransition.Tick += new System.EventHandler(this.SidebarTransition_Tick);
            // 
            // lostPanel5
            // 
            this.lostPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lostPanel5.Controls.Add(this.lnStaffNumber);
            this.lostPanel5.Controls.Add(this.foxLabel7);
            this.lostPanel5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lostPanel5.ForeColor = System.Drawing.Color.White;
            this.lostPanel5.Location = new System.Drawing.Point(1145, 70);
            this.lostPanel5.Name = "lostPanel5";
            this.lostPanel5.Padding = new System.Windows.Forms.Padding(5);
            this.lostPanel5.ShowText = true;
            this.lostPanel5.Size = new System.Drawing.Size(253, 124);
            this.lostPanel5.TabIndex = 52;
            // 
            // lnStaffNumber
            // 
            this.lnStaffNumber.AutoSize = true;
            this.lnStaffNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnStaffNumber.ForeColor = System.Drawing.Color.White;
            this.lnStaffNumber.Location = new System.Drawing.Point(94, 78);
            this.lnStaffNumber.Name = "lnStaffNumber";
            this.lnStaffNumber.Size = new System.Drawing.Size(25, 20);
            this.lnStaffNumber.TabIndex = 43;
            this.lnStaffNumber.Text = "00";
            // 
            // foxLabel7
            // 
            this.foxLabel7.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foxLabel7.ForeColor = System.Drawing.Color.White;
            this.foxLabel7.Location = new System.Drawing.Point(55, 15);
            this.foxLabel7.Name = "foxLabel7";
            this.foxLabel7.Size = new System.Drawing.Size(131, 30);
            this.foxLabel7.TabIndex = 41;
            this.foxLabel7.Text = "Total Staff";
            // 
            // lostPanel3
            // 
            this.lostPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lostPanel3.Controls.Add(this.cmbTime);
            this.lostPanel3.Controls.Add(this.lbTotalAmount);
            this.lostPanel3.Controls.Add(this.foxLabel5);
            this.lostPanel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lostPanel3.ForeColor = System.Drawing.Color.White;
            this.lostPanel3.Location = new System.Drawing.Point(360, 70);
            this.lostPanel3.Name = "lostPanel3";
            this.lostPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.lostPanel3.ShowText = true;
            this.lostPanel3.Size = new System.Drawing.Size(261, 124);
            this.lostPanel3.TabIndex = 50;
            // 
            // cmbTime
            // 
            this.cmbTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.ItemHeight = 20;
            this.cmbTime.Items.AddRange(new object[] {
            "Today",
            "Week",
            "Month"});
            this.cmbTime.Location = new System.Drawing.Point(123, 19);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(118, 26);
            this.cmbTime.TabIndex = 44;
            this.cmbTime.SelectedIndexChanged += new System.EventHandler(this.cmbTime_SelectedIndexChanged_1);
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.AutoSize = true;
            this.lbTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lbTotalAmount.Location = new System.Drawing.Point(64, 78);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(25, 20);
            this.lbTotalAmount.TabIndex = 43;
            this.lbTotalAmount.Text = "00";
            // 
            // foxLabel5
            // 
            this.foxLabel5.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foxLabel5.ForeColor = System.Drawing.Color.White;
            this.foxLabel5.Location = new System.Drawing.Point(9, 20);
            this.foxLabel5.Name = "foxLabel5";
            this.foxLabel5.Size = new System.Drawing.Size(135, 30);
            this.foxLabel5.TabIndex = 41;
            this.foxLabel5.Text = "Total Sold";
            // 
            // lostPanel7
            // 
            this.lostPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lostPanel7.Controls.Add(this.gridSoldProduct1);
            this.lostPanel7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lostPanel7.ForeColor = System.Drawing.Color.White;
            this.lostPanel7.Location = new System.Drawing.Point(383, 258);
            this.lostPanel7.Name = "lostPanel7";
            this.lostPanel7.Padding = new System.Windows.Forms.Padding(5);
            this.lostPanel7.ShowText = true;
            this.lostPanel7.Size = new System.Drawing.Size(1020, 534);
            this.lostPanel7.TabIndex = 55;
            this.lostPanel7.Text = "Recently Sold Product";
            // 
            // gridSoldProduct1
            // 
            this.gridSoldProduct1.AllowUserToResizeRows = false;
            this.gridSoldProduct1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSoldProduct1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSoldProduct1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridSoldProduct1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridSoldProduct1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSoldProduct1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridSoldProduct1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSoldProduct1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSoldProduct1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSoldProduct1.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSoldProduct1.EnableHeadersVisualStyles = false;
            this.gridSoldProduct1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridSoldProduct1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridSoldProduct1.Location = new System.Drawing.Point(23, 59);
            this.gridSoldProduct1.MultiSelect = false;
            this.gridSoldProduct1.Name = "gridSoldProduct1";
            this.gridSoldProduct1.ReadOnly = true;
            this.gridSoldProduct1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSoldProduct1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridSoldProduct1.RowHeadersWidth = 51;
            this.gridSoldProduct1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSoldProduct1.RowTemplate.Height = 24;
            this.gridSoldProduct1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSoldProduct1.Size = new System.Drawing.Size(971, 431);
            this.gridSoldProduct1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnRefresh.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefresh.Image = null;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnRefresh.Location = new System.Drawing.Point(845, 828);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnRefresh.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnRefresh.Size = new System.Drawing.Size(199, 45);
            this.btnRefresh.TabIndex = 52;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // AdminDashboard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lostPanel7);
            this.Controls.Add(this.lostPanel5);
            this.Controls.Add(this.lostPanel3);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "AdminDashboard1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTheme1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.AdminDashboard1_Load);
            this.Sidebar.ResumeLayout(false);
            this.PnDashboard.ResumeLayout(false);
            this.pnProduct.ResumeLayout(false);
            this.PnStaff.ResumeLayout(false);
            this.pnreport1.ResumeLayout(false);
            this.PnLogOut.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.lostPanel5.ResumeLayout(false);
            this.lostPanel5.PerformLayout();
            this.lostPanel3.ResumeLayout(false);
            this.lostPanel3.PerformLayout();
            this.lostPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSoldProduct1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Panel PnDashboard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel PnStaff;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel PnLogOut;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Label lbInfo1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer MenuTransition;
        private System.Windows.Forms.Timer SidebarTransition;
        private System.Windows.Forms.Panel pnProduct;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel pnreport1;
        private System.Windows.Forms.Button btnReport;
        private ReaLTaiizor.Controls.LostPanel lostPanel5;
        private System.Windows.Forms.Label lnStaffNumber;
        private ReaLTaiizor.Controls.FoxLabel foxLabel7;
        private ReaLTaiizor.Controls.LostPanel lostPanel3;
        private ReaLTaiizor.Controls.CrownComboBox cmbTime;
        private System.Windows.Forms.Label lbTotalAmount;
        private ReaLTaiizor.Controls.FoxLabel foxLabel5;
        private ReaLTaiizor.Controls.LostPanel lostPanel7;
        private ReaLTaiizor.Controls.Button btnRefresh;
        private ReaLTaiizor.Controls.PoisonDataGridView gridSoldProduct1;
    }
}