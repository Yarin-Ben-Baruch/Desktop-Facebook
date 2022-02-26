using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FaceBookAppLogic;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Message = System.Windows.Forms.Message;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_AppId = "507070034420577";
        // TODO: ITS OK ? sr ? rs ?
        private static readonly string[] sr_Permissions = {
            "email", "public_profile", "user_age_range", "user_birthday", "user_events",
            "user_friends", "user_gender", "user_hometown", "user_likes", "user_link",
            "user_location", "user_photos", "user_posts", "groups_access_member_info",
            "user_videos"};

        public LogicManager ManagerLogic { get; }

        public User LoggedInUser { get; set; }

        public LoginResult LoginResult { get; set; }

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;

            ManagerLogic = new LogicManager();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                FacebookService.LogoutWithUI();
                resetWhenLogout();
            }
            else
            {
                MessageBox.Show("You need to be logged in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("You need to be logged in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("You need to be logged in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPopularPhotos_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                fetchPhotos();
            }
            else
            {
                MessageBox.Show("You need to be logged in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxPopularPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxPopularPhotos.SelectedItems.Count == 1)
            {
                Photo selectedPhoto = m_ListBoxPopularPhotos.SelectedItem as Photo;

                m_PictureBoxSelectedPopularPhoto.LoadAsync(selectedPhoto.PictureNormalURL);
                m_LabelNumberOfLikes.Text = string.Format("Likes: {0}", selectedPhoto.LikedBy.Count);
            }
        }

        private void fetchPhotos()
        {
            List<Photo> photos = ManagerLogic.FetchSortedPhotos(LoggedInUser.Albums);

            m_ListBoxPopularPhotos.Items.Clear();
            m_ListBoxPopularPhotos.DisplayMember = "Name";

            foreach (Photo photo in photos)
            {
                m_ListBoxPopularPhotos.Items.Add(photo);
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

            m_ListBoxPopularPhotos.Items.Clear();
        }

        private void fetchUserInfo()
        {
            m_PictureBoxProfilePhoto.LoadAsync(LoggedInUser.PictureLargeURL);
            m_LabelFullName.Text = LoginResult.LoggedInUser.Name;
            m_LabelBirthday.Text = LoginResult.LoggedInUser.Birthday;
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
                MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
