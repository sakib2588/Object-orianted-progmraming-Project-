namespace WindowsFormsApp1
{
    partial class ManageStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStaff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.PnDashboard = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PnStaff = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.PnLogOut = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new ReaLTaiizor.Controls.Panel();
            this.nightLabel9 = new ReaLTaiizor.Controls.NightLabel();
            this.txtBoxPassword = new ReaLTaiizor.Controls.ForeverTextBox();
            this.nightLabel6 = new ReaLTaiizor.Controls.NightLabel();
            this.btnStaffShow = new ReaLTaiizor.Controls.Button();
            this.nightLabel8 = new ReaLTaiizor.Controls.NightLabel();
            this.comStatus = new ReaLTaiizor.Controls.CrownComboBox();
            this.nightLabel7 = new ReaLTaiizor.Controls.NightLabel();
            this.txtBoxStaffID = new ReaLTaiizor.Controls.ForeverTextBox();
            this.comBlood = new ReaLTaiizor.Controls.CrownComboBox();
            this.nightLabel5 = new ReaLTaiizor.Controls.NightLabel();
            this.nightLabel4 = new ReaLTaiizor.Controls.NightLabel();
            this.nightLabel3 = new ReaLTaiizor.Controls.NightLabel();
            this.nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            this.nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            this.btnStaffRemove = new ReaLTaiizor.Controls.Button();
            this.btnStaffAdd = new ReaLTaiizor.Controls.Button();
            this.txtBoxPhone = new ReaLTaiizor.Controls.ForeverTextBox();
            this.comGender = new ReaLTaiizor.Controls.CrownComboBox();
            this.txtBoxEmail = new ReaLTaiizor.Controls.ForeverTextBox();
            this.txtBoxAge = new ReaLTaiizor.Controls.ForeverTextBox();
            this.txtboxStaffName = new ReaLTaiizor.Controls.ForeverTextBox();
            this.panel5 = new ReaLTaiizor.Controls.Panel();
            this.StaffTable = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.Sidebar.SuspendLayout();
            this.PnDashboard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PnStaff.SuspendLayout();
            this.panel4.SuspendLayout();
            this.PnLogOut.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Sidebar.Controls.Add(this.PnDashboard);
            this.Sidebar.Controls.Add(this.panel2);
            this.Sidebar.Controls.Add(this.PnStaff);
            this.Sidebar.Controls.Add(this.panel4);
            this.Sidebar.Controls.Add(this.PnLogOut);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Sidebar.Location = new System.Drawing.Point(0, 37);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Sidebar.Size = new System.Drawing.Size(239, 816);
            this.Sidebar.TabIndex = 5;
            // 
            // PnDashboard
            // 
            this.PnDashboard.Controls.Add(this.button2);
            this.PnDashboard.Location = new System.Drawing.Point(3, 33);
            this.PnDashboard.Name = "PnDashboard";
            this.PnDashboard.Size = new System.Drawing.Size(236, 46);
            this.PnDashboard.TabIndex = 8;
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
            this.button2.Size = new System.Drawing.Size(277, 86);
            this.button2.TabIndex = 5;
            this.button2.Text = "                    Dashboard";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 46);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-14, -20);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(277, 86);
            this.button1.TabIndex = 5;
            this.button1.Text = "                    Inventory";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnStaff
            // 
            this.PnStaff.Controls.Add(this.button3);
            this.PnStaff.Location = new System.Drawing.Point(3, 137);
            this.PnStaff.Name = "PnStaff";
            this.PnStaff.Size = new System.Drawing.Size(249, 46);
            this.PnStaff.TabIndex = 11;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(3, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 46);
            this.panel4.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-14, -20);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(277, 86);
            this.button4.TabIndex = 5;
            this.button4.Text = "                    Report";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PnLogOut
            // 
            this.PnLogOut.Controls.Add(this.button5);
            this.PnLogOut.Location = new System.Drawing.Point(3, 241);
            this.PnLogOut.Name = "PnLogOut";
            this.PnLogOut.Size = new System.Drawing.Size(232, 46);
            this.PnLogOut.TabIndex = 12;
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
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 37);
            this.panel1.TabIndex = 4;
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
            this.nightControlBox1.Location = new System.Drawing.Point(1443, 0);
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
            // 
            // SidebarTransition
            // 
            this.SidebarTransition.Interval = 4;
            this.SidebarTransition.Tick += new System.EventHandler(this.SidebarTransition_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.panel3.Controls.Add(this.nightLabel9);
            this.panel3.Controls.Add(this.txtBoxPassword);
            this.panel3.Controls.Add(this.nightLabel6);
            this.panel3.Controls.Add(this.btnStaffShow);
            this.panel3.Controls.Add(this.nightLabel8);
            this.panel3.Controls.Add(this.comStatus);
            this.panel3.Controls.Add(this.nightLabel7);
            this.panel3.Controls.Add(this.txtBoxStaffID);
            this.panel3.Controls.Add(this.comBlood);
            this.panel3.Controls.Add(this.nightLabel5);
            this.panel3.Controls.Add(this.nightLabel4);
            this.panel3.Controls.Add(this.nightLabel3);
            this.panel3.Controls.Add(this.nightLabel2);
            this.panel3.Controls.Add(this.nightLabel1);
            this.panel3.Controls.Add(this.btnStaffRemove);
            this.panel3.Controls.Add(this.btnStaffAdd);
            this.panel3.Controls.Add(this.txtBoxPhone);
            this.panel3.Controls.Add(this.comGender);
            this.panel3.Controls.Add(this.txtBoxEmail);
            this.panel3.Controls.Add(this.txtBoxAge);
            this.panel3.Controls.Add(this.txtboxStaffName);
            this.panel3.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel3.Location = new System.Drawing.Point(241, 43);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(1341, 397);
            this.panel3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel3.TabIndex = 8;
            // 
            // nightLabel9
            // 
            this.nightLabel9.AutoSize = true;
            this.nightLabel9.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightLabel9.ForeColor = System.Drawing.Color.White;
            this.nightLabel9.Location = new System.Drawing.Point(48, 98);
            this.nightLabel9.Name = "nightLabel9";
            this.nightLabel9.Size = new System.Drawing.Size(80, 23);
            this.nightLabel9.TabIndex = 70;
            this.nightLabel9.Text = "Password";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxPassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txtBoxPassword.FocusOnHover = false;
            this.txtBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtBoxPassword.Location = new System.Drawing.Point(206, 91);
            this.txtBoxPassword.MaxLength = 32767;
            this.txtBoxPassword.Multiline = false;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.ReadOnly = false;
            this.txtBoxPassword.Size = new System.Drawing.Size(362, 34);
            this.txtBoxPassword.TabIndex = 69;
            this.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // nightLabel6
            // 
            this.nightLabel6.AutoSize = true;
            this.nightLabel6.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightLabel6.ForeColor = System.Drawing.Color.White;
            this.nightLabel6.Location = new System.Drawing.Point(794, 218);
            this.nightLabel6.Name = "nightLabel6";
            this.nightLabel6.Size = new System.Drawing.Size(66, 23);
            this.nightLabel6.TabIndex = 68;
            this.nightLabel6.Text = "Gender";
            // 
            // btnStaffShow
            // 
            this.btnStaffShow.BackColor = System.Drawing.Color.Transparent;
            this.btnStaffShow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnStaffShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffShow.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnStaffShow.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnStaffShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStaffShow.Image = null;
            this.btnStaffShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffShow.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnStaffShow.Location = new System.Drawing.Point(588, 324);
            this.btnStaffShow.Name = "btnStaffShow";
            this.btnStaffShow.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnStaffShow.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnStaffShow.Size = new System.Drawing.Size(212, 45);
            this.btnStaffShow.TabIndex = 67;
            this.btnStaffShow.Text = "Show Table ";
            this.btnStaffShow.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnStaffShow.Click += new System.EventHandler(this.btnStaffShow_Click);
            // 
            // nightLabel8
            // 
            this.nightLabel8.AutoSize = true;
            this.nightLabel8.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightLabel8.ForeColor = System.Drawing.Color.White;
            this.nightLabel8.Location = new System.Drawing.Point(48, 254);
            this.nightLabel8.Name = "nightLabel8";
            this.nightLabel8.Size = new System.Drawing.Size(56, 23);
            this.nightLabel8.TabIndex = 66;
            this.nightLabel8.Text = "Status";
            // 
            // comStatus
            // 
            this.comStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comStatus.FormattingEnabled = true;
            this.comStatus.ItemHeight = 26;
            this.comStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comStatus.Location = new System.Drawing.Point(206, 249);
            this.comStatus.Name = "comStatus";
            this.comStatus.Size = new System.Drawing.Size(151, 32);
            this.comStatus.TabIndex = 65;
            // 
            // nightLabel7
            // 
            this.nightLabel7.AutoSize = true;
            this.nightLabel7.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightLabel7.ForeColor = System.Drawing.Color.White;
            this.nightLabel7.Location = new System.Drawing.Point(794, 41);
            this.nightLabel7.Name = "nightLabel7";
            this.nightLabel7.Size = new System.Drawing.Size(66, 23);
            this.nightLabel7.TabIndex = 64;
            this.nightLabel7.Text = "User ID";
            // 
            // txtBoxStaffID
            // 
            this.txtBoxStaffID.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxStaffID.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtBoxStaffID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txtBoxStaffID.FocusOnHover = false;
            this.txtBoxStaffID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtBoxStaffID.Location = new System.Drawing.Point(924, 30);
            this.txtBoxStaffID.MaxLength = 32767;
            this.txtBoxStaffID.Multiline = false;
            this.txtBoxStaffID.Name = "txtBoxStaffID";
            this.txtBoxStaffID.ReadOnly = true;
            this.txtBoxStaffID.Size = new System.Drawing.Size(151, 34);
            this.txtBoxStaffID.TabIndex = 63;
            this.txtBoxStaffID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxStaffID.UseSystemPasswordChar = false;
            // 
            // comBlood
            // 
            this.comBlood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comBlood.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comBlood.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBlood.FormattingEnabled = true;
            this.comBlood.ItemHeight = 26;
            this.comBlood.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.comBlood.Location = new System.Drawing.Point(924, 157);
            this.comBlood.Name = "comBlood";
            this.comBlood.Size = new System.Drawing.Size(151, 32);
            this.comBlood.TabIndex = 62;
            // 
            // nightLabel5
            // 
            this.nightLabel5.AutoSize = true;
            this.nightLabel5.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightLabel5.ForeColor = System.Drawing.Color.White;
            this.nightLabel5.Location = new System.Drawing.Point(794, 102);
            this.nightLabel5.Name = "nightLabel5";
            this.nightLabel5.Size = new System.Drawing.Size(40, 23);
            this.nightLabel5.TabIndex = 60;
            this.nightLabel5.Text = "Age";
            // 
            // nightLabel4
            // 
            this.nightLabel4.AutoSize = true;
            this.nightLabel4.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightLabel4.ForeColor = System.Drawing.Color.White;
            this.nightLabel4.Location = new System.Drawing.Point(794, 163);
            this.nightLabel4.Name = "nightLabel4";
            this.nightLabel4.Size = new System.Drawing.Size(94, 23);
            this.nightLabel4.TabIndex = 59;
            this.nightLabel4.Text = "Blood Type";
            // 
            // nightLabel3
            // 
            this.nightLabel3.AutoSize = true;
            this.nightLabel3.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightLabel3.ForeColor = System.Drawing.Color.White;
            this.nightLabel3.Location = new System.Drawing.Point(48, 194);
            this.nightLabel3.Name = "nightLabel3";
            this.nightLabel3.Size = new System.Drawing.Size(127, 23);
            this.nightLabel3.TabIndex = 58;
            this.nightLabel3.Text = "Phone Number";
            // 
            // nightLabel2
            // 
            this.nightLabel2.AutoSize = true;
            this.nightLabel2.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightLabel2.ForeColor = System.Drawing.Color.White;
            this.nightLabel2.Location = new System.Drawing.Point(48, 151);
            this.nightLabel2.Name = "nightLabel2";
            this.nightLabel2.Size = new System.Drawing.Size(51, 23);
            this.nightLabel2.TabIndex = 57;
            this.nightLabel2.Text = "Email";
            // 
            // nightLabel1
            // 
            this.nightLabel1.AutoSize = true;
            this.nightLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightLabel1.ForeColor = System.Drawing.Color.White;
            this.nightLabel1.Location = new System.Drawing.Point(48, 39);
            this.nightLabel1.Name = "nightLabel1";
            this.nightLabel1.Size = new System.Drawing.Size(94, 23);
            this.nightLabel1.TabIndex = 56;
            this.nightLabel1.Text = "Staff Name";
            // 
            // btnStaffRemove
            // 
            this.btnStaffRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnStaffRemove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnStaffRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffRemove.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnStaffRemove.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnStaffRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStaffRemove.Image = null;
            this.btnStaffRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffRemove.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnStaffRemove.Location = new System.Drawing.Point(943, 324);
            this.btnStaffRemove.Name = "btnStaffRemove";
            this.btnStaffRemove.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnStaffRemove.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnStaffRemove.Size = new System.Drawing.Size(212, 45);
            this.btnStaffRemove.TabIndex = 53;
            this.btnStaffRemove.Text = "Remove Staff";
            this.btnStaffRemove.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnStaffRemove.Click += new System.EventHandler(this.btnStaffRemove_Click);
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnStaffAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnStaffAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffAdd.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnStaffAdd.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnStaffAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStaffAdd.Image = null;
            this.btnStaffAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffAdd.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnStaffAdd.Location = new System.Drawing.Point(270, 324);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnStaffAdd.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnStaffAdd.Size = new System.Drawing.Size(199, 45);
            this.btnStaffAdd.TabIndex = 52;
            this.btnStaffAdd.Text = "Add Staff";
            this.btnStaffAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnStaffAdd.Click += new System.EventHandler(this.btnStaffAdd_Click);
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxPhone.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtBoxPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txtBoxPhone.FocusOnHover = false;
            this.txtBoxPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtBoxPhone.Location = new System.Drawing.Point(206, 189);
            this.txtBoxPhone.MaxLength = 32767;
            this.txtBoxPhone.Multiline = false;
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.ReadOnly = false;
            this.txtBoxPhone.Size = new System.Drawing.Size(362, 34);
            this.txtBoxPhone.TabIndex = 18;
            this.txtBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxPhone.UseSystemPasswordChar = false;
            // 
            // comGender
            // 
            this.comGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comGender.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comGender.FormattingEnabled = true;
            this.comGender.ItemHeight = 26;
            this.comGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comGender.Location = new System.Drawing.Point(924, 212);
            this.comGender.Name = "comGender";
            this.comGender.Size = new System.Drawing.Size(151, 32);
            this.comGender.TabIndex = 17;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxEmail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtBoxEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txtBoxEmail.FocusOnHover = false;
            this.txtBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtBoxEmail.Location = new System.Drawing.Point(206, 140);
            this.txtBoxEmail.MaxLength = 32767;
            this.txtBoxEmail.Multiline = false;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.ReadOnly = false;
            this.txtBoxEmail.Size = new System.Drawing.Size(362, 34);
            this.txtBoxEmail.TabIndex = 15;
            this.txtBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxEmail.UseSystemPasswordChar = false;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxAge.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtBoxAge.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txtBoxAge.FocusOnHover = false;
            this.txtBoxAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtBoxAge.Location = new System.Drawing.Point(924, 94);
            this.txtBoxAge.MaxLength = 32767;
            this.txtBoxAge.Multiline = false;
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.ReadOnly = false;
            this.txtBoxAge.Size = new System.Drawing.Size(151, 34);
            this.txtBoxAge.TabIndex = 14;
            this.txtBoxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxAge.UseSystemPasswordChar = false;
            // 
            // txtboxStaffName
            // 
            this.txtboxStaffName.BackColor = System.Drawing.Color.Transparent;
            this.txtboxStaffName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtboxStaffName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txtboxStaffName.FocusOnHover = false;
            this.txtboxStaffName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtboxStaffName.Location = new System.Drawing.Point(206, 36);
            this.txtboxStaffName.MaxLength = 32767;
            this.txtboxStaffName.Multiline = false;
            this.txtboxStaffName.Name = "txtboxStaffName";
            this.txtboxStaffName.ReadOnly = false;
            this.txtboxStaffName.Size = new System.Drawing.Size(362, 34);
            this.txtboxStaffName.TabIndex = 12;
            this.txtboxStaffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtboxStaffName.UseSystemPasswordChar = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.panel5.Controls.Add(this.StaffTable);
            this.panel5.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel5.Location = new System.Drawing.Point(241, 436);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(1341, 417);
            this.panel5.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel5.TabIndex = 9;
            this.panel5.Text = "panel5";
            // 
            // StaffTable
            // 
            this.StaffTable.AllowUserToOrderColumns = true;
            this.StaffTable.AllowUserToResizeRows = false;
            this.StaffTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StaffTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.StaffTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.StaffTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StaffTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.StaffTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StaffTable.EnableHeadersVisualStyles = false;
            this.StaffTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StaffTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.StaffTable.Location = new System.Drawing.Point(5, 5);
            this.StaffTable.MultiSelect = false;
            this.StaffTable.Name = "StaffTable";
            this.StaffTable.ReadOnly = true;
            this.StaffTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StaffTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.StaffTable.RowTemplate.Height = 24;
            this.StaffTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffTable.Size = new System.Drawing.Size(1331, 407);
            this.StaffTable.TabIndex = 0;
            this.StaffTable.DoubleClick += new System.EventHandler(this.StaffTable_DoubleClick);
            // 
            // ManageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "ManageStaff";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "themeForm1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.ManageStaff_Load);
            this.Sidebar.ResumeLayout(false);
            this.PnDashboard.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PnStaff.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.PnLogOut.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StaffTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer SidebarTransition;
        private System.Windows.Forms.Panel PnDashboard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel PnStaff;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel PnLogOut;
        private System.Windows.Forms.Button button5;
        private ReaLTaiizor.Controls.Panel panel3;
        private ReaLTaiizor.Controls.NightLabel nightLabel5;
        private ReaLTaiizor.Controls.NightLabel nightLabel4;
        private ReaLTaiizor.Controls.NightLabel nightLabel3;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private ReaLTaiizor.Controls.Button btnStaffRemove;
        private ReaLTaiizor.Controls.Button btnStaffAdd;
        private ReaLTaiizor.Controls.ForeverTextBox txtBoxPhone;
        private ReaLTaiizor.Controls.CrownComboBox comGender;
        private ReaLTaiizor.Controls.ForeverTextBox txtBoxEmail;
        private ReaLTaiizor.Controls.ForeverTextBox txtBoxAge;
        private ReaLTaiizor.Controls.ForeverTextBox txtboxStaffName;
        private ReaLTaiizor.Controls.Panel panel5;
        private ReaLTaiizor.Controls.CrownComboBox comBlood;
        private ReaLTaiizor.Controls.NightLabel nightLabel7;
        private ReaLTaiizor.Controls.ForeverTextBox txtBoxStaffID;
        private ReaLTaiizor.Controls.NightLabel nightLabel8;
        private ReaLTaiizor.Controls.CrownComboBox comStatus;
        private ReaLTaiizor.Controls.Button btnStaffShow;
        private ReaLTaiizor.Controls.PoisonDataGridView StaffTable;
        private ReaLTaiizor.Controls.NightLabel nightLabel6;
        private ReaLTaiizor.Controls.NightLabel nightLabel9;
        private ReaLTaiizor.Controls.ForeverTextBox txtBoxPassword;
    }
}