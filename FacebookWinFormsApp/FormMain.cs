using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_AppId = "507070034420577";

        public User LoggedInUser { get; set; }

        public LoginResult LoginResult { get; set; }

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        { 
            FacebookService.LogoutWithUI();
            resetWhenLogout();
		}

        private void m_ButtonBestMatch_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new FormBestMatch(this).ShowDialog();
            }
            // TODO: ERROR MESSAGE
        }

        private void m_ButtonMostLikesFromFriends_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                new FormMostLikesFromFriends(this).ShowDialog();
            }
            // TODO: ERROR MESSAGE
        }

        private void m_ButtonPopularPhotos_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                //fetchPhotos();
            }
            // TODO : ERROR MESSAGE
        }

        private void m_ListBoxPopularPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxPopularPhotos.SelectedItems.Count == 1)
            {
                Photo selectedPage = m_ListBoxPopularPhotos.SelectedItem as Photo;
                m_PictureBoxSelectedPopularPhoto.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        private void fetchPhotos()
        {
            m_ListBoxPopularPhotos.Items.Clear();
            m_ListBoxPopularPhotos.DisplayMember = "Name";

            foreach (Album album in LoggedInUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    m_ListBoxPopularPhotos.Items.Add(photo);
                }
            }

            if (m_ListBoxPopularPhotos.Items.Count == 0)
            {
                MessageBox.Show("No Photo to retrieve :(");
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
            LoginResult = FacebookService.Login(k_AppId,
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "groups_access_member_info",
                "user_videos");

            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedInUser = LoginResult.LoggedInUser;

                m_ButtonLogin.Text = $"Logged in";
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(LoginResult.ErrorMessage, "Login Failed");
            }
        }
    }
}
