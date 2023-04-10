namespace CovidMangementApp.UI.Custom
{
    partial class VaccineCertItem
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
            pnl = new RoundedPanel();
            injectionVaccine = new Label();
            facilityVaccine = new Label();
            nameVaccine = new Label();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            dateVaccine = new Label();
            indexVaccine = new Label();
            pnl.SuspendLayout();
            SuspendLayout();
            // 
            // pnl
            // 
            pnl.BackColor = Color.White;
            pnl.BorderRadius = 50;
            pnl.Controls.Add(injectionVaccine);
            pnl.Controls.Add(facilityVaccine);
            pnl.Controls.Add(nameVaccine);
            pnl.Controls.Add(materialDivider1);
            pnl.Controls.Add(dateVaccine);
            pnl.Controls.Add(indexVaccine);
            pnl.ForeColor = Color.Black;
            pnl.GradientAngIe = 90F;
            pnl.GradientBottomColor = Color.White;
            pnl.GradientTopColor = Color.White;
            pnl.Location = new Point(0, 0);
            pnl.Name = "pnl";
            pnl.Size = new Size(425, 208);
            pnl.TabIndex = 0;
            // 
            // injectionVaccine
            // 
            injectionVaccine.BackColor = Color.Transparent;
            injectionVaccine.Cursor = Cursors.Hand;
            injectionVaccine.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            injectionVaccine.Location = new Point(172, 130);
            injectionVaccine.Name = "injectionVaccine";
            injectionVaccine.Size = new Size(250, 44);
            injectionVaccine.TabIndex = 103;
            injectionVaccine.Text = "Mũi số: 1";
            injectionVaccine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // facilityVaccine
            // 
            facilityVaccine.BackColor = Color.Transparent;
            facilityVaccine.Cursor = Cursors.Hand;
            facilityVaccine.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            facilityVaccine.Location = new Point(172, 68);
            facilityVaccine.Name = "facilityVaccine";
            facilityVaccine.Size = new Size(250, 59);
            facilityVaccine.TabIndex = 102;
            facilityVaccine.Text = "Nơi tiêm : Vaccine";
            // 
            // nameVaccine
            // 
            nameVaccine.BackColor = Color.Transparent;
            nameVaccine.Cursor = Cursors.Hand;
            nameVaccine.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            nameVaccine.Location = new Point(172, 16);
            nameVaccine.Name = "nameVaccine";
            nameVaccine.Size = new Size(250, 44);
            nameVaccine.TabIndex = 101;
            nameVaccine.Text = "Tên: Vaccine";
            nameVaccine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.Gray;
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(155, 3);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(1, 208);
            materialDivider1.TabIndex = 99;
            materialDivider1.Text = "materialDivider1";
            // 
            // dateVaccine
            // 
            dateVaccine.BackColor = Color.Transparent;
            dateVaccine.Cursor = Cursors.Hand;
            dateVaccine.Font = new Font("Roboto", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dateVaccine.Location = new Point(-5, 117);
            dateVaccine.Name = "dateVaccine";
            dateVaccine.Size = new Size(168, 44);
            dateVaccine.TabIndex = 100;
            dateVaccine.Text = "04/04/2023";
            dateVaccine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // indexVaccine
            // 
            indexVaccine.BackColor = Color.Transparent;
            indexVaccine.Cursor = Cursors.Hand;
            indexVaccine.Font = new Font("Roboto", 49.8000031F, FontStyle.Bold, GraphicsUnit.Point);
            indexVaccine.Location = new Point(6, 20);
            indexVaccine.Name = "indexVaccine";
            indexVaccine.Size = new Size(145, 100);
            indexVaccine.TabIndex = 1;
            indexVaccine.Text = "01";
            indexVaccine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VaccineCertItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnl);
            Name = "VaccineCertItem";
            Size = new Size(425, 208);
            pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel pnl;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Label indexVaccine;
        private Label dateVaccine;
        private Label nameVaccine;
        private Label injectionVaccine;
        private Label facilityVaccine;
    }
}
