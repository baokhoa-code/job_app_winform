using CovidMangementApp.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace CovidMangementApp.UI
{
    public partial class Forgot : Form
    {
        public Point mouseLocation;
        public Forgot()
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

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            String cmnd = txtCMND.Text;
            String answer = txtAnswer.Text;

            if (username.Length != 0 && cmnd.Length != 0 && answer.Length != 0 && cmnd.Length != 0 && password.Length != 0)
            {
                if (username.Length == 10)
                {
                    if (username.Substring(0, 5).Equals("admin"))
                    {
                        string code = "SELECT * FROM ADMIN_ACCOUNT WHERE AA_USERNAME=@username";

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
                                string result_cmnd = reader["AA_ADMIN"].ToString();
                                string result_answer = reader["AA_ANSWER"].ToString();
                                clsDatabase.CloseConnection();

                                if (cmnd.Equals(result_cmnd) && answer.Equals(result_answer))
                                {
                                    try
                                    {
                                        clsDatabase.OpenConnection();
                                        string code_password = "UPDATE ADMIN_ACCOUNT SET AA_PASSWORD=@password WHERE AA_USERNAME=@username";

                                        SqlCommand cmd_password = new SqlCommand(code_password, clsDatabase.con);
                                        SqlDataAdapter sda_password = new SqlDataAdapter(cmd_password);

                                        SqlParameter p1_password = new SqlParameter("@password", SqlDbType.NVarChar);
                                        p1_password.Value = password;

                                        SqlParameter p2_password = new SqlParameter("@username", SqlDbType.NVarChar);
                                        p2_password.Value = username;

                                        cmd_password.Parameters.Add(p1_password);
                                        cmd_password.Parameters.Add(p2_password);

                                        cmd_password.ExecuteNonQuery();

                                        Notification notification = new Notification("Mật khẩu đã cập nhật thành công. Hãy đăng nhập lại với mật khẩu mới.");
                                        notification.ShowDialog();
                                        clsDatabase.CloseConnection();
                                        Login login = new Login();
                                        this.Hide();
                                        login.ShowDialog();
                                        this.Close();

                                    }
                                    catch (Exception ex)
                                    {
                                        Notification notification = new Notification(ex.ToString());
                                        notification.ShowDialog();
                                        return;
                                    }
                                }
                                else
                                {
                                    Notification notification = new Notification("Thông tin bạn cung cấp không chính xác. Vui lòng kiểm tra lại");
                                    notification.ShowDialog();
                                    return;
                                }
                            }
                            else
                            {
                                Notification notification = new Notification("Thông tin bạn cung cấp không chính xác. Vui lòng kiểm tra lại");
                                notification.ShowDialog();
                                return;
                            }

                        }
                        catch (Exception ex)
                        {
                            Notification notification = new Notification("Lỗi cơ sở dữ liệu: " + ex);
                            notification.ShowDialog();
                        }
                    }
                    else if (username.Substring(0, 5).Equals("staff"))
                    {
                        string code = "SELECT * FROM STAFF_ACCOUNT WHERE SA_USERNAME=@username";

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
                                string result_cmnd = reader["SA_STAFF"].ToString();
                                string result_answer = reader["SA_ANSWER"].ToString();

                                clsDatabase.CloseConnection();

                                if (cmnd.Equals(result_cmnd) && answer.Equals(result_answer))
                                {
                                    try
                                    {
                                        clsDatabase.OpenConnection();
                                        string code_password = "UPDATE ADMIN_ACCOUNT SET SA_PASSWORD=@password WHERE SA_USERNAME=@username";

                                        SqlCommand cmd_password = new SqlCommand(code_password, clsDatabase.con);
                                        SqlDataAdapter sda_password = new SqlDataAdapter(cmd_password);

                                        SqlParameter p1_password = new SqlParameter("@password", SqlDbType.NVarChar);
                                        p1_password.Value = password;

                                        SqlParameter p2_password = new SqlParameter("@username", SqlDbType.NVarChar);
                                        p2_password.Value = username;

                                        cmd_password.Parameters.Add(p1_password);
                                        cmd_password.Parameters.Add(p2_password);

                                        cmd_password.ExecuteNonQuery();

                                        Notification notification = new Notification("Mật khẩu đã cập nhật thành công. Hãy đăng nhập lại với mật khẩu mới.");
                                        notification.ShowDialog();
                                        clsDatabase.CloseConnection();
                                        Login login = new Login();
                                        this.Hide();
                                        login.ShowDialog();
                                        this.Close();

                                    }
                                    catch
                                    {
                                        Notification notification = new Notification("Lỗi kết nối dữ liệu, cập nhật thất bại");
                                        notification.ShowDialog();
                                        return;
                                    }
                                }
                                else
                                {
                                    Notification notification = new Notification("Thông tin bạn cung cấp không chính xác. Vui lòng kiểm tra lại");
                                    notification.ShowDialog();
                                    return;
                                }
                            }
                            else
                            {
                                Notification notification = new Notification("Thông tin bạn cung cấp không chính xác. Vui lòng kiểm tra lại");
                                notification.ShowDialog();
                                return;
                            }

                        }
                        catch (Exception ex)
                        {
                            Notification notification = new Notification("Lỗi cơ sở dữ liệu: " + ex);
                            notification.ShowDialog();
                        }
                    }
                    else
                    {
                        string code = "SELECT * FROM RESIDENT_ACCOUNT WHERE RA_USERNAME=@username";

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
                                string result_cmnd = reader["RA_STAFF"].ToString();
                                string result_answer = reader["RA_ANSWER"].ToString();

                                clsDatabase.CloseConnection();

                                if (cmnd.Equals(result_cmnd) && answer.Equals(result_answer))
                                {
                                    try
                                    {
                                        clsDatabase.OpenConnection();
                                        string code_password = "UPDATE ADMIN_ACCOUNT SET RA_PASSWORD=@password WHERE RA_USERNAME=@username";

                                        SqlCommand cmd_password = new SqlCommand(code_password, clsDatabase.con);
                                        SqlDataAdapter sda_password = new SqlDataAdapter(cmd_password);

                                        SqlParameter p1_password = new SqlParameter("@password", SqlDbType.NVarChar);
                                        p1_password.Value = password;

                                        SqlParameter p2_password = new SqlParameter("@username", SqlDbType.NVarChar);
                                        p2_password.Value = username;

                                        cmd_password.Parameters.Add(p1_password);
                                        cmd_password.Parameters.Add(p2_password);

                                        cmd_password.ExecuteNonQuery();

                                        Notification notification = new Notification("Mật khẩu đã cập nhật thành công. Hãy đăng nhập lại với mật khẩu mới.");
                                        notification.ShowDialog();
                                        clsDatabase.CloseConnection();
                                        Login login = new Login();
                                        this.Hide();
                                        login.ShowDialog();
                                        this.Close();

                                    }
                                    catch
                                    {
                                        Notification notification = new Notification("Lỗi kết nối dữ liệu, cập nhật thất bại");
                                        notification.ShowDialog();
                                        return;
                                    }
                                }
                                else
                                {
                                    Notification notification = new Notification("Thông tin bạn cung cấp không chính xác. Vui lòng kiểm tra lại");
                                    notification.ShowDialog();
                                    return;
                                }
                            }
                            else
                            {
                                Notification notification = new Notification("Thông tin bạn cung cấp không chính xác. Vui lòng kiểm tra lại");
                                notification.ShowDialog();
                                return;
                            }

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
                    Notification notification = new Notification("Thông tin bạn cung cấp không chính xác. Vui lòng kiểm tra lại");
                    notification.ShowDialog();
                    return;
                }

            }
            else
            {
                Notification notification = new Notification("Bạn phải nhập đầy đủ thông tin ở các trường");
                notification.ShowDialog();
                return;
            }
            clsDatabase.CloseConnection();

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
