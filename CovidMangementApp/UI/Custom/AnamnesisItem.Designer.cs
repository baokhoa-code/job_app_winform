namespace CovidMangementApp.UI.Custom
{
    partial class AnamnesisItem
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
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            infoValue = new TextBox();
            infoImage = new PictureBox();
            infoUnit = new Label();
            infoName = new Label();
            roundedPanel2 = new RoundedPanel();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)infoImage).BeginInit();
            roundedPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderRadius = 50;
            roundedPanel1.Controls.Add(materialDivider1);
            roundedPanel1.Controls.Add(infoValue);
            roundedPanel1.Controls.Add(infoImage);
            roundedPanel1.Controls.Add(infoUnit);
            roundedPanel1.Controls.Add(infoName);
            roundedPanel1.ForeColor = Color.Black;
            roundedPanel1.GradientAngIe = 90F;
            roundedPanel1.GradientBottomColor = Color.White;
            roundedPanel1.GradientTopColor = Color.White;
            roundedPanel1.Location = new Point(7, 0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(250, 210);
            roundedPanel1.TabIndex = 6;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.RoyalBlue;
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(9, 182);
            materialDivider1.Margin = new Padding(3, 0, 3, 3);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(228, 2);
            materialDivider1.TabIndex = 33;
            materialDivider1.Text = "materialDivider1";
            // 
            // infoValue
            // 
            infoValue.BorderStyle = BorderStyle.None;
            infoValue.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            infoValue.Location = new Point(9, 155);
            infoValue.Name = "infoValue";
            infoValue.Size = new Size(228, 28);
            infoValue.TabIndex = 3;
            infoValue.TextChanged += infoValue__TextChanged;
            // 
            // infoImage
            // 
            infoImage.Location = new Point(9, 12);
            infoImage.Name = "infoImage";
            infoImage.Size = new Size(73, 72);
            infoImage.SizeMode = PictureBoxSizeMode.Zoom;
            infoImage.TabIndex = 2;
            infoImage.TabStop = false;
            // 
            // infoUnit
            // 
            infoUnit.BackColor = Color.Transparent;
            infoUnit.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            infoUnit.ForeColor = Color.Blue;
            infoUnit.Location = new Point(76, 59);
            infoUnit.Name = "infoUnit";
            infoUnit.Padding = new Padding(3, 0, 0, 0);
            infoUnit.Size = new Size(174, 28);
            infoUnit.TabIndex = 1;
            // 
            // infoName
            // 
            infoName.BackColor = Color.Transparent;
            infoName.Font = new Font("Roboto", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            infoName.Location = new Point(76, 16);
            infoName.Name = "infoName";
            infoName.Size = new Size(176, 34);
            infoName.TabIndex = 0;
            infoName.Tag = "";
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
            roundedPanel2.Size = new Size(260, 215);
            roundedPanel2.TabIndex = 7;
            // 
            // AnamnesisItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(roundedPanel2);
            Name = "AnamnesisItem";
            Size = new Size(260, 215);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)infoImage).EndInit();
            roundedPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private Label infoName;
        private Label infoUnit;
        private PictureBox infoImage;
        private TextBox infoValue;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}
