using System;
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
            Post selected = r_FormMain.LoggedInUser.Posts[m_ListBoxPosts.SelectedIndex];

            try
            {
                m_ListBoxPostComments.DisplayMember = "Message";
                m_ListBoxPostComments.DataSource = selected.Comments;
            }
            catch (Exception)
            {
                MessageBox.Show(r_FormMain.ErrorMessageSupported, r_FormMain.TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = r_FormMain.LoggedInUser.PostStatus(m_TextBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception)
            {
                MessageBox.Show(r_FormMain.ErrorMessageSupported, r_FormMain.TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // TODO : CHECK IF CAN PUT IN 
        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            try
            {
                fetchPosts();
            }
            catch (Exception)
            {
                MessageBox.Show(r_FormMain.ErrorMessageSupported, r_FormMain.TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fetchPosts()
        {
            m_ListBoxPosts.Items.Clear();
        
            foreach (Post post in r_FormMain.LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    m_ListBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    m_ListBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    m_ListBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }
        
            if (m_ListBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }
    }
}
