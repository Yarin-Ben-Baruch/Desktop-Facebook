﻿
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FormMostLikesFromFriends
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
            this.m_LabelMostLikesOnPhotos = new System.Windows.Forms.Label();
            this.m_ListBoxMostLikesPhotos = new System.Windows.Forms.ListBox();
            this.m_PictureBoxSelectedFriendPhoto = new System.Windows.Forms.PictureBox();
            this.m_ListBoxMostLikesPosts = new System.Windows.Forms.ListBox();
            this.m_LabelMostLikesOnPosts = new System.Windows.Forms.Label();
            this.m_PictureBoxSelectedFriendPost = new System.Windows.Forms.PictureBox();
            this.m_PictureBoxSelectedFriendComment = new System.Windows.Forms.PictureBox();
            this.m_ListBoxMostComments = new System.Windows.Forms.ListBox();
            this.m_LabelMostCommentsOnPosts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedFriendPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedFriendPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedFriendComment)).BeginInit();
            this.SuspendLayout();
            // 
            // m_LabelMostLikesOnPhotos
            // 
            this.m_LabelMostLikesOnPhotos.AutoSize = true;
            this.m_LabelMostLikesOnPhotos.Location = new System.Drawing.Point(128, 55);
            this.m_LabelMostLikesOnPhotos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_LabelMostLikesOnPhotos.Name = "m_LabelMostLikesOnPhotos";
            this.m_LabelMostLikesOnPhotos.Size = new System.Drawing.Size(210, 25);
            this.m_LabelMostLikesOnPhotos.TabIndex = 0;
            this.m_LabelMostLikesOnPhotos.Text = "Most likes on photos";
            this.m_LabelMostLikesOnPhotos.Click += new System.EventHandler(this.labelMostLikesOnPhotos_Click);
            // 
            // m_ListBoxMostLikesPhotos
            // 
            this.m_ListBoxMostLikesPhotos.FormattingEnabled = true;
            this.m_ListBoxMostLikesPhotos.ItemHeight = 25;
            this.m_ListBoxMostLikesPhotos.Location = new System.Drawing.Point(62, 118);
            this.m_ListBoxMostLikesPhotos.Margin = new System.Windows.Forms.Padding(6);
            this.m_ListBoxMostLikesPhotos.Name = "m_ListBoxMostLikesPhotos";
            this.m_ListBoxMostLikesPhotos.Size = new System.Drawing.Size(324, 379);
            this.m_ListBoxMostLikesPhotos.TabIndex = 1;
            this.m_ListBoxMostLikesPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxMostLikesPhotos_SelectedIndexChanged);
            // 
            // m_PictureBoxSelectedFriendPhoto
            // 
            this.m_PictureBoxSelectedFriendPhoto.Location = new System.Drawing.Point(220, 345);
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
            this.m_ListBoxMostLikesPosts.Location = new System.Drawing.Point(568, 118);
            this.m_ListBoxMostLikesPosts.Margin = new System.Windows.Forms.Padding(6);
            this.m_ListBoxMostLikesPosts.Name = "m_ListBoxMostLikesPosts";
            this.m_ListBoxMostLikesPosts.Size = new System.Drawing.Size(318, 379);
            this.m_ListBoxMostLikesPosts.TabIndex = 4;
            // 
            // m_LabelMostLikesOnPosts
            // 
            this.m_LabelMostLikesOnPosts.AutoSize = true;
            this.m_LabelMostLikesOnPosts.Location = new System.Drawing.Point(628, 55);
            this.m_LabelMostLikesOnPosts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_LabelMostLikesOnPosts.Name = "m_LabelMostLikesOnPosts";
            this.m_LabelMostLikesOnPosts.Size = new System.Drawing.Size(197, 25);
            this.m_LabelMostLikesOnPosts.TabIndex = 3;
            this.m_LabelMostLikesOnPosts.Text = "Most likes on posts";
            this.m_LabelMostLikesOnPosts.Click += new System.EventHandler(this.labelMostLikesOnPosts_Click);
            // 
            // m_PictureBoxSelectedFriendPost
            // 
            this.m_PictureBoxSelectedFriendPost.Location = new System.Drawing.Point(732, 345);
            this.m_PictureBoxSelectedFriendPost.Margin = new System.Windows.Forms.Padding(6);
            this.m_PictureBoxSelectedFriendPost.Name = "m_PictureBoxSelectedFriendPost";
            this.m_PictureBoxSelectedFriendPost.Size = new System.Drawing.Size(152, 153);
            this.m_PictureBoxSelectedFriendPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxSelectedFriendPost.TabIndex = 5;
            this.m_PictureBoxSelectedFriendPost.TabStop = false;
            // 
            // m_PictureBoxSelectedFriendComment
            // 
            this.m_PictureBoxSelectedFriendComment.Location = new System.Drawing.Point(1229, 345);
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
            this.m_ListBoxMostComments.Location = new System.Drawing.Point(1065, 118);
            this.m_ListBoxMostComments.Margin = new System.Windows.Forms.Padding(6);
            this.m_ListBoxMostComments.Name = "m_ListBoxMostComments";
            this.m_ListBoxMostComments.Size = new System.Drawing.Size(318, 379);
            this.m_ListBoxMostComments.TabIndex = 7;
            this.m_ListBoxMostComments.SelectedIndexChanged += new System.EventHandler(this.m_ListBoxMostComments_SelectedIndexChanged);
            // 
            // m_LabelMostCommentsOnPosts
            // 
            this.m_LabelMostCommentsOnPosts.AutoSize = true;
            this.m_LabelMostCommentsOnPosts.Location = new System.Drawing.Point(1095, 55);
            this.m_LabelMostCommentsOnPosts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_LabelMostCommentsOnPosts.Name = "m_LabelMostCommentsOnPosts";
            this.m_LabelMostCommentsOnPosts.Size = new System.Drawing.Size(264, 25);
            this.m_LabelMostCommentsOnPosts.TabIndex = 6;
            this.m_LabelMostCommentsOnPosts.Text = "Most comments on photos";
            this.m_LabelMostCommentsOnPosts.Click += new System.EventHandler(this.m_LabelMostCommentsOnPosts_Click);
            // 
            // FormMostLikesFromFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.MostLikesForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1428, 616);
            this.Controls.Add(this.m_PictureBoxSelectedFriendComment);
            this.Controls.Add(this.m_ListBoxMostComments);
            this.Controls.Add(this.m_LabelMostCommentsOnPosts);
            this.Controls.Add(this.m_PictureBoxSelectedFriendPost);
            this.Controls.Add(this.m_ListBoxMostLikesPosts);
            this.Controls.Add(this.m_LabelMostLikesOnPosts);
            this.Controls.Add(this.m_PictureBoxSelectedFriendPhoto);
            this.Controls.Add(this.m_ListBoxMostLikesPhotos);
            this.Controls.Add(this.m_LabelMostLikesOnPhotos);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LabelMostLikesOnPhotos;
        private System.Windows.Forms.ListBox m_ListBoxMostLikesPhotos;
        private System.Windows.Forms.PictureBox m_PictureBoxSelectedFriendPhoto;
        private System.Windows.Forms.ListBox m_ListBoxMostLikesPosts;
        private System.Windows.Forms.Label m_LabelMostLikesOnPosts;
        private PictureBox m_PictureBoxSelectedFriendPost;
        private PictureBox m_PictureBoxSelectedFriendComment;
        private ListBox m_ListBoxMostComments;
        private Label m_LabelMostCommentsOnPosts;
    }
}
