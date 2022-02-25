using FacebookWrapper.ObjectModel;
using System;
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

        private void m_LabelMostLikesOnPhotos_Click(object sender, EventArgs e)
        {
            fetchPhotos();
        }

        private void m_ListBoxMostLikesPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxMostLikesPhotos.SelectedItems.Count == 1)
            {
                Photo selectedPage = m_ListBoxMostLikesPhotos.SelectedItem as Photo;
                m_PictureBoxSelectedFriendPhoto.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        private void m_LabelMostLikesOnPosts_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            m_ListBoxMostLikesPosts.Items.Clear();

            foreach (Post post in r_FormMain.LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    m_ListBoxMostLikesPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    m_ListBoxMostLikesPosts.Items.Add(post.Caption);
                }
                else
                {
                    m_ListBoxMostLikesPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (m_ListBoxMostLikesPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void fetchPhotos()
        {
            m_ListBoxMostLikesPhotos.Items.Clear();
            m_ListBoxMostLikesPhotos.DisplayMember = "Name";

            foreach (Album album in r_FormMain.LoggedInUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    m_ListBoxMostLikesPhotos.Items.Add(photo);
                }
            }

            if (m_ListBoxMostLikesPhotos.Items.Count == 0)
            {
                MessageBox.Show("No Photo to retrieve :(");
            }
        }
    }
}
