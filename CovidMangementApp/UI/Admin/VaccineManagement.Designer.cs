using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CovidMangementApp.UI.Admin
{
    partial class VaccineManagement
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            btnOpenAdd = new RJCodeAdvance.RJControls.RJButton();
            upbar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            btnGoBack = new Button();
            gridView = new DataGridView();
            coverPanel = new Panel();
            pnlInfoVaccine = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label6 = new Label();
            txtInfoCode = new MaterialSkin.Controls.MaterialTextBox();
            label17 = new Label();
            txtInfoName = new MaterialSkin.Controls.MaterialTextBox();
            label24 = new Label();
            cbxInfoCountry = new MaterialSkin.Controls.MaterialComboBox();
            label25 = new Label();
            txtInfoManufacure = new MaterialSkin.Controls.MaterialTextBox();
            btnUpdate = new RJCodeAdvance.RJControls.RJButton();
            label38 = new Label();
            pnlAddVaccine = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label3 = new Label();
            txtAddCode = new MaterialSkin.Controls.MaterialTextBox();
            label4 = new Label();
            txtAddName = new MaterialSkin.Controls.MaterialTextBox();
            label14 = new Label();
            cbxAddCountry = new MaterialSkin.Controls.MaterialComboBox();
            label15 = new Label();
            txtAddManufacure = new MaterialSkin.Controls.MaterialTextBox();
            btnAdd = new RJCodeAdvance.RJControls.RJButton();
            label2 = new Label();
            upbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            coverPanel.SuspendLayout();
            pnlInfoVaccine.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlAddVaccine.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(265, 40);
            label1.Name = "label1";
            label1.Size = new Size(365, 46);
            label1.TabIndex = 34;
            label1.Text = "QUẢN LÍ VẮC XIN";
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
            btnOpenAdd.Text = "Thêm vắc xin";
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.ForestGreen;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            coverPanel.Controls.Add(pnlInfoVaccine);
            coverPanel.Controls.Add(pnlAddVaccine);
            coverPanel.ForeColor = Color.FromArgb(100, 0, 0);
            coverPanel.Location = new Point(0, 89);
            coverPanel.Name = "coverPanel";
            coverPanel.Size = new Size(900, 551);
            coverPanel.TabIndex = 43;
            coverPanel.Visible = false;
            coverPanel.Click += coverPanel_Click;
            // 
            // pnlInfoVaccine
            // 
            pnlInfoVaccine.BackColor = Color.White;
            pnlInfoVaccine.Controls.Add(flowLayoutPanel1);
            pnlInfoVaccine.Controls.Add(label38);
            pnlInfoVaccine.Location = new Point(230, 51);
            pnlInfoVaccine.Name = "pnlInfoVaccine";
            pnlInfoVaccine.Size = new Size(440, 449);
            pnlInfoVaccine.TabIndex = 50;
            pnlInfoVaccine.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(txtInfoCode);
            flowLayoutPanel1.Controls.Add(label17);
            flowLayoutPanel1.Controls.Add(txtInfoName);
            flowLayoutPanel1.Controls.Add(label24);
            flowLayoutPanel1.Controls.Add(cbxInfoCountry);
            flowLayoutPanel1.Controls.Add(label25);
            flowLayoutPanel1.Controls.Add(txtInfoManufacure);
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
            label6.Size = new Size(105, 20);
            label6.TabIndex = 23;
            label6.Text = "Mã vắc xin:";
            // 
            // txtInfoCode
            // 
            txtInfoCode.AnimateReadOnly = false;
            txtInfoCode.BackColor = Color.White;
            txtInfoCode.BorderStyle = BorderStyle.None;
            txtInfoCode.Depth = 0;
            txtInfoCode.Enabled = false;
            txtInfoCode.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInfoCode.LeadingIcon = null;
            txtInfoCode.Location = new Point(3, 33);
            txtInfoCode.Margin = new Padding(3, 5, 3, 0);
            txtInfoCode.MaxLength = 50;
            txtInfoCode.MouseState = MaterialSkin.MouseState.OUT;
            txtInfoCode.Multiline = false;
            txtInfoCode.Name = "txtInfoCode";
            txtInfoCode.Size = new Size(400, 50);
            txtInfoCode.TabIndex = 39;
            txtInfoCode.Text = "";
            txtInfoCode.TrailingIcon = null;
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
            label17.Size = new Size(102, 20);
            label17.TabIndex = 58;
            label17.Text = "Tên vắc xin:";
            // 
            // txtInfoName
            // 
            txtInfoName.AnimateReadOnly = false;
            txtInfoName.BackColor = Color.White;
            txtInfoName.BorderStyle = BorderStyle.None;
            txtInfoName.Depth = 0;
            txtInfoName.Enabled = false;
            txtInfoName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInfoName.LeadingIcon = null;
            txtInfoName.Location = new Point(3, 114);
            txtInfoName.MaxLength = 50;
            txtInfoName.MouseState = MaterialSkin.MouseState.OUT;
            txtInfoName.Multiline = false;
            txtInfoName.Name = "txtInfoName";
            txtInfoName.Size = new Size(400, 50);
            txtInfoName.TabIndex = 46;
            txtInfoName.Text = "";
            txtInfoName.TrailingIcon = null;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(0, 175);
            label24.Margin = new Padding(0, 8, 0, 0);
            label24.Name = "label24";
            label24.Size = new Size(102, 20);
            label24.TabIndex = 64;
            label24.Text = "Quốc gia (*)";
            // 
            // cbxInfoCountry
            // 
            cbxInfoCountry.AutoResize = false;
            cbxInfoCountry.BackColor = Color.FromArgb(255, 255, 255);
            cbxInfoCountry.Depth = 0;
            cbxInfoCountry.DrawMode = DrawMode.OwnerDrawVariable;
            cbxInfoCountry.DropDownHeight = 174;
            cbxInfoCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxInfoCountry.DropDownWidth = 121;
            cbxInfoCountry.Enabled = false;
            cbxInfoCountry.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxInfoCountry.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxInfoCountry.FormattingEnabled = true;
            cbxInfoCountry.IntegralHeight = false;
            cbxInfoCountry.ItemHeight = 43;
            cbxInfoCountry.Location = new Point(3, 198);
            cbxInfoCountry.MaxDropDownItems = 4;
            cbxInfoCountry.MouseState = MaterialSkin.MouseState.OUT;
            cbxInfoCountry.Name = "cbxInfoCountry";
            cbxInfoCountry.Size = new Size(400, 49);
            cbxInfoCountry.StartIndex = 0;
            cbxInfoCountry.TabIndex = 54;
            cbxInfoCountry.MouseWheel += cbx_MouseWheel;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(0, 258);
            label25.Margin = new Padding(0, 8, 0, 0);
            label25.Name = "label25";
            label25.Size = new Size(194, 20);
            label25.TabIndex = 65;
            label25.Text = "Tên công ty sản xuất (*)";
            // 
            // txtInfoManufacure
            // 
            txtInfoManufacure.AnimateReadOnly = false;
            txtInfoManufacure.BorderStyle = BorderStyle.None;
            txtInfoManufacure.Depth = 0;
            txtInfoManufacure.Enabled = false;
            txtInfoManufacure.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInfoManufacure.LeadingIcon = null;
            txtInfoManufacure.Location = new Point(3, 281);
            txtInfoManufacure.MaxLength = 50;
            txtInfoManufacure.MouseState = MaterialSkin.MouseState.OUT;
            txtInfoManufacure.Multiline = false;
            txtInfoManufacure.Name = "txtInfoManufacure";
            txtInfoManufacure.Size = new Size(400, 50);
            txtInfoManufacure.TabIndex = 55;
            txtInfoManufacure.Text = "";
            txtInfoManufacure.TrailingIcon = null;
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
            btnUpdate.Location = new Point(95, 337);
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
            label38.Location = new Point(85, 5);
            label38.Name = "label38";
            label38.Size = new Size(264, 29);
            label38.TabIndex = 26;
            label38.Text = "THÔNG TIN VẮC XIN";
            // 
            // pnlAddVaccine
            // 
            pnlAddVaccine.BackColor = Color.White;
            pnlAddVaccine.Controls.Add(flowLayoutPanel2);
            pnlAddVaccine.Controls.Add(label2);
            pnlAddVaccine.Location = new Point(230, 51);
            pnlAddVaccine.Name = "pnlAddVaccine";
            pnlAddVaccine.Size = new Size(440, 449);
            pnlAddVaccine.TabIndex = 49;
            pnlAddVaccine.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(txtAddCode);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(txtAddName);
            flowLayoutPanel2.Controls.Add(label14);
            flowLayoutPanel2.Controls.Add(cbxAddCountry);
            flowLayoutPanel2.Controls.Add(label15);
            flowLayoutPanel2.Controls.Add(txtAddManufacure);
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
            label3.Size = new Size(105, 20);
            label3.TabIndex = 23;
            label3.Text = "Mã vắc xin:";
            // 
            // txtAddCode
            // 
            txtAddCode.AnimateReadOnly = false;
            txtAddCode.BackColor = Color.White;
            txtAddCode.BorderStyle = BorderStyle.None;
            txtAddCode.Depth = 0;
            txtAddCode.Enabled = false;
            txtAddCode.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddCode.LeadingIcon = null;
            txtAddCode.Location = new Point(3, 33);
            txtAddCode.Margin = new Padding(3, 5, 3, 0);
            txtAddCode.MaxLength = 50;
            txtAddCode.MouseState = MaterialSkin.MouseState.OUT;
            txtAddCode.Multiline = false;
            txtAddCode.Name = "txtAddCode";
            txtAddCode.ReadOnly = true;
            txtAddCode.Size = new Size(400, 50);
            txtAddCode.TabIndex = 39;
            txtAddCode.Text = "";
            txtAddCode.TrailingIcon = null;
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
            label4.Size = new Size(111, 20);
            label4.TabIndex = 43;
            label4.Text = "Tên vắc xin:";
            // 
            // txtAddName
            // 
            txtAddName.AnimateReadOnly = false;
            txtAddName.BackColor = Color.WhiteSmoke;
            txtAddName.BorderStyle = BorderStyle.None;
            txtAddName.Depth = 0;
            txtAddName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddName.LeadingIcon = null;
            txtAddName.Location = new Point(3, 116);
            txtAddName.Margin = new Padding(3, 5, 3, 0);
            txtAddName.MaxLength = 50;
            txtAddName.MouseState = MaterialSkin.MouseState.OUT;
            txtAddName.Multiline = false;
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(400, 50);
            txtAddName.TabIndex = 45;
            txtAddName.Text = "";
            txtAddName.TrailingIcon = null;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(0, 174);
            label14.Margin = new Padding(0, 8, 0, 0);
            label14.Name = "label14";
            label14.Size = new Size(102, 20);
            label14.TabIndex = 64;
            label14.Text = "Quốc gia (*)";
            // 
            // cbxAddCountry
            // 
            cbxAddCountry.AutoResize = false;
            cbxAddCountry.BackColor = Color.FromArgb(255, 255, 255);
            cbxAddCountry.Depth = 0;
            cbxAddCountry.DrawMode = DrawMode.OwnerDrawVariable;
            cbxAddCountry.DropDownHeight = 174;
            cbxAddCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAddCountry.DropDownWidth = 121;
            cbxAddCountry.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxAddCountry.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxAddCountry.FormattingEnabled = true;
            cbxAddCountry.IntegralHeight = false;
            cbxAddCountry.ItemHeight = 43;
            cbxAddCountry.Location = new Point(3, 197);
            cbxAddCountry.MaxDropDownItems = 4;
            cbxAddCountry.MouseState = MaterialSkin.MouseState.OUT;
            cbxAddCountry.Name = "cbxAddCountry";
            cbxAddCountry.Size = new Size(400, 49);
            cbxAddCountry.StartIndex = 0;
            cbxAddCountry.TabIndex = 54;
            cbxAddCountry.MouseWheel += cbx_MouseWheel;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(0, 257);
            label15.Margin = new Padding(0, 8, 0, 0);
            label15.Name = "label15";
            label15.Size = new Size(194, 20);
            label15.TabIndex = 65;
            label15.Text = "Tên công ty sản xuất (*)";
            // 
            // txtAddManufacure
            // 
            txtAddManufacure.AnimateReadOnly = false;
            txtAddManufacure.BorderStyle = BorderStyle.None;
            txtAddManufacure.Depth = 0;
            txtAddManufacure.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddManufacure.LeadingIcon = null;
            txtAddManufacure.Location = new Point(3, 280);
            txtAddManufacure.MaxLength = 50;
            txtAddManufacure.MouseState = MaterialSkin.MouseState.OUT;
            txtAddManufacure.Multiline = false;
            txtAddManufacure.Name = "txtAddManufacure";
            txtAddManufacure.Size = new Size(400, 50);
            txtAddManufacure.TabIndex = 55;
            txtAddManufacure.Text = "";
            txtAddManufacure.TrailingIcon = null;
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
            btnAdd.Location = new Point(115, 336);
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
            label2.Location = new Point(125, 5);
            label2.Name = "label2";
            label2.Size = new Size(194, 29);
            label2.TabIndex = 26;
            label2.Text = "THÊM VẮC XIN";
            // 
            // VaccineManagement
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
            Name = "VaccineManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VaccineManagement";
            upbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            coverPanel.ResumeLayout(false);
            pnlInfoVaccine.ResumeLayout(false);
            pnlInfoVaccine.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnlAddVaccine.ResumeLayout(false);
            pnlAddVaccine.PerformLayout();
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
        private Panel pnlAddVaccine;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox txtAddCode;
        private Label label4;
        private MaterialSkin.Controls.MaterialTextBox txtAddName;
        private Label label14;
        private MaterialSkin.Controls.MaterialComboBox cbxAddCountry;
        private Label label15;
        private MaterialSkin.Controls.MaterialTextBox txtAddManufacure;
        private RJCodeAdvance.RJControls.RJButton btnAdd;
        private Panel pnlInfoVaccine;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label6;
        private MaterialSkin.Controls.MaterialTextBox txtInfoCode;
        private Label label17;
        private MaterialSkin.Controls.MaterialTextBox txtInfoName;
        private Label label24;
        private MaterialSkin.Controls.MaterialComboBox cbxInfoCountry;
        private Label label25;
        private MaterialSkin.Controls.MaterialTextBox txtInfoManufacure;
        private RJCodeAdvance.RJControls.RJButton btnUpdate;
        private Label label38;
    }
}