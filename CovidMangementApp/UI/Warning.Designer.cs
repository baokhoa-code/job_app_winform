namespace CovidMangementApp.UI
{
    partial class Warning
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
            label1 = new Label();
            btnMinimize = new Button();
            btnLogin = new RJCodeAdvance.RJControls.RJButton();
            txtContent = new Label();
            pictureBox1 = new PictureBox();
            rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMinimize);
            panel1.Location = new Point(0, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 35);
            panel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(35, 7);
            label1.Name = "label1";
            label1.Size = new Size(96, 22);
            label1.TabIndex = 19;
            label1.Text = "Cảnh báo";
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
            // btnLogin
            // 
            btnLogin.BackColor = Color.BlueViolet;
            btnLogin.BackgroundColor = Color.BlueViolet;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 10;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(67, 262);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 47);
            btnLogin.TabIndex = 33;
            btnLogin.Text = "OK";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtContent
            // 
            txtContent.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtContent.Location = new Point(50, 195);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(400, 64);
            txtContent.TabIndex = 32;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.notification1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(172, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 122);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.Peru;
            rjButton1.BackgroundColor = Color.Peru;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(332, 261);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(100, 47);
            rjButton1.TabIndex = 34;
            rjButton1.Text = "Thử lại";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // Warning
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(500, 320);
            Controls.Add(rjButton1);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Controls.Add(txtContent);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Warning";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Warning";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnMinimize;
        private RJCodeAdvance.RJControls.RJButton btnLogin;
        private Label txtContent;
        private PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
    }
}