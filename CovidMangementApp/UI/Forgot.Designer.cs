namespace CovidMangementApp.UI
{
    partial class Forgot
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
            btnGoBack = new Button();
            txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            txtCMND = new MaterialSkin.Controls.MaterialTextBox();
            btnChangePassword = new RJCodeAdvance.RJControls.RJButton();
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            txtAnswer = new MaterialSkin.Controls.MaterialTextBox();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            upbar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(281, 63);
            label1.Name = "label1";
            label1.Size = new Size(335, 48);
            label1.TabIndex = 23;
            label1.Text = "QUÊN MẬT KHẨU";
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
            btnGoBack.TabIndex = 22;
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // txtUsername
            // 
            txtUsername.AnimateReadOnly = false;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Depth = 0;
            txtUsername.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsername.Hint = "Tên đăng nhập (*)";
            txtUsername.LeadingIcon = null;
            txtUsername.Location = new Point(249, 178);
            txtUsername.MaxLength = 50;
            txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 50);
            txtUsername.TabIndex = 24;
            txtUsername.Text = "";
            txtUsername.TrailingIcon = null;
            // 
            // txtCMND
            // 
            txtCMND.AnimateReadOnly = false;
            txtCMND.BorderStyle = BorderStyle.None;
            txtCMND.Depth = 0;
            txtCMND.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCMND.Hint = "Hộ chiếu/Căc cước/ Chứng minh(*)";
            txtCMND.LeadingIcon = null;
            txtCMND.Location = new Point(250, 278);
            txtCMND.MaxLength = 50;
            txtCMND.MouseState = MaterialSkin.MouseState.OUT;
            txtCMND.Multiline = false;
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(400, 50);
            txtCMND.TabIndex = 25;
            txtCMND.Text = "";
            txtCMND.TrailingIcon = null;
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
            btnChangePassword.Location = new Point(305, 572);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(272, 50);
            btnChangePassword.TabIndex = 28;
            btnChangePassword.Text = "Xác nhận thông tin";
            btnChangePassword.TextColor = Color.White;
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // upbar
            // 
            upbar.BackColor = Color.DarkSlateGray;
            upbar.Controls.Add(btnMinimize);
            upbar.Controls.Add(btnClose);
            upbar.Location = new Point(0, 0);
            upbar.Name = "upbar";
            upbar.Size = new Size(900, 30);
            upbar.TabIndex = 29;
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
            // txtAnswer
            // 
            txtAnswer.AnimateReadOnly = false;
            txtAnswer.BorderStyle = BorderStyle.None;
            txtAnswer.Depth = 0;
            txtAnswer.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAnswer.Hint = "Câu trả lời bảo mật (*)";
            txtAnswer.LeadingIcon = null;
            txtAnswer.Location = new Point(249, 378);
            txtAnswer.MaxLength = 50;
            txtAnswer.MouseState = MaterialSkin.MouseState.OUT;
            txtAnswer.Multiline = false;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(400, 50);
            txtAnswer.TabIndex = 26;
            txtAnswer.Text = "";
            txtAnswer.TrailingIcon = null;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.Hint = "Mật khẩu mới";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(250, 487);
            txtPassword.MaxLength = 50;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Password = true;
            txtPassword.Size = new Size(400, 50);
            txtPassword.TabIndex = 38;
            txtPassword.Text = "";
            txtPassword.TrailingIcon = Properties.Resources.show_pass;
            txtPassword.TrailingIconClick += txtPassword_TrailingIconClick;
            // 
            // Forgot
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 640);
            Controls.Add(txtPassword);
            Controls.Add(upbar);
            Controls.Add(btnChangePassword);
            Controls.Add(txtAnswer);
            Controls.Add(txtCMND);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(btnGoBack);
            Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Forgot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot";
            upbar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnGoBack;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialTextBox txtCMND;
        private RJCodeAdvance.RJControls.RJButton btnChangePassword;
        private Panel upbar;
        private Button btnMinimize;
        private Button btnClose;
        private MaterialSkin.Controls.MaterialTextBox txtAnswer;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
    }
}