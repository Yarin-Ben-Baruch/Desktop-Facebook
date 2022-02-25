using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FormMain
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
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxProfilePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedPopularPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ButtonLogin
            // 
            this.m_ButtonLogin.BackColor = System.Drawing.Color.White;
            this.m_ButtonLogin.Location = new System.Drawing.Point(868, 46);
            this.m_ButtonLogin.Margin = new System.Windows.Forms.Padding(6);
            this.m_ButtonLogin.Name = "m_ButtonLogin";
            this.m_ButtonLogin.Size = new System.Drawing.Size(358, 44);
            this.m_ButtonLogin.TabIndex = 36;
            this.m_ButtonLogin.Text = "Login";
            this.m_ButtonLogin.UseVisualStyleBackColor = false;
            this.m_ButtonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // m_ButtonLogout
            // 
            this.m_ButtonLogout.BackColor = System.Drawing.Color.White;
            this.m_ButtonLogout.Location = new System.Drawing.Point(868, 108);
            this.m_ButtonLogout.Margin = new System.Windows.Forms.Padding(6);
            this.m_ButtonLogout.Name = "m_ButtonLogout";
            this.m_ButtonLogout.Size = new System.Drawing.Size(358, 44);
            this.m_ButtonLogout.TabIndex = 52;
            this.m_ButtonLogout.Text = "Logout";
            this.m_ButtonLogout.UseVisualStyleBackColor = false;
            this.m_ButtonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // m_PictureBoxProfilePhoto
            // 
            this.m_PictureBoxProfilePhoto.BackColor = System.Drawing.Color.White;
            this.m_PictureBoxProfilePhoto.Location = new System.Drawing.Point(22, 23);
            this.m_PictureBoxProfilePhoto.Margin = new System.Windows.Forms.Padding(4);
            this.m_PictureBoxProfilePhoto.Name = "m_PictureBoxProfilePhoto";
            this.m_PictureBoxProfilePhoto.Size = new System.Drawing.Size(316, 250);
            this.m_PictureBoxProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxProfilePhoto.TabIndex = 53;
            this.m_PictureBoxProfilePhoto.TabStop = false;
            // 
            // m_LabelFullName
            // 
            this.m_LabelFullName.AutoSize = true;
            this.m_LabelFullName.BackColor = System.Drawing.Color.White;
            this.m_LabelFullName.Location = new System.Drawing.Point(372, 56);
            this.m_LabelFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LabelFullName.Name = "m_LabelFullName";
            this.m_LabelFullName.Size = new System.Drawing.Size(106, 25);
            this.m_LabelFullName.TabIndex = 54;
            this.m_LabelFullName.Text = "Full name";
            // 
            // m_LabelBirthday
            // 
            this.m_LabelBirthday.AutoSize = true;
            this.m_LabelBirthday.BackColor = System.Drawing.Color.White;
            this.m_LabelBirthday.Location = new System.Drawing.Point(372, 117);
            this.m_LabelBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LabelBirthday.Name = "m_LabelBirthday";
            this.m_LabelBirthday.Size = new System.Drawing.Size(91, 25);
            this.m_LabelBirthday.TabIndex = 55;
            this.m_LabelBirthday.Text = "Birthday";
            // 
            // m_ButtonBestMatch
            // 
            this.m_ButtonBestMatch.BackColor = System.Drawing.Color.White;
            this.m_ButtonBestMatch.Location = new System.Drawing.Point(66, 575);
            this.m_ButtonBestMatch.Margin = new System.Windows.Forms.Padding(4);
            this.m_ButtonBestMatch.Name = "m_ButtonBestMatch";
            this.m_ButtonBestMatch.Size = new System.Drawing.Size(228, 88);
            this.m_ButtonBestMatch.TabIndex = 56;
            this.m_ButtonBestMatch.Text = "Find best match";
            this.m_ButtonBestMatch.UseVisualStyleBackColor = false;
            this.m_ButtonBestMatch.Click += new System.EventHandler(this.m_ButtonBestMatch_Click);
            // 
            // m_ButtonMostLikesFromFriends
            // 
            this.m_ButtonMostLikesFromFriends.BackColor = System.Drawing.Color.White;
            this.m_ButtonMostLikesFromFriends.Location = new System.Drawing.Point(66, 387);
            this.m_ButtonMostLikesFromFriends.Margin = new System.Windows.Forms.Padding(4);
            this.m_ButtonMostLikesFromFriends.Name = "m_ButtonMostLikesFromFriends";
            this.m_ButtonMostLikesFromFriends.Size = new System.Drawing.Size(228, 88);
            this.m_ButtonMostLikesFromFriends.TabIndex = 57;
            this.m_ButtonMostLikesFromFriends.Text = "My loyal friend";
            this.m_ButtonMostLikesFromFriends.UseVisualStyleBackColor = false;
            this.m_ButtonMostLikesFromFriends.Click += new System.EventHandler(this.m_ButtonMostLikesFromFriends_Click);
            // 
            // m_ListBoxPopularPhotos
            // 
            this.m_ListBoxPopularPhotos.BackColor = System.Drawing.Color.White;
            this.m_ListBoxPopularPhotos.FormattingEnabled = true;
            this.m_ListBoxPopularPhotos.ItemHeight = 25;
            this.m_ListBoxPopularPhotos.Location = new System.Drawing.Point(840, 348);
            this.m_ListBoxPopularPhotos.Margin = new System.Windows.Forms.Padding(4);
            this.m_ListBoxPopularPhotos.Name = "m_ListBoxPopularPhotos";
            this.m_ListBoxPopularPhotos.Size = new System.Drawing.Size(386, 354);
            this.m_ListBoxPopularPhotos.TabIndex = 58;
            this.m_ListBoxPopularPhotos.SelectedIndexChanged += new System.EventHandler(this.m_ListBoxPopularPhotos_SelectedIndexChanged);
            // 
            // m_PictureBoxSelectedPopularPhoto
            // 
            this.m_PictureBoxSelectedPopularPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_PictureBoxSelectedPopularPhoto.Location = new System.Drawing.Point(1078, 550);
            this.m_PictureBoxSelectedPopularPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxSelectedPopularPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.m_PictureBoxSelectedPopularPhoto.Name = "m_PictureBoxSelectedPopularPhoto";
            this.m_PictureBoxSelectedPopularPhoto.Size = new System.Drawing.Size(148, 152);
            this.m_PictureBoxSelectedPopularPhoto.TabIndex = 59;
            this.m_PictureBoxSelectedPopularPhoto.TabStop = false;
            // 
            // m_ButtonPopularPhotos
            // 
            this.m_ButtonPopularPhotos.BackColor = System.Drawing.Color.White;
            this.m_ButtonPopularPhotos.Location = new System.Drawing.Point(910, 290);
            this.m_ButtonPopularPhotos.Margin = new System.Windows.Forms.Padding(4);
            this.m_ButtonPopularPhotos.Name = "m_ButtonPopularPhotos";
            this.m_ButtonPopularPhotos.Size = new System.Drawing.Size(236, 50);
            this.m_ButtonPopularPhotos.TabIndex = 60;
            this.m_ButtonPopularPhotos.Text = "My popular photos";
            this.m_ButtonPopularPhotos.UseVisualStyleBackColor = false;
            this.m_ButtonPopularPhotos.Click += new System.EventHandler(this.m_ButtonPopularPhotos_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 727);
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
            this.Margin = new System.Windows.Forms.Padding(6);
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
	}
}

