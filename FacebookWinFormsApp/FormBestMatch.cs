﻿using System;
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
        private LinkedList<User> m_BestMatchs;

        public FormBestMatch(FormMain i_FormMain)
        {
            r_FormMain = i_FormMain;
            InitializeComponent();
        }

        private void buttonSearchMatch_Click(object sender, EventArgs e)
        {
            resetPreviusPhotos();
            m_ListBoxBestMatch.Items.Clear();
            m_ListBoxBestMatch.DisplayMember = "Name";

            m_BestMatchs = r_FormMain.ManagerLogic.FindBestMatch(
                r_FormMain.LoggedInUser.Friends,
                r_FormMain.LoggedInUser,
                m_ChosenGender);

            try
            {
                foreach (User user in m_BestMatchs)
                {
                    m_ListBoxBestMatch.Items.Add(user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (m_ListBoxBestMatch.Items.Count == 0)
            {
                MessageBox.Show("No matchs to retrieve :(");
            }
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

            initializatedCommonPagesList(m_BestMatchs, m_ListBoxBestMatch.SelectedIndex);
            initializatedCommonGroupsList(m_BestMatchs, m_ListBoxBestMatch.SelectedIndex);
            initializatedCommonFriendsList(m_BestMatchs, m_ListBoxBestMatch.SelectedIndex);
        }

        private void linkLabelLoverProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                visitLoverProfile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void comboBoxAge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_ChosenGender = (User.eGender)m_ComboBoxGender.SelectedIndex;
        }

        private void visitLoverProfile()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            m_LinkLabelLoverProfile.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            if (m_ListBoxBestMatch.SelectedItems.Count == 1)
            {
                User selectedUser = m_ListBoxBestMatch.SelectedItem as User;
                System.Diagnostics.Process.Start(selectedUser.Link);
            }

        }

        private void getingTheData()
        {
            m_ComboBoxAge.SelectedItem.ToString();

        }

        private void resetPreviusPhotos()
        {
            m_PictureBoxBestMatch.Image = null;
            m_PictureBoxPages.Image = null;
            m_PictureBoxFriends.Image = null;
            m_PictureBoxGroups.Image = null;
        }

        // NEED TO FIX
        private void initializatedCommonPagesList(LinkedList<User> bestMatchsInLinkedList, int SelectedIndex)
        {
            List<User> bestMatchs = new List<User>();
            List<Page> commonPagesWithMatch = new List<Page>();

            bestMatchs = bestMatchsInLinkedList.ToList();
            commonPagesWithMatch = r_FormMain.ManagerLogic.FindCommonLikedPages<Page>(bestMatchs[SelectedIndex].Id);

            m_ListBoxPages.Items.Clear();
            m_ListBoxPages.DisplayMember = "Name";

            try
            {
                foreach (Page page in commonPagesWithMatch)
                {
                    m_ListBoxPages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (m_ListBoxPages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }
        }

        private void initializatedCommonGroupsList(LinkedList<User> bestMatchsInLinkedList, int SelectedIndex)
        {
            List<User> bestMatchs = new List<User>();
            List<Group> commonGroupsWithMatch = new List<Group>();

            bestMatchs = bestMatchsInLinkedList.ToList();
            commonGroupsWithMatch = r_FormMain.ManagerLogic.FindCommonGroups<Group>(bestMatchs[SelectedIndex].Id);

            m_ListBoxGroups.Items.Clear();
            m_ListBoxGroups.DisplayMember = "Name";

            try
            {
                foreach (Group group in commonGroupsWithMatch)
                {
                    m_ListBoxGroups.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (m_ListBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void initializatedCommonFriendsList(LinkedList<User> bestMatchsInLinkedList, int SelectedIndex)
        {
            List<User> bestMatchs = new List<User>();
            List<User> commonGroupsWithMatch = new List<User>();

            bestMatchs = bestMatchsInLinkedList.ToList();
            commonGroupsWithMatch = r_FormMain.ManagerLogic.FindCommonFriends<User>(bestMatchs[SelectedIndex].Id);

            m_ListBoxFriends.Items.Clear();
            m_ListBoxFriends.DisplayMember = "Name";

            try
            {
                foreach (User user in commonGroupsWithMatch)
                {
                    m_ListBoxFriends.Items.Add(user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (m_ListBoxFriends.Items.Count == 0)
            {
                MessageBox.Show("No friends to retrieve :(");
            }
        }
    }
}
