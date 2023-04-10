using CovidMangementApp.Helpers;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CovidMangementApp.UI.Admin
{
    public partial class AdminHomePage : Form
    {
        private String username;
        public Point mouseLocation;
        public AdminHomePage()
        {
            InitializeComponent();
        }

        public AdminHomePage(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadFullName();

        }
        private void LoadFullName()
        {

            string code = "SELECT * FROM ADMIN JOIN ADMIN_ACCOUNT ON ADMIN.ADMIN_ID = ADMIN_ACCOUNT.AA_ADMIN WHERE AA_USERNAME= '" + username + "'";

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
                    txtName.Text = fullname1 + " (ADMIN)";
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            drpdMenu.Show(btnMenu, drpdMenu.Width - btnMenu.Width - 370, btnMenu.Height);
        }

        private void btnAccountInfo_Click(object sender, EventArgs e)
        {
            AdminAccountInformation adminAccountInformation = new AdminAccountInformation(username);
            this.Hide();
            adminAccountInformation.ShowDialog();
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            AdminChangePassword adminChangePassword = new AdminChangePassword(username);
            this.Hide();
            adminChangePassword.ShowDialog();
            this.Close();
        }

        private void btnChangeAnswer_Click(object sender, EventArgs e)
        {
            AdminChangeAnswer adminChangeAnswer = new AdminChangeAnswer(username);
            this.Hide();
            adminChangeAnswer.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void btnGoVacine_Click(object sender, EventArgs e)
        {
            VaccineManagement vaccineManagement = new VaccineManagement(username);
            this.Hide();
            vaccineManagement.ShowDialog();
            this.Close();
        }

        private void btnGoAdminManage_Click(object sender, EventArgs e)
        {
            AdminManagment adminManagment = new AdminManagment(username);
            this.Hide();
            adminManagment.ShowDialog();
            this.Close();
        }

        private void btnGoStaffManage_Click(object sender, EventArgs e)
        {
            StaffManagment staffManagment = new StaffManagment(username);
            this.Hide();
            staffManagment.ShowDialog();
            this.Close();
        }

        private void btnGoVaccineFacility_Click(object sender, EventArgs e)
        {
            VaccinationFacilityManagement vaccinationFacilityManagement = new VaccinationFacilityManagement(username);
            this.Hide();
            vaccinationFacilityManagement.ShowDialog();
            this.Close();
        }
    }
}
