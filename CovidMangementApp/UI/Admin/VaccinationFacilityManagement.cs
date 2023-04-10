using CovidMangementApp.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace CovidMangementApp.UI.Admin
{
    public partial class VaccinationFacilityManagement : Form
    {
        private String username;
        public Point mouseLocation;
        private List<City> cities;
        private List<Job> jobs;
        private List<Religion> religions;
        private List<Ethnic> ethnics;
        private List<District> districts;
        private List<Ward> wards;
        private List<Country> countries;
        DataTable originalDataTable;
        public VaccinationFacilityManagement()
        {
            InitializeComponent();
        }

        public VaccinationFacilityManagement(String username)
        {
            InitializeComponent();
            this.username = username;
            BindingData();
        }
        private void BindingCity()
        {
            cities = new List<City>();

            string code = "SELECT PROVINCE_ID, PROVINCE_NAME FROM PROVINCE";

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
                        string id = reader["PROVINCE_ID"].ToString();
                        string name = reader["PROVINCE_NAME"].ToString();

                        cities.Add(new City(id, name));
                    }

                    cbxAddCity.DataSource = cities;
                    cbxAddCity.DisplayMember = "Name";
                    cbxAddCity.ValueMember = "CityCode";

                    cbxInfoCity.DataSource = cities;
                    cbxInfoCity.DisplayMember = "Name";
                    cbxInfoCity.ValueMember = "CityCode";

                }
                else
                {
                    Notification notification = new Notification("Không tìm thấy tỉnh, thành phố");
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
        private void BindingAddDisctrict()
        {
            if (cbxAddCity.SelectedValue != null && cbxAddCity.SelectedValue.ToString() != "CovidMangementApp.UI.City")
            {
                string province_id = cbxAddCity.SelectedValue.ToString();

                districts = new List<District>();

                string code = "SELECT DISTRICT_ID, DISTRICT_NAME FROM DISTRICT WHERE PROVINCE_ID='" + province_id + "'";

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
                            string id = reader["DISTRICT_ID"].ToString();
                            string name = reader["DISTRICT_NAME"].ToString();

                            districts.Add(new District(id, name));
                        }

                        cbxAddDistrict.DataSource = districts;
                        cbxAddDistrict.DisplayMember = "Name";
                        cbxAddDistrict.ValueMember = "DistrictCode";

                    }
                    else
                    {
                        Notification notification = new Notification("Không tìm thấy quận huyện");
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
        }
        private void BindingInfoDisctrict()
        {
            if (cbxInfoCity.SelectedValue != null && cbxInfoCity.SelectedValue.ToString() != "CovidMangementApp.UI.City")
            {
                string province_id = cbxInfoCity.SelectedValue.ToString();

                districts = new List<District>();

                string code = "SELECT DISTRICT_ID, DISTRICT_NAME FROM DISTRICT WHERE PROVINCE_ID='" + province_id + "'";

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
                            string id = reader["DISTRICT_ID"].ToString();
                            string name = reader["DISTRICT_NAME"].ToString();

                            districts.Add(new District(id, name));
                        }

                        cbxInfoDistrict.DataSource = districts;
                        cbxInfoDistrict.DisplayMember = "Name";
                        cbxInfoDistrict.ValueMember = "DistrictCode";

                    }
                    else
                    {
                        Notification notification = new Notification("Không tìm thấy quận huyện");
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
        }
        private void BindingAddWard()
        {
            if (cbxAddDistrict.SelectedValue != null && cbxAddDistrict.SelectedValue.ToString() != "CovidMangementApp.UI.District")
            {
                string district_id = cbxAddDistrict.SelectedValue.ToString();

                wards = new List<Ward>();

                string code = "SELECT WARD_ID, WARD_NAME FROM WARD WHERE DISTRICT_ID='" + district_id + "'";

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
                            string id = reader["WARD_ID"].ToString();
                            string name = reader["WARD_NAME"].ToString();

                            wards.Add(new Ward(id, name));
                        }

                        cbxAddWard.DataSource = wards;
                        cbxAddWard.DisplayMember = "Name";
                        cbxAddWard.ValueMember = "WardCode";

                    }
                    else
                    {
                        Notification notification = new Notification("Không tìm thấy phường xã");
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
        }
        private void BindingInfoWard()
        {
            if (cbxInfoDistrict.SelectedValue != null && cbxInfoDistrict.SelectedValue.ToString() != "CovidMangementApp.UI.District")
            {
                string district_id = cbxInfoDistrict.SelectedValue.ToString();

                wards = new List<Ward>();

                string code = "SELECT WARD_ID, WARD_NAME FROM WARD WHERE DISTRICT_ID='" + district_id + "'";

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
                            string id = reader["WARD_ID"].ToString();
                            string name = reader["WARD_NAME"].ToString();

                            wards.Add(new Ward(id, name));
                        }

                        cbxInfoWard.DataSource = wards;
                        cbxInfoWard.DisplayMember = "Name";
                        cbxInfoWard.ValueMember = "WardCode";

                    }
                    else
                    {
                        Notification notification = new Notification("Không tìm thấy phường xã");
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
        }
        private void BindingVaccinationFacilityList()
        {
            gridView.DataSource = null;
            gridView.Columns.Clear();

            string code = "SELECT * FROM FACILITY";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();



                if (reader.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Mã cơ sở", typeof(string));
                    table.Columns.Add("Tên cơ sở", typeof(string));

                    while (reader.Read())
                    {

                        table.Rows.Add(
                            reader["FACILITY_ID"].ToString(),
                            reader["FACILITY_NAME"].ToString());
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
                    Notification notification = new Notification("Danh sách cơ sở trống");
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
            BindingVaccinationFacilityList();
            BindingCity();
            BindingAddDisctrict();
            BindingInfoDisctrict();
            BindingAddWard();
            BindingInfoWard();
        }
        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnOpenAdd_Click(object sender, EventArgs e)
        {

            if (coverPanel.Visible == false)
            {
                coverPanel.Visible = true;
                pnlAddFacility.Visible = true;
            }
            else
            {
                coverPanel.Visible = false;
                pnlAddFacility.Visible = false;
            }
            pnlInfoFacility.Visible = false;
            ClearAddForm();

            string code = "SELECT MAX(FACILITY_ID) CODE FROM FACILITY";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();


                string id = "VF00001";
                if (reader.HasRows)
                {
                    try
                    {
                        reader.Read();
                        id = reader["CODE"].ToString();
                        int number = int.Parse(id.Substring(2, 5));
                        number++;
                        if (number < 10)
                            id = "VF0000" + number.ToString();
                        else if (number < 100)
                            id = "VF000" + number.ToString();
                        else if (number < 1000)
                            id = "VF00" + number.ToString();
                        else if (number < 10000)
                            id = "VF0" + number.ToString();
                        else
                            id = "VF" + number.ToString();
                    }
                    catch (Exception ex)
                    {
                        id = "VF00001";
                    }

                }
                txtAddVFCode.Text = id;
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
            string id = txtAddVFCode.Text;
            string name = txtAddVFName.Text;
            string address = txtAddAddress.Text;
            string province = cbxAddCity.SelectedValue.ToString();
            string district = cbxAddDistrict.SelectedValue.ToString();
            string ward = cbxAddWard.SelectedValue.ToString();

            string adminname = txtAddVFCode.Text;


            if (province.Length != 0 && district.Length != 0 && ward.Length != 0 && id.Length != 0 && name.Length != 0 && address.Length != 0)
            {
                string code3 = "INSERT INTO FACILITY VALUES (N'"
                                                    + id + "',N'" + name + "',N'" + address + "',N'" + ward + "',N'" + district + "',N'" + province + "')";

                try
                {
                    clsDatabase.OpenConnection();
                    SqlCommand cmd3 = new SqlCommand(code3, clsDatabase.con);
                    SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
                    cmd3.ExecuteNonQuery();
                    clsDatabase.CloseConnection();

                    Notification notification = new Notification("Bạn đã thêm cơ sở tiêm chủng thành công");
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
                    string vfCode = selectedRow.Cells["Mã cơ sở"].Value.ToString();

                    openInfoForm(vfCode);

                }
                if (e.ColumnIndex == gridView.Columns["Xóa"].Index)
                {
                    DataGridViewRow selectedRow = gridView.Rows[e.RowIndex];
                    string vfCode = selectedRow.Cells["Mã cơ sở"].Value.ToString();

                    DialogResult result = MessageBox.Show("Bạn có chắc là muốn xóa cở sở tiêm chủng  " + vfCode + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string code2 = "DELETE FROM FACILITY WHERE FACILITY_ID = '" + vfCode + "'";

                        try
                        {
                            clsDatabase.OpenConnection();
                            SqlCommand cmd2 = new SqlCommand(code2, clsDatabase.con);
                            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);

                            cmd2.ExecuteNonQuery();

                            clsDatabase.CloseConnection();

                            Notification notification3 = new Notification("Đã xóa cơ sở tiêm chủng thành công");
                            notification3.ShowDialog();
                            clsDatabase.CloseConnection();
                            BindingVaccinationFacilityList();
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
        private void cbxAddCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingAddDisctrict();
        }
        private void cbxAddDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingAddWard();
        }
        private void cbxInfoCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingInfoDisctrict();
        }
        private void cbxInfoDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingInfoWard();
        }
        private void openInfoForm(String vfCode)
        {
            coverPanel.Visible = true;
            pnlInfoFacility.Visible = true;
            pnlAddFacility.Visible = false;

            string code = "SELECT * FROM FACILITY WHERE FACILITY_ID='" + vfCode + "'";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    string fullname = reader["FACILITY_NAME"].ToString();
                    string address = reader["FACILITY_ADDRESS"].ToString();
                    string r_province = reader["PROVINCE_ID"].ToString();
                    string r_district = reader["DISTRICT_ID"].ToString();
                    string r_ward = reader["WARD_ID"].ToString();

                    txtInfoVFCode.Text = vfCode;
                    txtInfoVFName.Text = fullname;
                    txtInfoAddress.Text = address;

                    int indexCity = cities.FindIndex(c => c.CityCode == r_province);
                    if (indexCity >= 0)
                    {
                        cbxInfoCity.SelectedIndex = indexCity;
                    }

                    int indexDistrict = districts.FindIndex(c => c.DistrictCode == r_district);
                    if (indexDistrict >= 0)
                    {
                        cbxInfoDistrict.SelectedIndex = indexDistrict;
                    }

                    int indexWard = wards.FindIndex(c => c.WardCode == r_ward);
                    if (indexWard >= 0)
                    {
                        cbxInfoWard.SelectedIndex = indexWard;
                    }

                    clsDatabase.CloseConnection();
                }
                else
                {
                    Notification notification = new Notification("Không tìm thấy cơ sở này");
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
            pnlInfoFacility.Visible = false;
            pnlAddFacility.Visible = false;
            ClearAddForm();
            ClearInfoForm();
            BindingVaccinationFacilityList();
            btnUpdate.Text = "Chỉnh sửa thông tin";
            txtInfoVFName.Enabled = false;
            txtInfoVFCode.Enabled = false;
            txtInfoAddress.Enabled = false;

            cbxInfoCity.Enabled = false;
            cbxInfoDistrict.Enabled = false;
            cbxInfoWard.Enabled = false;
        }
        private void ClearAddForm()
        {
            txtAddAddress.Text = string.Empty;
            txtAddVFCode.Text = string.Empty;
            txtAddVFName.Text = string.Empty;
            cbxAddCity.SelectedIndex = 0;

        }
        private void ClearInfoForm()
        {
            txtInfoVFName.Enabled = false;
            txtInfoVFCode.Enabled = false;
            txtInfoAddress.Enabled = false;

            cbxInfoCity.Enabled = false;
            cbxInfoDistrict.Enabled = false;
            cbxInfoWard.Enabled = false;
            txtInfoAddress.Text = string.Empty;
            txtInfoVFCode.Text = string.Empty;
            txtInfoVFName.Text = string.Empty;
            cbxInfoCity.SelectedIndex = 0;
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
                txtInfoVFName.Enabled = true;
                txtInfoVFCode.Enabled = false;
                txtInfoAddress.Enabled = true;

                cbxInfoCity.Enabled = true;
                cbxInfoDistrict.Enabled = true;
                cbxInfoWard.Enabled = true;
            }
            else
            {
                string id = txtInfoVFCode.Text;
                string name = txtInfoVFName.Text;
                string address = txtInfoAddress.Text;
                string province = cbxInfoCity.SelectedValue.ToString();
                string district = cbxInfoDistrict.SelectedValue.ToString();
                string ward = cbxInfoWard.SelectedValue.ToString();

                if (province.Length != 0 && district.Length != 0 && ward.Length != 0 && id.Length != 0 && name.Length != 0 && address.Length != 0)
                {
                    string code3 = "UPDATE FACILITY SET FACILITY_NAME=N'"
                                                        + name + "',FACILITY_ADDRESS=N'" + address + "',WARD_ID=N'" + ward + "',DISTRICT_ID=N'" + district + "',PROVINCE_ID=N'" + province + "' WHERE FACILITY_ID = '" + id + "'";

                    try
                    {
                        clsDatabase.OpenConnection();
                        SqlCommand cmd3 = new SqlCommand(code3, clsDatabase.con);
                        SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
                        cmd3.ExecuteNonQuery();
                        clsDatabase.CloseConnection();

                        Notification notification = new Notification("Bạn đã cập nhật cơ sở tiêm chủng thành công");
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

            string filter = $"[Mã cơ sở] LIKE '%{keyword}%' OR [Tên cơ sở] LIKE '%{keyword}%'";
            originalDataTable.DefaultView.RowFilter = filter;
            gridView.DataSource = originalDataTable.DefaultView.ToTable();


        }
    }
}
