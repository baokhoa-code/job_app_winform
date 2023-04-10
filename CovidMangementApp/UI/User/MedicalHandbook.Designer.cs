namespace CovidMangementApp.UI.User
{
    partial class MedicalHandbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalHandbook));
            label1 = new Label();
            btnGoBack = new Button();
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            roundedPanel1 = new Custom.RoundedPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            upbar.SuspendLayout();
            roundedPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepPink;
            label1.Location = new Point(310, 41);
            label1.Name = "label1";
            label1.Size = new Size(271, 41);
            label1.TabIndex = 41;
            label1.Text = "CẨM NANG Y TẾ";
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
            btnGoBack.TabIndex = 40;
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
            upbar.TabIndex = 39;
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
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderRadius = 50;
            roundedPanel1.Controls.Add(flowLayoutPanel1);
            roundedPanel1.ForeColor = Color.Black;
            roundedPanel1.GradientAngIe = 90F;
            roundedPanel1.GradientBottomColor = Color.AliceBlue;
            roundedPanel1.GradientTopColor = Color.AliceBlue;
            roundedPanel1.Location = new Point(12, 116);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(888, 512);
            roundedPanel1.TabIndex = 42;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Location = new Point(3, 16);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(885, 476);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Roboto Black", 22.5F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.PaleVioletRed;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(867, 46);
            label2.TabIndex = 0;
            label2.Text = "HẬU COVID: Đối phó với đau vai gáy và lưng";
            // 
            // label3
            // 
            label3.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 46);
            label3.Name = "label3";
            label3.Padding = new Padding(30, 0, 0, 0);
            label3.Size = new Size(867, 202);
            label3.TabIndex = 1;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 248);
            label4.Name = "label4";
            label4.Padding = new Padding(30, 0, 0, 0);
            label4.Size = new Size(867, 176);
            label4.TabIndex = 2;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            label5.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 424);
            label5.Name = "label5";
            label5.Padding = new Padding(30, 0, 0, 0);
            label5.Size = new Size(867, 177);
            label5.TabIndex = 3;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            label6.Font = new Font("Roboto Black", 22.5F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.PaleVioletRed;
            label6.Location = new Point(3, 601);
            label6.Name = "label6";
            label6.Size = new Size(867, 96);
            label6.TabIndex = 4;
            label6.Text = "Giữ AN TOÀN cho bản thân với người nhiễm COVID-19";
            // 
            // label7
            // 
            label7.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 697);
            label7.Name = "label7";
            label7.Padding = new Padding(30, 0, 0, 0);
            label7.Size = new Size(867, 164);
            label7.TabIndex = 5;
            label7.Text = resources.GetString("label7.Text");
            // 
            // MedicalHandbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 640);
            Controls.Add(roundedPanel1);
            Controls.Add(label1);
            Controls.Add(btnGoBack);
            Controls.Add(upbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MedicalHandbook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MedicalHandbook";
            upbar.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGoBack;
        private Panel upbar;
        private Button btnMinimize;
        private Button btnClose;
        private Custom.RoundedPanel roundedPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}