using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CovidMangementApp.UI.Staff
{
    partial class PatientAnamnesis
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            btnGoBack = new Button();
            gridView = new DataGridView();
            coverPanel = new Panel();
            flowList = new FlowLayoutPanel();
            panel1 = new Panel();
            bloodSugar = new Custom.AnamnesisItem();
            spo2 = new Custom.AnamnesisItem();
            bloodPressure = new Custom.AnamnesisItem();
            heartRate = new Custom.AnamnesisItem();
            temperature = new Custom.AnamnesisItem();
            height = new Custom.AnamnesisItem();
            weight = new Custom.AnamnesisItem();
            bmi = new Custom.AnamnesisItem();
            bloodType = new Custom.AnamnesisItem();
            allergy = new Custom.AnamnesisItem2();
            sick = new Custom.AnamnesisItem2();
            surgery = new Custom.AnamnesisItem2();
            roundedPanel1 = new Custom.RoundedPanel();
            roundedPanel2 = new Custom.RoundedPanel();
            roundedPanel3 = new Custom.RoundedPanel();
            txtName = new Label();
            txtGender = new Label();
            txtDob = new Label();
            upbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            coverPanel.SuspendLayout();
            flowList.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepPink;
            label1.Location = new Point(200, 40);
            label1.Name = "label1";
            label1.Size = new Size(529, 46);
            label1.TabIndex = 34;
            label1.Text = "QUẢN LÍ NHÂN VIÊN Y TẾ";
            // 
            // txtSearch
            // 
            txtSearch.AnimateReadOnly = false;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Depth = 0;
            txtSearch.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearch.Hint = "Nhập thông tin tìm kiếm";
            txtSearch.LeadingIcon = Properties.Resources.magnifier;
            txtSearch.Location = new Point(0, 102);
            txtSearch.MaxLength = 50;
            txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(626, 50);
            txtSearch.TabIndex = 35;
            txtSearch.Text = "";
            txtSearch.TrailingIcon = null;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // upbar
            // 
            upbar.BackColor = Color.DarkSlateGray;
            upbar.Controls.Add(btnMinimize);
            upbar.Controls.Add(btnClose);
            upbar.Location = new Point(0, 0);
            upbar.Name = "upbar";
            upbar.Size = new Size(900, 30);
            upbar.TabIndex = 41;
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
            // gridView
            // 
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.AllowUserToResizeColumns = false;
            gridView.AllowUserToResizeRows = false;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.BackgroundColor = Color.White;
            gridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            gridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.ForestGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.EnableHeadersVisualStyles = false;
            gridView.Location = new Point(12, 163);
            gridView.Name = "gridView";
            gridView.ReadOnly = true;
            gridView.RowHeadersWidth = 51;
            gridView.RowTemplate.DefaultCellStyle.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            gridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(198, 224, 180);
            gridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            gridView.RowTemplate.Height = 29;
            gridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gridView.ShowCellErrors = false;
            gridView.ShowCellToolTips = false;
            gridView.ShowEditingIcon = false;
            gridView.ShowRowErrors = false;
            gridView.Size = new Size(876, 465);
            gridView.TabIndex = 42;
            gridView.CellClick += gridView_CellClick;
            // 
            // coverPanel
            // 
            coverPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            coverPanel.Controls.Add(flowList);
            coverPanel.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            coverPanel.ForeColor = Color.FromArgb(100, 0, 0);
            coverPanel.Location = new Point(0, 89);
            coverPanel.Name = "coverPanel";
            coverPanel.Size = new Size(900, 551);
            coverPanel.TabIndex = 43;
            coverPanel.Visible = false;
            coverPanel.Click += coverPanel_Click;
            // 
            // flowList
            // 
            flowList.AutoScroll = true;
            flowList.BackColor = Color.Transparent;
            flowList.Controls.Add(panel1);
            flowList.Controls.Add(bloodSugar);
            flowList.Controls.Add(spo2);
            flowList.Controls.Add(bloodPressure);
            flowList.Controls.Add(heartRate);
            flowList.Controls.Add(temperature);
            flowList.Controls.Add(height);
            flowList.Controls.Add(weight);
            flowList.Controls.Add(bmi);
            flowList.Controls.Add(bloodType);
            flowList.Controls.Add(allergy);
            flowList.Controls.Add(sick);
            flowList.Controls.Add(surgery);
            flowList.Location = new Point(0, 12);
            flowList.Name = "flowList";
            flowList.Size = new Size(900, 526);
            flowList.TabIndex = 46;
            // 
            // panel1
            // 
            panel1.Controls.Add(roundedPanel3);
            panel1.Controls.Add(roundedPanel2);
            panel1.Controls.Add(roundedPanel1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 70);
            panel1.TabIndex = 70;
            // 
            // bloodSugar
            // 
            bloodSugar.BackColor = Color.Transparent;
            bloodSugar.EnabledTexBox = false;
            bloodSugar.ItemImageInfo = Properties.Resources.blood_sugar;
            bloodSugar.ItemNameInfo = "Đường huyết";
            bloodSugar.ItemUnitInfo = "mg/DL";
            bloodSugar.ItemValueTextBox = null;
            bloodSugar.Location = new Point(20, 79);
            bloodSugar.Margin = new Padding(20, 3, 3, 0);
            bloodSugar.Name = "bloodSugar";
            bloodSugar.PlaceHolderTexBox = "Đường huyết";
            bloodSugar.Size = new Size(258, 195);
            bloodSugar.TabIndex = 58;
            // 
            // spo2
            // 
            spo2.BackColor = Color.Transparent;
            spo2.EnabledTexBox = false;
            spo2.ItemImageInfo = Properties.Resources.oxygen;
            spo2.ItemNameInfo = "SPO2";
            spo2.ItemUnitInfo = null;
            spo2.ItemValueTextBox = null;
            spo2.Location = new Point(301, 79);
            spo2.Margin = new Padding(20, 3, 3, 0);
            spo2.Name = "spo2";
            spo2.PlaceHolderTexBox = "Chỉ số SPO2 (%)";
            spo2.Size = new Size(258, 195);
            spo2.TabIndex = 59;
            // 
            // bloodPressure
            // 
            bloodPressure.BackColor = Color.Transparent;
            bloodPressure.EnabledTexBox = false;
            bloodPressure.ItemImageInfo = Properties.Resources.blood_pressure;
            bloodPressure.ItemNameInfo = "Huyết áp";
            bloodPressure.ItemUnitInfo = "mmHg";
            bloodPressure.ItemValueTextBox = null;
            bloodPressure.Location = new Point(582, 79);
            bloodPressure.Margin = new Padding(20, 3, 3, 0);
            bloodPressure.Name = "bloodPressure";
            bloodPressure.PlaceHolderTexBox = "Huyết áp";
            bloodPressure.Size = new Size(258, 195);
            bloodPressure.TabIndex = 60;
            // 
            // heartRate
            // 
            heartRate.BackColor = Color.Transparent;
            heartRate.EnabledTexBox = false;
            heartRate.ItemImageInfo = Properties.Resources.heart_rate;
            heartRate.ItemNameInfo = "Nhịp tim";
            heartRate.ItemUnitInfo = "nhịp/phút";
            heartRate.ItemValueTextBox = null;
            heartRate.Location = new Point(20, 294);
            heartRate.Margin = new Padding(20, 20, 3, 0);
            heartRate.Name = "heartRate";
            heartRate.PlaceHolderTexBox = "Nhịp tim";
            heartRate.Size = new Size(258, 195);
            heartRate.TabIndex = 61;
            // 
            // temperature
            // 
            temperature.BackColor = Color.Transparent;
            temperature.EnabledTexBox = false;
            temperature.ItemImageInfo = Properties.Resources.temperature;
            temperature.ItemNameInfo = "Nhiệt độ";
            temperature.ItemUnitInfo = "°C";
            temperature.ItemValueTextBox = null;
            temperature.Location = new Point(301, 294);
            temperature.Margin = new Padding(20, 20, 3, 0);
            temperature.Name = "temperature";
            temperature.PlaceHolderTexBox = "Nhiệt độ";
            temperature.Size = new Size(258, 195);
            temperature.TabIndex = 62;
            // 
            // height
            // 
            height.BackColor = Color.Transparent;
            height.EnabledTexBox = false;
            height.ItemImageInfo = Properties.Resources.height;
            height.ItemNameInfo = "Chiêu cao";
            height.ItemUnitInfo = "cm";
            height.ItemValueTextBox = null;
            height.Location = new Point(582, 294);
            height.Margin = new Padding(20, 20, 3, 0);
            height.Name = "height";
            height.PlaceHolderTexBox = "Chiêu cao";
            height.Size = new Size(258, 195);
            height.TabIndex = 63;
            // 
            // weight
            // 
            weight.BackColor = Color.Transparent;
            weight.EnabledTexBox = false;
            weight.ItemImageInfo = Properties.Resources.weight_loss;
            weight.ItemNameInfo = "Cân nặng";
            weight.ItemUnitInfo = "kg";
            weight.ItemValueTextBox = null;
            weight.Location = new Point(20, 509);
            weight.Margin = new Padding(20, 20, 3, 0);
            weight.Name = "weight";
            weight.PlaceHolderTexBox = "Cân nặng";
            weight.Size = new Size(258, 195);
            weight.TabIndex = 64;
            // 
            // bmi
            // 
            bmi.BackColor = Color.Transparent;
            bmi.EnabledTexBox = false;
            bmi.ItemImageInfo = Properties.Resources.bmi;
            bmi.ItemNameInfo = "Chỉ số BMI";
            bmi.ItemUnitInfo = "kg/m2";
            bmi.ItemValueTextBox = null;
            bmi.Location = new Point(301, 509);
            bmi.Margin = new Padding(20, 20, 3, 0);
            bmi.Name = "bmi";
            bmi.PlaceHolderTexBox = "Chỉ số BMI";
            bmi.Size = new Size(258, 195);
            bmi.TabIndex = 65;
            // 
            // bloodType
            // 
            bloodType.BackColor = Color.Transparent;
            bloodType.EnabledTexBox = false;
            bloodType.ItemImageInfo = Properties.Resources.blood_type;
            bloodType.ItemNameInfo = "Nhóm máu";
            bloodType.ItemUnitInfo = null;
            bloodType.ItemValueTextBox = null;
            bloodType.Location = new Point(582, 509);
            bloodType.Margin = new Padding(20, 20, 3, 0);
            bloodType.Name = "bloodType";
            bloodType.PlaceHolderTexBox = "Nhóm máu";
            bloodType.Size = new Size(258, 195);
            bloodType.TabIndex = 66;
            // 
            // allergy
            // 
            allergy.BackColor = Color.Transparent;
            allergy.EnabledTexBox = false;
            allergy.ItemNameInfo = "Tiền sử dị ứng";
            allergy.ItemValueTextBox = null;
            allergy.Location = new Point(20, 724);
            allergy.Margin = new Padding(20, 20, 3, 0);
            allergy.Name = "allergy";
            allergy.PlaceHolderTexBox = "Nhập mô tả";
            allergy.Size = new Size(258, 300);
            allergy.TabIndex = 67;
            // 
            // sick
            // 
            sick.BackColor = Color.Transparent;
            sick.EnabledTexBox = false;
            sick.ItemNameInfo = "Tiền sử bệnh";
            sick.ItemValueTextBox = null;
            sick.Location = new Point(301, 724);
            sick.Margin = new Padding(20, 20, 3, 0);
            sick.Name = "sick";
            sick.PlaceHolderTexBox = "Nhập mô tả";
            sick.Size = new Size(258, 300);
            sick.TabIndex = 68;
            // 
            // surgery
            // 
            surgery.BackColor = Color.Transparent;
            surgery.EnabledTexBox = false;
            surgery.ItemNameInfo = "Tiển sử phẩu thuật";
            surgery.ItemValueTextBox = null;
            surgery.Location = new Point(582, 724);
            surgery.Margin = new Padding(20, 20, 3, 0);
            surgery.Name = "surgery";
            surgery.PlaceHolderTexBox = "Nhập mô tả";
            surgery.Size = new Size(258, 300);
            surgery.TabIndex = 69;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderRadius = 30;
            roundedPanel1.Controls.Add(txtName);
            roundedPanel1.ForeColor = Color.Black;
            roundedPanel1.GradientAngIe = 90F;
            roundedPanel1.GradientBottomColor = Color.White;
            roundedPanel1.GradientTopColor = Color.White;
            roundedPanel1.Location = new Point(17, 13);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(258, 46);
            roundedPanel1.TabIndex = 0;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BorderRadius = 30;
            roundedPanel2.Controls.Add(txtGender);
            roundedPanel2.ForeColor = Color.Black;
            roundedPanel2.GradientAngIe = 90F;
            roundedPanel2.GradientBottomColor = Color.White;
            roundedPanel2.GradientTopColor = Color.White;
            roundedPanel2.Location = new Point(298, 13);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(258, 46);
            roundedPanel2.TabIndex = 1;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.White;
            roundedPanel3.BorderRadius = 30;
            roundedPanel3.Controls.Add(txtDob);
            roundedPanel3.ForeColor = Color.Black;
            roundedPanel3.GradientAngIe = 90F;
            roundedPanel3.GradientBottomColor = Color.White;
            roundedPanel3.GradientTopColor = Color.White;
            roundedPanel3.Location = new Point(579, 13);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(258, 46);
            roundedPanel3.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(0, 0);
            txtName.Name = "txtName";
            txtName.Size = new Size(258, 46);
            txtName.TabIndex = 0;
            txtName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGender
            // 
            txtGender.Dock = DockStyle.Fill;
            txtGender.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtGender.Location = new Point(0, 0);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(258, 46);
            txtGender.TabIndex = 1;
            txtGender.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDob
            // 
            txtDob.Dock = DockStyle.Fill;
            txtDob.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDob.Location = new Point(0, 0);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(258, 46);
            txtDob.TabIndex = 2;
            txtDob.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PatientAnamnesis
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 640);
            Controls.Add(coverPanel);
            Controls.Add(gridView);
            Controls.Add(upbar);
            Controls.Add(btnGoBack);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PatientAnamnesis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientAnamnesis";
            Load += PatientAnamnesis_Load;
            upbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            coverPanel.ResumeLayout(false);
            flowList.ResumeLayout(false);
            panel1.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private Panel upbar;
        private Button btnMinimize;
        private Button btnClose;
        private Button btnGoBack;
        private DataGridView gridView;
        private Panel coverPanel;
        private FlowLayoutPanel flowList;
        private Custom.AnamnesisItem bloodSugar;
        private Custom.AnamnesisItem spo2;
        private Custom.AnamnesisItem bloodPressure;
        private Custom.AnamnesisItem heartRate;
        private Custom.AnamnesisItem temperature;
        private Custom.AnamnesisItem height;
        private Custom.AnamnesisItem weight;
        private Custom.AnamnesisItem bmi;
        private Custom.AnamnesisItem bloodType;
        private Custom.AnamnesisItem2 allergy;
        private Custom.AnamnesisItem2 sick;
        private Custom.AnamnesisItem2 surgery;
        private Panel panel1;
        private Custom.RoundedPanel roundedPanel1;
        private Custom.RoundedPanel roundedPanel3;
        private Custom.RoundedPanel roundedPanel2;
        private Label txtName;
        private Label txtGender;
        private Label txtDob;
    }
}