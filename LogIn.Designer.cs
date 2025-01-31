namespace WindowsFormsApp1
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.button1 = new ReaLTaiizor.Controls.Button();
            this.button2 = new ReaLTaiizor.Controls.Button();
            this.nightLabel3 = new ReaLTaiizor.Controls.NightLabel();
            this.User = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.Pass = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.colourPanel1 = new WindowsFormsApp1.ColourPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroCheckBox1 = new ReaLTaiizor.Controls.MetroCheckBox();
            this.nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            this.colourPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Image = null;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Location = new System.Drawing.Point(761, 465);
            this.button1.Name = "button1";
            this.button1.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Log in";
            this.button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button2.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Image = null;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button2.Location = new System.Drawing.Point(909, 464);
            this.button2.Name = "button2";
            this.button2.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear";
            this.button2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nightLabel3
            // 
            this.nightLabel3.AutoSize = true;
            this.nightLabel3.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightLabel3.ForeColor = System.Drawing.Color.White;
            this.nightLabel3.Location = new System.Drawing.Point(121, 413);
            this.nightLabel3.Name = "nightLabel3";
            this.nightLabel3.Size = new System.Drawing.Size(0, 23);
            this.nightLabel3.TabIndex = 78;
            // 
            // User
            // 
            this.User.AllowPromptAsInput = true;
            this.User.AnimateReadOnly = false;
            this.User.AsciiOnly = false;
            this.User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.User.BeepOnError = false;
            this.User.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.User.Depth = 0;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.User.HidePromptOnLeave = false;
            this.User.HideSelection = true;
            this.User.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.User.LeadingIcon = null;
            this.User.Location = new System.Drawing.Point(770, 279);
            this.User.Mask = "";
            this.User.MaxLength = 32767;
            this.User.MouseState = MaterialSkin.MouseState.OUT;
            this.User.Name = "User";
            this.User.PasswordChar = '\0';
            this.User.PrefixSuffixText = null;
            this.User.PromptChar = '_';
            this.User.ReadOnly = false;
            this.User.RejectInputOnFirstFailure = false;
            this.User.ResetOnPrompt = true;
            this.User.ResetOnSpace = true;
            this.User.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.User.SelectedText = "";
            this.User.SelectionLength = 0;
            this.User.SelectionStart = 0;
            this.User.ShortcutsEnabled = true;
            this.User.Size = new System.Drawing.Size(250, 48);
            this.User.SkipLiterals = true;
            this.User.TabIndex = 81;
            this.User.TabStop = false;
            this.User.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.User.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.User.TrailingIcon = null;
            this.User.UseSystemPasswordChar = false;
            this.User.ValidatingType = null;
            // 
            // Pass
            // 
            this.Pass.AllowPromptAsInput = true;
            this.Pass.AnimateReadOnly = false;
            this.Pass.AsciiOnly = false;
            this.Pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pass.BeepOnError = false;
            this.Pass.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Pass.Depth = 0;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Pass.HidePromptOnLeave = false;
            this.Pass.HideSelection = true;
            this.Pass.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Pass.LeadingIcon = null;
            this.Pass.Location = new System.Drawing.Point(770, 365);
            this.Pass.Mask = "";
            this.Pass.MaxLength = 32767;
            this.Pass.MouseState = MaterialSkin.MouseState.OUT;
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.PrefixSuffixText = null;
            this.Pass.PromptChar = '_';
            this.Pass.ReadOnly = false;
            this.Pass.RejectInputOnFirstFailure = false;
            this.Pass.ResetOnPrompt = true;
            this.Pass.ResetOnSpace = true;
            this.Pass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Pass.SelectedText = "";
            this.Pass.SelectionLength = 0;
            this.Pass.SelectionStart = 0;
            this.Pass.ShortcutsEnabled = true;
            this.Pass.Size = new System.Drawing.Size(250, 48);
            this.Pass.SkipLiterals = true;
            this.Pass.TabIndex = 82;
            this.Pass.TabStop = false;
            this.Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Pass.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Pass.TrailingIcon = null;
            this.Pass.UseSystemPasswordChar = false;
            this.Pass.ValidatingType = null;
            // 
            // colourPanel1
            // 
            this.colourPanel1.Controls.Add(this.pictureBox2);
            this.colourPanel1.gradientBottom = System.Drawing.Color.DarkCyan;
            this.colourPanel1.gradientTop = System.Drawing.Color.RoyalBlue;
            this.colourPanel1.Location = new System.Drawing.Point(-6, -5);
            this.colourPanel1.Name = "colourPanel1";
            this.colourPanel1.Size = new System.Drawing.Size(589, 760);
            this.colourPanel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 43);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(531, 597);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.metroCheckBox1.BackgroundColor = System.Drawing.Color.White;
            this.metroCheckBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroCheckBox1.Checked = false;
            this.metroCheckBox1.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroCheckBox1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.metroCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroCheckBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroCheckBox1.IsDerivedStyle = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(770, 424);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.SignStyle = ReaLTaiizor.Enum.Metro.SignStyle.Sign;
            this.metroCheckBox1.Size = new System.Drawing.Size(153, 16);
            this.metroCheckBox1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroCheckBox1.StyleManager = null;
            this.metroCheckBox1.TabIndex = 83;
            this.metroCheckBox1.Text = "Show Password";
            this.metroCheckBox1.ThemeAuthor = "Taiizor";
            this.metroCheckBox1.ThemeName = "MetroLight";
            this.metroCheckBox1.CheckedChanged += new ReaLTaiizor.Controls.MetroCheckBox.CheckedChangedEventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // nightLabel1
            // 
            this.nightLabel1.AutoSize = true;
            this.nightLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightLabel1.ForeColor = System.Drawing.Color.Black;
            this.nightLabel1.Location = new System.Drawing.Point(712, 148);
            this.nightLabel1.Name = "nightLabel1";
            this.nightLabel1.Size = new System.Drawing.Size(372, 38);
            this.nightLabel1.TabIndex = 84;
            this.nightLabel1.Text = "Log In To Enter The System";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1192, 751);
            this.Controls.Add(this.nightLabel1);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.User);
            this.Controls.Add(this.nightLabel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colourPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.colourPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private ColourPanel colourPanel1;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.Button button2;
        private ReaLTaiizor.Controls.NightLabel nightLabel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox User;
        private MaterialSkin.Controls.MaterialMaskedTextBox Pass;
        private ReaLTaiizor.Controls.MetroCheckBox metroCheckBox1;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
    }
}