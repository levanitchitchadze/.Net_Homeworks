namespace HomeWork8
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MetroGridView = new MetroFramework.Controls.MetroGrid();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.BrowseB = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmpIdL = new MetroFramework.Controls.MetroLabel();
            this.NameL = new MetroFramework.Controls.MetroLabel();
            this.EmailL = new MetroFramework.Controls.MetroLabel();
            this.DOBL = new MetroFramework.Controls.MetroLabel();
            this.AddressL = new MetroFramework.Controls.MetroLabel();
            this.EmpIdTB = new MetroFramework.Controls.MetroTextBox();
            this.NameTB = new MetroFramework.Controls.MetroTextBox();
            this.EmailTB = new MetroFramework.Controls.MetroTextBox();
            this.DOBTB = new MetroFramework.Controls.MetroTextBox();
            this.AddressTB = new MetroFramework.Controls.MetroTextBox();
            this.AddB = new MetroFramework.Controls.MetroButton();
            this.EditB = new MetroFramework.Controls.MetroButton();
            this.DeleteB = new MetroFramework.Controls.MetroButton();
            this.CancelB = new MetroFramework.Controls.MetroButton();
            this.SaveB = new MetroFramework.Controls.MetroButton();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MetroGridView)).BeginInit();
            this.metroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MetroGridView
            // 
            this.MetroGridView.AllowUserToResizeRows = false;
            this.MetroGridView.AutoGenerateColumns = false;
            this.MetroGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MetroGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MetroGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MetroGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MetroGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MetroGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.MetroGridView.DataSource = this.employeeBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MetroGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.MetroGridView.EnableHeadersVisualStyles = false;
            this.MetroGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MetroGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MetroGridView.Location = new System.Drawing.Point(7, 84);
            this.MetroGridView.Name = "MetroGridView";
            this.MetroGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.MetroGridView.RowHeadersWidth = 51;
            this.MetroGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MetroGridView.RowTemplate.Height = 24;
            this.MetroGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MetroGridView.Size = new System.Drawing.Size(682, 672);
            this.MetroGridView.TabIndex = 0;
            this.MetroGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MetroGridView_CellClick);
            // 
            // metroPanel
            // 
            this.metroPanel.Controls.Add(this.AddressTB);
            this.metroPanel.Controls.Add(this.DOBTB);
            this.metroPanel.Controls.Add(this.EmailTB);
            this.metroPanel.Controls.Add(this.NameTB);
            this.metroPanel.Controls.Add(this.EmpIdTB);
            this.metroPanel.Controls.Add(this.AddressL);
            this.metroPanel.Controls.Add(this.DOBL);
            this.metroPanel.Controls.Add(this.EmailL);
            this.metroPanel.Controls.Add(this.NameL);
            this.metroPanel.Controls.Add(this.EmpIdL);
            this.metroPanel.Controls.Add(this.pictureBox1);
            this.metroPanel.Controls.Add(this.BrowseB);
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(695, 84);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(433, 577);
            this.metroPanel.TabIndex = 1;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // BrowseB
            // 
            this.BrowseB.Location = new System.Drawing.Point(73, 258);
            this.BrowseB.Name = "BrowseB";
            this.BrowseB.Size = new System.Drawing.Size(75, 23);
            this.BrowseB.TabIndex = 2;
            this.BrowseB.Text = "Browse";
            this.BrowseB.UseSelectable = true;
            this.BrowseB.Click += new System.EventHandler(this.BrowseB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(4, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 222);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // EmpIdL
            // 
            this.EmpIdL.AutoSize = true;
            this.EmpIdL.Location = new System.Drawing.Point(222, 27);
            this.EmpIdL.Name = "EmpIdL";
            this.EmpIdL.Size = new System.Drawing.Size(54, 20);
            this.EmpIdL.TabIndex = 4;
            this.EmpIdL.Text = "Emp ID";
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Location = new System.Drawing.Point(222, 70);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(47, 20);
            this.NameL.TabIndex = 4;
            this.NameL.Text = "Name";
            // 
            // EmailL
            // 
            this.EmailL.AutoSize = true;
            this.EmailL.Location = new System.Drawing.Point(222, 111);
            this.EmailL.Name = "EmailL";
            this.EmailL.Size = new System.Drawing.Size(42, 20);
            this.EmailL.TabIndex = 4;
            this.EmailL.Text = "Email";
            // 
            // DOBL
            // 
            this.DOBL.AutoSize = true;
            this.DOBL.Location = new System.Drawing.Point(222, 150);
            this.DOBL.Name = "DOBL";
            this.DOBL.Size = new System.Drawing.Size(38, 20);
            this.DOBL.TabIndex = 4;
            this.DOBL.Text = "DOB";
            // 
            // AddressL
            // 
            this.AddressL.AutoSize = true;
            this.AddressL.Location = new System.Drawing.Point(222, 189);
            this.AddressL.Name = "AddressL";
            this.AddressL.Size = new System.Drawing.Size(59, 20);
            this.AddressL.TabIndex = 4;
            this.AddressL.Text = "Address";
            // 
            // EmpIdTB
            // 
            // 
            // 
            // 
            this.EmpIdTB.CustomButton.Image = null;
            this.EmpIdTB.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.EmpIdTB.CustomButton.Name = "";
            this.EmpIdTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EmpIdTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EmpIdTB.CustomButton.TabIndex = 1;
            this.EmpIdTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EmpIdTB.CustomButton.UseSelectable = true;
            this.EmpIdTB.CustomButton.Visible = false;
            this.EmpIdTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmpID", true));
            this.EmpIdTB.Lines = new string[0];
            this.EmpIdTB.Location = new System.Drawing.Point(282, 27);
            this.EmpIdTB.MaxLength = 32767;
            this.EmpIdTB.Name = "EmpIdTB";
            this.EmpIdTB.PasswordChar = '\0';
            this.EmpIdTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmpIdTB.SelectedText = "";
            this.EmpIdTB.SelectionLength = 0;
            this.EmpIdTB.SelectionStart = 0;
            this.EmpIdTB.ShortcutsEnabled = true;
            this.EmpIdTB.Size = new System.Drawing.Size(142, 23);
            this.EmpIdTB.TabIndex = 5;
            this.EmpIdTB.UseSelectable = true;
            this.EmpIdTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmpIdTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NameTB
            // 
            // 
            // 
            // 
            this.NameTB.CustomButton.Image = null;
            this.NameTB.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.NameTB.CustomButton.Name = "";
            this.NameTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NameTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameTB.CustomButton.TabIndex = 1;
            this.NameTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameTB.CustomButton.UseSelectable = true;
            this.NameTB.CustomButton.Visible = false;
            this.NameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Name", true));
            this.NameTB.Lines = new string[0];
            this.NameTB.Location = new System.Drawing.Point(282, 67);
            this.NameTB.MaxLength = 32767;
            this.NameTB.Name = "NameTB";
            this.NameTB.PasswordChar = '\0';
            this.NameTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTB.SelectedText = "";
            this.NameTB.SelectionLength = 0;
            this.NameTB.SelectionStart = 0;
            this.NameTB.ShortcutsEnabled = true;
            this.NameTB.Size = new System.Drawing.Size(142, 23);
            this.NameTB.TabIndex = 5;
            this.NameTB.UseSelectable = true;
            this.NameTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EmailTB
            // 
            // 
            // 
            // 
            this.EmailTB.CustomButton.Image = null;
            this.EmailTB.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.EmailTB.CustomButton.Name = "";
            this.EmailTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EmailTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EmailTB.CustomButton.TabIndex = 1;
            this.EmailTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EmailTB.CustomButton.UseSelectable = true;
            this.EmailTB.CustomButton.Visible = false;
            this.EmailTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Email", true));
            this.EmailTB.Lines = new string[0];
            this.EmailTB.Location = new System.Drawing.Point(282, 107);
            this.EmailTB.MaxLength = 32767;
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.PasswordChar = '\0';
            this.EmailTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailTB.SelectedText = "";
            this.EmailTB.SelectionLength = 0;
            this.EmailTB.SelectionStart = 0;
            this.EmailTB.ShortcutsEnabled = true;
            this.EmailTB.Size = new System.Drawing.Size(142, 23);
            this.EmailTB.TabIndex = 5;
            this.EmailTB.UseSelectable = true;
            this.EmailTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmailTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DOBTB
            // 
            // 
            // 
            // 
            this.DOBTB.CustomButton.Image = null;
            this.DOBTB.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.DOBTB.CustomButton.Name = "";
            this.DOBTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DOBTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DOBTB.CustomButton.TabIndex = 1;
            this.DOBTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DOBTB.CustomButton.UseSelectable = true;
            this.DOBTB.CustomButton.Visible = false;
            this.DOBTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Dob", true));
            this.DOBTB.Lines = new string[0];
            this.DOBTB.Location = new System.Drawing.Point(282, 147);
            this.DOBTB.MaxLength = 32767;
            this.DOBTB.Name = "DOBTB";
            this.DOBTB.PasswordChar = '\0';
            this.DOBTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DOBTB.SelectedText = "";
            this.DOBTB.SelectionLength = 0;
            this.DOBTB.SelectionStart = 0;
            this.DOBTB.ShortcutsEnabled = true;
            this.DOBTB.Size = new System.Drawing.Size(142, 23);
            this.DOBTB.TabIndex = 5;
            this.DOBTB.UseSelectable = true;
            this.DOBTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DOBTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddressTB
            // 
            // 
            // 
            // 
            this.AddressTB.CustomButton.Image = null;
            this.AddressTB.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.AddressTB.CustomButton.Name = "";
            this.AddressTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AddressTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddressTB.CustomButton.TabIndex = 1;
            this.AddressTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddressTB.CustomButton.UseSelectable = true;
            this.AddressTB.CustomButton.Visible = false;
            this.AddressTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Address", true));
            this.AddressTB.Lines = new string[0];
            this.AddressTB.Location = new System.Drawing.Point(282, 187);
            this.AddressTB.MaxLength = 32767;
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.PasswordChar = '\0';
            this.AddressTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AddressTB.SelectedText = "";
            this.AddressTB.SelectionLength = 0;
            this.AddressTB.SelectionStart = 0;
            this.AddressTB.ShortcutsEnabled = true;
            this.AddressTB.Size = new System.Drawing.Size(142, 23);
            this.AddressTB.TabIndex = 5;
            this.AddressTB.UseSelectable = true;
            this.AddressTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AddressTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddB
            // 
            this.AddB.Location = new System.Drawing.Point(703, 667);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(75, 23);
            this.AddB.TabIndex = 2;
            this.AddB.Text = "Add";
            this.AddB.UseSelectable = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // EditB
            // 
            this.EditB.Location = new System.Drawing.Point(784, 667);
            this.EditB.Name = "EditB";
            this.EditB.Size = new System.Drawing.Size(75, 23);
            this.EditB.TabIndex = 2;
            this.EditB.Text = "Edit";
            this.EditB.UseSelectable = true;
            this.EditB.Click += new System.EventHandler(this.EditB_Click);
            // 
            // DeleteB
            // 
            this.DeleteB.Location = new System.Drawing.Point(865, 667);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(75, 23);
            this.DeleteB.TabIndex = 2;
            this.DeleteB.Text = "Delete";
            this.DeleteB.UseSelectable = true;
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // CancelB
            // 
            this.CancelB.Location = new System.Drawing.Point(946, 667);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.TabIndex = 2;
            this.CancelB.Text = "Cancel";
            this.CancelB.UseSelectable = true;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // SaveB
            // 
            this.SaveB.Location = new System.Drawing.Point(1027, 667);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(75, 23);
            this.SaveB.TabIndex = 2;
            this.SaveB.Text = "Save";
            this.SaveB.UseSelectable = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(HomeWork8.Employee);
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.empIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 761);
            this.Controls.Add(this.metroPanel);
            this.Controls.Add(this.MetroGridView);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.DeleteB);
            this.Controls.Add(this.EditB);
            this.Controls.Add(this.AddB);
            this.Name = "MainForm";
            this.Text = "Crud With Code First";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MetroGridView)).EndInit();
            this.metroPanel.ResumeLayout(false);
            this.metroPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid MetroGridView;
        private MetroFramework.Controls.MetroPanel metroPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton BrowseB;
        private MetroFramework.Controls.MetroTextBox AddressTB;
        private MetroFramework.Controls.MetroTextBox DOBTB;
        private MetroFramework.Controls.MetroTextBox EmailTB;
        private MetroFramework.Controls.MetroTextBox NameTB;
        private MetroFramework.Controls.MetroTextBox EmpIdTB;
        private MetroFramework.Controls.MetroLabel AddressL;
        private MetroFramework.Controls.MetroLabel DOBL;
        private MetroFramework.Controls.MetroLabel EmailL;
        private MetroFramework.Controls.MetroLabel NameL;
        private MetroFramework.Controls.MetroLabel EmpIdL;
        private MetroFramework.Controls.MetroButton AddB;
        private MetroFramework.Controls.MetroButton EditB;
        private MetroFramework.Controls.MetroButton DeleteB;
        private MetroFramework.Controls.MetroButton CancelB;
        private MetroFramework.Controls.MetroButton SaveB;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
    }
}

