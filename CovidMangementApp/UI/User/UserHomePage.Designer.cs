namespace CovidMangementApp.UI.User
{
    partial class UserHomePage
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
            components = new System.ComponentModel.Container();
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            drpdMenu = new RJCodeAdvance.RJControls.RJDropdownMenu(components);
            btnAccountInfo = new ToolStripMenuItem();
            btnChangePassword = new ToolStripMenuItem();
            btnChangeAnswer = new ToolStripMenuItem();
            btnLogout = new ToolStripMenuItem();
            label2 = new Label();
            btnMenu = new Button();
            btnGoMedicalDeclare = new Button();
            label1 = new Label();
            label3 = new Label();
            btnGoVaccineCert = new Button();
            label4 = new Label();
            btnGoSignVaccine = new Button();
            label5 = new Label();
            btnGoHandBook = new Button();
            label6 = new Label();
            btnGoAnamnesis = new Button();
            label7 = new Label();
            btnGoReactionAfterVaccine = new Button();
            label8 = new Label();
            txtName = new Label();
            upbar.SuspendLayout();
            drpdMenu.SuspendLayout();
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
            upbar.TabIndex = 31;
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
            // drpdMenu
            // 
            drpdMenu.BackColor = Color.LightBlue;
            drpdMenu.BackgroundImageLayout = ImageLayout.Stretch;
            drpdMenu.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            drpdMenu.ImageScalingSize = new Size(20, 20);
            drpdMenu.IsMainMenu = false;
            drpdMenu.Items.AddRange(new ToolStripItem[] { btnAccountInfo, btnChangePassword, btnChangeAnswer, btnLogout });
            drpdMenu.Margin = new Padding(0, 10, 0, 10);
            drpdMenu.MenuItemHeight = 25;
            drpdMenu.MenuItemTextColor = Color.Empty;
            drpdMenu.Name = "rjDropdownMenu1";
            drpdMenu.PrimaryColor = Color.Empty;
            drpdMenu.Size = new Size(336, 116);
            // 
            // btnAccountInfo
            // 
            btnAccountInfo.Image = Properties.Resources.info;
            btnAccountInfo.Name = "btnAccountInfo";
            btnAccountInfo.Size = new Size(335, 28);
            btnAccountInfo.Text = "Thông tin tài khoản";
            btnAccountInfo.Click += btnAccountInfo_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Image = Properties.Resources.padlock;
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(335, 28);
            btnChangePassword.Text = "Thay đổi mật khẩu";
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnChangeAnswer
            // 
            btnChangeAnswer.Image = Properties.Resources.question;
            btnChangeAnswer.Name = "btnChangeAnswer";
            btnChangeAnswer.Size = new Size(335, 28);
            btnChangeAnswer.Text = "Thay đổi câu trả lời đặc biệt";
            btnChangeAnswer.Click += btnChangeAnswer_Click;
            // 
            // btnLogout
            // 
            btnLogout.Image = Properties.Resources.log_out;
            btnLogout.ImageTransparentColor = Color.Transparent;
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(335, 28);
            btnLogout.Text = "Đăng xuất";
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Chocolate;
            label2.Location = new Point(15, 43);
            label2.Name = "label2";
            label2.Size = new Size(133, 35);
            label2.TabIndex = 33;
            label2.Text = "Xin chào,";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.BackgroundImage = Properties.Resources.account;
            btnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(810, 43);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(80, 54);
            btnMenu.TabIndex = 34;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnGoMedicalDeclare
            // 
            btnGoMedicalDeclare.BackColor = Color.Transparent;
            btnGoMedicalDeclare.BackgroundImage = Properties.Resources.medical_declaration8;
            btnGoMedicalDeclare.BackgroundImageLayout = ImageLayout.Zoom;
            btnGoMedicalDeclare.FlatAppearance.BorderSize = 0;
            btnGoMedicalDeclare.FlatStyle = FlatStyle.Flat;
            btnGoMedicalDeclare.Location = new Point(15, 163);
            btnGoMedicalDeclare.Name = "btnGoMedicalDeclare";
            btnGoMedicalDeclare.Size = new Size(260, 160);
            btnGoMedicalDeclare.TabIndex = 35;
            btnGoMedicalDeclare.UseVisualStyleBackColor = false;
            btnGoMedicalDeclare.Click += btnGoMedicalDeclare_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(82, 326);
            label1.Name = "label1";
            label1.Size = new Size(125, 24);
            label1.TabIndex = 36;
            label1.Text = "Khai báo y tế";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(335, 326);
            label3.Name = "label3";
            label3.Size = new Size(213, 24);
            label3.TabIndex = 38;
            label3.Text = "Chứng nhận tiêm ngừa";
            // 
            // btnGoVaccineCert
            // 
            btnGoVaccineCert.BackColor = Color.Transparent;
            btnGoVaccineCert.BackgroundImage = Properties.Resources.vaccination_certificate;
            btnGoVaccineCert.BackgroundImageLayout = ImageLayout.Zoom;
            btnGoVaccineCert.FlatAppearance.BorderSize = 0;
            btnGoVaccineCert.FlatStyle = FlatStyle.Flat;
            btnGoVaccineCert.Location = new Point(310, 163);
            btnGoVaccineCert.Name = "btnGoVaccineCert";
            btnGoVaccineCert.Size = new Size(260, 160);
            btnGoVaccineCert.TabIndex = 37;
            btnGoVaccineCert.UseVisualStyleBackColor = false;
            btnGoVaccineCert.Click += btnGoVaccineCert_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(647, 326);
            label4.Name = "label4";
            label4.Size = new Size(185, 24);
            label4.TabIndex = 40;
            label4.Text = "Đăng ký tiêm chủng";
            // 
            // btnGoSignVaccine
            // 
            btnGoSignVaccine.BackColor = Color.Transparent;
            btnGoSignVaccine.BackgroundImage = Properties.Resources.signin_vaccine;
            btnGoSignVaccine.BackgroundImageLayout = ImageLayout.Zoom;
            btnGoSignVaccine.FlatAppearance.BorderSize = 0;
            btnGoSignVaccine.FlatStyle = FlatStyle.Flat;
            btnGoSignVaccine.Location = new Point(608, 163);
            btnGoSignVaccine.Name = "btnGoSignVaccine";
            btnGoSignVaccine.Size = new Size(260, 160);
            btnGoSignVaccine.TabIndex = 39;
            btnGoSignVaccine.UseVisualStyleBackColor = false;
            btnGoSignVaccine.Click += btnGoSignVaccine_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(664, 563);
            label5.Name = "label5";
            label5.Size = new Size(138, 24);
            label5.TabIndex = 46;
            label5.Text = "Cẩm nang y tế";
            // 
            // btnGoHandBook
            // 
            btnGoHandBook.BackColor = Color.Transparent;
            btnGoHandBook.BackgroundImage = Properties.Resources.medical_handbook;
            btnGoHandBook.BackgroundImageLayout = ImageLayout.Zoom;
            btnGoHandBook.FlatAppearance.BorderSize = 0;
            btnGoHandBook.FlatStyle = FlatStyle.Flat;
            btnGoHandBook.Location = new Point(608, 400);
            btnGoHandBook.Name = "btnGoHandBook";
            btnGoHandBook.Size = new Size(260, 160);
            btnGoHandBook.TabIndex = 45;
            btnGoHandBook.UseVisualStyleBackColor = false;
            btnGoHandBook.Click += btnGoHandBook_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(369, 563);
            label6.Name = "label6";
            label6.Size = new Size(146, 24);
            label6.TabIndex = 44;
            label6.Text = "Hồ sơ sức khỏe";
            // 
            // btnGoAnamnesis
            // 
            btnGoAnamnesis.BackColor = Color.Transparent;
            btnGoAnamnesis.BackgroundImage = Properties.Resources.anamnesis;
            btnGoAnamnesis.BackgroundImageLayout = ImageLayout.Zoom;
            btnGoAnamnesis.FlatAppearance.BorderSize = 0;
            btnGoAnamnesis.FlatStyle = FlatStyle.Flat;
            btnGoAnamnesis.Location = new Point(310, 400);
            btnGoAnamnesis.Name = "btnGoAnamnesis";
            btnGoAnamnesis.Size = new Size(260, 160);
            btnGoAnamnesis.TabIndex = 43;
            btnGoAnamnesis.UseVisualStyleBackColor = false;
            btnGoAnamnesis.Click += btnGoAnamnesis_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(57, 563);
            label7.Name = "label7";
            label7.Size = new Size(178, 24);
            label7.TabIndex = 42;
            label7.Text = "Phản ứng sau tiêm";
            // 
            // btnGoReactionAfterVaccine
            // 
            btnGoReactionAfterVaccine.BackColor = Color.Transparent;
            btnGoReactionAfterVaccine.BackgroundImage = Properties.Resources.reaction_after_vaccination;
            btnGoReactionAfterVaccine.BackgroundImageLayout = ImageLayout.Zoom;
            btnGoReactionAfterVaccine.FlatAppearance.BorderSize = 0;
            btnGoReactionAfterVaccine.FlatStyle = FlatStyle.Flat;
            btnGoReactionAfterVaccine.Location = new Point(15, 400);
            btnGoReactionAfterVaccine.Name = "btnGoReactionAfterVaccine";
            btnGoReactionAfterVaccine.Size = new Size(260, 160);
            btnGoReactionAfterVaccine.TabIndex = 41;
            btnGoReactionAfterVaccine.UseVisualStyleBackColor = false;
            btnGoReactionAfterVaccine.Click += btnGoReactionAfterVaccine_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Roboto", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(15, 95);
            label8.Name = "label8";
            label8.Size = new Size(0, 35);
            label8.TabIndex = 47;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.BackColor = Color.Transparent;
            txtName.Font = new Font("Roboto", 21F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.ForeColor = Color.ForestGreen;
            txtName.Location = new Point(15, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(0, 42);
            txtName.TabIndex = 48;
            // 
            // UserHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 640);
            Controls.Add(txtName);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(btnGoHandBook);
            Controls.Add(label6);
            Controls.Add(btnGoAnamnesis);
            Controls.Add(label7);
            Controls.Add(btnGoReactionAfterVaccine);
            Controls.Add(label4);
            Controls.Add(btnGoSignVaccine);
            Controls.Add(label3);
            Controls.Add(btnGoVaccineCert);
            Controls.Add(label1);
            Controls.Add(btnGoMedicalDeclare);
            Controls.Add(btnMenu);
            Controls.Add(label2);
            Controls.Add(upbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserHomePage";
            upbar.ResumeLayout(false);
            drpdMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel upbar;
        private Button btnMinimize;
        private Button btnClose;
        private RJCodeAdvance.RJControls.RJDropdownMenu drpdMenu;
        private ToolStripMenuItem btnAccountInfo;
        private ToolStripMenuItem btnChangePassword;
        private ToolStripMenuItem btnChangeAnswer;
        private ToolStripMenuItem btnLogout;
        private Label label2;
        private Button btnMenu;
        private Button btnGoMedicalDeclare;
        private Label label1;
        private Label label3;
        private Button btnGoVaccineCert;
        private Label label4;
        private Button btnGoSignVaccine;
        private Label label5;
        private Button btnGoHandBook;
        private Label label6;
        private Button btnGoAnamnesis;
        private Label label7;
        private Button btnGoReactionAfterVaccine;
        private Label label8;
        private Label txtName;
    }
}