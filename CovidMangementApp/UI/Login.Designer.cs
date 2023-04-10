namespace CovidMangementApp.UI
{
    partial class Login
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
            btnGoRegist = new Button();
            label1 = new Label();
            btnLogin = new RJCodeAdvance.RJControls.RJButton();
            btnGoForgot = new Button();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            pictureBox1 = new PictureBox();
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            upbar.SuspendLayout();
            SuspendLayout();
            // 
            // btnGoRegist
            // 
            btnGoRegist.BackColor = Color.Transparent;
            btnGoRegist.FlatAppearance.BorderSize = 0;
            btnGoRegist.FlatStyle = FlatStyle.Flat;
            btnGoRegist.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Underline, GraphicsUnit.Point);
            btnGoRegist.ForeColor = Color.RoyalBlue;
            btnGoRegist.Location = new Point(502, 555);
            btnGoRegist.Name = "btnGoRegist";
            btnGoRegist.Size = new Size(78, 29);
            btnGoRegist.TabIndex = 14;
            btnGoRegist.Text = "Đăng ký";
            btnGoRegist.UseVisualStyleBackColor = false;
            btnGoRegist.Click += btnGoRegist_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(321, 560);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 13;
            label1.Text = "Bạn chưa có tài khoản?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.ForestGreen;
            btnLogin.BackgroundColor = Color.ForestGreen;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 20;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(312, 490);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(261, 50);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Đăng nhập";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnGoForgot
            // 
            btnGoForgot.BackColor = Color.Transparent;
            btnGoForgot.FlatAppearance.BorderSize = 0;
            btnGoForgot.FlatStyle = FlatStyle.Flat;
            btnGoForgot.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Underline, GraphicsUnit.Point);
            btnGoForgot.ForeColor = Color.RoyalBlue;
            btnGoForgot.Location = new Point(511, 448);
            btnGoForgot.Name = "btnGoForgot";
            btnGoForgot.Size = new Size(145, 29);
            btnGoForgot.TabIndex = 11;
            btnGoForgot.Text = "Quên mật khẩu?";
            btnGoForgot.UseVisualStyleBackColor = false;
            btnGoForgot.Click += btnGoForgot_Click;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.Hint = "Mật khẩu";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(250, 379);
            txtPassword.MaxLength = 50;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Password = true;
            txtPassword.Size = new Size(400, 50);
            txtPassword.TabIndex = 10;
            txtPassword.Text = "";
            txtPassword.TrailingIcon = Properties.Resources.show_pass;
            txtPassword.TrailingIconClick += txtPassword_TrailingIconClick;
            // 
            // txtUsername
            // 
            txtUsername.AnimateReadOnly = false;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Depth = 0;
            txtUsername.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsername.Hint = "Tên đăng nhập";
            txtUsername.LeadingIcon = null;
            txtUsername.Location = new Point(250, 312);
            txtUsername.MaxLength = 50;
            txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 50);
            txtUsername.TabIndex = 9;
            txtUsername.Text = "";
            txtUsername.TrailingIcon = null;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(343, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // upbar
            // 
            upbar.BackColor = Color.DarkSlateGray;
            upbar.Controls.Add(btnMinimize);
            upbar.Controls.Add(btnClose);
            upbar.Location = new Point(0, 0);
            upbar.Name = "upbar";
            upbar.Size = new Size(900, 30);
            upbar.TabIndex = 15;
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
            // Login
            // 
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(900, 640);
            Controls.Add(upbar);
            Controls.Add(btnGoRegist);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(btnGoForgot);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            upbar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGoRegist;
        private Label label1;
        private RJCodeAdvance.RJControls.RJButton btnLogin;
        private Button btnGoForgot;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private PictureBox pictureBox1;
        private Panel upbar;
        private Button btnClose;
        private Button btnMinimize;
    }
}