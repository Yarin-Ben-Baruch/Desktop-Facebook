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

        public FormMostLikesFromFriends(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            InitializeComponent();
        }

        private void buttonMostLikesOnPhotos_Click(object sender, EventArgs e)
        {
            fetchUserPhotos();
        }

        private void buttonMostComments_Click(object sender, EventArgs e)
        {
            fetchUserComments();
        }

        private void listBoxMostLikesPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxMostLikesPhotos.SelectedItems.Count == 1)
            {
                User selectedUser = m_ListBoxMostLikesPhotos.SelectedItem as User;

                m_PictureBoxSelectedFriendPhoto.LoadAsync(selectedUser.PictureNormalURL);
            }
        }

        private void listBoxMostComments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxMostComments.SelectedItems.Count == 1)
            {
                User selectedUser = m_ListBoxMostComments.SelectedItem as User;

                m_PictureBoxSelectedFriendComment.LoadAsync(selectedUser.PictureNormalURL);
            }
        }

        private void fetchUserPhotos()
        {
            const string errorMessage = "No User to retrieve :(";
            ICollection<User> listOfFriends = r_FormMain.LoggedInUser.Friends.ToList();

            //// For self Checking adding myself to the list to see if i show on the ListBox.
            listOfFriends.Add(r_FormMain.LoggedInUser);

            ICollection<User> usersToShow = r_FormMain.ManagerLogic.GetMostLikesOnPhotosByUsers(r_FormMain.LoggedInUser.Albums, listOfFriends);

            // m_ListBoxMostLikesPhotos.Items.Clear();
            // m_ListBoxMostLikesPhotos.DisplayMember = "Name";



            r_FormMain.resetListAndPhoto(m_ListBoxMostLikesPhotos, m_PictureBoxSelectedFriendPhoto);
            r_FormMain.fetchUserData(m_ListBoxMostLikesPhotos, usersToShow, errorMessage);

            // enterDataIntoListBox(m_ListBoxMostLikesPhotos, usersToShow);
        }

        private void fetchUserComments()
        {
            const string errorMessage = "No User to retrieve :(";
            ICollection<User> listOfFriends = r_FormMain.LoggedInUser.Friends.ToList();

            //// For self Checking adding myself to the list to see if i show on the ListBox.
            listOfFriends.Add(r_FormMain.LoggedInUser);

            ICollection<User> usersToShow = r_FormMain.ManagerLogic.GetMostCommentsOnPhotosByUsers(r_FormMain.LoggedInUser.Albums, listOfFriends);



            r_FormMain.resetListAndPhoto(m_ListBoxMostComments,m_PictureBoxSelectedFriendComment);
            r_FormMain.fetchUserData(m_ListBoxMostComments, usersToShow,errorMessage);

            // m_ListBoxMostComments.Items.Clear();
            // m_ListBoxMostComments.DisplayMember = "Name";
            
            // enterDataIntoListBox(m_ListBoxMostComments, usersToShow);
        }

        // private void enterDataIntoListBox(ListBox i_ListBoxToAdd, ICollection<User> i_UsersToAdd)
        // {
        //     foreach (User user in i_UsersToAdd)
        //     {
        //         i_ListBoxToAdd.Items.Add(user);
        //     }
        //
        //     if (i_ListBoxToAdd.Items.Count == 0)
        //     {
        //         MessageBox.Show("No User to retrieve :(");
        //     }
        // }

        private void m_ButtonMostLikesOnPosts_Click(object sender, EventArgs e)
        {
            const string errorMessage = "No Posts to retrieve :(";
            ICollection<User> usersToShow = r_FormMain.ManagerLogic.GetMostLikesOnPostByUsers(r_FormMain.LoggedInUser.Posts);

            r_FormMain.resetListAndPhoto(m_ListBoxMostLikesPosts,m_PictureBoxSelectedFriendPost);
            r_FormMain.fetchUserData(m_ListBoxMostLikesPosts, usersToShow, errorMessage);
            // fetchPosts();
        }

        // private void fetchPosts()
        // {
        //     ICollection<User> usersToShow = r_FormMain.ManagerLogic.GetMostLikesOnPostByUsers(r_FormMain.LoggedInUser.Posts);
        //
        //     m_ListBoxMostLikesPosts.Items.Clear();
        //
        //     foreach (User user in usersToShow)
        //     {
        //         m_ListBoxMostLikesPosts.Items.Add(user);
        //     }
        //
        //     if (m_ListBoxMostLikesPosts.Items.Count == 0)
        //     {
        //         MessageBox.Show("No Posts to retrieve :(");
        //     }
        // }
    }
}
