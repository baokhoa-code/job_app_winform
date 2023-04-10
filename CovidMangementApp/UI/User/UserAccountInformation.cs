using CovidMangementApp.Helpers;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CovidMangementApp.UI.User
{
    public partial class UserAccountInformation : Form
    {
        public Point mouseLocation;
        private String username;
        private String oldPhone;
        private String oldCmnd;
        private List<City> cities;
        private List<Job> jobs;
        private List<Religion> religions;
        private List<Ethnic> ethnics;
        private List<District> districts;
        private List<Ward> wards;
        private List<Country> countries;

        public UserAccountInformation()
        {
            InitializeComponent();
            BindingData();
        }

        public UserAccountInformation(string username)
        {
            InitializeComponent();
            BindingData();
            this.username = username;
            LoadingUserInfor();
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

                    cbxCity.DataSource = cities;
                    cbxCity.DisplayMember = "Name";
                    cbxCity.ValueMember = "CityCode";

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

                    cbxJob.DataSource = jobs;
                    cbxJob.DisplayMember = "Name";
                    cbxJob.ValueMember = "JobCode";

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

                    cbxReligion.DataSource = religions;
                    cbxReligion.DisplayMember = "Name";
                    cbxReligion.ValueMember = "ReligionCode";

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

                    cbxEthnic.DataSource = ethnics;
                    cbxEthnic.DisplayMember = "Name";
                    cbxEthnic.ValueMember = "EthnicCode";

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
        private void BindingDisctrict()
        {
            if (cbxCity.SelectedValue != null && cbxCity.SelectedValue.ToString() != "CovidMangementApp.UI.City")
            {
                string province_id = cbxCity.SelectedValue.ToString();

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

                        cbxDistrict.DataSource = districts;
                        cbxDistrict.DisplayMember = "Name";
                        cbxDistrict.ValueMember = "DistrictCode";

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
        private void BindingWard()
        {
            if (cbxDistrict.SelectedValue != null && cbxDistrict.SelectedValue.ToString() != "CovidMangementApp.UI.District")
            {
                string district_id = cbxDistrict.SelectedValue.ToString();

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

                        cbxWard.DataSource = wards;
                        cbxWard.DisplayMember = "Name";
                        cbxWard.ValueMember = "WardCode";

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

                    cbxNationality.DataSource = countries;
                    cbxNationality.DisplayMember = "Name";
                    cbxNationality.ValueMember = "CountryCode";

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
        private void BindingData()
        {
            BindingCity();
            BindingJob();
            BindingReligion();
            BindingEthnic();
            BindingNationality();
            BindingDisctrict();
            BindingWard();

        }
        private void LoadingUserInfor()
        {

            string code = "SELECT * FROM RESIDENT JOIN RESIDENT_ACCOUNT ON RESIDENT.RESIDENT_ID = RESIDENT_ACCOUNT.RA_RESIDENT WHERE RA_USERNAME= '" + username + "'";

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
                    string insurance1 = reader.GetString(10);
                    string dateStart1 = reader.GetString(11);
                    string dateEnd1 = reader.GetString(12);
                    string datePoint1 = reader.GetString(13);
                    string nationality1 = reader.GetString(14);
                    string religion1 = reader.GetString(15);
                    string ethnic1 = reader.GetString(16);
                    string job1 = reader.GetString(17);


                    txtName.Text = fullname1;
                    txtEmail.Text = email1;
                    txtCmnd.Text = cmnd1;
                    txtAddress.Text = address1;
                    txtPhone.Text = phone1;
                    txtInsurance.Text = insurance1;

                    if (sex1 == "1") rdbtnMale.Checked = true;
                    if (sex1 == "2") rdbtnFemale.Checked = true;
                    if (sex1 == "3") rdbtnOther.Checked = true;

                    DateTime date = DateTime.ParseExact(dob1, "dd/MM/yyyy", null);
                    dpkDob.Value = date;

                    DateTime date1 = DateTime.ParseExact(dateStart1, "dd/MM/yyyy", null);
                    dpkStartDate.Value = date1;

                    DateTime date2 = DateTime.ParseExact(dateEnd1, "dd/MM/yyyy", null);
                    dpkEndDate.Value = date2;

                    DateTime date3 = DateTime.ParseExact(datePoint1, "dd/MM/yyyy", null);
                    dpkPointDate.Value = date3;

                    int indexCity = cities.FindIndex(c => c.CityCode == province1);
                    if (indexCity >= 0)
                    {
                        cbxCity.SelectedIndex = indexCity;
                    }

                    int indexDistrict = districts.FindIndex(c => c.DistrictCode == district1);
                    if (indexDistrict >= 0)
                    {
                        cbxDistrict.SelectedIndex = indexDistrict;
                    }

                    int indexWard = wards.FindIndex(c => c.WardCode == ward1);
                    if (indexWard >= 0)
                    {
                        cbxWard.SelectedIndex = indexWard;
                    }

                    int indexNationality = countries.FindIndex(c => c.CountryCode == nationality1);
                    if (indexNationality >= 0)
                    {
                        cbxNationality.SelectedIndex = indexNationality;
                    }

                    int indexEthic = ethnics.FindIndex(c => c.EthnicCode == ethnic1);
                    if (indexEthic >= 0)
                    {
                        cbxEthnic.SelectedIndex = indexEthic;
                    }

                    int indexReligion = religions.FindIndex(c => c.ReligionCode == religion1);
                    if (indexReligion >= 0)
                    {
                        cbxReligion.SelectedIndex = indexReligion;
                    }

                    int indexJob = jobs.FindIndex(c => c.JobCode == job1);
                    if (indexJob >= 0)
                    {
                        cbxJob.SelectedIndex = indexJob;
                    }


                    clsDatabase.CloseConnection();

                }
                else
                {
                    clsDatabase.CloseConnection();
                    Notification notification = new Notification("Không tìm thấy thông tin người dùng");
                    notification.ShowDialog();
                    return;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                Debug.WriteLine(code);
                Notification notification31 = new Notification("Lỗi cơ sở dữ liệu, xin thử lại sau");
                notification31.ShowDialog();
                clsDatabase.CloseConnection();
                return;
            }
        }
        private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingDisctrict();
        }
        private void cbxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingWard();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Chỉnh sửa thông tin")
            {
                btnUpdate.Text = "Cập nhật thông tin";
                txtEmail.Enabled = true;
                txtName.Enabled = true;
                txtPhone.Enabled = true;
                txtAddress.Enabled = true;
                txtInsurance.Enabled = true;
                txtCmnd.Enabled = false;

                cbxCity.Enabled = true;
                cbxDistrict.Enabled = true;
                cbxWard.Enabled = true;
                cbxEthnic.Enabled = true;
                cbxJob.Enabled = true;
                cbxNationality.Enabled = true;
                cbxReligion.Enabled = true;

                rdbtnFemale.Enabled = true;
                rdbtnMale.Enabled = true;
                rdbtnOther.Enabled = true;

                dpkDob.Enabled = true;
                dpkStartDate.Enabled = true;
                dpkEndDate.Enabled = true;
                dpkPointDate.Enabled = true;
            }
            else
            {
                string fullname = txtName.Text;
                string dob = dpkDob.Text;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;
                string address = txtAddress.Text;
                string cmnd = txtCmnd.Text;
                string sex = "";
                string province = cbxCity.SelectedValue.ToString();
                string district = cbxDistrict.SelectedValue.ToString();
                string ward = cbxWard.SelectedValue.ToString();
                string ethnic = cbxEthnic.SelectedValue.ToString();
                string job = cbxJob.SelectedValue.ToString();
                string religion = cbxReligion.SelectedValue.ToString();
                string nationality = cbxNationality.SelectedValue.ToString();
                string insurance = txtInsurance.Text;
                string dateStart = dpkStartDate.Text;
                string dateEnd = dpkEndDate.Text;
                string datePoint = dpkPointDate.Text;


                if (rdbtnMale.Checked) { sex = "1"; }
                if (rdbtnFemale.Checked) { sex = "2"; }
                if (rdbtnOther.Checked) { sex = "3"; }

                if (fullname.Length != 0 && dob.Length != 0 && phone.Length != 0 && email.Length != 0 && address.Length != 0 &&
                    cmnd.Length != 0 && sex.Length != 0 && insurance.Length != 0 && dateStart.Length != 0 && dateEnd.Length != 0 && datePoint.Length != 0)
                {
                    if (Regex.IsMatch(fullname, @"^[A-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ]+$") && fullname.Length <= 100)
                    {
                        if (Regex.IsMatch(phone, @"^[0-9]+$") && phone.Length == 10)
                        {
                            if ((Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z") && email.Length <= 100 && email.Length != 0) || email.Length == 0)
                            {

                                string code24 = "SELECT * FROM RESIDENT WHERE RESIDENT_ID='" + cmnd + "'";

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

                                    string code1 = "SELECT RESIDENT_NAME FROM RESIDENT WHERE RESIDENT_PHONE='" + phone + "'";

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

                                        string code2 = "UPDATE R  SET R.RESIDENT_NAME=N'" +
                                                                fullname + "',R.RESIDENT_DOB=N'" +
                                                                dob + "',R.RESIDENT_PHONE=N'" +
                                                                phone + "',R.RESIDENT_SEX=N'" +
                                                                sex + "', R.RESIDENT_EMAIL=N'" +
                                                                email + "',R.RESIDENT_PROVINCE=N'" +
                                                                province + "',R.RESIDENT_DISTRICT=N'" +
                                                                district + "',R.RESIDENT_WARD=N'" +
                                                                ward + "',R.RESIDENT_INSURANCE=N'" +
                                                                insurance + "',R.RESIDENT_DATESTART=N'" +
                                                                dateStart + "',R.RESIDENT_DATEEND=N'" +
                                                                dateEnd + "',R.RESIDENT_DATEPOINT=N'" +
                                                                datePoint + "',R.RESIDENT_ADDRESS=N'" +
                                                                address + "',R.RESIDENT_NATIONALITY=N'" +
                                                                nationality + "',R.RESIDENT_RELIGION=N'" +
                                                                religion + "',R.RESIDENT_ETHNIC=N'" +
                                                                ethnic + "',R.RESIDENT_JOB=N'" +
                                                                job + "' FROM RESIDENT AS R JOIN RESIDENT_ACCOUNT AS RA ON R.RESIDENT_ID=RA.RA_RESIDENT WHERE RA.RA_USERNAME='" + username + "'";

                                        try
                                        {
                                            clsDatabase.OpenConnection();
                                            SqlCommand cmd2 = new SqlCommand(code2, clsDatabase.con);
                                            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                                            cmd2.ExecuteNonQuery();

                                            string result = "Bạn đã cập nhật thông tin thành công";

                                            Notification notification21 = new Notification(result);
                                            notification21.ShowDialog();

                                            btnUpdate.Text = "Chỉnh sửa thông tin";
                                            txtEmail.Enabled = false;
                                            txtName.Enabled = false;
                                            txtPhone.Enabled = false;
                                            txtAddress.Enabled = false;
                                            txtInsurance.Enabled = false;
                                            txtCmnd.Enabled = false;

                                            cbxCity.Enabled = false;
                                            cbxDistrict.Enabled = false;
                                            cbxWard.Enabled = false;
                                            cbxEthnic.Enabled = false;
                                            cbxJob.Enabled = false;
                                            cbxNationality.Enabled = false;
                                            cbxReligion.Enabled = false;

                                            rdbtnFemale.Enabled = false;
                                            rdbtnMale.Enabled = false;
                                            rdbtnOther.Enabled = false;

                                            dpkDob.Enabled = false;
                                            dpkStartDate.Enabled = false;
                                            dpkEndDate.Enabled = false;
                                            dpkPointDate.Enabled = false;

                                            clsDatabase.CloseConnection();
                                            return;
                                        }
                                        catch (Exception ex)
                                        {
                                            Debug.WriteLine(code2);
                                            Notification notification31 = new Notification("Đã xảy ra lỗi, xin thử lại sau");
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
            UserHomePage userHomePage = new UserHomePage(username);
            this.Hide();
            userHomePage.ShowDialog();
            this.Close();
        }
    }
}
