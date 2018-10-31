namespace test
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TCMain = new MetroFramework.Controls.MetroTabControl();
            this.PGEmployee = new MetroFramework.Controls.MetroTabPage();
            this.TCEmp = new MetroFramework.Controls.MetroTabControl();
            this.PGList = new MetroFramework.Controls.MetroTabPage();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.GridEmployees = new MetroFramework.Controls.MetroGrid();
            this.PGBulk = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtTeamLeader = new MetroFramework.Controls.MetroTextBox();
            this.txtTeam = new MetroFramework.Controls.MetroTextBox();
            this.txtFullName = new MetroFramework.Controls.MetroTextBox();
            this.txtWorkdayID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnBulk = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.PGEvents = new MetroFramework.Controls.MetroTabPage();
            this.TCMain.SuspendLayout();
            this.PGEmployee.SuspendLayout();
            this.TCEmp.SuspendLayout();
            this.PGList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployees)).BeginInit();
            this.PGBulk.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCMain
            // 
            this.TCMain.Controls.Add(this.PGEmployee);
            this.TCMain.Controls.Add(this.PGEvents);
            this.TCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCMain.Location = new System.Drawing.Point(20, 60);
            this.TCMain.Name = "TCMain";
            this.TCMain.SelectedIndex = 0;
            this.TCMain.Size = new System.Drawing.Size(1326, 650);
            this.TCMain.TabIndex = 1;
            this.TCMain.UseSelectable = true;
            // 
            // PGEmployee
            // 
            this.PGEmployee.Controls.Add(this.TCEmp);
            this.PGEmployee.HorizontalScrollbarBarColor = true;
            this.PGEmployee.HorizontalScrollbarHighlightOnWheel = false;
            this.PGEmployee.HorizontalScrollbarSize = 10;
            this.PGEmployee.Location = new System.Drawing.Point(4, 38);
            this.PGEmployee.Name = "PGEmployee";
            this.PGEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.PGEmployee.Size = new System.Drawing.Size(1318, 608);
            this.PGEmployee.TabIndex = 0;
            this.PGEmployee.Text = "Employees";
            this.PGEmployee.VerticalScrollbarBarColor = true;
            this.PGEmployee.VerticalScrollbarHighlightOnWheel = false;
            this.PGEmployee.VerticalScrollbarSize = 10;
            // 
            // TCEmp
            // 
            this.TCEmp.Controls.Add(this.PGList);
            this.TCEmp.Controls.Add(this.PGBulk);
            this.TCEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCEmp.Location = new System.Drawing.Point(3, 3);
            this.TCEmp.Name = "TCEmp";
            this.TCEmp.SelectedIndex = 1;
            this.TCEmp.Size = new System.Drawing.Size(1312, 602);
            this.TCEmp.TabIndex = 1;
            this.TCEmp.UseSelectable = true;
            // 
            // PGList
            // 
            this.PGList.Controls.Add(this.btnRefresh);
            this.PGList.Controls.Add(this.GridEmployees);
            this.PGList.HorizontalScrollbarBarColor = true;
            this.PGList.HorizontalScrollbarHighlightOnWheel = false;
            this.PGList.HorizontalScrollbarSize = 10;
            this.PGList.Location = new System.Drawing.Point(4, 38);
            this.PGList.Name = "PGList";
            this.PGList.Padding = new System.Windows.Forms.Padding(3);
            this.PGList.Size = new System.Drawing.Size(1304, 560);
            this.PGList.TabIndex = 0;
            this.PGList.Text = "List";
            this.PGList.VerticalScrollbarBarColor = true;
            this.PGList.VerticalScrollbarHighlightOnWheel = false;
            this.PGList.VerticalScrollbarSize = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(0, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.Style = MetroFramework.MetroColorStyle.Green;
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh\r\n";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // GridEmployees
            // 
            this.GridEmployees.AllowUserToAddRows = false;
            this.GridEmployees.AllowUserToDeleteRows = false;
            this.GridEmployees.AllowUserToResizeRows = false;
            this.GridEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridEmployees.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridEmployees.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridEmployees.EnableHeadersVisualStyles = false;
            this.GridEmployees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridEmployees.Location = new System.Drawing.Point(3, 45);
            this.GridEmployees.Name = "GridEmployees";
            this.GridEmployees.ReadOnly = true;
            this.GridEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEmployees.Size = new System.Drawing.Size(1298, 512);
            this.GridEmployees.TabIndex = 2;
            // 
            // PGBulk
            // 
            this.PGBulk.Controls.Add(this.metroPanel2);
            this.PGBulk.Controls.Add(this.metroPanel1);
            this.PGBulk.HorizontalScrollbarBarColor = true;
            this.PGBulk.HorizontalScrollbarHighlightOnWheel = false;
            this.PGBulk.HorizontalScrollbarSize = 10;
            this.PGBulk.Location = new System.Drawing.Point(4, 38);
            this.PGBulk.Name = "PGBulk";
            this.PGBulk.Size = new System.Drawing.Size(1304, 560);
            this.PGBulk.TabIndex = 1;
            this.PGBulk.Text = "Bulk Insert";
            this.PGBulk.VerticalScrollbarBarColor = true;
            this.PGBulk.VerticalScrollbarHighlightOnWheel = false;
            this.PGBulk.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.btnSave);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.txtTeamLeader);
            this.metroPanel2.Controls.Add(this.txtTeam);
            this.metroPanel2.Controls.Add(this.txtFullName);
            this.metroPanel2.Controls.Add(this.txtWorkdayID);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(931, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Padding = new System.Windows.Forms.Padding(20);
            this.metroPanel2.Size = new System.Drawing.Size(373, 560);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(202, 505);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(18, 314);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(84, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Team Leader";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(18, 238);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(80, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Team Name";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(18, 160);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Full Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(18, 93);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Workday ID";
            // 
            // txtTeamLeader
            // 
            // 
            // 
            // 
            this.txtTeamLeader.CustomButton.Image = null;
            this.txtTeamLeader.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.txtTeamLeader.CustomButton.Name = "";
            this.txtTeamLeader.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTeamLeader.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTeamLeader.CustomButton.TabIndex = 1;
            this.txtTeamLeader.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTeamLeader.CustomButton.UseSelectable = true;
            this.txtTeamLeader.CustomButton.Visible = false;
            this.txtTeamLeader.Lines = new string[0];
            this.txtTeamLeader.Location = new System.Drawing.Point(18, 336);
            this.txtTeamLeader.MaxLength = 32767;
            this.txtTeamLeader.Name = "txtTeamLeader";
            this.txtTeamLeader.PasswordChar = '\0';
            this.txtTeamLeader.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTeamLeader.SelectedText = "";
            this.txtTeamLeader.SelectionLength = 0;
            this.txtTeamLeader.SelectionStart = 0;
            this.txtTeamLeader.ShortcutsEnabled = true;
            this.txtTeamLeader.Size = new System.Drawing.Size(340, 23);
            this.txtTeamLeader.TabIndex = 9;
            this.txtTeamLeader.UseSelectable = true;
            this.txtTeamLeader.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTeamLeader.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTeam
            // 
            // 
            // 
            // 
            this.txtTeam.CustomButton.Image = null;
            this.txtTeam.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.txtTeam.CustomButton.Name = "";
            this.txtTeam.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTeam.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTeam.CustomButton.TabIndex = 1;
            this.txtTeam.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTeam.CustomButton.UseSelectable = true;
            this.txtTeam.CustomButton.Visible = false;
            this.txtTeam.Lines = new string[0];
            this.txtTeam.Location = new System.Drawing.Point(18, 260);
            this.txtTeam.MaxLength = 32767;
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.PasswordChar = '\0';
            this.txtTeam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTeam.SelectedText = "";
            this.txtTeam.SelectionLength = 0;
            this.txtTeam.SelectionStart = 0;
            this.txtTeam.ShortcutsEnabled = true;
            this.txtTeam.Size = new System.Drawing.Size(340, 23);
            this.txtTeam.TabIndex = 8;
            this.txtTeam.UseSelectable = true;
            this.txtTeam.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTeam.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFullName
            // 
            // 
            // 
            // 
            this.txtFullName.CustomButton.Image = null;
            this.txtFullName.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.txtFullName.CustomButton.Name = "";
            this.txtFullName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFullName.CustomButton.TabIndex = 1;
            this.txtFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFullName.CustomButton.UseSelectable = true;
            this.txtFullName.CustomButton.Visible = false;
            this.txtFullName.Lines = new string[0];
            this.txtFullName.Location = new System.Drawing.Point(18, 182);
            this.txtFullName.MaxLength = 32767;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.ShortcutsEnabled = true;
            this.txtFullName.Size = new System.Drawing.Size(340, 23);
            this.txtFullName.TabIndex = 6;
            this.txtFullName.UseSelectable = true;
            this.txtFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtWorkdayID
            // 
            // 
            // 
            // 
            this.txtWorkdayID.CustomButton.Image = null;
            this.txtWorkdayID.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.txtWorkdayID.CustomButton.Name = "";
            this.txtWorkdayID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtWorkdayID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWorkdayID.CustomButton.TabIndex = 1;
            this.txtWorkdayID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWorkdayID.CustomButton.UseSelectable = true;
            this.txtWorkdayID.CustomButton.Visible = false;
            this.txtWorkdayID.Lines = new string[0];
            this.txtWorkdayID.Location = new System.Drawing.Point(18, 115);
            this.txtWorkdayID.MaxLength = 32767;
            this.txtWorkdayID.Name = "txtWorkdayID";
            this.txtWorkdayID.PasswordChar = '\0';
            this.txtWorkdayID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWorkdayID.SelectedText = "";
            this.txtWorkdayID.SelectionLength = 0;
            this.txtWorkdayID.SelectionStart = 0;
            this.txtWorkdayID.ShortcutsEnabled = true;
            this.txtWorkdayID.Size = new System.Drawing.Size(340, 23);
            this.txtWorkdayID.TabIndex = 5;
            this.txtWorkdayID.UseSelectable = true;
            this.txtWorkdayID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWorkdayID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(38, 43);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(239, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Manual Insertion of Employee";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btnBulk);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroTextBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.metroPanel1.Size = new System.Drawing.Size(925, 560);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnBulk
            // 
            this.btnBulk.Location = new System.Drawing.Point(744, 13);
            this.btnBulk.Name = "btnBulk";
            this.btnBulk.Size = new System.Drawing.Size(156, 35);
            this.btnBulk.TabIndex = 4;
            this.btnBulk.Text = "Bulk Insert";
            this.btnBulk.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(20, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(388, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Insert JSON string for bulk insertion of Employees";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(409, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(471, 471);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(20, 62);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(883, 476);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PGEvents
            // 
            this.PGEvents.HorizontalScrollbarBarColor = true;
            this.PGEvents.HorizontalScrollbarHighlightOnWheel = false;
            this.PGEvents.HorizontalScrollbarSize = 10;
            this.PGEvents.Location = new System.Drawing.Point(4, 38);
            this.PGEvents.Name = "PGEvents";
            this.PGEvents.Size = new System.Drawing.Size(1318, 608);
            this.PGEvents.TabIndex = 1;
            this.PGEvents.Text = "Events ";
            this.PGEvents.VerticalScrollbarBarColor = true;
            this.PGEvents.VerticalScrollbarHighlightOnWheel = false;
            this.PGEvents.VerticalScrollbarSize = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1366, 730);
            this.Controls.Add(this.TCMain);
            this.Name = "Main";
            this.Text = "Information Systems";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.TCMain.ResumeLayout(false);
            this.PGEmployee.ResumeLayout(false);
            this.TCEmp.ResumeLayout(false);
            this.PGList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployees)).EndInit();
            this.PGBulk.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl TCMain;
        private MetroFramework.Controls.MetroTabPage PGEmployee;
        private MetroFramework.Controls.MetroTabControl TCEmp;
        private MetroFramework.Controls.MetroTabPage PGList;
        private MetroFramework.Controls.MetroTabPage PGBulk;
        private MetroFramework.Controls.MetroTabPage PGEvents;
        private MetroFramework.Controls.MetroGrid GridEmployees;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton btnBulk;
        private MetroFramework.Controls.MetroTextBox txtTeamLeader;
        private MetroFramework.Controls.MetroTextBox txtTeam;
        private MetroFramework.Controls.MetroTextBox txtFullName;
        private MetroFramework.Controls.MetroTextBox txtWorkdayID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}

