using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormLocations : Form
    {
        private readonly FormMain r_FormMain;

        public FormLocations(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            InitializeComponent();
        }

        private void buttonFindCities_Click(object sender, EventArgs e)
        {
            fetchCities();
        }

        private void listBoxAllCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxAllCities.SelectedItems.Count == 1)
            {
                City city = m_ListBoxAllCities.SelectedItem as City;

                IList<User> allUserInTheCity =
                    r_FormMain.ManagerLogic.GetAllUserInCity(r_FormMain.LoggedInUser.Friends, city);

                foreach (User user in allUserInTheCity)
                {
                    m_ListBoxUserInSameCity.Items.Add(user);
                }

                if (m_ListBoxUserInSameCity.Items.Count == 0)
                {
                    MessageBox.Show("No user to retrieve :(");
                }
            }
        }

        private void fetchCities()
        {
            ISet<City> allCities = r_FormMain.ManagerLogic.GetAllCities(r_FormMain.LoggedInUser.Friends);

            enterDataIntoListBox(m_ListBoxAllCities, allCities);
        }

        private void enterDataIntoListBox(ListBox i_ListBoxToAdd, ISet<City> i_AllCities)
        {
            foreach (City city in i_AllCities)
            {
                i_ListBoxToAdd.Items.Add(city);
            }

            if (i_ListBoxToAdd.Items.Count == 0)
            {
                MessageBox.Show("No city to retrieve :(");
            }
        }
    }
}
