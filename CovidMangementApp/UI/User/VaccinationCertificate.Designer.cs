namespace CovidMangementApp.UI.User
{
    partial class VaccinationCertificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaccinationCertificate));
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            btnGoBack = new Button();
            label1 = new Label();
            btnOpenCertificate = new RJCodeAdvance.RJControls.RJButton();
            pnlCertificate = new Custom.RoundedPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            roundedPanel2 = new Custom.RoundedPanel();
            flLayoutMain = new FlowLayoutPanel();
            label8 = new Label();
            txtName = new MaterialSkin.Controls.MaterialTextBox();
            label5 = new Label();
            txtDob = new MaterialSkin.Controls.MaterialTextBox();
            label6 = new Label();
            txtCmnd = new MaterialSkin.Controls.MaterialTextBox();
            label7 = new Label();
            txtAddress = new MaterialSkin.Controls.MaterialTextBox();
            label9 = new Label();
            flowVaccineList = new FlowLayoutPanel();
            roundedPanel3 = new Custom.RoundedPanel();
            richTextBox4 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnNoVaccine = new RJCodeAdvance.RJControls.RJButton();
            upbar.SuspendLayout();
            pnlCertificate.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            flLayoutMain.SuspendLayout();
            roundedPanel3.SuspendLayout();
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
            upbar.TabIndex = 37;
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
            btnGoBack.TabIndex = 38;
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(238, 41);
            label1.Name = "label1";
            label1.Size = new Size(427, 41);
            label1.TabIndex = 39;
            label1.Text = "CHỨNG NHẬN TIÊM NGỪA";
            // 
            // btnOpenCertificate
            // 
            btnOpenCertificate.BackColor = Color.Green;
            btnOpenCertificate.BackgroundColor = Color.Green;
            btnOpenCertificate.BorderColor = Color.PaleVioletRed;
            btnOpenCertificate.BorderRadius = 20;
            btnOpenCertificate.BorderSize = 0;
            btnOpenCertificate.FlatAppearance.BorderSize = 0;
            btnOpenCertificate.FlatStyle = FlatStyle.Flat;
            btnOpenCertificate.Font = new Font("Roboto", 34.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpenCertificate.ForeColor = Color.White;
            btnOpenCertificate.Location = new Point(12, 172);
            btnOpenCertificate.Name = "btnOpenCertificate";
            btnOpenCertificate.Size = new Size(293, 292);
            btnOpenCertificate.TabIndex = 40;
            btnOpenCertificate.Text = "ĐÃ TIÊM 04 MŨI VẮC XIN";
            btnOpenCertificate.TextColor = Color.White;
            btnOpenCertificate.UseVisualStyleBackColor = false;
            btnOpenCertificate.Visible = false;
            btnOpenCertificate.Click += btnOpenCertificate_Click;
            // 
            // pnlCertificate
            // 
            pnlCertificate.BackColor = Color.White;
            pnlCertificate.BorderRadius = 40;
            pnlCertificate.Controls.Add(flowLayoutPanel1);
            pnlCertificate.Controls.Add(label4);
            pnlCertificate.Controls.Add(label3);
            pnlCertificate.Controls.Add(label2);
            pnlCertificate.ForeColor = Color.Black;
            pnlCertificate.GradientAngIe = 90F;
            pnlCertificate.GradientBottomColor = Color.ForestGreen;
            pnlCertificate.GradientTopColor = Color.ForestGreen;
            pnlCertificate.Location = new Point(317, 89);
            pnlCertificate.Name = "pnlCertificate";
            pnlCertificate.Size = new Size(569, 539);
            pnlCertificate.TabIndex = 41;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(roundedPanel2);
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.Controls.Add(flowVaccineList);
            flowLayoutPanel1.Controls.Add(roundedPanel3);
            flowLayoutPanel1.Location = new Point(3, 133);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(566, 403);
            flowLayoutPanel1.TabIndex = 35;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BorderRadius = 30;
            roundedPanel2.Controls.Add(flLayoutMain);
            roundedPanel2.ForeColor = Color.Black;
            roundedPanel2.GradientAngIe = 90F;
            roundedPanel2.GradientBottomColor = Color.White;
            roundedPanel2.GradientTopColor = Color.White;
            roundedPanel2.Location = new Point(54, 3);
            roundedPanel2.Margin = new Padding(54, 3, 3, 3);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(459, 341);
            roundedPanel2.TabIndex = 4;
            // 
            // flLayoutMain
            // 
            flLayoutMain.AutoScroll = true;
            flLayoutMain.BackColor = Color.White;
            flLayoutMain.Controls.Add(label8);
            flLayoutMain.Controls.Add(txtName);
            flLayoutMain.Controls.Add(label5);
            flLayoutMain.Controls.Add(txtDob);
            flLayoutMain.Controls.Add(label6);
            flLayoutMain.Controls.Add(txtCmnd);
            flLayoutMain.Controls.Add(label7);
            flLayoutMain.Controls.Add(txtAddress);
            flLayoutMain.Location = new Point(3, 3);
            flLayoutMain.Name = "flLayoutMain";
            flLayoutMain.Size = new Size(453, 338);
            flLayoutMain.TabIndex = 34;
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
            label8.Size = new Size(84, 20);
            label8.TabIndex = 34;
            label8.Text = "Họ và tên:";
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
            txtName.ReadOnly = true;
            txtName.Size = new Size(426, 50);
            txtName.TabIndex = 10;
            txtName.Text = "";
            txtName.TrailingIcon = null;
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
            label5.Size = new Size(176, 20);
            label5.TabIndex = 36;
            label5.Text = "Ngày, tháng, năm sinh:";
            // 
            // txtDob
            // 
            txtDob.AnimateReadOnly = false;
            txtDob.BorderStyle = BorderStyle.None;
            txtDob.Depth = 0;
            txtDob.Enabled = false;
            txtDob.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDob.LeadingIcon = null;
            txtDob.Location = new Point(3, 109);
            txtDob.MaxLength = 50;
            txtDob.MouseState = MaterialSkin.MouseState.OUT;
            txtDob.Multiline = false;
            txtDob.Name = "txtDob";
            txtDob.ReadOnly = true;
            txtDob.Size = new Size(426, 50);
            txtDob.TabIndex = 35;
            txtDob.Text = "";
            txtDob.TrailingIcon = null;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 167);
            label6.Margin = new Padding(12, 5, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(207, 20);
            label6.TabIndex = 38;
            label6.Text = "Số hộ chiếu/CMND/CCCD:";
            // 
            // txtCmnd
            // 
            txtCmnd.AnimateReadOnly = false;
            txtCmnd.BorderStyle = BorderStyle.None;
            txtCmnd.Depth = 0;
            txtCmnd.Enabled = false;
            txtCmnd.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCmnd.LeadingIcon = null;
            txtCmnd.Location = new Point(3, 190);
            txtCmnd.MaxLength = 50;
            txtCmnd.MouseState = MaterialSkin.MouseState.OUT;
            txtCmnd.Multiline = false;
            txtCmnd.Name = "txtCmnd";
            txtCmnd.ReadOnly = true;
            txtCmnd.Size = new Size(426, 50);
            txtCmnd.TabIndex = 37;
            txtCmnd.Text = "";
            txtCmnd.TrailingIcon = null;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 248);
            label7.Margin = new Padding(12, 5, 0, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 40;
            label7.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            txtAddress.AnimateReadOnly = false;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Depth = 0;
            txtAddress.Enabled = false;
            txtAddress.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddress.LeadingIcon = null;
            txtAddress.Location = new Point(3, 271);
            txtAddress.MaxLength = 50;
            txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtAddress.Multiline = false;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(426, 50);
            txtAddress.TabIndex = 39;
            txtAddress.Text = "";
            txtAddress.TrailingIcon = null;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(55, 367);
            label9.Margin = new Padding(55, 20, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(431, 27);
            label9.TabIndex = 5;
            label9.Text = "Đã được tiêm vắc xin phòng bệnh Covid-19:";
            // 
            // flowVaccineList
            // 
            flowVaccineList.AutoSize = true;
            flowVaccineList.BackColor = Color.Transparent;
            flowVaccineList.Location = new Point(543, 367);
            flowVaccineList.Margin = new Padding(54, 20, 3, 3);
            flowVaccineList.Name = "flowVaccineList";
            flowVaccineList.Size = new Size(0, 0);
            flowVaccineList.TabIndex = 35;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.White;
            roundedPanel3.BorderRadius = 30;
            roundedPanel3.Controls.Add(richTextBox4);
            roundedPanel3.Controls.Add(richTextBox3);
            roundedPanel3.Controls.Add(richTextBox2);
            roundedPanel3.Controls.Add(richTextBox1);
            roundedPanel3.ForeColor = Color.Black;
            roundedPanel3.GradientAngIe = 90F;
            roundedPanel3.GradientBottomColor = Color.White;
            roundedPanel3.GradientTopColor = Color.White;
            roundedPanel3.Location = new Point(54, 404);
            roundedPanel3.Margin = new Padding(54, 10, 3, 3);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(459, 583);
            roundedPanel3.TabIndex = 6;
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.White;
            richTextBox4.BorderStyle = BorderStyle.None;
            richTextBox4.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox4.Location = new Point(0, 459);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ReadOnly = true;
            richTextBox4.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox4.Size = new Size(459, 121);
            richTextBox4.TabIndex = 4;
            richTextBox4.Text = "Sau khi tiêm vắc xin vẫn phải thực hiện các biện pháp phòng chống dịch COVID-19 - thông điệp 5K: \"Khẩu trang - Khử khuẩn - Khoảng cách - Không tập trung - Khai báo y tế\"";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.White;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Location = new Point(0, 314);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox3.Size = new Size(459, 121);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.White;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(0, 218);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox2.Size = new Size(459, 77);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "Phản ứng thông thường: Đau đầu, buồn nôn, đau cơ, đau khớp, sưng nóng tại vị trí tiêm, ngứa, mệt mỏi, bồn chồn, sốt trên 38 độ C, ớn lạnh.";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(1, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(459, 195);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(22, 89);
            label4.Name = "label4";
            label4.Size = new Size(529, 27);
            label4.TabIndex = 2;
            label4.Text = "GIẤY XÁC NHẬN ĐÃ TIÊM VẮC XIN PHÒNG COVID-19";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(160, 29);
            label3.Name = "label3";
            label3.Size = new Size(253, 24);
            label3.TabIndex = 1;
            label3.Text = "Độc lập - Tự do - Hạnh phúc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(93, 3);
            label2.Name = "label2";
            label2.Size = new Size(385, 24);
            label2.TabIndex = 0;
            label2.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
            // 
            // btnNoVaccine
            // 
            btnNoVaccine.BackColor = Color.DarkSalmon;
            btnNoVaccine.BackgroundColor = Color.DarkSalmon;
            btnNoVaccine.BorderColor = Color.PaleVioletRed;
            btnNoVaccine.BorderRadius = 20;
            btnNoVaccine.BorderSize = 0;
            btnNoVaccine.FlatAppearance.BorderSize = 0;
            btnNoVaccine.FlatStyle = FlatStyle.Flat;
            btnNoVaccine.Font = new Font("Roboto", 34.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnNoVaccine.ForeColor = Color.White;
            btnNoVaccine.Location = new Point(12, 172);
            btnNoVaccine.Name = "btnNoVaccine";
            btnNoVaccine.Size = new Size(293, 292);
            btnNoVaccine.TabIndex = 42;
            btnNoVaccine.Text = "CHƯA ĐƯỢC TIÊM VẮC XIN";
            btnNoVaccine.TextColor = Color.White;
            btnNoVaccine.UseVisualStyleBackColor = false;
            btnNoVaccine.Visible = false;
            // 
            // VaccinationCertificate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 640);
            Controls.Add(pnlCertificate);
            Controls.Add(btnOpenCertificate);
            Controls.Add(btnNoVaccine);
            Controls.Add(label1);
            Controls.Add(btnGoBack);
            Controls.Add(upbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VaccinationCertificate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VaccinationCertificate";
            Load += VaccinationCertificate_Load;
            upbar.ResumeLayout(false);
            pnlCertificate.ResumeLayout(false);
            pnlCertificate.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            flLayoutMain.ResumeLayout(false);
            flLayoutMain.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel upbar;
        private Button btnMinimize;
        private Button btnClose;
        private Button btnGoBack;
        private Label label1;
        private RJCodeAdvance.RJControls.RJButton btnOpenCertificate;
        private Custom.RoundedPanel pnlCertificate;
        private Label label2;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Custom.RoundedPanel roundedPanel2;
        private FlowLayoutPanel flLayoutMain;
        private Label label8;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private Label label5;
        private MaterialSkin.Controls.MaterialTextBox txtDob;
        private Label label6;
        private MaterialSkin.Controls.MaterialTextBox txtCmnd;
        private Label label7;
        private MaterialSkin.Controls.MaterialTextBox txtAddress;
        private Label label9;
        private Custom.RoundedPanel roundedPanel3;
        private RichTextBox richTextBox1;
        private FlowLayoutPanel flowVaccineList;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private RJCodeAdvance.RJControls.RJButton btnNoVaccine;
    }
}