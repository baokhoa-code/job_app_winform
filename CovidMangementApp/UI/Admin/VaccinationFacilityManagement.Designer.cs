using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CovidMangementApp.UI.Admin
{
    partial class VaccinationFacilityManagement
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
            btnOpenAdd = new RJCodeAdvance.RJControls.RJButton();
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            btnGoBack = new Button();
            gridView = new DataGridView();
            coverPanel = new Panel();
            pnlInfoFacility = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label6 = new Label();
            txtInfoVFCode = new MaterialSkin.Controls.MaterialTextBox();
            label17 = new Label();
            txtInfoVFName = new MaterialSkin.Controls.MaterialTextBox();
            label22 = new Label();
            cbxInfoCity = new MaterialSkin.Controls.MaterialComboBox();
            label23 = new Label();
            cbxInfoDistrict = new MaterialSkin.Controls.MaterialComboBox();
            label24 = new Label();
            cbxInfoWard = new MaterialSkin.Controls.MaterialComboBox();
            label25 = new Label();
            txtInfoAddress = new MaterialSkin.Controls.MaterialTextBox();
            btnUpdate = new RJCodeAdvance.RJControls.RJButton();
            label38 = new Label();
            pnlAddFacility = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label3 = new Label();
            txtAddVFCode = new MaterialSkin.Controls.MaterialTextBox();
            label4 = new Label();
            txtAddVFName = new MaterialSkin.Controls.MaterialTextBox();
            label12 = new Label();
            cbxAddCity = new MaterialSkin.Controls.MaterialComboBox();
            label13 = new Label();
            cbxAddDistrict = new MaterialSkin.Controls.MaterialComboBox();
            label14 = new Label();
            cbxAddWard = new MaterialSkin.Controls.MaterialComboBox();
            label15 = new Label();
            txtAddAddress = new MaterialSkin.Controls.MaterialTextBox();
            btnAdd = new RJCodeAdvance.RJControls.RJButton();
            label2 = new Label();
            upbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            coverPanel.SuspendLayout();
            pnlInfoFacility.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlAddFacility.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(160, 40);
            label1.Name = "label1";
            label1.Size = new Size(606, 46);
            label1.TabIndex = 34;
            label1.Text = "QUẢN LÍ CƠ SỞ TIÊM CHỦNG";
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
            txtSearch.Size = new Size(625, 50);
            txtSearch.TabIndex = 35;
            txtSearch.Text = "";
            txtSearch.TrailingIcon = null;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnOpenAdd
            // 
            btnOpenAdd.BackColor = Color.ForestGreen;
            btnOpenAdd.BackgroundColor = Color.ForestGreen;
            btnOpenAdd.BorderColor = Color.PaleVioletRed;
            btnOpenAdd.BorderRadius = 20;
            btnOpenAdd.BorderSize = 0;
            btnOpenAdd.FlatAppearance.BorderSize = 0;
            btnOpenAdd.FlatStyle = FlatStyle.Flat;
            btnOpenAdd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpenAdd.ForeColor = Color.White;
            btnOpenAdd.Location = new Point(625, 102);
            btnOpenAdd.Name = "btnOpenAdd";
            btnOpenAdd.Size = new Size(272, 50);
            btnOpenAdd.TabIndex = 37;
            btnOpenAdd.Text = "Thêm cơ sở tiêm";
            btnOpenAdd.TextColor = Color.White;
            btnOpenAdd.UseVisualStyleBackColor = false;
            btnOpenAdd.Click += btnOpenAdd_Click;
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
            coverPanel.Controls.Add(pnlInfoFacility);
            coverPanel.Controls.Add(pnlAddFacility);
            coverPanel.ForeColor = Color.FromArgb(100, 0, 0);
            coverPanel.Location = new Point(0, 89);
            coverPanel.Name = "coverPanel";
            coverPanel.Size = new Size(900, 551);
            coverPanel.TabIndex = 43;
            coverPanel.Visible = false;
            coverPanel.Click += coverPanel_Click;
            // 
            // pnlInfoFacility
            // 
            pnlInfoFacility.BackColor = Color.White;
            pnlInfoFacility.Controls.Add(flowLayoutPanel1);
            pnlInfoFacility.Controls.Add(label38);
            pnlInfoFacility.Location = new Point(230, 51);
            pnlInfoFacility.Name = "pnlInfoFacility";
            pnlInfoFacility.Size = new Size(440, 449);
            pnlInfoFacility.TabIndex = 50;
            pnlInfoFacility.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(txtInfoVFCode);
            flowLayoutPanel1.Controls.Add(label17);
            flowLayoutPanel1.Controls.Add(txtInfoVFName);
            flowLayoutPanel1.Controls.Add(label22);
            flowLayoutPanel1.Controls.Add(cbxInfoCity);
            flowLayoutPanel1.Controls.Add(label23);
            flowLayoutPanel1.Controls.Add(cbxInfoDistrict);
            flowLayoutPanel1.Controls.Add(label24);
            flowLayoutPanel1.Controls.Add(cbxInfoWard);
            flowLayoutPanel1.Controls.Add(label25);
            flowLayoutPanel1.Controls.Add(txtInfoAddress);
            flowLayoutPanel1.Controls.Add(btnUpdate);
            flowLayoutPanel1.Location = new Point(7, 42);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(427, 394);
            flowLayoutPanel1.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(0, 8);
            label6.Margin = new Padding(0, 8, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 23;
            label6.Text = "Mã cơ sở:";
            // 
            // txtInfoVFCode
            // 
            txtInfoVFCode.AnimateReadOnly = false;
            txtInfoVFCode.BackColor = Color.White;
            txtInfoVFCode.BorderStyle = BorderStyle.None;
            txtInfoVFCode.Depth = 0;
            txtInfoVFCode.Enabled = false;
            txtInfoVFCode.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInfoVFCode.LeadingIcon = null;
            txtInfoVFCode.Location = new Point(3, 33);
            txtInfoVFCode.Margin = new Padding(3, 5, 3, 0);
            txtInfoVFCode.MaxLength = 50;
            txtInfoVFCode.MouseState = MaterialSkin.MouseState.OUT;
            txtInfoVFCode.Multiline = false;
            txtInfoVFCode.Name = "txtInfoVFCode";
            txtInfoVFCode.Size = new Size(400, 50);
            txtInfoVFCode.TabIndex = 39;
            txtInfoVFCode.Text = "";
            txtInfoVFCode.TrailingIcon = null;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(0, 91);
            label17.Margin = new Padding(0, 8, 0, 0);
            label17.Name = "label17";
            label17.Size = new Size(89, 20);
            label17.TabIndex = 58;
            label17.Text = "Tên cơ sở:";
            // 
            // txtInfoVFName
            // 
            txtInfoVFName.AnimateReadOnly = false;
            txtInfoVFName.BackColor = Color.White;
            txtInfoVFName.BorderStyle = BorderStyle.None;
            txtInfoVFName.Depth = 0;
            txtInfoVFName.Enabled = false;
            txtInfoVFName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInfoVFName.LeadingIcon = null;
            txtInfoVFName.Location = new Point(3, 114);
            txtInfoVFName.MaxLength = 50;
            txtInfoVFName.MouseState = MaterialSkin.MouseState.OUT;
            txtInfoVFName.Multiline = false;
            txtInfoVFName.Name = "txtInfoVFName";
            txtInfoVFName.Size = new Size(400, 50);
            txtInfoVFName.TabIndex = 46;
            txtInfoVFName.Text = "";
            txtInfoVFName.TrailingIcon = null;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(0, 175);
            label22.Margin = new Padding(0, 8, 0, 0);
            label22.Name = "label22";
            label22.Size = new Size(159, 20);
            label22.TabIndex = 62;
            label22.Text = "Tỉnh/Thành phố (*)";
            // 
            // cbxInfoCity
            // 
            cbxInfoCity.AutoResize = false;
            cbxInfoCity.BackColor = Color.FromArgb(255, 255, 255);
            cbxInfoCity.Depth = 0;
            cbxInfoCity.DrawMode = DrawMode.OwnerDrawVariable;
            cbxInfoCity.DropDownHeight = 174;
            cbxInfoCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxInfoCity.DropDownWidth = 121;
            cbxInfoCity.Enabled = false;
            cbxInfoCity.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxInfoCity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxInfoCity.FormattingEnabled = true;
            cbxInfoCity.IntegralHeight = false;
            cbxInfoCity.ItemHeight = 43;
            cbxInfoCity.Location = new Point(3, 198);
            cbxInfoCity.MaxDropDownItems = 4;
            cbxInfoCity.MouseState = MaterialSkin.MouseState.OUT;
            cbxInfoCity.Name = "cbxInfoCity";
            cbxInfoCity.Size = new Size(400, 49);
            cbxInfoCity.StartIndex = 0;
            cbxInfoCity.TabIndex = 52;
            cbxInfoCity.SelectedIndexChanged += cbxInfoCity_SelectedIndexChanged;
            cbxInfoCity.MouseWheel += cbx_MouseWheel;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(0, 258);
            label23.Margin = new Padding(0, 8, 0, 0);
            label23.Name = "label23";
            label23.Size = new Size(130, 20);
            label23.TabIndex = 63;
            label23.Text = "Quận/Huyện (*)";
            // 
            // cbxInfoDistrict
            // 
            cbxInfoDistrict.AutoResize = false;
            cbxInfoDistrict.BackColor = Color.FromArgb(255, 255, 255);
            cbxInfoDistrict.Depth = 0;
            cbxInfoDistrict.DrawMode = DrawMode.OwnerDrawVariable;
            cbxInfoDistrict.DropDownHeight = 174;
            cbxInfoDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxInfoDistrict.DropDownWidth = 121;
            cbxInfoDistrict.Enabled = false;
            cbxInfoDistrict.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxInfoDistrict.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxInfoDistrict.FormattingEnabled = true;
            cbxInfoDistrict.IntegralHeight = false;
            cbxInfoDistrict.ItemHeight = 43;
            cbxInfoDistrict.Location = new Point(3, 281);
            cbxInfoDistrict.MaxDropDownItems = 4;
            cbxInfoDistrict.MouseState = MaterialSkin.MouseState.OUT;
            cbxInfoDistrict.Name = "cbxInfoDistrict";
            cbxInfoDistrict.Size = new Size(400, 49);
            cbxInfoDistrict.StartIndex = 0;
            cbxInfoDistrict.TabIndex = 53;
            cbxInfoDistrict.SelectedIndexChanged += cbxInfoDistrict_SelectedIndexChanged;
            cbxInfoDistrict.MouseWheel += cbx_MouseWheel;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(0, 341);
            label24.Margin = new Padding(0, 8, 0, 0);
            label24.Name = "label24";
            label24.Size = new Size(120, 20);
            label24.TabIndex = 64;
            label24.Text = "Phường/Xã (*)";
            // 
            // cbxInfoWard
            // 
            cbxInfoWard.AutoResize = false;
            cbxInfoWard.BackColor = Color.FromArgb(255, 255, 255);
            cbxInfoWard.Depth = 0;
            cbxInfoWard.DrawMode = DrawMode.OwnerDrawVariable;
            cbxInfoWard.DropDownHeight = 174;
            cbxInfoWard.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxInfoWard.DropDownWidth = 121;
            cbxInfoWard.Enabled = false;
            cbxInfoWard.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxInfoWard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxInfoWard.FormattingEnabled = true;
            cbxInfoWard.IntegralHeight = false;
            cbxInfoWard.ItemHeight = 43;
            cbxInfoWard.Location = new Point(3, 364);
            cbxInfoWard.MaxDropDownItems = 4;
            cbxInfoWard.MouseState = MaterialSkin.MouseState.OUT;
            cbxInfoWard.Name = "cbxInfoWard";
            cbxInfoWard.Size = new Size(400, 49);
            cbxInfoWard.StartIndex = 0;
            cbxInfoWard.TabIndex = 54;
            cbxInfoWard.MouseWheel += cbx_MouseWheel;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(0, 424);
            label25.Margin = new Padding(0, 8, 0, 0);
            label25.Name = "label25";
            label25.Size = new Size(153, 20);
            label25.TabIndex = 65;
            label25.Text = "Thôn/Xóm/Nhà (*)";
            // 
            // txtInfoAddress
            // 
            txtInfoAddress.AnimateReadOnly = false;
            txtInfoAddress.BorderStyle = BorderStyle.None;
            txtInfoAddress.Depth = 0;
            txtInfoAddress.Enabled = false;
            txtInfoAddress.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInfoAddress.LeadingIcon = null;
            txtInfoAddress.Location = new Point(3, 447);
            txtInfoAddress.MaxLength = 50;
            txtInfoAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtInfoAddress.Multiline = false;
            txtInfoAddress.Name = "txtInfoAddress";
            txtInfoAddress.Size = new Size(400, 50);
            txtInfoAddress.TabIndex = 55;
            txtInfoAddress.Text = "";
            txtInfoAddress.TrailingIcon = null;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Blue;
            btnUpdate.BackgroundColor = Color.Blue;
            btnUpdate.BorderColor = Color.PaleVioletRed;
            btnUpdate.BorderRadius = 20;
            btnUpdate.BorderSize = 0;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(95, 503);
            btnUpdate.Margin = new Padding(95, 3, 3, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(220, 38);
            btnUpdate.TabIndex = 66;
            btnUpdate.Text = "Chỉnh sửa thông tin";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.BackColor = Color.Transparent;
            label38.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label38.ForeColor = Color.Blue;
            label38.Location = new Point(10, 5);
            label38.Name = "label38";
            label38.Size = new Size(413, 29);
            label38.TabIndex = 26;
            label38.Text = "THÔNG TIN CƠ SỞ TIÊM CHỦNG";
            // 
            // pnlAddFacility
            // 
            pnlAddFacility.BackColor = Color.White;
            pnlAddFacility.Controls.Add(flowLayoutPanel2);
            pnlAddFacility.Controls.Add(label2);
            pnlAddFacility.Location = new Point(230, 51);
            pnlAddFacility.Name = "pnlAddFacility";
            pnlAddFacility.Size = new Size(440, 449);
            pnlAddFacility.TabIndex = 49;
            pnlAddFacility.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(txtAddVFCode);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(txtAddVFName);
            flowLayoutPanel2.Controls.Add(label12);
            flowLayoutPanel2.Controls.Add(cbxAddCity);
            flowLayoutPanel2.Controls.Add(label13);
            flowLayoutPanel2.Controls.Add(cbxAddDistrict);
            flowLayoutPanel2.Controls.Add(label14);
            flowLayoutPanel2.Controls.Add(cbxAddWard);
            flowLayoutPanel2.Controls.Add(label15);
            flowLayoutPanel2.Controls.Add(txtAddAddress);
            flowLayoutPanel2.Controls.Add(btnAdd);
            flowLayoutPanel2.Location = new Point(7, 42);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(427, 394);
            flowLayoutPanel2.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 8);
            label3.Margin = new Padding(0, 8, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 23;
            label3.Text = "Mã cơ sở:";
            // 
            // txtAddVFCode
            // 
            txtAddVFCode.AnimateReadOnly = false;
            txtAddVFCode.BackColor = Color.White;
            txtAddVFCode.BorderStyle = BorderStyle.None;
            txtAddVFCode.Depth = 0;
            txtAddVFCode.Enabled = false;
            txtAddVFCode.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddVFCode.LeadingIcon = null;
            txtAddVFCode.Location = new Point(3, 33);
            txtAddVFCode.Margin = new Padding(3, 5, 3, 0);
            txtAddVFCode.MaxLength = 50;
            txtAddVFCode.MouseState = MaterialSkin.MouseState.OUT;
            txtAddVFCode.Multiline = false;
            txtAddVFCode.Name = "txtAddVFCode";
            txtAddVFCode.ReadOnly = true;
            txtAddVFCode.Size = new Size(400, 50);
            txtAddVFCode.TabIndex = 39;
            txtAddVFCode.Text = "";
            txtAddVFCode.TrailingIcon = null;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(0, 91);
            label4.Margin = new Padding(0, 8, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 43;
            label4.Text = "Tên cơ sở:";
            // 
            // txtAddVFName
            // 
            txtAddVFName.AnimateReadOnly = false;
            txtAddVFName.BackColor = Color.WhiteSmoke;
            txtAddVFName.BorderStyle = BorderStyle.None;
            txtAddVFName.Depth = 0;
            txtAddVFName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddVFName.LeadingIcon = null;
            txtAddVFName.Location = new Point(3, 116);
            txtAddVFName.Margin = new Padding(3, 5, 3, 0);
            txtAddVFName.MaxLength = 50;
            txtAddVFName.MouseState = MaterialSkin.MouseState.OUT;
            txtAddVFName.Multiline = false;
            txtAddVFName.Name = "txtAddVFName";
            txtAddVFName.Size = new Size(400, 50);
            txtAddVFName.TabIndex = 45;
            txtAddVFName.Text = "";
            txtAddVFName.TrailingIcon = null;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(0, 174);
            label12.Margin = new Padding(0, 8, 0, 0);
            label12.Name = "label12";
            label12.Size = new Size(159, 20);
            label12.TabIndex = 62;
            label12.Text = "Tỉnh/Thành phố (*)";
            // 
            // cbxAddCity
            // 
            cbxAddCity.AutoResize = false;
            cbxAddCity.BackColor = Color.FromArgb(255, 255, 255);
            cbxAddCity.Depth = 0;
            cbxAddCity.DrawMode = DrawMode.OwnerDrawVariable;
            cbxAddCity.DropDownHeight = 174;
            cbxAddCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAddCity.DropDownWidth = 121;
            cbxAddCity.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxAddCity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxAddCity.FormattingEnabled = true;
            cbxAddCity.IntegralHeight = false;
            cbxAddCity.ItemHeight = 43;
            cbxAddCity.Location = new Point(3, 197);
            cbxAddCity.MaxDropDownItems = 4;
            cbxAddCity.MouseState = MaterialSkin.MouseState.OUT;
            cbxAddCity.Name = "cbxAddCity";
            cbxAddCity.Size = new Size(400, 49);
            cbxAddCity.StartIndex = 0;
            cbxAddCity.TabIndex = 52;
            cbxAddCity.SelectedIndexChanged += cbxAddCity_SelectedIndexChanged;
            cbxAddCity.MouseWheel += cbx_MouseWheel;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(0, 257);
            label13.Margin = new Padding(0, 8, 0, 0);
            label13.Name = "label13";
            label13.Size = new Size(130, 20);
            label13.TabIndex = 63;
            label13.Text = "Quận/Huyện (*)";
            // 
            // cbxAddDistrict
            // 
            cbxAddDistrict.AutoResize = false;
            cbxAddDistrict.BackColor = Color.FromArgb(255, 255, 255);
            cbxAddDistrict.Depth = 0;
            cbxAddDistrict.DrawMode = DrawMode.OwnerDrawVariable;
            cbxAddDistrict.DropDownHeight = 174;
            cbxAddDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAddDistrict.DropDownWidth = 121;
            cbxAddDistrict.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxAddDistrict.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxAddDistrict.FormattingEnabled = true;
            cbxAddDistrict.IntegralHeight = false;
            cbxAddDistrict.ItemHeight = 43;
            cbxAddDistrict.Location = new Point(3, 280);
            cbxAddDistrict.MaxDropDownItems = 4;
            cbxAddDistrict.MouseState = MaterialSkin.MouseState.OUT;
            cbxAddDistrict.Name = "cbxAddDistrict";
            cbxAddDistrict.Size = new Size(400, 49);
            cbxAddDistrict.StartIndex = 0;
            cbxAddDistrict.TabIndex = 53;
            cbxAddDistrict.SelectedIndexChanged += cbxAddDistrict_SelectedIndexChanged;
            cbxAddDistrict.MouseWheel += cbx_MouseWheel;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(0, 340);
            label14.Margin = new Padding(0, 8, 0, 0);
            label14.Name = "label14";
            label14.Size = new Size(120, 20);
            label14.TabIndex = 64;
            label14.Text = "Phường/Xã (*)";
            // 
            // cbxAddWard
            // 
            cbxAddWard.AutoResize = false;
            cbxAddWard.BackColor = Color.FromArgb(255, 255, 255);
            cbxAddWard.Depth = 0;
            cbxAddWard.DrawMode = DrawMode.OwnerDrawVariable;
            cbxAddWard.DropDownHeight = 174;
            cbxAddWard.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAddWard.DropDownWidth = 121;
            cbxAddWard.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxAddWard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxAddWard.FormattingEnabled = true;
            cbxAddWard.IntegralHeight = false;
            cbxAddWard.ItemHeight = 43;
            cbxAddWard.Location = new Point(3, 363);
            cbxAddWard.MaxDropDownItems = 4;
            cbxAddWard.MouseState = MaterialSkin.MouseState.OUT;
            cbxAddWard.Name = "cbxAddWard";
            cbxAddWard.Size = new Size(400, 49);
            cbxAddWard.StartIndex = 0;
            cbxAddWard.TabIndex = 54;
            cbxAddWard.MouseWheel += cbx_MouseWheel;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(0, 423);
            label15.Margin = new Padding(0, 8, 0, 0);
            label15.Name = "label15";
            label15.Size = new Size(153, 20);
            label15.TabIndex = 65;
            label15.Text = "Thôn/Xóm/Nhà (*)";
            // 
            // txtAddAddress
            // 
            txtAddAddress.AnimateReadOnly = false;
            txtAddAddress.BorderStyle = BorderStyle.None;
            txtAddAddress.Depth = 0;
            txtAddAddress.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddAddress.LeadingIcon = null;
            txtAddAddress.Location = new Point(3, 446);
            txtAddAddress.MaxLength = 50;
            txtAddAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtAddAddress.Multiline = false;
            txtAddAddress.Name = "txtAddAddress";
            txtAddAddress.Size = new Size(400, 50);
            txtAddAddress.TabIndex = 55;
            txtAddAddress.Text = "";
            txtAddAddress.TrailingIcon = null;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Blue;
            btnAdd.BackgroundColor = Color.Blue;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 20;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(115, 502);
            btnAdd.Margin = new Padding(115, 3, 3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(196, 38);
            btnAdd.TabIndex = 66;
            btnAdd.Text = "Đăng ký thông tin";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(50, 5);
            label2.Name = "label2";
            label2.Size = new Size(343, 29);
            label2.TabIndex = 26;
            label2.Text = "THÊM CƠ SỞ TIÊM CHỦNG";
            // 
            // VaccinationFacilityManagement
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
            Controls.Add(btnOpenAdd);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VaccinationFacilityManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VaccinationFacilityManagement";
            upbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            coverPanel.ResumeLayout(false);
            pnlInfoFacility.ResumeLayout(false);
            pnlInfoFacility.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnlAddFacility.ResumeLayout(false);
            pnlAddFacility.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private RJCodeAdvance.RJControls.RJButton btnOpenAdd;
        private Panel upbar;
        private Button btnMinimize;
        private Button btnClose;
        private Button btnGoBack;
        private DataGridView gridView;
        private Panel coverPanel;
        private Panel pnlAddFacility;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox txtAddVFCode;
        private Label label4;
        private MaterialSkin.Controls.MaterialTextBox txtAddVFName;
        private Label label12;
        private MaterialSkin.Controls.MaterialComboBox cbxAddCity;
        private Label label13;
        private MaterialSkin.Controls.MaterialComboBox cbxAddDistrict;
        private Label label14;
        private MaterialSkin.Controls.MaterialComboBox cbxAddWard;
        private Label label15;
        private MaterialSkin.Controls.MaterialTextBox txtAddAddress;
        private RJCodeAdvance.RJControls.RJButton btnAdd;
        private Panel pnlInfoFacility;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label6;
        private MaterialSkin.Controls.MaterialTextBox txtInfoVFCode;
        private Label label17;
        private MaterialSkin.Controls.MaterialTextBox txtInfoVFName;
        private MaterialSkin.Controls.MaterialComboBox cbxInfoCity;
        private Label label23;
        private MaterialSkin.Controls.MaterialComboBox cbxInfoDistrict;
        private Label label24;
        private MaterialSkin.Controls.MaterialComboBox cbxInfoWard;
        private Label label25;
        private MaterialSkin.Controls.MaterialTextBox txtInfoAddress;
        private RJCodeAdvance.RJControls.RJButton btnUpdate;
        private Label label38;
        private Label label22;
    }
}