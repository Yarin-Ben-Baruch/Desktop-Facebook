using System;
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
    public partial class FormChooseName : Form
    {
        private readonly FormMain r_FormMain;

        public FormChooseName(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            InitializeComponent();
        }


        private void m_ButtonShowFriends_Click(object sender, EventArgs e)
        {
            const string errorMessage = "No Friends to retrieve :(";

            fetchUserData(m_ListBoxFriends, r_FormMain.LoggedInUser.Friends, errorMessage);
        }

        private void m_ButtonAlbums_Click(object sender, EventArgs e)
        {
            const string errorMessage = "No Albums to retrieve :(";

            fetchUserData(m_ListBoxAlbums, r_FormMain.LoggedInUser.Albums, errorMessage);
        }

        private void m_ButtonLikedPages_Click(object sender, EventArgs e)
        {
            const string errorMessage = "No Liked Pages to retrieve :(";

            fetchUserData(m_ListBoxLikedPages, r_FormMain.LoggedInUser.LikedPages, errorMessage);
        }

        private void m_ButtonEvents_Click(object sender, EventArgs e)
        {
            const string errorMessage = "No Events to retrieve :(";

            fetchUserData(m_ListBoxEvents, r_FormMain.LoggedInUser.Events, errorMessage);
        }

        // WE HAVE THIS METHOD TWICE !!!
        private void fetchUserData<T>(ListBox i_ListBoxToFill,
            FacebookObjectCollection<T> i_Collection, string i_ErrorMessage)
        {
            i_ListBoxToFill.Items.Clear();
            i_ListBoxToFill.DisplayMember = "Name";

            foreach (T itemToAdd in i_Collection)
            {
                i_ListBoxToFill.Items.Add(itemToAdd);
            }

            if (i_ListBoxToFill.Items.Count == 0)
            {
                MessageBox.Show(i_ErrorMessage);
            }
        }

        private void m_ListBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = m_ListBoxFriends.SelectedItem as User;
                m_PictureBoxFriends.LoadAsync(selectedFriend.PictureNormalURL);
            }
            else
            {
                m_PictureBoxFriends.Image = m_PictureBoxFriends.ErrorImage;
            }
        }

        private void m_ListBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxLikedPages.SelectedItems.Count == 1)
            {
                Page selectedPage = m_ListBoxLikedPages.SelectedItem as Page;
                m_PictureBoxLikedPages.LoadAsync(selectedPage.PictureNormalURL);
            }
            else
            {
                m_PictureBoxLikedPages.Image = m_PictureBoxLikedPages.ErrorImage;
            }
        }

        private void m_ListBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = m_ListBoxEvents.SelectedItem as Event;
                m_PictureBoxEvents.LoadAsync(selectedEvent.Cover.SourceURL);
            }
            else
            {
                m_PictureBoxEvents.Image = m_PictureBoxLikedPages.ErrorImage;
            }
        }

        private void m_ListBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = m_ListBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    m_PictureBoxAlbums.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    m_PictureBoxAlbums.Image = m_PictureBoxAlbums.ErrorImage;
                }
            }
        }
    }
}