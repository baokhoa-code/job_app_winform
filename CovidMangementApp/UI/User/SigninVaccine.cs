using CovidMangementApp.Helpers;
using CovidMangementApp.UI.Custom;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CovidMangementApp.UI.User
{
    public partial class SigninVaccine : Form
    {
        public Point mouseLocation;
        private String username;
        private String residentCmnd;
        private List<Target> targets;

        public SigninVaccine()
        {
            InitializeComponent();
        }

        public SigninVaccine(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void SigninVaccine_Load(object sender, EventArgs e)
        {
            BindingRegistList();
            getInfo();
            BindingTarget();
        }
        private void BindingTarget()
        {
            targets = new List<Target>();

            string code = "SELECT OBJECT_ID, OBJECT_NAME FROM OBJECT";

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
                        string id = reader["OBJECT_ID"].ToString();
                        string name = reader["OBJECT_NAME"].ToString();

                        targets.Add(new Target(id, name));
                    }

                    cbxRegistTarget.DataSource = targets;
                    cbxRegistTarget.DisplayMember = "Name";
                    cbxRegistTarget.ValueMember = "TargetCode";

                }
                else
                {
                    Notification notification = new Notification("Không tìm thấy đối tượng");
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
        private void getInfo()
        {
            string code = "SELECT R.RESIDENT_NAME, R.RESIDENT_DOB, R.RESIDENT_ID, R.RESIDENT_SEX, R.RESIDENT_EMAIL, P.PROVINCE_NAME, D.DISTRICT_NAME, W.WARD_NAME, R.RESIDENT_ADDRESS, R.RESIDENT_INSURANCE, C.COUNTRY_NAME, J.JOB_NAME  FROM RESIDENT R JOIN SEX S ON R.RESIDENT_SEX=S.SEX_ID JOIN PROVINCE P ON R.RESIDENT_PROVINCE=P.PROVINCE_ID JOIN DISTRICT D ON R.RESIDENT_DISTRICT=D.DISTRICT_ID JOIN WARD W ON R.RESIDENT_WARD=W.WARD_ID JOIN COUNTRY C ON R.RESIDENT_NATIONALITY=C.COUNTRY_ID JOIN ETHNIC E ON R.RESIDENT_ETHNIC=E.ETHNIC_ID JOIN RELIGION RE ON RE.RELIGION_ID=R.RESIDENT_RELIGION JOIN JOB J ON R.RESIDENT_JOB=J.JOB_ID WHERE R.RESIDENT_PHONE='" + username + "'";

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
                    residentCmnd = cmnd1;
                    string sex1 = reader.GetString(3);
                    string province1 = reader.GetString(5);
                    string district1 = reader.GetString(6);
                    string ward1 = reader.GetString(7);
                    string address1 = reader.GetString(8);
                    string insurance1 = reader.GetString(9);
                    string nationality1 = reader.GetString(10);
                    string job1 = reader.GetString(10);

                    if (sex1 == "1") rdbtnRegistMale.Checked = true;
                    if (sex1 == "2") rdbtnRegistFemale.Checked = true;
                    if (sex1 == "3") rdbtnRegistOther.Checked = true;


                    txtRegistName.Text = fullname1;
                    txtRegistDob.Text = dob1;
                    txtRegistCmnd.Text = cmnd1;
                    txtRegistCity.Text = province1;
                    txtRegistDistrict.Text = district1;
                    txtRegistWard.Text = ward1;
                    txtRegistAddress.Text = address1;
                    txtRegistBhyt.Text = insurance1;
                    txtRegistNationality.Text = nationality1;
                    txtRegistJob.Text = job1;

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
        private void BindingRegistList()
        {
            flowListRegist.Controls.Clear();

            string code = "SELECT SV.SV_STATE, SV.SV_TIMESIGNIN, SV.SV_DATEDESIRE, OB.OBJECT_NAME FROM SIGNIN_VACCINE SV JOIN OBJECT OB ON SV.SV_OBJECT = OB.OBJECT_ID JOIN RESIDENT_ACCOUNT RA ON SV.SV_RESIDENT=RA.RA_RESIDENT WHERE RA.RA_USERNAME='" + username + "'";

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
                        string datetime = reader["SV_TIMESIGNIN"].ToString();
                        string[] vs = datetime.Split(' ');
                        string state = reader["SV_STATE"].ToString();
                        string datedes = reader["SV_DATEDESIRE"].ToString();
                        string targetdes = reader["OBJECT_NAME"].ToString();

                        SigninVaccineItem item = new SigninVaccineItem();

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
        private void btnAddRegist_Click(object sender, EventArgs e)
        {
            String target;
            String desireDate;
            String timesignin;

            target = cbxRegistTarget.SelectedValue.ToString();
            desireDate = dpkRegistDateDesire.Text;
            timesignin = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            if (target == null || desireDate == null || target.Length == 0 || desireDate.Length == 0)
            {
                Notification notification = new Notification("Bạn phải nhập đầy đủ thông tin ở các trường có dấu (*)");
                notification.ShowDialog();
            }
            else
            {
                string code = "INSERT INTO SIGNIN_VACCINE VALUES (N'" +
                                        residentCmnd + "',N'" +
                                        timesignin + "',N'" +
                                        target + "',N'" +
                                        desireDate + "',0)";

                try
                {
                    clsDatabase.OpenConnection();
                    SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();

                    Notification notification311 = new Notification("Bạn đã đăng ký tiêm ngừa thành công");
                    notification311.ShowDialog();
                    clsDatabase.CloseConnection();
                    BindingRegistList();
                    clearRegist();
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
        }
        private void itemRegistDetailClick(Object obj, EventArgs e)
        {
            clearRegist();

            SigninVaccineItem item = (SigninVaccineItem)obj;

            if (lblDetail.Visible == false)
            {
                lblDetail.Visible = true;
                pnlDetail.Visible = true;
                lblRegist.Visible = false;
                pnlRegist.Visible = false;
            }

            lblDetail.Text = "CHI TIẾT LỊCH SỬ ĐĂNG KÝ TIÊM SỐ " + item.IndexDeclaration;
            txtDetailDateDesire.Text = item.DateDesireDeclaration;
        }
        private void btnOpenRegist_Click(object sender, EventArgs e)
        {
            clearRegist();
            if (lblRegist.Visible == false)
            {
                lblRegist.Visible = true;
                pnlRegist.Visible = true;
                lblDetail.Visible = false;
                pnlDetail.Visible = false;
            }
            else
            {
                lblRegist.Visible = false;
                pnlRegist.Visible = false;
                lblDetail.Visible = false;
                pnlDetail.Visible = false;
            }
        }
        private void clearRegist()
        {
            cbxRegistTarget.SelectedIndex = -1;
            dpkRegistDateDesire.Text = "";
            rd1N.Checked = true;
            rd2N.Checked = true;
            rd3N.Checked = true;
            rd4N.Checked = true;
            rd5N.Checked = true;
            rd6N.Checked = true;
            rd7N.Checked = true;
            rd8N.Checked = true;
            rd9N.Checked = true;
            rd10N.Checked = true;
        }
        private void rd1(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(sender, rd1Y))
            {
                if (rd1Y.Checked == true)
                {
                    rd1N.Checked = false;
                    rd1F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd1N))
            {
                if (rd1N.Checked == true)
                {
                    rd1Y.Checked = false;
                    rd1F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd1F))
            {
                if (rd1F.Checked == true)
                {
                    rd1Y.Checked = false;
                    rd1N.Checked = false;
                }
            }
        }
        private void rd2(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(sender, rd2Y))
            {
                if (rd2Y.Checked == true)
                {
                    rd2N.Checked = false;
                    rd2F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd2N))
            {
                if (rd2N.Checked == true)
                {
                    rd2Y.Checked = false;
                    rd2F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd2F))
            {
                if (rd2F.Checked == true)
                {
                    rd2Y.Checked = false;
                    rd2N.Checked = false;
                }
            }
        }
        private void rd3(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(sender, rd3Y))
            {
                if (rd3Y.Checked == true)
                {
                    rd3N.Checked = false;
                    rd3F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd3N))
            {
                if (rd3N.Checked == true)
                {
                    rd3Y.Checked = false;
                    rd3F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd3F))
            {
                if (rd3F.Checked == true)
                {
                    rd3Y.Checked = false;
                    rd3N.Checked = false;
                }
            }
        }
        private void rd4(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(sender, rd4Y))
            {
                if (rd4Y.Checked == true)
                {
                    rd4N.Checked = false;
                    rd4F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd4N))
            {
                if (rd4N.Checked == true)
                {
                    rd4Y.Checked = false;
                    rd4F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd4F))
            {
                if (rd4F.Checked == true)
                {
                    rd4Y.Checked = false;
                    rd4N.Checked = false;
                }
            }
        }
        private void rd5(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(sender, rd5Y))
            {
                if (rd5Y.Checked == true)
                {
                    rd5N.Checked = false;
                    rd5F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd5N))
            {
                if (rd5N.Checked == true)
                {
                    rd5Y.Checked = false;
                    rd5F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd5F))
            {
                if (rd5F.Checked == true)
                {
                    rd5Y.Checked = false;
                    rd5N.Checked = false;
                }
            }
        }
        private void rd6(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(sender, rd6Y))
            {
                if (rd6Y.Checked == true)
                {
                    rd6N.Checked = false;
                    rd6F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd6N))
            {
                if (rd6N.Checked == true)
                {
                    rd6Y.Checked = false;
                    rd6F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd6F))
            {
                if (rd6F.Checked == true)
                {
                    rd6Y.Checked = false;
                    rd6N.Checked = false;
                }
            }
        }
        private void rd7(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(sender, rd7Y))
            {
                if (rd7Y.Checked == true)
                {
                    rd7N.Checked = false;
                    rd7F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd7N))
            {
                if (rd7N.Checked == true)
                {
                    rd7Y.Checked = false;
                    rd7F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd7F))
            {
                if (rd7F.Checked == true)
                {
                    rd7Y.Checked = false;
                    rd7N.Checked = false;
                }
            }
        }
        private void rd8(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(sender, rd8Y))
            {
                if (rd8Y.Checked == true)
                {
                    rd8N.Checked = false;
                    rd8F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd8N))
            {
                if (rd8N.Checked == true)
                {
                    rd8Y.Checked = false;
                    rd8F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd8F))
            {
                if (rd8F.Checked == true)
                {
                    rd8Y.Checked = false;
                    rd8N.Checked = false;
                }
            }
        }
        private void rd9(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(sender, rd9Y))
            {
                if (rd9Y.Checked == true)
                {
                    rd9N.Checked = false;
                    rd9F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd9N))
            {
                if (rd9N.Checked == true)
                {
                    rd9Y.Checked = false;
                    rd9F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd9F))
            {
                if (rd9F.Checked == true)
                {
                    rd9Y.Checked = false;
                    rd9N.Checked = false;
                }
            }
        }
        private void rd10(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(sender, rd10Y))
            {
                if (rd10Y.Checked == true)
                {
                    rd10N.Checked = false;
                    rd10F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd10N))
            {
                if (rd10N.Checked == true)
                {
                    rd10Y.Checked = false;
                    rd10F.Checked = false;
                }
            }
            else if (object.ReferenceEquals(sender, rd10F))
            {
                if (rd10F.Checked == true)
                {
                    rd10Y.Checked = false;
                    rd10N.Checked = false;
                }
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
