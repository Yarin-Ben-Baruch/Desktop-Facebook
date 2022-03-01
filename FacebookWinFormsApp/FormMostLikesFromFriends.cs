using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMostLikesFromFriends : Form
    {
        private readonly FormMain r_FormMain;
        private const string k_ErrorMessage = "This feature is not yet supported";

        public FormMostLikesFromFriends(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            InitializeComponent();
        }

        private void buttonMostLikesOnPhotos_Click(object sender, EventArgs e)
        {
            try
            {
                fetchUserPhotos();
            }
            catch (Exception)
            {
                MessageBox.Show(k_ErrorMessage);
            }
        }

        private void buttonMostComments_Click(object sender, EventArgs e)
        {
            try
            {
                fetchUserComments();
            }
            catch (Exception)
            {
                MessageBox.Show(k_ErrorMessage);
            }
        }

        private void m_ButtonMostLikesOnPosts_Click(object sender, EventArgs e)
        {
            try
            {
                fetchUserPosts();
            }
            catch (Exception)
            {
                MessageBox.Show(k_ErrorMessage);
            }
        }

        private void listBoxMostLikesPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_FormMain.updatePhotoAsUser(m_ListBoxMostLikesPhotos, m_PictureBoxSelectedFriendPhoto, k_ErrorMessage);
        }

        private void listBoxMostLikesPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_FormMain.updatePhotoAsUser(m_ListBoxMostLikesPosts, m_PictureBoxSelectedFriendPost, k_ErrorMessage);
        }

        private void listBoxMostComments_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_FormMain.updatePhotoAsUser(m_ListBoxMostComments, m_PictureBoxSelectedFriendComment, k_ErrorMessage);
        }

        private void fetchUserPhotos()
        {
            const string errorMessage = "No User to retrieve :(";
            ICollection<User> listOfFriends = r_FormMain.LoggedInUser.Friends.ToList();

            //// For self Checking adding myself to the list to see if i show on the ListBox.
            listOfFriends.Add(r_FormMain.LoggedInUser);

            ICollection<User> usersToShow = r_FormMain.ManagerLogic.GetMostLikesOnPhotosByUsers(r_FormMain.LoggedInUser.Albums, listOfFriends);

            r_FormMain.resetListAndPhoto(m_ListBoxMostLikesPhotos, m_PictureBoxSelectedFriendPhoto);
            r_FormMain.fetchUserData(m_ListBoxMostLikesPhotos, usersToShow, errorMessage);
        }

        private void fetchUserComments()
        {
            const string errorMessage = "No User to retrieve :(";
            ICollection<User> listOfFriends = r_FormMain.LoggedInUser.Friends.ToList();

            //// For self Checking adding myself to the list to see if i show on the ListBox.
            listOfFriends.Add(r_FormMain.LoggedInUser);

            ICollection<User> usersToShow = r_FormMain.ManagerLogic.GetMostCommentsOnPhotosByUsers(r_FormMain.LoggedInUser.Albums, listOfFriends);

            r_FormMain.resetListAndPhoto(m_ListBoxMostComments, m_PictureBoxSelectedFriendComment);
            r_FormMain.fetchUserData(m_ListBoxMostComments, usersToShow,errorMessage);
        }

        private void fetchUserPosts()
        {
            const string errorMessage = "No Posts to retrieve :(";
            ICollection<User> listOfFriends = r_FormMain.LoggedInUser.Friends.ToList();
            ICollection<User> usersToShow = r_FormMain.ManagerLogic.GetMostLikesOnPostByUsers(r_FormMain.LoggedInUser.Posts, listOfFriends);

            r_FormMain.resetListAndPhoto(m_ListBoxMostLikesPosts, m_PictureBoxSelectedFriendPost);
            r_FormMain.fetchUserData(m_ListBoxMostLikesPosts, usersToShow, errorMessage);
        }
    }
}
