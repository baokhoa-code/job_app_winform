namespace CovidMangementApp.UI
{
    partial class Notification
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
            panel1 = new Panel();
            txtTT = new Label();
            btnMinimize = new Button();
            pictureBox1 = new PictureBox();
            txtContent = new Label();
            btnLogin = new RJCodeAdvance.RJControls.RJButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(txtTT);
            panel1.Controls.Add(btnMinimize);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 35);
            panel1.TabIndex = 18;
            // 
            // txtTT
            // 
            txtTT.AutoSize = true;
            txtTT.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtTT.ForeColor = SystemColors.ButtonHighlight;
            txtTT.Location = new Point(35, 7);
            txtTT.Name = "txtTT";
            txtTT.Size = new Size(106, 22);
            txtTT.TabIndex = 19;
            txtTT.Text = "Thông báo";
            // 
            // btnMinimize
            // 
            btnMinimize.BackgroundImage = Properties.Resources.notification;
            btnMinimize.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(7, 5);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(25, 25);
            btnMinimize.TabIndex = 18;
            btnMinimize.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.notification1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(171, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 122);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // txtContent
            // 
            txtContent.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtContent.Location = new Point(50, 173);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(400, 69);
            txtContent.TabIndex = 20;
            txtContent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.ForestGreen;
            btnLogin.BackgroundColor = Color.ForestGreen;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 10;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(198, 261);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 47);
            btnLogin.TabIndex = 29;
            btnLogin.Text = "OK";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Notification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(500, 320);
            Controls.Add(btnLogin);
            Controls.Add(txtContent);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Notification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notification";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMinimize;
        private Label txtTT;
        private PictureBox pictureBox1;
        private Label txtContent;
        private RJCodeAdvance.RJControls.RJButton btnLogin;
    }
}