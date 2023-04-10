using CovidMangementApp.Helpers;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CovidMangementApp.UI
{
    public partial class Regist : Form
    {
        public Point mouseLocation;
        public Regist()
        {
            InitializeComponent();

            BindingData();

        }
        private void BindingCity()
        {
            List<City> cities = new List<City>();

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
            List<Job> jobs = new List<Job>();

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
            List<Religion> religions = new List<Religion>();

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
            List<Ethnic> ethnics = new List<Ethnic>();

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

                List<District> districts = new List<District>();

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

                List<Ward> wards = new List<Ward>();

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
            List<Country> countries = new List<Country>();

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
        private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingDisctrict();
        }
        private void cbxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingWard();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {

            string fullname = txtName.Text;
            string dob = dpkDob.Text;
            string phone = txtPhone.Text;
            string cmnd = txtCmnd.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string insurance = txtInsurance.Text;
            string startday = dpkStartDate.Text;
            string endday = dpkEndDate.Text;
            string pointday = dpkPointDate.Text;
            string answer = txtAnswer.Text;
            string sex = "";
            string province = cbxCity.SelectedValue.ToString();
            string district = cbxDistrict.SelectedValue.ToString();
            string ward = cbxWard.SelectedValue.ToString();
            string ethnic = cbxEthnic.SelectedValue.ToString();
            string job = cbxJob.SelectedValue.ToString();
            string religion = cbxReligion.SelectedValue.ToString();
            string nationality = cbxNationality.SelectedValue.ToString();

            if (rdbtnMale.Checked) { sex = "1"; }
            if (rdbtnFemale.Checked) { sex = "2"; }
            if (rdbtnOther.Checked) { sex = "3"; }

            if (fullname.Length != 0 && dob.Length != 0 && sex.Length != 0 && phone.Length != 0 && cmnd.Length != 0 && province.Length != 0
                && district.Length != 0 && ward.Length != 0 && nationality.Length != 0 && ethnic.Length != 0 && job.Length != 0 && religion.Length != 0
                && answer.Length != 0 && startday.Length != 0 && endday.Length != 0 && pointday.Length != 0)
            {
                if (Regex.IsMatch(fullname, @"^[A-Z ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ]+$") && fullname.Length <= 100)
                {
                    if (Regex.IsMatch(phone, @"^[0-9]+$") && phone.Length == 10)
                    {
                        if (Regex.IsMatch(cmnd, @"^[a-zA-Z0-9]+$") && cmnd.Length <= 20)
                        {
                            if ((Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z") && email.Length <= 100 && email.Length != 0) || email.Length == 0)
                            {
                                string code = "SELECT RESIDENT_NAME FROM RESIDENT WHERE RESIDENT_ID='" + cmnd + "'";

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

                                        string code1 = "SELECT RA_ANSWER FROM RESIDENT_ACCOUNT WHERE RA_USERNAME='" + phone + "'";

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

                                                string code2 = "INSERT INTO RESIDENT VALUES (N'" +
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
                                                    insurance + "',N'" +
                                                    startday + "',N'" +
                                                    endday + "',N'" +
                                                    pointday + "',N'" +
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


                                                string code3 = "INSERT INTO RESIDENT_ACCOUNT VALUES ('" + phone + "','" + phone + "','" + cmnd + "','" + answer + "')";

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

                                                string result = "Bạn đã đăng ký thành công tài khoản. Hãy đăng nhập với tên đăng nhập là '" + phone + "' và mật khẩu là '" + phone + "'.";

                                                Notification notification = new Notification(result);
                                                notification.ShowDialog();

                                                Login login = new Login();
                                                this.Hide();
                                                login.ShowDialog();
                                                this.Close();
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
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
    public class Country
    {
        public string CountryCode { get; set; }
        public string Name { get; set; }

        public Country(string id, string name)
        {
            CountryCode = id;
            Name = name;
        }
    }

    public class City
    {
        public string CityCode { get; set; }
        public string Name { get; set; }

        public City(string id, string name)
        {
            CityCode = id;
            Name = name;
        }
    }

    public class District
    {
        public string DistrictCode { get; set; }
        public string Name { get; set; }

        public District(string id, string name)
        {
            DistrictCode = id;
            Name = name;
        }
    }

    public class Ward
    {
        public string WardCode { get; set; }
        public string Name { get; set; }

        public Ward(string id, string name)
        {
            WardCode = id;
            Name = name;
        }
    }

    public class Ethnic
    {
        public string EthnicCode { get; set; }
        public string Name { get; set; }

        public Ethnic(string id, string name)
        {
            EthnicCode = id;
            Name = name;
        }
    }

    public class Religion
    {
        public string ReligionCode { get; set; }
        public string Name { get; set; }

        public Religion(string id, string name)
        {
            ReligionCode = id;
            Name = name;
        }
    }

    public class Job
    {
        public string JobCode { get; set; }
        public string Name { get; set; }

        public Job(string id, string name)
        {
            JobCode = id;
            Name = name;
        }
    }

    public class Vaccine
    {
        public string VaccineCode { get; set; }
        public string Name { get; set; }

        public Vaccine(string id, string name)
        {
            VaccineCode = id;
            Name = name;
        }
    }
    public class VaccineWithInjection
    {
        public string VaccineName { get; set; }
        public string VaccineCode { get; set; }
        public string VaccineDate { get; set; }

        public VaccineWithInjection(string injection, string name, string code, string vaccineDate)
        {
            VaccineName = "Mũi " + injection + " - " + name;
            VaccineCode = code;
            VaccineDate = vaccineDate;
        }
    }

    public class Facility
    {
        public string FacilityCode { get; set; }
        public string Name { get; set; }

        public Facility(string id, string name)
        {
            FacilityCode = id;
            Name = name;
        }
    }
    public class Target
    {
        public string TargetCode { get; set; }
        public string Name { get; set; }

        public Target(string id, string name)
        {
            TargetCode = id;
            Name = name;
        }
    }


}
