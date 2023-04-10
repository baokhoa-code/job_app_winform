using CovidMangementApp.Helpers;
using System.Data.SqlClient;

namespace CovidMangementApp.UI.User
{
    public partial class UserChangePassword : Form
    {
        public Point mouseLocation;
        private String username;
        public UserChangePassword()
        {
            InitializeComponent();
        }
        public UserChangePassword(String username)
        {
            InitializeComponent();
            this.username = username;
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
            UserHomePage residentHomePage = new UserHomePage(username);
            this.Hide();
            residentHomePage.ShowDialog();
            this.Close();
        }

        private void txtOldPassword_TrailingIconClick(object sender, EventArgs e)
        {
            if (txtOldPassword.Password == true)
            {
                txtOldPassword.TrailingIcon = Properties.Resources.hide_pass;
            }
            else
            {
                txtOldPassword.TrailingIcon = Properties.Resources.show_pass;
            }
            txtOldPassword.Password = !txtOldPassword.Password;
        }

        private void txtNewPassword_TrailingIconClick(object sender, EventArgs e)
        {
            if (txtNewPassword.Password == true)
            {
                txtNewPassword.TrailingIcon = Properties.Resources.hide_pass;
            }
            else
            {
                txtNewPassword.TrailingIcon = Properties.Resources.show_pass;
            }
            txtNewPassword.Password = !txtNewPassword.Password;
        }

        private void txtReNewPassword_TrailingIconClick(object sender, EventArgs e)
        {
            if (txtReNewPassword.Password == true)
            {
                txtReNewPassword.TrailingIcon = Properties.Resources.hide_pass;
            }
            else
            {
                txtReNewPassword.TrailingIcon = Properties.Resources.show_pass;
            }
            txtReNewPassword.Password = !txtReNewPassword.Password;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string oldpassword = txtOldPassword.Text;
            string newpassword = txtNewPassword.Text;
            string againpassword = txtReNewPassword.Text;

            if (oldpassword.Length == 0 || newpassword.Length == 0 || againpassword.Length == 0)
            {
                Notification notification = new Notification("Bạn phải nhập đầy đủ thông tin ở các trường có dấu (*)");
                notification.ShowDialog();
                return;
            }
            else
            {
                if (newpassword.Equals(againpassword))
                {
                    string code = "SELECT RA_PASSWORD FROM RESIDENT_ACCOUNT WHERE RA_USERNAME=N'" + username + "'";


                    try
                    {
                        clsDatabase.OpenConnection();
                        SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();

                            string r_password = reader["RA_PASSWORD"].ToString();

                            clsDatabase.CloseConnection();

                            if (r_password.Equals(oldpassword))
                            {
                                string query = "UPDATE RESIDENT_ACCOUNT SET RA_PASSWORD=N'" + newpassword + "' WHERE RA_USERNAME=N'" + username + "'";

                                try
                                {
                                    clsDatabase.OpenConnection();

                                    SqlCommand cmd1 = new SqlCommand(query, clsDatabase.con);
                                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);

                                    cmd1.ExecuteNonQuery();

                                    Notification notification22 = new Notification("Bạn đã thay đổi mật khẩu thành công");
                                    notification22.ShowDialog();
                                    clsDatabase.CloseConnection();
                                    return;
                                }
                                catch (Exception ex)
                                {
                                    Notification notification21 = new Notification("Đã xảy ra lỗi, xin thử lại sau");
                                    notification21.ShowDialog();
                                    return;
                                }
                            }
                            else
                            {
                                Notification notification23 = new Notification("Mật khẩu cũ không chính xác");
                                notification23.ShowDialog();
                                return;
                            }
                        }
                        else
                        {
                            Notification notification = new Notification("Không tìm câu trả lời cũ");
                            notification.ShowDialog();
                            clsDatabase.CloseConnection();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        Notification notification = new Notification("Lỗi cơ sở dữ liệu: " + ex);
                        notification.ShowDialog();
                        clsDatabase.CloseConnection();
                    }
                }
                else
                {
                    Notification notification = new Notification("Mật khẩu mới không khớp");
                    notification.ShowDialog();
                    return;
                }
            }
        }
    }
}
