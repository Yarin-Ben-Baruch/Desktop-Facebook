using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormPopularPhotos : Form
    {
        private readonly FormMain r_FormMain;
        private const string k_ErrorMessage = "This feature is not yet supported";

        public FormPopularPhotos(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            InitializeComponent();
        }

        private void buttonPopularPhotos_Click(object sender, EventArgs e)
        {
            try
            {
                const string errorMessage = "No photos to ...";
                ICollection<Photo> photos = r_FormMain.ManagerLogic.FetchSortedPhotos(r_FormMain.LoggedInUser.Albums);

                r_FormMain.resetListAndPhoto(m_ListBoxPopularPhotos, m_PictureBoxSelectedPopularPhoto);
                r_FormMain.fetchUserData(m_ListBoxPopularPhotos, photos, errorMessage);
            }
            catch (Exception)
            {
                MessageBox.Show(k_ErrorMessage);
            }

        }

        private void listBoxPopularPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxPopularPhotos.SelectedItems.Count == 1)
            {
                Photo selectedPhoto = m_ListBoxPopularPhotos.SelectedItem as Photo;

                try
                {
                    m_PictureBoxSelectedPopularPhoto.LoadAsync(selectedPhoto.PictureNormalURL);
                    m_LabelNumberOfLikes.Text = $"Likes: {selectedPhoto.LikedBy.Count}";
                }
                catch (Exception)
                {
                    MessageBox.Show(k_ErrorMessage);
                }
            }
        }

    }
}
