using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormAccountInfo : Form
    {
        private readonly FormMain r_FormMain;

        public FormAccountInfo(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            InitializeComponent();
        }

        private void buttonShowFriends_Click(object sender, EventArgs e)
        {
            try
            {
                const string errorMessage = "No Friends to retrieve :(";

                r_FormMain.ResetListAndPhoto(m_ListBoxFriends, m_PictureBoxFriends);
                r_FormMain.FetchUserData(m_ListBoxFriends, r_FormMain.LoggedInUser.Friends, errorMessage);
            }
            catch (Exception)
            {
                MessageBox.Show(r_FormMain.ErrorMessageSupported, r_FormMain.TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            try
            {
                const string errorMessage = "No Albums to retrieve :(";

                r_FormMain.ResetListAndPhoto(m_ListBoxAlbums, m_PictureBoxAlbums);
                r_FormMain.FetchUserData(m_ListBoxAlbums, r_FormMain.LoggedInUser.Albums, errorMessage);
            }
            catch (Exception)
            {
                MessageBox.Show(r_FormMain.ErrorMessageSupported, r_FormMain.TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            try
            {
                const string errorMessage = "No Liked Pages to retrieve :(";

                r_FormMain.ResetListAndPhoto(m_ListBoxLikedPages, m_PictureBoxLikedPages);
                r_FormMain.FetchUserData(m_ListBoxLikedPages, r_FormMain.LoggedInUser.LikedPages, errorMessage);
            }
            catch (Exception)
            {
                MessageBox.Show(r_FormMain.ErrorMessageSupported, r_FormMain.TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            try
            {
                const string errorMessage = "No Events to retrieve :(";

                r_FormMain.ResetListAndPhoto(m_ListBoxEvents, m_PictureBoxEvents);
                r_FormMain.FetchUserData(m_ListBoxEvents, r_FormMain.LoggedInUser.Events, errorMessage);
            }
            catch (Exception)
            {
                MessageBox.Show(r_FormMain.ErrorMessageSupported, r_FormMain.TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_FormMain.UpdatePhotoAsUser(m_ListBoxFriends, m_PictureBoxFriends);
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_FormMain.UpdatePhotoAsPage(m_ListBoxLikedPages, m_PictureBoxLikedPages);
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_FormMain.UpdatePhotoAsEvent(m_ListBoxEvents, m_PictureBoxEvents);
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_FormMain.UpdatePhotoAsAlbum(m_ListBoxAlbums, m_PictureBoxAlbums);
        }
    }
}