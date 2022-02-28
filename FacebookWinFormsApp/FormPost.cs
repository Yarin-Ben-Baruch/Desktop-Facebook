using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormPost : Form
    {
        private readonly FormMain r_FormMain;

        public FormPost(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            InitializeComponent();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = r_FormMain.LoggedInUser.Posts[listBoxPosts.SelectedIndex];
            listBoxPostComments.DisplayMember = "Message";
            listBoxPostComments.DataSource = selected.Comments;
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = r_FormMain.LoggedInUser.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();

            foreach (Post post in r_FormMain.LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }
    }
}

/*
 * private void listBoxPostComments_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxPostComments.SelectedItems.Count == 1)
            {
                try
                {
                    (listBoxPostComments.SelectedItem as Comment).Like();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
@"posting LIKEs is no longer supported :(
(OAuthException - #3) 
Publishing likes through the API is only available for page access tokens");
                }
            }
        }
 */
