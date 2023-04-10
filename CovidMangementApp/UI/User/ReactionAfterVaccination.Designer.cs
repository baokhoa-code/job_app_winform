namespace CovidMangementApp.UI.User
{
    partial class ReactionAfterVaccination
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
            label1 = new Label();
            btnGoBack = new Button();
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            roundedPanel1 = new Custom.RoundedPanel();
            flowListRegist = new FlowLayoutPanel();
            btnOpenRegist = new RJCodeAdvance.RJControls.RJButton();
            lblRegist = new Label();
            pnlRegist = new Custom.RoundedPanel();
            flLayoutOther = new FlowLayoutPanel();
            label4 = new Label();
            label13 = new Label();
            txtRegistTarget = new MaterialSkin.Controls.MaterialTextBox();
            label12 = new Label();
            cbxRegistVaccineName = new MaterialSkin.Controls.MaterialComboBox();
            label5 = new Label();
            txtRegistInjectionDate = new MaterialSkin.Controls.MaterialTextBox();
            label14 = new Label();
            dpkRegistReactionDate = new RJCodeAdvance.RJControls.RJDatePicker();
            label15 = new Label();
            dpkRegistReactionTime = new RJCodeAdvance.RJControls.RJDatePicker();
            label16 = new Label();
            panel1 = new Panel();
            rdbtnRegistYes = new RJCodeAdvance.RJControls.RJRadioButton();
            rdbtnRegistNo = new RJCodeAdvance.RJControls.RJRadioButton();
            label17 = new Label();
            btnAddRegist = new RJCodeAdvance.RJControls.RJButton();
            pnlDetail = new Custom.RoundedPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            txtDetailTarget = new RJCodeAdvance.RJControls.RJTextBox();
            label6 = new Label();
            txtDetailVaccineName = new RJCodeAdvance.RJControls.RJTextBox();
            label7 = new Label();
            txtDetailInjectionDate = new RJCodeAdvance.RJControls.RJTextBox();
            label8 = new Label();
            txtDetailReactionDate = new RJCodeAdvance.RJControls.RJTextBox();
            label9 = new Label();
            txtDetailReactionTime = new RJCodeAdvance.RJControls.RJTextBox();
            label10 = new Label();
            panel2 = new Panel();
            rdDetailYes = new RJCodeAdvance.RJControls.RJRadioButton();
            rdDetailNo = new RJCodeAdvance.RJControls.RJRadioButton();
            label11 = new Label();
            panel29 = new Panel();
            txtDetailAdvice = new Label();
            lblDetail = new Label();
            upbar.SuspendLayout();
            roundedPanel1.SuspendLayout();
            pnlRegist.SuspendLayout();
            flLayoutOther.SuspendLayout();
            panel1.SuspendLayout();
            pnlDetail.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel29.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 107);
            label2.Name = "label2";
            label2.Size = new Size(238, 24);
            label2.TabIndex = 43;
            label2.Text = "Danh sách phiếu khảo sát";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(276, 41);
            label1.Name = "label1";
            label1.Size = new Size(351, 41);
            label1.TabIndex = 42;
            label1.Text = "PHẢN ỨNG SAU TIÊM";
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.Transparent;
            btnGoBack.BackgroundImage = Properties.Resources.left_arrow;
            btnGoBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnGoBack.FlatAppearance.BorderSize = 0;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Location = new Point(2, 32);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(35, 35);
            btnGoBack.TabIndex = 41;
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // upbar
            // 
            upbar.BackColor = Color.DarkSlateGray;
            upbar.Controls.Add(btnMinimize);
            upbar.Controls.Add(btnClose);
            upbar.Location = new Point(0, 0);
            upbar.Name = "upbar";
            upbar.Size = new Size(900, 30);
            upbar.TabIndex = 40;
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
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderRadius = 50;
            roundedPanel1.Controls.Add(flowListRegist);
            roundedPanel1.Controls.Add(btnOpenRegist);
            roundedPanel1.ForeColor = Color.Black;
            roundedPanel1.GradientAngIe = 90F;
            roundedPanel1.GradientBottomColor = Color.AliceBlue;
            roundedPanel1.GradientTopColor = Color.AliceBlue;
            roundedPanel1.Location = new Point(12, 137);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(269, 491);
            roundedPanel1.TabIndex = 44;
            // 
            // flowListRegist
            // 
            flowListRegist.AutoScroll = true;
            flowListRegist.BackColor = Color.AliceBlue;
            flowListRegist.Location = new Point(3, 57);
            flowListRegist.Name = "flowListRegist";
            flowListRegist.Size = new Size(263, 409);
            flowListRegist.TabIndex = 38;
            // 
            // btnOpenRegist
            // 
            btnOpenRegist.BackColor = Color.DodgerBlue;
            btnOpenRegist.BackgroundColor = Color.DodgerBlue;
            btnOpenRegist.BorderColor = Color.PaleVioletRed;
            btnOpenRegist.BorderRadius = 25;
            btnOpenRegist.BorderSize = 0;
            btnOpenRegist.FlatAppearance.BorderSize = 0;
            btnOpenRegist.FlatStyle = FlatStyle.Flat;
            btnOpenRegist.Font = new Font("Roboto", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpenRegist.ForeColor = Color.White;
            btnOpenRegist.Location = new Point(12, 1);
            btnOpenRegist.Name = "btnOpenRegist";
            btnOpenRegist.Size = new Size(246, 44);
            btnOpenRegist.TabIndex = 37;
            btnOpenRegist.Text = "Phiếu khảo sát";
            btnOpenRegist.TextColor = Color.White;
            btnOpenRegist.UseVisualStyleBackColor = false;
            btnOpenRegist.Click += btnOpenRegist_Click;
            // 
            // lblRegist
            // 
            lblRegist.AutoSize = true;
            lblRegist.BackColor = Color.Transparent;
            lblRegist.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegist.ForeColor = Color.Blue;
            lblRegist.Location = new Point(340, 107);
            lblRegist.Name = "lblRegist";
            lblRegist.Size = new Size(502, 28);
            lblRegist.TabIndex = 45;
            lblRegist.Text = "THÔNG TIN TÌNH TRẠNG PHẢN ỨNG SAU TIÊM";
            lblRegist.Visible = false;
            // 
            // pnlRegist
            // 
            pnlRegist.BackColor = Color.White;
            pnlRegist.BorderRadius = 50;
            pnlRegist.Controls.Add(flLayoutOther);
            pnlRegist.ForeColor = Color.Black;
            pnlRegist.GradientAngIe = 90F;
            pnlRegist.GradientBottomColor = Color.White;
            pnlRegist.GradientTopColor = Color.White;
            pnlRegist.Location = new Point(294, 137);
            pnlRegist.Name = "pnlRegist";
            pnlRegist.Size = new Size(594, 491);
            pnlRegist.TabIndex = 46;
            pnlRegist.Visible = false;
            // 
            // flLayoutOther
            // 
            flLayoutOther.AutoScroll = true;
            flLayoutOther.BackColor = Color.White;
            flLayoutOther.Controls.Add(label4);
            flLayoutOther.Controls.Add(label13);
            flLayoutOther.Controls.Add(txtRegistTarget);
            flLayoutOther.Controls.Add(label12);
            flLayoutOther.Controls.Add(cbxRegistVaccineName);
            flLayoutOther.Controls.Add(label5);
            flLayoutOther.Controls.Add(txtRegistInjectionDate);
            flLayoutOther.Controls.Add(label14);
            flLayoutOther.Controls.Add(dpkRegistReactionDate);
            flLayoutOther.Controls.Add(label15);
            flLayoutOther.Controls.Add(dpkRegistReactionTime);
            flLayoutOther.Controls.Add(label16);
            flLayoutOther.Controls.Add(panel1);
            flLayoutOther.Controls.Add(label17);
            flLayoutOther.Controls.Add(btnAddRegist);
            flLayoutOther.Location = new Point(3, 3);
            flLayoutOther.Name = "flLayoutOther";
            flLayoutOther.Size = new Size(588, 471);
            flLayoutOther.TabIndex = 35;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(12, 5);
            label4.Margin = new Padding(12, 5, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(559, 44);
            label4.TabIndex = 62;
            label4.Text = "Khuyến cáo: Bất kỳ lúc nào có biểu hiện bất thường, đề nghị Anh/Chị điền ngày thông tin vào bảng hỏi";
            // 
            // label13
            // 
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(12, 79);
            label13.Margin = new Padding(12, 30, 0, 0);
            label13.Name = "label13";
            label13.Size = new Size(559, 20);
            label13.TabIndex = 70;
            label13.Text = "Đối tượng tiêm";
            // 
            // txtRegistTarget
            // 
            txtRegistTarget.AnimateReadOnly = false;
            txtRegistTarget.BorderStyle = BorderStyle.None;
            txtRegistTarget.Depth = 0;
            txtRegistTarget.Enabled = false;
            txtRegistTarget.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRegistTarget.LeadingIcon = null;
            txtRegistTarget.Location = new Point(15, 102);
            txtRegistTarget.Margin = new Padding(15, 3, 3, 3);
            txtRegistTarget.MaxLength = 50;
            txtRegistTarget.MouseState = MaterialSkin.MouseState.OUT;
            txtRegistTarget.Multiline = false;
            txtRegistTarget.Name = "txtRegistTarget";
            txtRegistTarget.Size = new Size(536, 50);
            txtRegistTarget.TabIndex = 67;
            txtRegistTarget.Text = "";
            txtRegistTarget.TrailingIcon = null;
            // 
            // label12
            // 
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(12, 160);
            label12.Margin = new Padding(12, 5, 0, 0);
            label12.Name = "label12";
            label12.Size = new Size(559, 20);
            label12.TabIndex = 68;
            label12.Text = "Tên vắc xin (*)";
            // 
            // cbxRegistVaccineName
            // 
            cbxRegistVaccineName.AutoResize = false;
            cbxRegistVaccineName.BackColor = Color.FromArgb(255, 255, 255);
            cbxRegistVaccineName.Depth = 0;
            cbxRegistVaccineName.DrawMode = DrawMode.OwnerDrawVariable;
            cbxRegistVaccineName.DropDownHeight = 174;
            cbxRegistVaccineName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRegistVaccineName.DropDownWidth = 121;
            cbxRegistVaccineName.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxRegistVaccineName.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxRegistVaccineName.FormattingEnabled = true;
            cbxRegistVaccineName.IntegralHeight = false;
            cbxRegistVaccineName.ItemHeight = 43;
            cbxRegistVaccineName.Location = new Point(15, 183);
            cbxRegistVaccineName.Margin = new Padding(15, 3, 3, 3);
            cbxRegistVaccineName.MaxDropDownItems = 4;
            cbxRegistVaccineName.MouseState = MaterialSkin.MouseState.OUT;
            cbxRegistVaccineName.Name = "cbxRegistVaccineName";
            cbxRegistVaccineName.Size = new Size(536, 49);
            cbxRegistVaccineName.StartIndex = 0;
            cbxRegistVaccineName.TabIndex = 81;
            cbxRegistVaccineName.SelectedIndexChanged += cbxRegistVaccineName_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 240);
            label5.Margin = new Padding(12, 5, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(370, 20);
            label5.TabIndex = 72;
            label5.Text = "Ngày tiêm";
            // 
            // txtRegistInjectionDate
            // 
            txtRegistInjectionDate.AnimateReadOnly = false;
            txtRegistInjectionDate.BorderStyle = BorderStyle.None;
            txtRegistInjectionDate.Depth = 0;
            txtRegistInjectionDate.Enabled = false;
            txtRegistInjectionDate.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRegistInjectionDate.LeadingIcon = null;
            txtRegistInjectionDate.Location = new Point(15, 263);
            txtRegistInjectionDate.Margin = new Padding(15, 3, 3, 3);
            txtRegistInjectionDate.MaxLength = 50;
            txtRegistInjectionDate.MouseState = MaterialSkin.MouseState.OUT;
            txtRegistInjectionDate.Multiline = false;
            txtRegistInjectionDate.Name = "txtRegistInjectionDate";
            txtRegistInjectionDate.Size = new Size(536, 50);
            txtRegistInjectionDate.TabIndex = 95;
            txtRegistInjectionDate.Text = "";
            txtRegistInjectionDate.TrailingIcon = null;
            // 
            // label14
            // 
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(12, 321);
            label14.Margin = new Padding(12, 5, 0, 0);
            label14.Name = "label14";
            label14.Size = new Size(370, 20);
            label14.TabIndex = 74;
            label14.Text = "Ngày xảy ra phản ứng (*)";
            // 
            // dpkRegistReactionDate
            // 
            dpkRegistReactionDate.BorderColor = Color.Black;
            dpkRegistReactionDate.BorderSize = 0;
            dpkRegistReactionDate.CustomFormat = "dd/MM/yyyy";
            dpkRegistReactionDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpkRegistReactionDate.Format = DateTimePickerFormat.Custom;
            dpkRegistReactionDate.Location = new Point(15, 346);
            dpkRegistReactionDate.Margin = new Padding(15, 5, 3, 0);
            dpkRegistReactionDate.MinimumSize = new Size(0, 50);
            dpkRegistReactionDate.Name = "dpkRegistReactionDate";
            dpkRegistReactionDate.Size = new Size(536, 50);
            dpkRegistReactionDate.SkinColor = Color.WhiteSmoke;
            dpkRegistReactionDate.TabIndex = 103;
            dpkRegistReactionDate.TextColor = Color.DimGray;
            // 
            // label15
            // 
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(12, 401);
            label15.Margin = new Padding(12, 5, 0, 0);
            label15.Name = "label15";
            label15.Size = new Size(370, 20);
            label15.TabIndex = 76;
            label15.Text = "Thời gian xảy ra phản ứng (*)";
            // 
            // dpkRegistReactionTime
            // 
            dpkRegistReactionTime.BorderColor = Color.Black;
            dpkRegistReactionTime.BorderSize = 0;
            dpkRegistReactionTime.CalendarTitleForeColor = Color.Transparent;
            dpkRegistReactionTime.CalendarTrailingForeColor = Color.Transparent;
            dpkRegistReactionTime.CustomFormat = "hh:mm";
            dpkRegistReactionTime.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpkRegistReactionTime.Format = DateTimePickerFormat.Custom;
            dpkRegistReactionTime.Location = new Point(15, 426);
            dpkRegistReactionTime.Margin = new Padding(15, 5, 3, 0);
            dpkRegistReactionTime.MinimumSize = new Size(0, 50);
            dpkRegistReactionTime.Name = "dpkRegistReactionTime";
            dpkRegistReactionTime.ShowUpDown = true;
            dpkRegistReactionTime.Size = new Size(530, 50);
            dpkRegistReactionTime.SkinColor = Color.WhiteSmoke;
            dpkRegistReactionTime.TabIndex = 104;
            dpkRegistReactionTime.TextColor = Color.DimGray;
            // 
            // label16
            // 
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(12, 481);
            label16.Margin = new Padding(12, 5, 0, 0);
            label16.Name = "label16";
            label16.Size = new Size(533, 41);
            label16.TabIndex = 78;
            label16.Text = "Bạn gặp phải bất kì triệu chứng nào sau 7 ngày tiêm vắc xin phòng COVID-19 không?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(rdbtnRegistYes);
            panel1.Controls.Add(rdbtnRegistNo);
            panel1.Location = new Point(3, 525);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 66);
            panel1.TabIndex = 71;
            // 
            // rdbtnRegistYes
            // 
            rdbtnRegistYes.AutoSize = true;
            rdbtnRegistYes.CheckedColor = Color.MediumSlateBlue;
            rdbtnRegistYes.Location = new Point(12, 39);
            rdbtnRegistYes.MinimumSize = new Size(0, 21);
            rdbtnRegistYes.Name = "rdbtnRegistYes";
            rdbtnRegistYes.Padding = new Padding(10, 0, 0, 0);
            rdbtnRegistYes.Size = new Size(58, 24);
            rdbtnRegistYes.TabIndex = 1;
            rdbtnRegistYes.TabStop = true;
            rdbtnRegistYes.Text = "Có";
            rdbtnRegistYes.UnCheckedColor = Color.Gray;
            rdbtnRegistYes.UseVisualStyleBackColor = true;
            // 
            // rdbtnRegistNo
            // 
            rdbtnRegistNo.AutoSize = true;
            rdbtnRegistNo.CheckedColor = Color.MediumSlateBlue;
            rdbtnRegistNo.Location = new Point(12, 6);
            rdbtnRegistNo.MinimumSize = new Size(0, 21);
            rdbtnRegistNo.Name = "rdbtnRegistNo";
            rdbtnRegistNo.Padding = new Padding(10, 0, 0, 0);
            rdbtnRegistNo.Size = new Size(83, 24);
            rdbtnRegistNo.TabIndex = 0;
            rdbtnRegistNo.TabStop = true;
            rdbtnRegistNo.Text = "Không";
            rdbtnRegistNo.UnCheckedColor = Color.Gray;
            rdbtnRegistNo.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(12, 604);
            label17.Margin = new Padding(12, 10, 0, 20);
            label17.Name = "label17";
            label17.Size = new Size(370, 20);
            label17.TabIndex = 80;
            label17.Text = "Cảm ơn bạn đã dành thời gian trả lời";
            // 
            // btnAddRegist
            // 
            btnAddRegist.BackColor = Color.DodgerBlue;
            btnAddRegist.BackgroundColor = Color.DodgerBlue;
            btnAddRegist.BorderColor = Color.PaleVioletRed;
            btnAddRegist.BorderRadius = 20;
            btnAddRegist.BorderSize = 0;
            btnAddRegist.FlatAppearance.BorderSize = 0;
            btnAddRegist.FlatStyle = FlatStyle.Flat;
            btnAddRegist.Font = new Font("Roboto", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddRegist.ForeColor = Color.White;
            btnAddRegist.Location = new Point(180, 647);
            btnAddRegist.Margin = new Padding(180, 3, 3, 3);
            btnAddRegist.Name = "btnAddRegist";
            btnAddRegist.Size = new Size(221, 44);
            btnAddRegist.TabIndex = 94;
            btnAddRegist.Text = "Xác nhận";
            btnAddRegist.TextColor = Color.White;
            btnAddRegist.UseVisualStyleBackColor = false;
            btnAddRegist.Click += btnAddRegist_Click;
            // 
            // pnlDetail
            // 
            pnlDetail.BackColor = Color.White;
            pnlDetail.BorderRadius = 50;
            pnlDetail.Controls.Add(flowLayoutPanel1);
            pnlDetail.ForeColor = Color.Black;
            pnlDetail.GradientAngIe = 90F;
            pnlDetail.GradientBottomColor = Color.White;
            pnlDetail.GradientTopColor = Color.White;
            pnlDetail.Location = new Point(294, 137);
            pnlDetail.Name = "pnlDetail";
            pnlDetail.Size = new Size(594, 491);
            pnlDetail.TabIndex = 48;
            pnlDetail.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(txtDetailTarget);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(txtDetailVaccineName);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(txtDetailInjectionDate);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(txtDetailReactionDate);
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.Controls.Add(txtDetailReactionTime);
            flowLayoutPanel1.Controls.Add(label10);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(label11);
            flowLayoutPanel1.Controls.Add(panel29);
            flowLayoutPanel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(588, 471);
            flowLayoutPanel1.TabIndex = 35;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 20);
            label3.Margin = new Padding(12, 20, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(559, 20);
            label3.TabIndex = 71;
            label3.Text = "Đối tượng tiêm";
            // 
            // txtDetailTarget
            // 
            txtDetailTarget.BackColor = SystemColors.Window;
            txtDetailTarget.BorderColor = Color.LightSlateGray;
            txtDetailTarget.BorderFocusColor = Color.HotPink;
            txtDetailTarget.BorderRadius = 0;
            txtDetailTarget.BorderSize = 2;
            txtDetailTarget.Enabled = false;
            txtDetailTarget.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetailTarget.ForeColor = Color.FromArgb(64, 64, 64);
            txtDetailTarget.Location = new Point(15, 44);
            txtDetailTarget.Margin = new Padding(15, 4, 4, 4);
            txtDetailTarget.Multiline = false;
            txtDetailTarget.Name = "txtDetailTarget";
            txtDetailTarget.Padding = new Padding(10, 7, 10, 7);
            txtDetailTarget.PasswordChar = false;
            txtDetailTarget.PlaceholderColor = Color.DarkGray;
            txtDetailTarget.PlaceholderText = "";
            txtDetailTarget.Size = new Size(536, 35);
            txtDetailTarget.TabIndex = 34;
            txtDetailTarget.Texts = "";
            txtDetailTarget.UnderlinedStyle = true;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 103);
            label6.Margin = new Padding(12, 20, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(559, 20);
            label6.TabIndex = 73;
            label6.Text = "Tên vắc xin";
            // 
            // txtDetailVaccineName
            // 
            txtDetailVaccineName.BackColor = SystemColors.Window;
            txtDetailVaccineName.BorderColor = Color.LightSlateGray;
            txtDetailVaccineName.BorderFocusColor = Color.HotPink;
            txtDetailVaccineName.BorderRadius = 0;
            txtDetailVaccineName.BorderSize = 2;
            txtDetailVaccineName.Enabled = false;
            txtDetailVaccineName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetailVaccineName.ForeColor = Color.FromArgb(64, 64, 64);
            txtDetailVaccineName.Location = new Point(15, 127);
            txtDetailVaccineName.Margin = new Padding(15, 4, 4, 4);
            txtDetailVaccineName.Multiline = false;
            txtDetailVaccineName.Name = "txtDetailVaccineName";
            txtDetailVaccineName.Padding = new Padding(10, 7, 10, 7);
            txtDetailVaccineName.PasswordChar = false;
            txtDetailVaccineName.PlaceholderColor = Color.DarkGray;
            txtDetailVaccineName.PlaceholderText = "";
            txtDetailVaccineName.Size = new Size(536, 35);
            txtDetailVaccineName.TabIndex = 72;
            txtDetailVaccineName.Texts = "";
            txtDetailVaccineName.UnderlinedStyle = true;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 186);
            label7.Margin = new Padding(12, 20, 0, 0);
            label7.Name = "label7";
            label7.Size = new Size(559, 20);
            label7.TabIndex = 75;
            label7.Text = "Ngày tiêm";
            // 
            // txtDetailInjectionDate
            // 
            txtDetailInjectionDate.BackColor = SystemColors.Window;
            txtDetailInjectionDate.BorderColor = Color.LightSlateGray;
            txtDetailInjectionDate.BorderFocusColor = Color.HotPink;
            txtDetailInjectionDate.BorderRadius = 0;
            txtDetailInjectionDate.BorderSize = 2;
            txtDetailInjectionDate.Enabled = false;
            txtDetailInjectionDate.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetailInjectionDate.ForeColor = Color.FromArgb(64, 64, 64);
            txtDetailInjectionDate.Location = new Point(15, 210);
            txtDetailInjectionDate.Margin = new Padding(15, 4, 4, 4);
            txtDetailInjectionDate.Multiline = false;
            txtDetailInjectionDate.Name = "txtDetailInjectionDate";
            txtDetailInjectionDate.Padding = new Padding(10, 7, 10, 7);
            txtDetailInjectionDate.PasswordChar = false;
            txtDetailInjectionDate.PlaceholderColor = Color.DarkGray;
            txtDetailInjectionDate.PlaceholderText = "";
            txtDetailInjectionDate.Size = new Size(536, 35);
            txtDetailInjectionDate.TabIndex = 74;
            txtDetailInjectionDate.Texts = "";
            txtDetailInjectionDate.UnderlinedStyle = true;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 269);
            label8.Margin = new Padding(12, 20, 0, 0);
            label8.Name = "label8";
            label8.Size = new Size(559, 20);
            label8.TabIndex = 77;
            label8.Text = "Ngày xảy ra phản ứng";
            // 
            // txtDetailReactionDate
            // 
            txtDetailReactionDate.BackColor = SystemColors.Window;
            txtDetailReactionDate.BorderColor = Color.LightSlateGray;
            txtDetailReactionDate.BorderFocusColor = Color.HotPink;
            txtDetailReactionDate.BorderRadius = 0;
            txtDetailReactionDate.BorderSize = 2;
            txtDetailReactionDate.Enabled = false;
            txtDetailReactionDate.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetailReactionDate.ForeColor = Color.FromArgb(64, 64, 64);
            txtDetailReactionDate.Location = new Point(15, 293);
            txtDetailReactionDate.Margin = new Padding(15, 4, 4, 4);
            txtDetailReactionDate.Multiline = false;
            txtDetailReactionDate.Name = "txtDetailReactionDate";
            txtDetailReactionDate.Padding = new Padding(10, 7, 10, 7);
            txtDetailReactionDate.PasswordChar = false;
            txtDetailReactionDate.PlaceholderColor = Color.DarkGray;
            txtDetailReactionDate.PlaceholderText = "";
            txtDetailReactionDate.Size = new Size(536, 35);
            txtDetailReactionDate.TabIndex = 76;
            txtDetailReactionDate.Texts = "";
            txtDetailReactionDate.UnderlinedStyle = true;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(12, 352);
            label9.Margin = new Padding(12, 20, 0, 0);
            label9.Name = "label9";
            label9.Size = new Size(559, 20);
            label9.TabIndex = 79;
            label9.Text = "Thời điểm xảy ra phản ứng";
            // 
            // txtDetailReactionTime
            // 
            txtDetailReactionTime.BackColor = SystemColors.Window;
            txtDetailReactionTime.BorderColor = Color.LightSlateGray;
            txtDetailReactionTime.BorderFocusColor = Color.HotPink;
            txtDetailReactionTime.BorderRadius = 0;
            txtDetailReactionTime.BorderSize = 2;
            txtDetailReactionTime.Enabled = false;
            txtDetailReactionTime.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetailReactionTime.ForeColor = Color.FromArgb(64, 64, 64);
            txtDetailReactionTime.Location = new Point(15, 376);
            txtDetailReactionTime.Margin = new Padding(15, 4, 4, 4);
            txtDetailReactionTime.Multiline = false;
            txtDetailReactionTime.Name = "txtDetailReactionTime";
            txtDetailReactionTime.Padding = new Padding(10, 7, 10, 7);
            txtDetailReactionTime.PasswordChar = false;
            txtDetailReactionTime.PlaceholderColor = Color.DarkGray;
            txtDetailReactionTime.PlaceholderText = "";
            txtDetailReactionTime.Size = new Size(536, 35);
            txtDetailReactionTime.TabIndex = 78;
            txtDetailReactionTime.Texts = "";
            txtDetailReactionTime.UnderlinedStyle = true;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(12, 435);
            label10.Margin = new Padding(12, 20, 0, 0);
            label10.Name = "label10";
            label10.Size = new Size(559, 45);
            label10.TabIndex = 80;
            label10.Text = "Bạn gặp phải bất kì triệu chứng nào sau 7 ngày tiêm vắc xin phòng COVID-19 không?";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(rdDetailYes);
            panel2.Controls.Add(rdDetailNo);
            panel2.Location = new Point(3, 483);
            panel2.Name = "panel2";
            panel2.Size = new Size(548, 66);
            panel2.TabIndex = 81;
            // 
            // rdDetailYes
            // 
            rdDetailYes.AutoSize = true;
            rdDetailYes.CheckedColor = Color.MediumSlateBlue;
            rdDetailYes.Enabled = false;
            rdDetailYes.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdDetailYes.Location = new Point(12, 39);
            rdDetailYes.MinimumSize = new Size(0, 21);
            rdDetailYes.Name = "rdDetailYes";
            rdDetailYes.Padding = new Padding(10, 0, 0, 0);
            rdDetailYes.Size = new Size(63, 26);
            rdDetailYes.TabIndex = 1;
            rdDetailYes.Text = "Có";
            rdDetailYes.UnCheckedColor = Color.Gray;
            rdDetailYes.UseVisualStyleBackColor = true;
            // 
            // rdDetailNo
            // 
            rdDetailNo.AutoSize = true;
            rdDetailNo.CheckedColor = Color.MediumSlateBlue;
            rdDetailNo.Enabled = false;
            rdDetailNo.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdDetailNo.Location = new Point(12, 6);
            rdDetailNo.MinimumSize = new Size(0, 21);
            rdDetailNo.Name = "rdDetailNo";
            rdDetailNo.Padding = new Padding(10, 0, 0, 0);
            rdDetailNo.Size = new Size(92, 26);
            rdDetailNo.TabIndex = 0;
            rdDetailNo.Text = "Không";
            rdDetailNo.UnCheckedColor = Color.Gray;
            rdDetailNo.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(12, 567);
            label11.Margin = new Padding(12, 15, 0, 0);
            label11.Name = "label11";
            label11.Size = new Size(559, 20);
            label11.TabIndex = 83;
            label11.Text = "Lời khuyên từ chuyên gia";
            // 
            // panel29
            // 
            panel29.BackgroundImage = Properties.Resources.loix;
            panel29.BackgroundImageLayout = ImageLayout.Stretch;
            panel29.Controls.Add(txtDetailAdvice);
            panel29.Location = new Point(5, 590);
            panel29.Margin = new Padding(5, 3, 4, 4);
            panel29.Name = "panel29";
            panel29.Padding = new Padding(5);
            panel29.Size = new Size(549, 117);
            panel29.TabIndex = 82;
            // 
            // txtDetailAdvice
            // 
            txtDetailAdvice.Dock = DockStyle.Fill;
            txtDetailAdvice.Enabled = false;
            txtDetailAdvice.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetailAdvice.Location = new Point(5, 5);
            txtDetailAdvice.Name = "txtDetailAdvice";
            txtDetailAdvice.Size = new Size(539, 107);
            txtDetailAdvice.TabIndex = 0;
            // 
            // lblDetail
            // 
            lblDetail.AutoSize = true;
            lblDetail.BackColor = Color.Transparent;
            lblDetail.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDetail.ForeColor = Color.Blue;
            lblDetail.Location = new Point(412, 107);
            lblDetail.Name = "lblDetail";
            lblDetail.Size = new Size(356, 28);
            lblDetail.TabIndex = 47;
            lblDetail.Text = "CHI TIẾT PHIÊU KHẢO SÁT SỐ 01";
            lblDetail.Visible = false;
            // 
            // ReactionAfterVaccination
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 640);
            Controls.Add(lblDetail);
            Controls.Add(pnlDetail);
            Controls.Add(pnlRegist);
            Controls.Add(lblRegist);
            Controls.Add(roundedPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGoBack);
            Controls.Add(upbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReactionAfterVaccination";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReactionAfterVaccination";
            Load += ReactionAfterVaccination_Load;
            upbar.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            pnlRegist.ResumeLayout(false);
            flLayoutOther.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlDetail.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel29.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnGoBack;
        private Panel upbar;
        private Button btnMinimize;
        private Button btnClose;
        private Custom.RoundedPanel roundedPanel1;
        private FlowLayoutPanel flowListRegist;
        private RJCodeAdvance.RJControls.RJButton btnOpenRegist;
        private Label lblRegist;
        private Custom.RoundedPanel pnlRegist;
        private FlowLayoutPanel flLayoutOther;
        private Label label4;
        private MaterialSkin.Controls.MaterialTextBox txtRegistTarget;
        private Label label12;
        private Label label13;
        private Panel panel1;
        private RJCodeAdvance.RJControls.RJRadioButton rdbtnRegistYes;
        private RJCodeAdvance.RJControls.RJRadioButton rdbtnRegistNo;
        private Label label5;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private RJCodeAdvance.RJControls.RJButton btnAddRegist;
        private global::CovidMangementApp.UI.Custom.RoundedPanel pnlDetail;
        private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private global::System.Windows.Forms.Label lblDetail;
        private MaterialSkin.Controls.MaterialTextBox txtRegistInjectionDate;
        private MaterialSkin.Controls.MaterialComboBox cbxRegistVaccineName;
        private RJCodeAdvance.RJControls.RJDatePicker dpkRegistReactionDate;
        private RJCodeAdvance.RJControls.RJDatePicker dpkRegistReactionTime;
        private Label label3;
        private RJCodeAdvance.RJControls.RJTextBox txtDetailTarget;
        private Label label6;
        private RJCodeAdvance.RJControls.RJTextBox txtDetailVaccineName;
        private Label label7;
        private RJCodeAdvance.RJControls.RJTextBox txtDetailInjectionDate;
        private Label label8;
        private RJCodeAdvance.RJControls.RJTextBox txtDetailReactionDate;
        private Label label9;
        private RJCodeAdvance.RJControls.RJTextBox txtDetailReactionTime;
        private Label label10;
        private Panel panel2;
        private RJCodeAdvance.RJControls.RJRadioButton rdDetailYes;
        private RJCodeAdvance.RJControls.RJRadioButton rdDetailNo;
        private Panel panel29;
        private Label txtDetailAdvice;
        private Label label11;
    }
}