using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidMangementApp.UI.Custom
{
    public partial class AnamnesisItem2 : UserControl
    {
        private String itemNameInfo;
        private String itemUnitInfo;
        private String itemValueTextBox;
        private Image itemImageInfo;
        public AnamnesisItem2()
        {
            InitializeComponent();
        }

        [Category("Custom Props")]
        public String ItemNameInfo
        {
            get { return itemNameInfo; }
            set { itemNameInfo = value; infoName.Text = value; }
        }

        [Category("Custom Props")]
        public String ItemValueTextBox
        {
            get { return itemValueTextBox; }
            set { itemValueTextBox = value; infoValue.Text = value; }
        }

        [Category("Custom Props")]
        public bool EnabledTexBox
        {
            get { return infoValue.Enabled; }
            set { infoValue.Enabled = value; }
        }

        [Category("Custom Props")]
        public String PlaceHolderTexBox
        {
            get { return infoValue.PlaceholderText; }
            set { infoValue.PlaceholderText = value; }
        }
        private void infoValue__TextChanged(object sender, EventArgs e)
        {
            if (infoValue.Text != null)
            {
                itemValueTextBox = infoValue.Text;
            }
        }
    }
}
