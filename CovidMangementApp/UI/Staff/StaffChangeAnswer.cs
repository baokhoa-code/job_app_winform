using CovidMangementApp.Helpers;
using System.Data.SqlClient;

namespace CovidMangementApp.UI.Staff
{
    public partial class StaffChangeAnswer : Form
    {
        public Point mouseLocation;
        private String username;
        public StaffChangeAnswer()
        {
            InitializeComponent();
        }
        public StaffChangeAnswer(String username)
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
            StaffHomePage staffHomePage = new StaffHomePage(username);
            this.Hide();
            staffHomePage.ShowDialog();
            this.Close();
        }

        private void btnUpdateAnswer_Click(object sender, EventArgs e)
        {
            string oldanswer = txtOldAnswer.Text;
            string newanswer = txtNewAnswer.Text;
            string againanswer = txtReNewAnswer.Text;

            if (oldanswer.Length == 0 || newanswer.Length == 0 || againanswer.Length == 0)
            {
                Notification notification = new Notification("Bạn phải nhập đầy đủ thông tin ở các trường có dấu (*)");
                notification.ShowDialog();
                return;
            }
            else
            {
                if (newanswer.Equals(againanswer))
                {
                    string code = "SELECT SA_ANSWER FROM STAFF_ACCOUNT WHERE SA_USERNAME=N'" + username + "'";


                    try
                    {
                        clsDatabase.OpenConnection();
                        SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();

                            string r_answer = reader["SA_ANSWER"].ToString();

                            clsDatabase.CloseConnection();

                            if (r_answer.Equals(oldanswer))
                            {
                                string query = "UPDATE STAFF_ACCOUNT SET SA_ANSWER=N'" + newanswer + "' WHERE SA_USERNAME=N'" + username + "'";

                                try
                                {
                                    clsDatabase.OpenConnection();

                                    SqlCommand cmd1 = new SqlCommand(query, clsDatabase.con);
                                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);

                                    cmd1.ExecuteNonQuery();

                                    Notification notification22 = new Notification("Bạn đã thay đổi câu trả lời đặc biệt thành công");
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
                                Notification notification23 = new Notification("Thông tin bạn cung cấp không chính xác");
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
                    Notification notification = new Notification("Câu trả lời mới không khớp");
                    notification.ShowDialog();
                    return;
                }
            }
        }
    }
}
