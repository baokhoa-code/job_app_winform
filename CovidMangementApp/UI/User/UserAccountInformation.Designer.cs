namespace CovidMangementApp.UI.User
{
    partial class UserAccountInformation
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
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnUpdate = new RJCodeAdvance.RJControls.RJButton();
            btnGoBack = new Button();
            flLayoutOther = new FlowLayoutPanel();
            label16 = new Label();
            txtInsurance = new MaterialSkin.Controls.MaterialTextBox();
            label5 = new Label();
            dpkStartDate = new RJCodeAdvance.RJControls.RJDatePicker();
            label6 = new Label();
            dpkEndDate = new RJCodeAdvance.RJControls.RJDatePicker();
            label7 = new Label();
            dpkPointDate = new RJCodeAdvance.RJControls.RJDatePicker();
            label17 = new Label();
            cbxNationality = new MaterialSkin.Controls.MaterialComboBox();
            label18 = new Label();
            cbxEthnic = new MaterialSkin.Controls.MaterialComboBox();
            label19 = new Label();
            cbxReligion = new MaterialSkin.Controls.MaterialComboBox();
            label20 = new Label();
            cbxJob = new MaterialSkin.Controls.MaterialComboBox();
            flLayoutMain = new FlowLayoutPanel();
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
            label10 = new Label();
            txtCmnd = new MaterialSkin.Controls.MaterialTextBox();
            label11 = new Label();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            label12 = new Label();
            cbxCity = new MaterialSkin.Controls.MaterialComboBox();
            label13 = new Label();
            cbxDistrict = new MaterialSkin.Controls.MaterialComboBox();
            label14 = new Label();
            cbxWard = new MaterialSkin.Controls.MaterialComboBox();
            label15 = new Label();
            txtAddress = new MaterialSkin.Controls.MaterialTextBox();
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            flLayoutOther.SuspendLayout();
            flLayoutMain.SuspendLayout();
            panel2.SuspendLayout();
            upbar.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(91, 122);
            label2.Name = "label2";
            label2.Size = new Size(273, 37);
            label2.TabIndex = 31;
            label2.Text = "THÔNG TIN CHÍNH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(550, 122);
            label3.Name = "label3";
            label3.Size = new Size(261, 37);
            label3.TabIndex = 32;
            label3.Text = "THÔNG TIN KHÁC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(250, 63);
            label1.Name = "label1";
            label1.Size = new Size(447, 48);
            label1.TabIndex = 29;
            label1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.ForestGreen;
            btnUpdate.BackgroundColor = Color.ForestGreen;
            btnUpdate.BorderColor = Color.PaleVioletRed;
            btnUpdate.BorderRadius = 20;
            btnUpdate.BorderSize = 0;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Roboto", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(306, 581);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(272, 50);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Chỉnh sửa thông tin";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
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
            btnGoBack.TabIndex = 27;
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // flLayoutOther
            // 
            flLayoutOther.AutoScroll = true;
            flLayoutOther.BackColor = Color.White;
            flLayoutOther.Controls.Add(label16);
            flLayoutOther.Controls.Add(txtInsurance);
            flLayoutOther.Controls.Add(label5);
            flLayoutOther.Controls.Add(dpkStartDate);
            flLayoutOther.Controls.Add(label6);
            flLayoutOther.Controls.Add(dpkEndDate);
            flLayoutOther.Controls.Add(label7);
            flLayoutOther.Controls.Add(dpkPointDate);
            flLayoutOther.Controls.Add(label17);
            flLayoutOther.Controls.Add(cbxNationality);
            flLayoutOther.Controls.Add(label18);
            flLayoutOther.Controls.Add(cbxEthnic);
            flLayoutOther.Controls.Add(label19);
            flLayoutOther.Controls.Add(cbxReligion);
            flLayoutOther.Controls.Add(label20);
            flLayoutOther.Controls.Add(cbxJob);
            flLayoutOther.Location = new Point(461, 162);
            flLayoutOther.Name = "flLayoutOther";
            flLayoutOther.Size = new Size(427, 394);
            flLayoutOther.TabIndex = 34;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(12, 5);
            label16.Margin = new Padding(12, 5, 0, 0);
            label16.Name = "label16";
            label16.Size = new Size(186, 20);
            label16.TabIndex = 59;
            label16.Text = "Số thẻ Bảo hiểm y tế (*)";
            // 
            // txtInsurance
            // 
            txtInsurance.AnimateReadOnly = false;
            txtInsurance.BorderStyle = BorderStyle.None;
            txtInsurance.Depth = 0;
            txtInsurance.Enabled = false;
            txtInsurance.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInsurance.LeadingIcon = null;
            txtInsurance.Location = new Point(3, 28);
            txtInsurance.MaxLength = 50;
            txtInsurance.MouseState = MaterialSkin.MouseState.OUT;
            txtInsurance.Multiline = false;
            txtInsurance.Name = "txtInsurance";
            txtInsurance.Size = new Size(400, 50);
            txtInsurance.TabIndex = 48;
            txtInsurance.Text = "";
            txtInsurance.TrailingIcon = null;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 86);
            label5.Margin = new Padding(12, 5, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(263, 20);
            label5.TabIndex = 53;
            label5.Text = "Thời hạn sử dụng thẻ - Từ ngày (*)";
            // 
            // dpkStartDate
            // 
            dpkStartDate.BorderColor = Color.Black;
            dpkStartDate.BorderSize = 0;
            dpkStartDate.CustomFormat = "dd/MM/yyyy";
            dpkStartDate.Enabled = false;
            dpkStartDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpkStartDate.Format = DateTimePickerFormat.Custom;
            dpkStartDate.Location = new Point(3, 111);
            dpkStartDate.Margin = new Padding(3, 5, 3, 0);
            dpkStartDate.MinimumSize = new Size(0, 50);
            dpkStartDate.Name = "dpkStartDate";
            dpkStartDate.Size = new Size(400, 50);
            dpkStartDate.SkinColor = Color.WhiteSmoke;
            dpkStartDate.TabIndex = 56;
            dpkStartDate.TextColor = Color.DimGray;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 166);
            label6.Margin = new Padding(12, 5, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(272, 20);
            label6.TabIndex = 54;
            label6.Text = "Thời hạn sử dụng thẻ - Đến ngày (*)";
            // 
            // dpkEndDate
            // 
            dpkEndDate.BorderColor = Color.Black;
            dpkEndDate.BorderSize = 0;
            dpkEndDate.CustomFormat = "dd/MM/yyyy";
            dpkEndDate.Enabled = false;
            dpkEndDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpkEndDate.Format = DateTimePickerFormat.Custom;
            dpkEndDate.Location = new Point(3, 191);
            dpkEndDate.Margin = new Padding(3, 5, 3, 0);
            dpkEndDate.MinimumSize = new Size(0, 50);
            dpkEndDate.Name = "dpkEndDate";
            dpkEndDate.Size = new Size(400, 50);
            dpkEndDate.SkinColor = Color.WhiteSmoke;
            dpkEndDate.TabIndex = 57;
            dpkEndDate.TextColor = Color.DimGray;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 246);
            label7.Margin = new Padding(12, 5, 0, 0);
            label7.Name = "label7";
            label7.Size = new Size(249, 20);
            label7.TabIndex = 55;
            label7.Text = "Thời điểm đủ 05 năm liên tục (*)";
            // 
            // dpkPointDate
            // 
            dpkPointDate.BorderColor = Color.Black;
            dpkPointDate.BorderSize = 0;
            dpkPointDate.CustomFormat = "dd/MM/yyyy";
            dpkPointDate.Enabled = false;
            dpkPointDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpkPointDate.Format = DateTimePickerFormat.Custom;
            dpkPointDate.Location = new Point(3, 271);
            dpkPointDate.Margin = new Padding(3, 5, 3, 0);
            dpkPointDate.MinimumSize = new Size(0, 50);
            dpkPointDate.Name = "dpkPointDate";
            dpkPointDate.Size = new Size(400, 50);
            dpkPointDate.SkinColor = Color.WhiteSmoke;
            dpkPointDate.TabIndex = 58;
            dpkPointDate.TextColor = Color.DimGray;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(12, 326);
            label17.Margin = new Padding(12, 5, 0, 0);
            label17.Name = "label17";
            label17.Size = new Size(104, 20);
            label17.TabIndex = 60;
            label17.Text = "Quốc tịch (*)";
            // 
            // cbxNationality
            // 
            cbxNationality.AutoResize = false;
            cbxNationality.BackColor = Color.FromArgb(255, 255, 255);
            cbxNationality.Depth = 0;
            cbxNationality.DrawMode = DrawMode.OwnerDrawVariable;
            cbxNationality.DropDownHeight = 174;
            cbxNationality.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNationality.DropDownWidth = 121;
            cbxNationality.Enabled = false;
            cbxNationality.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxNationality.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxNationality.FormattingEnabled = true;
            cbxNationality.IntegralHeight = false;
            cbxNationality.ItemHeight = 43;
            cbxNationality.Location = new Point(3, 349);
            cbxNationality.MaxDropDownItems = 4;
            cbxNationality.MouseState = MaterialSkin.MouseState.OUT;
            cbxNationality.Name = "cbxNationality";
            cbxNationality.Size = new Size(400, 49);
            cbxNationality.StartIndex = 0;
            cbxNationality.TabIndex = 49;
            cbxNationality.MouseWheel += cbx_MouseWheel;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(12, 406);
            label18.Margin = new Padding(12, 5, 0, 0);
            label18.Name = "label18";
            label18.Size = new Size(90, 20);
            label18.TabIndex = 61;
            label18.Text = "Dân tộc (*)";
            // 
            // cbxEthnic
            // 
            cbxEthnic.AutoResize = false;
            cbxEthnic.BackColor = Color.FromArgb(255, 255, 255);
            cbxEthnic.Depth = 0;
            cbxEthnic.DrawMode = DrawMode.OwnerDrawVariable;
            cbxEthnic.DropDownHeight = 174;
            cbxEthnic.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEthnic.DropDownWidth = 121;
            cbxEthnic.Enabled = false;
            cbxEthnic.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxEthnic.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxEthnic.FormattingEnabled = true;
            cbxEthnic.IntegralHeight = false;
            cbxEthnic.ItemHeight = 43;
            cbxEthnic.Location = new Point(3, 429);
            cbxEthnic.MaxDropDownItems = 4;
            cbxEthnic.MouseState = MaterialSkin.MouseState.OUT;
            cbxEthnic.Name = "cbxEthnic";
            cbxEthnic.Size = new Size(400, 49);
            cbxEthnic.StartIndex = 0;
            cbxEthnic.TabIndex = 50;
            cbxEthnic.MouseWheel += cbx_MouseWheel;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(12, 486);
            label19.Margin = new Padding(12, 5, 0, 0);
            label19.Name = "label19";
            label19.Size = new Size(97, 20);
            label19.TabIndex = 62;
            label19.Text = "Tôn giáo (*)";
            // 
            // cbxReligion
            // 
            cbxReligion.AutoResize = false;
            cbxReligion.BackColor = Color.FromArgb(255, 255, 255);
            cbxReligion.Depth = 0;
            cbxReligion.DrawMode = DrawMode.OwnerDrawVariable;
            cbxReligion.DropDownHeight = 174;
            cbxReligion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxReligion.DropDownWidth = 121;
            cbxReligion.Enabled = false;
            cbxReligion.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxReligion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxReligion.FormattingEnabled = true;
            cbxReligion.IntegralHeight = false;
            cbxReligion.ItemHeight = 43;
            cbxReligion.Location = new Point(3, 509);
            cbxReligion.MaxDropDownItems = 4;
            cbxReligion.MouseState = MaterialSkin.MouseState.OUT;
            cbxReligion.Name = "cbxReligion";
            cbxReligion.Size = new Size(400, 49);
            cbxReligion.StartIndex = 0;
            cbxReligion.TabIndex = 51;
            cbxReligion.MouseWheel += cbx_MouseWheel;

            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(12, 566);
            label20.Margin = new Padding(12, 5, 0, 0);
            label20.Name = "label20";
            label20.Size = new Size(127, 20);
            label20.TabIndex = 63;
            label20.Text = "Nghề nghiệp (*)";
            // 
            // cbxJob
            // 
            cbxJob.AutoResize = false;
            cbxJob.BackColor = Color.FromArgb(255, 255, 255);
            cbxJob.Depth = 0;
            cbxJob.DrawMode = DrawMode.OwnerDrawVariable;
            cbxJob.DropDownHeight = 174;
            cbxJob.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxJob.DropDownWidth = 121;
            cbxJob.Enabled = false;
            cbxJob.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxJob.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxJob.FormattingEnabled = true;
            cbxJob.IntegralHeight = false;
            cbxJob.ItemHeight = 43;
            cbxJob.Location = new Point(3, 589);
            cbxJob.MaxDropDownItems = 4;
            cbxJob.MouseState = MaterialSkin.MouseState.OUT;
            cbxJob.Name = "cbxJob";
            cbxJob.Size = new Size(400, 49);
            cbxJob.StartIndex = 0;
            cbxJob.TabIndex = 52;
            cbxJob.MouseWheel += cbx_MouseWheel;
            // 
            // flLayoutMain
            // 
            flLayoutMain.AutoScroll = true;
            flLayoutMain.BackColor = Color.White;
            flLayoutMain.Controls.Add(label8);
            flLayoutMain.Controls.Add(txtName);
            flLayoutMain.Controls.Add(label4);
            flLayoutMain.Controls.Add(dpkDob);
            flLayoutMain.Controls.Add(materialDivider1);
            flLayoutMain.Controls.Add(lblTest);
            flLayoutMain.Controls.Add(panel2);
            flLayoutMain.Controls.Add(label9);
            flLayoutMain.Controls.Add(txtPhone);
            flLayoutMain.Controls.Add(label10);
            flLayoutMain.Controls.Add(txtCmnd);
            flLayoutMain.Controls.Add(label11);
            flLayoutMain.Controls.Add(txtEmail);
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
            flLayoutMain.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 5);
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
            txtName.Enabled = false;
            txtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.LeadingIcon = null;
            txtName.Location = new Point(3, 28);
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
            label4.Location = new Point(12, 86);
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
            dpkDob.Enabled = false;
            dpkDob.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpkDob.Format = DateTimePickerFormat.Custom;
            dpkDob.Location = new Point(3, 111);
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
            materialDivider1.Location = new Point(3, 161);
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
            lblTest.Location = new Point(12, 170);
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
            panel2.Location = new Point(3, 193);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 33);
            panel2.TabIndex = 13;
            // 
            // rdbtnOther
            // 
            rdbtnOther.AutoSize = true;
            rdbtnOther.CheckedColor = Color.MediumSlateBlue;
            rdbtnOther.Enabled = false;
            rdbtnOther.Location = new Point(251, 6);
            rdbtnOther.MinimumSize = new Size(0, 21);
            rdbtnOther.Name = "rdbtnOther";
            rdbtnOther.Padding = new Padding(10, 0, 0, 0);
            rdbtnOther.Size = new Size(72, 22);
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
            rdbtnFemale.Enabled = false;
            rdbtnFemale.Location = new Point(155, 6);
            rdbtnFemale.MinimumSize = new Size(0, 21);
            rdbtnFemale.Name = "rdbtnFemale";
            rdbtnFemale.Padding = new Padding(10, 0, 0, 0);
            rdbtnFemale.Size = new Size(58, 22);
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
            rdbtnMale.Enabled = false;
            rdbtnMale.Location = new Point(43, 6);
            rdbtnMale.MinimumSize = new Size(0, 21);
            rdbtnMale.Name = "rdbtnMale";
            rdbtnMale.Padding = new Padding(10, 0, 0, 0);
            rdbtnMale.Size = new Size(71, 22);
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
            label9.Location = new Point(12, 234);
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
            txtPhone.Enabled = false;
            txtPhone.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPhone.LeadingIcon = null;
            txtPhone.Location = new Point(3, 257);
            txtPhone.MaxLength = 50;
            txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            txtPhone.Multiline = false;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(400, 50);
            txtPhone.TabIndex = 14;
            txtPhone.Text = "";
            txtPhone.TrailingIcon = null;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(12, 315);
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
            txtCmnd.Enabled = false;
            txtCmnd.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCmnd.LeadingIcon = null;
            txtCmnd.Location = new Point(3, 338);
            txtCmnd.MaxLength = 50;
            txtCmnd.MouseState = MaterialSkin.MouseState.OUT;
            txtCmnd.Multiline = false;
            txtCmnd.Name = "txtCmnd";
            txtCmnd.Size = new Size(400, 50);
            txtCmnd.TabIndex = 15;
            txtCmnd.Text = "";
            txtCmnd.TrailingIcon = null;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(12, 396);
            label11.Margin = new Padding(12, 5, 0, 0);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 37;
            label11.Text = "Email (*)";
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(3, 419);
            txtEmail.MaxLength = 50;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 50);
            txtEmail.TabIndex = 16;
            txtEmail.Text = "";
            txtEmail.TrailingIcon = null;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(12, 477);
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
            cbxCity.Enabled = false;
            cbxCity.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxCity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxCity.FormattingEnabled = true;
            cbxCity.IntegralHeight = false;
            cbxCity.ItemHeight = 43;
            cbxCity.Location = new Point(3, 500);
            cbxCity.MaxDropDownItems = 4;
            cbxCity.MouseState = MaterialSkin.MouseState.OUT;
            cbxCity.Name = "cbxCity";
            cbxCity.Size = new Size(400, 49);
            cbxCity.StartIndex = 0;
            cbxCity.TabIndex = 17;
            cbxCity.SelectedIndexChanged += cbxCity_SelectedIndexChanged;
            cbxCity.MouseWheel += cbx_MouseWheel;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(12, 557);
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
            cbxDistrict.Enabled = false;
            cbxDistrict.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxDistrict.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxDistrict.FormattingEnabled = true;
            cbxDistrict.IntegralHeight = false;
            cbxDistrict.ItemHeight = 43;
            cbxDistrict.Location = new Point(3, 580);
            cbxDistrict.MaxDropDownItems = 4;
            cbxDistrict.MouseState = MaterialSkin.MouseState.OUT;
            cbxDistrict.Name = "cbxDistrict";
            cbxDistrict.Size = new Size(400, 49);
            cbxDistrict.StartIndex = 0;
            cbxDistrict.TabIndex = 18;
            cbxDistrict.SelectedIndexChanged += cbxDistrict_SelectedIndexChanged;
            cbxDistrict.MouseWheel += cbx_MouseWheel;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(12, 637);
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
            cbxWard.Enabled = false;
            cbxWard.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxWard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxWard.FormattingEnabled = true;
            cbxWard.IntegralHeight = false;
            cbxWard.ItemHeight = 43;
            cbxWard.Location = new Point(3, 660);
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
            label15.Location = new Point(12, 717);
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
            txtAddress.Enabled = false;
            txtAddress.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddress.LeadingIcon = null;
            txtAddress.Location = new Point(3, 740);
            txtAddress.MaxLength = 50;
            txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtAddress.Multiline = false;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(400, 50);
            txtAddress.TabIndex = 20;
            txtAddress.Text = "";
            txtAddress.TrailingIcon = null;
            // 
            // upbar
            // 
            upbar.BackColor = Color.DarkSlateGray;
            upbar.Controls.Add(btnMinimize);
            upbar.Controls.Add(btnClose);
            upbar.Location = new Point(0, 0);
            upbar.Name = "upbar";
            upbar.Size = new Size(900, 30);
            upbar.TabIndex = 35;
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
            // UserAccountInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 640);
            Controls.Add(upbar);
            Controls.Add(flLayoutOther);
            Controls.Add(flLayoutMain);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(btnGoBack);
            Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserAccountInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserAccountInformation";
            flLayoutOther.ResumeLayout(false);
            flLayoutOther.PerformLayout();
            flLayoutMain.ResumeLayout(false);
            flLayoutMain.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            upbar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label1;
        private RJCodeAdvance.RJControls.RJButton btnUpdate;
        private Button btnGoBack;
        private FlowLayoutPanel flLayoutOther;
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
        private Label label11;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private Label label12;
        private MaterialSkin.Controls.MaterialComboBox cbxCity;
        private Label label13;
        private MaterialSkin.Controls.MaterialComboBox cbxDistrict;
        private Label label14;
        private MaterialSkin.Controls.MaterialComboBox cbxWard;
        private Label label15;
        private MaterialSkin.Controls.MaterialTextBox txtAddress;
        private Panel upbar;
        private Button btnMinimize;
        private Button btnClose;
        private Label label16;
        private MaterialSkin.Controls.MaterialTextBox txtInsurance;
        private Label label5;
        private RJCodeAdvance.RJControls.RJDatePicker dpkStartDate;
        private Label label6;
        private RJCodeAdvance.RJControls.RJDatePicker dpkEndDate;
        private Label label7;
        private RJCodeAdvance.RJControls.RJDatePicker dpkPointDate;
        private Label label17;
        private MaterialSkin.Controls.MaterialComboBox cbxNationality;
        private Label label18;
        private MaterialSkin.Controls.MaterialComboBox cbxEthnic;
        private Label label19;
        private MaterialSkin.Controls.MaterialComboBox cbxReligion;
        private Label label20;
        private MaterialSkin.Controls.MaterialComboBox cbxJob;
    }
}