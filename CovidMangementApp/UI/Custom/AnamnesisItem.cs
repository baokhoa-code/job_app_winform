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
    public partial class AnamnesisItem : UserControl
    {
        private String itemNameInfo;
        private String itemUnitInfo;
        private String itemValueTextBox;
        private Image itemImageInfo;
        public AnamnesisItem()
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
        public String ItemUnitInfo
        {
            get { return itemUnitInfo; }
            set { itemUnitInfo = value; infoUnit.Text = value; }
        }


        [Category("Custom Props")]
        public String ItemValueTextBox
        {
            get { return itemValueTextBox; }
            set { itemValueTextBox = value; infoValue.Text = value; }
        }


        [Category("Custom Props")]
        public Image ItemImageInfo
        {
            get { return itemImageInfo; }
            set { itemImageInfo = value; infoImage.Image = value; }
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
