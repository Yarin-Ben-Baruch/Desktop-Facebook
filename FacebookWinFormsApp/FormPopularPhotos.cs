using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormPopularPhotos : Form
    {
        private readonly FormMain r_FormMain;

        public FormPopularPhotos(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            InitializeComponent();
        }

        private void buttonPopularPhotos_Click(object sender, EventArgs e)
        {
            fetchPhotos();
        }

        private void fetchPhotos()
        {
            ICollection<Photo> photos = r_FormMain.ManagerLogic.FetchSortedPhotos(r_FormMain.LoggedInUser.Albums);

            m_ListBoxPopularPhotos.Items.Clear();
            m_ListBoxPopularPhotos.DisplayMember = "Name";

            foreach (Photo photo in photos)
            {
                m_ListBoxPopularPhotos.Items.Add(photo);
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
    }
}
