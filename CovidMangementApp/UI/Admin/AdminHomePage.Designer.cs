namespace CovidMangementApp.UI.Admin
{
    partial class AdminHomePage
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
            txtName = new Label();
            label2 = new Label();
            btnGoAdminManage = new RJCodeAdvance.RJControls.RJButton();
            btnGoStaffManage = new RJCodeAdvance.RJControls.RJButton();
            btnGoVacine = new RJCodeAdvance.RJControls.RJButton();
            btnGoVaccineFacility = new RJCodeAdvance.RJControls.RJButton();
            btnMenu = new Button();
            drpdMenu = new RJCodeAdvance.RJControls.RJDropdownMenu(components);
            btnAccountInfo = new ToolStripMenuItem();
            btnChangePassword = new ToolStripMenuItem();
            btnChangeAnswer = new ToolStripMenuItem();
            btnLogout = new ToolStripMenuItem();
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            drpdMenu.SuspendLayout();
            upbar.SuspendLayout();
            SuspendLayout();
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
            txtName.TabIndex = 22;
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
            label2.TabIndex = 23;
            label2.Text = "Xin chào,";
            // 
            // btnGoAdminManage
            // 
            btnGoAdminManage.BackColor = Color.DarkViolet;
            btnGoAdminManage.BackgroundColor = Color.DarkViolet;
            btnGoAdminManage.BorderColor = Color.PaleVioletRed;
            btnGoAdminManage.BorderRadius = 20;
            btnGoAdminManage.BorderSize = 0;
            btnGoAdminManage.FlatAppearance.BorderSize = 0;
            btnGoAdminManage.FlatStyle = FlatStyle.Flat;
            btnGoAdminManage.Font = new Font("Roboto", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoAdminManage.ForeColor = Color.White;
            btnGoAdminManage.Location = new Point(110, 120);
            btnGoAdminManage.Name = "btnGoAdminManage";
            btnGoAdminManage.Size = new Size(280, 213);
            btnGoAdminManage.TabIndex = 24;
            btnGoAdminManage.Text = "Quản lí quản trị viên";
            btnGoAdminManage.TextColor = Color.White;
            btnGoAdminManage.UseVisualStyleBackColor = false;
            btnGoAdminManage.Click += btnGoAdminManage_Click;
            // 
            // btnGoStaffManage
            // 
            btnGoStaffManage.BackColor = Color.DeepPink;
            btnGoStaffManage.BackgroundColor = Color.DeepPink;
            btnGoStaffManage.BorderColor = Color.PaleVioletRed;
            btnGoStaffManage.BorderRadius = 20;
            btnGoStaffManage.BorderSize = 0;
            btnGoStaffManage.FlatAppearance.BorderSize = 0;
            btnGoStaffManage.FlatStyle = FlatStyle.Flat;
            btnGoStaffManage.Font = new Font("Roboto", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoStaffManage.ForeColor = Color.White;
            btnGoStaffManage.Location = new Point(510, 120);
            btnGoStaffManage.Name = "btnGoStaffManage";
            btnGoStaffManage.Size = new Size(280, 213);
            btnGoStaffManage.TabIndex = 25;
            btnGoStaffManage.Text = "Quản lí nhân viên y tế";
            btnGoStaffManage.TextColor = Color.White;
            btnGoStaffManage.UseVisualStyleBackColor = false;
            btnGoStaffManage.Click += btnGoStaffManage_Click;
            // 
            // btnGoVacine
            // 
            btnGoVacine.BackColor = Color.Green;
            btnGoVacine.BackgroundColor = Color.Green;
            btnGoVacine.BorderColor = Color.PaleVioletRed;
            btnGoVacine.BorderRadius = 20;
            btnGoVacine.BorderSize = 0;
            btnGoVacine.FlatAppearance.BorderSize = 0;
            btnGoVacine.FlatStyle = FlatStyle.Flat;
            btnGoVacine.Font = new Font("Roboto", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoVacine.ForeColor = Color.White;
            btnGoVacine.Location = new Point(510, 380);
            btnGoVacine.Name = "btnGoVacine";
            btnGoVacine.Size = new Size(280, 213);
            btnGoVacine.TabIndex = 26;
            btnGoVacine.Text = "Quản lí vắc xin";
            btnGoVacine.TextColor = Color.White;
            btnGoVacine.UseVisualStyleBackColor = false;
            btnGoVacine.Click += btnGoVacine_Click;
            // 
            // btnGoVaccineFacility
            // 
            btnGoVaccineFacility.BackColor = Color.Goldenrod;
            btnGoVaccineFacility.BackgroundColor = Color.Goldenrod;
            btnGoVaccineFacility.BorderColor = Color.PaleVioletRed;
            btnGoVaccineFacility.BorderRadius = 20;
            btnGoVaccineFacility.BorderSize = 0;
            btnGoVaccineFacility.FlatAppearance.BorderSize = 0;
            btnGoVaccineFacility.FlatStyle = FlatStyle.Flat;
            btnGoVaccineFacility.Font = new Font("Roboto", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoVaccineFacility.ForeColor = Color.White;
            btnGoVaccineFacility.Location = new Point(110, 380);
            btnGoVaccineFacility.Name = "btnGoVaccineFacility";
            btnGoVaccineFacility.Size = new Size(280, 213);
            btnGoVaccineFacility.TabIndex = 27;
            btnGoVaccineFacility.Text = "Quản lí cơ sở tiêm chủng";
            btnGoVaccineFacility.TextColor = Color.White;
            btnGoVaccineFacility.UseVisualStyleBackColor = false;
            btnGoVaccineFacility.Click += btnGoVaccineFacility_Click;
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
            btnMenu.TabIndex = 29;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
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
            // AdminHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 640);
            Controls.Add(upbar);
            Controls.Add(btnMenu);
            Controls.Add(btnGoVaccineFacility);
            Controls.Add(btnGoVacine);
            Controls.Add(btnGoStaffManage);
            Controls.Add(btnGoAdminManage);
            Controls.Add(label2);
            Controls.Add(txtName);
            Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminHomePage";
            drpdMenu.ResumeLayout(false);
            upbar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label txtName;
        private Label label2;
        private RJCodeAdvance.RJControls.RJButton btnGoAdminManage;
        private RJCodeAdvance.RJControls.RJButton btnGoStaffManage;
        private RJCodeAdvance.RJControls.RJButton btnGoVacine;
        private RJCodeAdvance.RJControls.RJButton btnGoVaccineFacility;
        private Button btnMenu;
        private RJCodeAdvance.RJControls.RJDropdownMenu drpdMenu;
        private ToolStripMenuItem btnAccountInfo;
        private ToolStripMenuItem btnChangePassword;
        private ToolStripMenuItem btnChangeAnswer;
        private ToolStripMenuItem btnLogout;
        private Panel upbar;
        private Button btnMinimize;
        private Button btnClose;
    }
}