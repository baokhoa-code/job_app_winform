using CovidMangementApp.Helpers;
using CovidMangementApp.UI.Admin;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CovidMangementApp.UI.Staff
{
    public partial class StaffHomePage : Form
    {
        private String username;
        public Point mouseLocation;
        public StaffHomePage()
        {
            InitializeComponent();
        }

        public StaffHomePage(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadFullName();

        }
        private void LoadFullName()
        {

            string code = "SELECT * FROM STAFF JOIN STAFF_ACCOUNT ON STAFF.STAFF_ID = STAFF_ACCOUNT.SA_STAFF WHERE SA_USERNAME= '" + username + "'";

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
                    txtName.Text = fullname1 + " (STAFF)";
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
            StaffAccountInformation staffAccountInformation = new StaffAccountInformation(username);
            this.Hide();
            staffAccountInformation.ShowDialog();
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            StaffChangePassword staffChangePassword = new StaffChangePassword(username);
            this.Hide();
            staffChangePassword.ShowDialog();
            this.Close();
        }

        private void btnChangeAnswer_Click(object sender, EventArgs e)
        {
            StaffChangeAnswer staffChangeAnswer = new StaffChangeAnswer(username);
            this.Hide();
            staffChangeAnswer.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
        private void btnGoInputVaccine_Click(object sender, EventArgs e)
        {
            InputVaccination inputVaccination = new InputVaccination(username);
            this.Hide();
            inputVaccination.ShowDialog();
            this.Close();
        }

        private void btnGoSearchAnamnesis_Click(object sender, EventArgs e)
        {
            PatientAnamnesis patientAnamnesis = new PatientAnamnesis(username);
            this.Hide();
            patientAnamnesis.ShowDialog();
            this.Close();
        }

        private void btnGoResponseSignIn_Click(object sender, EventArgs e)
        {
            ResponseSigninVaccine vaccinationFacilityManagement = new ResponseSigninVaccine(username);
            this.Hide();
            vaccinationFacilityManagement.ShowDialog();
            this.Close();
        }
        private void btnGoResponseReaction_Click(object sender, EventArgs e)
        {
            ResponseReactionAfterVaccination vaccineManagement = new ResponseReactionAfterVaccination(username);
            this.Hide();
            vaccineManagement.ShowDialog();
            this.Close();
        }

    }
}
