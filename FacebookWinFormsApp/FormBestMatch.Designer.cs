
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FormBestMatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_ComboBoxAge = new System.Windows.Forms.ComboBox();
            this.m_LabelGender = new System.Windows.Forms.Label();
            this.m_LabelAge = new System.Windows.Forms.Label();
            this.m_ButtonSearchMatch = new System.Windows.Forms.Button();
            this.m_ListBoxGroups = new System.Windows.Forms.ListBox();
            this.m_LabelGroups = new System.Windows.Forms.Label();
            this.m_PictureBoxGroups = new System.Windows.Forms.PictureBox();
            this.m_PictureBoxPages = new System.Windows.Forms.PictureBox();
            this.m_LabelPages = new System.Windows.Forms.Label();
            this.m_ListBoxPages = new System.Windows.Forms.ListBox();
            this.m_PictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.m_LabelFriends = new System.Windows.Forms.Label();
            this.m_ListBoxFriends = new System.Windows.Forms.ListBox();
            this.m_ListBoxBestMatch = new System.Windows.Forms.ListBox();
            this.m_PictureBoxBestMatch = new System.Windows.Forms.PictureBox();
            this.m_LinkLabelLoverProfile = new System.Windows.Forms.LinkLabel();
            this.m_LabelBestMatch = new System.Windows.Forms.Label();
            this.m_LinkLabelCommonGroups = new System.Windows.Forms.LinkLabel();
            this.m_LinkLabelCommonPages = new System.Windows.Forms.LinkLabel();
            this.m_LinkLabelCommonFriends = new System.Windows.Forms.LinkLabel();
            this.m_ComboBoxGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxBestMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ComboBoxAge
            // 
            this.m_ComboBoxAge.FormattingEnabled = true;
            this.m_ComboBoxAge.Items.AddRange(new object[] {
            "15-20",
            "20-25",
            "25-30",
            "30-35",
            "35-40",
            "40+"});
            this.m_ComboBoxAge.Location = new System.Drawing.Point(111, 70);
            this.m_ComboBoxAge.Margin = new System.Windows.Forms.Padding(4);
            this.m_ComboBoxAge.Name = "m_ComboBoxAge";
            this.m_ComboBoxAge.Size = new System.Drawing.Size(160, 24);
            this.m_ComboBoxAge.TabIndex = 1;
            this.m_ComboBoxAge.SelectedIndexChanged += new System.EventHandler(this.comboBoxAge_SelectedIndexChanged);
            // 
            // m_LabelGender
            // 
            this.m_LabelGender.AutoSize = true;
            this.m_LabelGender.Location = new System.Drawing.Point(18, 31);
            this.m_LabelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LabelGender.Name = "m_LabelGender";
            this.m_LabelGender.Size = new System.Drawing.Size(56, 17);
            this.m_LabelGender.TabIndex = 2;
            this.m_LabelGender.Text = "Gender";
            // 
            // m_LabelAge
            // 
            this.m_LabelAge.AutoSize = true;
            this.m_LabelAge.Location = new System.Drawing.Point(18, 77);
            this.m_LabelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LabelAge.Name = "m_LabelAge";
            this.m_LabelAge.Size = new System.Drawing.Size(33, 17);
            this.m_LabelAge.TabIndex = 3;
            this.m_LabelAge.Text = "Age";
            // 
            // m_ButtonSearchMatch
            // 
            this.m_ButtonSearchMatch.BackColor = System.Drawing.Color.White;
            this.m_ButtonSearchMatch.Location = new System.Drawing.Point(72, 131);
            this.m_ButtonSearchMatch.Margin = new System.Windows.Forms.Padding(4);
            this.m_ButtonSearchMatch.Name = "m_ButtonSearchMatch";
            this.m_ButtonSearchMatch.Size = new System.Drawing.Size(100, 28);
            this.m_ButtonSearchMatch.TabIndex = 4;
            this.m_ButtonSearchMatch.Text = "Search";
            this.m_ButtonSearchMatch.UseVisualStyleBackColor = false;
            this.m_ButtonSearchMatch.Click += new System.EventHandler(this.buttonSearchMatch_Click);
            // 
            // m_ListBoxGroups
            // 
            this.m_ListBoxGroups.FormattingEnabled = true;
            this.m_ListBoxGroups.ItemHeight = 16;
            this.m_ListBoxGroups.Location = new System.Drawing.Point(32, 278);
            this.m_ListBoxGroups.Margin = new System.Windows.Forms.Padding(4);
            this.m_ListBoxGroups.Name = "m_ListBoxGroups";
            this.m_ListBoxGroups.Size = new System.Drawing.Size(204, 244);
            this.m_ListBoxGroups.TabIndex = 5;
            this.m_ListBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // m_LabelGroups
            // 
            this.m_LabelGroups.AutoSize = true;
            this.m_LabelGroups.Location = new System.Drawing.Point(79, 229);
            this.m_LabelGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LabelGroups.Name = "m_LabelGroups";
            this.m_LabelGroups.Size = new System.Drawing.Size(114, 17);
            this.m_LabelGroups.TabIndex = 6;
            this.m_LabelGroups.Text = "Common Groups";
            // 
            // m_PictureBoxGroups
            // 
            this.m_PictureBoxGroups.Location = new System.Drawing.Point(141, 440);
            this.m_PictureBoxGroups.Margin = new System.Windows.Forms.Padding(4);
            this.m_PictureBoxGroups.Name = "m_PictureBoxGroups";
            this.m_PictureBoxGroups.Size = new System.Drawing.Size(93, 80);
            this.m_PictureBoxGroups.TabIndex = 7;
            this.m_PictureBoxGroups.TabStop = false;
            // 
            // m_PictureBoxPages
            // 
            this.m_PictureBoxPages.Location = new System.Drawing.Point(504, 440);
            this.m_PictureBoxPages.Margin = new System.Windows.Forms.Padding(4);
            this.m_PictureBoxPages.Name = "m_PictureBoxPages";
            this.m_PictureBoxPages.Size = new System.Drawing.Size(93, 80);
            this.m_PictureBoxPages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxPages.TabIndex = 10;
            this.m_PictureBoxPages.TabStop = false;
            // 
            // m_LabelPages
            // 
            this.m_LabelPages.AutoSize = true;
            this.m_LabelPages.Location = new System.Drawing.Point(436, 229);
            this.m_LabelPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LabelPages.Name = "m_LabelPages";
            this.m_LabelPages.Size = new System.Drawing.Size(107, 17);
            this.m_LabelPages.TabIndex = 9;
            this.m_LabelPages.Text = "Common Pages";
            // 
            // m_ListBoxPages
            // 
            this.m_ListBoxPages.FormattingEnabled = true;
            this.m_ListBoxPages.ItemHeight = 16;
            this.m_ListBoxPages.Location = new System.Drawing.Point(395, 278);
            this.m_ListBoxPages.Margin = new System.Windows.Forms.Padding(4);
            this.m_ListBoxPages.Name = "m_ListBoxPages";
            this.m_ListBoxPages.Size = new System.Drawing.Size(204, 244);
            this.m_ListBoxPages.TabIndex = 8;
            this.m_ListBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // m_PictureBoxFriends
            // 
            this.m_PictureBoxFriends.Location = new System.Drawing.Point(861, 440);
            this.m_PictureBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.m_PictureBoxFriends.Name = "m_PictureBoxFriends";
            this.m_PictureBoxFriends.Size = new System.Drawing.Size(93, 80);
            this.m_PictureBoxFriends.TabIndex = 13;
            this.m_PictureBoxFriends.TabStop = false;
            // 
            // m_LabelFriends
            // 
            this.m_LabelFriends.AutoSize = true;
            this.m_LabelFriends.Location = new System.Drawing.Point(793, 229);
            this.m_LabelFriends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LabelFriends.Name = "m_LabelFriends";
            this.m_LabelFriends.Size = new System.Drawing.Size(114, 17);
            this.m_LabelFriends.TabIndex = 12;
            this.m_LabelFriends.Text = "Common Friends";
            // 
            // m_ListBoxFriends
            // 
            this.m_ListBoxFriends.FormattingEnabled = true;
            this.m_ListBoxFriends.ItemHeight = 16;
            this.m_ListBoxFriends.Location = new System.Drawing.Point(752, 278);
            this.m_ListBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.m_ListBoxFriends.Name = "m_ListBoxFriends";
            this.m_ListBoxFriends.Size = new System.Drawing.Size(204, 244);
            this.m_ListBoxFriends.TabIndex = 11;
            this.m_ListBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // m_ListBoxBestMatch
            // 
            this.m_ListBoxBestMatch.FormattingEnabled = true;
            this.m_ListBoxBestMatch.ItemHeight = 16;
            this.m_ListBoxBestMatch.Location = new System.Drawing.Point(684, 24);
            this.m_ListBoxBestMatch.Margin = new System.Windows.Forms.Padding(4);
            this.m_ListBoxBestMatch.Name = "m_ListBoxBestMatch";
            this.m_ListBoxBestMatch.Size = new System.Drawing.Size(272, 164);
            this.m_ListBoxBestMatch.TabIndex = 14;
            this.m_ListBoxBestMatch.SelectedIndexChanged += new System.EventHandler(this.listBoxBestMatch_SelectedIndexChanged);
            // 
            // m_PictureBoxBestMatch
            // 
            this.m_PictureBoxBestMatch.Location = new System.Drawing.Point(861, 107);
            this.m_PictureBoxBestMatch.Margin = new System.Windows.Forms.Padding(4);
            this.m_PictureBoxBestMatch.Name = "m_PictureBoxBestMatch";
            this.m_PictureBoxBestMatch.Size = new System.Drawing.Size(93, 80);
            this.m_PictureBoxBestMatch.TabIndex = 15;
            this.m_PictureBoxBestMatch.TabStop = false;
            // 
            // m_LinkLabelLoverProfile
            // 
            this.m_LinkLabelLoverProfile.AutoSize = true;
            this.m_LinkLabelLoverProfile.Location = new System.Drawing.Point(503, 84);
            this.m_LinkLabelLoverProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LinkLabelLoverProfile.Name = "m_LinkLabelLoverProfile";
            this.m_LinkLabelLoverProfile.Size = new System.Drawing.Size(122, 17);
            this.m_LinkLabelLoverProfile.TabIndex = 16;
            this.m_LinkLabelLoverProfile.TabStop = true;
            this.m_LinkLabelLoverProfile.Text = "link for your Lover";
            this.m_LinkLabelLoverProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLoverProfile_LinkClicked);
            // 
            // m_LabelBestMatch
            // 
            this.m_LabelBestMatch.AutoSize = true;
            this.m_LabelBestMatch.Location = new System.Drawing.Point(503, 54);
            this.m_LabelBestMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LabelBestMatch.Name = "m_LabelBestMatch";
            this.m_LabelBestMatch.Size = new System.Drawing.Size(107, 17);
            this.m_LabelBestMatch.TabIndex = 17;
            this.m_LabelBestMatch.Text = "The Best Match";
            // 
            // m_LinkLabelCommonGroups
            // 
            this.m_LinkLabelCommonGroups.AutoSize = true;
            this.m_LinkLabelCommonGroups.Location = new System.Drawing.Point(94, 257);
            this.m_LinkLabelCommonGroups.Name = "m_LinkLabelCommonGroups";
            this.m_LinkLabelCommonGroups.Size = new System.Drawing.Size(90, 17);
            this.m_LinkLabelCommonGroups.TabIndex = 18;
            this.m_LinkLabelCommonGroups.TabStop = true;
            this.m_LinkLabelCommonGroups.Text = "See common";
            this.m_LinkLabelCommonGroups.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCommonGroups_LinkClicked);
            // 
            // m_LinkLabelCommonPages
            // 
            this.m_LinkLabelCommonPages.AutoSize = true;
            this.m_LinkLabelCommonPages.Location = new System.Drawing.Point(443, 257);
            this.m_LinkLabelCommonPages.Name = "m_LinkLabelCommonPages";
            this.m_LinkLabelCommonPages.Size = new System.Drawing.Size(90, 17);
            this.m_LinkLabelCommonPages.TabIndex = 19;
            this.m_LinkLabelCommonPages.TabStop = true;
            this.m_LinkLabelCommonPages.Text = "See common";
            this.m_LinkLabelCommonPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCommonPages_LinkClicked);
            // 
            // m_LinkLabelCommonFriends
            // 
            this.m_LinkLabelCommonFriends.AutoSize = true;
            this.m_LinkLabelCommonFriends.Location = new System.Drawing.Point(803, 257);
            this.m_LinkLabelCommonFriends.Name = "m_LinkLabelCommonFriends";
            this.m_LinkLabelCommonFriends.Size = new System.Drawing.Size(90, 17);
            this.m_LinkLabelCommonFriends.TabIndex = 20;
            this.m_LinkLabelCommonFriends.TabStop = true;
            this.m_LinkLabelCommonFriends.Text = "See common";
            this.m_LinkLabelCommonFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCommonFriends_LinkClicked);
            // 
            // m_ComboBoxGender
            // 
            this.m_ComboBoxGender.FormattingEnabled = true;
            this.m_ComboBoxGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.m_ComboBoxGender.Location = new System.Drawing.Point(111, 28);
            this.m_ComboBoxGender.Margin = new System.Windows.Forms.Padding(4);
            this.m_ComboBoxGender.Name = "m_ComboBoxGender";
            this.m_ComboBoxGender.Size = new System.Drawing.Size(160, 24);
            this.m_ComboBoxGender.TabIndex = 21;
            this.m_ComboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // FormBestMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.MostLikesForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 554);
            this.Controls.Add(this.m_ComboBoxGender);
            this.Controls.Add(this.m_LinkLabelCommonFriends);
            this.Controls.Add(this.m_LinkLabelCommonPages);
            this.Controls.Add(this.m_LinkLabelCommonGroups);
            this.Controls.Add(this.m_LabelBestMatch);
            this.Controls.Add(this.m_LinkLabelLoverProfile);
            this.Controls.Add(this.m_PictureBoxBestMatch);
            this.Controls.Add(this.m_ListBoxBestMatch);
            this.Controls.Add(this.m_PictureBoxFriends);
            this.Controls.Add(this.m_LabelFriends);
            this.Controls.Add(this.m_ListBoxFriends);
            this.Controls.Add(this.m_PictureBoxPages);
            this.Controls.Add(this.m_LabelPages);
            this.Controls.Add(this.m_ListBoxPages);
            this.Controls.Add(this.m_PictureBoxGroups);
            this.Controls.Add(this.m_LabelGroups);
            this.Controls.Add(this.m_ListBoxGroups);
            this.Controls.Add(this.m_ButtonSearchMatch);
            this.Controls.Add(this.m_LabelAge);
            this.Controls.Add(this.m_LabelGender);
            this.Controls.Add(this.m_ComboBoxAge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormBestMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Best Match";
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxBestMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox m_ComboBoxAge;
        private System.Windows.Forms.Label m_LabelGender;
        private System.Windows.Forms.Label m_LabelAge;
        private System.Windows.Forms.Button m_ButtonSearchMatch;
        private System.Windows.Forms.ListBox m_ListBoxGroups;
        private System.Windows.Forms.Label m_LabelGroups;
        private System.Windows.Forms.PictureBox m_PictureBoxGroups;
        private System.Windows.Forms.PictureBox m_PictureBoxPages;
        private System.Windows.Forms.Label m_LabelPages;
        private System.Windows.Forms.ListBox m_ListBoxPages;
        private System.Windows.Forms.PictureBox m_PictureBoxFriends;
        private System.Windows.Forms.Label m_LabelFriends;
        private System.Windows.Forms.ListBox m_ListBoxFriends;
        private System.Windows.Forms.ListBox m_ListBoxBestMatch;
        private System.Windows.Forms.PictureBox m_PictureBoxBestMatch;
        private System.Windows.Forms.LinkLabel m_LinkLabelLoverProfile;
        private System.Windows.Forms.Label m_LabelBestMatch;
        private System.Windows.Forms.LinkLabel m_LinkLabelCommonGroups;
        private System.Windows.Forms.LinkLabel m_LinkLabelCommonPages;
        private System.Windows.Forms.LinkLabel m_LinkLabelCommonFriends;
        private ComboBox m_ComboBoxGender;
    }
}
