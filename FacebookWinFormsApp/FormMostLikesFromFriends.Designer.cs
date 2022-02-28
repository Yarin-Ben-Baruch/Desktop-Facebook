using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMostLikesFromFriends
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
            this.m_ListBoxMostLikesPhotos = new System.Windows.Forms.ListBox();
            this.m_PictureBoxSelectedFriendPhoto = new System.Windows.Forms.PictureBox();
            this.m_ListBoxMostLikesPosts = new System.Windows.Forms.ListBox();
            this.m_PictureBoxSelectedFriendPost = new System.Windows.Forms.PictureBox();
            this.m_PictureBoxSelectedFriendComment = new System.Windows.Forms.PictureBox();
            this.m_ListBoxMostComments = new System.Windows.Forms.ListBox();
            this.m_ButtonMostLikesOnPhotos = new System.Windows.Forms.Button();
            this.m_ButtonMostComments = new System.Windows.Forms.Button();
            this.m_ButtonMostLikesOnPosts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedFriendPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedFriendPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedFriendComment)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ListBoxMostLikesPhotos
            // 
            this.m_ListBoxMostLikesPhotos.FormattingEnabled = true;
            this.m_ListBoxMostLikesPhotos.ItemHeight = 25;
            this.m_ListBoxMostLikesPhotos.Location = new System.Drawing.Point(62, 140);
            this.m_ListBoxMostLikesPhotos.Margin = new System.Windows.Forms.Padding(6);
            this.m_ListBoxMostLikesPhotos.Name = "m_ListBoxMostLikesPhotos";
            this.m_ListBoxMostLikesPhotos.Size = new System.Drawing.Size(324, 379);
            this.m_ListBoxMostLikesPhotos.TabIndex = 1;
            this.m_ListBoxMostLikesPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxMostLikesPhotos_SelectedIndexChanged);
            // 
            // m_PictureBoxSelectedFriendPhoto
            // 
            this.m_PictureBoxSelectedFriendPhoto.Location = new System.Drawing.Point(220, 367);
            this.m_PictureBoxSelectedFriendPhoto.Margin = new System.Windows.Forms.Padding(6);
            this.m_PictureBoxSelectedFriendPhoto.Name = "m_PictureBoxSelectedFriendPhoto";
            this.m_PictureBoxSelectedFriendPhoto.Size = new System.Drawing.Size(166, 153);
            this.m_PictureBoxSelectedFriendPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxSelectedFriendPhoto.TabIndex = 2;
            this.m_PictureBoxSelectedFriendPhoto.TabStop = false;
            // 
            // m_ListBoxMostLikesPosts
            // 
            this.m_ListBoxMostLikesPosts.FormattingEnabled = true;
            this.m_ListBoxMostLikesPosts.ItemHeight = 25;
            this.m_ListBoxMostLikesPosts.Location = new System.Drawing.Point(568, 140);
            this.m_ListBoxMostLikesPosts.Margin = new System.Windows.Forms.Padding(6);
            this.m_ListBoxMostLikesPosts.Name = "m_ListBoxMostLikesPosts";
            this.m_ListBoxMostLikesPosts.Size = new System.Drawing.Size(318, 379);
            this.m_ListBoxMostLikesPosts.TabIndex = 4;
            this.m_ListBoxMostLikesPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxMostLikesPosts_SelectedIndexChanged);
            // 
            // m_PictureBoxSelectedFriendPost
            // 
            this.m_PictureBoxSelectedFriendPost.Location = new System.Drawing.Point(732, 367);
            this.m_PictureBoxSelectedFriendPost.Margin = new System.Windows.Forms.Padding(6);
            this.m_PictureBoxSelectedFriendPost.Name = "m_PictureBoxSelectedFriendPost";
            this.m_PictureBoxSelectedFriendPost.Size = new System.Drawing.Size(152, 153);
            this.m_PictureBoxSelectedFriendPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxSelectedFriendPost.TabIndex = 5;
            this.m_PictureBoxSelectedFriendPost.TabStop = false;
            // 
            // m_PictureBoxSelectedFriendComment
            // 
            this.m_PictureBoxSelectedFriendComment.Location = new System.Drawing.Point(1229, 367);
            this.m_PictureBoxSelectedFriendComment.Margin = new System.Windows.Forms.Padding(6);
            this.m_PictureBoxSelectedFriendComment.Name = "m_PictureBoxSelectedFriendComment";
            this.m_PictureBoxSelectedFriendComment.Size = new System.Drawing.Size(152, 153);
            this.m_PictureBoxSelectedFriendComment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxSelectedFriendComment.TabIndex = 8;
            this.m_PictureBoxSelectedFriendComment.TabStop = false;
            // 
            // m_ListBoxMostComments
            // 
            this.m_ListBoxMostComments.FormattingEnabled = true;
            this.m_ListBoxMostComments.ItemHeight = 25;
            this.m_ListBoxMostComments.Location = new System.Drawing.Point(1065, 140);
            this.m_ListBoxMostComments.Margin = new System.Windows.Forms.Padding(6);
            this.m_ListBoxMostComments.Name = "m_ListBoxMostComments";
            this.m_ListBoxMostComments.Size = new System.Drawing.Size(318, 379);
            this.m_ListBoxMostComments.TabIndex = 7;
            this.m_ListBoxMostComments.SelectedIndexChanged += new System.EventHandler(this.listBoxMostComments_SelectedIndexChanged);
            // 
            // m_ButtonMostLikesOnPhotos
            // 
            this.m_ButtonMostLikesOnPhotos.Location = new System.Drawing.Point(106, 78);
            this.m_ButtonMostLikesOnPhotos.Name = "m_ButtonMostLikesOnPhotos";
            this.m_ButtonMostLikesOnPhotos.Size = new System.Drawing.Size(233, 42);
            this.m_ButtonMostLikesOnPhotos.TabIndex = 9;
            this.m_ButtonMostLikesOnPhotos.Text = "Most likes on photos";
            this.m_ButtonMostLikesOnPhotos.UseVisualStyleBackColor = true;
            this.m_ButtonMostLikesOnPhotos.Click += new System.EventHandler(this.buttonMostLikesOnPhotos_Click);
            // 
            // m_ButtonMostComments
            // 
            this.m_ButtonMostComments.Location = new System.Drawing.Point(1075, 78);
            this.m_ButtonMostComments.Name = "m_ButtonMostComments";
            this.m_ButtonMostComments.Size = new System.Drawing.Size(294, 42);
            this.m_ButtonMostComments.TabIndex = 10;
            this.m_ButtonMostComments.Text = "Most comments on photos";
            this.m_ButtonMostComments.UseVisualStyleBackColor = true;
            this.m_ButtonMostComments.Click += new System.EventHandler(this.buttonMostComments_Click);
            // 
            // m_ButtonMostLikesOnPosts
            // 
            this.m_ButtonMostLikesOnPosts.Location = new System.Drawing.Point(602, 78);
            this.m_ButtonMostLikesOnPosts.Name = "m_ButtonMostLikesOnPosts";
            this.m_ButtonMostLikesOnPosts.Size = new System.Drawing.Size(233, 42);
            this.m_ButtonMostLikesOnPosts.TabIndex = 11;
            this.m_ButtonMostLikesOnPosts.Text = "Most likes on posts";
            this.m_ButtonMostLikesOnPosts.UseVisualStyleBackColor = true;
            this.m_ButtonMostLikesOnPosts.Click += new System.EventHandler(this.m_ButtonMostLikesOnPosts_Click);
            // 
            // FormMostLikesFromFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.MostLikesForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1428, 616);
            this.Controls.Add(this.m_ButtonMostLikesOnPosts);
            this.Controls.Add(this.m_ButtonMostComments);
            this.Controls.Add(this.m_ButtonMostLikesOnPhotos);
            this.Controls.Add(this.m_PictureBoxSelectedFriendComment);
            this.Controls.Add(this.m_ListBoxMostComments);
            this.Controls.Add(this.m_PictureBoxSelectedFriendPost);
            this.Controls.Add(this.m_ListBoxMostLikesPosts);
            this.Controls.Add(this.m_PictureBoxSelectedFriendPhoto);
            this.Controls.Add(this.m_ListBoxMostLikesPhotos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormMostLikesFromFriends";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Who did the most likes";
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedFriendPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedFriendPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedFriendComment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox m_ListBoxMostLikesPhotos;
        private System.Windows.Forms.PictureBox m_PictureBoxSelectedFriendPhoto;
        private System.Windows.Forms.ListBox m_ListBoxMostLikesPosts;
        private PictureBox m_PictureBoxSelectedFriendPost;
        private PictureBox m_PictureBoxSelectedFriendComment;
        private ListBox m_ListBoxMostComments;
        private Button m_ButtonMostLikesOnPhotos;
        private Button m_ButtonMostComments;
        private Button m_ButtonMostLikesOnPosts;
    }
}
