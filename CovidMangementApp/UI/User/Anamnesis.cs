using CovidMangementApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace CovidMangementApp.UI.User
{
    public partial class Anamnesis : Form
    {
        public Point mouseLocation;
        private String username;
        private String residentCmnd;
        public Anamnesis()
        {
            InitializeComponent();
        }
        public Anamnesis(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Anamnesis_Load(object sender, EventArgs e)
        {
            loadCmnd();
            loadInfo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (btnUpdate.Text == "Tạo hồ sơ")
            {
                string bloodsugar = bloodSugar.ItemValueTextBox;
                string spo2s = spo2.ItemValueTextBox;
                string bloodpressure = bloodPressure.ItemValueTextBox;
                string heartrate = heartRate.ItemValueTextBox;
                string temperatures = temperature.ItemValueTextBox;
                string heights = height.ItemValueTextBox;
                string weights = weight.ItemValueTextBox;
                string bmis = bmi.ItemValueTextBox;
                string bloodtype = bloodType.ItemValueTextBox;
                string allergys = allergy.ItemValueTextBox;
                string sicks = sick.ItemValueTextBox;
                string surgerys = surgery.ItemValueTextBox;

                if (bloodsugar.Length == 0 || spo2s.Length == 0 || bloodpressure.Length == 0 || heartrate.Length == 0 ||
                    temperatures.Length == 0 || heights.Length == 0 || weights.Length == 0 || bmis.Length == 0 ||
                    bloodtype.Length == 0 || allergys.Length == 0 || sicks.Length == 0 || surgerys.Length == 0 ||
                    bloodSugar == null || spo2s == null || bloodpressure == null || heartrate == null ||
                    temperatures == null || heights == null || weights == null || bmis == null ||
                    bloodtype == null || allergys == null || sicks == null || surgerys == null)
                {
                    Notification notification = new Notification("Bạn phải nhập đầy đủ thông tin ở tất cả các trường");
                    notification.ShowDialog();
                }
                else
                {
                    string code = "INSERT INTO ANAMESIS VALUES(N'" +
                                        residentCmnd + "',N'" +
                                        bloodsugar + "',N'" +
                                        spo2s + "',N'" +
                                        bloodpressure + "',N'" +
                                        heartrate + "',N'" +
                                        temperatures + "',N'" +
                                        heights + "',N'" +
                                        weights + "',N'" +
                                        bmis + "',N'" +
                                        bloodtype + "',N'" +
                                        allergys + "',N'" +
                                        sicks + "',N'" +
                                        surgerys + "')";

                    try
                    {
                        clsDatabase.OpenConnection();
                        SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();

                        Notification notification311 = new Notification("Bạn đã tạo hồ sơ sức khỏe thành công");
                        notification311.ShowDialog();
                        clsDatabase.CloseConnection();

                        btnUpdate.Text = "Chỉnh sửa thông tin";

                        bloodSugar.EnabledTexBox = false;
                        spo2.EnabledTexBox = false;
                        bloodPressure.EnabledTexBox = false;
                        heartRate.EnabledTexBox = false;
                        temperature.EnabledTexBox = false;
                        height.EnabledTexBox = false;
                        weight.EnabledTexBox = false;
                        bmi.EnabledTexBox = false;
                        bloodType.EnabledTexBox = false;
                        allergy.EnabledTexBox = false;
                        sick.EnabledTexBox = false;
                        surgery.EnabledTexBox = false;
                        return;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(code);
                        Notification notification31 = new Notification("Đã xảy ra lỗi, xin thử lại sau");
                        notification31.ShowDialog();
                        clsDatabase.CloseConnection();
                        return;
                    }
                }

            }
            else if (btnUpdate.Text == "Chỉnh sửa thông tin")
            {
                btnUpdate.Text = "Cập nhật thông tin";

                bloodSugar.EnabledTexBox = true;
                spo2.EnabledTexBox = true;
                bloodPressure.EnabledTexBox = true;
                heartRate.EnabledTexBox = true;
                temperature.EnabledTexBox = true;
                height.EnabledTexBox = true;
                weight.EnabledTexBox = true;
                bmi.EnabledTexBox = true;
                bloodType.EnabledTexBox = true;
                allergy.EnabledTexBox = true;
                sick.EnabledTexBox = true;
                surgery.EnabledTexBox = true;
            }
            else
            {
                string bloodsugar = bloodSugar.ItemValueTextBox;
                string spo2s = spo2.ItemValueTextBox;
                string bloodpressure = bloodPressure.ItemValueTextBox;
                string heartrate = heartRate.ItemValueTextBox;
                string temperatures = temperature.ItemValueTextBox;
                string heights = height.ItemValueTextBox;
                string weights = weight.ItemValueTextBox;
                string bmis = bmi.ItemValueTextBox;
                string bloodtype = bloodType.ItemValueTextBox;
                string allergys = allergy.ItemValueTextBox;
                string sicks = sick.ItemValueTextBox;
                string surgerys = surgery.ItemValueTextBox;


                if (bloodsugar.Length == 0 || spo2s.Length == 0 || bloodpressure.Length == 0 || heartrate.Length == 0 ||
                    temperatures.Length == 0 || heights.Length == 0 || weights.Length == 0 || bmis.Length == 0 ||
                    bloodtype.Length == 0 || allergys.Length == 0 || sicks.Length == 0 || surgerys.Length == 0 ||
                    bloodSugar == null || spo2s == null || bloodpressure == null || heartrate == null ||
                    temperatures == null || heights == null || weights == null || bmis == null ||
                    bloodtype == null || allergys == null || sicks == null || surgerys == null)
                {
                    Notification notification = new Notification("Bạn phải nhập đầy đủ thông tin ở tất cả các trường");
                    notification.ShowDialog();
                }
                else
                {
                    string code = "UPDATE ANAMESIS SET A_BLOODSUGAR=N'" +
                    bloodsugar + "', A_SP02=N'" +
                    spo2s + "',A_BLOODPRESSURE=N'" +
                    bloodpressure + "', A_HEARTBEAT=N'" +
                    heartrate + "',A_TEMPERATURE=N'" +
                    temperatures + "',A_HEIGHT=N'" +
                    heights + "',A_WEIGHT=N'" +
                    weights + "',A_BMI=N'" +
                    bmis + "',A_BLOODGROUP=N'" +
                    bloodtype + "',A_ALLERGY=N'" +
                    allergys + "',A_SICK=N'" +
                    sicks + "',A_SURGERY=N'" +
                    surgerys + "' WHERE A_RESIDENT='" +
                                        residentCmnd + "'";

                    try
                    {
                        clsDatabase.OpenConnection();
                        SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();

                        Notification notification311 = new Notification("Bạn đã cập nhật hồ sơ sức khỏe thành công");
                        notification311.ShowDialog();
                        clsDatabase.CloseConnection();

                        btnUpdate.Text = "Chỉnh sửa thông tin";

                        bloodSugar.EnabledTexBox = false;
                        spo2.EnabledTexBox = false;
                        bloodPressure.EnabledTexBox = false;
                        heartRate.EnabledTexBox = false;
                        temperature.EnabledTexBox = false;
                        height.EnabledTexBox = false;
                        weight.EnabledTexBox = false;
                        bmi.EnabledTexBox = false;
                        bloodType.EnabledTexBox = false;
                        allergy.EnabledTexBox = false;
                        sick.EnabledTexBox = false;
                        surgery.EnabledTexBox = false;
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

        }

        private void loadInfo()
        {
            string code = "SELECT * FROM ANAMESIS A JOIN RESIDENT_ACCOUNT RA ON A.A_RESIDENT=RA.RA_RESIDENT WHERE RA.RA_USERNAME='" + username + "'";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string bloodsugar = reader["A_BLOODSUGAR"].ToString();
                    string spo2s = reader["A_SP02"].ToString();
                    string bloodpressure = reader["A_BLOODPRESSURE"].ToString();
                    string heartbeat = reader["A_HEARTBEAT"].ToString();
                    string temperatures = reader["A_TEMPERATURE"].ToString();
                    string heights = reader["A_HEIGHT"].ToString();
                    string weights = reader["A_WEIGHT"].ToString();
                    string bmis = reader["A_BMI"].ToString();
                    string bloodgroup = reader["A_BLOODGROUP"].ToString();
                    string allergys = reader["A_ALLERGY"].ToString();
                    string sicks = reader["A_SICK"].ToString();
                    string surgerys = reader["A_SURGERY"].ToString();

                    bloodSugar.PlaceHolderTexBox = "";
                    spo2.PlaceHolderTexBox = "";
                    bloodPressure.PlaceHolderTexBox = "";
                    heartRate.PlaceHolderTexBox = "";
                    temperature.PlaceHolderTexBox = "";
                    height.PlaceHolderTexBox = "";
                    weight.PlaceHolderTexBox = "";
                    bmi.PlaceHolderTexBox = "";
                    bloodType.PlaceHolderTexBox = "";
                    allergy.PlaceHolderTexBox = "";
                    sick.PlaceHolderTexBox = "";
                    surgery.PlaceHolderTexBox = "";

                    bloodSugar.ItemValueTextBox = bloodsugar;
                    spo2.ItemValueTextBox = spo2s;
                    bloodPressure.ItemValueTextBox = bloodpressure;
                    heartRate.ItemValueTextBox = heartbeat;
                    temperature.ItemValueTextBox = temperatures;
                    height.ItemValueTextBox = heights;
                    weight.ItemValueTextBox = weights;
                    bmi.ItemValueTextBox = bmis;
                    bloodType.ItemValueTextBox = bloodgroup;
                    allergy.ItemValueTextBox = allergys;
                    sick.ItemValueTextBox = sicks;
                    surgery.ItemValueTextBox = surgerys;

                }
                else
                {
                    btnUpdate.Text = "Tạo hồ sơ";

                    bloodSugar.EnabledTexBox = true;
                    spo2.EnabledTexBox = true;
                    bloodPressure.EnabledTexBox = true;
                    heartRate.EnabledTexBox = true;
                    temperature.EnabledTexBox = true;
                    height.EnabledTexBox = true;
                    weight.EnabledTexBox = true;
                    bmi.EnabledTexBox = true;
                    bloodType.EnabledTexBox = true;
                    allergy.EnabledTexBox = true;
                    sick.EnabledTexBox = true;
                    surgery.EnabledTexBox = true;
                }
                clsDatabase.CloseConnection();

            }
            catch (Exception ex)
            {
                Notification notification = new Notification("Lỗi cơ sở dữ liệu: " + ex);
                notification.ShowDialog();
            }
        }
        private void loadCmnd()
        {
            string code = "SELECT RA_RESIDENT FROM RESIDENT_ACCOUNT WHERE RA_USERNAME='" + username + "'";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    residentCmnd = reader["RA_RESIDENT"].ToString();
                }
                else
                {
                    residentCmnd = "";
                    Notification notification = new Notification("Không tìm thấy thông tin người dùng");
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
