using CovidMangementApp.Helpers;
using CovidMangementApp.UI.Custom;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CovidMangementApp.UI.User
{
    public partial class VaccinationCertificate : Form
    {
        public Point mouseLocation;
        private String username;
        private String residentCmnd;

        public VaccinationCertificate()
        {
            InitializeComponent();
        }
        public VaccinationCertificate(String username)
        {
            InitializeComponent();
            this.username = username;
        }
        private void VaccinationCertificate_Load(object sender, EventArgs e)
        {
            getVaccineNumber();

            BindingCertData();
        }
        private void getVaccineNumber()
        {
            string code = "SELECT COUNT(*) COUNT FROM VACCINATION_HISTORY VH JOIN RESIDENT_ACCOUNT RA ON VH.VH_RESIDENT=RA.RA_RESIDENT WHERE RA_USERNAME='" + username + "'";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    string countVaccine = reader["COUNT"].ToString();

                    if (countVaccine.Equals("0"))
                    {
                        btnOpenCertificate.Visible = false;
                        btnNoVaccine.Visible = true;
                        pnlCertificate.Visible = false;
                    }
                    else
                    {
                        btnOpenCertificate.Visible = true;
                        btnNoVaccine.Visible = false;
                        pnlCertificate.Visible = false;

                        btnOpenCertificate.Text = "ĐÃ TIÊM " + countVaccine + " MŨI VẮC XIN";
                    }
                }

                clsDatabase.CloseConnection();

            }
            catch (Exception ex)
            {
                Notification notification = new Notification("Lỗi cơ sở dữ liệu: " + ex);
                notification.ShowDialog();
            }
        }

        private void btnOpenCertificate_Click(object sender, EventArgs e)
        {
            if (pnlCertificate.Visible == false)
            {
                pnlCertificate.Visible = true;

            }
            else
            {
                pnlCertificate.Visible = false;
            }

        }

        private void BindingCertData()
        {

            flowVaccineList.Controls.Clear();

            string code = "SELECT R.RESIDENT_NAME, R.RESIDENT_DOB, R.RESIDENT_ID, P.PROVINCE_NAME, D.DISTRICT_NAME, W.WARD_NAME, V.VACCINE_NAME, VH.VH_INJECTION, F.FACILITY_NAME, VH.VH_DATE FROM RESIDENT R JOIN PROVINCE P ON R.RESIDENT_PROVINCE=P.PROVINCE_ID JOIN DISTRICT D ON R.RESIDENT_DISTRICT=D.DISTRICT_ID JOIN WARD W ON R.RESIDENT_WARD=W.WARD_ID JOIN VACCINATION_HISTORY VH ON VH.VH_RESIDENT=R.RESIDENT_ID JOIN VACCINE V ON VH.VH_VACCINE=V.VACCINE_ID JOIN FACILITY F ON VH.VH_FACILITY=F.FACILITY_ID WHERE R.RESIDENT_PHONE='" + username + "' ORDER BY VH.VH_INJECTION";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    int i = 1;

                    while (reader.Read())
                    {
                        txtName.Text = reader["RESIDENT_NAME"].ToString();
                        txtDob.Text = reader["RESIDENT_DOB"].ToString();
                        txtCmnd.Text = reader["RESIDENT_ID"].ToString();
                        txtAddress.Text = reader["WARD_NAME"].ToString() + ", " + reader["DISTRICT_NAME"].ToString() + ", " + reader["PROVINCE_NAME"].ToString();

                        VaccineCertItem item = new VaccineCertItem();

                        item.VaccineIndex = i + "";
                        item.VaccineDate = reader["VH_DATE"].ToString();
                        item.VaccineName = reader["VACCINE_NAME"].ToString();
                        item.VaccineFacility = reader["FACILITY_NAME"].ToString();
                        item.VaccineInjection = reader["VH_INJECTION"].ToString();

                        flowVaccineList.Controls.Add(item);


                        i++;
                    }

                }
                else
                {
                    Debug.WriteLine(code);
                    Notification notification = new Notification("Không tìm thấy thông tin chứng nhận");
                    notification.ShowDialog();
                }
                clsDatabase.CloseConnection();

            }
            catch (Exception ex)
            {
                Notification notification = new Notification("Lỗi cơ sở dữ liệu: " + ex);
                notification.ShowDialog();
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
            UserHomePage userHomePage = new UserHomePage(username);
            this.Hide();
            userHomePage.ShowDialog();
            this.Close();
        }
    }
}
