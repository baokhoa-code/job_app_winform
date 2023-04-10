using System.ComponentModel;
using static System.Windows.Forms.AxHost;

namespace CovidMangementApp.UI.Custom
{
    public partial class ReactionAfterVaccinationItem : UserControl
    {
        private String index;
        private String target;
        private String vaccineName;
        private String dateInject;
        private String dateReact;
        private String timeReact;
        private String rdbtn;
        private String state;
        private String advice;


        public ReactionAfterVaccinationItem()
        {
            InitializeComponent();
        }

        //Index
        [Category("Custom Props")]
        public String Index
        {
            get { return index; }
            set { index = value; lblIndex.Text = index; }
        }

        //Target
        [Category("Custom Props")]
        public string Target { get => target; set => target = value; }

        //Vaccine Name
        [Category("Custom Props")]
        public string VaccineName { get => vaccineName; set => vaccineName = value; }

        //Date Inject
        [Category("Custom Props")]
        public string DateInject { get => dateInject; set => dateInject = value; }

        //Date react
        [Category("Custom Props")]
        public String DateReact
        {
            get { return dateReact; }
            set { dateReact = value; lblDate.Text = dateReact; }
        }

        //Time react
        [Category("Custom Props")]
        public String TimeReact
        {
            get { return timeReact; }
            set { timeReact = value; lblTime.Text = timeReact; }
        }

        //Radio button
        [Category("Custom Props")]
        public string Rdbtn { get => rdbtn; set => rdbtn = value; }

        //State
        [Category("Custom Props")]
        public String State
        {
            get { return state; }
            set
            {
                state = value;
                if (value.Equals("False"))
                    this.BackgroundImage = Properties.Resources.test11;
                else
                    this.BackgroundImage = Properties.Resources.test3;
            }
        }
        //Advice
        [Category("Custom Props")]
        public String Advice
        {
            get { return advice; }
            set
            {
                advice = value;
            }
        }



        private void DeclarationItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.test2;
        }

        private void DeclarationItem_MouseLeave(object sender, EventArgs e)
        {

            if (state.Equals("False"))
            {
                this.BackgroundImage = Properties.Resources.test11;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.test3;
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
