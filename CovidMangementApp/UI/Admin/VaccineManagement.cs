using CovidMangementApp.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace CovidMangementApp.UI.Admin
{
    public partial class VaccineManagement : Form
    {
        private String username;
        public Point mouseLocation;
        private List<Country> countries;
        DataTable originalDataTable;
        public VaccineManagement()
        {
            InitializeComponent();
        }

        public VaccineManagement(String username)
        {
            InitializeComponent();
            this.username = username;
            BindingData();
        }
        private void BindingCountry()
        {
            countries = new List<Country>();

            string code = "SELECT * FROM COUNTRY";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();



                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        string id = reader["COUNTRY_ID"].ToString();
                        string name = reader["COUNTRY_NAME"].ToString();

                        countries.Add(new Country(id, name));
                    }

                    cbxInfoCountry.DataSource = countries;
                    cbxInfoCountry.DisplayMember = "Name";
                    cbxInfoCountry.ValueMember = "CountryCode";

                    cbxAddCountry.DataSource = countries;
                    cbxAddCountry.DisplayMember = "Name";
                    cbxAddCountry.ValueMember = "CountryCode";

                }
                else
                {
                    Notification notification = new Notification("Không tìm thấy công việc");
                    notification.ShowDialog();
                    return;
                }
                clsDatabase.CloseConnection();

            }
            catch (Exception ex)
            {
                Notification notification = new Notification("Lỗi cơ sở dữ liệu: " + ex);
                notification.ShowDialog();
            }
        }

        private void BindingVaccineList()
        {
            gridView.DataSource = null;
            gridView.Columns.Clear();

            string code = "SELECT * FROM VACCINE JOIN COUNTRY ON VACCINE.COUNTRY_ID = COUNTRY.COUNTRY_ID";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();



                if (reader.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Mã vắc xin", typeof(string));
                    table.Columns.Add("Tên vắc xin", typeof(string));
                    table.Columns.Add("Xuất sứ", typeof(string));
                    table.Columns.Add("Nhà sản xuất", typeof(string));

                    while (reader.Read())
                    {

                        table.Rows.Add(
                            reader["VACCINE_ID"].ToString(),
                            reader["VACCINE_NAME"].ToString(),
                            reader["COUNTRY_NAME"].ToString(),
                            reader["VACCINE_COMPANY"].ToString());
                    }

                    originalDataTable = table;
                    gridView.DataSource = table;


                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                    editButtonColumn.Name = "Chi tiết";
                    editButtonColumn.Text = "Chi tiết";
                    editButtonColumn.UseColumnTextForButtonValue = true;
                    gridView.Columns.Add(editButtonColumn);

                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                    deleteButtonColumn.Name = "Xóa";
                    deleteButtonColumn.Text = "Xóa";
                    deleteButtonColumn.UseColumnTextForButtonValue = true;
                    gridView.Columns.Add(deleteButtonColumn);

                    gridView.Columns["Chi tiết"].Width = 50;
                    gridView.Columns["Xóa"].Width = 50;

                }
                else
                {
                    Notification notification = new Notification("Danh sách vắc xin trống");
                    notification.ShowDialog();
                    return;
                }
                clsDatabase.CloseConnection();

            }
            catch (Exception ex)
            {
                Notification notification = new Notification("Lỗi cơ sở dữ liệu: " + ex);
                notification.ShowDialog();
            }
        }
        private void BindingData()
        {
            BindingVaccineList();
            BindingCountry();
        }
        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnOpenAdd_Click(object sender, EventArgs e)
        {

            if (coverPanel.Visible == false)
            {
                coverPanel.Visible = true;
                pnlAddVaccine.Visible = true;
            }
            else
            {
                coverPanel.Visible = false;
                pnlAddVaccine.Visible = false;
            }
            pnlInfoVaccine.Visible = false;
            ClearAddForm();

            string code = "SELECT MAX(VACCINE_ID) CODE FROM VACCINE";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();


                string id = "VACCINE01";
                if (reader.HasRows)
                {
                    try
                    {
                        reader.Read();
                        id = reader["CODE"].ToString();
                        int number = int.Parse(id.Substring(7, 2));
                        number++;
                        if (number < 10)
                        {
                            id = "VACCINE0" + number.ToString();
                        }
                        else if (number >= 10)
                        {
                            id = "VACCINE" + number.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        id = "VACCINE01";
                    }

                }
                txtAddCode.Text = id;
                clsDatabase.CloseConnection();

            }
            catch (Exception ex)
            {
                Notification notification = new Notification("Lỗi cơ sở dữ liệu: " + ex);
                notification.ShowDialog();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtAddCode.Text;
            string name = txtAddName.Text;
            string manufacture = txtAddManufacure.Text;
            string country = cbxAddCountry.SelectedValue.ToString();



            if (id.Length != 0 && name.Length != 0 && manufacture.Length != 0 && country.Length != 0)
            {
                string code3 = "INSERT INTO VACCINE VALUES (N'"
                                                    + id + "',N'" + name + "',N'" + manufacture + "',N'" + country + "')";

                try
                {
                    clsDatabase.OpenConnection();
                    SqlCommand cmd3 = new SqlCommand(code3, clsDatabase.con);
                    SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
                    cmd3.ExecuteNonQuery();
                    clsDatabase.CloseConnection();

                    Notification notification = new Notification("Bạn đã thêm vắc xin thành công");
                    notification.ShowDialog();
                    return;
                }
                catch (Exception ex)
                {

                    Notification notification3 = new Notification("Đã xảy ra lỗi, xin thử lại sau ");
                    notification3.ShowDialog();
                    clsDatabase.CloseConnection();
                    return;
                }

            }
            else
            {
                Notification notification = new Notification("Bạn phải nhập đầy đủ thông tin ở các trường có dấu (*)");
                notification.ShowDialog();
                return;
            }
        }
        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == gridView.Columns["Chi tiết"].Index)
                {
                    DataGridViewRow selectedRow = gridView.Rows[e.RowIndex];
                    string vfCode = selectedRow.Cells["Mã vắc xin"].Value.ToString();

                    openInfoForm(vfCode);

                }
                if (e.ColumnIndex == gridView.Columns["Xóa"].Index)
                {
                    DataGridViewRow selectedRow = gridView.Rows[e.RowIndex];
                    string vfCode = selectedRow.Cells["Mã vắc xin"].Value.ToString();

                    DialogResult result = MessageBox.Show("Bạn có chắc là muốn xóa vắc xin  " + vfCode + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string code2 = "DELETE FROM VACCINE WHERE VACCINE_ID = '" + vfCode + "'";

                        try
                        {
                            clsDatabase.OpenConnection();
                            SqlCommand cmd2 = new SqlCommand(code2, clsDatabase.con);
                            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);

                            cmd2.ExecuteNonQuery();

                            clsDatabase.CloseConnection();

                            Notification notification3 = new Notification("Đã xóa vắc xin thành công");
                            notification3.ShowDialog();
                            clsDatabase.CloseConnection();
                            BindingVaccineList();
                            return;

                        }
                        catch (Exception ex)
                        {
                            Notification notification = new Notification("Lỗi cơ sở dữ liệu: " + ex);
                            notification.ShowDialog();
                        }
                    }

                }
            }
        }
        private void openInfoForm(String vfCode)
        {
            coverPanel.Visible = true;
            pnlInfoVaccine.Visible = true;
            pnlAddVaccine.Visible = false;

            string code = "SELECT * FROM VACCINE WHERE VACCINE_ID='" + vfCode + "'";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    string fullname = reader["VACCINE_NAME"].ToString();
                    string manufacture = reader["VACCINE_COMPANY"].ToString();
                    string r_country = reader["COUNTRY_ID"].ToString();


                    txtInfoCode.Text = vfCode;
                    txtInfoName.Text = fullname;
                    txtInfoManufacure.Text = manufacture;

                    int indexCountry = countries.FindIndex(c => c.CountryCode == r_country);
                    if (indexCountry >= 0)
                    {
                        cbxInfoCountry.SelectedIndex = indexCountry;
                    }

                    clsDatabase.CloseConnection();
                }
                else
                {
                    Notification notification = new Notification("Không tìm thấy vắc xin này");
                    notification.ShowDialog();
                    return;
                }
                clsDatabase.CloseConnection();

            }
            catch (Exception ex)
            {
                Notification notification = new Notification("Lỗi cơ sở dữ liệu: " + ex);
                notification.ShowDialog();
            }

        }
        private void coverPanel_Click(object sender, EventArgs e)
        {
            coverPanel.Visible = false;
            pnlInfoVaccine.Visible = false;
            pnlAddVaccine.Visible = false;
            ClearAddForm();
            ClearInfoForm();
            BindingVaccineList();
            btnUpdate.Text = "Chỉnh sửa thông tin";
            txtInfoName.Enabled = false;
            txtInfoCode.Enabled = false;
            txtInfoManufacure.Enabled = false;
            cbxInfoCountry.Enabled = false;

        }
        private void ClearAddForm()
        {
            txtAddManufacure.Text = string.Empty;
            txtAddCode.Text = string.Empty;
            txtAddName.Text = string.Empty;
            cbxAddCountry.SelectedIndex = 0;

        }
        private void ClearInfoForm()
        {
            txtInfoName.Enabled = false;
            txtInfoCode.Enabled = false;
            txtInfoManufacure.Enabled = false;

            cbxInfoCountry.Enabled = false;
            txtInfoManufacure.Text = string.Empty;
            txtInfoCode.Text = string.Empty;
            txtInfoName.Text = string.Empty;
            cbxInfoCountry.SelectedIndex = 0;
        }
        void cbx_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void upbar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void upbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            AdminHomePage adminHomePage = new AdminHomePage(username);
            this.Hide();
            adminHomePage.ShowDialog();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Chỉnh sửa thông tin")
            {
                btnUpdate.Text = "Cập nhật thông tin";
                txtInfoName.Enabled = true;
                txtInfoCode.Enabled = false;
                txtInfoManufacure.Enabled = true;
                cbxInfoCountry.Enabled = true;
            }
            else
            {
                string id = txtInfoCode.Text;
                string name = txtInfoName.Text;
                string manufacture = txtInfoManufacure.Text;
                string country = cbxInfoCountry.SelectedValue.ToString();

                if (country.Length != 0 && id.Length != 0 && name.Length != 0 && manufacture.Length != 0)
                {
                    string code3 = "UPDATE VACCINE SET VACCINE_NAME=N'"
                                                        + name + "',VACCINE_COMPANY=N'" + manufacture + "',COUNTRY_ID=N'" + country + "' WHERE VACCINE_ID = '" + id + "'";

                    try
                    {
                        clsDatabase.OpenConnection();
                        SqlCommand cmd3 = new SqlCommand(code3, clsDatabase.con);
                        SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
                        cmd3.ExecuteNonQuery();
                        clsDatabase.CloseConnection();

                        Notification notification = new Notification("Bạn đã cập nhật vắc xin thành công");
                        notification.ShowDialog();
                        return;
                    }
                    catch (Exception ex)
                    {

                        Notification notification3 = new Notification("Đã xảy ra lỗi, xin thử lại sau ");
                        notification3.ShowDialog();
                        clsDatabase.CloseConnection();
                        return;
                    }

                }
                else
                {
                    Notification notification = new Notification("Bạn phải nhập đầy đủ thông tin ở các trường có dấu (*)");
                    notification.ShowDialog();
                    return;
                }

            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String keyword = txtSearch.Text.Trim();

            string filter = $"[Mã vắc xin] LIKE '%{keyword}%' OR [Tên vắc xin] LIKE '%{keyword}%' OR [Xuất sứ] LIKE '%{keyword}%'";
            originalDataTable.DefaultView.RowFilter = filter;
            gridView.DataSource = originalDataTable.DefaultView.ToTable();


        }
    }
}
