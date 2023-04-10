using CovidMangementApp.Helpers;
using CovidMangementApp.UI.Custom;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CovidMangementApp.UI.Staff
{
    public partial class ResponseSigninVaccine : Form
    {
        public Point mouseLocation;
        private String username;
        private String residentCmnd;
        private String timesignin;
        public ResponseSigninVaccine()
        {
            InitializeComponent();
        }
        public ResponseSigninVaccine(String username)
        {
            InitializeComponent();
            this.username = username;
        }
        private void ResponseSigninVaccine_Load(object sender, EventArgs e)
        {
            BindingRegistList();
        }
        private void BindingRegistList()
        {
            flowListRegist.Controls.Clear();

            string code = "SELECT SV.SV_RESIDENT, SV.SV_STATE, SV.SV_TIMESIGNIN, SV.SV_DATEDESIRE, OB.OBJECT_NAME FROM SIGNIN_VACCINE SV JOIN OBJECT OB ON SV.SV_OBJECT = OB.OBJECT_ID JOIN RESIDENT_ACCOUNT RA ON SV.SV_RESIDENT=RA.RA_RESIDENT WHERE SV.SV_STATE = '0'";

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
                        string cmndtemp = reader["SV_RESIDENT"].ToString();
                        string datetime = reader["SV_TIMESIGNIN"].ToString();
                        string[] vs = datetime.Split(' ');
                        string state = reader["SV_STATE"].ToString();
                        string datedes = reader["SV_DATEDESIRE"].ToString();
                        string targetdes = reader["OBJECT_NAME"].ToString();

                        ResponseSigninVaccineItem item = new ResponseSigninVaccineItem();

                        item.CmndDeclaration = cmndtemp;
                        item.IndexDeclaration = i + "";
                        item.DateDeclaration = vs[0];
                        item.TimeDeclaration = vs[1];
                        item.StateDeclaration = state;
                        item.DateDesireDeclaration = datedes;
                        item.TargetDeclaration = targetdes;

                        flowListRegist.Controls.Add(item);

                        item.Click += new System.EventHandler(this.itemRegistDetailClick);

                        i++;
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
        private void itemRegistDetailClick(Object obj, EventArgs e)
        {
            ResponseSigninVaccineItem item = (ResponseSigninVaccineItem)obj;

            if (lblDetail.Visible == false)
            {
                lblDetail.Visible = true;
                pnlDetail.Visible = true;
            }

            lblDetail.Text = "CHI TIẾT LỊCH SỬ ĐĂNG KÝ TIÊM SỐ " + item.IndexDeclaration;
            txtDetailDateDesire.Text = item.DateDesireDeclaration;

            residentCmnd = item.CmndDeclaration;
            timesignin = item.DateDeclaration + " " + item.TimeDeclaration;

            loadDetail();
        }
        private void loadDetail()
        {
            string code = "SELECT R.RESIDENT_NAME, R.RESIDENT_DOB, R.RESIDENT_ID, R.RESIDENT_SEX, R.RESIDENT_EMAIL, P.PROVINCE_NAME, D.DISTRICT_NAME, W.WARD_NAME, R.RESIDENT_ADDRESS, R.RESIDENT_INSURANCE, C.COUNTRY_NAME, J.JOB_NAME  FROM RESIDENT R JOIN SEX S ON R.RESIDENT_SEX=S.SEX_ID JOIN PROVINCE P ON R.RESIDENT_PROVINCE=P.PROVINCE_ID JOIN DISTRICT D ON R.RESIDENT_DISTRICT=D.DISTRICT_ID JOIN WARD W ON R.RESIDENT_WARD=W.WARD_ID JOIN COUNTRY C ON R.RESIDENT_NATIONALITY=C.COUNTRY_ID JOIN ETHNIC E ON R.RESIDENT_ETHNIC=E.ETHNIC_ID JOIN RELIGION RE ON RE.RELIGION_ID=R.RESIDENT_RELIGION JOIN JOB J ON R.RESIDENT_JOB=J.JOB_ID WHERE R.RESIDENT_ID='" + residentCmnd + "'";

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
                    string cmnd1 = reader.GetString(2);
                    string sex1 = reader.GetString(3);
                    string province1 = reader.GetString(5);
                    string district1 = reader.GetString(6);
                    string ward1 = reader.GetString(7);
                    string address1 = reader.GetString(8);
                    string insurance1 = reader.GetString(9);
                    string nationality1 = reader.GetString(10);
                    string job1 = reader.GetString(10);

                    txtDetailName.Text = fullname1;
                    txtDetailDob.Text = dob1;
                    txtDetailCmnd.Text = cmnd1;
                    txtDetailCity.Text = province1;
                    txtDetailDistrict.Text = district1;
                    txtDetailWard.Text = ward1;
                    txtDetailBhyt.Text = insurance1;
                    txtDetailAddress.Text = address1;

                    if (sex1 == "1") txtDetailGender.Text = "Nam";
                    if (sex1 == "2") txtDetailGender.Text = "Nu";
                    if (sex1 == "3") txtDetailGender.Text = "Khac";

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
                Notification notification31 = new Notification(ex.ToString());
                notification31.ShowDialog();
                clsDatabase.CloseConnection();
                return;
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string code = "UPDATE SIGNIN_VACCINE SET SV_STATE='1' WHERE SV_RESIDENT= '" + residentCmnd + "' AND SV_TIMESIGNIN='" + timesignin + "'";

            try
            {
                Debug.WriteLine(code);
                clsDatabase.OpenConnection();
                SqlCommand cmd2 = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                cmd2.ExecuteNonQuery();

                string result = "Xác nhận đăng ký tiêm ngừa thành công";

                Notification notification21 = new Notification(result);
                notification21.ShowDialog();
                BindingRegistList();
                lblDetail.Visible = false;
                pnlDetail.Visible = false;
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
            StaffHomePage staffHome = new StaffHomePage(username);
            this.Hide();
            staffHome.ShowDialog();
            this.Close();
        }

    }
}
