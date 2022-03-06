using System;
using System.Collections.Generic;
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
            try
            {
                fetchCities();
            }
            catch (Exception)
            {
                MessageBox.Show(r_FormMain.ErrorMessageSupported, r_FormMain.TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxAllCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxAllCities.SelectedItems.Count == 1)
            {
                City city = m_ListBoxAllCities.SelectedItem as City;

                fetchUsersByCity(city);
            }
        }

        private void fetchUsersByCity(City i_CityToFind)
        {
            const string errorMessage = "No user to retrieve :(";
            ICollection<User> allUserInTheCity =
                r_FormMain.ManagerLogic.GetAllUserInCity(r_FormMain.LoggedInUser.Friends, i_CityToFind);

            r_FormMain.ResetListAndPhoto(m_ListBoxUserInSameCity, m_PictureBoxProfileUser);
            r_FormMain.FetchUserData(m_ListBoxUserInSameCity, allUserInTheCity, errorMessage);
        }

        private void listBoxUserInSameCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_FormMain.UpdatePhotoAsUser(m_ListBoxUserInSameCity, m_PictureBoxProfileUser);
        }

        private void fetchCities()
        {
            const string errorMessage = "No city to retrieve :(";
            ICollection<City> allCities = r_FormMain.ManagerLogic.GetAllCities(r_FormMain.LoggedInUser.Friends);

            r_FormMain.ResetListAndPhoto(m_ListBoxUserInSameCity, m_PictureBoxProfileUser);
            r_FormMain.FetchUserData(m_ListBoxAllCities, allCities, errorMessage);
        }
    }
}
