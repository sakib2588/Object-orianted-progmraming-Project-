namespace WindowsFormsApp1
{
    partial class ViewCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCart));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PnDashboard = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pnSellProduct = new System.Windows.Forms.Panel();
            this.btnSellProduct = new System.Windows.Forms.Button();
            this.pnViewCart = new System.Windows.Forms.Panel();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.PnLogOut = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.nightControlBox2 = new ReaLTaiizor.Controls.NightControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUserID = new System.Windows.Forms.Label();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuTransition = new System.Windows.Forms.Timer(this.components);
            this.SidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.rbcash = new System.Windows.Forms.RadioButton();
            this.btnConfirmPayment = new ReaLTaiizor.Controls.Button();
            this.btnShowCart = new ReaLTaiizor.Controls.Button();
            this.btnRemoveFromCart = new ReaLTaiizor.Controls.Button();
            this.gridCartItems = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.txtSession = new ReaLTaiizor.Controls.ForeverTextBox();
            this.nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            this.Sidebar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PnDashboard.SuspendLayout();
            this.pnSellProduct.SuspendLayout();
            this.pnViewCart.SuspendLayout();
            this.PnLogOut.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.foreverGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCartItems)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Sidebar.Controls.Add(this.flowLayoutPanel1);
            this.Sidebar.Controls.Add(this.panel11);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Sidebar.Location = new System.Drawing.Point(0, 37);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Sidebar.Size = new System.Drawing.Size(270, 863);
            this.Sidebar.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.flowLayoutPanel1.Controls.Add(this.PnDashboard);
            this.flowLayoutPanel1.Controls.Add(this.pnSellProduct);
            this.flowLayoutPanel1.Controls.Add(this.pnViewCart);
            this.flowLayoutPanel1.Controls.Add(this.PnLogOut);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(270, 863);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // PnDashboard
            // 
            this.PnDashboard.Controls.Add(this.button2);
            this.PnDashboard.Location = new System.Drawing.Point(3, 33);
            this.PnDashboard.Name = "PnDashboard";
            this.PnDashboard.Size = new System.Drawing.Size(249, 46);
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
            this.button2.Size = new System.Drawing.Size(288, 86);
            this.button2.TabIndex = 5;
            this.button2.Text = "                    Dashboard";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnSellProduct
            // 
            this.pnSellProduct.Controls.Add(this.btnSellProduct);
            this.pnSellProduct.Location = new System.Drawing.Point(3, 85);
            this.pnSellProduct.Name = "pnSellProduct";
            this.pnSellProduct.Size = new System.Drawing.Size(249, 46);
            this.pnSellProduct.TabIndex = 98;
            // 
            // btnSellProduct
            // 
            this.btnSellProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnSellProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellProduct.ForeColor = System.Drawing.Color.White;
            this.btnSellProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnSellProduct.Image")));
            this.btnSellProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSellProduct.Location = new System.Drawing.Point(-14, -20);
            this.btnSellProduct.Name = "btnSellProduct";
            this.btnSellProduct.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSellProduct.Size = new System.Drawing.Size(288, 86);
            this.btnSellProduct.TabIndex = 5;
            this.btnSellProduct.Text = "                    Sell Product";
            this.btnSellProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSellProduct.UseVisualStyleBackColor = false;
            this.btnSellProduct.Click += new System.EventHandler(this.btnSellProduct_Click);
            // 
            // pnViewCart
            // 
            this.pnViewCart.Controls.Add(this.btnViewCart);
            this.pnViewCart.Location = new System.Drawing.Point(3, 137);
            this.pnViewCart.Name = "pnViewCart";
            this.pnViewCart.Size = new System.Drawing.Size(249, 46);
            this.pnViewCart.TabIndex = 97;
            // 
            // btnViewCart
            // 
            this.btnViewCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnViewCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCart.ForeColor = System.Drawing.Color.White;
            this.btnViewCart.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCart.Image")));
            this.btnViewCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCart.Location = new System.Drawing.Point(-14, -20);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnViewCart.Size = new System.Drawing.Size(288, 86);
            this.btnViewCart.TabIndex = 5;
            this.btnViewCart.Text = "                    View Cart";
            this.btnViewCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCart.UseVisualStyleBackColor = false;
            // 
            // PnLogOut
            // 
            this.PnLogOut.Controls.Add(this.button5);
            this.PnLogOut.Location = new System.Drawing.Point(3, 189);
            this.PnLogOut.Name = "PnLogOut";
            this.PnLogOut.Size = new System.Drawing.Size(249, 46);
            this.PnLogOut.TabIndex = 96;
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
            this.button5.Size = new System.Drawing.Size(288, 86);
            this.button5.TabIndex = 5;
            this.button5.Text = "                    Log out";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.nightControlBox2);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.pictureBox2);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(279, 33);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(0, 37);
            this.panel11.TabIndex = 9;
            // 
            // nightControlBox2
            // 
            this.nightControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox2.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox2.CloseHoverForeColor = System.Drawing.Color.Black;
            this.nightControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox2.DefaultLocation = true;
            this.nightControlBox2.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox2.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox2.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox2.EnableMaximizeButton = true;
            this.nightControlBox2.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox2.EnableMinimizeButton = true;
            this.nightControlBox2.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox2.Location = new System.Drawing.Point(-139, 0);
            this.nightControlBox2.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox2.MaximizeHoverForeColor = System.Drawing.Color.Black;
            this.nightControlBox2.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox2.MinimizeHoverForeColor = System.Drawing.Color.Black;
            this.nightControlBox2.Name = "nightControlBox2";
            this.nightControlBox2.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbUserID);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 37);
            this.panel1.TabIndex = 4;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(261, 9);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(131, 20);
            this.lbUserID.TabIndex = 9;
            this.lbUserID.Text = "Welcome Back, ";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
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
            // foreverGroupBox1
            // 
            this.foreverGroupBox1.ArrowColorF = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverGroupBox1.ArrowColorH = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.foreverGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverGroupBox1.Controls.Add(this.rbCredit);
            this.foreverGroupBox1.Controls.Add(this.rbcash);
            this.foreverGroupBox1.Controls.Add(this.btnConfirmPayment);
            this.foreverGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.foreverGroupBox1.Location = new System.Drawing.Point(348, 561);
            this.foreverGroupBox1.Name = "foreverGroupBox1";
            this.foreverGroupBox1.ShowArrow = true;
            this.foreverGroupBox1.ShowText = true;
            this.foreverGroupBox1.Size = new System.Drawing.Size(458, 284);
            this.foreverGroupBox1.TabIndex = 9;
            this.foreverGroupBox1.Text = "Payment Methord";
            this.foreverGroupBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Location = new System.Drawing.Point(142, 115);
            this.rbCredit.Margin = new System.Windows.Forms.Padding(4);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(144, 27);
            this.rbCredit.TabIndex = 113;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "Credit or Debit";
            this.rbCredit.UseVisualStyleBackColor = true;
            // 
            // rbcash
            // 
            this.rbcash.AutoSize = true;
            this.rbcash.Location = new System.Drawing.Point(140, 51);
            this.rbcash.Margin = new System.Windows.Forms.Padding(4);
            this.rbcash.Name = "rbcash";
            this.rbcash.Size = new System.Drawing.Size(139, 27);
            this.rbcash.TabIndex = 114;
            this.rbcash.TabStop = true;
            this.rbcash.Text = "Cash Payment";
            this.rbcash.UseVisualStyleBackColor = true;
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmPayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnConfirmPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmPayment.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnConfirmPayment.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnConfirmPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConfirmPayment.Image = null;
            this.btnConfirmPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmPayment.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnConfirmPayment.Location = new System.Drawing.Point(115, 184);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnConfirmPayment.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnConfirmPayment.Size = new System.Drawing.Size(240, 66);
            this.btnConfirmPayment.TabIndex = 112;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // btnShowCart
            // 
            this.btnShowCart.BackColor = System.Drawing.Color.Transparent;
            this.btnShowCart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnShowCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowCart.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnShowCart.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnShowCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnShowCart.Image = null;
            this.btnShowCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowCart.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnShowCart.Location = new System.Drawing.Point(902, 586);
            this.btnShowCart.Name = "btnShowCart";
            this.btnShowCart.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnShowCart.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnShowCart.Size = new System.Drawing.Size(199, 45);
            this.btnShowCart.TabIndex = 113;
            this.btnShowCart.Text = "Show Cart";
            this.btnShowCart.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnShowCart.Click += new System.EventHandler(this.btnShowCart_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveFromCart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnRemoveFromCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveFromCart.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnRemoveFromCart.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRemoveFromCart.Image = null;
            this.btnRemoveFromCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveFromCart.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnRemoveFromCart.Location = new System.Drawing.Point(1255, 586);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnRemoveFromCart.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnRemoveFromCart.Size = new System.Drawing.Size(199, 45);
            this.btnRemoveFromCart.TabIndex = 115;
            this.btnRemoveFromCart.Text = "Remove From Cart";
            this.btnRemoveFromCart.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.BtnRemoveFromCart_Click);
            // 
            // gridCartItems
            // 
            this.gridCartItems.AllowUserToResizeRows = false;
            this.gridCartItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridCartItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridCartItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.gridCartItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCartItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCartItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCartItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCartItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCartItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCartItems.EnableHeadersVisualStyles = false;
            this.gridCartItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridCartItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.gridCartItems.Location = new System.Drawing.Point(328, 70);
            this.gridCartItems.MultiSelect = false;
            this.gridCartItems.Name = "gridCartItems";
            this.gridCartItems.ReadOnly = true;
            this.gridCartItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCartItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCartItems.RowHeadersWidth = 51;
            this.gridCartItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCartItems.RowTemplate.Height = 24;
            this.gridCartItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCartItems.Size = new System.Drawing.Size(1216, 435);
            this.gridCartItems.TabIndex = 116;
            this.gridCartItems.Click += new System.EventHandler(this.GridCartItems_Click);
            // 
            // txtSession
            // 
            this.txtSession.BackColor = System.Drawing.Color.Transparent;
            this.txtSession.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtSession.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txtSession.FocusOnHover = false;
            this.txtSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSession.Location = new System.Drawing.Point(532, 525);
            this.txtSession.MaxLength = 32767;
            this.txtSession.Multiline = false;
            this.txtSession.Name = "txtSession";
            this.txtSession.ReadOnly = true;
            this.txtSession.Size = new System.Drawing.Size(180, 34);
            this.txtSession.TabIndex = 117;
            this.txtSession.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSession.UseSystemPasswordChar = false;
            // 
            // nightLabel2
            // 
            this.nightLabel2.AutoSize = true;
            this.nightLabel2.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightLabel2.ForeColor = System.Drawing.Color.White;
            this.nightLabel2.Location = new System.Drawing.Point(422, 530);
            this.nightLabel2.Name = "nightLabel2";
            this.nightLabel2.Size = new System.Drawing.Size(93, 23);
            this.nightLabel2.TabIndex = 116;
            this.nightLabel2.Text = "Session ID ";
            // 
            // ViewCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.nightLabel2);
            this.Controls.Add(this.gridCartItems);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnShowCart);
            this.Controls.Add(this.foreverGroupBox1);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "ViewCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTheme2";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.SellProduct_Load);
            this.Sidebar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PnDashboard.ResumeLayout(false);
            this.pnSellProduct.ResumeLayout(false);
            this.pnViewCart.ResumeLayout(false);
            this.PnLogOut.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.foreverGroupBox1.ResumeLayout(false);
            this.foreverGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCartItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Panel PnDashboard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel11;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer MenuTransition;
        private System.Windows.Forms.Timer SidebarTransition;
        private System.Windows.Forms.Panel pnSellProduct;
        private System.Windows.Forms.Button btnSellProduct;
        private System.Windows.Forms.Panel pnViewCart;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.Panel PnLogOut;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lbUserID;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.Button btnConfirmPayment;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.RadioButton rbcash;
        private ReaLTaiizor.Controls.Button btnShowCart;
        private ReaLTaiizor.Controls.Button btnRemoveFromCart;
        private ReaLTaiizor.Controls.PoisonDataGridView gridCartItems;
        private ReaLTaiizor.Controls.ForeverTextBox txtSession;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
    }
}