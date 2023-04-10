using CovidMangementApp.Helpers;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CovidMangementApp.UI.Admin
{
    public partial class StaffManagment : Form
    {
        private String username;
        private String oldPhone;
        private String oldCmnd;
        public Point mouseLocation;
        private List<City> cities;
        private List<Job> jobs;
        private List<Religion> religions;
        private List<Ethnic> ethnics;
        private List<District> districts;
        private List<Ward> wards;
        private List<Country> countries;
        private DataTable originalDataTable;

        public StaffManagment()
        {
            InitializeComponent();
        }

        public StaffManagment(String username)
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
        private void BindingJob()
        {
            jobs = new List<Job>();

            string code = "SELECT * FROM JOB";

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
                        string id = reader["JOB_ID"].ToString();
                        string name = reader["JOB_NAME"].ToString();

                        jobs.Add(new Job(id, name));
                    }

                    cbxAddJob.DataSource = jobs;
                    cbxAddJob.DisplayMember = "Name";
                    cbxAddJob.ValueMember = "JobCode";

                    cbxInfoJob.DataSource = jobs;
                    cbxInfoJob.DisplayMember = "Name";
                    cbxInfoJob.ValueMember = "JobCode";

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
        private void BindingReligion()
        {
            religions = new List<Religion>();

            string code = "SELECT * FROM RELIGION";

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
                        string id = reader["RELIGION_ID"].ToString();
                        string name = reader["RELIGION_NAME"].ToString();

                        religions.Add(new Religion(id, name));
                    }

                    cbxAddReligion.DataSource = religions;
                    cbxAddReligion.DisplayMember = "Name";
                    cbxAddReligion.ValueMember = "ReligionCode";

                    cbxInfoReligion.DataSource = religions;
                    cbxInfoReligion.DisplayMember = "Name";
                    cbxInfoReligion.ValueMember = "ReligionCode";

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
        private void BindingEthnic()
        {
            ethnics = new List<Ethnic>();

            string code = "SELECT * FROM ETHNIC";

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
                        string id = reader["ETHNIC_ID"].ToString();
                        string name = reader["ETHNIC_NAME"].ToString();

                        ethnics.Add(new Ethnic(id, name));
                    }

                    cbxAddEthnic.DataSource = ethnics;
                    cbxAddEthnic.DisplayMember = "Name";
                    cbxAddEthnic.ValueMember = "EthnicCode";

                    cbxInfoEthnic.DataSource = ethnics;
                    cbxInfoEthnic.DisplayMember = "Name";
                    cbxInfoEthnic.ValueMember = "EthnicCode";

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
        private void BindingNationality()
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

                    cbxAddNationality.DataSource = countries;
                    cbxAddNationality.DisplayMember = "Name";
                    cbxAddNationality.ValueMember = "CountryCode";

                    cbxInfoNationality.DataSource = countries;
                    cbxInfoNationality.DisplayMember = "Name";
                    cbxInfoNationality.ValueMember = "CountryCode";


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
        private void BindingStaffList()
        {
            oldCmnd = "";
            oldPhone = "";
            gridView.DataSource = null;
            gridView.Columns.Clear();

            string code = "SELECT * FROM STAFF_ACCOUNT JOIN STAFF ON STAFF_ACCOUNT.SA_STAFF = STAFF.STAFF_ID";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();



                if (reader.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Tên đăng nhập", typeof(string));
                    table.Columns.Add("Họ và tên", typeof(string));
                    table.Columns.Add("Số điện thoại", typeof(string));
                    table.Columns.Add("Địa chỉ Email", typeof(string));

                    while (reader.Read())
                    {

                        table.Rows.Add(
                            reader["SA_USERNAME"].ToString(),
                            reader["STAFF_NAME"].ToString(),
                            reader["STAFF_PHONE"].ToString(),
                            reader["STAFF_EMAIL"].ToString());
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
                    gridView.Columns["Số điện thoại"].Width = 80;
                    gridView.Columns["Tên đăng nhập"].Width = 100;

                }
                else
                {
                    Notification notification = new Notification("Danh sách nhân viên trống");
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
            BindingStaffList();
            BindingCity();
            BindingJob();
            BindingReligion();
            BindingEthnic();
            BindingNationality();
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
                pnlAddStaff.Visible = true;
            }
            else
            {
                coverPanel.Visible = false;
                pnlAddStaff.Visible = false;
            }
            pnlInfoStaff.Visible = false;
            ClearAddForm();

            string code = "SELECT MAX(SA_ORDER) CODE FROM STAFF_ACCOUNT";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();


                string id = "staff00001";
                if (reader.HasRows)
                {
                    try
                    {
                        reader.Read();
                        id = reader["CODE"].ToString();
                        int number = int.Parse(id);
                        number++;
                        if (number < 10)
                            id = "staff0000" + number.ToString();
                        else if (number < 100)
                            id = "staff000" + number.ToString();
                        else if (number < 1000)
                            id = "staff00" + number.ToString();
                        else if (number < 10000)
                            id = "staff0" + number.ToString();
                        else
                            id = "staff" + number.ToString();
                    }
                    catch (Exception ex)
                    {
                        id = "staff00001";
                    }

                }
                txtAddUsername.Text = id;
                txtAddPassword.Text = id;
                txtAddAnswer.Text = id;
                clsDatabase.CloseConnection();

            }
            catch (Exception ex)
            {
                Notification notification = new Notification("SELECT MAX(SA_ORDER): Lỗi cơ sở dữ liệu: " + ex);
                notification.ShowDialog();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fullname = txtAddFullName.Text;
            string dob = dpkAddDob.Text;
            string phone = txtAddPhone.Text;
            string cmnd = txtAddCmnd.Text;
            string email = txtAddEmail.Text;
            string address = txtAddAddress.Text;
            string answer = txtAddAnswer.Text;
            string sex = "";
            string province = cbxAddCity.SelectedValue.ToString();
            string district = cbxAddDistrict.SelectedValue.ToString();
            string ward = cbxAddWard.SelectedValue.ToString();
            string ethnic = cbxAddEthnic.SelectedValue.ToString();
            string job = cbxAddJob.SelectedValue.ToString();
            string religion = cbxAddReligion.SelectedValue.ToString();
            string nationality = cbxAddNationality.SelectedValue.ToString();
            string adminname = txtAddUsername.Text;

            if (rdbtnAddMale.Checked) { sex = "1"; }
            if (rdbtnAddFeMale.Checked) { sex = "2"; }
            if (rdbtnAddOther.Checked) { sex = "3"; }

            if (fullname.Length != 0 && dob.Length != 0 && sex.Length != 0 && phone.Length != 0 && cmnd.Length != 0 && province.Length != 0
                && district.Length != 0 && ward.Length != 0 && nationality.Length != 0 && ethnic.Length != 0 && job.Length != 0 && religion.Length != 0
                && answer.Length != 0)
            {
                if (Regex.IsMatch(fullname, @"^[A-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ]+$") && fullname.Length <= 100)
                {
                    if (Regex.IsMatch(phone, @"^[0-9]+$") && phone.Length == 10)
                    {
                        if (Regex.IsMatch(cmnd, @"^[a-zA-Z0-9]+$") && cmnd.Length <= 20)
                        {
                            if ((Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z") && email.Length <= 100 && email.Length != 0) || email.Length == 0)
                            {
                                string code = "SELECT STAFF_PHONE FROM STAFF WHERE STAFF_ID='" + cmnd + "'";

                                try
                                {
                                    clsDatabase.OpenConnection();
                                    SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                                    SqlDataReader reader = cmd.ExecuteReader();

                                    if (reader.HasRows)
                                    {
                                        clsDatabase.CloseConnection();
                                        Notification notification = new Notification("Số hộ chiếu/CMND/CCCD bạn nhập đã tồn tại");
                                        notification.ShowDialog();
                                        return;
                                    }
                                    else
                                    {
                                        clsDatabase.CloseConnection();

                                        string code1 = "SELECT STAFF_NAME FROM STAFF WHERE STAFF_PHONE='" + phone + "'";

                                        try
                                        {
                                            clsDatabase.OpenConnection();
                                            SqlCommand cmd1 = new SqlCommand(code1, clsDatabase.con);
                                            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);

                                            SqlDataReader reader1 = cmd1.ExecuteReader();

                                            if (reader1.HasRows)
                                            {
                                                clsDatabase.CloseConnection();
                                                Notification notification = new Notification("Số điện thoại bạn nhập đã tồn tại");
                                                notification.ShowDialog();
                                                return;
                                            }
                                            else
                                            {
                                                clsDatabase.CloseConnection();

                                                string code2 = "INSERT INTO STAFF VALUES (N'" +
                                                    fullname + "',N'" +
                                                    dob + "',N'" +
                                                    sex + "',N'" +
                                                    cmnd + "',N'" +
                                                    phone + "',N'" +
                                                    email + "',N'" +
                                                    province + "',N'" +
                                                    district + "',N'" +
                                                    ward + "',N'" +
                                                    address + "',N'" +
                                                    nationality + "',N'" +
                                                    religion + "',N'" +
                                                    ethnic + "',N'" +
                                                    job + "')";

                                                try
                                                {
                                                    clsDatabase.OpenConnection();
                                                    SqlCommand cmd2 = new SqlCommand(code2, clsDatabase.con);
                                                    SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                                                    cmd2.ExecuteNonQuery();
                                                    clsDatabase.CloseConnection();
                                                }
                                                catch (Exception ex)
                                                {
                                                    Notification notification31 = new Notification("Đã xảy ra lỗi, xin thử lại sau");
                                                    notification31.ShowDialog();
                                                    clsDatabase.CloseConnection();
                                                    return;
                                                }


                                                string code3 = "INSERT INTO STAFF_ACCOUNT(SA_USERNAME,SA_PASSWORD,SA_STAFF,SA_ANSWER) VALUES ('"
                                                    + adminname + "','" + adminname + "','" + cmnd + "','" + answer + "')";

                                                try
                                                {
                                                    clsDatabase.OpenConnection();
                                                    SqlCommand cmd3 = new SqlCommand(code3, clsDatabase.con);
                                                    SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
                                                    cmd3.ExecuteNonQuery();
                                                    clsDatabase.CloseConnection();
                                                }
                                                catch (Exception ex)
                                                {

                                                    Notification notification3 = new Notification("Đã xảy ra lỗi, xin thử lại sau");
                                                    notification3.ShowDialog();
                                                    clsDatabase.CloseConnection();
                                                    return;
                                                }

                                                string result = "Bạn đã đăng ký thành công tài khoản nhân viên y tế. Hãy đăng nhập với tên đăng nhập là '" + adminname + "' và mật khẩu là '" + adminname + "'.";

                                                Notification notification = new Notification(result);
                                                notification.ShowDialog();
                                                return;
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Notification notification4 = new Notification("Đã xảy ra lỗi, xin thử lại sau");
                                            notification4.ShowDialog();
                                            clsDatabase.CloseConnection();
                                            return;
                                        }

                                    }
                                }
                                catch (Exception ex)
                                {
                                    clsDatabase.CloseConnection();
                                    Notification notification = new Notification("Lỗi cơ sở dữ liệu: " + ex);
                                    notification.ShowDialog();
                                }
                            }
                            else
                            {
                                Notification notification = new Notification("Email bạn nhập không hợp lệ");
                                notification.ShowDialog();
                                return;
                            }
                        }
                        else
                        {
                            Notification notification = new Notification("Số hộ chiếu/CMND/CCCD bạn nhập không hợp lệ");
                            notification.ShowDialog();
                            return;
                        }
                    }
                    else
                    {
                        Notification notification = new Notification("Số điện thoại bạn nhập không hợp lệ");
                        notification.ShowDialog();
                        return;
                    }
                }
                else
                {
                    Notification notification = new Notification("Họ và tên bạn nhập không hợp lệ");
                    notification.ShowDialog();
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
                    string username = selectedRow.Cells["Tên đăng nhập"].Value.ToString();

                    openInfoForm(username);

                }
                if (e.ColumnIndex == gridView.Columns["Xóa"].Index)
                {
                    DataGridViewRow selectedRow = gridView.Rows[e.RowIndex];
                    string usernameReal = selectedRow.Cells["Tên đăng nhập"].Value.ToString();

                    string code = "SELECT * FROM STAFF JOIN STAFF_ACCOUNT ON STAFF.STAFF_ID = STAFF_ACCOUNT.SA_STAFF WHERE SA_USERNAME= '" + usernameReal + "'";

                    try
                    {
                        clsDatabase.OpenConnection();
                        SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            string cmnd1 = reader.GetString(3);
                            clsDatabase.CloseConnection();

                            DialogResult result = MessageBox.Show("Are you sure you want to delete user" + usernameReal + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                string code2 = "DELETE FROM STAFF_ACCOUNT WHERE SA_USERNAME = '" + usernameReal + "'";

                                try
                                {
                                    clsDatabase.OpenConnection();
                                    SqlCommand cmd2 = new SqlCommand(code2, clsDatabase.con);
                                    SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);

                                    cmd2.ExecuteNonQuery();

                                    clsDatabase.CloseConnection();

                                    string code3 = "DELETE FROM STAFF WHERE STAFF_ID = '" + cmnd1 + "'";

                                    try
                                    {
                                        clsDatabase.OpenConnection();
                                        SqlCommand cmd3 = new SqlCommand(code3, clsDatabase.con);
                                        SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);

                                        cmd3.ExecuteNonQuery();


                                        Notification notification3 = new Notification("Đã xóa nhân viên thành công");
                                        notification3.ShowDialog();
                                        clsDatabase.CloseConnection();
                                        BindingStaffList();
                                        return;

                                    }
                                    catch (Exception ex)
                                    {
                                        Notification notification4 = new Notification("Lỗi cơ sở dữ liệu: " + ex);
                                        notification4.ShowDialog();
                                    }

                                }
                                catch (Exception ex)
                                {
                                    Notification notification = new Notification("Lỗi cơ sở dữ liệu: " + ex);
                                    notification.ShowDialog();
                                }
                            }
                        }
                        else
                        {
                            Notification notification = new Notification("Không tìm thấy nhân viên");
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
        }
        private void txtAddPassword_TrailingIconClick(object sender, EventArgs e)
        {
            if (txtAddPassword.Password == true)
            {
                txtAddPassword.TrailingIcon = Properties.Resources.hide_pass;
            }
            else
            {
                txtAddPassword.TrailingIcon = Properties.Resources.show_pass;
            }
            txtAddPassword.Password = !txtAddPassword.Password;
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
        private void openInfoForm(String usernameReal)
        {
            coverPanel.Visible = true;
            pnlInfoStaff.Visible = true;
            pnlAddStaff.Visible = false;
            oldCmnd = "";
            oldPhone = "";

            string code = "SELECT * FROM STAFF JOIN STAFF_ACCOUNT ON STAFF.STAFF_ID = STAFF_ACCOUNT.SA_STAFF WHERE SA_USERNAME= '" + usernameReal + "'";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    string fullname1 = reader.GetString(0);
                    string dob1 = reader.GetString(1);
                    string sex1 = reader.GetString(2);
                    string cmnd1 = reader.GetString(3);
                    oldCmnd = reader.GetString(3);
                    string phone1 = reader.GetString(4);
                    oldPhone = reader.GetString(4);
                    string email1 = reader.GetString(5);
                    string province1 = reader.GetString(6);
                    string district1 = reader.GetString(7);
                    string ward1 = reader.GetString(8);
                    string address1 = reader.GetString(9);
                    string nationality1 = reader.GetString(10);
                    string religion1 = reader.GetString(11);
                    string ethnic1 = reader.GetString(12);
                    string job1 = reader.GetString(13);

                    txtInfoUsername.Text = usernameReal;
                    txtInfoFullName.Text = fullname1;
                    txtInfoEmail.Text = email1;
                    txtInfoCmnd.Text = cmnd1;
                    txtInfoAddress.Text = address1;
                    txtInfoPhone.Text = phone1;

                    if (sex1 == "1") rdbtnInfoMale.Checked = true;
                    if (sex1 == "2") rdbtnInfoFeMale.Checked = true;
                    if (sex1 == "3") rdbtnInfoOther.Checked = true;

                    DateTime date = DateTime.ParseExact(dob1, "dd/MM/yyyy", null);
                    dpkInfoDob.Value = date;

                    int indexCity = cities.FindIndex(c => c.CityCode == province1);
                    if (indexCity >= 0)
                    {
                        cbxInfoCity.SelectedIndex = indexCity;
                    }

                    int indexDistrict = districts.FindIndex(c => c.DistrictCode == district1);
                    if (indexDistrict >= 0)
                    {
                        cbxInfoDistrict.SelectedIndex = indexDistrict;
                    }

                    int indexWard = wards.FindIndex(c => c.WardCode == ward1);
                    if (indexWard >= 0)
                    {
                        cbxInfoWard.SelectedIndex = indexWard;
                    }

                    int indexNationality = countries.FindIndex(c => c.CountryCode == nationality1);
                    if (indexNationality >= 0)
                    {
                        cbxInfoNationality.SelectedIndex = indexNationality;
                    }

                    int indexEthic = ethnics.FindIndex(c => c.EthnicCode == ethnic1);
                    if (indexEthic >= 0)
                    {
                        cbxInfoEthnic.SelectedIndex = indexEthic;
                    }

                    int indexReligion = religions.FindIndex(c => c.ReligionCode == religion1);
                    if (indexReligion >= 0)
                    {
                        cbxInfoReligion.SelectedIndex = indexReligion;
                    }

                    int indexJob = jobs.FindIndex(c => c.JobCode == job1);
                    if (indexJob >= 0)
                    {
                        cbxInfoJob.SelectedIndex = indexJob;
                    }


                    clsDatabase.CloseConnection();
                }
                else
                {
                    Notification notification = new Notification("Không tìm admin");
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
            pnlInfoStaff.Visible = false;
            pnlAddStaff.Visible = false;
            ClearAddForm();
            ClearInfoForm();
            BindingStaffList();
            oldCmnd = "";
            oldPhone = "";
            btnUpdate.Text = "Chỉnh sửa thông tin";
            txtInfoEmail.Enabled = false;
            txtInfoFullName.Enabled = false;
            txtInfoPhone.Enabled = false;
            txtInfoAddress.Enabled = false;
            txtInfoCmnd.Enabled = false;

            cbxInfoCity.Enabled = false;
            cbxInfoDistrict.Enabled = false;
            cbxInfoWard.Enabled = false;
            cbxInfoEthnic.Enabled = false;
            cbxInfoJob.Enabled = false;
            cbxInfoNationality.Enabled = false;
            cbxInfoReligion.Enabled = false;

            rdbtnInfoFeMale.Enabled = false;
            rdbtnInfoMale.Enabled = false;
            rdbtnInfoOther.Enabled = false;

            dpkInfoDob.Enabled = false;
        }
        private void ClearAddForm()
        {
            txtAddAddress.Text = string.Empty;
            txtAddAnswer.Text = string.Empty;
            txtAddCmnd.Text = string.Empty;
            txtAddEmail.Text = string.Empty;
            txtAddFullName.Text = string.Empty;
            txtAddPassword.Text = string.Empty;
            txtAddPhone.Text = string.Empty;
            txtAddAnswer.Text += string.Empty;
            txtAddUsername.Text += string.Empty;
            cbxAddCity.SelectedIndex = 0;
            cbxAddEthnic.SelectedIndex = 0;
            cbxAddJob.SelectedIndex = 0;
            cbxAddNationality.SelectedIndex = 0;
            cbxAddReligion.SelectedIndex = 0;
        }
        private void ClearInfoForm()
        {
            txtInfoAddress.Text = string.Empty;
            txtInfoCmnd.Text = string.Empty;
            txtInfoEmail.Text = string.Empty;
            txtInfoFullName.Text = string.Empty;
            txtInfoPhone.Text = string.Empty;
            txtInfoUsername.Text += string.Empty;
            cbxInfoCity.SelectedIndex = 0;
            cbxInfoEthnic.SelectedIndex = 0;
            cbxInfoJob.SelectedIndex = 0;
            cbxInfoNationality.SelectedIndex = 0;
            cbxInfoReligion.SelectedIndex = 0;
            oldCmnd = "";
            oldPhone = "";
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
                txtInfoEmail.Enabled = true;
                txtInfoFullName.Enabled = true;
                txtInfoPhone.Enabled = true;
                txtInfoAddress.Enabled = true;
                txtInfoCmnd.Enabled = false;

                cbxInfoCity.Enabled = true;
                cbxInfoDistrict.Enabled = true;
                cbxInfoWard.Enabled = true;
                cbxInfoEthnic.Enabled = true;
                cbxInfoJob.Enabled = true;
                cbxInfoNationality.Enabled = true;
                cbxInfoReligion.Enabled = true;

                rdbtnInfoFeMale.Enabled = true;
                rdbtnInfoMale.Enabled = true;
                rdbtnInfoOther.Enabled = true;

                dpkInfoDob.Enabled = true;
            }
            else
            {
                string usernameReal = txtInfoUsername.Text;
                string cmnd = txtInfoCmnd.Text;
                string fullname = txtInfoFullName.Text;
                string dob = dpkInfoDob.Text;
                string phone = txtInfoPhone.Text;
                string email = txtInfoEmail.Text;
                string address = txtInfoAddress.Text;
                string sex = "";
                string province = cbxInfoCity.SelectedValue.ToString();
                string district = cbxInfoDistrict.SelectedValue.ToString();
                string ward = cbxInfoWard.SelectedValue.ToString();
                string ethnic = cbxInfoEthnic.SelectedValue.ToString();
                string job = cbxInfoJob.SelectedValue.ToString();
                string religion = cbxInfoReligion.SelectedValue.ToString();
                string nationality = cbxInfoNationality.SelectedValue.ToString();

                if (rdbtnInfoMale.Checked) { sex = "1"; }
                if (rdbtnInfoFeMale.Checked) { sex = "2"; }
                if (rdbtnInfoOther.Checked) { sex = "3"; }

                if (fullname.Length != 0 && dob.Length != 0 && sex.Length != 0 && phone.Length != 0 && email.Length != 0)
                {
                    if (Regex.IsMatch(fullname, @"^[A-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ]+$") && fullname.Length <= 100)
                    {
                        if (Regex.IsMatch(phone, @"^[0-9]+$") && phone.Length == 10)
                        {
                            if ((Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z") && email.Length <= 100 && email.Length != 0) || email.Length == 0)
                            {

                                string code24 = "SELECT * FROM STAFF WHERE STAFF_ID='" + cmnd + "'";

                                try
                                {


                                    clsDatabase.OpenConnection();
                                    SqlCommand cmd24 = new SqlCommand(code24, clsDatabase.con);
                                    SqlDataAdapter sda24 = new SqlDataAdapter(cmd24);

                                    SqlDataReader reader24 = cmd24.ExecuteReader();

                                    if (reader24.HasRows && !cmnd.Equals(oldCmnd))
                                    {
                                        Notification notification24 = new Notification("Số hộ chiếu/CMND/CCCD bạn nhập đã tồn tại");
                                        notification24.ShowDialog();
                                        clsDatabase.CloseConnection();
                                        return;
                                    }

                                    clsDatabase.CloseConnection();

                                    string code1 = "SELECT STAFF_NAME FROM STAFF WHERE STAFF_PHONE='" + phone + "'";

                                    try
                                    {


                                        clsDatabase.OpenConnection();
                                        SqlCommand cmd1 = new SqlCommand(code1, clsDatabase.con);
                                        SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);

                                        SqlDataReader reader1 = cmd1.ExecuteReader();

                                        if (reader1.HasRows && !phone.Equals(oldPhone))
                                        {
                                            Notification notification = new Notification("Số điện thoại bạn nhập đã tồn tại");
                                            notification.ShowDialog();
                                            clsDatabase.CloseConnection();
                                            return;
                                        }

                                        clsDatabase.CloseConnection();

                                        string code2 = "UPDATE S SET S.STAFF_NAME=N'" +
                                            fullname + "',S.STAFF_DOB=N'" +
                                            dob + "',S.STAFF_PHONE=N'" +
                                            phone + "',S.STAFF_SEX=N'" +
                                            sex + "', S.STAFF_EMAIL=N'" +
                                            email + "',S.STAFF_PROVINCE=N'" +
                                            province + "',S.STAFF_DISTRICT=N'" +
                                            district + "',S.STAFF_WARD=N'" +
                                            ward + "',S.STAFF_ADDRESS=N'" +
                                            address + "',S.STAFF_NATIONALITY=N'" +
                                            nationality + "',S.STAFF_RELIGION=N'" +
                                            religion + "',S.STAFF_ETHNIC=N'" +
                                            ethnic + "',S.STAFF_JOB=N'" +
                                            job + "' FROM STAFF AS S JOIN STAFF_ACCOUNT AS SA ON S.STAFF_ID=SA.SA_STAFF WHERE SA.SA_USERNAME='" + usernameReal + "'";

                                        try
                                        {
                                            clsDatabase.OpenConnection();
                                            SqlCommand cmd2 = new SqlCommand(code2, clsDatabase.con);
                                            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                                            cmd2.ExecuteNonQuery();

                                            string result = "Thông tin nhân viên đã được cập nhật thành công";

                                            Notification notification21 = new Notification(result);
                                            notification21.ShowDialog();

                                            btnUpdate.Text = "Chỉnh sửa thông tin";
                                            txtInfoEmail.Enabled = false;
                                            txtInfoFullName.Enabled = false;
                                            txtInfoPhone.Enabled = false;
                                            txtInfoAddress.Enabled = false;
                                            txtInfoCmnd.Enabled = false;

                                            cbxInfoCity.Enabled = false;
                                            cbxInfoDistrict.Enabled = false;
                                            cbxInfoWard.Enabled = false;
                                            cbxInfoEthnic.Enabled = false;
                                            cbxInfoJob.Enabled = false;
                                            cbxInfoNationality.Enabled = false;
                                            cbxInfoReligion.Enabled = false;

                                            rdbtnInfoFeMale.Enabled = false;
                                            rdbtnInfoMale.Enabled = false;
                                            rdbtnInfoOther.Enabled = false;

                                            dpkInfoDob.Enabled = false;

                                            clsDatabase.CloseConnection();
                                            return;
                                        }
                                        catch (Exception ex)
                                        {
                                            Debug.WriteLine(code2);
                                            Notification notification31 = new Notification(ex.ToString());
                                            notification31.ShowDialog();
                                            clsDatabase.CloseConnection();
                                            return;
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        Notification notification4 = new Notification("Đã xảy ra lỗi, xin thử lại sau");
                                        notification4.ShowDialog();
                                        clsDatabase.CloseConnection();
                                        return;
                                    }



                                }
                                catch (Exception ex)
                                {
                                    Notification notification4 = new Notification("Đã xảy ra lỗi, xin thử lại sau");
                                    notification4.ShowDialog();
                                    clsDatabase.CloseConnection();
                                    return;
                                }



                            }
                            else
                            {
                                Notification notification = new Notification("Email bạn nhập không hợp lệ");
                                notification.ShowDialog();
                                return;
                            }
                        }
                        else
                        {
                            Notification notification = new Notification("Số điện thoại bạn nhập không hợp lệ");
                            notification.ShowDialog();
                            return;
                        }
                    }
                    else
                    {
                        Notification notification = new Notification("Họ và tên bạn nhập không hợp lệ");
                        notification.ShowDialog();
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

            string filter = $"[Tên đăng nhập] LIKE '%{keyword}%' OR [Họ và tên] LIKE '%{keyword}%'";
            originalDataTable.DefaultView.RowFilter = filter;
            gridView.DataSource = originalDataTable.DefaultView.ToTable();


        }
    }
}
