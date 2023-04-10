namespace CovidMangementApp.UI.Staff
{
    partial class StaffHomePage
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
            btnGoInputVaccine = new RJCodeAdvance.RJControls.RJButton();
            btnGoSearchAnamnesis = new RJCodeAdvance.RJControls.RJButton();
            btnGoResponseReaction = new RJCodeAdvance.RJControls.RJButton();
            btnGoResponseSignIn = new RJCodeAdvance.RJControls.RJButton();
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
            // btnGoInputVaccine
            // 
            btnGoInputVaccine.BackColor = Color.DarkViolet;
            btnGoInputVaccine.BackgroundColor = Color.DarkViolet;
            btnGoInputVaccine.BorderColor = Color.PaleVioletRed;
            btnGoInputVaccine.BorderRadius = 20;
            btnGoInputVaccine.BorderSize = 0;
            btnGoInputVaccine.FlatAppearance.BorderSize = 0;
            btnGoInputVaccine.FlatStyle = FlatStyle.Flat;
            btnGoInputVaccine.Font = new Font("Roboto", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoInputVaccine.ForeColor = Color.White;
            btnGoInputVaccine.Location = new Point(110, 120);
            btnGoInputVaccine.Name = "btnGoInputVaccine";
            btnGoInputVaccine.Size = new Size(280, 213);
            btnGoInputVaccine.TabIndex = 24;
            btnGoInputVaccine.Text = "Nhập thông tin tiêm chủng";
            btnGoInputVaccine.TextColor = Color.White;
            btnGoInputVaccine.UseVisualStyleBackColor = false;
            btnGoInputVaccine.Click += btnGoInputVaccine_Click;
            // 
            // btnGoSearchAnamnesis
            // 
            btnGoSearchAnamnesis.BackColor = Color.DeepPink;
            btnGoSearchAnamnesis.BackgroundColor = Color.DeepPink;
            btnGoSearchAnamnesis.BorderColor = Color.PaleVioletRed;
            btnGoSearchAnamnesis.BorderRadius = 20;
            btnGoSearchAnamnesis.BorderSize = 0;
            btnGoSearchAnamnesis.FlatAppearance.BorderSize = 0;
            btnGoSearchAnamnesis.FlatStyle = FlatStyle.Flat;
            btnGoSearchAnamnesis.Font = new Font("Roboto", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoSearchAnamnesis.ForeColor = Color.White;
            btnGoSearchAnamnesis.Location = new Point(510, 120);
            btnGoSearchAnamnesis.Name = "btnGoSearchAnamnesis";
            btnGoSearchAnamnesis.Size = new Size(280, 213);
            btnGoSearchAnamnesis.TabIndex = 25;
            btnGoSearchAnamnesis.Text = "Tra cứu\r\nhồ sơ\r\nsức khỏe";
            btnGoSearchAnamnesis.TextColor = Color.White;
            btnGoSearchAnamnesis.UseVisualStyleBackColor = false;
            btnGoSearchAnamnesis.Click += btnGoSearchAnamnesis_Click;
            // 
            // btnGoResponseReaction
            // 
            btnGoResponseReaction.BackColor = Color.Green;
            btnGoResponseReaction.BackgroundColor = Color.Green;
            btnGoResponseReaction.BorderColor = Color.PaleVioletRed;
            btnGoResponseReaction.BorderRadius = 20;
            btnGoResponseReaction.BorderSize = 0;
            btnGoResponseReaction.FlatAppearance.BorderSize = 0;
            btnGoResponseReaction.FlatStyle = FlatStyle.Flat;
            btnGoResponseReaction.Font = new Font("Roboto", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoResponseReaction.ForeColor = Color.White;
            btnGoResponseReaction.Location = new Point(510, 380);
            btnGoResponseReaction.Name = "btnGoResponseReaction";
            btnGoResponseReaction.Size = new Size(280, 213);
            btnGoResponseReaction.TabIndex = 26;
            btnGoResponseReaction.Text = "Phản hồi phản ứng sau tiêm";
            btnGoResponseReaction.TextColor = Color.White;
            btnGoResponseReaction.UseVisualStyleBackColor = false;
            btnGoResponseReaction.Click += btnGoResponseReaction_Click;
            // 
            // btnGoResponseSignIn
            // 
            btnGoResponseSignIn.BackColor = Color.Goldenrod;
            btnGoResponseSignIn.BackgroundColor = Color.Goldenrod;
            btnGoResponseSignIn.BorderColor = Color.PaleVioletRed;
            btnGoResponseSignIn.BorderRadius = 20;
            btnGoResponseSignIn.BorderSize = 0;
            btnGoResponseSignIn.FlatAppearance.BorderSize = 0;
            btnGoResponseSignIn.FlatStyle = FlatStyle.Flat;
            btnGoResponseSignIn.Font = new Font("Roboto", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoResponseSignIn.ForeColor = Color.White;
            btnGoResponseSignIn.Location = new Point(110, 380);
            btnGoResponseSignIn.Name = "btnGoResponseSignIn";
            btnGoResponseSignIn.Size = new Size(280, 213);
            btnGoResponseSignIn.TabIndex = 27;
            btnGoResponseSignIn.Text = "Phản hồi đăng ký tiêm chủng";
            btnGoResponseSignIn.TextColor = Color.White;
            btnGoResponseSignIn.UseVisualStyleBackColor = false;
            btnGoResponseSignIn.Click += btnGoResponseSignIn_Click;
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
            // StaffHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 640);
            Controls.Add(upbar);
            Controls.Add(btnMenu);
            Controls.Add(btnGoResponseSignIn);
            Controls.Add(btnGoResponseReaction);
            Controls.Add(btnGoSearchAnamnesis);
            Controls.Add(btnGoInputVaccine);
            Controls.Add(label2);
            Controls.Add(txtName);
            Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffHomePage";
            drpdMenu.ResumeLayout(false);
            upbar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label txtName;
        private Label label2;
        private RJCodeAdvance.RJControls.RJButton btnGoInputVaccine;
        private RJCodeAdvance.RJControls.RJButton btnGoSearchAnamnesis;
        private RJCodeAdvance.RJControls.RJButton btnGoResponseReaction;
        private RJCodeAdvance.RJControls.RJButton btnGoResponseSignIn;
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