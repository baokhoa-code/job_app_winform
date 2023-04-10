using CovidMangementApp.Helpers;
using CovidMangementApp.UI.Custom;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace CovidMangementApp.UI.User
{
    public partial class MedicalDeclaration : Form
    {
        public Point mouseLocation;
        private String username;
        private String residentCmnd;

        public MedicalDeclaration()
        {
            InitializeComponent();
        }

        public MedicalDeclaration(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void MedicalDeclaration_Load(object sender, EventArgs e)
        {
            BindingDeclarationList();
            GetCmnd();
        }

        private void BindingDeclarationList()
        {

            flowListDeclaration.Controls.Clear();

            string code = "SELECT MD.MD_TIME FROM MEDICAL_DECLARATION MD JOIN RESIDENT_ACCOUNT RA ON MD.MD_RESIDENT=RA.RA_RESIDENT WHERE RA.RA_USERNAME='" + username + "'";

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
                        string datetime = reader["MD_TIME"].ToString();
                        string[] vs = datetime.Split(' ');

                        DeclarationItem item = new DeclarationItem();

                        item.IndexDeclaration = i + "";
                        item.DateDeclaration = vs[0];
                        item.TimeDeclaration = vs[1];

                        flowListDeclaration.Controls.Add(item);

                        item.Click += new System.EventHandler(this.itemDeclarationClick);



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

        private void GetCmnd()
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

        private void getDeclarationInfo(DeclarationItem item)
        {
            clearContent();

            string code = "SELECT * FROM MEDICAL_DECLARATION WHERE MD_RESIDENT='" + residentCmnd + "' AND MD_TIME='" + item.DateDeclaration + " " + item.TimeDeclaration + "'";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    bool isTravel = reader.GetBoolean("MD_RDBTN_1");
                    bool isSymptom = reader.GetBoolean("MD_RDBTN_2");
                    bool isPersonInspect = reader.GetBoolean("MD_RDBTN_31");
                    bool isPersonVictim = reader.GetBoolean("MD_RDBTN_32");
                    bool isPersonSymptom = reader.GetBoolean("MD_RDBTN_33");
                    string travelDescription = reader.GetString("MD_DESCRIBE");

                    if (isTravel)
                    {
                        rdbtnContentTravelYes.Checked = true;
                        txtContentTravelDescription.Text = travelDescription;
                    }
                    else
                    {
                        rdbtnContentTravelNo.Checked = true;
                        txtContentTravelDescription.Text = "";
                    }

                    if (isSymptom)
                    {
                        rdbtnContentSymptomYes.Checked = true;
                    }
                    else
                    {
                        rdbtnContentSymptomNo.Checked = true;
                    }

                    if (isPersonInspect)
                    {
                        rdbtnContentPersonInspectYes.Checked = true;
                    }
                    else
                    {
                        rdbtnContentPersonInspectNo.Checked = true;
                    }

                    if (isPersonVictim)
                    {
                        rdbtnContentPersonVictimYes.Checked = true;
                    }
                    else
                    {
                        rdbtnContentPersonVictimNo.Checked = true;
                    }

                    if (isPersonSymptom)
                    {
                        rdbtnContentPersonSymptomYes.Checked = true;
                    }
                    else
                    {
                        rdbtnContentPersonSymptomNo.Checked = true;
                    }

                }
                else
                {
                    Debug.WriteLine(code);
                    Notification notification = new Notification("Không tìm thấy thông tin khai báo");
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

        private void itemDeclarationClick(Object obj, EventArgs e)
        {
            clearContent();
            clearDeclaration();

            DeclarationItem item = (DeclarationItem)obj;

            if (lblContent.Visible == false)
            {
                lblContent.Visible = true;
                pnlContent.Visible = true;
                lblDeclaration.Visible = false;
                pnlDeclaration.Visible = false;
            }

            getDeclarationInfo(item);
        }

        private void btnDeclaration_Click(object sender, EventArgs e)
        {
            clearContent();
            clearDeclaration();
            if (lblDeclaration.Visible == false)
            {
                lblDeclaration.Visible = true;
                pnlDeclaration.Visible = true;
                lblContent.Visible = false;
                pnlContent.Visible = false;
            }
            else
            {
                lblDeclaration.Visible = false;
                pnlDeclaration.Visible = false;
                lblContent.Visible = false;
                pnlContent.Visible = false;
            }
        }
        private void btnAddDeclaration_Click(object sender, EventArgs e)
        {
            String travelDescription = txtDeclarationTravelDescription.Texts;
            string time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            int isTravel = -1, isSymptom = -1, isPersonInspect = -1, isPersonVictim = -1, isPersonSymptom = -1;

            if (rdbtnDeclarationTravelYes.Checked == true)
            {
                isTravel = 1;
            }
            if (rdbtnDeclarationTravelNo.Checked == true)
            {
                isTravel = 0;
            }

            if (rdbtnDeclarationSymptomYes.Checked == true)
            {
                isSymptom = 1;
            }
            if (rdbtnDeclarationSymptomNo.Checked == true)
            {
                isSymptom = 0;
            }

            if (rdbtnDeclarationPersonInspectYes.Checked == true)
            {
                isPersonInspect = 1;
            }
            if (rdbtnDeclarationPersonInspectNo.Checked == true)
            {
                isPersonInspect = 0;
            }

            if (rdbtnDeclarationPersonVictimYes.Checked == true)
            {
                isPersonVictim = 1;
            }
            if (rdbtnDeclarationPersonVictimNo.Checked == true)
            {
                isPersonVictim = 0;
            }

            if (rdbtnDeclarationPersonSymptomYes.Checked == true)
            {
                isPersonSymptom = 1;
            }
            if (rdbtnDeclarationPersonSymptomNo.Checked == true)
            {
                isPersonSymptom = 0;
            }

            if (isTravel != -1 && isSymptom != -1 && isPersonInspect != -1 && isPersonVictim != -1 && isPersonSymptom != -1)
            {
                if (isTravel == 1 && travelDescription.Length == 0)
                {
                    Notification notification = new Notification("Bạn phải nhập thông tin lịch trình di chuyển");
                    notification.ShowDialog();
                }
                else
                {
                    if (isTravel == 0)
                    {
                        travelDescription = "";
                    }
                    string code = "INSERT INTO MEDICAL_DECLARATION VALUES (N'" +
                                        residentCmnd + "',N'" +
                                        time + "'," +
                                        isTravel + ",N'" +
                                        travelDescription + "'," +
                                        isSymptom + "," +
                                        isPersonInspect + "," +
                                        isPersonVictim + "," +
                                        isPersonSymptom + ")";

                    try
                    {
                        clsDatabase.OpenConnection();
                        SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();

                        Notification notification311 = new Notification("Bạn đã khai báo y tế thành công");
                        notification311.ShowDialog();
                        clsDatabase.CloseConnection();
                        BindingDeclarationList();
                        clearDeclaration();
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
            else
            {
                Notification notification = new Notification("Bạn phải nhập đầy đủ thông tin ở các trường có dấu (*)");
                notification.ShowDialog();
            }
        }
        private void clearDeclaration()
        {
            txtDeclarationTravelDescription.Texts = "";
            rdbtnDeclarationTravelYes.Checked = false;
            rdbtnDeclarationTravelNo.Checked = false;
            rdbtnDeclarationSymptomYes.Checked = false;
            rdbtnDeclarationSymptomNo.Checked = false;
            rdbtnDeclarationPersonInspectNo.Checked = false;
            rdbtnDeclarationPersonInspectYes.Checked = false;
            rdbtnDeclarationPersonVictimNo.Checked = false;
            rdbtnDeclarationPersonVictimYes.Checked = false;
            rdbtnDeclarationPersonSymptomNo.Checked = false;
            rdbtnDeclarationPersonSymptomYes.Checked = false;
        }
        private void clearContent()
        {
            txtContentTravelDescription.Text = "";
            rdbtnContentTravelYes.Checked = false;
            rdbtnContentTravelNo.Checked = false;
            rdbtnContentSymptomYes.Checked = false;
            rdbtnContentSymptomNo.Checked = false;
            rdbtnContentPersonInspectNo.Checked = false;
            rdbtnContentPersonInspectYes.Checked = false;
            rdbtnContentPersonVictimNo.Checked = false;
            rdbtnContentPersonVictimYes.Checked = false;
            rdbtnContentPersonSymptomNo.Checked = false;
            rdbtnContentPersonSymptomYes.Checked = false;
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

        private void txtContentTravelDescription_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtContentTravelDescription.Text);
        }

        private void rdbtnDeclarationPersonInspectNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDeclarationPersonInspectNo.Checked)
            {
                rdbtnDeclarationPersonInspectYes.Checked = false;
            }
        }
        private void rdbtnDeclarationPersonInspectYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDeclarationPersonInspectYes.Checked)
            {
                rdbtnDeclarationPersonInspectNo.Checked = false;
            }
        }

        private void rdbtnDeclarationPersonVictimNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDeclarationPersonVictimNo.Checked)
            {
                rdbtnDeclarationPersonVictimYes.Checked = false;
            }
        }
        private void rdbtnDeclarationPersonVictimYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDeclarationPersonVictimYes.Checked)
            {
                rdbtnDeclarationPersonVictimNo.Checked = false;
            }
        }

        private void rdbtnDeclarationPersonSymptomNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDeclarationPersonSymptomNo.Checked)
            {
                rdbtnDeclarationPersonSymptomYes.Checked = false;
            }
        }
        private void rdbtnDeclarationPersonSymptomYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDeclarationPersonSymptomYes.Checked)
            {
                rdbtnDeclarationPersonSymptomNo.Checked = false;
            }
        }

        private void rdbtnDeclarationTravelYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDeclarationTravelYes.Checked == true)
            {
                txtDeclarationTravelDescription.Text = "";
                txtDeclarationTravelDescription.Enabled = true;
            }
            else
            {
                txtDeclarationTravelDescription.Text = "";
                txtDeclarationTravelDescription.Enabled = false;
            }
        }

        private void rdbtnDeclarationTravelNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDeclarationTravelNo.Checked == true)
            {
                txtDeclarationTravelDescription.Text = "";
                txtDeclarationTravelDescription.Enabled = false;
            }
            else
            {
                txtDeclarationTravelDescription.Text = "";
                txtDeclarationTravelDescription.Enabled = true;
            }
        }
    }
}
