namespace CovidMangementApp.UI
{
    partial class Regist
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
            btnGoBack = new Button();
            btnRegist = new RJCodeAdvance.RJControls.RJButton();
            label1 = new Label();
            txtName = new MaterialSkin.Controls.MaterialTextBox();
            lblTest = new Label();
            panel2 = new Panel();
            rdbtnOther = new RJCodeAdvance.RJControls.RJRadioButton();
            rdbtnFemale = new RJCodeAdvance.RJControls.RJRadioButton();
            rdbtnMale = new RJCodeAdvance.RJControls.RJRadioButton();
            txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            txtCmnd = new MaterialSkin.Controls.MaterialTextBox();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            cbxCity = new MaterialSkin.Controls.MaterialComboBox();
            cbxDistrict = new MaterialSkin.Controls.MaterialComboBox();
            cbxWard = new MaterialSkin.Controls.MaterialComboBox();
            txtAddress = new MaterialSkin.Controls.MaterialTextBox();
            label2 = new Label();
            flLayoutMain = new FlowLayoutPanel();
            label8 = new Label();
            label4 = new Label();
            dpkDob = new RJCodeAdvance.RJControls.RJDatePicker();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            flLayoutOther = new FlowLayoutPanel();
            label16 = new Label();
            txtInsurance = new MaterialSkin.Controls.MaterialTextBox();
            label5 = new Label();
            dpkStartDate = new RJCodeAdvance.RJControls.RJDatePicker();
            materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            label6 = new Label();
            dpkEndDate = new RJCodeAdvance.RJControls.RJDatePicker();
            materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            label7 = new Label();
            dpkPointDate = new RJCodeAdvance.RJControls.RJDatePicker();
            materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            label17 = new Label();
            cbxNationality = new MaterialSkin.Controls.MaterialComboBox();
            label18 = new Label();
            cbxEthnic = new MaterialSkin.Controls.MaterialComboBox();
            label19 = new Label();
            cbxReligion = new MaterialSkin.Controls.MaterialComboBox();
            label20 = new Label();
            cbxJob = new MaterialSkin.Controls.MaterialComboBox();
            label21 = new Label();
            txtQuestion = new MaterialSkin.Controls.MaterialTextBox();
            label22 = new Label();
            txtAnswer = new MaterialSkin.Controls.MaterialTextBox();
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            label3 = new Label();
            panel2.SuspendLayout();
            flLayoutMain.SuspendLayout();
            flLayoutOther.SuspendLayout();
            upbar.SuspendLayout();
            SuspendLayout();
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.Transparent;
            btnGoBack.BackgroundImage = Properties.Resources.left_arrow;
            btnGoBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnGoBack.FlatAppearance.BorderSize = 0;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Location = new Point(4, 34);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(35, 35);
            btnGoBack.TabIndex = 19;
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // btnRegist
            // 
            btnRegist.BackColor = Color.ForestGreen;
            btnRegist.BackgroundColor = Color.ForestGreen;
            btnRegist.BorderColor = Color.PaleVioletRed;
            btnRegist.BorderRadius = 20;
            btnRegist.BorderSize = 0;
            btnRegist.FlatAppearance.BorderSize = 0;
            btnRegist.FlatStyle = FlatStyle.Flat;
            btnRegist.Font = new Font("Roboto", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegist.ForeColor = Color.White;
            btnRegist.Location = new Point(306, 572);
            btnRegist.Name = "btnRegist";
            btnRegist.Size = new Size(272, 50);
            btnRegist.TabIndex = 20;
            btnRegist.Text = "Đăng ký thông tin";
            btnRegist.TextColor = Color.White;
            btnRegist.UseVisualStyleBackColor = false;
            btnRegist.Click += btnRegist_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(250, 63);
            label1.Name = "label1";
            label1.Size = new Size(406, 48);
            label1.TabIndex = 21;
            label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Depth = 0;
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
            // txtPhone
            // 
            txtPhone.AnimateReadOnly = false;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Depth = 0;
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
            // txtCmnd
            // 
            txtCmnd.AnimateReadOnly = false;
            txtCmnd.BorderStyle = BorderStyle.None;
            txtCmnd.Depth = 0;
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
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
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
            cbxCity.Location = new Point(3, 500);
            cbxCity.MaxDropDownItems = 4;
            cbxCity.MouseState = MaterialSkin.MouseState.OUT;
            cbxCity.Name = "cbxCity";
            cbxCity.Size = new Size(400, 49);
            cbxCity.StartIndex = 0;
            cbxCity.TabIndex = 17;
            cbxCity.SelectedIndexChanged += cbxCity_SelectedIndexChanged;
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
            cbxDistrict.Location = new Point(3, 580);
            cbxDistrict.MaxDropDownItems = 4;
            cbxDistrict.MouseState = MaterialSkin.MouseState.OUT;
            cbxDistrict.Name = "cbxDistrict";
            cbxDistrict.Size = new Size(400, 49);
            cbxDistrict.StartIndex = 0;
            cbxDistrict.TabIndex = 18;
            cbxDistrict.SelectedIndexChanged += cbxDistrict_SelectedIndexChanged;
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
            cbxWard.Location = new Point(3, 660);
            cbxWard.MaxDropDownItems = 4;
            cbxWard.MouseState = MaterialSkin.MouseState.OUT;
            cbxWard.Name = "cbxWard";
            cbxWard.Size = new Size(400, 49);
            cbxWard.StartIndex = 0;
            cbxWard.TabIndex = 19;
            // 
            // txtAddress
            // 
            txtAddress.AnimateReadOnly = false;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Depth = 0;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(91, 122);
            label2.Name = "label2";
            label2.Size = new Size(273, 37);
            label2.TabIndex = 23;
            label2.Text = "THÔNG TIN CHÍNH";
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
            flLayoutMain.TabIndex = 23;
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
            // flLayoutOther
            // 
            flLayoutOther.AutoScroll = true;
            flLayoutOther.BackColor = Color.White;
            flLayoutOther.Controls.Add(label16);
            flLayoutOther.Controls.Add(txtInsurance);
            flLayoutOther.Controls.Add(label5);
            flLayoutOther.Controls.Add(dpkStartDate);
            flLayoutOther.Controls.Add(materialDivider2);
            flLayoutOther.Controls.Add(label6);
            flLayoutOther.Controls.Add(dpkEndDate);
            flLayoutOther.Controls.Add(materialDivider3);
            flLayoutOther.Controls.Add(label7);
            flLayoutOther.Controls.Add(dpkPointDate);
            flLayoutOther.Controls.Add(materialDivider4);
            flLayoutOther.Controls.Add(label17);
            flLayoutOther.Controls.Add(cbxNationality);
            flLayoutOther.Controls.Add(label18);
            flLayoutOther.Controls.Add(cbxEthnic);
            flLayoutOther.Controls.Add(label19);
            flLayoutOther.Controls.Add(cbxReligion);
            flLayoutOther.Controls.Add(label20);
            flLayoutOther.Controls.Add(cbxJob);
            flLayoutOther.Controls.Add(label21);
            flLayoutOther.Controls.Add(txtQuestion);
            flLayoutOther.Controls.Add(label22);
            flLayoutOther.Controls.Add(txtAnswer);
            flLayoutOther.Location = new Point(461, 162);
            flLayoutOther.Name = "flLayoutOther";
            flLayoutOther.Size = new Size(427, 394);
            flLayoutOther.TabIndex = 25;
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
            label16.TabIndex = 43;
            label16.Text = "Số thẻ Bảo hiểm y tế (*)";
            // 
            // txtInsurance
            // 
            txtInsurance.AnimateReadOnly = false;
            txtInsurance.BorderStyle = BorderStyle.None;
            txtInsurance.Depth = 0;
            txtInsurance.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInsurance.LeadingIcon = null;
            txtInsurance.Location = new Point(3, 28);
            txtInsurance.MaxLength = 50;
            txtInsurance.MouseState = MaterialSkin.MouseState.OUT;
            txtInsurance.Multiline = false;
            txtInsurance.Name = "txtInsurance";
            txtInsurance.Size = new Size(400, 50);
            txtInsurance.TabIndex = 12;
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
            label5.TabIndex = 34;
            label5.Text = "Thời hạn sử dụng thẻ - Từ ngày (*)";
            // 
            // dpkStartDate
            // 
            dpkStartDate.BorderColor = Color.Black;
            dpkStartDate.BorderSize = 0;
            dpkStartDate.CustomFormat = "dd/MM/yyyy";
            dpkStartDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpkStartDate.Format = DateTimePickerFormat.Custom;
            dpkStartDate.Location = new Point(3, 111);
            dpkStartDate.Margin = new Padding(3, 5, 3, 0);
            dpkStartDate.MinimumSize = new Size(0, 50);
            dpkStartDate.Name = "dpkStartDate";
            dpkStartDate.Size = new Size(400, 50);
            dpkStartDate.SkinColor = Color.WhiteSmoke;
            dpkStartDate.TabIndex = 40;
            dpkStartDate.TextColor = Color.DimGray;
            // 
            // materialDivider2
            // 
            materialDivider2.BackColor = Color.Black;
            materialDivider2.Depth = 0;
            materialDivider2.Location = new Point(3, 161);
            materialDivider2.Margin = new Padding(3, 0, 3, 3);
            materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider2.Name = "materialDivider2";
            materialDivider2.Size = new Size(400, 1);
            materialDivider2.TabIndex = 37;
            materialDivider2.Text = "materialDivider2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 170);
            label6.Margin = new Padding(12, 5, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(272, 20);
            label6.TabIndex = 35;
            label6.Text = "Thời hạn sử dụng thẻ - Đến ngày (*)";
            // 
            // dpkEndDate
            // 
            dpkEndDate.BorderColor = Color.Black;
            dpkEndDate.BorderSize = 0;
            dpkEndDate.CustomFormat = "dd/MM/yyyy";
            dpkEndDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpkEndDate.Format = DateTimePickerFormat.Custom;
            dpkEndDate.Location = new Point(3, 195);
            dpkEndDate.Margin = new Padding(3, 5, 3, 0);
            dpkEndDate.MinimumSize = new Size(0, 50);
            dpkEndDate.Name = "dpkEndDate";
            dpkEndDate.Size = new Size(400, 50);
            dpkEndDate.SkinColor = Color.WhiteSmoke;
            dpkEndDate.TabIndex = 41;
            dpkEndDate.TextColor = Color.DimGray;
            // 
            // materialDivider3
            // 
            materialDivider3.BackColor = Color.Black;
            materialDivider3.Depth = 0;
            materialDivider3.Location = new Point(3, 245);
            materialDivider3.Margin = new Padding(3, 0, 3, 3);
            materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider3.Name = "materialDivider3";
            materialDivider3.Size = new Size(400, 1);
            materialDivider3.TabIndex = 38;
            materialDivider3.Text = "materialDivider3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 254);
            label7.Margin = new Padding(12, 5, 0, 0);
            label7.Name = "label7";
            label7.Size = new Size(249, 20);
            label7.TabIndex = 36;
            label7.Text = "Thời điểm đủ 05 năm liên tục (*)";
            // 
            // dpkPointDate
            // 
            dpkPointDate.BorderColor = Color.Black;
            dpkPointDate.BorderSize = 0;
            dpkPointDate.CustomFormat = "dd/MM/yyyy";
            dpkPointDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpkPointDate.Format = DateTimePickerFormat.Custom;
            dpkPointDate.Location = new Point(3, 279);
            dpkPointDate.Margin = new Padding(3, 5, 3, 0);
            dpkPointDate.MinimumSize = new Size(0, 50);
            dpkPointDate.Name = "dpkPointDate";
            dpkPointDate.Size = new Size(400, 50);
            dpkPointDate.SkinColor = Color.WhiteSmoke;
            dpkPointDate.TabIndex = 42;
            dpkPointDate.TextColor = Color.DimGray;
            // 
            // materialDivider4
            // 
            materialDivider4.BackColor = Color.Black;
            materialDivider4.Depth = 0;
            materialDivider4.Location = new Point(3, 329);
            materialDivider4.Margin = new Padding(3, 0, 3, 3);
            materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider4.Name = "materialDivider4";
            materialDivider4.Size = new Size(400, 1);
            materialDivider4.TabIndex = 39;
            materialDivider4.Text = "materialDivider4";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(12, 338);
            label17.Margin = new Padding(12, 5, 0, 0);
            label17.Name = "label17";
            label17.Size = new Size(104, 20);
            label17.TabIndex = 44;
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
            cbxNationality.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxNationality.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxNationality.FormattingEnabled = true;
            cbxNationality.IntegralHeight = false;
            cbxNationality.ItemHeight = 43;
            cbxNationality.Location = new Point(3, 361);
            cbxNationality.MaxDropDownItems = 4;
            cbxNationality.MouseState = MaterialSkin.MouseState.OUT;
            cbxNationality.Name = "cbxNationality";
            cbxNationality.Size = new Size(400, 49);
            cbxNationality.StartIndex = 0;
            cbxNationality.TabIndex = 19;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(12, 418);
            label18.Margin = new Padding(12, 5, 0, 0);
            label18.Name = "label18";
            label18.Size = new Size(90, 20);
            label18.TabIndex = 45;
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
            cbxEthnic.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxEthnic.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxEthnic.FormattingEnabled = true;
            cbxEthnic.IntegralHeight = false;
            cbxEthnic.ItemHeight = 43;
            cbxEthnic.Location = new Point(3, 441);
            cbxEthnic.MaxDropDownItems = 4;
            cbxEthnic.MouseState = MaterialSkin.MouseState.OUT;
            cbxEthnic.Name = "cbxEthnic";
            cbxEthnic.Size = new Size(400, 49);
            cbxEthnic.StartIndex = 0;
            cbxEthnic.TabIndex = 20;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(12, 498);
            label19.Margin = new Padding(12, 5, 0, 0);
            label19.Name = "label19";
            label19.Size = new Size(97, 20);
            label19.TabIndex = 46;
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
            cbxReligion.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxReligion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxReligion.FormattingEnabled = true;
            cbxReligion.IntegralHeight = false;
            cbxReligion.ItemHeight = 43;
            cbxReligion.Location = new Point(3, 521);
            cbxReligion.MaxDropDownItems = 4;
            cbxReligion.MouseState = MaterialSkin.MouseState.OUT;
            cbxReligion.Name = "cbxReligion";
            cbxReligion.Size = new Size(400, 49);
            cbxReligion.StartIndex = 0;
            cbxReligion.TabIndex = 21;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(12, 578);
            label20.Margin = new Padding(12, 5, 0, 0);
            label20.Name = "label20";
            label20.Size = new Size(127, 20);
            label20.TabIndex = 47;
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
            cbxJob.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxJob.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxJob.FormattingEnabled = true;
            cbxJob.IntegralHeight = false;
            cbxJob.ItemHeight = 43;
            cbxJob.Location = new Point(3, 601);
            cbxJob.MaxDropDownItems = 4;
            cbxJob.MouseState = MaterialSkin.MouseState.OUT;
            cbxJob.Name = "cbxJob";
            cbxJob.Size = new Size(400, 49);
            cbxJob.StartIndex = 0;
            cbxJob.TabIndex = 25;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(12, 658);
            label21.Margin = new Padding(12, 5, 0, 0);
            label21.Name = "label21";
            label21.Size = new Size(153, 20);
            label21.TabIndex = 48;
            label21.Text = "Câu hỏi đặc biệt (*)";
            // 
            // txtQuestion
            // 
            txtQuestion.AnimateReadOnly = false;
            txtQuestion.BorderStyle = BorderStyle.None;
            txtQuestion.Depth = 0;
            txtQuestion.Enabled = false;
            txtQuestion.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuestion.LeadingIcon = null;
            txtQuestion.Location = new Point(3, 681);
            txtQuestion.MaxLength = 50;
            txtQuestion.MouseState = MaterialSkin.MouseState.OUT;
            txtQuestion.Multiline = false;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(400, 50);
            txtQuestion.TabIndex = 26;
            txtQuestion.Text = "Trường tiểu học bạn học tên là gì?";
            txtQuestion.TrailingIcon = null;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(12, 739);
            label22.Margin = new Padding(12, 5, 0, 0);
            label22.Name = "label22";
            label22.Size = new Size(207, 20);
            label22.TabIndex = 49;
            label22.Text = "Đáp án câu hỏi đặc biệt (*)";
            // 
            // txtAnswer
            // 
            txtAnswer.AnimateReadOnly = false;
            txtAnswer.BorderStyle = BorderStyle.None;
            txtAnswer.Depth = 0;
            txtAnswer.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAnswer.LeadingIcon = null;
            txtAnswer.Location = new Point(3, 762);
            txtAnswer.MaxLength = 50;
            txtAnswer.MouseState = MaterialSkin.MouseState.OUT;
            txtAnswer.Multiline = false;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(400, 50);
            txtAnswer.TabIndex = 27;
            txtAnswer.Text = "";
            txtAnswer.TrailingIcon = null;
            // 
            // upbar
            // 
            upbar.BackColor = Color.DarkSlateGray;
            upbar.Controls.Add(btnMinimize);
            upbar.Controls.Add(btnClose);
            upbar.Location = new Point(0, 0);
            upbar.Name = "upbar";
            upbar.Size = new Size(900, 30);
            upbar.TabIndex = 30;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(550, 122);
            label3.Name = "label3";
            label3.Size = new Size(261, 37);
            label3.TabIndex = 24;
            label3.Text = "THÔNG TIN KHÁC";
            // 
            // Regist
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 640);
            Controls.Add(upbar);
            Controls.Add(flLayoutOther);
            Controls.Add(flLayoutMain);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegist);
            Controls.Add(btnGoBack);
            Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Regist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Regist";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flLayoutMain.ResumeLayout(false);
            flLayoutMain.PerformLayout();
            flLayoutOther.ResumeLayout(false);
            flLayoutOther.PerformLayout();
            upbar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGoBack;
        private RJCodeAdvance.RJControls.RJButton btnRegist;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flLayoutMain;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private Label lblTest;
        private Panel panel2;
        private RJCodeAdvance.RJControls.RJRadioButton rdbtnFemale;
        private RJCodeAdvance.RJControls.RJRadioButton rdbtnMale;
        private RJCodeAdvance.RJControls.RJRadioButton rdbtnOther;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
        private MaterialSkin.Controls.MaterialTextBox txtCmnd;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialComboBox cbxCity;
        private MaterialSkin.Controls.MaterialComboBox cbxDistrict;
        private MaterialSkin.Controls.MaterialComboBox cbxWard;
        private MaterialSkin.Controls.MaterialTextBox txtAddress;
        private FlowLayoutPanel flLayoutOther;
        private MaterialSkin.Controls.MaterialTextBox txtInsurance;
        private MaterialSkin.Controls.MaterialComboBox cbxNationality;
        private MaterialSkin.Controls.MaterialComboBox cbxEthnic;
        private MaterialSkin.Controls.MaterialComboBox cbxReligion;
        private MaterialSkin.Controls.MaterialComboBox cbxJob;
        private MaterialSkin.Controls.MaterialTextBox txtQuestion;
        private MaterialSkin.Controls.MaterialTextBox txtAnswer;
        private Panel upbar;
        private Button btnMinimize;
        private Button btnClose;
        private RJCodeAdvance.RJControls.RJDatePicker dpkDob;
        private Label label3;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private RJCodeAdvance.RJControls.RJDatePicker dpkStartDate;
        private RJCodeAdvance.RJControls.RJDatePicker dpkEndDate;
        private RJCodeAdvance.RJControls.RJDatePicker dpkPointDate;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
    }
}