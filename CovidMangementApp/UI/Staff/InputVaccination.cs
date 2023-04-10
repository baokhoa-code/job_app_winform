using CovidMangementApp.Helpers;
using System.Data.SqlClient;

namespace CovidMangementApp.UI.Staff
{
    public partial class InputVaccination : Form
    {
        public Point mouseLocation;
        private String username;
        private List<City> cities;
        private List<District> districts;
        private List<Ward> wards;
        private List<Vaccine> vaccines;
        private List<Facility> facilities;
        public InputVaccination()
        {
            InitializeComponent();
            BindingData();
        }

        public InputVaccination(string username)
        {
            InitializeComponent();
            BindingData();
            this.username = username;
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
        private void BindingVaccine()
        {
            vaccines = new List<Vaccine>();

            string code = "SELECT VACCINE_ID, VACCINE_NAME FROM VACCINE";

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
                        string id = reader["VACCINE_ID"].ToString();
                        string name = reader["VACCINE_NAME"].ToString();

                        vaccines.Add(new Vaccine(id, name));
                    }

                    cbxVaccine.DataSource = vaccines;
                    cbxVaccine.DisplayMember = "Name";
                    cbxVaccine.ValueMember = "VaccineCode";

                }
                else
                {
                    Notification notification = new Notification("Không tìm thấy vắc xin");
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
        private void BindingFacility()
        {
            facilities = new List<Facility>();

            string code = "SELECT FACILITY_ID, FACILITY_NAME FROM FACILITY";

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
                        string id = reader["FACILITY_ID"].ToString();
                        string name = reader["FACILITY_NAME"].ToString();

                        facilities.Add(new Facility(id, name));
                    }

                    cbxFacility.DataSource = facilities;
                    cbxFacility.DisplayMember = "Name";
                    cbxFacility.ValueMember = "FacilityCode";

                }
                else
                {
                    Notification notification = new Notification("Không tìm thấy vắc xin");
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
            BindingDisctrict();
            BindingWard();
            BindingVaccine();
            BindingFacility();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String cmnd = txtCmnd.Text;
            String fullname = txtName.Text;
            String dob = dpkDob.Text;
            String sex = "";
            if (rdbtnMale.Checked) { sex = "1"; }
            if (rdbtnFemale.Checked) { sex = "2"; }
            if (rdbtnOther.Checked) { sex = "3"; }
            String phone = txtPhone.Text;
            String city = cbxCity.SelectedValue.ToString();
            String district = cbxDistrict.SelectedValue.ToString();
            String ward = cbxWard.Text;
            String address = txtAddress.Text;
            String vaccine = cbxVaccine.SelectedValue.ToString();
            String injection = cbxInjection.Text;
            String facility = cbxFacility.SelectedValue.ToString();
            String dateInject = dpkDate.Text;
            String timeInject = dpkTime.Text;

            if (fullname.Length != 0 && dob.Length != 0 && sex.Length != 0 && phone.Length != 0 && cmnd.Length != 0 && city.Length != 0
                && district.Length != 0 && ward.Length != 0 && address.Length != 0 && vaccine.Length != 0 && injection.Length != 0 && facility.Length != 0
                && dateInject.Length != 0 && timeInject.Length != 0)
            {
                string code2 = "INSERT INTO VACCINATION_HISTORY VALUES (N'" +
                                                    cmnd + "',N'" +
                                                    vaccine + "',N'" +
                                                    injection + "',N'" +
                                                    facility + "',N'" +
                                                    dateInject + "',N'" +
                                                    timeInject + "')";

                try
                {
                    clsDatabase.OpenConnection();
                    SqlCommand cmd2 = new SqlCommand(code2, clsDatabase.con);
                    SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                    cmd2.ExecuteNonQuery();

                    Notification notification311 = new Notification("Bạn đã nhập thông tin tiêm chủng thành công");
                    notification311.ShowDialog();
                    clsDatabase.CloseConnection();
                    return;
                }
                catch (Exception ex)
                {
                    Notification notification31 = new Notification("Đã xảy ra lỗi, xin thử lại sau");
                    notification31.ShowDialog();
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
            StaffHomePage staffHomePage = new StaffHomePage(username);
            this.Hide();
            staffHomePage.ShowDialog();
            this.Close();
        }
    }
}
