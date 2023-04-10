using CovidMangementApp.Helpers;
using CovidMangementApp.UI.Custom;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CovidMangementApp.UI.User
{
    public partial class ReactionAfterVaccination : Form
    {
        public Point mouseLocation;
        private String username;
        private String residentCmnd;
        private List<VaccineWithInjection> vaccines;

        public ReactionAfterVaccination()
        {
            InitializeComponent();
        }

        public ReactionAfterVaccination(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void ReactionAfterVaccination_Load(object sender, EventArgs e)
        {
            BindingRegistList();
            getInfo();
            BindingVaccine();
        }
        private void BindingVaccine()
        {
            vaccines = new List<VaccineWithInjection>();

            string code = "SELECT VH.VH_INJECTION, V.VACCINE_NAME, V.VACCINE_ID, VH.VH_DATE FROM VACCINATION_HISTORY VH JOIN VACCINE V ON VH.VH_VACCINE=V.VACCINE_ID JOIN RESIDENT_ACCOUNT RA ON VH.VH_RESIDENT=RA.RA_RESIDENT WHERE RA.RA_USERNAME='" + username + "'";

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
                        string id = reader["VACCINE_ID"].ToString();
                        string name = reader["VACCINE_NAME"].ToString();
                        string injection = reader["VH_INJECTION"].ToString();
                        string vaccineDate = reader["VH_DATE"].ToString();

                        vaccines.Add(new VaccineWithInjection(injection, name, id, vaccineDate));
                    }

                    cbxRegistVaccineName.DataSource = vaccines;
                    cbxRegistVaccineName.DisplayMember = "VaccineName";
                    cbxRegistVaccineName.ValueMember = "VaccineCode";

                }
                else
                {
                    Notification notification = new Notification("Bạn chưa được tiêm vắc xin nào");
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
            string code = "SELECT R.RESIDENT_NAME, R.RESIDENT_ID FROM RESIDENT R JOIN RESIDENT_ACCOUNT RA ON R.RESIDENT_ID = RA.RA_RESIDENT WHERE RA.RA_USERNAME = '" + username + "'";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    txtRegistTarget.Text = reader.GetString(0);
                    residentCmnd = reader.GetString(1);

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

            string code = "SELECT REACT.R_STATE, REACT.R_DATEREACT, REACT.R_TIMEREACT, REACT.R_DATEVACCINE, REACT.R_RDBTN, REACT.R_ADVICE, RESI.RESIDENT_NAME, VAC.VACCINE_NAME FROM REACTION REACT JOIN RESIDENT_ACCOUNT RA ON REACT.R_RESIDENT=RA.RA_RESIDENT JOIN RESIDENT RESI ON REACT.R_RESIDENT = RESI.RESIDENT_ID JOIN VACCINE VAC ON VAC.VACCINE_ID = REACT.R_VACCINE WHERE RA.RA_USERNAME ='" + username + "'";

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


                        ReactionAfterVaccinationItem item = new ReactionAfterVaccinationItem();

                        item.Index = i + "";
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
        private void btnAddRegist_Click(object sender, EventArgs e)
        {
            String datevaccine = txtRegistInjectionDate.Text;
            String datereact = dpkRegistReactionDate.Text;
            String timereact = dpkRegistReactionTime.Text;
            String isHaveSymptom = "";

            if (rdbtnRegistNo.Checked) { isHaveSymptom = "0"; }
            if (rdbtnRegistYes.Checked) { isHaveSymptom = "1"; }

            if (isHaveSymptom.Equals("") || cbxRegistVaccineName.SelectedValue == null || datevaccine == null || datereact == null || timereact == null || datereact.Length == 0 || datereact.Length == 0 || timereact.Length == 0)
            {
                Notification notification = new Notification("Bạn phải nhập đầy đủ thông tin ở các trường có dấu (*)");
                notification.ShowDialog();
            }
            else
            {
                String codevaccine = cbxRegistVaccineName.SelectedValue.ToString();

                string code = "INSERT INTO REACTION(R_RESIDENT, R_VACCINE, R_DATEVACCINE, R_DATEREACT, R_TIMEREACT, R_RDBTN, R_STATE, R_ADVICE) VALUES(N'" +
                                        residentCmnd + "',N'" +
                                        codevaccine + "',N'" +
                                        datevaccine + "',N'" +
                                        datereact + "',N'" +
                                        timereact + "',N'" +
                                        isHaveSymptom + "',0,'')";

                try
                {
                    clsDatabase.OpenConnection();
                    SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();

                    Notification notification311 = new Notification("Bạn đã gửi phiếu khảo sát thành công");
                    notification311.ShowDialog();
                    clsDatabase.CloseConnection();
                    BindingRegistList();
                    clearRegist();
                    return;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(code);
                    Notification notification31 = new Notification(ex.ToString());
                    notification31.ShowDialog();
                    clsDatabase.CloseConnection();
                    return;
                }
            }
        }
        private void itemRegistDetailClick(Object obj, EventArgs e)
        {
            clearRegist();

            ReactionAfterVaccinationItem item = (ReactionAfterVaccinationItem)obj;

            if (lblDetail.Visible == false)
            {
                lblDetail.Visible = true;
                pnlDetail.Visible = true;
                lblRegist.Visible = false;
                pnlRegist.Visible = false;
            }
            lblDetail.Text = "CHI TIẾT PHIÊU KHẢO SÁT SỐ " + item.Index;
            txtDetailAdvice.Text = item.Advice;
            txtDetailInjectionDate.Texts = item.DateInject;
            txtDetailReactionDate.Texts = item.DateReact;
            txtDetailReactionTime.Texts = item.TimeReact;
            txtDetailTarget.Texts = item.Target;
            txtDetailVaccineName.Texts = item.VaccineName;
            if (item.Rdbtn.Equals("0"))
                rdDetailNo.Checked = true;
            else
                rdDetailYes.Checked = true;
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
            cbxRegistVaccineName.SelectedIndex = -1;
            rdbtnRegistNo.Checked = false;
            rdbtnRegistYes.Checked = false;

        }
        private void cbxRegistVaccineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRegistVaccineName.SelectedIndex >= 0)
            {
                VaccineWithInjection selectedVaccine = (VaccineWithInjection)cbxRegistVaccineName.SelectedItem;
                string vaccineName = selectedVaccine.VaccineName;
                string vaccineCode = selectedVaccine.VaccineCode;
                string vaccineDate = selectedVaccine.VaccineDate;
                txtRegistInjectionDate.Text = vaccineDate;
            }
            else
            {
                txtRegistInjectionDate.Text = "";
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
