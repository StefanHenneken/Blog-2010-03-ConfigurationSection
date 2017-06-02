using System;
using System.Configuration;
using System.Windows.Forms;

namespace MySection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ReadSection_OnClick(object sender, EventArgs e)
        {
            MyConfigurationSection myConfigurationSection = (MyConfigurationSection)ConfigurationManager.GetSection("mySection");
            listViewSection.Items.Clear();
            foreach (SectionValue sectionValue in myConfigurationSection.SectionValues)
            {
                ListViewItem listItem = new ListViewItem(sectionValue.Id.ToString());
                listItem.SubItems.Add(sectionValue.Attribute);
                listItem.SubItems.Add(sectionValue.OldValue.ToString());
                listItem.SubItems.Add(sectionValue.NewValue.ToString());
                listViewSection.Items.Add(listItem);
            }
        }
    }
}



