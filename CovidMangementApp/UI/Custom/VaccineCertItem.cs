using System.ComponentModel;

namespace CovidMangementApp.UI.Custom
{
    public partial class VaccineCertItem : UserControl
    {
        private String vaccineIndex;
        private String vaccineDate;
        private String vaccineName;
        private String vaccineFacility;
        private String vaccineInjection;

        public VaccineCertItem()
        {
            InitializeComponent();
        }

        [Category("Custom Props")]
        public String VaccineIndex
        {
            get { return vaccineIndex; }
            set { vaccineIndex = value; indexVaccine.Text = vaccineIndex; }
        }
        [Category("Custom Props")]
        public String VaccineDate
        {
            get { return vaccineDate; }
            set { vaccineDate = value; dateVaccine.Text = vaccineDate; }
        }
        [Category("Custom Props")]
        public String VaccineName
        {
            get { return vaccineName; }
            set { vaccineName = value; nameVaccine.Text = "Tên: " + vaccineName; }
        }
        [Category("Custom Props")]
        public String VaccineFacility
        {
            get { return vaccineFacility; }
            set { vaccineFacility = value; facilityVaccine.Text = "Nơi tiêm: " + vaccineFacility; }
        }
        [Category("Custom Props")]
        public String VaccineInjection
        {
            get { return vaccineInjection; }
            set { vaccineInjection = value; injectionVaccine.Text = "Mũi số: " + vaccineInjection; }
        }

    }
}
