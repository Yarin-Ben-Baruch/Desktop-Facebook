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
            this.m_ListBoxLoyalFriends = new System.Windows.Forms.ListBox();
            this.m_ButtonSearchLoyalFriends = new System.Windows.Forms.Button();
            this.m_PictureBoxLoyalFriends = new System.Windows.Forms.PictureBox();
            this.m_LabelLoyalFriends = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedFriendPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedFriendPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedFriendComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxLoyalFriends)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ListBoxMostLikesPhotos
            // 
            this.m_ListBoxMostLikesPhotos.FormattingEnabled = true;
            this.m_ListBoxMostLikesPhotos.ItemHeight = 25;
            this.m_ListBoxMostLikesPhotos.Location = new System.Drawing.Point(52, 471);
            this.m_ListBoxMostLikesPhotos.Margin = new System.Windows.Forms.Padding(6);
            this.m_ListBoxMostLikesPhotos.Name = "m_ListBoxMostLikesPhotos";
            this.m_ListBoxMostLikesPhotos.Size = new System.Drawing.Size(324, 379);
            this.m_ListBoxMostLikesPhotos.TabIndex = 1;
            this.m_ListBoxMostLikesPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxMostLikesPhotos_SelectedIndexChanged);
            // 
            // m_PictureBoxSelectedFriendPhoto
            // 
            this.m_PictureBoxSelectedFriendPhoto.Location = new System.Drawing.Point(210, 697);
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
            this.m_ListBoxMostLikesPosts.Location = new System.Drawing.Point(514, 471);
            this.m_ListBoxMostLikesPosts.Margin = new System.Windows.Forms.Padding(6);
            this.m_ListBoxMostLikesPosts.Name = "m_ListBoxMostLikesPosts";
            this.m_ListBoxMostLikesPosts.Size = new System.Drawing.Size(318, 379);
            this.m_ListBoxMostLikesPosts.TabIndex = 4;
            this.m_ListBoxMostLikesPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxMostLikesPosts_SelectedIndexChanged);
            // 
            // m_PictureBoxSelectedFriendPost
            // 
            this.m_PictureBoxSelectedFriendPost.Location = new System.Drawing.Point(680, 697);
            this.m_PictureBoxSelectedFriendPost.Margin = new System.Windows.Forms.Padding(6);
            this.m_PictureBoxSelectedFriendPost.Name = "m_PictureBoxSelectedFriendPost";
            this.m_PictureBoxSelectedFriendPost.Size = new System.Drawing.Size(152, 153);
            this.m_PictureBoxSelectedFriendPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxSelectedFriendPost.TabIndex = 5;
            this.m_PictureBoxSelectedFriendPost.TabStop = false;
            // 
            // m_PictureBoxSelectedFriendComment
            // 
            this.m_PictureBoxSelectedFriendComment.Location = new System.Drawing.Point(1138, 697);
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
            this.m_ListBoxMostComments.Location = new System.Drawing.Point(975, 471);
            this.m_ListBoxMostComments.Margin = new System.Windows.Forms.Padding(6);
            this.m_ListBoxMostComments.Name = "m_ListBoxMostComments";
            this.m_ListBoxMostComments.Size = new System.Drawing.Size(318, 379);
            this.m_ListBoxMostComments.TabIndex = 7;
            this.m_ListBoxMostComments.SelectedIndexChanged += new System.EventHandler(this.listBoxMostComments_SelectedIndexChanged);
            // 
            // m_ListBoxLoyalFriends
            // 
            this.m_ListBoxLoyalFriends.FormattingEnabled = true;
            this.m_ListBoxLoyalFriends.ItemHeight = 25;
            this.m_ListBoxLoyalFriends.Location = new System.Drawing.Point(420, 81);
            this.m_ListBoxLoyalFriends.Name = "m_ListBoxLoyalFriends";
            this.m_ListBoxLoyalFriends.Size = new System.Drawing.Size(518, 254);
            this.m_ListBoxLoyalFriends.TabIndex = 12;
            this.m_ListBoxLoyalFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxLoyalFriends_SelectedIndexChanged);
            // 
            // m_ButtonSearchLoyalFriends
            // 
            this.m_ButtonSearchLoyalFriends.Location = new System.Drawing.Point(52, 81);
            this.m_ButtonSearchLoyalFriends.Name = "m_ButtonSearchLoyalFriends";
            this.m_ButtonSearchLoyalFriends.Size = new System.Drawing.Size(242, 82);
            this.m_ButtonSearchLoyalFriends.TabIndex = 13;
            this.m_ButtonSearchLoyalFriends.Text = "Search my loyal friend";
            this.m_ButtonSearchLoyalFriends.UseVisualStyleBackColor = true;
            this.m_ButtonSearchLoyalFriends.Click += new System.EventHandler(this.buttonSearchLoyalFriends_Click);
            // 
            // m_PictureBoxLoyalFriends
            // 
            this.m_PictureBoxLoyalFriends.Location = new System.Drawing.Point(909, 81);
            this.m_PictureBoxLoyalFriends.Margin = new System.Windows.Forms.Padding(6);
            this.m_PictureBoxLoyalFriends.Name = "m_PictureBoxLoyalFriends";
            this.m_PictureBoxLoyalFriends.Size = new System.Drawing.Size(206, 254);
            this.m_PictureBoxLoyalFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxLoyalFriends.TabIndex = 14;
            this.m_PictureBoxLoyalFriends.TabStop = false;
            // 
            // m_LabelLoyalFriends
            // 
            this.m_LabelLoyalFriends.AutoSize = true;
            this.m_LabelLoyalFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelLoyalFriends.Location = new System.Drawing.Point(652, 26);
            this.m_LabelLoyalFriends.Name = "m_LabelLoyalFriends";
            this.m_LabelLoyalFriends.Size = new System.Drawing.Size(202, 31);
            this.m_LabelLoyalFriends.TabIndex = 15;
            this.m_LabelLoyalFriends.Text = "My loyal friends";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Most likes on photos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Most likes on posts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1004, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Most comments on photos";
            // 
            // FormMostLikesFromFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.MostLikesForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 888);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_LabelLoyalFriends);
            this.Controls.Add(this.m_PictureBoxLoyalFriends);
            this.Controls.Add(this.m_ButtonSearchLoyalFriends);
            this.Controls.Add(this.m_ListBoxLoyalFriends);
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
            this.Text = "Who is my loyal friend";
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedFriendPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedFriendPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedFriendComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxLoyalFriends)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox m_ListBoxMostLikesPhotos;
        private System.Windows.Forms.PictureBox m_PictureBoxSelectedFriendPhoto;
        private System.Windows.Forms.ListBox m_ListBoxMostLikesPosts;
        private PictureBox m_PictureBoxSelectedFriendPost;
        private PictureBox m_PictureBoxSelectedFriendComment;
        private ListBox m_ListBoxMostComments;
        private ListBox m_ListBoxLoyalFriends;
        private Button m_ButtonSearchLoyalFriends;
        private PictureBox m_PictureBoxLoyalFriends;
        private Label m_LabelLoyalFriends;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
