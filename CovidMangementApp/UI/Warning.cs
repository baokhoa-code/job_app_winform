namespace CovidMangementApp.UI
{
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
        }

        public Warning(String s)
        {
            InitializeComponent();
            txtContent.Text = s;
        }
    }
}
