namespace CovidMangementApp.UI.Admin
{
    partial class AdminManagment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            btnOpenAdd = new RJCodeAdvance.RJControls.RJButton();
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            btnGoBack = new Button();
            gridView = new DataGridView();
            coverPanel = new Panel();
            pnlInfoAdmin = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label6 = new Label();
            txtInfoUsername = new MaterialSkin.Controls.MaterialTextBox();
            label17 = new Label();
            txtInfoFullName = new MaterialSkin.Controls.MaterialTextBox();
            label18 = new Label();
            dpkInfoDob = new RJCodeAdvance.RJControls.RJDatePicker();
            label19 = new Label();
            panel3 = new Panel();
            rdbtnInfoOther = new RJCodeAdvance.RJControls.RJRadioButton();
            rdbtnInfoFeMale = new RJCodeAdvance.RJControls.RJRadioButton();
            rdbtnInfoMale = new RJCodeAdvance.RJControls.RJRadioButton();
            label20 = new Label();
            txtInfoPhone = new MaterialSkin.Controls.MaterialTextBox();
            label21 = new Label();
            txtInfoCmnd = new MaterialSkin.Controls.MaterialTextBox();
            label22 = new Label();
            cbxInfoCity = new MaterialSkin.Controls.MaterialComboBox();
            label23 = new Label();
            cbxInfoDistrict = new MaterialSkin.Controls.MaterialComboBox();
            label24 = new Label();
            cbxInfoWard = new MaterialSkin.Controls.MaterialComboBox();
            label25 = new Label();
            txtInfoAddress = new MaterialSkin.Controls.MaterialTextBox();
            label26 = new Label();
            txtInfoEmail = new MaterialSkin.Controls.MaterialTextBox();
            label32 = new Label();
            cbxInfoNationality = new MaterialSkin.Controls.MaterialComboBox();
            label33 = new Label();
            cbxInfoEthnic = new MaterialSkin.Controls.MaterialComboBox();
            label34 = new Label();
            cbxInfoReligion = new MaterialSkin.Controls.MaterialComboBox();
            label35 = new Label();
            cbxInfoJob = new MaterialSkin.Controls.MaterialComboBox();
            btnUpdate = new RJCodeAdvance.RJControls.RJButton();
            label38 = new Label();
            pnlAddAdmin = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label3 = new Label();
            txtAddUsername = new MaterialSkin.Controls.MaterialTextBox();
            label4 = new Label();
            txtAddPassword = new MaterialSkin.Controls.MaterialTextBox();
            label8 = new Label();
            txtAddFullName = new MaterialSkin.Controls.MaterialTextBox();
            label5 = new Label();
            dpkAddDob = new RJCodeAdvance.RJControls.RJDatePicker();
            lblTest = new Label();
            panel1 = new Panel();
            rdbtnAddOther = new RJCodeAdvance.RJControls.RJRadioButton();
            rdbtnAddFeMale = new RJCodeAdvance.RJControls.RJRadioButton();
            rdbtnAddMale = new RJCodeAdvance.RJControls.RJRadioButton();
            label9 = new Label();
            txtAddPhone = new MaterialSkin.Controls.MaterialTextBox();
            label10 = new Label();
            txtAddCmnd = new MaterialSkin.Controls.MaterialTextBox();
            label12 = new Label();
            cbxAddCity = new MaterialSkin.Controls.MaterialComboBox();
            label13 = new Label();
            cbxAddDistrict = new MaterialSkin.Controls.MaterialComboBox();
            label14 = new Label();
            cbxAddWard = new MaterialSkin.Controls.MaterialComboBox();
            label15 = new Label();
            txtAddAddress = new MaterialSkin.Controls.MaterialTextBox();
            label7 = new Label();
            txtAddEmail = new MaterialSkin.Controls.MaterialTextBox();
            label27 = new Label();
            cbxAddNationality = new MaterialSkin.Controls.MaterialComboBox();
            label28 = new Label();
            cbxAddEthnic = new MaterialSkin.Controls.MaterialComboBox();
            label29 = new Label();
            cbxAddReligion = new MaterialSkin.Controls.MaterialComboBox();
            label30 = new Label();
            cbxAddJob = new MaterialSkin.Controls.MaterialComboBox();
            label11 = new Label();
            txtAddQuestion = new MaterialSkin.Controls.MaterialTextBox();
            label31 = new Label();
            txtAddAnswer = new MaterialSkin.Controls.MaterialTextBox();
            btnAdd = new RJCodeAdvance.RJControls.RJButton();
            label2 = new Label();
            upbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            coverPanel.SuspendLayout();
            pnlInfoAdmin.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            pnlAddAdmin.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkViolet;
            label1.Location = new Point(223, 40);
            label1.Name = "label1";
            label1.Size = new Size(505, 46);
            label1.TabIndex = 34;
            label1.Text = "QUẢN LÍ QUẢN TRỊ VIÊN";
            // 
            // txtSearch
            // 
            txtSearch.AnimateReadOnly = false;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Depth = 0;
            txtSearch.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearch.Hint = "Nhập thông tin tìm kiếm";
            txtSearch.LeadingIcon = Properties.Resources.magnifier;
            txtSearch.Location = new Point(0, 102);
            txtSearch.MaxLength = 50;
            txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(625, 50);
            txtSearch.TabIndex = 35;
            txtSearch.Text = "";
            txtSearch.TrailingIcon = null;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnOpenAdd
            // 
            btnOpenAdd.BackColor = Color.ForestGreen;
            btnOpenAdd.BackgroundColor = Color.ForestGreen;
            btnOpenAdd.BorderColor = Color.PaleVioletRed;
            btnOpenAdd.BorderRadius = 20;
            btnOpenAdd.BorderSize = 0;
            btnOpenAdd.FlatAppearance.BorderSize = 0;
            btnOpenAdd.FlatStyle = FlatStyle.Flat;
            btnOpenAdd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpenAdd.ForeColor = Color.White;
            btnOpenAdd.Location = new Point(625, 102);
            btnOpenAdd.Name = "btnOpenAdd";
            btnOpenAdd.Size = new Size(272, 50);
            btnOpenAdd.TabIndex = 37;
            btnOpenAdd.Text = "Thêm quản trị viên";
            btnOpenAdd.TextColor = Color.White;
            btnOpenAdd.UseVisualStyleBackColor = false;
            btnOpenAdd.Click += btnOpenAdd_Click;
            // 
            // upbar
            // 
            upbar.BackColor = Color.DarkSlateGray;
            upbar.Controls.Add(btnMinimize);
            upbar.Controls.Add(btnClose);
            upbar.Location = new Point(0, 0);
            upbar.Name = "upbar";
            upbar.Size = new Size(900, 30);
            upbar.TabIndex = 41;
            upbar.MouseDown += upbar_MouseDown;
            upbar.MouseMove += upbar_MouseMove;
            // 
            // btnMinimize
            // 
            btnMinimize.BackgroundImage = Properties.Resources.minimize;
            btnMinimize.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(848, 5);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(20, 20);
            btnMinimize.TabIndex = 18;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(875, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.TabIndex = 16;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.Transparent;
            btnGoBack.BackgroundImage = Properties.Resources.left_arrow;
            btnGoBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnGoBack.FlatAppearance.BorderSize = 0;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Location = new Point(4, 32);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(35, 35);
            btnGoBack.TabIndex = 40;
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // gridView
            // 
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.AllowUserToResizeColumns = false;
            gridView.AllowUserToResizeRows = false;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.BackgroundColor = Color.White;
            gridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            gridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.ForestGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.EnableHeadersVisualStyles = false;
            gridView.Location = new Point(12, 163);
            gridView.Name = "gridView";
            gridView.ReadOnly = true;
            gridView.RowHeadersWidth = 51;
            gridView.RowTemplate.DefaultCellStyle.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            gridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(198, 224, 180);
            gridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            gridView.RowTemplate.Height = 29;
            gridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gridView.ShowCellErrors = false;
            gridView.ShowCellToolTips = false;
            gridView.ShowEditingIcon = false;
            gridView.ShowRowErrors = false;
            gridView.Size = new Size(876, 465);
            gridView.TabIndex = 42;
            gridView.CellClick += gridView_CellClick;
            // 
            // coverPanel
            // 
            coverPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            coverPanel.Controls.Add(pnlInfoAdmin);
            coverPanel.Controls.Add(pnlAddAdmin);
            coverPanel.ForeColor = Color.FromArgb(100, 0, 0);
            coverPanel.Location = new Point(0, 89);
            coverPanel.Name = "coverPanel";
            coverPanel.Size = new Size(900, 551);
            coverPanel.TabIndex = 43;
            coverPanel.Visible = false;
            coverPanel.Click += coverPanel_Click;
            // 
            // pnlInfoAdmin
            // 
            pnlInfoAdmin.BackColor = Color.White;
            pnlInfoAdmin.Controls.Add(flowLayoutPanel1);
            pnlInfoAdmin.Controls.Add(label38);
            pnlInfoAdmin.Location = new Point(230, 51);
            pnlInfoAdmin.Name = "pnlInfoAdmin";
            pnlInfoAdmin.Size = new Size(440, 449);
            pnlInfoAdmin.TabIndex = 50;
            pnlInfoAdmin.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(txtInfoUsername);
            flowLayoutPanel1.Controls.Add(label17);
            flowLayoutPanel1.Controls.Add(txtInfoFullName);
            flowLayoutPanel1.Controls.Add(label18);
            flowLayoutPanel1.Controls.Add(dpkInfoDob);
            flowLayoutPanel1.Controls.Add(label19);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(label20);
            flowLayoutPanel1.Controls.Add(txtInfoPhone);
            flowLayoutPanel1.Controls.Add(label21);
            flowLayoutPanel1.Controls.Add(txtInfoCmnd);
            flowLayoutPanel1.Controls.Add(label22);
            flowLayoutPanel1.Controls.Add(cbxInfoCity);
            flowLayoutPanel1.Controls.Add(label23);
            flowLayoutPanel1.Controls.Add(cbxInfoDistrict);
            flowLayoutPanel1.Controls.Add(label24);
            flowLayoutPanel1.Controls.Add(cbxInfoWard);
            flowLayoutPanel1.Controls.Add(label25);
            flowLayoutPanel1.Controls.Add(txtInfoAddress);
            flowLayoutPanel1.Controls.Add(label26);
            flowLayoutPanel1.Controls.Add(txtInfoEmail);
            flowLayoutPanel1.Controls.Add(label32);
            flowLayoutPanel1.Controls.Add(cbxInfoNationality);
            flowLayoutPanel1.Controls.Add(label33);
            flowLayoutPanel1.Controls.Add(cbxInfoEthnic);
            flowLayoutPanel1.Controls.Add(label34);
            flowLayoutPanel1.Controls.Add(cbxInfoReligion);
            flowLayoutPanel1.Controls.Add(label35);
            flowLayoutPanel1.Controls.Add(cbxInfoJob);
            flowLayoutPanel1.Controls.Add(btnUpdate);
            flowLayoutPanel1.Location = new Point(7, 42);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(427, 394);
            flowLayoutPanel1.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(0, 8);
            label6.Margin = new Padding(0, 8, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(138, 20);
            label6.TabIndex = 23;
            label6.Text = "Tên đăng nhập:";
            // 
            // txtInfoUsername
            // 
            txtInfoUsername.AnimateReadOnly = false;
            txtInfoUsername.BackColor = Color.White;
            txtInfoUsername.BorderStyle = BorderStyle.None;
            txtInfoUsername.Depth = 0;
            txtInfoUsername.Enabled = false;
            txtInfoUsername.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInfoUsername.LeadingIcon = null;
            txtInfoUsername.Location = new Point(3, 33);
            txtInfoUsername.Margin = new Padding(3, 5, 3, 0);
            txtInfoUsername.MaxLength = 50;
            txtInfoUsername.MouseState = MaterialSkin.MouseState.OUT;
            txtInfoUsername.Multiline = false;
            txtInfoUsername.Name = "txtInfoUsername";
            txtInfoUsername.Size = new Size(400, 50);
            txtInfoUsername.TabIndex = 39;
            txtInfoUsername.Text = "";
            txtInfoUsername.TrailingIcon = null;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(0, 91);
            label17.Margin = new Padding(0, 8, 0, 0);
            label17.Name = "label17";
            label17.Size = new Size(106, 20);
            label17.TabIndex = 58;
            label17.Text = "Họ và tên (*)";
            // 
            // txtInfoFullName
            // 
            txtInfoFullName.AnimateReadOnly = false;
            txtInfoFullName.BackColor = Color.White;
            txtInfoFullName.BorderStyle = BorderStyle.None;
            txtInfoFullName.Depth = 0;
            txtInfoFullName.Enabled = false;
            txtInfoFullName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInfoFullName.LeadingIcon = null;
            txtInfoFullName.Location = new Point(3, 114);
            txtInfoFullName.MaxLength = 50;
            txtInfoFullName.MouseState = MaterialSkin.MouseState.OUT;
            txtInfoFullName.Multiline = false;
            txtInfoFullName.Name = "txtInfoFullName";
            txtInfoFullName.Size = new Size(400, 50);
            txtInfoFullName.TabIndex = 46;
            txtInfoFullName.Text = "";
            txtInfoFullName.TrailingIcon = null;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(0, 175);
            label18.Margin = new Padding(0, 8, 0, 0);
            label18.Name = "label18";
            label18.Size = new Size(202, 20);
            label18.TabIndex = 57;
            label18.Text = "Ngày/tháng/năm sinh (*)";
            // 
            // dpkInfoDob
            // 
            dpkInfoDob.BorderColor = Color.Black;
            dpkInfoDob.BorderSize = 0;
            dpkInfoDob.CalendarMonthBackground = Color.White;
            dpkInfoDob.CustomFormat = "dd/MM/yyyy";
            dpkInfoDob.Enabled = false;
            dpkInfoDob.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpkInfoDob.Format = DateTimePickerFormat.Custom;
            dpkInfoDob.Location = new Point(3, 200);
            dpkInfoDob.Margin = new Padding(3, 5, 3, 0);
            dpkInfoDob.MinimumSize = new Size(0, 50);
            dpkInfoDob.Name = "dpkInfoDob";
            dpkInfoDob.Size = new Size(400, 50);
            dpkInfoDob.SkinColor = Color.WhiteSmoke;
            dpkInfoDob.TabIndex = 56;
            dpkInfoDob.TextColor = Color.DimGray;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(0, 258);
            label19.Margin = new Padding(0, 8, 0, 0);
            label19.Name = "label19";
            label19.Size = new Size(100, 20);
            label19.TabIndex = 47;
            label19.Text = "Giới tính (*)";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(rdbtnInfoOther);
            panel3.Controls.Add(rdbtnInfoFeMale);
            panel3.Controls.Add(rdbtnInfoMale);
            panel3.Location = new Point(3, 281);
            panel3.Name = "panel3";
            panel3.Size = new Size(403, 33);
            panel3.TabIndex = 48;
            // 
            // rdbtnInfoOther
            // 
            rdbtnInfoOther.AutoSize = true;
            rdbtnInfoOther.CheckedColor = Color.MediumSlateBlue;
            rdbtnInfoOther.Enabled = false;
            rdbtnInfoOther.Location = new Point(251, 6);
            rdbtnInfoOther.MinimumSize = new Size(0, 21);
            rdbtnInfoOther.Name = "rdbtnInfoOther";
            rdbtnInfoOther.Padding = new Padding(10, 0, 0, 0);
            rdbtnInfoOther.Size = new Size(73, 22);
            rdbtnInfoOther.TabIndex = 2;
            rdbtnInfoOther.TabStop = true;
            rdbtnInfoOther.Text = "Khac";
            rdbtnInfoOther.UnCheckedColor = Color.Gray;
            rdbtnInfoOther.UseVisualStyleBackColor = true;
            // 
            // rdbtnInfoFeMale
            // 
            rdbtnInfoFeMale.AutoSize = true;
            rdbtnInfoFeMale.CheckedColor = Color.MediumSlateBlue;
            rdbtnInfoFeMale.Enabled = false;
            rdbtnInfoFeMale.Location = new Point(155, 6);
            rdbtnInfoFeMale.MinimumSize = new Size(0, 21);
            rdbtnInfoFeMale.Name = "rdbtnInfoFeMale";
            rdbtnInfoFeMale.Padding = new Padding(10, 0, 0, 0);
            rdbtnInfoFeMale.Size = new Size(58, 22);
            rdbtnInfoFeMale.TabIndex = 1;
            rdbtnInfoFeMale.TabStop = true;
            rdbtnInfoFeMale.Text = "Nu";
            rdbtnInfoFeMale.UnCheckedColor = Color.Gray;
            rdbtnInfoFeMale.UseVisualStyleBackColor = true;
            // 
            // rdbtnInfoMale
            // 
            rdbtnInfoMale.AutoSize = true;
            rdbtnInfoMale.CheckedColor = Color.MediumSlateBlue;
            rdbtnInfoMale.Enabled = false;
            rdbtnInfoMale.Location = new Point(43, 6);
            rdbtnInfoMale.MinimumSize = new Size(0, 21);
            rdbtnInfoMale.Name = "rdbtnInfoMale";
            rdbtnInfoMale.Padding = new Padding(10, 0, 0, 0);
            rdbtnInfoMale.Size = new Size(71, 22);
            rdbtnInfoMale.TabIndex = 0;
            rdbtnInfoMale.TabStop = true;
            rdbtnInfoMale.Text = "Nam";
            rdbtnInfoMale.UnCheckedColor = Color.Gray;
            rdbtnInfoMale.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(0, 325);
            label20.Margin = new Padding(0, 8, 0, 0);
            label20.Name = "label20";
            label20.Size = new Size(136, 20);
            label20.TabIndex = 59;
            label20.Text = "Số điện thoại (*)";
            // 
            // txtInfoPhone
            // 
            txtInfoPhone.AnimateReadOnly = false;
            txtInfoPhone.BorderStyle = BorderStyle.None;
            txtInfoPhone.Depth = 0;
            txtInfoPhone.Enabled = false;
            txtInfoPhone.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInfoPhone.LeadingIcon = null;
            txtInfoPhone.Location = new Point(3, 348);
            txtInfoPhone.MaxLength = 50;
            txtInfoPhone.MouseState = MaterialSkin.MouseState.OUT;
            txtInfoPhone.Multiline = false;
            txtInfoPhone.Name = "txtInfoPhone";
            txtInfoPhone.Size = new Size(400, 50);
            txtInfoPhone.TabIndex = 49;
            txtInfoPhone.Text = "";
            txtInfoPhone.TrailingIcon = null;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(0, 409);
            label21.Margin = new Padding(0, 8, 0, 0);
            label21.Name = "label21";
            label21.Size = new Size(231, 20);
            label21.TabIndex = 60;
            label21.Text = "Số Hộ chiếu/CMND/CCCD (*)";
            // 
            // txtInfoCmnd
            // 
            txtInfoCmnd.AnimateReadOnly = false;
            txtInfoCmnd.BorderStyle = BorderStyle.None;
            txtInfoCmnd.Depth = 0;
            txtInfoCmnd.Enabled = false;
            txtInfoCmnd.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInfoCmnd.LeadingIcon = null;
            txtInfoCmnd.Location = new Point(3, 432);
            txtInfoCmnd.MaxLength = 50;
            txtInfoCmnd.MouseState = MaterialSkin.MouseState.OUT;
            txtInfoCmnd.Multiline = false;
            txtInfoCmnd.Name = "txtInfoCmnd";
            txtInfoCmnd.Size = new Size(400, 50);
            txtInfoCmnd.TabIndex = 50;
            txtInfoCmnd.Text = "";
            txtInfoCmnd.TrailingIcon = null;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(0, 493);
            label22.Margin = new Padding(0, 8, 0, 0);
            label22.Name = "label22";
            label22.Size = new Size(159, 20);
            label22.TabIndex = 62;
            label22.Text = "Tỉnh/Thành phố (*)";
            // 
            // cbxInfoCity
            // 
            cbxInfoCity.AutoResize = false;
            cbxInfoCity.BackColor = Color.FromArgb(255, 255, 255);
            cbxInfoCity.Depth = 0;
            cbxInfoCity.DrawMode = DrawMode.OwnerDrawVariable;
            cbxInfoCity.DropDownHeight = 174;
            cbxInfoCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxInfoCity.DropDownWidth = 121;
            cbxInfoCity.Enabled = false;
            cbxInfoCity.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxInfoCity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxInfoCity.FormattingEnabled = true;
            cbxInfoCity.IntegralHeight = false;
            cbxInfoCity.ItemHeight = 43;
            cbxInfoCity.Location = new Point(3, 516);
            cbxInfoCity.MaxDropDownItems = 4;
            cbxInfoCity.MouseState = MaterialSkin.MouseState.OUT;
            cbxInfoCity.Name = "cbxInfoCity";
            cbxInfoCity.Size = new Size(400, 49);
            cbxInfoCity.StartIndex = 0;
            cbxInfoCity.TabIndex = 52;
            cbxInfoCity.SelectedIndexChanged += cbxInfoCity_SelectedIndexChanged;
            cbxInfoCity.MouseWheel += cbx_MouseWheel;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(0, 576);
            label23.Margin = new Padding(0, 8, 0, 0);
            label23.Name = "label23";
            label23.Size = new Size(130, 20);
            label23.TabIndex = 63;
            label23.Text = "Quận/Huyện (*)";
            // 
            // cbxInfoDistrict
            // 
            cbxInfoDistrict.AutoResize = false;
            cbxInfoDistrict.BackColor = Color.FromArgb(255, 255, 255);
            cbxInfoDistrict.Depth = 0;
            cbxInfoDistrict.DrawMode = DrawMode.OwnerDrawVariable;
            cbxInfoDistrict.DropDownHeight = 174;
            cbxInfoDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxInfoDistrict.DropDownWidth = 121;
            cbxInfoDistrict.Enabled = false;
            cbxInfoDistrict.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxInfoDistrict.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxInfoDistrict.FormattingEnabled = true;
            cbxInfoDistrict.IntegralHeight = false;
            cbxInfoDistrict.ItemHeight = 43;
            cbxInfoDistrict.Location = new Point(3, 599);
            cbxInfoDistrict.MaxDropDownItems = 4;
            cbxInfoDistrict.MouseState = MaterialSkin.MouseState.OUT;
            cbxInfoDistrict.Name = "cbxInfoDistrict";
            cbxInfoDistrict.Size = new Size(400, 49);
            cbxInfoDistrict.StartIndex = 0;
            cbxInfoDistrict.TabIndex = 53;
            cbxInfoDistrict.SelectedIndexChanged += cbxInfoDistrict_SelectedIndexChanged;
            cbxInfoDistrict.MouseWheel += cbx_MouseWheel;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(0, 659);
            label24.Margin = new Padding(0, 8, 0, 0);
            label24.Name = "label24";
            label24.Size = new Size(120, 20);
            label24.TabIndex = 64;
            label24.Text = "Phường/Xã (*)";
            // 
            // cbxInfoWard
            // 
            cbxInfoWard.AutoResize = false;
            cbxInfoWard.BackColor = Color.FromArgb(255, 255, 255);
            cbxInfoWard.Depth = 0;
            cbxInfoWard.DrawMode = DrawMode.OwnerDrawVariable;
            cbxInfoWard.DropDownHeight = 174;
            cbxInfoWard.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxInfoWard.DropDownWidth = 121;
            cbxInfoWard.Enabled = false;
            cbxInfoWard.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxInfoWard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxInfoWard.FormattingEnabled = true;
            cbxInfoWard.IntegralHeight = false;
            cbxInfoWard.ItemHeight = 43;
            cbxInfoWard.Location = new Point(3, 682);
            cbxInfoWard.MaxDropDownItems = 4;
            cbxInfoWard.MouseState = MaterialSkin.MouseState.OUT;
            cbxInfoWard.Name = "cbxInfoWard";
            cbxInfoWard.Size = new Size(400, 49);
            cbxInfoWard.StartIndex = 0;
            cbxInfoWard.TabIndex = 54;
            cbxInfoWard.MouseWheel += cbx_MouseWheel;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(0, 742);
            label25.Margin = new Padding(0, 8, 0, 0);
            label25.Name = "label25";
            label25.Size = new Size(153, 20);
            label25.TabIndex = 65;
            label25.Text = "Thôn/Xóm/Nhà (*)";
            // 
            // txtInfoAddress
            // 
            txtInfoAddress.AnimateReadOnly = false;
            txtInfoAddress.BorderStyle = BorderStyle.None;
            txtInfoAddress.Depth = 0;
            txtInfoAddress.Enabled = false;
            txtInfoAddress.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInfoAddress.LeadingIcon = null;
            txtInfoAddress.Location = new Point(3, 765);
            txtInfoAddress.MaxLength = 50;
            txtInfoAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtInfoAddress.Multiline = false;
            txtInfoAddress.Name = "txtInfoAddress";
            txtInfoAddress.Size = new Size(400, 50);
            txtInfoAddress.TabIndex = 55;
            txtInfoAddress.Text = "";
            txtInfoAddress.TrailingIcon = null;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = Color.Black;
            label26.Location = new Point(0, 826);
            label26.Margin = new Padding(0, 8, 0, 0);
            label26.Name = "label26";
            label26.Size = new Size(77, 20);
            label26.TabIndex = 67;
            label26.Text = "Email (*)";
            // 
            // txtInfoEmail
            // 
            txtInfoEmail.AnimateReadOnly = false;
            txtInfoEmail.BorderStyle = BorderStyle.None;
            txtInfoEmail.Depth = 0;
            txtInfoEmail.Enabled = false;
            txtInfoEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInfoEmail.LeadingIcon = null;
            txtInfoEmail.Location = new Point(3, 849);
            txtInfoEmail.MaxLength = 50;
            txtInfoEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtInfoEmail.Multiline = false;
            txtInfoEmail.Name = "txtInfoEmail";
            txtInfoEmail.Size = new Size(400, 50);
            txtInfoEmail.TabIndex = 68;
            txtInfoEmail.Text = "";
            txtInfoEmail.TrailingIcon = null;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BackColor = Color.Transparent;
            label32.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label32.ForeColor = Color.Black;
            label32.Location = new Point(0, 910);
            label32.Margin = new Padding(0, 8, 0, 0);
            label32.Name = "label32";
            label32.Size = new Size(108, 20);
            label32.TabIndex = 73;
            label32.Text = "Quốc tịch (*)";
            // 
            // cbxInfoNationality
            // 
            cbxInfoNationality.AutoResize = false;
            cbxInfoNationality.BackColor = Color.FromArgb(255, 255, 255);
            cbxInfoNationality.Depth = 0;
            cbxInfoNationality.DrawMode = DrawMode.OwnerDrawVariable;
            cbxInfoNationality.DropDownHeight = 174;
            cbxInfoNationality.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxInfoNationality.DropDownWidth = 121;
            cbxInfoNationality.Enabled = false;
            cbxInfoNationality.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxInfoNationality.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxInfoNationality.FormattingEnabled = true;
            cbxInfoNationality.IntegralHeight = false;
            cbxInfoNationality.ItemHeight = 43;
            cbxInfoNationality.Location = new Point(3, 933);
            cbxInfoNationality.MaxDropDownItems = 4;
            cbxInfoNationality.MouseState = MaterialSkin.MouseState.OUT;
            cbxInfoNationality.Name = "cbxInfoNationality";
            cbxInfoNationality.Size = new Size(400, 49);
            cbxInfoNationality.StartIndex = 0;
            cbxInfoNationality.TabIndex = 69;
            cbxInfoNationality.MouseWheel += cbx_MouseWheel;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BackColor = Color.Transparent;
            label33.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label33.ForeColor = Color.Black;
            label33.Location = new Point(0, 993);
            label33.Margin = new Padding(0, 8, 0, 0);
            label33.Name = "label33";
            label33.Size = new Size(92, 20);
            label33.TabIndex = 74;
            label33.Text = "Dân tộc (*)";
            // 
            // cbxInfoEthnic
            // 
            cbxInfoEthnic.AutoResize = false;
            cbxInfoEthnic.BackColor = Color.FromArgb(255, 255, 255);
            cbxInfoEthnic.Depth = 0;
            cbxInfoEthnic.DrawMode = DrawMode.OwnerDrawVariable;
            cbxInfoEthnic.DropDownHeight = 174;
            cbxInfoEthnic.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxInfoEthnic.DropDownWidth = 121;
            cbxInfoEthnic.Enabled = false;
            cbxInfoEthnic.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxInfoEthnic.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxInfoEthnic.FormattingEnabled = true;
            cbxInfoEthnic.IntegralHeight = false;
            cbxInfoEthnic.ItemHeight = 43;
            cbxInfoEthnic.Location = new Point(3, 1016);
            cbxInfoEthnic.MaxDropDownItems = 4;
            cbxInfoEthnic.MouseState = MaterialSkin.MouseState.OUT;
            cbxInfoEthnic.Name = "cbxInfoEthnic";
            cbxInfoEthnic.Size = new Size(400, 49);
            cbxInfoEthnic.StartIndex = 0;
            cbxInfoEthnic.TabIndex = 70;
            cbxInfoEthnic.MouseWheel += cbx_MouseWheel;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = Color.Transparent;
            label34.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label34.ForeColor = Color.Black;
            label34.Location = new Point(0, 1076);
            label34.Margin = new Padding(0, 8, 0, 0);
            label34.Name = "label34";
            label34.Size = new Size(100, 20);
            label34.TabIndex = 75;
            label34.Text = "Tôn giáo (*)";
            // 
            // cbxInfoReligion
            // 
            cbxInfoReligion.AutoResize = false;
            cbxInfoReligion.BackColor = Color.FromArgb(255, 255, 255);
            cbxInfoReligion.Depth = 0;
            cbxInfoReligion.DrawMode = DrawMode.OwnerDrawVariable;
            cbxInfoReligion.DropDownHeight = 174;
            cbxInfoReligion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxInfoReligion.DropDownWidth = 121;
            cbxInfoReligion.Enabled = false;
            cbxInfoReligion.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxInfoReligion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxInfoReligion.FormattingEnabled = true;
            cbxInfoReligion.IntegralHeight = false;
            cbxInfoReligion.ItemHeight = 43;
            cbxInfoReligion.Location = new Point(3, 1099);
            cbxInfoReligion.MaxDropDownItems = 4;
            cbxInfoReligion.MouseState = MaterialSkin.MouseState.OUT;
            cbxInfoReligion.Name = "cbxInfoReligion";
            cbxInfoReligion.Size = new Size(400, 49);
            cbxInfoReligion.StartIndex = 0;
            cbxInfoReligion.TabIndex = 71;
            cbxInfoReligion.MouseWheel += cbx_MouseWheel;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BackColor = Color.Transparent;
            label35.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label35.ForeColor = Color.Black;
            label35.Location = new Point(0, 1159);
            label35.Margin = new Padding(0, 8, 0, 0);
            label35.Name = "label35";
            label35.Size = new Size(132, 20);
            label35.TabIndex = 76;
            label35.Text = "Nghề nghiệp (*)";
            // 
            // cbxInfoJob
            // 
            cbxInfoJob.AutoResize = false;
            cbxInfoJob.BackColor = Color.FromArgb(255, 255, 255);
            cbxInfoJob.Depth = 0;
            cbxInfoJob.DrawMode = DrawMode.OwnerDrawVariable;
            cbxInfoJob.DropDownHeight = 174;
            cbxInfoJob.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxInfoJob.DropDownWidth = 121;
            cbxInfoJob.Enabled = false;
            cbxInfoJob.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxInfoJob.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxInfoJob.FormattingEnabled = true;
            cbxInfoJob.IntegralHeight = false;
            cbxInfoJob.ItemHeight = 43;
            cbxInfoJob.Location = new Point(3, 1182);
            cbxInfoJob.MaxDropDownItems = 4;
            cbxInfoJob.MouseState = MaterialSkin.MouseState.OUT;
            cbxInfoJob.Name = "cbxInfoJob";
            cbxInfoJob.Size = new Size(400, 49);
            cbxInfoJob.StartIndex = 0;
            cbxInfoJob.TabIndex = 72;
            cbxInfoJob.MouseWheel += cbx_MouseWheel;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Blue;
            btnUpdate.BackgroundColor = Color.Blue;
            btnUpdate.BorderColor = Color.PaleVioletRed;
            btnUpdate.BorderRadius = 20;
            btnUpdate.BorderSize = 0;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(95, 1237);
            btnUpdate.Margin = new Padding(95, 3, 3, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(220, 38);
            btnUpdate.TabIndex = 66;
            btnUpdate.Text = "Chỉnh sửa thông tin";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.BackColor = Color.Transparent;
            label38.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label38.ForeColor = Color.Blue;
            label38.Location = new Point(45, 5);
            label38.Name = "label38";
            label38.Size = new Size(351, 29);
            label38.TabIndex = 26;
            label38.Text = "THÔNG TIN QUẢN TRỊ VIÊN";
            // 
            // pnlAddAdmin
            // 
            pnlAddAdmin.BackColor = Color.White;
            pnlAddAdmin.Controls.Add(flowLayoutPanel2);
            pnlAddAdmin.Controls.Add(label2);
            pnlAddAdmin.Location = new Point(230, 51);
            pnlAddAdmin.Name = "pnlAddAdmin";
            pnlAddAdmin.Size = new Size(440, 449);
            pnlAddAdmin.TabIndex = 49;
            pnlAddAdmin.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(txtAddUsername);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(txtAddPassword);
            flowLayoutPanel2.Controls.Add(label8);
            flowLayoutPanel2.Controls.Add(txtAddFullName);
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Controls.Add(dpkAddDob);
            flowLayoutPanel2.Controls.Add(lblTest);
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Controls.Add(label9);
            flowLayoutPanel2.Controls.Add(txtAddPhone);
            flowLayoutPanel2.Controls.Add(label10);
            flowLayoutPanel2.Controls.Add(txtAddCmnd);
            flowLayoutPanel2.Controls.Add(label12);
            flowLayoutPanel2.Controls.Add(cbxAddCity);
            flowLayoutPanel2.Controls.Add(label13);
            flowLayoutPanel2.Controls.Add(cbxAddDistrict);
            flowLayoutPanel2.Controls.Add(label14);
            flowLayoutPanel2.Controls.Add(cbxAddWard);
            flowLayoutPanel2.Controls.Add(label15);
            flowLayoutPanel2.Controls.Add(txtAddAddress);
            flowLayoutPanel2.Controls.Add(label7);
            flowLayoutPanel2.Controls.Add(txtAddEmail);
            flowLayoutPanel2.Controls.Add(label27);
            flowLayoutPanel2.Controls.Add(cbxAddNationality);
            flowLayoutPanel2.Controls.Add(label28);
            flowLayoutPanel2.Controls.Add(cbxAddEthnic);
            flowLayoutPanel2.Controls.Add(label29);
            flowLayoutPanel2.Controls.Add(cbxAddReligion);
            flowLayoutPanel2.Controls.Add(label30);
            flowLayoutPanel2.Controls.Add(cbxAddJob);
            flowLayoutPanel2.Controls.Add(label11);
            flowLayoutPanel2.Controls.Add(txtAddQuestion);
            flowLayoutPanel2.Controls.Add(label31);
            flowLayoutPanel2.Controls.Add(txtAddAnswer);
            flowLayoutPanel2.Controls.Add(btnAdd);
            flowLayoutPanel2.Location = new Point(7, 42);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(427, 394);
            flowLayoutPanel2.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 8);
            label3.Margin = new Padding(0, 8, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 23;
            label3.Text = "Tên đăng nhập:";
            // 
            // txtAddUsername
            // 
            txtAddUsername.AnimateReadOnly = false;
            txtAddUsername.BackColor = Color.White;
            txtAddUsername.BorderStyle = BorderStyle.None;
            txtAddUsername.Depth = 0;
            txtAddUsername.Enabled = false;
            txtAddUsername.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddUsername.LeadingIcon = null;
            txtAddUsername.Location = new Point(3, 33);
            txtAddUsername.Margin = new Padding(3, 5, 3, 0);
            txtAddUsername.MaxLength = 50;
            txtAddUsername.MouseState = MaterialSkin.MouseState.OUT;
            txtAddUsername.Multiline = false;
            txtAddUsername.Name = "txtAddUsername";
            txtAddUsername.ReadOnly = true;
            txtAddUsername.Size = new Size(400, 50);
            txtAddUsername.TabIndex = 39;
            txtAddUsername.Text = "";
            txtAddUsername.TrailingIcon = null;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(0, 91);
            label4.Margin = new Padding(0, 8, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 43;
            label4.Text = "Mật khẩu:";
            // 
            // txtAddPassword
            // 
            txtAddPassword.AnimateReadOnly = false;
            txtAddPassword.BackColor = Color.WhiteSmoke;
            txtAddPassword.BorderStyle = BorderStyle.None;
            txtAddPassword.Depth = 0;
            txtAddPassword.Enabled = false;
            txtAddPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddPassword.LeadingIcon = null;
            txtAddPassword.Location = new Point(3, 116);
            txtAddPassword.Margin = new Padding(3, 5, 3, 0);
            txtAddPassword.MaxLength = 50;
            txtAddPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtAddPassword.Multiline = false;
            txtAddPassword.Name = "txtAddPassword";
            txtAddPassword.ReadOnly = true;
            txtAddPassword.Size = new Size(400, 50);
            txtAddPassword.TabIndex = 45;
            txtAddPassword.Text = "";
            txtAddPassword.TrailingIcon = Properties.Resources.hide_pass;
            txtAddPassword.TrailingIconClick += txtAddPassword_TrailingIconClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(0, 174);
            label8.Margin = new Padding(0, 8, 0, 0);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 58;
            label8.Text = "Họ và tên (*)";
            // 
            // txtAddFullName
            // 
            txtAddFullName.AnimateReadOnly = false;
            txtAddFullName.BackColor = Color.White;
            txtAddFullName.BorderStyle = BorderStyle.None;
            txtAddFullName.Depth = 0;
            txtAddFullName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddFullName.LeadingIcon = null;
            txtAddFullName.Location = new Point(3, 197);
            txtAddFullName.MaxLength = 50;
            txtAddFullName.MouseState = MaterialSkin.MouseState.OUT;
            txtAddFullName.Multiline = false;
            txtAddFullName.Name = "txtAddFullName";
            txtAddFullName.Size = new Size(400, 50);
            txtAddFullName.TabIndex = 46;
            txtAddFullName.Text = "";
            txtAddFullName.TrailingIcon = null;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(0, 258);
            label5.Margin = new Padding(0, 8, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(202, 20);
            label5.TabIndex = 57;
            label5.Text = "Ngày/tháng/năm sinh (*)";
            // 
            // dpkAddDob
            // 
            dpkAddDob.BorderColor = Color.Black;
            dpkAddDob.BorderSize = 0;
            dpkAddDob.CalendarMonthBackground = Color.White;
            dpkAddDob.CustomFormat = "dd/MM/yyyy";
            dpkAddDob.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpkAddDob.Format = DateTimePickerFormat.Custom;
            dpkAddDob.Location = new Point(3, 283);
            dpkAddDob.Margin = new Padding(3, 5, 3, 0);
            dpkAddDob.MinimumSize = new Size(0, 50);
            dpkAddDob.Name = "dpkAddDob";
            dpkAddDob.Size = new Size(400, 50);
            dpkAddDob.SkinColor = Color.WhiteSmoke;
            dpkAddDob.TabIndex = 56;
            dpkAddDob.TextColor = Color.DimGray;
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.BackColor = Color.Transparent;
            lblTest.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTest.ForeColor = Color.Black;
            lblTest.Location = new Point(0, 341);
            lblTest.Margin = new Padding(0, 8, 0, 0);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(100, 20);
            lblTest.TabIndex = 47;
            lblTest.Text = "Giới tính (*)";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(rdbtnAddOther);
            panel1.Controls.Add(rdbtnAddFeMale);
            panel1.Controls.Add(rdbtnAddMale);
            panel1.Location = new Point(3, 364);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 33);
            panel1.TabIndex = 48;
            // 
            // rdbtnAddOther
            // 
            rdbtnAddOther.AutoSize = true;
            rdbtnAddOther.CheckedColor = Color.MediumSlateBlue;
            rdbtnAddOther.Location = new Point(251, 6);
            rdbtnAddOther.MinimumSize = new Size(0, 21);
            rdbtnAddOther.Name = "rdbtnAddOther";
            rdbtnAddOther.Padding = new Padding(10, 0, 0, 0);
            rdbtnAddOther.Size = new Size(73, 22);
            rdbtnAddOther.TabIndex = 2;
            rdbtnAddOther.TabStop = true;
            rdbtnAddOther.Text = "Khac";
            rdbtnAddOther.UnCheckedColor = Color.Gray;
            rdbtnAddOther.UseVisualStyleBackColor = true;
            // 
            // rdbtnAddFeMale
            // 
            rdbtnAddFeMale.AutoSize = true;
            rdbtnAddFeMale.CheckedColor = Color.MediumSlateBlue;
            rdbtnAddFeMale.Location = new Point(155, 6);
            rdbtnAddFeMale.MinimumSize = new Size(0, 21);
            rdbtnAddFeMale.Name = "rdbtnAddFeMale";
            rdbtnAddFeMale.Padding = new Padding(10, 0, 0, 0);
            rdbtnAddFeMale.Size = new Size(58, 22);
            rdbtnAddFeMale.TabIndex = 1;
            rdbtnAddFeMale.TabStop = true;
            rdbtnAddFeMale.Text = "Nu";
            rdbtnAddFeMale.UnCheckedColor = Color.Gray;
            rdbtnAddFeMale.UseVisualStyleBackColor = true;
            // 
            // rdbtnAddMale
            // 
            rdbtnAddMale.AutoSize = true;
            rdbtnAddMale.CheckedColor = Color.MediumSlateBlue;
            rdbtnAddMale.Location = new Point(43, 6);
            rdbtnAddMale.MinimumSize = new Size(0, 21);
            rdbtnAddMale.Name = "rdbtnAddMale";
            rdbtnAddMale.Padding = new Padding(10, 0, 0, 0);
            rdbtnAddMale.Size = new Size(71, 22);
            rdbtnAddMale.TabIndex = 0;
            rdbtnAddMale.TabStop = true;
            rdbtnAddMale.Text = "Nam";
            rdbtnAddMale.UnCheckedColor = Color.Gray;
            rdbtnAddMale.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(0, 408);
            label9.Margin = new Padding(0, 8, 0, 0);
            label9.Name = "label9";
            label9.Size = new Size(136, 20);
            label9.TabIndex = 59;
            label9.Text = "Số điện thoại (*)";
            // 
            // txtAddPhone
            // 
            txtAddPhone.AnimateReadOnly = false;
            txtAddPhone.BorderStyle = BorderStyle.None;
            txtAddPhone.Depth = 0;
            txtAddPhone.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddPhone.LeadingIcon = null;
            txtAddPhone.Location = new Point(3, 431);
            txtAddPhone.MaxLength = 50;
            txtAddPhone.MouseState = MaterialSkin.MouseState.OUT;
            txtAddPhone.Multiline = false;
            txtAddPhone.Name = "txtAddPhone";
            txtAddPhone.Size = new Size(400, 50);
            txtAddPhone.TabIndex = 49;
            txtAddPhone.Text = "";
            txtAddPhone.TrailingIcon = null;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(0, 492);
            label10.Margin = new Padding(0, 8, 0, 0);
            label10.Name = "label10";
            label10.Size = new Size(231, 20);
            label10.TabIndex = 60;
            label10.Text = "Số Hộ chiếu/CMND/CCCD (*)";
            // 
            // txtAddCmnd
            // 
            txtAddCmnd.AnimateReadOnly = false;
            txtAddCmnd.BorderStyle = BorderStyle.None;
            txtAddCmnd.Depth = 0;
            txtAddCmnd.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddCmnd.LeadingIcon = null;
            txtAddCmnd.Location = new Point(3, 515);
            txtAddCmnd.MaxLength = 50;
            txtAddCmnd.MouseState = MaterialSkin.MouseState.OUT;
            txtAddCmnd.Multiline = false;
            txtAddCmnd.Name = "txtAddCmnd";
            txtAddCmnd.Size = new Size(400, 50);
            txtAddCmnd.TabIndex = 50;
            txtAddCmnd.Text = "";
            txtAddCmnd.TrailingIcon = null;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(0, 576);
            label12.Margin = new Padding(0, 8, 0, 0);
            label12.Name = "label12";
            label12.Size = new Size(159, 20);
            label12.TabIndex = 62;
            label12.Text = "Tỉnh/Thành phố (*)";
            // 
            // cbxAddCity
            // 
            cbxAddCity.AutoResize = false;
            cbxAddCity.BackColor = Color.FromArgb(255, 255, 255);
            cbxAddCity.Depth = 0;
            cbxAddCity.DrawMode = DrawMode.OwnerDrawVariable;
            cbxAddCity.DropDownHeight = 174;
            cbxAddCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAddCity.DropDownWidth = 121;
            cbxAddCity.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxAddCity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxAddCity.FormattingEnabled = true;
            cbxAddCity.IntegralHeight = false;
            cbxAddCity.ItemHeight = 43;
            cbxAddCity.Location = new Point(3, 599);
            cbxAddCity.MaxDropDownItems = 4;
            cbxAddCity.MouseState = MaterialSkin.MouseState.OUT;
            cbxAddCity.Name = "cbxAddCity";
            cbxAddCity.Size = new Size(400, 49);
            cbxAddCity.StartIndex = 0;
            cbxAddCity.TabIndex = 52;
            cbxAddCity.SelectedIndexChanged += cbxAddCity_SelectedIndexChanged;
            cbxAddCity.MouseWheel += cbx_MouseWheel;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(0, 659);
            label13.Margin = new Padding(0, 8, 0, 0);
            label13.Name = "label13";
            label13.Size = new Size(130, 20);
            label13.TabIndex = 63;
            label13.Text = "Quận/Huyện (*)";
            // 
            // cbxAddDistrict
            // 
            cbxAddDistrict.AutoResize = false;
            cbxAddDistrict.BackColor = Color.FromArgb(255, 255, 255);
            cbxAddDistrict.Depth = 0;
            cbxAddDistrict.DrawMode = DrawMode.OwnerDrawVariable;
            cbxAddDistrict.DropDownHeight = 174;
            cbxAddDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAddDistrict.DropDownWidth = 121;
            cbxAddDistrict.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxAddDistrict.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxAddDistrict.FormattingEnabled = true;
            cbxAddDistrict.IntegralHeight = false;
            cbxAddDistrict.ItemHeight = 43;
            cbxAddDistrict.Location = new Point(3, 682);
            cbxAddDistrict.MaxDropDownItems = 4;
            cbxAddDistrict.MouseState = MaterialSkin.MouseState.OUT;
            cbxAddDistrict.Name = "cbxAddDistrict";
            cbxAddDistrict.Size = new Size(400, 49);
            cbxAddDistrict.StartIndex = 0;
            cbxAddDistrict.TabIndex = 53;
            cbxAddDistrict.SelectedIndexChanged += cbxAddDistrict_SelectedIndexChanged;
            cbxAddDistrict.MouseWheel += cbx_MouseWheel;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(0, 742);
            label14.Margin = new Padding(0, 8, 0, 0);
            label14.Name = "label14";
            label14.Size = new Size(120, 20);
            label14.TabIndex = 64;
            label14.Text = "Phường/Xã (*)";
            // 
            // cbxAddWard
            // 
            cbxAddWard.AutoResize = false;
            cbxAddWard.BackColor = Color.FromArgb(255, 255, 255);
            cbxAddWard.Depth = 0;
            cbxAddWard.DrawMode = DrawMode.OwnerDrawVariable;
            cbxAddWard.DropDownHeight = 174;
            cbxAddWard.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAddWard.DropDownWidth = 121;
            cbxAddWard.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxAddWard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxAddWard.FormattingEnabled = true;
            cbxAddWard.IntegralHeight = false;
            cbxAddWard.ItemHeight = 43;
            cbxAddWard.Location = new Point(3, 765);
            cbxAddWard.MaxDropDownItems = 4;
            cbxAddWard.MouseState = MaterialSkin.MouseState.OUT;
            cbxAddWard.Name = "cbxAddWard";
            cbxAddWard.Size = new Size(400, 49);
            cbxAddWard.StartIndex = 0;
            cbxAddWard.TabIndex = 54;
            cbxAddWard.MouseWheel += cbx_MouseWheel;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(0, 825);
            label15.Margin = new Padding(0, 8, 0, 0);
            label15.Name = "label15";
            label15.Size = new Size(153, 20);
            label15.TabIndex = 65;
            label15.Text = "Thôn/Xóm/Nhà (*)";
            // 
            // txtAddAddress
            // 
            txtAddAddress.AnimateReadOnly = false;
            txtAddAddress.BorderStyle = BorderStyle.None;
            txtAddAddress.Depth = 0;
            txtAddAddress.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddAddress.LeadingIcon = null;
            txtAddAddress.Location = new Point(3, 848);
            txtAddAddress.MaxLength = 50;
            txtAddAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtAddAddress.Multiline = false;
            txtAddAddress.Name = "txtAddAddress";
            txtAddAddress.Size = new Size(400, 50);
            txtAddAddress.TabIndex = 55;
            txtAddAddress.Text = "";
            txtAddAddress.TrailingIcon = null;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(0, 909);
            label7.Margin = new Padding(0, 8, 0, 0);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 67;
            label7.Text = "Email (*)";
            // 
            // txtAddEmail
            // 
            txtAddEmail.AnimateReadOnly = false;
            txtAddEmail.BorderStyle = BorderStyle.None;
            txtAddEmail.Depth = 0;
            txtAddEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddEmail.LeadingIcon = null;
            txtAddEmail.Location = new Point(3, 932);
            txtAddEmail.MaxLength = 50;
            txtAddEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtAddEmail.Multiline = false;
            txtAddEmail.Name = "txtAddEmail";
            txtAddEmail.Size = new Size(400, 50);
            txtAddEmail.TabIndex = 68;
            txtAddEmail.Text = "";
            txtAddEmail.TrailingIcon = null;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.Transparent;
            label27.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label27.ForeColor = Color.Black;
            label27.Location = new Point(0, 993);
            label27.Margin = new Padding(0, 8, 0, 0);
            label27.Name = "label27";
            label27.Size = new Size(108, 20);
            label27.TabIndex = 73;
            label27.Text = "Quốc tịch (*)";
            // 
            // cbxAddNationality
            // 
            cbxAddNationality.AutoResize = false;
            cbxAddNationality.BackColor = Color.FromArgb(255, 255, 255);
            cbxAddNationality.Depth = 0;
            cbxAddNationality.DrawMode = DrawMode.OwnerDrawVariable;
            cbxAddNationality.DropDownHeight = 174;
            cbxAddNationality.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAddNationality.DropDownWidth = 121;
            cbxAddNationality.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxAddNationality.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxAddNationality.FormattingEnabled = true;
            cbxAddNationality.IntegralHeight = false;
            cbxAddNationality.ItemHeight = 43;
            cbxAddNationality.Location = new Point(3, 1016);
            cbxAddNationality.MaxDropDownItems = 4;
            cbxAddNationality.MouseState = MaterialSkin.MouseState.OUT;
            cbxAddNationality.Name = "cbxAddNationality";
            cbxAddNationality.Size = new Size(400, 49);
            cbxAddNationality.StartIndex = 0;
            cbxAddNationality.TabIndex = 69;
            cbxAddNationality.MouseWheel += cbx_MouseWheel;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BackColor = Color.Transparent;
            label28.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label28.ForeColor = Color.Black;
            label28.Location = new Point(0, 1076);
            label28.Margin = new Padding(0, 8, 0, 0);
            label28.Name = "label28";
            label28.Size = new Size(92, 20);
            label28.TabIndex = 74;
            label28.Text = "Dân tộc (*)";
            // 
            // cbxAddEthnic
            // 
            cbxAddEthnic.AutoResize = false;
            cbxAddEthnic.BackColor = Color.FromArgb(255, 255, 255);
            cbxAddEthnic.Depth = 0;
            cbxAddEthnic.DrawMode = DrawMode.OwnerDrawVariable;
            cbxAddEthnic.DropDownHeight = 174;
            cbxAddEthnic.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAddEthnic.DropDownWidth = 121;
            cbxAddEthnic.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxAddEthnic.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxAddEthnic.FormattingEnabled = true;
            cbxAddEthnic.IntegralHeight = false;
            cbxAddEthnic.ItemHeight = 43;
            cbxAddEthnic.Location = new Point(3, 1099);
            cbxAddEthnic.MaxDropDownItems = 4;
            cbxAddEthnic.MouseState = MaterialSkin.MouseState.OUT;
            cbxAddEthnic.Name = "cbxAddEthnic";
            cbxAddEthnic.Size = new Size(400, 49);
            cbxAddEthnic.StartIndex = 0;
            cbxAddEthnic.TabIndex = 70;
            cbxAddEthnic.MouseWheel += cbx_MouseWheel;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = Color.Transparent;
            label29.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label29.ForeColor = Color.Black;
            label29.Location = new Point(0, 1159);
            label29.Margin = new Padding(0, 8, 0, 0);
            label29.Name = "label29";
            label29.Size = new Size(100, 20);
            label29.TabIndex = 75;
            label29.Text = "Tôn giáo (*)";
            // 
            // cbxAddReligion
            // 
            cbxAddReligion.AutoResize = false;
            cbxAddReligion.BackColor = Color.FromArgb(255, 255, 255);
            cbxAddReligion.Depth = 0;
            cbxAddReligion.DrawMode = DrawMode.OwnerDrawVariable;
            cbxAddReligion.DropDownHeight = 174;
            cbxAddReligion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAddReligion.DropDownWidth = 121;
            cbxAddReligion.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxAddReligion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxAddReligion.FormattingEnabled = true;
            cbxAddReligion.IntegralHeight = false;
            cbxAddReligion.ItemHeight = 43;
            cbxAddReligion.Location = new Point(3, 1182);
            cbxAddReligion.MaxDropDownItems = 4;
            cbxAddReligion.MouseState = MaterialSkin.MouseState.OUT;
            cbxAddReligion.Name = "cbxAddReligion";
            cbxAddReligion.Size = new Size(400, 49);
            cbxAddReligion.StartIndex = 0;
            cbxAddReligion.TabIndex = 71;
            cbxAddReligion.MouseWheel += cbx_MouseWheel;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = Color.Transparent;
            label30.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label30.ForeColor = Color.Black;
            label30.Location = new Point(0, 1242);
            label30.Margin = new Padding(0, 8, 0, 0);
            label30.Name = "label30";
            label30.Size = new Size(132, 20);
            label30.TabIndex = 76;
            label30.Text = "Nghề nghiệp (*)";
            // 
            // cbxAddJob
            // 
            cbxAddJob.AutoResize = false;
            cbxAddJob.BackColor = Color.FromArgb(255, 255, 255);
            cbxAddJob.Depth = 0;
            cbxAddJob.DrawMode = DrawMode.OwnerDrawVariable;
            cbxAddJob.DropDownHeight = 174;
            cbxAddJob.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAddJob.DropDownWidth = 121;
            cbxAddJob.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxAddJob.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxAddJob.FormattingEnabled = true;
            cbxAddJob.IntegralHeight = false;
            cbxAddJob.ItemHeight = 43;
            cbxAddJob.Location = new Point(3, 1265);
            cbxAddJob.MaxDropDownItems = 4;
            cbxAddJob.MouseState = MaterialSkin.MouseState.OUT;
            cbxAddJob.Name = "cbxAddJob";
            cbxAddJob.Size = new Size(400, 49);
            cbxAddJob.StartIndex = 0;
            cbxAddJob.TabIndex = 72;
            cbxAddJob.MouseWheel += cbx_MouseWheel;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(0, 1325);
            label11.Margin = new Padding(0, 8, 0, 0);
            label11.Name = "label11";
            label11.Size = new Size(156, 20);
            label11.TabIndex = 77;
            label11.Text = "Câu hỏi đặt biệt (*)";
            // 
            // txtAddQuestion
            // 
            txtAddQuestion.AnimateReadOnly = false;
            txtAddQuestion.BorderStyle = BorderStyle.None;
            txtAddQuestion.Depth = 0;
            txtAddQuestion.Enabled = false;
            txtAddQuestion.Font = new Font("Roboto", 9.6F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddQuestion.LeadingIcon = null;
            txtAddQuestion.Location = new Point(3, 1348);
            txtAddQuestion.MaxLength = 50;
            txtAddQuestion.MouseState = MaterialSkin.MouseState.OUT;
            txtAddQuestion.Multiline = false;
            txtAddQuestion.Name = "txtAddQuestion";
            txtAddQuestion.Size = new Size(400, 50);
            txtAddQuestion.TabIndex = 79;
            txtAddQuestion.Text = "Trường tiểu học bạn học tên là gì?";
            txtAddQuestion.TrailingIcon = null;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BackColor = Color.Transparent;
            label31.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label31.ForeColor = Color.Black;
            label31.Location = new Point(0, 1409);
            label31.Margin = new Padding(0, 8, 0, 0);
            label31.Name = "label31";
            label31.Size = new Size(211, 20);
            label31.TabIndex = 78;
            label31.Text = "Đáp án câu hỏi đặt biệt (*)";
            // 
            // txtAddAnswer
            // 
            txtAddAnswer.AnimateReadOnly = false;
            txtAddAnswer.BorderStyle = BorderStyle.None;
            txtAddAnswer.Depth = 0;
            txtAddAnswer.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddAnswer.LeadingIcon = null;
            txtAddAnswer.Location = new Point(3, 1432);
            txtAddAnswer.MaxLength = 50;
            txtAddAnswer.MouseState = MaterialSkin.MouseState.OUT;
            txtAddAnswer.Multiline = false;
            txtAddAnswer.Name = "txtAddAnswer";
            txtAddAnswer.Size = new Size(400, 50);
            txtAddAnswer.TabIndex = 80;
            txtAddAnswer.Text = "";
            txtAddAnswer.TrailingIcon = null;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Blue;
            btnAdd.BackgroundColor = Color.Blue;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 20;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(115, 1488);
            btnAdd.Margin = new Padding(115, 3, 3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(196, 38);
            btnAdd.TabIndex = 66;
            btnAdd.Text = "Đăng ký thông tin";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(79, 5);
            label2.Name = "label2";
            label2.Size = new Size(281, 29);
            label2.TabIndex = 26;
            label2.Text = "THÊM QUẢN TRỊ VIÊN";
            // 
            // AdminManagment
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 640);
            Controls.Add(coverPanel);
            Controls.Add(gridView);
            Controls.Add(upbar);
            Controls.Add(btnGoBack);
            Controls.Add(btnOpenAdd);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminManagment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManagment";
            upbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            coverPanel.ResumeLayout(false);
            pnlInfoAdmin.ResumeLayout(false);
            pnlInfoAdmin.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnlAddAdmin.ResumeLayout(false);
            pnlAddAdmin.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private RJCodeAdvance.RJControls.RJButton btnOpenAdd;
        private Panel upbar;
        private Button btnMinimize;
        private Button btnClose;
        private Button btnGoBack;
        private DataGridView gridView;
        private Panel coverPanel;
        private Panel pnlAddAdmin;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox txtAddUsername;
        private Label label4;
        private MaterialSkin.Controls.MaterialTextBox txtAddPassword;
        private Label label8;
        private MaterialSkin.Controls.MaterialTextBox txtAddFullName;
        private Label label5;
        private RJCodeAdvance.RJControls.RJDatePicker dpkAddDob;
        private Label lblTest;
        private Panel panel1;
        private RJCodeAdvance.RJControls.RJRadioButton rdbtnAddOther;
        private RJCodeAdvance.RJControls.RJRadioButton rdbtnAddFeMale;
        private RJCodeAdvance.RJControls.RJRadioButton rdbtnAddMale;
        private Label label9;
        private MaterialSkin.Controls.MaterialTextBox txtAddPhone;
        private Label label10;
        private MaterialSkin.Controls.MaterialTextBox txtAddCmnd;
        private Label label12;
        private MaterialSkin.Controls.MaterialComboBox cbxAddCity;
        private Label label13;
        private MaterialSkin.Controls.MaterialComboBox cbxAddDistrict;
        private Label label14;
        private MaterialSkin.Controls.MaterialComboBox cbxAddWard;
        private Label label15;
        private MaterialSkin.Controls.MaterialTextBox txtAddAddress;
        private RJCodeAdvance.RJControls.RJButton btnAdd;
        private Label label7;
        private MaterialSkin.Controls.MaterialTextBox txtAddEmail;
        private MaterialSkin.Controls.MaterialComboBox cbxAddNationality;
        private MaterialSkin.Controls.MaterialComboBox cbxAddEthnic;
        private MaterialSkin.Controls.MaterialComboBox cbxAddReligion;
        private MaterialSkin.Controls.MaterialComboBox cbxAddJob;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label11;
        private Label label31;
        private MaterialSkin.Controls.MaterialTextBox txtAddQuestion;
        private MaterialSkin.Controls.MaterialTextBox txtAddAnswer;
        private Panel pnlInfoAdmin;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label6;
        private MaterialSkin.Controls.MaterialTextBox txtInfoUsername;
        private Label label17;
        private MaterialSkin.Controls.MaterialTextBox txtInfoFullName;
        private Label label18;
        private RJCodeAdvance.RJControls.RJDatePicker dpkInfoDob;
        private Label label19;
        private Panel panel3;
        private RJCodeAdvance.RJControls.RJRadioButton rdbtnInfoOther;
        private RJCodeAdvance.RJControls.RJRadioButton rdbtnInfoFeMale;
        private RJCodeAdvance.RJControls.RJRadioButton rdbtnInfoMale;
        private Label label20;
        private MaterialSkin.Controls.MaterialTextBox txtInfoPhone;
        private Label label21;
        private MaterialSkin.Controls.MaterialTextBox txtInfoCmnd;
        private Label label22;
        private MaterialSkin.Controls.MaterialComboBox cbxInfoCity;
        private Label label23;
        private MaterialSkin.Controls.MaterialComboBox cbxInfoDistrict;
        private Label label24;
        private MaterialSkin.Controls.MaterialComboBox cbxInfoWard;
        private Label label25;
        private MaterialSkin.Controls.MaterialTextBox txtInfoAddress;
        private Label label26;
        private MaterialSkin.Controls.MaterialTextBox txtInfoEmail;
        private Label label32;
        private MaterialSkin.Controls.MaterialComboBox cbxInfoNationality;
        private Label label33;
        private MaterialSkin.Controls.MaterialComboBox cbxInfoEthnic;
        private Label label34;
        private MaterialSkin.Controls.MaterialComboBox cbxInfoReligion;
        private Label label35;
        private MaterialSkin.Controls.MaterialComboBox cbxInfoJob;
        private RJCodeAdvance.RJControls.RJButton btnUpdate;
        private Label label38;

    }
}