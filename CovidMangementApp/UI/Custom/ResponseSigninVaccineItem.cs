using System.ComponentModel;
using static System.Windows.Forms.AxHost;

namespace CovidMangementApp.UI.Custom
{
    public partial class ResponseSigninVaccineItem : UserControl
    {
        private String cmndDeclaration;
        private String indexDeclaration;
        private String dateDeclaration;
        private String timeDeclaration;
        private String stateDeclaration;
        private String targetDeclaration;
        private String dateDesireDeclaration;

        public ResponseSigninVaccineItem()
        {
            InitializeComponent();
        }

        [Category("Custom Props")]
        public String IndexDeclaration
        {
            get { return indexDeclaration; }
            set { indexDeclaration = value; lblIndex.Text = indexDeclaration; }
        }
        [Category("Custom Props")]
        public String StateDeclaration
        {
            get { return stateDeclaration; }
            set
            {
                stateDeclaration = value;
                if (value.Equals("False"))
                    this.BackgroundImage = Properties.Resources.test3;
                else
                    this.BackgroundImage = Properties.Resources.test11;
            }
        }
        [Category("Custom Props")]
        public String DateDeclaration
        {
            get { return dateDeclaration; }
            set { dateDeclaration = value; lblDate.Text = dateDeclaration; }
        }
        [Category("Custom Props")]
        public String TimeDeclaration
        {
            get { return timeDeclaration; }
            set { timeDeclaration = value; lblTime.Text = timeDeclaration; }
        }

        [Category("Custom Props")]
        public string TargetDeclaration { get => targetDeclaration; set => targetDeclaration = value; }
        [Category("Custom Props")]
        public string DateDesireDeclaration { get => dateDesireDeclaration; set => dateDesireDeclaration = value; }
        public string CmndDeclaration { get => cmndDeclaration; set => cmndDeclaration = value; }

        private void DeclarationItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.test2;
        }

        private void DeclarationItem_MouseLeave(object sender, EventArgs e)
        {

            if (stateDeclaration.Equals("False"))
            {
                this.BackgroundImage = Properties.Resources.test3;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.test11;
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblIndex_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
