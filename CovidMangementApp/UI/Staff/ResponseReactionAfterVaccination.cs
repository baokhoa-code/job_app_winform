using CovidMangementApp.Helpers;
using CovidMangementApp.UI.Custom;
using CovidMangementApp.UI.Staff;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CovidMangementApp.UI.Staff
{
    public partial class ResponseReactionAfterVaccination : Form
    {
        public Point mouseLocation;
        private String username;
        private int reactOrder;

        public ResponseReactionAfterVaccination()
        {
            InitializeComponent();
        }

        public ResponseReactionAfterVaccination(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void ResponseReactionAfterVaccination_Load(object sender, EventArgs e)
        {
            BindingRegistList();
        }
        private void BindingRegistList()
        {
            flowListRegist.Controls.Clear();

            string code = "SELECT REACT.R_ORDER, REACT.R_STATE, REACT.R_DATEREACT, REACT.R_TIMEREACT, REACT.R_DATEVACCINE, REACT.R_RDBTN, REACT.R_ADVICE, RESI.RESIDENT_NAME, VAC.VACCINE_NAME FROM REACTION REACT JOIN RESIDENT_ACCOUNT RA ON REACT.R_RESIDENT=RA.RA_RESIDENT JOIN RESIDENT RESI ON REACT.R_RESIDENT = RESI.RESIDENT_ID JOIN VACCINE VAC ON VAC.VACCINE_ID = REACT.R_VACCINE WHERE REACT.R_STATE='0'";

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

                        ResponseReactionAfterVaccinationItem item = new ResponseReactionAfterVaccinationItem();

                        item.Index = i + "";
                        item.Order = Int32.Parse(reader["R_ORDER"].ToString());
                        item.Target = reader["RESIDENT_NAME"].ToString();
                        item.VaccineName = reader["VACCINE_NAME"].ToString();
                        item.DateInject = reader["R_DATEVACCINE"].ToString();
                        item.DateReact = reader["R_DATEREACT"].ToString();
                        item.TimeReact = reader["R_TIMEREACT"].ToString();
                        item.Rdbtn = reader["R_RDBTN"].ToString();
                        item.State = reader["R_STATE"].ToString();
                        item.Advice = reader["R_ADVICE"].ToString();

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
            ResponseReactionAfterVaccinationItem item = (ResponseReactionAfterVaccinationItem)obj;

            if (lblDetail.Visible == false)
            {
                lblDetail.Visible = true;
                pnlDetail.Visible = true;
            }
            lblDetail.Text = "CHI TIẾT PHIÊU KHẢO SÁT SỐ " + item.Index;
            txtDetailAdvice.Text = item.Advice;
            txtDetailInjectionDate.Texts = item.DateInject;
            txtDetailReactionDate.Texts = item.DateReact;
            txtDetailReactionTime.Texts = item.TimeReact;
            txtDetailTarget.Texts = item.Target;
            txtDetailVaccineName.Texts = item.VaccineName;
            reactOrder = item.Order;
            if (item.Rdbtn.Equals("0"))
                rdDetailNo.Checked = true;
            else
                rdDetailYes.Checked = true;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String advice = txtDetailAdvice.Text;

            if (advice == null || advice.Length == 0)
            {
                Notification notification = new Notification("Hãy nhập lời khuyên từ chuyên gia");
                notification.ShowDialog();
            }
            else
            {
                string code = "UPDATE REACTION SET R_STATE='1', R_ADVICE=N'" + advice + "' WHERE R_ORDER=" + reactOrder + "";

                try
                {
                    clsDatabase.OpenConnection();
                    SqlCommand cmd2 = new SqlCommand(code, clsDatabase.con);
                    SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                    cmd2.ExecuteNonQuery();

                    string result = "Bạn đã phản hồi thành công";

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
        }
    }
}
