namespace CovidMangementApp.UI.Staff
{
    partial class ResponseReactionAfterVaccination
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
            txtDetailAdvice = new TextBox();
            btnUpdate = new RJCodeAdvance.RJControls.RJButton();
            lblDetail = new Label();
            upbar.SuspendLayout();
            roundedPanel1.SuspendLayout();
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
            label1.Location = new Point(300, 41);
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
            flowListRegist.Location = new Point(3, 11);
            flowListRegist.Name = "flowListRegist";
            flowListRegist.Size = new Size(263, 455);
            flowListRegist.TabIndex = 38;
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
            flowLayoutPanel1.Controls.Add(btnUpdate);
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
            txtDetailAdvice.BorderStyle = BorderStyle.None;
            txtDetailAdvice.Dock = DockStyle.Fill;
            txtDetailAdvice.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetailAdvice.Location = new Point(5, 5);
            txtDetailAdvice.Multiline = true;
            txtDetailAdvice.Name = "txtDetailAdvice";
            txtDetailAdvice.Size = new Size(539, 107);
            txtDetailAdvice.TabIndex = 0;
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
            btnUpdate.Location = new Point(135, 721);
            btnUpdate.Margin = new Padding(135, 10, 3, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(300, 50);
            btnUpdate.TabIndex = 84;
            btnUpdate.Text = "Xác nhận thành công";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
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
            // ResponseReactionAfterVaccination
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 640);
            Controls.Add(lblDetail);
            Controls.Add(pnlDetail);
            Controls.Add(roundedPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGoBack);
            Controls.Add(upbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResponseReactionAfterVaccination";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResponseReactionAfterVaccination";
            Load += ResponseReactionAfterVaccination_Load;
            upbar.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            pnlDetail.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel29.ResumeLayout(false);
            panel29.PerformLayout();
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
        private global::CovidMangementApp.UI.Custom.RoundedPanel pnlDetail;
        private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private global::System.Windows.Forms.Label lblDetail;
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
        private Label label11;
        private RJCodeAdvance.RJControls.RJButton btnUpdate;
        private TextBox txtDetailAdvice;
    }
}