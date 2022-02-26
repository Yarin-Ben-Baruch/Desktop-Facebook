using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMostLikesFromFriends : Form
    {
        private readonly FormMain r_FormMain;

        public FormMostLikesFromFriends(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            InitializeComponent();
        }

        private void labelMostLikesOnPhotos_Click(object sender, EventArgs e)
        {
            fetchPhotos();
        }

        private void listBoxMostLikesPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxMostLikesPhotos.SelectedItems.Count == 1)
            {
                User selectedUser = m_ListBoxMostLikesPhotos.SelectedItem as User;

                m_PictureBoxSelectedFriendPhoto.LoadAsync(selectedUser.PictureNormalURL);
            }
        }

        private void labelMostLikesOnPosts_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            LinkedList<User> usersToShow = r_FormMain.ManagerLogic.GetMostLikesOnPostByUsers(r_FormMain.LoggedInUser.Posts);

            m_ListBoxMostLikesPosts.Items.Clear();

            foreach (User user in usersToShow)
            {
                m_ListBoxMostLikesPosts.Items.Add(user);
            }

            if (m_ListBoxMostLikesPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void fetchPhotos()
        {
            List<User> listOfFriends = r_FormMain.LoggedInUser.Friends.ToList();

            m_ListBoxMostLikesPhotos.Items.Clear();
            m_ListBoxMostLikesPhotos.DisplayMember = "Name";
            // For self Checking adding myself to the list to see if i show on the ListBox.
            listOfFriends.Add(r_FormMain.LoggedInUser);

            LinkedList<User> usersToShow = r_FormMain.ManagerLogic.GetMostLikesOnPhotosByUsers(r_FormMain.LoggedInUser.Albums, listOfFriends);

            foreach (User user in usersToShow)
            {
                m_ListBoxMostLikesPhotos.Items.Add(user);
            }

            if (m_ListBoxMostLikesPhotos.Items.Count == 0)
            {
                MessageBox.Show("No Photo to retrieve :(");
            }
        }
    }
}
