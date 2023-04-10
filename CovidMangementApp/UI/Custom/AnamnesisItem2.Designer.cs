namespace CovidMangementApp.UI.Custom
{
    partial class AnamnesisItem2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            roundedPanel1 = new RoundedPanel();
            panel1 = new Panel();
            infoValue = new TextBox();
            infoName = new Label();
            roundedPanel2 = new RoundedPanel();
            roundedPanel1.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderRadius = 50;
            roundedPanel1.Controls.Add(panel1);
            roundedPanel1.Controls.Add(infoName);
            roundedPanel1.ForeColor = Color.Black;
            roundedPanel1.GradientAngIe = 90F;
            roundedPanel1.GradientBottomColor = Color.White;
            roundedPanel1.GradientTopColor = Color.White;
            roundedPanel1.Location = new Point(7, 0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(250, 315);
            roundedPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.border;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(infoValue);
            panel1.Location = new Point(16, 68);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(215, 231);
            panel1.TabIndex = 1;
            // 
            // infoValue
            // 
            infoValue.BackColor = Color.White;
            infoValue.BorderStyle = BorderStyle.None;
            infoValue.Dock = DockStyle.Fill;
            infoValue.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            infoValue.Location = new Point(10, 10);
            infoValue.Multiline = true;
            infoValue.Name = "infoValue";
            infoValue.Size = new Size(195, 211);
            infoValue.TabIndex = 0;
            infoValue.TextChanged += infoValue__TextChanged;
            // 
            // infoName
            // 
            infoName.BackColor = Color.Transparent;
            infoName.Font = new Font("Roboto", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            infoName.Location = new Point(0, 16);
            infoName.Name = "infoName";
            infoName.Size = new Size(250, 34);
            infoName.TabIndex = 0;
            infoName.Tag = "";
            infoName.Text = "Tiền sử bệnh án";
            infoName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BorderRadius = 50;
            roundedPanel2.Controls.Add(roundedPanel1);
            roundedPanel2.ForeColor = Color.Black;
            roundedPanel2.GradientAngIe = 90F;
            roundedPanel2.GradientBottomColor = Color.Silver;
            roundedPanel2.GradientTopColor = Color.Silver;
            roundedPanel2.Location = new Point(0, 0);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(260, 320);
            roundedPanel2.TabIndex = 7;
            // 
            // AnamnesisItem2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(roundedPanel2);
            Name = "AnamnesisItem2";
            Size = new Size(260, 320);
            roundedPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private Label infoName;
        private Panel panel1;
        private TextBox infoValue;
    }
}
