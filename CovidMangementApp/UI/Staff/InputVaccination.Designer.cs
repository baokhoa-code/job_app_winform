namespace CovidMangementApp.UI.Staff
{
    partial class InputVaccination
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
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            btnGoBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            flLayoutOther = new FlowLayoutPanel();
            label17 = new Label();
            cbxVaccine = new MaterialSkin.Controls.MaterialComboBox();
            label18 = new Label();
            cbxInjection = new MaterialSkin.Controls.MaterialComboBox();
            label19 = new Label();
            cbxFacility = new MaterialSkin.Controls.MaterialComboBox();
            label20 = new Label();
            dpkDate = new RJCodeAdvance.RJControls.RJDatePicker();
            materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            label5 = new Label();
            dpkTime = new RJCodeAdvance.RJControls.RJDatePicker();
            materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            flLayoutMain = new FlowLayoutPanel();
            label10 = new Label();
            txtCmnd = new MaterialSkin.Controls.MaterialTextBox();
            label8 = new Label();
            txtName = new MaterialSkin.Controls.MaterialTextBox();
            label4 = new Label();
            dpkDob = new RJCodeAdvance.RJControls.RJDatePicker();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            lblTest = new Label();
            panel2 = new Panel();
            rdbtnOther = new RJCodeAdvance.RJControls.RJRadioButton();
            rdbtnFemale = new RJCodeAdvance.RJControls.RJRadioButton();
            rdbtnMale = new RJCodeAdvance.RJControls.RJRadioButton();
            label9 = new Label();
            txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            label12 = new Label();
            cbxCity = new MaterialSkin.Controls.MaterialComboBox();
            label13 = new Label();
            cbxDistrict = new MaterialSkin.Controls.MaterialComboBox();
            label14 = new Label();
            cbxWard = new MaterialSkin.Controls.MaterialComboBox();
            label15 = new Label();
            txtAddress = new MaterialSkin.Controls.MaterialTextBox();
            btnSave = new RJCodeAdvance.RJControls.RJButton();
            upbar.SuspendLayout();
            flLayoutOther.SuspendLayout();
            flLayoutMain.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // upbar
            // 
            upbar.BackColor = Color.DarkSlateGray;
            upbar.Controls.Add(btnMinimize);
            upbar.Controls.Add(btnClose);
            upbar.Location = new Point(0, 0);
            upbar.Name = "upbar";
            upbar.Size = new Size(900, 30);
            upbar.TabIndex = 36;
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
            btnGoBack.TabIndex = 37;
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(160, 63);
            label1.Name = "label1";
            label1.Size = new Size(597, 48);
            label1.TabIndex = 38;
            label1.Text = "NHẬP THÔNG TIN TIÊM CHỦNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(10, 122);
            label2.Name = "label2";
            label2.Size = new Size(416, 37);
            label2.TabIndex = 39;
            label2.Text = "THÔNG TIN ĐỐI TƯỢNG TIÊM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(495, 122);
            label3.Name = "label3";
            label3.Size = new Size(360, 37);
            label3.TabIndex = 40;
            label3.Text = "THÔNG TIN TIÊM CHỦNG";
            // 
            // flLayoutOther
            // 
            flLayoutOther.AutoScroll = true;
            flLayoutOther.BackColor = Color.White;
            flLayoutOther.Controls.Add(label17);
            flLayoutOther.Controls.Add(cbxVaccine);
            flLayoutOther.Controls.Add(label18);
            flLayoutOther.Controls.Add(cbxInjection);
            flLayoutOther.Controls.Add(label19);
            flLayoutOther.Controls.Add(cbxFacility);
            flLayoutOther.Controls.Add(label20);
            flLayoutOther.Controls.Add(dpkDate);
            flLayoutOther.Controls.Add(materialDivider2);
            flLayoutOther.Controls.Add(label5);
            flLayoutOther.Controls.Add(dpkTime);
            flLayoutOther.Controls.Add(materialDivider3);
            flLayoutOther.Location = new Point(461, 162);
            flLayoutOther.Name = "flLayoutOther";
            flLayoutOther.Size = new Size(427, 394);
            flLayoutOther.TabIndex = 41;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(12, 5);
            label17.Margin = new Padding(12, 5, 0, 0);
            label17.Name = "label17";
            label17.Size = new Size(86, 20);
            label17.TabIndex = 44;
            label17.Text = "Vắc xin (*)";
            // 
            // cbxVaccine
            // 
            cbxVaccine.AutoResize = false;
            cbxVaccine.BackColor = Color.FromArgb(255, 255, 255);
            cbxVaccine.Depth = 0;
            cbxVaccine.DrawMode = DrawMode.OwnerDrawVariable;
            cbxVaccine.DropDownHeight = 174;
            cbxVaccine.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxVaccine.DropDownWidth = 121;
            cbxVaccine.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxVaccine.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxVaccine.FormattingEnabled = true;
            cbxVaccine.IntegralHeight = false;
            cbxVaccine.ItemHeight = 43;
            cbxVaccine.Location = new Point(3, 28);
            cbxVaccine.MaxDropDownItems = 4;
            cbxVaccine.MouseState = MaterialSkin.MouseState.OUT;
            cbxVaccine.Name = "cbxVaccine";
            cbxVaccine.Size = new Size(400, 49);
            cbxVaccine.StartIndex = 0;
            cbxVaccine.TabIndex = 19;
            cbxVaccine.MouseWheel += cbx_MouseWheel;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(12, 85);
            label18.Margin = new Padding(12, 5, 0, 0);
            label18.Name = "label18";
            label18.Size = new Size(83, 20);
            label18.TabIndex = 45;
            label18.Text = "Mũi số (*)";
            // 
            // cbxInjection
            // 
            cbxInjection.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbxInjection.AutoResize = false;
            cbxInjection.BackColor = Color.FromArgb(255, 255, 255);
            cbxInjection.Depth = 0;
            cbxInjection.DrawMode = DrawMode.OwnerDrawVariable;
            cbxInjection.DropDownHeight = 174;
            cbxInjection.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxInjection.DropDownWidth = 121;
            cbxInjection.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxInjection.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxInjection.FormattingEnabled = true;
            cbxInjection.IntegralHeight = false;
            cbxInjection.ItemHeight = 43;
            cbxInjection.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbxInjection.Location = new Point(3, 108);
            cbxInjection.MaxDropDownItems = 4;
            cbxInjection.MouseState = MaterialSkin.MouseState.OUT;
            cbxInjection.Name = "cbxInjection";
            cbxInjection.Size = new Size(400, 49);
            cbxInjection.StartIndex = 0;
            cbxInjection.TabIndex = 20;
            cbxInjection.MouseWheel += cbx_MouseWheel;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(12, 165);
            label19.Margin = new Padding(12, 5, 0, 0);
            label19.Name = "label19";
            label19.Size = new Size(164, 20);
            label19.TabIndex = 46;
            label19.Text = "Cơ sở tiêm chủng (*)";
            // 
            // cbxFacility
            // 
            cbxFacility.AutoResize = false;
            cbxFacility.BackColor = Color.FromArgb(255, 255, 255);
            cbxFacility.Depth = 0;
            cbxFacility.DrawMode = DrawMode.OwnerDrawVariable;
            cbxFacility.DropDownHeight = 174;
            cbxFacility.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFacility.DropDownWidth = 121;
            cbxFacility.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxFacility.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxFacility.FormattingEnabled = true;
            cbxFacility.IntegralHeight = false;
            cbxFacility.ItemHeight = 43;
            cbxFacility.Location = new Point(3, 188);
            cbxFacility.MaxDropDownItems = 4;
            cbxFacility.MouseState = MaterialSkin.MouseState.OUT;
            cbxFacility.Name = "cbxFacility";
            cbxFacility.Size = new Size(400, 49);
            cbxFacility.StartIndex = 0;
            cbxFacility.TabIndex = 21;
            cbxFacility.MouseWheel += cbx_MouseWheel;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(12, 245);
            label20.Margin = new Padding(12, 5, 0, 0);
            label20.Name = "label20";
            label20.Size = new Size(159, 20);
            label20.TabIndex = 47;
            label20.Text = "Ngày tiêm chủng (*)";
            // 
            // dpkDate
            // 
            dpkDate.BorderColor = Color.Black;
            dpkDate.BorderSize = 0;
            dpkDate.CustomFormat = "dd/MM/yyyy";
            dpkDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpkDate.Format = DateTimePickerFormat.Custom;
            dpkDate.Location = new Point(3, 270);
            dpkDate.Margin = new Padding(3, 5, 3, 0);
            dpkDate.MinimumSize = new Size(0, 50);
            dpkDate.Name = "dpkDate";
            dpkDate.Size = new Size(400, 50);
            dpkDate.SkinColor = Color.WhiteSmoke;
            dpkDate.TabIndex = 48;
            dpkDate.TextColor = Color.DimGray;
            // 
            // materialDivider2
            // 
            materialDivider2.BackColor = Color.Black;
            materialDivider2.Depth = 0;
            materialDivider2.Location = new Point(3, 320);
            materialDivider2.Margin = new Padding(3, 0, 3, 3);
            materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider2.Name = "materialDivider2";
            materialDivider2.Size = new Size(400, 1);
            materialDivider2.TabIndex = 51;
            materialDivider2.Text = "materialDivider2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 329);
            label5.Margin = new Padding(12, 5, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(189, 20);
            label5.TabIndex = 49;
            label5.Text = "Thời gian tiêm chủng (*)";
            // 
            // dpkTime
            // 
            dpkTime.BorderColor = Color.Black;
            dpkTime.BorderSize = 0;
            dpkTime.CalendarTitleForeColor = Color.Transparent;
            dpkTime.CalendarTrailingForeColor = Color.Transparent;
            dpkTime.CustomFormat = "hh:mm";
            dpkTime.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpkTime.Format = DateTimePickerFormat.Custom;
            dpkTime.Location = new Point(3, 354);
            dpkTime.Margin = new Padding(3, 5, 3, 0);
            dpkTime.MinimumSize = new Size(0, 50);
            dpkTime.Name = "dpkTime";
            dpkTime.ShowUpDown = true;
            dpkTime.Size = new Size(400, 50);
            dpkTime.SkinColor = Color.WhiteSmoke;
            dpkTime.TabIndex = 50;
            dpkTime.TextColor = Color.DimGray;
            // 
            // materialDivider3
            // 
            materialDivider3.BackColor = Color.Black;
            materialDivider3.Depth = 0;
            materialDivider3.Location = new Point(3, 404);
            materialDivider3.Margin = new Padding(3, 0, 3, 3);
            materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider3.Name = "materialDivider3";
            materialDivider3.Size = new Size(400, 1);
            materialDivider3.TabIndex = 52;
            materialDivider3.Text = "materialDivider3";
            // 
            // flLayoutMain
            // 
            flLayoutMain.AutoScroll = true;
            flLayoutMain.BackColor = Color.White;
            flLayoutMain.Controls.Add(label10);
            flLayoutMain.Controls.Add(txtCmnd);
            flLayoutMain.Controls.Add(label8);
            flLayoutMain.Controls.Add(txtName);
            flLayoutMain.Controls.Add(label4);
            flLayoutMain.Controls.Add(dpkDob);
            flLayoutMain.Controls.Add(materialDivider1);
            flLayoutMain.Controls.Add(lblTest);
            flLayoutMain.Controls.Add(panel2);
            flLayoutMain.Controls.Add(label9);
            flLayoutMain.Controls.Add(txtPhone);
            flLayoutMain.Controls.Add(label12);
            flLayoutMain.Controls.Add(cbxCity);
            flLayoutMain.Controls.Add(label13);
            flLayoutMain.Controls.Add(cbxDistrict);
            flLayoutMain.Controls.Add(label14);
            flLayoutMain.Controls.Add(cbxWard);
            flLayoutMain.Controls.Add(label15);
            flLayoutMain.Controls.Add(txtAddress);
            flLayoutMain.Location = new Point(12, 162);
            flLayoutMain.Name = "flLayoutMain";
            flLayoutMain.Size = new Size(427, 394);
            flLayoutMain.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(12, 5);
            label10.Margin = new Padding(12, 5, 0, 0);
            label10.Name = "label10";
            label10.Size = new Size(225, 20);
            label10.TabIndex = 36;
            label10.Text = "Số Hộ chiếu/CMND/CCCD(*)";
            // 
            // txtCmnd
            // 
            txtCmnd.AnimateReadOnly = false;
            txtCmnd.BorderStyle = BorderStyle.None;
            txtCmnd.Depth = 0;
            txtCmnd.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCmnd.LeadingIcon = null;
            txtCmnd.Location = new Point(3, 28);
            txtCmnd.MaxLength = 50;
            txtCmnd.MouseState = MaterialSkin.MouseState.OUT;
            txtCmnd.Multiline = false;
            txtCmnd.Name = "txtCmnd";
            txtCmnd.Size = new Size(400, 50);
            txtCmnd.TabIndex = 15;
            txtCmnd.Text = "";
            txtCmnd.TrailingIcon = null;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 86);
            label8.Margin = new Padding(12, 5, 0, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 34;
            label8.Text = "Họ và tên (*)";
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Depth = 0;
            txtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.LeadingIcon = null;
            txtName.Location = new Point(3, 109);
            txtName.MaxLength = 50;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Size = new Size(400, 50);
            txtName.TabIndex = 10;
            txtName.Text = "";
            txtName.TrailingIcon = null;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 167);
            label4.Margin = new Padding(12, 5, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(196, 20);
            label4.TabIndex = 33;
            label4.Text = "Ngày/tháng/năm sinh (*)";
            // 
            // dpkDob
            // 
            dpkDob.BorderColor = Color.Black;
            dpkDob.BorderSize = 0;
            dpkDob.CustomFormat = "dd/MM/yyyy";
            dpkDob.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpkDob.Format = DateTimePickerFormat.Custom;
            dpkDob.Location = new Point(3, 192);
            dpkDob.Margin = new Padding(3, 5, 3, 0);
            dpkDob.MinimumSize = new Size(0, 50);
            dpkDob.Name = "dpkDob";
            dpkDob.Size = new Size(400, 50);
            dpkDob.SkinColor = Color.WhiteSmoke;
            dpkDob.TabIndex = 31;
            dpkDob.TextColor = Color.DimGray;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.Black;
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(3, 242);
            materialDivider1.Margin = new Padding(3, 0, 3, 3);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(400, 1);
            materialDivider1.TabIndex = 32;
            materialDivider1.Text = "materialDivider1";
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.BackColor = Color.Transparent;
            lblTest.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTest.ForeColor = Color.Black;
            lblTest.Location = new Point(12, 251);
            lblTest.Margin = new Padding(12, 5, 0, 0);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(94, 20);
            lblTest.TabIndex = 12;
            lblTest.Text = "Giới tính (*)";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(rdbtnOther);
            panel2.Controls.Add(rdbtnFemale);
            panel2.Controls.Add(rdbtnMale);
            panel2.Location = new Point(3, 274);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 33);
            panel2.TabIndex = 13;
            // 
            // rdbtnOther
            // 
            rdbtnOther.AutoSize = true;
            rdbtnOther.CheckedColor = Color.MediumSlateBlue;
            rdbtnOther.Location = new Point(251, 6);
            rdbtnOther.MinimumSize = new Size(0, 21);
            rdbtnOther.Name = "rdbtnOther";
            rdbtnOther.Padding = new Padding(10, 0, 0, 0);
            rdbtnOther.Size = new Size(72, 24);
            rdbtnOther.TabIndex = 2;
            rdbtnOther.TabStop = true;
            rdbtnOther.Text = "Khac";
            rdbtnOther.UnCheckedColor = Color.Gray;
            rdbtnOther.UseVisualStyleBackColor = true;
            // 
            // rdbtnFemale
            // 
            rdbtnFemale.AutoSize = true;
            rdbtnFemale.CheckedColor = Color.MediumSlateBlue;
            rdbtnFemale.Location = new Point(155, 6);
            rdbtnFemale.MinimumSize = new Size(0, 21);
            rdbtnFemale.Name = "rdbtnFemale";
            rdbtnFemale.Padding = new Padding(10, 0, 0, 0);
            rdbtnFemale.Size = new Size(59, 24);
            rdbtnFemale.TabIndex = 1;
            rdbtnFemale.TabStop = true;
            rdbtnFemale.Text = "Nu";
            rdbtnFemale.UnCheckedColor = Color.Gray;
            rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            rdbtnMale.AutoSize = true;
            rdbtnMale.CheckedColor = Color.MediumSlateBlue;
            rdbtnMale.Location = new Point(43, 6);
            rdbtnMale.MinimumSize = new Size(0, 21);
            rdbtnMale.Name = "rdbtnMale";
            rdbtnMale.Padding = new Padding(10, 0, 0, 0);
            rdbtnMale.Size = new Size(72, 24);
            rdbtnMale.TabIndex = 0;
            rdbtnMale.TabStop = true;
            rdbtnMale.Text = "Nam";
            rdbtnMale.UnCheckedColor = Color.Gray;
            rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(12, 315);
            label9.Margin = new Padding(12, 5, 0, 0);
            label9.Name = "label9";
            label9.Size = new Size(130, 20);
            label9.TabIndex = 35;
            label9.Text = "Số điện thoại (*)";
            // 
            // txtPhone
            // 
            txtPhone.AnimateReadOnly = false;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Depth = 0;
            txtPhone.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPhone.LeadingIcon = null;
            txtPhone.Location = new Point(3, 338);
            txtPhone.MaxLength = 50;
            txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            txtPhone.Multiline = false;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(400, 50);
            txtPhone.TabIndex = 14;
            txtPhone.Text = "";
            txtPhone.TrailingIcon = null;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(12, 396);
            label12.Margin = new Padding(12, 5, 0, 0);
            label12.Name = "label12";
            label12.Size = new Size(150, 20);
            label12.TabIndex = 38;
            label12.Text = "Tỉnh/Thành phố (*)";
            // 
            // cbxCity
            // 
            cbxCity.AutoResize = false;
            cbxCity.BackColor = Color.FromArgb(255, 255, 255);
            cbxCity.Depth = 0;
            cbxCity.DrawMode = DrawMode.OwnerDrawVariable;
            cbxCity.DropDownHeight = 174;
            cbxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCity.DropDownWidth = 121;
            cbxCity.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxCity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxCity.FormattingEnabled = true;
            cbxCity.IntegralHeight = false;
            cbxCity.ItemHeight = 43;
            cbxCity.Location = new Point(3, 419);
            cbxCity.MaxDropDownItems = 4;
            cbxCity.MouseState = MaterialSkin.MouseState.OUT;
            cbxCity.Name = "cbxCity";
            cbxCity.Size = new Size(400, 49);
            cbxCity.StartIndex = 0;
            cbxCity.TabIndex = 17;
            cbxCity.MouseWheel += cbx_MouseWheel;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(12, 476);
            label13.Margin = new Padding(12, 5, 0, 0);
            label13.Name = "label13";
            label13.Size = new Size(125, 20);
            label13.TabIndex = 39;
            label13.Text = "Quận/Huyện (*)";
            // 
            // cbxDistrict
            // 
            cbxDistrict.AutoResize = false;
            cbxDistrict.BackColor = Color.FromArgb(255, 255, 255);
            cbxDistrict.Depth = 0;
            cbxDistrict.DrawMode = DrawMode.OwnerDrawVariable;
            cbxDistrict.DropDownHeight = 174;
            cbxDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDistrict.DropDownWidth = 121;
            cbxDistrict.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxDistrict.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxDistrict.FormattingEnabled = true;
            cbxDistrict.IntegralHeight = false;
            cbxDistrict.ItemHeight = 43;
            cbxDistrict.Location = new Point(3, 499);
            cbxDistrict.MaxDropDownItems = 4;
            cbxDistrict.MouseState = MaterialSkin.MouseState.OUT;
            cbxDistrict.Name = "cbxDistrict";
            cbxDistrict.Size = new Size(400, 49);
            cbxDistrict.StartIndex = 0;
            cbxDistrict.TabIndex = 18;
            cbxDistrict.MouseWheel += cbx_MouseWheel;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(12, 556);
            label14.Margin = new Padding(12, 5, 0, 0);
            label14.Name = "label14";
            label14.Size = new Size(119, 20);
            label14.TabIndex = 40;
            label14.Text = "Phường/Xã (*)";
            // 
            // cbxWard
            // 
            cbxWard.AutoResize = false;
            cbxWard.BackColor = Color.FromArgb(255, 255, 255);
            cbxWard.Depth = 0;
            cbxWard.DrawMode = DrawMode.OwnerDrawVariable;
            cbxWard.DropDownHeight = 174;
            cbxWard.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxWard.DropDownWidth = 121;
            cbxWard.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxWard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxWard.FormattingEnabled = true;
            cbxWard.IntegralHeight = false;
            cbxWard.ItemHeight = 43;
            cbxWard.Location = new Point(3, 579);
            cbxWard.MaxDropDownItems = 4;
            cbxWard.MouseState = MaterialSkin.MouseState.OUT;
            cbxWard.Name = "cbxWard";
            cbxWard.Size = new Size(400, 49);
            cbxWard.StartIndex = 0;
            cbxWard.TabIndex = 19;
            cbxWard.MouseWheel += cbx_MouseWheel;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(12, 636);
            label15.Margin = new Padding(12, 5, 0, 0);
            label15.Name = "label15";
            label15.Size = new Size(150, 20);
            label15.TabIndex = 41;
            label15.Text = "Thôn/Xóm/Nhà (*)";
            // 
            // txtAddress
            // 
            txtAddress.AnimateReadOnly = false;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Depth = 0;
            txtAddress.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddress.LeadingIcon = null;
            txtAddress.Location = new Point(3, 659);
            txtAddress.MaxLength = 50;
            txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtAddress.Multiline = false;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(400, 50);
            txtAddress.TabIndex = 20;
            txtAddress.Text = "";
            txtAddress.TrailingIcon = null;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.BackgroundColor = Color.ForestGreen;
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 20;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Roboto", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(306, 575);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(272, 50);
            btnSave.TabIndex = 43;
            btnSave.Text = "Lưu thông tin";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // InputVaccination
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 640);
            Controls.Add(btnSave);
            Controls.Add(flLayoutMain);
            Controls.Add(flLayoutOther);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnGoBack);
            Controls.Add(upbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InputVaccination";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InputVaccination";
            upbar.ResumeLayout(false);
            flLayoutOther.ResumeLayout(false);
            flLayoutOther.PerformLayout();
            flLayoutMain.ResumeLayout(false);
            flLayoutMain.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel upbar;
        private Button btnMinimize;
        private Button btnClose;
        private Button btnGoBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flLayoutOther;
        private Label label17;
        private MaterialSkin.Controls.MaterialComboBox cbxVaccine;
        private Label label18;
        private MaterialSkin.Controls.MaterialComboBox cbxInjection;
        private Label label19;
        private MaterialSkin.Controls.MaterialComboBox cbxFacility;
        private Label label20;
        private FlowLayoutPanel flLayoutMain;
        private Label label8;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private Label label4;
        private RJCodeAdvance.RJControls.RJDatePicker dpkDob;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Label lblTest;
        private Panel panel2;
        private RJCodeAdvance.RJControls.RJRadioButton rdbtnOther;
        private RJCodeAdvance.RJControls.RJRadioButton rdbtnFemale;
        private RJCodeAdvance.RJControls.RJRadioButton rdbtnMale;
        private Label label9;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
        private Label label10;
        private MaterialSkin.Controls.MaterialTextBox txtCmnd;
        private Label label12;
        private MaterialSkin.Controls.MaterialComboBox cbxCity;
        private Label label13;
        private MaterialSkin.Controls.MaterialComboBox cbxDistrict;
        private Label label14;
        private MaterialSkin.Controls.MaterialComboBox cbxWard;
        private Label label15;
        private MaterialSkin.Controls.MaterialTextBox txtAddress;
        private RJCodeAdvance.RJControls.RJButton btnSave;
        private RJCodeAdvance.RJControls.RJDatePicker dpkDate;
        private Label label5;
        private RJCodeAdvance.RJControls.RJDatePicker dpkTime;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
    }
}