using CovidMangementApp.Helpers;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CovidMangementApp.UI.Staff
{
    public partial class PatientAnamnesis : Form
    {
        private String username;
        public Point mouseLocation;
        private DataTable originalDataTable;

        public PatientAnamnesis()
        {
            InitializeComponent();
        }

        public PatientAnamnesis(String username)
        {
            InitializeComponent();
            this.username = username;

        }
        private void BindingAnamnesisList()
        {
            gridView.DataSource = null;
            gridView.Columns.Clear();

            string code = "SELECT * FROM ANAMESIS A JOIN RESIDENT R ON A.A_RESIDENT = R.RESIDENT_ID";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();



                if (reader.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Số chứng minh", typeof(string));
                    table.Columns.Add("Họ và tên", typeof(string));
                    table.Columns.Add("Số điện thoại", typeof(string));
                    table.Columns.Add("Địa chỉ Email", typeof(string));

                    while (reader.Read())
                    {
                        table.Rows.Add(
                            reader["RESIDENT_ID"].ToString(),
                            reader["RESIDENT_NAME"].ToString(),
                            reader["RESIDENT_PHONE"].ToString(),
                            reader["RESIDENT_EMAIL"].ToString());
                    }

                    originalDataTable = table;
                    gridView.DataSource = table;


                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                    editButtonColumn.Name = "Chi tiết";
                    editButtonColumn.Text = "Chi tiết";
                    editButtonColumn.UseColumnTextForButtonValue = true;
                    gridView.Columns.Add(editButtonColumn);

                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                    deleteButtonColumn.Name = "Xóa";
                    deleteButtonColumn.Text = "Xóa";
                    deleteButtonColumn.UseColumnTextForButtonValue = true;
                    gridView.Columns.Add(deleteButtonColumn);

                    gridView.Columns["Chi tiết"].Width = 50;
                    gridView.Columns["Xóa"].Width = 50;
                    gridView.Columns["Số điện thoại"].Width = 100;
                    gridView.Columns["Số chứng minh"].Width = 150;

                }
                else
                {
                    Notification notification = new Notification("Danh sách hồ sơ trống");
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
        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == gridView.Columns["Chi tiết"].Index)
                {
                    DataGridViewRow selectedRow = gridView.Rows[e.RowIndex];
                    string cmnd = selectedRow.Cells["Số chứng minh"].Value.ToString();

                    openInfoForm(cmnd);

                }
                if (e.ColumnIndex == gridView.Columns["Xóa"].Index)
                {
                    DataGridViewRow selectedRow = gridView.Rows[e.RowIndex];
                    string cmnd = selectedRow.Cells["Số chứng minh"].Value.ToString();
                    string redidentName = selectedRow.Cells["Họ và tên"].Value.ToString();

                    DialogResult result = MessageBox.Show("Bạn có muốn xóa hồ sơ của " + redidentName + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string code2 = "DELETE FROM ANAMESIS WHERE A_RESIDENT = '" + cmnd + "'";

                        try
                        {
                            clsDatabase.OpenConnection();
                            SqlCommand cmd2 = new SqlCommand(code2, clsDatabase.con);
                            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);

                            cmd2.ExecuteNonQuery();

                            clsDatabase.CloseConnection();

                            Notification notification3 = new Notification("Đã xóa hồ sơ thành công");
                            notification3.ShowDialog();
                            clsDatabase.CloseConnection();
                            BindingAnamnesisList();
                            return;

                        }
                        catch (Exception ex)
                        {
                            Notification notification = new Notification("Lỗi cơ sở dữ liệu: " + ex);
                            notification.ShowDialog();
                        }
                    }
                }
            }
        }

        private void openInfoForm(String cmnd)
        {
            coverPanel.Visible = true;

            string code = "SELECT * FROM ANAMESIS A JOIN RESIDENT R ON A.A_RESIDENT = R.RESIDENT_ID WHERE R.RESIDENT_ID ='" + cmnd + "'";

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(code, clsDatabase.con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    string rname = reader["RESIDENT_NAME"].ToString();
                    string rsex = reader["RESIDENT_SEX"].ToString();
                    string rdob = reader["RESIDENT_DOB"].ToString();
                    string bloodsugar = reader["A_BLOODSUGAR"].ToString();
                    string spo2s = reader["A_SP02"].ToString();
                    string bloodpressure = reader["A_BLOODPRESSURE"].ToString();
                    string heartbeat = reader["A_HEARTBEAT"].ToString();
                    string temperatures = reader["A_TEMPERATURE"].ToString();
                    string heights = reader["A_HEIGHT"].ToString();
                    string weights = reader["A_WEIGHT"].ToString();
                    string bmis = reader["A_BMI"].ToString();
                    string bloodgroup = reader["A_BLOODGROUP"].ToString();
                    string allergys = reader["A_ALLERGY"].ToString();
                    string sicks = reader["A_SICK"].ToString();
                    string surgerys = reader["A_SURGERY"].ToString();

                    bloodSugar.PlaceHolderTexBox = "";
                    spo2.PlaceHolderTexBox = "";
                    bloodPressure.PlaceHolderTexBox = "";
                    heartRate.PlaceHolderTexBox = "";
                    temperature.PlaceHolderTexBox = "";
                    height.PlaceHolderTexBox = "";
                    weight.PlaceHolderTexBox = "";
                    bmi.PlaceHolderTexBox = "";
                    bloodType.PlaceHolderTexBox = "";
                    allergy.PlaceHolderTexBox = "";
                    sick.PlaceHolderTexBox = "";
                    surgery.PlaceHolderTexBox = "";

                    txtName.Text = rname;
                    txtDob.Text = rdob;
                    if (rsex.Equals("1"))
                    {
                        txtGender.Text = "Nam";
                    }
                    if (rsex.Equals("2"))
                    {
                        txtGender.Text = "Nữ";
                    }
                    if (rsex.Equals("3"))
                    {
                        txtGender.Text = "Khác";
                    }
                    bloodSugar.ItemValueTextBox = bloodsugar;
                    spo2.ItemValueTextBox = spo2s;
                    bloodPressure.ItemValueTextBox = bloodpressure;
                    heartRate.ItemValueTextBox = heartbeat;
                    temperature.ItemValueTextBox = temperatures;
                    height.ItemValueTextBox = heights;
                    weight.ItemValueTextBox = weights;
                    bmi.ItemValueTextBox = bmis;
                    bloodType.ItemValueTextBox = bloodgroup;
                    allergy.ItemValueTextBox = allergys;
                    sick.ItemValueTextBox = sicks;
                    surgery.ItemValueTextBox = surgerys;

                }
                clsDatabase.CloseConnection();

            }
            catch (Exception ex)
            {
                Notification notification = new Notification("Lỗi cơ sở dữ liệu: " + ex);
                notification.ShowDialog();
            }

        }
        private void coverPanel_Click(object sender, EventArgs e)
        {
            coverPanel.Visible = false;
            ClearInfoForm();
            BindingAnamnesisList();

        }
        private void ClearInfoForm()
        {

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String keyword = txtSearch.Text.Trim();

            string filter = $"[Số chứng minh] LIKE '%{keyword}%' OR [Họ và tên] LIKE '%{keyword}%' OR [Địa chỉ Email] LIKE '%{keyword}%'";
            originalDataTable.DefaultView.RowFilter = filter;
            gridView.DataSource = originalDataTable.DefaultView.ToTable();


        }

        private void PatientAnamnesis_Load(object sender, EventArgs e)
        {
            BindingAnamnesisList();
        }
    }
}
