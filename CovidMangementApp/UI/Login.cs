using CovidMangementApp.Helpers;
using CovidMangementApp.UI.Admin;
using CovidMangementApp.UI.Staff;
using CovidMangementApp.UI.User;
using System.Data;
using System.Data.SqlClient;

namespace CovidMangementApp.UI
{
    public partial class Login : Form
    {
        public Point mouseLocation;
        public Login()
        {
            InitializeComponent();

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

        private void btnGoForgot_Click(object sender, EventArgs e)
        {
            Forgot forgot = new Forgot();
            this.Hide();
            forgot.ShowDialog();
            this.Close();
        }

        private void btnGoRegist_Click(object sender, EventArgs e)
        {
            Regist regist = new Regist();
            this.Hide();
            regist.ShowDialog();
            this.Close();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0 && txtPassword.Text.Length == 0)
            {
                Notification notification = new Notification("Bạn phải nhập đầy đủ tên đăng nhập và mật khẩu");
                notification.ShowDialog();
                return;
            }
            else if (txtUsername.Text.Length == 0)
            {
                Notification notification = new Notification("Bạn phải nhập tên đăng nhập");
                notification.ShowDialog();
                return;
            }
            else if (txtPassword.Text.Length == 0)
            {
                Notification notification = new Notification("Bạn phải nhập mật khẩu");
                notification.ShowDialog();
                return;
            }
            else
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                string code = "";

                if (username.Length == 10)
                {
                    if (username.Substring(0, 5).Equals("admin"))
                    {
                        code = "SELECT AA_PASSWORD FROM ADMIN_ACCOUNT WHERE AA_USERNAME=@username";

                        try
                        {
                            clsDatabase.OpenConnection();
                            SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);

                            SqlParameter p1 = new SqlParameter("@username", SqlDbType.NVarChar);
                            p1.Value = username;

                            cmd.Parameters.Add(p1);

                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                reader.Read();
                                string aa_password = reader["AA_PASSWORD"].ToString();
                                if (password.Equals(aa_password))
                                {
                                    AdminHomePage adminHomePage = new AdminHomePage(username);
                                    this.Hide();
                                    adminHomePage.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    Notification notification = new Notification("Mật khẩu không chính xác");
                                    notification.ShowDialog();
                                    return;
                                }
                            }
                            else
                            {
                                Notification notification = new Notification("Tên đăng nhập không tồn tại");
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
                    else if (username.Substring(0, 5).Equals("staff"))
                    {
                        code = "SELECT SA_PASSWORD FROM STAFF_ACCOUNT WHERE SA_USERNAME=@username";

                        try
                        {
                            clsDatabase.OpenConnection();
                            SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);

                            SqlParameter p1 = new SqlParameter("@username", SqlDbType.NVarChar);
                            p1.Value = username;

                            cmd.Parameters.Add(p1);

                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                reader.Read();
                                string sa_password = reader["SA_PASSWORD"].ToString();
                                if (password.Equals(sa_password))
                                {
                                    StaffHomePage staffHomePage = new StaffHomePage(username);
                                    this.Hide();
                                    staffHomePage.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    Notification notification = new Notification("Mật khẩu không chính xác");
                                    notification.ShowDialog();
                                    return;
                                }
                            }
                            else
                            {
                                Notification notification = new Notification("Tên đăng nhập không tồn tại");
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
                    else
                    {
                        code = "SELECT RA_PASSWORD FROM RESIDENT_ACCOUNT WHERE RA_USERNAME=@username";

                        try
                        {
                            clsDatabase.OpenConnection();
                            SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);

                            SqlParameter p1 = new SqlParameter("@username", SqlDbType.NVarChar);
                            p1.Value = username;

                            cmd.Parameters.Add(p1);

                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                reader.Read();
                                string ra_password = reader["RA_PASSWORD"].ToString();
                                if (password.Equals(ra_password))
                                {
                                    UserHomePage userHomePage = new UserHomePage(username);
                                    this.Hide();
                                    userHomePage.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    Notification notification = new Notification("Mật khẩu không chính xác");
                                    notification.ShowDialog();
                                    return;
                                }
                            }
                            else
                            {
                                Notification notification = new Notification("Tên đăng nhập không tồn tại");
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
                else
                {
                    Notification notification = new Notification("Tên đăng nhập không tồn tại");
                    notification.ShowDialog();
                    return;
                }
            }
        }

        private void txtPassword_TrailingIconClick(object sender, EventArgs e)
        {
            if (txtPassword.Password == true)
            {
                txtPassword.TrailingIcon = Properties.Resources.hide_pass;
            }
            else
            {
                txtPassword.TrailingIcon = Properties.Resources.show_pass;
            }
            txtPassword.Password = !txtPassword.Password;
        }
    }
}
