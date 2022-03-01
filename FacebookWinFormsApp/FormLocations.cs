using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormLocations : Form
    {
        private readonly FormMain r_FormMain;
        private const string k_ErrorMessage = "This feature is not yet supported";

        public FormLocations(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            InitializeComponent();
        }

        private void buttonFindCities_Click(object sender, EventArgs e)
        {
            try
            {
                fetchCities();
            }
            catch (Exception)
            {
                MessageBox.Show(k_ErrorMessage);
            }
        }

        private void listBoxAllCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxAllCities.SelectedItems.Count == 1)
            {
                City city = m_ListBoxAllCities.SelectedItem as City;

                fetchUsers(city);
            }
        }

        private void fetchUsers(City i_CityToFind)
        {
            const string errorMessage = "No user to retrieve :(";
            ICollection<User> allUserInTheCity =
                r_FormMain.ManagerLogic.GetAllUserInCity(r_FormMain.LoggedInUser.Friends, i_CityToFind);

            r_FormMain.resetListAndPhoto(m_ListBoxUserInSameCity, m_PictureBoxProfileUser);
            r_FormMain.fetchUserData(m_ListBoxUserInSameCity, allUserInTheCity, errorMessage);
        }

        private void listBoxUserInSameCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_FormMain.updatePhotoAsUser(m_ListBoxUserInSameCity, m_PictureBoxProfileUser);
        }

        private void fetchCities()
        {
            const string errorMessage = "No city to retrieve :(";
            ICollection<City> allCities = r_FormMain.ManagerLogic.GetAllCities(r_FormMain.LoggedInUser.Friends);

            r_FormMain.resetListAndPhoto(m_ListBoxUserInSameCity, m_PictureBoxProfileUser);
            r_FormMain.fetchUserData(m_ListBoxAllCities, allCities, errorMessage);
        }

    }
}
