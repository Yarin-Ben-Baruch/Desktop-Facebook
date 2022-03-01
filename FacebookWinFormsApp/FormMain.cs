﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FaceBookAppLogic;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_AppId = "507070034420577";
        private const string k_ErrorMessageLogin = "You need to be logged in";
        private const string k_ErrorMessageSupported = "This feature is not yet supported";
        private const string k_TypeOfMessage = "Error";
        private static readonly string[] sr_Permissions = { "public_profile", "user_birthday", "user_friends", "user_gender", "user_likes", "user_link", "user_location", "user_photos", "user_posts", "groups_access_member_info", "user_events" };

        public LogicManager ManagerLogic { get; }

        public User LoggedInUser { get; set; }

        public LoginResult LoginResult { get; set; }

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;

            ManagerLogic = new LogicManager();
        }

        // COMMON METHODS
        internal void FetchUserData<T>(ListBox i_ListBoxToFill,
            ICollection<T> i_Collection, string i_ErrorMessage)
        {
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

        internal void ResetListAndPhoto(ListBox i_ListBoxToFill, PictureBox i_PhotoToRemove)
        {
            i_PhotoToRemove.Image = null;
            i_ListBoxToFill.Items.Clear();
        }

        internal void UpdatePhotoAsUser(ListBox i_SelectedListBox, PictureBox i_PhotoToAdd)
        {
            if (i_SelectedListBox.SelectedItems.Count == 1)
            {
                User selectedUser = i_SelectedListBox.SelectedItem as User;

                i_PhotoToAdd.LoadAsync(selectedUser.PictureNormalURL);
            }
            else
            {
                i_PhotoToAdd.Image = i_PhotoToAdd.ErrorImage;
            }
        }

        internal void UpdatePhotoAsPage(ListBox i_SelectedListBox, PictureBox i_PhotoToAdd)
        {
            if (i_SelectedListBox.SelectedItems.Count == 1)
            {
                Page selectedPage = i_SelectedListBox.SelectedItem as Page;
                i_PhotoToAdd.LoadAsync(selectedPage.PictureNormalURL);
            }
            else
            {
                i_PhotoToAdd.Image = i_PhotoToAdd.ErrorImage;
            }
        }

        internal void UpdatePhotoAsEvent(ListBox i_SelectedListBox, PictureBox i_PhotoToAdd)
        {
            if (i_SelectedListBox.SelectedItems.Count == 1)
            {
                Event selectedEvent = i_SelectedListBox.SelectedItem as Event;
                i_PhotoToAdd.LoadAsync(selectedEvent.Cover.SourceURL);
            }
            else
            {
                i_PhotoToAdd.Image = i_PhotoToAdd.ErrorImage;
            }
        }

        internal void UpdatePhotoAsAlbum(ListBox i_SelectedListBox, PictureBox i_PhotoToAdd)
        {
            if (i_SelectedListBox.SelectedItems.Count == 1)
            {
                Album selectedEvent = i_SelectedListBox.SelectedItem as Album;
                i_PhotoToAdd.LoadAsync(selectedEvent.PictureAlbumURL);
            }
            else
            {
                i_PhotoToAdd.Image = i_PhotoToAdd.ErrorImage;
            }
        }

        internal void UpdatePhotoAsGroup(ListBox i_SelectedListBox, PictureBox i_PhotoToAdd)
        {
            if (i_SelectedListBox.SelectedItems.Count == 1)
            {
                Group selectedGroup = i_SelectedListBox.SelectedItem as Group;

                i_PhotoToAdd.LoadAsync(selectedGroup.PictureNormalURL);
            }
            else
            {
                i_PhotoToAdd.Image = i_PhotoToAdd.ErrorImage;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                loginAndInit();
            }
            catch (Exception)
            {
                MessageBox.Show(k_ErrorMessageSupported);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try
            {
                logoutAndReset();
            }
            catch (Exception)
            {
                MessageBox.Show(k_ErrorMessageSupported);
            }
        }

        private void buttonBestMatch_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new FormBestMatch(this).ShowDialog();
            }
            else
            {
                MessageBox.Show(k_ErrorMessageLogin, k_TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMostLikesFromFriends_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new FormMostLikesFromFriends(this).ShowDialog();
            }
            else
            {
                MessageBox.Show(k_ErrorMessageLogin, k_TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFindMyFriendsCities_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new FormLocations(this).ShowDialog();
            }
            else
            {
                MessageBox.Show(k_ErrorMessageLogin, k_TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPopularPhotos_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new FormPopularPhotos(this).ShowDialog();
            }
            else
            {
                MessageBox.Show(k_ErrorMessageLogin, k_TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAccountInfo_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new FormAccountInfo(this).ShowDialog();
            }
            else
            {
                MessageBox.Show(k_ErrorMessageLogin, k_TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new FormPost(this).ShowDialog();
            }
            else
            {
                MessageBox.Show(k_ErrorMessageLogin, k_TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetWhenLogout()
        {
            LoggedInUser = null;
            LoginResult = null;
            m_ButtonLogin.Text = "Login";

            m_PictureBoxProfilePhoto.Image = null;
            m_LabelFullName.Text = "Full name";
            m_LabelBirthday.Text = "Birthday";
            m_LabelGender.Text = "Gender";
        }

        private void fetchUserInfo()
        {
            m_PictureBoxProfilePhoto.LoadAsync(LoggedInUser.PictureLargeURL);
            m_LabelFullName.Text = LoggedInUser.Name;
            m_LabelBirthday.Text = LoggedInUser.Birthday;
            m_LabelGender.Text = LoggedInUser.Gender.ToString();
        }

        private void loginAndInit()
        {
            LoginResult = FacebookService.Login(k_AppId, sr_Permissions);

            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedInUser = LoginResult.LoggedInUser;

                m_ButtonLogin.Text = $"Logged in";
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show("Login Failed", k_TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoutAndReset()
        {
            if (LoggedInUser != null)
            {
                FacebookService.LogoutWithUI();
                resetWhenLogout();
            }
            else
            {
                MessageBox.Show(k_ErrorMessageLogin, k_TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
