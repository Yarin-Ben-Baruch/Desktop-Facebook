
namespace BasicFacebookFeatures
{
    partial class FormPost
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
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.m_ButtonFetchPosts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPostComments.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxPostComments.DisplayMember = "name";
            this.listBoxPostComments.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 39;
            this.listBoxPostComments.Location = new System.Drawing.Point(769, 374);
            this.listBoxPostComments.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(370, 160);
            this.listBoxPostComments.TabIndex = 57;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 39;
            this.listBoxPosts.Location = new System.Drawing.Point(57, 138);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(1082, 238);
            this.listBoxPosts.TabIndex = 52;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetStatus.Location = new System.Drawing.Point(989, 87);
            this.buttonSetStatus.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(150, 44);
            this.buttonSetStatus.TabIndex = 55;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Location = new System.Drawing.Point(651, 95);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(326, 31);
            this.textBoxStatus.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Post Status:";
            // 
            // linkPosts
            // 
            this.linkPosts.AutoSize = true;
            this.linkPosts.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.linkPosts.Location = new System.Drawing.Point(59, 82);
            this.linkPosts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(0, 28);
            this.linkPosts.TabIndex = 56;
            this.linkPosts.UseCompatibleTextRendering = true;
            // 
            // m_ButtonFetchPosts
            // 
            this.m_ButtonFetchPosts.Location = new System.Drawing.Point(81, 82);
            this.m_ButtonFetchPosts.Name = "m_ButtonFetchPosts";
            this.m_ButtonFetchPosts.Size = new System.Drawing.Size(216, 46);
            this.m_ButtonFetchPosts.TabIndex = 58;
            this.m_ButtonFetchPosts.Text = "Fetch posts";
            this.m_ButtonFetchPosts.UseVisualStyleBackColor = true;
            this.m_ButtonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // FormPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 578);
            this.Controls.Add(this.m_ButtonFetchPosts);
            this.Controls.Add(this.listBoxPostComments);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkPosts);
            this.Name = "FormPost";
            this.Text = "FormPost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPostComments;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkPosts;
        private System.Windows.Forms.Button m_ButtonFetchPosts;
    }
}