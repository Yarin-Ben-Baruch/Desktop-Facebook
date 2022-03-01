namespace BasicFacebookFeatures
{
    public partial class FormPopularPhotos
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
            this.m_LabelNumberOfLikes = new System.Windows.Forms.Label();
            this.m_ButtonPopularPhotos = new System.Windows.Forms.Button();
            this.m_PictureBoxSelectedPopularPhoto = new System.Windows.Forms.PictureBox();
            this.m_ListBoxPopularPhotos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedPopularPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // m_LabelNumberOfLikes
            // 
            this.m_LabelNumberOfLikes.AutoSize = true;
            this.m_LabelNumberOfLikes.Location = new System.Drawing.Point(375, 58);
            this.m_LabelNumberOfLikes.Name = "m_LabelNumberOfLikes";
            this.m_LabelNumberOfLikes.Size = new System.Drawing.Size(69, 25);
            this.m_LabelNumberOfLikes.TabIndex = 65;
            this.m_LabelNumberOfLikes.Text = "Likes:";
            // 
            // m_ButtonPopularPhotos
            // 
            this.m_ButtonPopularPhotos.BackColor = System.Drawing.Color.White;
            this.m_ButtonPopularPhotos.Location = new System.Drawing.Point(123, 46);
            this.m_ButtonPopularPhotos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_ButtonPopularPhotos.Name = "m_ButtonPopularPhotos";
            this.m_ButtonPopularPhotos.Size = new System.Drawing.Size(236, 50);
            this.m_ButtonPopularPhotos.TabIndex = 64;
            this.m_ButtonPopularPhotos.Text = "My popular photos";
            this.m_ButtonPopularPhotos.UseVisualStyleBackColor = false;
            this.m_ButtonPopularPhotos.Click += new System.EventHandler(this.buttonPopularPhotos_Click);
            // 
            // m_PictureBoxSelectedPopularPhoto
            // 
            this.m_PictureBoxSelectedPopularPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_PictureBoxSelectedPopularPhoto.Location = new System.Drawing.Point(361, 305);
            this.m_PictureBoxSelectedPopularPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_PictureBoxSelectedPopularPhoto.Name = "m_PictureBoxSelectedPopularPhoto";
            this.m_PictureBoxSelectedPopularPhoto.Size = new System.Drawing.Size(148, 152);
            this.m_PictureBoxSelectedPopularPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxSelectedPopularPhoto.TabIndex = 63;
            this.m_PictureBoxSelectedPopularPhoto.TabStop = false;
            // 
            // m_ListBoxPopularPhotos
            // 
            this.m_ListBoxPopularPhotos.BackColor = System.Drawing.Color.White;
            this.m_ListBoxPopularPhotos.FormattingEnabled = true;
            this.m_ListBoxPopularPhotos.ItemHeight = 25;
            this.m_ListBoxPopularPhotos.Location = new System.Drawing.Point(123, 103);
            this.m_ListBoxPopularPhotos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_ListBoxPopularPhotos.Name = "m_ListBoxPopularPhotos";
            this.m_ListBoxPopularPhotos.Size = new System.Drawing.Size(386, 354);
            this.m_ListBoxPopularPhotos.TabIndex = 62;
            this.m_ListBoxPopularPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxPopularPhotos_SelectedIndexChanged);
            // 
            // FormPopularPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.MostLikesForm;
            this.ClientSize = new System.Drawing.Size(644, 538);
            this.Controls.Add(this.m_LabelNumberOfLikes);
            this.Controls.Add(this.m_ButtonPopularPhotos);
            this.Controls.Add(this.m_PictureBoxSelectedPopularPhoto);
            this.Controls.Add(this.m_ListBoxPopularPhotos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormPopularPhotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPopularPhotos";
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedPopularPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LabelNumberOfLikes;
        private System.Windows.Forms.Button m_ButtonPopularPhotos;
        private System.Windows.Forms.PictureBox m_PictureBoxSelectedPopularPhoto;
        private System.Windows.Forms.ListBox m_ListBoxPopularPhotos;
    }
}