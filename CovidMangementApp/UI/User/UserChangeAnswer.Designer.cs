namespace CovidMangementApp.UI.User
{
    partial class UserChangeAnswer
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
            btnUpdateAnswer = new RJCodeAdvance.RJControls.RJButton();
            txtReNewAnswer = new MaterialSkin.Controls.MaterialTextBox();
            txtNewAnswer = new MaterialSkin.Controls.MaterialTextBox();
            txtOldAnswer = new MaterialSkin.Controls.MaterialTextBox();
            txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            label1 = new Label();
            btnGoBack = new Button();
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            upbar.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdateAnswer
            // 
            btnUpdateAnswer.BackColor = Color.ForestGreen;
            btnUpdateAnswer.BackgroundColor = Color.ForestGreen;
            btnUpdateAnswer.BorderColor = Color.PaleVioletRed;
            btnUpdateAnswer.BorderRadius = 20;
            btnUpdateAnswer.BorderSize = 0;
            btnUpdateAnswer.FlatAppearance.BorderSize = 0;
            btnUpdateAnswer.FlatStyle = FlatStyle.Flat;
            btnUpdateAnswer.Font = new Font("Roboto", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateAnswer.ForeColor = Color.White;
            btnUpdateAnswer.Location = new Point(301, 581);
            btnUpdateAnswer.Name = "btnUpdateAnswer";
            btnUpdateAnswer.Size = new Size(272, 50);
            btnUpdateAnswer.TabIndex = 36;
            btnUpdateAnswer.Text = "Thay đổi câu trả lời";
            btnUpdateAnswer.TextColor = Color.White;
            btnUpdateAnswer.UseVisualStyleBackColor = false;
            btnUpdateAnswer.Click += btnUpdateAnswer_Click;
            // 
            // txtReNewAnswer
            // 
            txtReNewAnswer.AnimateReadOnly = false;
            txtReNewAnswer.BorderStyle = BorderStyle.None;
            txtReNewAnswer.Depth = 0;
            txtReNewAnswer.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtReNewAnswer.Hint = "Nhập lại câu trả lời mới (*)";
            txtReNewAnswer.LeadingIcon = null;
            txtReNewAnswer.Location = new Point(250, 487);
            txtReNewAnswer.MaxLength = 50;
            txtReNewAnswer.MouseState = MaterialSkin.MouseState.OUT;
            txtReNewAnswer.Multiline = false;
            txtReNewAnswer.Name = "txtReNewAnswer";
            txtReNewAnswer.Size = new Size(400, 50);
            txtReNewAnswer.TabIndex = 35;
            txtReNewAnswer.Text = "";
            txtReNewAnswer.TrailingIcon = null;
            // 
            // txtNewAnswer
            // 
            txtNewAnswer.AnimateReadOnly = false;
            txtNewAnswer.BorderStyle = BorderStyle.None;
            txtNewAnswer.Depth = 0;
            txtNewAnswer.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNewAnswer.Hint = "Câu trả lời mới (*)";
            txtNewAnswer.LeadingIcon = null;
            txtNewAnswer.Location = new Point(249, 387);
            txtNewAnswer.MaxLength = 50;
            txtNewAnswer.MouseState = MaterialSkin.MouseState.OUT;
            txtNewAnswer.Multiline = false;
            txtNewAnswer.Name = "txtNewAnswer";
            txtNewAnswer.Size = new Size(400, 50);
            txtNewAnswer.TabIndex = 34;
            txtNewAnswer.Text = "";
            txtNewAnswer.TrailingIcon = null;
            // 
            // txtOldAnswer
            // 
            txtOldAnswer.AnimateReadOnly = false;
            txtOldAnswer.BorderStyle = BorderStyle.None;
            txtOldAnswer.Depth = 0;
            txtOldAnswer.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtOldAnswer.Hint = "Câu trả lời cũ (*)";
            txtOldAnswer.LeadingIcon = null;
            txtOldAnswer.Location = new Point(250, 287);
            txtOldAnswer.MaxLength = 50;
            txtOldAnswer.MouseState = MaterialSkin.MouseState.OUT;
            txtOldAnswer.Multiline = false;
            txtOldAnswer.Name = "txtOldAnswer";
            txtOldAnswer.Size = new Size(400, 50);
            txtOldAnswer.TabIndex = 33;
            txtOldAnswer.Text = "";
            txtOldAnswer.TrailingIcon = null;
            // 
            // txtUsername
            // 
            txtUsername.AnimateReadOnly = false;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Depth = 0;
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Roboto", 9.6F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Hint = "Câu hỏi đặt biệt (*)";
            txtUsername.LeadingIcon = null;
            txtUsername.Location = new Point(249, 187);
            txtUsername.MaxLength = 50;
            txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 50);
            txtUsername.TabIndex = 32;
            txtUsername.Text = "Trường tiểu học bạn học tên là gì?";
            txtUsername.TrailingIcon = null;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(142, 72);
            label1.Name = "label1";
            label1.Size = new Size(632, 48);
            label1.TabIndex = 31;
            label1.Text = "THAY ĐỔI CÂU TRẢ LỜI ĐẶC BIỆT";
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
            btnGoBack.TabIndex = 30;
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
            // UserChangeAnswer
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 640);
            Controls.Add(upbar);
            Controls.Add(btnUpdateAnswer);
            Controls.Add(txtReNewAnswer);
            Controls.Add(txtNewAnswer);
            Controls.Add(txtOldAnswer);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(btnGoBack);
            Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserChangeAnswer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserChangeAnswer";
            upbar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RJCodeAdvance.RJControls.RJButton btnUpdateAnswer;
        private MaterialSkin.Controls.MaterialTextBox txtReNewAnswer;
        private MaterialSkin.Controls.MaterialTextBox txtNewAnswer;
        private MaterialSkin.Controls.MaterialTextBox txtOldAnswer;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private Label label1;
        private Button btnGoBack;
        private Panel upbar;
        private Button btnMinimize;
        private Button btnClose;
    }
}