using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        internal string ErrorMessageSupported => k_ErrorMessageSupported;

        internal string TypeOfMessage => k_TypeOfMessage;

        public LogicManager ManagerLogic { get; }

        public User LoggedInUser { get; set; }

        public LoginResult LoginResult { get; set; }

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;

            ManagerLogic = new LogicManager();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (LoginResult != null)
            {
                saveUserSettings();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Location = ApplicationSettings.Instance.LastWindowLocation;
            this.m_CheckBoxAutoLogin.Checked = ApplicationSettings.Instance.AutoLogin;
            this.WindowState = ApplicationSettings.Instance.LastWindowState;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (ApplicationSettings.Instance.AutoLogin)
            {
                autoLogin();
            }
        }

        internal void FetchUserData<T>(ListBox i_ListBoxToFill, ICollection<T> i_Collection, string i_ErrorMessage)
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
                loginToUser();
            }
            catch (Exception)
            {
                MessageBox.Show(ErrorMessageSupported, TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try
            {
                logoutFromUser();
            }
            catch (Exception)
            {
                MessageBox.Show(ErrorMessageSupported, TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(k_ErrorMessageLogin, TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(k_ErrorMessageLogin, TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(k_ErrorMessageLogin, TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(k_ErrorMessageLogin, TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(k_ErrorMessageLogin, TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(k_ErrorMessageLogin, TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoutFromUser()
        {
            if (LoggedInUser != null)
            {
                FacebookService.LogoutWithUI();
                resetWhenLogout();
                saveUserSettings();
            }
            else
            {
                MessageBox.Show(k_ErrorMessageLogin, TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginToUser()
        {
            LoginResult = FacebookService.Login(k_AppId, sr_Permissions);

            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedInUser = LoginResult.LoggedInUser;
                ApplicationSettings.Instance.AccessToken = LoginResult.AccessToken;
                initWhenLogin();
            }
            else
            {
                MessageBox.Show("Login Failed", TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            m_CheckBoxAutoLogin.Enabled = false;
        }

        private void initWhenLogin()
        {
            m_ButtonLogin.Text = "Logged in";
            m_PictureBoxProfilePhoto.LoadAsync(LoggedInUser.PictureLargeURL);
            m_LabelFullName.Text = LoggedInUser.Name;
            m_LabelBirthday.Text = LoggedInUser.Birthday;
            m_LabelGender.Text = LoggedInUser.Gender.ToString();
            m_CheckBoxAutoLogin.Enabled = true;
        }

        private void saveUserSettings()
        {
            ApplicationSettings.Instance.LastWindowLocation = Location;
            ApplicationSettings.Instance.AutoLogin = m_CheckBoxAutoLogin.Checked;
            ApplicationSettings.Instance.SaveApplicationSettings();
        }

        private void autoLogin()
        {
            LoginResult result = FacebookService.Connect(ApplicationSettings.Instance.AccessToken);

            if (string.IsNullOrEmpty(result.ErrorMessage))
            {
                LoggedInUser = result.LoggedInUser;
                initWhenLogin();
            }
        }
    }
}
