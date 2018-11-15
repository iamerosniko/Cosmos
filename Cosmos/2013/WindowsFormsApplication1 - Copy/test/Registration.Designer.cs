namespace test
{
    partial class Registration
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new System.Windows.Forms.Panel();
            this.pnlReadOnlyTeam = new System.Windows.Forms.Panel();
            this.txtTeam = new MetroFramework.Controls.MetroTextBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.pnlTeamWithCombo = new System.Windows.Forms.Panel();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnOpenWaiver = new MetroFramework.Controls.MetroButton();
            this.chbWaive = new System.Windows.Forms.CheckBox();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMiddleName = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeader = new MetroFramework.Controls.MetroTextBox();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.txtWorkdayID = new MetroFramework.Controls.MetroTextBox();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.lblTL = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblWDID = new System.Windows.Forms.Label();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.pnlReadOnlyTeam.SuspendLayout();
            this.pnlTeamWithCombo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlImage, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1107, 690);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.LightGray;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.pnlReadOnlyTeam);
            this.metroPanel1.Controls.Add(this.pnlTeamWithCombo);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.btnOpenWaiver);
            this.metroPanel1.Controls.Add(this.chbWaive);
            this.metroPanel1.Controls.Add(this.txtLastName);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.txtMiddleName);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.txtLeader);
            this.metroPanel1.Controls.Add(this.txtFirstName);
            this.metroPanel1.Controls.Add(this.txtWorkdayID);
            this.metroPanel1.Controls.Add(this.btnRegister);
            this.metroPanel1.Controls.Add(this.lblTL);
            this.metroPanel1.Controls.Add(this.lblEmp);
            this.metroPanel1.Controls.Add(this.lblWDID);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.Location = new System.Drawing.Point(757, 0);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(350, 690);
            this.metroPanel1.TabIndex = 4;
            // 
            // pnlReadOnlyTeam
            // 
            this.pnlReadOnlyTeam.Controls.Add(this.txtTeam);
            this.pnlReadOnlyTeam.Controls.Add(this.lblTeam);
            this.pnlReadOnlyTeam.Location = new System.Drawing.Point(3, 331);
            this.pnlReadOnlyTeam.Name = "pnlReadOnlyTeam";
            this.pnlReadOnlyTeam.Size = new System.Drawing.Size(336, 61);
            this.pnlReadOnlyTeam.TabIndex = 16;
            // 
            // txtTeam
            // 
            this.txtTeam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTeam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtTeam.CustomButton.Image = null;
            this.txtTeam.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtTeam.CustomButton.Name = "";
            this.txtTeam.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTeam.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTeam.CustomButton.TabIndex = 1;
            this.txtTeam.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTeam.CustomButton.UseSelectable = true;
            this.txtTeam.CustomButton.Visible = false;
            this.txtTeam.Lines = new string[0];
            this.txtTeam.Location = new System.Drawing.Point(7, 29);
            this.txtTeam.MaxLength = 32767;
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.PasswordChar = '\0';
            this.txtTeam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTeam.SelectedText = "";
            this.txtTeam.SelectionLength = 0;
            this.txtTeam.SelectionStart = 0;
            this.txtTeam.ShortcutsEnabled = true;
            this.txtTeam.Size = new System.Drawing.Size(328, 23);
            this.txtTeam.TabIndex = 5;
            this.txtTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTeam.UseSelectable = true;
            this.txtTeam.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTeam.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.Location = new System.Drawing.Point(140, 6);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(63, 20);
            this.lblTeam.TabIndex = 4;
            this.lblTeam.Text = "Team :";
            // 
            // pnlTeamWithCombo
            // 
            this.pnlTeamWithCombo.Controls.Add(this.cmbTeam);
            this.pnlTeamWithCombo.Controls.Add(this.label3);
            this.pnlTeamWithCombo.Location = new System.Drawing.Point(4, 331);
            this.pnlTeamWithCombo.Name = "pnlTeamWithCombo";
            this.pnlTeamWithCombo.Size = new System.Drawing.Size(336, 61);
            this.pnlTeamWithCombo.TabIndex = 17;
            // 
            // cmbTeam
            // 
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.ItemHeight = 13;
            this.cmbTeam.Location = new System.Drawing.Point(5, 25);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(325, 21);
            this.cmbTeam.TabIndex = 5;
            this.cmbTeam.TextChanged += new System.EventHandler(this.cmbTeam_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Team :";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DarkRed;
            this.metroButton1.Location = new System.Drawing.Point(320, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(26, 26);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "X";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnOpenWaiver
            // 
            this.btnOpenWaiver.Location = new System.Drawing.Point(176, 462);
            this.btnOpenWaiver.Name = "btnOpenWaiver";
            this.btnOpenWaiver.Size = new System.Drawing.Size(108, 23);
            this.btnOpenWaiver.TabIndex = 14;
            this.btnOpenWaiver.Text = "Open Waiver File";
            this.btnOpenWaiver.UseSelectable = true;
            this.btnOpenWaiver.Click += new System.EventHandler(this.btnOpenWaiver_Click);
            // 
            // chbWaive
            // 
            this.chbWaive.AutoSize = true;
            this.chbWaive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chbWaive.Location = new System.Drawing.Point(76, 461);
            this.chbWaive.Name = "chbWaive";
            this.chbWaive.Size = new System.Drawing.Size(76, 24);
            this.chbWaive.TabIndex = 7;
            this.chbWaive.Text = "Waive";
            this.chbWaive.UseVisualStyleBackColor = true;
            this.chbWaive.CheckStateChanged += new System.EventHandler(this.chbWaive_CheckStateChanged);
            // 
            // txtLastName
            // 
            // 
            // 
            // 
            this.txtLastName.CustomButton.Image = null;
            this.txtLastName.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtLastName.CustomButton.Name = "";
            this.txtLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastName.CustomButton.TabIndex = 1;
            this.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastName.CustomButton.UseSelectable = true;
            this.txtLastName.CustomButton.Visible = false;
            this.txtLastName.Lines = new string[0];
            this.txtLastName.Location = new System.Drawing.Point(9, 302);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(328, 23);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLastName.UseSelectable = true;
            this.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name : ";
            // 
            // txtMiddleName
            // 
            // 
            // 
            // 
            this.txtMiddleName.CustomButton.Image = null;
            this.txtMiddleName.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtMiddleName.CustomButton.Name = "";
            this.txtMiddleName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMiddleName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMiddleName.CustomButton.TabIndex = 1;
            this.txtMiddleName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMiddleName.CustomButton.UseSelectable = true;
            this.txtMiddleName.CustomButton.Visible = false;
            this.txtMiddleName.Lines = new string[0];
            this.txtMiddleName.Location = new System.Drawing.Point(9, 241);
            this.txtMiddleName.MaxLength = 32767;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.PasswordChar = '\0';
            this.txtMiddleName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMiddleName.SelectedText = "";
            this.txtMiddleName.SelectionLength = 0;
            this.txtMiddleName.SelectionStart = 0;
            this.txtMiddleName.ShortcutsEnabled = true;
            this.txtMiddleName.Size = new System.Drawing.Size(328, 23);
            this.txtMiddleName.TabIndex = 3;
            this.txtMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiddleName.UseSelectable = true;
            this.txtMiddleName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMiddleName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Middle Name :";
            // 
            // txtLeader
            // 
            // 
            // 
            // 
            this.txtLeader.CustomButton.Image = null;
            this.txtLeader.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtLeader.CustomButton.Name = "";
            this.txtLeader.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLeader.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLeader.CustomButton.TabIndex = 1;
            this.txtLeader.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLeader.CustomButton.UseSelectable = true;
            this.txtLeader.CustomButton.Visible = false;
            this.txtLeader.Lines = new string[0];
            this.txtLeader.Location = new System.Drawing.Point(9, 424);
            this.txtLeader.MaxLength = 32767;
            this.txtLeader.Name = "txtLeader";
            this.txtLeader.PasswordChar = '\0';
            this.txtLeader.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLeader.SelectedText = "";
            this.txtLeader.SelectionLength = 0;
            this.txtLeader.SelectionStart = 0;
            this.txtLeader.ShortcutsEnabled = true;
            this.txtLeader.Size = new System.Drawing.Size(328, 23);
            this.txtLeader.TabIndex = 6;
            this.txtLeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLeader.UseSelectable = true;
            this.txtLeader.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLeader.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFirstName
            // 
            // 
            // 
            // 
            this.txtFirstName.CustomButton.Image = null;
            this.txtFirstName.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtFirstName.CustomButton.Name = "";
            this.txtFirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstName.CustomButton.TabIndex = 1;
            this.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstName.CustomButton.UseSelectable = true;
            this.txtFirstName.CustomButton.Visible = false;
            this.txtFirstName.Lines = new string[0];
            this.txtFirstName.Location = new System.Drawing.Point(9, 180);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.ShortcutsEnabled = true;
            this.txtFirstName.Size = new System.Drawing.Size(328, 23);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstName.UseSelectable = true;
            this.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtWorkdayID
            // 
            // 
            // 
            // 
            this.txtWorkdayID.CustomButton.Image = null;
            this.txtWorkdayID.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtWorkdayID.CustomButton.Name = "";
            this.txtWorkdayID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtWorkdayID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWorkdayID.CustomButton.TabIndex = 1;
            this.txtWorkdayID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWorkdayID.CustomButton.UseSelectable = true;
            this.txtWorkdayID.CustomButton.Visible = false;
            this.txtWorkdayID.Lines = new string[0];
            this.txtWorkdayID.Location = new System.Drawing.Point(9, 119);
            this.txtWorkdayID.MaxLength = 32767;
            this.txtWorkdayID.Name = "txtWorkdayID";
            this.txtWorkdayID.PasswordChar = '\0';
            this.txtWorkdayID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWorkdayID.SelectedText = "";
            this.txtWorkdayID.SelectionLength = 0;
            this.txtWorkdayID.SelectionStart = 0;
            this.txtWorkdayID.ShortcutsEnabled = true;
            this.txtWorkdayID.Size = new System.Drawing.Size(328, 23);
            this.txtWorkdayID.TabIndex = 1;
            this.txtWorkdayID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWorkdayID.UseSelectable = true;
            this.txtWorkdayID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWorkdayID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtWorkdayID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWorkdayID_KeyUp);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(11, 575);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(328, 75);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblTL
            // 
            this.lblTL.AutoSize = true;
            this.lblTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTL.Location = new System.Drawing.Point(109, 395);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(129, 20);
            this.lblTL.TabIndex = 5;
            this.lblTL.Text = "Team Leader : ";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.Location = new System.Drawing.Point(120, 151);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(106, 20);
            this.lblEmp.TabIndex = 3;
            this.lblEmp.Text = "First Name :";
            // 
            // lblWDID
            // 
            this.lblWDID.AutoSize = true;
            this.lblWDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWDID.Location = new System.Drawing.Point(115, 90);
            this.lblWDID.Name = "lblWDID";
            this.lblWDID.Size = new System.Drawing.Size(117, 20);
            this.lblWDID.TabIndex = 2;
            this.lblWDID.Text = "Workday ID : ";
            // 
            // pnlImage
            // 
            this.pnlImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Margin = new System.Windows.Forms.Padding(0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(757, 690);
            this.pnlImage.TabIndex = 5;
            this.pnlImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlImage_Paint);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 730);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Registration";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Registration_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.pnlReadOnlyTeam.ResumeLayout(false);
            this.pnlReadOnlyTeam.PerformLayout();
            this.pnlTeamWithCombo.ResumeLayout(false);
            this.pnlTeamWithCombo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtMiddleName;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtLeader;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private MetroFramework.Controls.MetroTextBox txtWorkdayID;
        private MetroFramework.Controls.MetroButton btnRegister;
        private System.Windows.Forms.Label lblTL;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblWDID;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.CheckBox chbWaive;
        private MetroFramework.Controls.MetroButton btnOpenWaiver;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtTeam;
        private System.Windows.Forms.Panel pnlReadOnlyTeam;
        private System.Windows.Forms.Panel pnlTeamWithCombo;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.Label label3;
    }
}