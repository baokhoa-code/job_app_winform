namespace CovidMangementApp.UI
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }

        public Notification(String s)
        {
            InitializeComponent();
            txtContent.Text = s;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
