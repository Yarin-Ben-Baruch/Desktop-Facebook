using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormBestMatch : Form
    {
        private readonly FormMain r_FormMain;
        private User.eGender m_ChosenGender;
        private ICollection<User> m_BestMatches;
        
        public FormBestMatch(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            InitializeComponent();
        }

        private void buttonSearchMatch_Click(object sender, EventArgs e)
        {
            try
            {
                const string errorMessage = "No matches to retrieve :(";

                m_BestMatches = r_FormMain.ManagerLogic.FindBestMatch(
                    r_FormMain.LoggedInUser.Friends,
                    r_FormMain.LoggedInUser,
                    m_ChosenGender,
                    decimal.ToInt32(m_NumericUpDownStartAge.Value),
                    decimal.ToInt32(m_NumericUpDownEndAge.Value));

                resetPreviousSearch();
                r_FormMain.FetchUserData(m_ListBoxBestMatch, m_BestMatches.ToList(), errorMessage);
            }
            catch (Exception)
            {
                MessageBox.Show(r_FormMain.ErrorMessageSupported, r_FormMain.TypeOfMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_FormMain.UpdatePhotoAsGroup(m_ListBoxGroups, m_PictureBoxGroups);
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_FormMain.UpdatePhotoAsPage(m_ListBoxPages, m_PictureBoxPages);
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_FormMain.UpdatePhotoAsUser(m_ListBoxFriends, m_PictureBoxFriends);
        }

        private void listBoxBestMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxBestMatch.SelectedItems.Count == 1)
            {
                User selectedUser = m_ListBoxBestMatch.SelectedItem as User;

                m_PictureBoxBestMatch.LoadAsync(selectedUser.PictureNormalURL);
                initializedCommonPagesList(m_BestMatches, m_ListBoxBestMatch.SelectedIndex);
                initializedCommonGroupsList(m_BestMatches, m_ListBoxBestMatch.SelectedIndex);
                initializedCommonFriendsList(m_BestMatches, m_ListBoxBestMatch.SelectedIndex);
            }
        }

        private void linkLabelLoverProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                visitLoverProfile();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_ChosenGender = (User.eGender)m_ComboBoxGender.SelectedIndex;
        }

        private void numericUpDownStartAge_ValueChanged(object sender, EventArgs e)
        {
            if (m_NumericUpDownStartAge.Value > m_NumericUpDownEndAge.Value)
            {
                m_NumericUpDownEndAge.Value = m_NumericUpDownStartAge.Value;
            }
        }

        private void numericUpDownEndAge_ValueChanged(object sender, EventArgs e)
        {
            if (m_NumericUpDownStartAge.Value > m_NumericUpDownEndAge.Value)
            {
                m_NumericUpDownStartAge.Value = m_NumericUpDownEndAge.Value;
            }
        }

        private void visitLoverProfile()
        {
            m_LinkLabelLoverProfile.LinkVisited = true;

            if (m_ListBoxBestMatch.SelectedItems.Count == 1)
            {
                User selectedUser = m_ListBoxBestMatch.SelectedItem as User;

                System.Diagnostics.Process.Start(selectedUser.Link);
            }
        }

        private void initializedCommonPagesList(ICollection<User> i_BestMatchesCollection, int i_SelectedIndex)
        {
            const string errorMessage = "No liked pages to retrieve :(";
            IList<User> bestMatches = new List<User>();
            ICollection<Page> commonPagesWithMatch = new List<Page>();

            bestMatches = i_BestMatchesCollection.ToList();
            commonPagesWithMatch = r_FormMain.ManagerLogic.FindCommonLikedPages(bestMatches[i_SelectedIndex].Id);

            r_FormMain.ResetListAndPhoto(m_ListBoxPages, m_PictureBoxPages);
            r_FormMain.FetchUserData(m_ListBoxPages, commonPagesWithMatch, errorMessage);
        }

        private void initializedCommonGroupsList(ICollection<User> i_BestMatchesCollection, int i_SelectedIndex)
        {
            const string errorMessage = "No groups to retrieve :(";
            IList<User> bestMatches = new List<User>();
            ICollection<Group> commonGroupsWithMatch = new List<Group>();

            bestMatches = i_BestMatchesCollection.ToList();
            commonGroupsWithMatch = r_FormMain.ManagerLogic.FindCommonGroups(bestMatches[i_SelectedIndex].Id);

            r_FormMain.ResetListAndPhoto(m_ListBoxGroups, m_PictureBoxGroups);
            r_FormMain.FetchUserData(m_ListBoxGroups, commonGroupsWithMatch, errorMessage);
        }

        private void initializedCommonFriendsList(ICollection<User> i_BestMatchesCollection, int i_SelectedIndex)
        {
            const string errorMessage = "No friends to retrieve :(";
            IList<User> bestMatches = new List<User>();
            ICollection<User> commonFriendsWithMatch = new List<User>();

            bestMatches = i_BestMatchesCollection.ToList();
            commonFriendsWithMatch = r_FormMain.ManagerLogic.FindCommonFriends(bestMatches[i_SelectedIndex].Id);

            r_FormMain.ResetListAndPhoto(m_ListBoxFriends, m_PictureBoxFriends);
            r_FormMain.FetchUserData(m_ListBoxFriends, commonFriendsWithMatch, errorMessage);
        }

        private void resetPreviousSearch()
        {
            m_ListBoxBestMatch.Items.Clear();
            m_ListBoxFriends.Items.Clear();
            m_ListBoxGroups.Items.Clear();
            m_ListBoxPages.Items.Clear();

            m_PictureBoxBestMatch.Image = null;
            m_PictureBoxPages.Image = null;
            m_PictureBoxFriends.Image = null;
            m_PictureBoxGroups.Image = null;
        }
    }
}
