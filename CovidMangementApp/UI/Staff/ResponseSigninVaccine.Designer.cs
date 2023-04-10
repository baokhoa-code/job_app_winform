using System.Runtime.Intrinsics.Arm;

namespace CovidMangementApp.UI.Staff
{
    partial class ResponseSigninVaccine
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
            txtDetailName = new MaterialSkin.Controls.MaterialTextBox();
            txtDetailDob = new MaterialSkin.Controls.MaterialTextBox();
            txtDetailGender = new MaterialSkin.Controls.MaterialTextBox();
            txtDetailCmnd = new MaterialSkin.Controls.MaterialTextBox();
            txtDetailBhyt = new MaterialSkin.Controls.MaterialTextBox();
            txtDetailDateDesire = new MaterialSkin.Controls.MaterialTextBox();
            txtDetailCity = new MaterialSkin.Controls.MaterialTextBox();
            txtDetailDistrict = new MaterialSkin.Controls.MaterialTextBox();
            txtDetailWard = new MaterialSkin.Controls.MaterialTextBox();
            txtDetailAddress = new MaterialSkin.Controls.MaterialTextBox();
            btnConfirm = new RJCodeAdvance.RJControls.RJButton();
            lblDetail = new Label();
            upbar.SuspendLayout();
            roundedPanel1.SuspendLayout();
            pnlDetail.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 107);
            label2.Name = "label2";
            label2.Size = new Size(253, 24);
            label2.TabIndex = 43;
            label2.Text = "Lịch sử đăng ký tiêm chủng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(267, 41);
            label1.Name = "label1";
            label1.Size = new Size(372, 41);
            label1.TabIndex = 42;
            label1.Text = "ĐĂNG KÝ TIÊM CHỦNG";
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
            flowListRegist.Location = new Point(3, 13);
            flowListRegist.Name = "flowListRegist";
            flowListRegist.Size = new Size(263, 453);
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
            flowLayoutPanel1.Controls.Add(txtDetailName);
            flowLayoutPanel1.Controls.Add(txtDetailDob);
            flowLayoutPanel1.Controls.Add(txtDetailGender);
            flowLayoutPanel1.Controls.Add(txtDetailCmnd);
            flowLayoutPanel1.Controls.Add(txtDetailBhyt);
            flowLayoutPanel1.Controls.Add(txtDetailDateDesire);
            flowLayoutPanel1.Controls.Add(txtDetailCity);
            flowLayoutPanel1.Controls.Add(txtDetailDistrict);
            flowLayoutPanel1.Controls.Add(txtDetailWard);
            flowLayoutPanel1.Controls.Add(txtDetailAddress);
            flowLayoutPanel1.Controls.Add(btnConfirm);
            flowLayoutPanel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(588, 471);
            flowLayoutPanel1.TabIndex = 35;
            // 
            // txtDetailName
            // 
            txtDetailName.AnimateReadOnly = false;
            txtDetailName.BackColor = Color.White;
            txtDetailName.BorderStyle = BorderStyle.None;
            txtDetailName.Depth = 0;
            txtDetailName.Enabled = false;
            txtDetailName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDetailName.Hint = "Người tới tiêm";
            txtDetailName.LeadingIcon = Properties.Resources.user;
            txtDetailName.Location = new Point(15, 15);
            txtDetailName.Margin = new Padding(15, 15, 3, 3);
            txtDetailName.MaxLength = 60;
            txtDetailName.MouseState = MaterialSkin.MouseState.OUT;
            txtDetailName.Multiline = false;
            txtDetailName.Name = "txtDetailName";
            txtDetailName.Size = new Size(536, 50);
            txtDetailName.TabIndex = 74;
            txtDetailName.Text = "";
            txtDetailName.TrailingIcon = null;
            // 
            // txtDetailDob
            // 
            txtDetailDob.AnimateReadOnly = false;
            txtDetailDob.BackColor = Color.White;
            txtDetailDob.BorderStyle = BorderStyle.None;
            txtDetailDob.Depth = 0;
            txtDetailDob.Enabled = false;
            txtDetailDob.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDetailDob.Hint = "Ngày tháng năm sinh";
            txtDetailDob.LeadingIcon = Properties.Resources.calendar1;
            txtDetailDob.Location = new Point(15, 83);
            txtDetailDob.Margin = new Padding(15, 15, 3, 3);
            txtDetailDob.MaxLength = 50;
            txtDetailDob.MouseState = MaterialSkin.MouseState.OUT;
            txtDetailDob.Multiline = false;
            txtDetailDob.Name = "txtDetailDob";
            txtDetailDob.Size = new Size(536, 50);
            txtDetailDob.TabIndex = 75;
            txtDetailDob.Text = "";
            txtDetailDob.TrailingIcon = null;
            // 
            // txtDetailGender
            // 
            txtDetailGender.AnimateReadOnly = false;
            txtDetailGender.BackColor = Color.White;
            txtDetailGender.BorderStyle = BorderStyle.None;
            txtDetailGender.Depth = 0;
            txtDetailGender.Enabled = false;
            txtDetailGender.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDetailGender.Hint = "Giới tính";
            txtDetailGender.LeadingIcon = Properties.Resources.genders;
            txtDetailGender.Location = new Point(15, 151);
            txtDetailGender.Margin = new Padding(15, 15, 3, 3);
            txtDetailGender.MaxLength = 50;
            txtDetailGender.MouseState = MaterialSkin.MouseState.OUT;
            txtDetailGender.Multiline = false;
            txtDetailGender.Name = "txtDetailGender";
            txtDetailGender.Size = new Size(536, 50);
            txtDetailGender.TabIndex = 76;
            txtDetailGender.Text = "";
            txtDetailGender.TrailingIcon = null;
            // 
            // txtDetailCmnd
            // 
            txtDetailCmnd.AnimateReadOnly = false;
            txtDetailCmnd.BackColor = Color.White;
            txtDetailCmnd.BorderStyle = BorderStyle.None;
            txtDetailCmnd.Depth = 0;
            txtDetailCmnd.Enabled = false;
            txtDetailCmnd.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDetailCmnd.Hint = "Số hộ chiếu/CMND/CCCD";
            txtDetailCmnd.LeadingIcon = Properties.Resources.id_card;
            txtDetailCmnd.Location = new Point(15, 219);
            txtDetailCmnd.Margin = new Padding(15, 15, 3, 3);
            txtDetailCmnd.MaxLength = 50;
            txtDetailCmnd.MouseState = MaterialSkin.MouseState.OUT;
            txtDetailCmnd.Multiline = false;
            txtDetailCmnd.Name = "txtDetailCmnd";
            txtDetailCmnd.Size = new Size(536, 50);
            txtDetailCmnd.TabIndex = 77;
            txtDetailCmnd.Text = "";
            txtDetailCmnd.TrailingIcon = null;
            // 
            // txtDetailBhyt
            // 
            txtDetailBhyt.AnimateReadOnly = false;
            txtDetailBhyt.BackColor = Color.White;
            txtDetailBhyt.BorderStyle = BorderStyle.None;
            txtDetailBhyt.Depth = 0;
            txtDetailBhyt.Enabled = false;
            txtDetailBhyt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDetailBhyt.Hint = "Số thẻ BHYT";
            txtDetailBhyt.LeadingIcon = Properties.Resources.barcode;
            txtDetailBhyt.Location = new Point(15, 287);
            txtDetailBhyt.Margin = new Padding(15, 15, 3, 3);
            txtDetailBhyt.MaxLength = 60;
            txtDetailBhyt.MouseState = MaterialSkin.MouseState.OUT;
            txtDetailBhyt.Multiline = false;
            txtDetailBhyt.Name = "txtDetailBhyt";
            txtDetailBhyt.Size = new Size(536, 50);
            txtDetailBhyt.TabIndex = 78;
            txtDetailBhyt.Text = "";
            txtDetailBhyt.TrailingIcon = null;
            // 
            // txtDetailDateDesire
            // 
            txtDetailDateDesire.AnimateReadOnly = false;
            txtDetailDateDesire.BackColor = Color.White;
            txtDetailDateDesire.BorderStyle = BorderStyle.None;
            txtDetailDateDesire.Depth = 0;
            txtDetailDateDesire.Enabled = false;
            txtDetailDateDesire.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDetailDateDesire.Hint = "Thời gian mong muốn tiêm (*)";
            txtDetailDateDesire.LeadingIcon = Properties.Resources.calendar1;
            txtDetailDateDesire.Location = new Point(15, 355);
            txtDetailDateDesire.Margin = new Padding(15, 15, 3, 3);
            txtDetailDateDesire.MaxLength = 50;
            txtDetailDateDesire.MouseState = MaterialSkin.MouseState.OUT;
            txtDetailDateDesire.Multiline = false;
            txtDetailDateDesire.Name = "txtDetailDateDesire";
            txtDetailDateDesire.Size = new Size(536, 50);
            txtDetailDateDesire.TabIndex = 79;
            txtDetailDateDesire.Text = "";
            txtDetailDateDesire.TrailingIcon = null;
            // 
            // txtDetailCity
            // 
            txtDetailCity.AnimateReadOnly = false;
            txtDetailCity.BackColor = Color.White;
            txtDetailCity.BorderStyle = BorderStyle.None;
            txtDetailCity.Depth = 0;
            txtDetailCity.Enabled = false;
            txtDetailCity.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDetailCity.Hint = "Tỉnh/Thành phố";
            txtDetailCity.LeadingIcon = Properties.Resources.location_pin;
            txtDetailCity.Location = new Point(15, 423);
            txtDetailCity.Margin = new Padding(15, 15, 3, 3);
            txtDetailCity.MaxLength = 50;
            txtDetailCity.MouseState = MaterialSkin.MouseState.OUT;
            txtDetailCity.Multiline = false;
            txtDetailCity.Name = "txtDetailCity";
            txtDetailCity.Size = new Size(536, 50);
            txtDetailCity.TabIndex = 80;
            txtDetailCity.Text = "";
            txtDetailCity.TrailingIcon = null;
            // 
            // txtDetailDistrict
            // 
            txtDetailDistrict.AnimateReadOnly = false;
            txtDetailDistrict.BackColor = Color.White;
            txtDetailDistrict.BorderStyle = BorderStyle.None;
            txtDetailDistrict.Depth = 0;
            txtDetailDistrict.Enabled = false;
            txtDetailDistrict.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDetailDistrict.Hint = "Quận/Huyện";
            txtDetailDistrict.LeadingIcon = Properties.Resources.location_pin;
            txtDetailDistrict.Location = new Point(15, 491);
            txtDetailDistrict.Margin = new Padding(15, 15, 3, 3);
            txtDetailDistrict.MaxLength = 50;
            txtDetailDistrict.MouseState = MaterialSkin.MouseState.OUT;
            txtDetailDistrict.Multiline = false;
            txtDetailDistrict.Name = "txtDetailDistrict";
            txtDetailDistrict.Size = new Size(536, 50);
            txtDetailDistrict.TabIndex = 81;
            txtDetailDistrict.Text = "";
            txtDetailDistrict.TrailingIcon = null;
            // 
            // txtDetailWard
            // 
            txtDetailWard.AnimateReadOnly = false;
            txtDetailWard.BackColor = Color.White;
            txtDetailWard.BorderStyle = BorderStyle.None;
            txtDetailWard.Depth = 0;
            txtDetailWard.Enabled = false;
            txtDetailWard.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDetailWard.Hint = "Phường/Xã";
            txtDetailWard.LeadingIcon = Properties.Resources.location_pin;
            txtDetailWard.Location = new Point(15, 559);
            txtDetailWard.Margin = new Padding(15, 15, 3, 3);
            txtDetailWard.MaxLength = 60;
            txtDetailWard.MouseState = MaterialSkin.MouseState.OUT;
            txtDetailWard.Multiline = false;
            txtDetailWard.Name = "txtDetailWard";
            txtDetailWard.Size = new Size(536, 50);
            txtDetailWard.TabIndex = 82;
            txtDetailWard.Text = "";
            txtDetailWard.TrailingIcon = null;
            // 
            // txtDetailAddress
            // 
            txtDetailAddress.AnimateReadOnly = false;
            txtDetailAddress.BackColor = Color.White;
            txtDetailAddress.BorderStyle = BorderStyle.None;
            txtDetailAddress.Depth = 0;
            txtDetailAddress.Enabled = false;
            txtDetailAddress.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDetailAddress.Hint = " Địa chỉ nơi ở";
            txtDetailAddress.LeadingIcon = Properties.Resources.location_pin;
            txtDetailAddress.Location = new Point(15, 627);
            txtDetailAddress.Margin = new Padding(15, 15, 3, 3);
            txtDetailAddress.MaxLength = 50;
            txtDetailAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtDetailAddress.Multiline = false;
            txtDetailAddress.Name = "txtDetailAddress";
            txtDetailAddress.Size = new Size(536, 50);
            txtDetailAddress.TabIndex = 83;
            txtDetailAddress.Text = "";
            txtDetailAddress.TrailingIcon = null;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.DodgerBlue;
            btnConfirm.BackgroundColor = Color.DodgerBlue;
            btnConfirm.BorderColor = Color.PaleVioletRed;
            btnConfirm.BorderRadius = 20;
            btnConfirm.BorderSize = 0;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Roboto", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(180, 683);
            btnConfirm.Margin = new Padding(180, 3, 3, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(221, 44);
            btnConfirm.TabIndex = 95;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.TextColor = Color.White;
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblDetail
            // 
            lblDetail.AutoSize = true;
            lblDetail.BackColor = Color.Transparent;
            lblDetail.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDetail.ForeColor = Color.Blue;
            lblDetail.Location = new Point(380, 107);
            lblDetail.Name = "lblDetail";
            lblDetail.Size = new Size(422, 28);
            lblDetail.TabIndex = 47;
            lblDetail.Text = "CHI TIẾT LỊCH SỬ ĐĂNG KÝ TIÊM SỐ 01";
            lblDetail.Visible = false;
            // 
            // ResponseSigninVaccine
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
            Name = "ResponseSigninVaccine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResponseSigninVaccine";
            Load += ResponseSigninVaccine_Load;
            upbar.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            pnlDetail.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialTextBox txtDetailName;
        private MaterialSkin.Controls.MaterialTextBox txtDetailDob;
        private MaterialSkin.Controls.MaterialTextBox txtDetailGender;
        private MaterialSkin.Controls.MaterialTextBox txtDetailCmnd;
        private MaterialSkin.Controls.MaterialTextBox txtDetailBhyt;
        private MaterialSkin.Controls.MaterialTextBox txtDetailDateDesire;
        private MaterialSkin.Controls.MaterialTextBox txtDetailCity;
        private MaterialSkin.Controls.MaterialTextBox txtDetailDistrict;
        private MaterialSkin.Controls.MaterialTextBox txtDetailWard;
        private MaterialSkin.Controls.MaterialTextBox txtDetailAddress;
        private RJCodeAdvance.RJControls.RJButton btnConfirm;
    }
}