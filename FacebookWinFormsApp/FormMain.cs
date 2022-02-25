using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_AppId = "507070034420577";
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
        }

        private void loginAndInit()
        {
            m_LoginResult = FacebookService.Login(k_AppId,
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
                "user_videos");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;

                m_ButtonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			m_ButtonLogin.Text = "Login";
		}

        private void m_ButtonBestMatch_Click(object sender, EventArgs e)
        {
            new FormBestMatch().ShowDialog();
        }

        private void m_ButtonMostLikesFromFriends_Click(object sender, EventArgs e)
        {
            new FormMostLikesFromFriends().ShowDialog();
        }

        private void fetchUserInfo()
        {
            m_PictureBoxProfilePhoto.LoadAsync(m_LoggedInUser.PictureNormalURL);
            m_LabelFullName.Text = m_LoginResult.LoggedInUser.Name;
            m_LabelAge.Text = m_LoginResult.LoggedInUser.Birthday;

            if (m_LoggedInUser.Posts.Count > 0)
            {
                //textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
            }
        }
    }
}
