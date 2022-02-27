using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMain
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
            this.m_ButtonLogin = new System.Windows.Forms.Button();
            this.m_ButtonLogout = new System.Windows.Forms.Button();
            this.m_PictureBoxProfilePhoto = new System.Windows.Forms.PictureBox();
            this.m_LabelFullName = new System.Windows.Forms.Label();
            this.m_LabelBirthday = new System.Windows.Forms.Label();
            this.m_ButtonBestMatch = new System.Windows.Forms.Button();
            this.m_ButtonMostLikesFromFriends = new System.Windows.Forms.Button();
            this.m_ListBoxPopularPhotos = new System.Windows.Forms.ListBox();
            this.m_PictureBoxSelectedPopularPhoto = new System.Windows.Forms.PictureBox();
            this.m_ButtonPopularPhotos = new System.Windows.Forms.Button();
            this.m_LabelNumberOfLikes = new System.Windows.Forms.Label();
            this.m_ButtonFindMyFriendsCities = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxProfilePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedPopularPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ButtonLogin
            // 
            this.m_ButtonLogin.BackColor = System.Drawing.Color.White;
            this.m_ButtonLogin.Location = new System.Drawing.Point(579, 29);
            this.m_ButtonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_ButtonLogin.Name = "m_ButtonLogin";
            this.m_ButtonLogin.Size = new System.Drawing.Size(239, 28);
            this.m_ButtonLogin.TabIndex = 36;
            this.m_ButtonLogin.Text = "Login";
            this.m_ButtonLogin.UseVisualStyleBackColor = false;
            this.m_ButtonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // m_ButtonLogout
            // 
            this.m_ButtonLogout.BackColor = System.Drawing.Color.White;
            this.m_ButtonLogout.Location = new System.Drawing.Point(579, 69);
            this.m_ButtonLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_ButtonLogout.Name = "m_ButtonLogout";
            this.m_ButtonLogout.Size = new System.Drawing.Size(239, 28);
            this.m_ButtonLogout.TabIndex = 52;
            this.m_ButtonLogout.Text = "Logout";
            this.m_ButtonLogout.UseVisualStyleBackColor = false;
            this.m_ButtonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // m_PictureBoxProfilePhoto
            // 
            this.m_PictureBoxProfilePhoto.BackColor = System.Drawing.Color.White;
            this.m_PictureBoxProfilePhoto.Location = new System.Drawing.Point(15, 15);
            this.m_PictureBoxProfilePhoto.Name = "m_PictureBoxProfilePhoto";
            this.m_PictureBoxProfilePhoto.Size = new System.Drawing.Size(211, 160);
            this.m_PictureBoxProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxProfilePhoto.TabIndex = 53;
            this.m_PictureBoxProfilePhoto.TabStop = false;
            // 
            // m_LabelFullName
            // 
            this.m_LabelFullName.AutoSize = true;
            this.m_LabelFullName.BackColor = System.Drawing.Color.White;
            this.m_LabelFullName.Location = new System.Drawing.Point(248, 36);
            this.m_LabelFullName.Name = "m_LabelFullName";
            this.m_LabelFullName.Size = new System.Drawing.Size(69, 17);
            this.m_LabelFullName.TabIndex = 54;
            this.m_LabelFullName.Text = "Full name";
            // 
            // m_LabelBirthday
            // 
            this.m_LabelBirthday.AutoSize = true;
            this.m_LabelBirthday.BackColor = System.Drawing.Color.White;
            this.m_LabelBirthday.Location = new System.Drawing.Point(248, 75);
            this.m_LabelBirthday.Name = "m_LabelBirthday";
            this.m_LabelBirthday.Size = new System.Drawing.Size(60, 17);
            this.m_LabelBirthday.TabIndex = 55;
            this.m_LabelBirthday.Text = "Birthday";
            // 
            // m_ButtonBestMatch
            // 
            this.m_ButtonBestMatch.BackColor = System.Drawing.Color.White;
            this.m_ButtonBestMatch.Location = new System.Drawing.Point(44, 310);
            this.m_ButtonBestMatch.Name = "m_ButtonBestMatch";
            this.m_ButtonBestMatch.Size = new System.Drawing.Size(152, 56);
            this.m_ButtonBestMatch.TabIndex = 56;
            this.m_ButtonBestMatch.Text = "Find best match";
            this.m_ButtonBestMatch.UseVisualStyleBackColor = false;
            this.m_ButtonBestMatch.Click += new System.EventHandler(this.buttonBestMatch_Click);
            // 
            // m_ButtonMostLikesFromFriends
            // 
            this.m_ButtonMostLikesFromFriends.BackColor = System.Drawing.Color.White;
            this.m_ButtonMostLikesFromFriends.Location = new System.Drawing.Point(44, 223);
            this.m_ButtonMostLikesFromFriends.Name = "m_ButtonMostLikesFromFriends";
            this.m_ButtonMostLikesFromFriends.Size = new System.Drawing.Size(152, 56);
            this.m_ButtonMostLikesFromFriends.TabIndex = 57;
            this.m_ButtonMostLikesFromFriends.Text = "My loyal friend";
            this.m_ButtonMostLikesFromFriends.UseVisualStyleBackColor = false;
            this.m_ButtonMostLikesFromFriends.Click += new System.EventHandler(this.buttonMostLikesFromFriends_Click);
            // 
            // m_ListBoxPopularPhotos
            // 
            this.m_ListBoxPopularPhotos.BackColor = System.Drawing.Color.White;
            this.m_ListBoxPopularPhotos.FormattingEnabled = true;
            this.m_ListBoxPopularPhotos.ItemHeight = 16;
            this.m_ListBoxPopularPhotos.Location = new System.Drawing.Point(560, 223);
            this.m_ListBoxPopularPhotos.Name = "m_ListBoxPopularPhotos";
            this.m_ListBoxPopularPhotos.Size = new System.Drawing.Size(259, 228);
            this.m_ListBoxPopularPhotos.TabIndex = 58;
            this.m_ListBoxPopularPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxPopularPhotos_SelectedIndexChanged);
            // 
            // m_PictureBoxSelectedPopularPhoto
            // 
            this.m_PictureBoxSelectedPopularPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_PictureBoxSelectedPopularPhoto.Location = new System.Drawing.Point(719, 352);
            this.m_PictureBoxSelectedPopularPhoto.Name = "m_PictureBoxSelectedPopularPhoto";
            this.m_PictureBoxSelectedPopularPhoto.Size = new System.Drawing.Size(99, 97);
            this.m_PictureBoxSelectedPopularPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxSelectedPopularPhoto.TabIndex = 59;
            this.m_PictureBoxSelectedPopularPhoto.TabStop = false;
            // 
            // m_ButtonPopularPhotos
            // 
            this.m_ButtonPopularPhotos.BackColor = System.Drawing.Color.White;
            this.m_ButtonPopularPhotos.Location = new System.Drawing.Point(560, 186);
            this.m_ButtonPopularPhotos.Name = "m_ButtonPopularPhotos";
            this.m_ButtonPopularPhotos.Size = new System.Drawing.Size(157, 32);
            this.m_ButtonPopularPhotos.TabIndex = 60;
            this.m_ButtonPopularPhotos.Text = "My popular photos";
            this.m_ButtonPopularPhotos.UseVisualStyleBackColor = false;
            this.m_ButtonPopularPhotos.Click += new System.EventHandler(this.buttonPopularPhotos_Click);
            // 
            // m_LabelNumberOfLikes
            // 
            this.m_LabelNumberOfLikes.AutoSize = true;
            this.m_LabelNumberOfLikes.Location = new System.Drawing.Point(728, 194);
            this.m_LabelNumberOfLikes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LabelNumberOfLikes.Name = "m_LabelNumberOfLikes";
            this.m_LabelNumberOfLikes.Size = new System.Drawing.Size(45, 17);
            this.m_LabelNumberOfLikes.TabIndex = 61;
            this.m_LabelNumberOfLikes.Text = "Likes:";
            // 
            // m_ButtonFindMyFriendsCities
            // 
            this.m_ButtonFindMyFriendsCities.BackColor = System.Drawing.Color.White;
            this.m_ButtonFindMyFriendsCities.Location = new System.Drawing.Point(44, 393);
            this.m_ButtonFindMyFriendsCities.Name = "m_ButtonFindMyFriendsCities";
            this.m_ButtonFindMyFriendsCities.Size = new System.Drawing.Size(152, 56);
            this.m_ButtonFindMyFriendsCities.TabIndex = 62;
            this.m_ButtonFindMyFriendsCities.Text = "Where all my friends";
            this.m_ButtonFindMyFriendsCities.UseVisualStyleBackColor = false;
            this.m_ButtonFindMyFriendsCities.Click += new System.EventHandler(this.buttonFindMyFriendsCities_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 465);
            this.Controls.Add(this.m_ButtonFindMyFriendsCities);
            this.Controls.Add(this.m_LabelNumberOfLikes);
            this.Controls.Add(this.m_ButtonPopularPhotos);
            this.Controls.Add(this.m_PictureBoxSelectedPopularPhoto);
            this.Controls.Add(this.m_ListBoxPopularPhotos);
            this.Controls.Add(this.m_ButtonMostLikesFromFriends);
            this.Controls.Add(this.m_ButtonBestMatch);
            this.Controls.Add(this.m_LabelBirthday);
            this.Controls.Add(this.m_LabelFullName);
            this.Controls.Add(this.m_PictureBoxProfilePhoto);
            this.Controls.Add(this.m_ButtonLogout);
            this.Controls.Add(this.m_ButtonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacebookApp";
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxProfilePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedPopularPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_ButtonLogin;
        private System.Windows.Forms.Button m_ButtonLogout;
        private System.Windows.Forms.PictureBox m_PictureBoxProfilePhoto;
        private System.Windows.Forms.Label m_LabelFullName;
        private System.Windows.Forms.Label m_LabelBirthday;
        private System.Windows.Forms.Button m_ButtonBestMatch;
        private System.Windows.Forms.Button m_ButtonMostLikesFromFriends;
        private System.Windows.Forms.ListBox m_ListBoxPopularPhotos;
        private System.Windows.Forms.PictureBox m_PictureBoxSelectedPopularPhoto;
        private System.Windows.Forms.Button m_ButtonPopularPhotos;
        private Label m_LabelNumberOfLikes;
        private Button m_ButtonFindMyFriendsCities;
    }
}