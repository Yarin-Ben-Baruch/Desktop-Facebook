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
            const string errorMessage = "No matches to retrieve :(";
            
            m_BestMatches = r_FormMain.ManagerLogic.FindBestMatch(
                r_FormMain.LoggedInUser.Friends,
                r_FormMain.LoggedInUser,
                m_ChosenGender,
                decimal.ToInt32(m_NumericUpDownStartAge.Value),
                decimal.ToInt32(m_NumericUpDownEndAge.Value));

            resetPreviousSearch();
            r_FormMain.fetchUserData(m_ListBoxBestMatch, m_BestMatches.ToList(), errorMessage);
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxGroups.SelectedItems.Count == 1)
            {
                Group selectedGroup = m_ListBoxGroups.SelectedItem as Group;

                m_PictureBoxGroups.LoadAsync(selectedGroup.PictureNormalURL);
            }
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxPages.SelectedItems.Count == 1)
            {
                Page selectedPage = m_ListBoxPages.SelectedItem as Page;

                m_PictureBoxPages.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxFriends.SelectedItems.Count == 1)
            {
                User selectedUser = m_ListBoxFriends.SelectedItem as User;

                m_PictureBoxFriends.LoadAsync(selectedUser.PictureNormalURL);
            }
        }

        private void listBoxBestMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxBestMatch.SelectedItems.Count == 1)
            {
                User selectedUser = m_ListBoxBestMatch.SelectedItem as User;

                m_PictureBoxBestMatch.LoadAsync(selectedUser.PictureNormalURL);
            }

            initializedCommonPagesList(m_BestMatches, m_ListBoxBestMatch.SelectedIndex);
            initializedCommonGroupsList(m_BestMatches, m_ListBoxBestMatch.SelectedIndex);
            initializedCommonFriendsList(m_BestMatches, m_ListBoxBestMatch.SelectedIndex);
        }

        // TODO : CHECK
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

        private void visitLoverProfile()
        {
            //// Change the color of the link text by setting LinkVisited
            //// to true.
            m_LinkLabelLoverProfile.LinkVisited = true;
            //// Call the Process.Start method to open the default browser
            //// with a URL:
            if (m_ListBoxBestMatch.SelectedItems.Count == 1)
            {
                User selectedUser = m_ListBoxBestMatch.SelectedItem as User;
                System.Diagnostics.Process.Start(selectedUser.Link);
            }
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_ChosenGender = (User.eGender)m_ComboBoxGender.SelectedIndex;
        }

        private void initializedCommonPagesList(ICollection<User> i_BestMatchesInLinkedList, int i_SelectedIndex)
        {
            const string errorMessage = "No liked pages to retrieve :(";
            IList<User> bestMatchs = new List<User>();
            ICollection<Page> commonPagesWithMatch = new List<Page>();

            bestMatchs = i_BestMatchesInLinkedList.ToList();
            commonPagesWithMatch = r_FormMain.ManagerLogic.FindCommonLikedPages(bestMatchs[i_SelectedIndex].Id);

            r_FormMain.resetListAndPhoto(m_ListBoxPages, m_PictureBoxPages);
            r_FormMain.fetchUserData(m_ListBoxPages, commonPagesWithMatch, errorMessage);
        }

        private void initializedCommonGroupsList(ICollection<User> i_BestMatchesInLinkedList, int i_SelectedIndex)
        {
            const string errorMessage = "No groups to retrieve :(";
            IList<User> bestMatchs = new List<User>();
            ICollection<Group> commonGroupsWithMatch = new List<Group>();

            bestMatchs = i_BestMatchesInLinkedList.ToList();
            commonGroupsWithMatch = r_FormMain.ManagerLogic.FindCommonGroups(bestMatchs[i_SelectedIndex].Id);

            r_FormMain.resetListAndPhoto(m_ListBoxGroups, m_PictureBoxGroups);
            r_FormMain.fetchUserData(m_ListBoxGroups, commonGroupsWithMatch, errorMessage);
        }

        private void initializedCommonFriendsList(ICollection<User> i_BestMatchesInLinkedList, int i_SelectedIndex)
        {
            const string errorMessage = "No friends to retrieve :(";
            IList<User> bestMatchs = new List<User>();
            ICollection<User> commonFriendsWithMatch = new List<User>();

            bestMatchs = i_BestMatchesInLinkedList.ToList();
            commonFriendsWithMatch = r_FormMain.ManagerLogic.FindCommonFriends(bestMatchs[i_SelectedIndex].Id);

            r_FormMain.resetListAndPhoto(m_ListBoxFriends, m_PictureBoxFriends);
            r_FormMain.fetchUserData(m_ListBoxFriends, commonFriendsWithMatch, errorMessage);
        }

        // private void fillListBoxWithCommonCollection<T>(ICollection<T> i_CommonCollection, string i_ErrorMessage, ListBox i_ListBoxToFill)
        // {
        //
        //     i_ListBoxToFill.DisplayMember = "Name";
        //
        //     try
        //     {
        //         foreach (T commonItem in i_CommonCollection)
        //         {
        //             i_ListBoxToFill.Items.Add(commonItem);
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         MessageBox.Show(ex.Message);
        //     }
        //
        //     if (i_ListBoxToFill.Items.Count == 0)
        //     {
        //         MessageBox.Show(i_ErrorMessage);
        //     }
        // }


        // private void resetListAndPhoto(ListBox i_ListBoxToFill, PictureBox i_PhotoToRemove)
        // {
        //     i_PhotoToRemove.Image = null;
        //     i_ListBoxToFill.Items.Clear();
        // }

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
