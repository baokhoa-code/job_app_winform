using CovidMangementApp.Helpers;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CovidMangementApp.UI.User
{
    public partial class UserHomePage : Form
    {
        private String username;
        public Point mouseLocation;
        public UserHomePage()
        {
            InitializeComponent();
        }

        public UserHomePage(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadFullName();

        }
        private void LoadFullName()
        {

            string code = "SELECT R.RESIDENT_NAME FROM RESIDENT_ACCOUNT RA JOIN RESIDENT R ON RA.RA_RESIDENT=R.RESIDENT_ID WHERE RA.RA_USERNAME= '" + username + "'";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    string fullname1 = reader["RESIDENT_NAME"].ToString();
                    txtName.Text = fullname1 + " (RESIDENT)";
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
            UserAccountInformation userAccountInformation = new UserAccountInformation(username);
            this.Hide();
            userAccountInformation.ShowDialog();
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            UserChangePassword userChangePassword = new UserChangePassword(username);
            this.Hide();
            userChangePassword.ShowDialog();
            this.Close();
        }

        private void btnChangeAnswer_Click(object sender, EventArgs e)
        {
            UserChangeAnswer userChangeAnswer = new UserChangeAnswer(username);
            this.Hide();
            userChangeAnswer.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void btnGoMedicalDeclare_Click(object sender, EventArgs e)
        {
            MedicalDeclaration medicalDeclaration = new MedicalDeclaration(username);
            this.Hide();
            medicalDeclaration.ShowDialog();
            this.Close();
        }

        private void btnGoVaccineCert_Click(object sender, EventArgs e)
        {
            VaccinationCertificate vaccinationCertificate = new VaccinationCertificate(username);
            this.Hide();
            vaccinationCertificate.ShowDialog();
            this.Close();
        }

        private void btnGoSignVaccine_Click(object sender, EventArgs e)
        {
            SigninVaccine signinVaccine = new SigninVaccine(username);
            this.Hide();
            signinVaccine.ShowDialog();
            this.Close();
        }

        private void btnGoReactionAfterVaccine_Click(object sender, EventArgs e)
        {
            ReactionAfterVaccination reactionAfterVaccination = new ReactionAfterVaccination(username);
            this.Hide();
            reactionAfterVaccination.ShowDialog();
            this.Close();
        }

        private void btnGoAnamnesis_Click(object sender, EventArgs e)
        {
            Anamnesis anamnesis = new Anamnesis(username);
            this.Hide();
            anamnesis.ShowDialog();
            this.Close();
        }

        private void btnGoHandBook_Click(object sender, EventArgs e)
        {
            MedicalHandbook medicalHandbook = new MedicalHandbook(username);
            this.Hide();
            medicalHandbook.ShowDialog();
            this.Close();
        }
    }
}
