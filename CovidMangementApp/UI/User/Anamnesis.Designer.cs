namespace CovidMangementApp.UI.User
{
    partial class Anamnesis
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
            label1 = new Label();
            btnGoBack = new Button();
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            flowList = new FlowLayoutPanel();
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
            btnUpdate = new RJCodeAdvance.RJControls.RJButton();
            upbar.SuspendLayout();
            flowList.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(305, 41);
            label1.Name = "label1";
            label1.Size = new Size(289, 41);
            label1.TabIndex = 41;
            label1.Text = "HỒ SƠ SỨC KHỎE";
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.Transparent;
            btnGoBack.BackgroundImage = Properties.Resources.left_arrow;
            btnGoBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnGoBack.FlatAppearance.BorderSize = 0;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Location = new Point(2, 32);
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
            btnMinimize.Click += btnClose_Click;
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
            // flowList
            // 
            flowList.AutoScroll = true;
            flowList.BackColor = Color.Transparent;
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
            flowList.Controls.Add(btnUpdate);
            flowList.Location = new Point(0, 110);
            flowList.Name = "flowList";
            flowList.Size = new Size(898, 526);
            flowList.TabIndex = 45;
            // 
            // bloodSugar
            // 
            bloodSugar.BackColor = Color.Transparent;
            bloodSugar.EnabledTexBox = false;
            bloodSugar.ItemImageInfo = Properties.Resources.blood_sugar;
            bloodSugar.ItemNameInfo = "Đường huyết";
            bloodSugar.ItemUnitInfo = "mg/DL";
            bloodSugar.ItemValueTextBox = null;
            bloodSugar.Location = new Point(20, 3);
            bloodSugar.Margin = new Padding(20, 3, 3, 0);
            bloodSugar.Name = "bloodSugar";
            bloodSugar.PlaceHolderTexBox = "Đường huyết";
            bloodSugar.Size = new Size(260, 215);
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
            spo2.Location = new Point(303, 3);
            spo2.Margin = new Padding(20, 3, 3, 0);
            spo2.Name = "spo2";
            spo2.PlaceHolderTexBox = "Chỉ số SPO2 (%)";
            spo2.Size = new Size(260, 215);
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
            bloodPressure.Location = new Point(586, 3);
            bloodPressure.Margin = new Padding(20, 3, 3, 0);
            bloodPressure.Name = "bloodPressure";
            bloodPressure.PlaceHolderTexBox = "Huyết áp";
            bloodPressure.Size = new Size(260, 215);
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
            heartRate.Location = new Point(20, 238);
            heartRate.Margin = new Padding(20, 20, 3, 0);
            heartRate.Name = "heartRate";
            heartRate.PlaceHolderTexBox = "Nhịp tim";
            heartRate.Size = new Size(260, 215);
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
            temperature.Location = new Point(303, 238);
            temperature.Margin = new Padding(20, 20, 3, 0);
            temperature.Name = "temperature";
            temperature.PlaceHolderTexBox = "Nhiệt độ";
            temperature.Size = new Size(260, 215);
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
            height.Location = new Point(586, 238);
            height.Margin = new Padding(20, 20, 3, 0);
            height.Name = "height";
            height.PlaceHolderTexBox = "Chiêu cao";
            height.Size = new Size(260, 215);
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
            weight.Location = new Point(20, 473);
            weight.Margin = new Padding(20, 20, 3, 0);
            weight.Name = "weight";
            weight.PlaceHolderTexBox = "Cân nặng";
            weight.Size = new Size(260, 215);
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
            bmi.Location = new Point(303, 473);
            bmi.Margin = new Padding(20, 20, 3, 0);
            bmi.Name = "bmi";
            bmi.PlaceHolderTexBox = "Chỉ số BMI";
            bmi.Size = new Size(260, 215);
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
            bloodType.Location = new Point(586, 473);
            bloodType.Margin = new Padding(20, 20, 3, 0);
            bloodType.Name = "bloodType";
            bloodType.PlaceHolderTexBox = "Nhóm máu";
            bloodType.Size = new Size(260, 215);
            bloodType.TabIndex = 66;
            // 
            // allergy
            // 
            allergy.BackColor = Color.Transparent;
            allergy.EnabledTexBox = false;
            allergy.ItemNameInfo = "Tiền sử dị ứng";
            allergy.ItemValueTextBox = null;
            allergy.Location = new Point(20, 708);
            allergy.Margin = new Padding(20, 20, 3, 10);
            allergy.Name = "allergy";
            allergy.PlaceHolderTexBox = "Nhập mô tả";
            allergy.Size = new Size(260, 320);
            allergy.TabIndex = 67;
            // 
            // sick
            // 
            sick.BackColor = Color.Transparent;
            sick.EnabledTexBox = false;
            sick.ItemNameInfo = "Tiền sử bệnh";
            sick.ItemValueTextBox = null;
            sick.Location = new Point(303, 708);
            sick.Margin = new Padding(20, 20, 3, 10);
            sick.Name = "sick";
            sick.PlaceHolderTexBox = "Nhập mô tả";
            sick.Size = new Size(260, 320);
            sick.TabIndex = 68;
            // 
            // surgery
            // 
            surgery.BackColor = Color.Transparent;
            surgery.EnabledTexBox = false;
            surgery.ItemNameInfo = "Tiển sử phẩu thuật";
            surgery.ItemValueTextBox = null;
            surgery.Location = new Point(586, 708);
            surgery.Margin = new Padding(20, 20, 3, 10);
            surgery.Name = "surgery";
            surgery.PlaceHolderTexBox = "Nhập mô tả";
            surgery.Size = new Size(260, 320);
            surgery.TabIndex = 69;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DodgerBlue;
            btnUpdate.BackgroundColor = Color.DodgerBlue;
            btnUpdate.BorderColor = Color.PaleVioletRed;
            btnUpdate.BorderRadius = 20;
            btnUpdate.BorderSize = 0;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Roboto", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(296, 1068);
            btnUpdate.Margin = new Padding(296, 30, 3, 30);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(272, 58);
            btnUpdate.TabIndex = 57;
            btnUpdate.Text = "Chỉnh sửa thông tin";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Anamnesis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 640);
            Controls.Add(flowList);
            Controls.Add(label1);
            Controls.Add(btnGoBack);
            Controls.Add(upbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Anamnesis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anamnesis";
            Load += Anamnesis_Load;
            upbar.ResumeLayout(false);
            flowList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGoBack;
        private Panel upbar;
        private Button btnMinimize;
        private Button btnClose;
        private FlowLayoutPanel flowList;
        private RJCodeAdvance.RJControls.RJButton btnUpdate;
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
    }
}