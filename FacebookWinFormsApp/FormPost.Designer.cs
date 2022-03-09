namespace BasicFacebookFeatures
{
    public partial class FormPost
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
            this.m_ListBoxPostComments = new System.Windows.Forms.ListBox();
            this.m_ListBoxPosts = new System.Windows.Forms.ListBox();
            this.m_ButtonSetStatus = new System.Windows.Forms.Button();
            this.m_TextBoxStatus = new System.Windows.Forms.TextBox();
            this.m_LinkPosts = new System.Windows.Forms.LinkLabel();
            this.m_ButtonFetchPosts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_ListBoxPostComments
            // 
            this.m_ListBoxPostComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ListBoxPostComments.BackColor = System.Drawing.SystemColors.Info;
            this.m_ListBoxPostComments.DisplayMember = "name";
            this.m_ListBoxPostComments.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ListBoxPostComments.FormattingEnabled = true;
            this.m_ListBoxPostComments.ItemHeight = 24;
            this.m_ListBoxPostComments.Location = new System.Drawing.Point(525, 214);
            this.m_ListBoxPostComments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_ListBoxPostComments.Name = "m_ListBoxPostComments";
            this.m_ListBoxPostComments.Size = new System.Drawing.Size(248, 76);
            this.m_ListBoxPostComments.TabIndex = 4;
            // 
            // m_ListBoxPosts
            // 
            this.m_ListBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ListBoxPosts.DisplayMember = "name";
            this.m_ListBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ListBoxPosts.FormattingEnabled = true;
            this.m_ListBoxPosts.ItemHeight = 24;
            this.m_ListBoxPosts.Location = new System.Drawing.Point(50, 114);
            this.m_ListBoxPosts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_ListBoxPosts.Name = "m_ListBoxPosts";
            this.m_ListBoxPosts.Size = new System.Drawing.Size(723, 172);
            this.m_ListBoxPosts.TabIndex = 3;
            this.m_ListBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // m_ButtonSetStatus
            // 
            this.m_ButtonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ButtonSetStatus.Location = new System.Drawing.Point(671, 81);
            this.m_ButtonSetStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_ButtonSetStatus.Name = "m_ButtonSetStatus";
            this.m_ButtonSetStatus.Size = new System.Drawing.Size(100, 28);
            this.m_ButtonSetStatus.TabIndex = 2;
            this.m_ButtonSetStatus.Text = "Post";
            this.m_ButtonSetStatus.UseVisualStyleBackColor = true;
            this.m_ButtonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // m_TextBoxStatus
            // 
            this.m_TextBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_TextBoxStatus.Location = new System.Drawing.Point(350, 86);
            this.m_TextBoxStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_TextBoxStatus.Name = "m_TextBoxStatus";
            this.m_TextBoxStatus.Size = new System.Drawing.Size(303, 22);
            this.m_TextBoxStatus.TabIndex = 1;
            // 
            // m_LinkPosts
            // 
            this.m_LinkPosts.AutoSize = true;
            this.m_LinkPosts.Location = new System.Drawing.Point(51, 78);
            this.m_LinkPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LinkPosts.Name = "m_LinkPosts";
            this.m_LinkPosts.Size = new System.Drawing.Size(0, 17);
            this.m_LinkPosts.TabIndex = 56;
            // 
            // m_ButtonFetchPosts
            // 
            this.m_ButtonFetchPosts.Location = new System.Drawing.Point(50, 81);
            this.m_ButtonFetchPosts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_ButtonFetchPosts.Name = "m_ButtonFetchPosts";
            this.m_ButtonFetchPosts.Size = new System.Drawing.Size(144, 29);
            this.m_ButtonFetchPosts.TabIndex = 0;
            this.m_ButtonFetchPosts.Text = "Fetch posts";
            this.m_ButtonFetchPosts.UseVisualStyleBackColor = true;
            this.m_ButtonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // FormPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.MostLikesForm;
            this.ClientSize = new System.Drawing.Size(835, 370);
            this.Controls.Add(this.m_ButtonFetchPosts);
            this.Controls.Add(this.m_ListBoxPostComments);
            this.Controls.Add(this.m_ListBoxPosts);
            this.Controls.Add(this.m_ButtonSetStatus);
            this.Controls.Add(this.m_TextBoxStatus);
            this.Controls.Add(this.m_LinkPosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Post Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox m_ListBoxPostComments;
        private System.Windows.Forms.ListBox m_ListBoxPosts;
        private System.Windows.Forms.Button m_ButtonSetStatus;
        private System.Windows.Forms.TextBox m_TextBoxStatus;
        private System.Windows.Forms.LinkLabel m_LinkPosts;
        private System.Windows.Forms.Button m_ButtonFetchPosts;
    }
}