namespace CovidMangementApp.UI.Custom
{
    partial class DeclarationItem
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
            lblTime = new Label();
            lblDate = new Label();
            lblIndex = new Label();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Roboto", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.Navy;
            lblTime.Location = new Point(111, 68);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(102, 28);
            lblTime.TabIndex = 2;
            lblTime.Text = "21:52:27";
            lblTime.Click += lblDate_Click;
            lblTime.MouseEnter += DeclarationItem_MouseEnter;
            lblTime.MouseLeave += DeclarationItem_MouseLeave;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Roboto", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.ForeColor = Color.Navy;
            lblDate.Location = new Point(94, 36);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(134, 28);
            lblDate.TabIndex = 1;
            lblDate.Text = "06/04/2023";
            lblDate.Click += lblDate_Click;
            lblDate.MouseEnter += DeclarationItem_MouseEnter;
            lblDate.MouseLeave += DeclarationItem_MouseLeave;
            // 
            // lblIndex
            // 
            lblIndex.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblIndex.Location = new Point(6, 36);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(84, 60);
            lblIndex.TabIndex = 0;
            lblIndex.Text = "1";
            lblIndex.TextAlign = ContentAlignment.MiddleCenter;
            lblIndex.Click += lblIndex_Click;
            lblIndex.MouseEnter += DeclarationItem_MouseEnter;
            lblIndex.MouseLeave += DeclarationItem_MouseLeave;
            // 
            // DeclarationItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.test11;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(lblIndex);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            Name = "DeclarationItem";
            Size = new Size(236, 129);
            MouseEnter += DeclarationItem_MouseEnter;
            MouseLeave += DeclarationItem_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblIndex;
        private Label lblDate;
        private Label lblTime;
    }
}
