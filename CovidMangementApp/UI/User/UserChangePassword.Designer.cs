namespace CovidMangementApp.UI.User
{
    partial class UserChangePassword
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
            label1 = new Label();
            btnChangePassword = new RJCodeAdvance.RJControls.RJButton();
            txtOldPassword = new MaterialSkin.Controls.MaterialTextBox();
            txtNewPassword = new MaterialSkin.Controls.MaterialTextBox();
            txtReNewPassword = new MaterialSkin.Controls.MaterialTextBox();
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            btnGoBack = new Button();
            upbar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(248, 72);
            label1.Name = "label1";
            label1.Size = new Size(409, 48);
            label1.TabIndex = 31;
            label1.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.ForestGreen;
            btnChangePassword.BackgroundColor = Color.ForestGreen;
            btnChangePassword.BorderColor = Color.PaleVioletRed;
            btnChangePassword.BorderRadius = 20;
            btnChangePassword.BorderSize = 0;
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Roboto", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(300, 526);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(272, 50);
            btnChangePassword.TabIndex = 36;
            btnChangePassword.Text = "Thay đổi mật khẩu";
            btnChangePassword.TextColor = Color.White;
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // txtOldPassword
            // 
            txtOldPassword.AnimateReadOnly = false;
            txtOldPassword.BorderStyle = BorderStyle.None;
            txtOldPassword.Depth = 0;
            txtOldPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtOldPassword.Hint = "Mật khẩu cũ";
            txtOldPassword.LeadingIcon = null;
            txtOldPassword.Location = new Point(250, 200);
            txtOldPassword.MaxLength = 50;
            txtOldPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtOldPassword.Multiline = false;
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Password = true;
            txtOldPassword.Size = new Size(400, 50);
            txtOldPassword.TabIndex = 37;
            txtOldPassword.Text = "";
            txtOldPassword.TrailingIcon = Properties.Resources.show_pass;
            txtOldPassword.TrailingIconClick += txtOldPassword_TrailingIconClick;
            // 
            // txtNewPassword
            // 
            txtNewPassword.AnimateReadOnly = false;
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.Depth = 0;
            txtNewPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNewPassword.Hint = "Mật khẩu mới";
            txtNewPassword.LeadingIcon = null;
            txtNewPassword.Location = new Point(250, 310);
            txtNewPassword.MaxLength = 50;
            txtNewPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtNewPassword.Multiline = false;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Password = true;
            txtNewPassword.Size = new Size(400, 50);
            txtNewPassword.TabIndex = 38;
            txtNewPassword.Text = "";
            txtNewPassword.TrailingIcon = Properties.Resources.show_pass;
            txtNewPassword.TrailingIconClick += txtNewPassword_TrailingIconClick;
            // 
            // txtReNewPassword
            // 
            txtReNewPassword.AnimateReadOnly = false;
            txtReNewPassword.BorderStyle = BorderStyle.None;
            txtReNewPassword.Depth = 0;
            txtReNewPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtReNewPassword.Hint = "Nhập lại mật khẩu mới";
            txtReNewPassword.LeadingIcon = null;
            txtReNewPassword.Location = new Point(248, 420);
            txtReNewPassword.MaxLength = 50;
            txtReNewPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtReNewPassword.Multiline = false;
            txtReNewPassword.Name = "txtReNewPassword";
            txtReNewPassword.Password = true;
            txtReNewPassword.Size = new Size(400, 50);
            txtReNewPassword.TabIndex = 39;
            txtReNewPassword.Text = "";
            txtReNewPassword.TrailingIcon = Properties.Resources.show_pass;
            txtReNewPassword.TrailingIconClick += txtReNewPassword_TrailingIconClick;
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
            btnGoBack.TabIndex = 41;
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // UserChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 640);
            Controls.Add(btnGoBack);
            Controls.Add(upbar);
            Controls.Add(txtReNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtOldPassword);
            Controls.Add(label1);
            Controls.Add(btnChangePassword);
            Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserChangePassword";
            upbar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RJCodeAdvance.RJControls.RJButton btnChangePassword;
        private MaterialSkin.Controls.MaterialTextBox txtOldPassword;
        private MaterialSkin.Controls.MaterialTextBox txtNewPassword;
        private MaterialSkin.Controls.MaterialTextBox txtReNewPassword;
        private Panel upbar;
        private Button btnMinimize;
        private Button btnClose;
        private Button btnGoBack;
    }
}