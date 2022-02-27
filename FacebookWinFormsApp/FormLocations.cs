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

                fetchUsers(city);
            }
        }

        private void fetchCities()
        {
            ISet<City> allCities = r_FormMain.ManagerLogic.GetAllCities(r_FormMain.LoggedInUser.Friends);

            enterDataIntoListBox(m_ListBoxAllCities, allCities);
        }

        private void enterDataIntoListBox(ListBox i_ListBoxToAdd, ISet<City> i_AllCities)
        {
            i_ListBoxToAdd.Items.Clear();
            i_ListBoxToAdd.DisplayMember = "Name";

            foreach (City city in i_AllCities)
            {
                i_ListBoxToAdd.Items.Add(city);
            }

            if (i_ListBoxToAdd.Items.Count == 0)
            {
                MessageBox.Show("No city to retrieve :(");
            }
        }

        private void fetchUsers(City i_CityToFind)
        {
            IList<User> allUserInTheCity =
                r_FormMain.ManagerLogic.GetAllUserInCity(r_FormMain.LoggedInUser.Friends, i_CityToFind);

            m_ListBoxUserInSameCity.Items.Clear();
            m_ListBoxUserInSameCity.DisplayMember = "Name";

            foreach (User user in allUserInTheCity)
            {
                m_ListBoxUserInSameCity.Items.Add(user);
            }

            if (m_ListBoxUserInSameCity.Items.Count == 0)
            {
                MessageBox.Show("No user to retrieve :(");
            }
        }

        private void m_ListBoxUserInSameCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxAllCities.SelectedItems.Count == 1)
            {
                User selectedUser = m_ListBoxUserInSameCity.SelectedItem as User;

                m_PictureBoxProfileUser.LoadAsync(selectedUser.PictureNormalURL);
            }
        }
    }
}
