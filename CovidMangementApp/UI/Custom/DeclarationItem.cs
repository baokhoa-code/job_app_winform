using System.ComponentModel;

namespace CovidMangementApp.UI.Custom
{
    public partial class DeclarationItem : UserControl
    {
        private String indexDeclaration;
        private String dateDeclaration;
        private String timeDeclaration;

        public DeclarationItem()
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

        private void DeclarationItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.test2;
        }

        private void DeclarationItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.test11;
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
