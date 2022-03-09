namespace BasicFacebookFeatures
{
    public partial class FormLocations
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
            this.m_ButtonFindCities = new System.Windows.Forms.Button();
            this.m_ListBoxAllCities = new System.Windows.Forms.ListBox();
            this.m_ListBoxUserInSameCity = new System.Windows.Forms.ListBox();
            this.m_LabelHeaderListBox = new System.Windows.Forms.Label();
            this.m_PictureBoxProfileUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxProfileUser)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ButtonFindCities
            // 
            this.m_ButtonFindCities.Location = new System.Drawing.Point(23, 52);
            this.m_ButtonFindCities.Margin = new System.Windows.Forms.Padding(2);
            this.m_ButtonFindCities.Name = "m_ButtonFindCities";
            this.m_ButtonFindCities.Size = new System.Drawing.Size(187, 32);
            this.m_ButtonFindCities.TabIndex = 0;
            this.m_ButtonFindCities.Text = "Find all friends cities";
            this.m_ButtonFindCities.UseVisualStyleBackColor = true;
            this.m_ButtonFindCities.Click += new System.EventHandler(this.buttonFindCities_Click);
            // 
            // m_ListBoxAllCities
            // 
            this.m_ListBoxAllCities.FormattingEnabled = true;
            this.m_ListBoxAllCities.ItemHeight = 16;
            this.m_ListBoxAllCities.Location = new System.Drawing.Point(27, 103);
            this.m_ListBoxAllCities.Margin = new System.Windows.Forms.Padding(2);
            this.m_ListBoxAllCities.Name = "m_ListBoxAllCities";
            this.m_ListBoxAllCities.Size = new System.Drawing.Size(183, 212);
            this.m_ListBoxAllCities.TabIndex = 1;
            this.m_ListBoxAllCities.SelectedIndexChanged += new System.EventHandler(this.listBoxAllCities_SelectedIndexChanged);
            // 
            // m_ListBoxUserInSameCity
            // 
            this.m_ListBoxUserInSameCity.FormattingEnabled = true;
            this.m_ListBoxUserInSameCity.ItemHeight = 16;
            this.m_ListBoxUserInSameCity.Location = new System.Drawing.Point(383, 103);
            this.m_ListBoxUserInSameCity.Margin = new System.Windows.Forms.Padding(2);
            this.m_ListBoxUserInSameCity.Name = "m_ListBoxUserInSameCity";
            this.m_ListBoxUserInSameCity.Size = new System.Drawing.Size(183, 212);
            this.m_ListBoxUserInSameCity.TabIndex = 2;
            this.m_ListBoxUserInSameCity.SelectedIndexChanged += new System.EventHandler(this.listBoxUserInSameCity_SelectedIndexChanged);
            // 
            // m_LabelHeaderListBox
            // 
            this.m_LabelHeaderListBox.AutoSize = true;
            this.m_LabelHeaderListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelHeaderListBox.Location = new System.Drawing.Point(407, 57);
            this.m_LabelHeaderListBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LabelHeaderListBox.Name = "m_LabelHeaderListBox";
            this.m_LabelHeaderListBox.Size = new System.Drawing.Size(125, 20);
            this.m_LabelHeaderListBox.TabIndex = 3;
            this.m_LabelHeaderListBox.Text = "Who lives there";
            // 
            // m_PictureBoxProfileUser
            // 
            this.m_PictureBoxProfileUser.Location = new System.Drawing.Point(483, 233);
            this.m_PictureBoxProfileUser.Margin = new System.Windows.Forms.Padding(2);
            this.m_PictureBoxProfileUser.Name = "m_PictureBoxProfileUser";
            this.m_PictureBoxProfileUser.Size = new System.Drawing.Size(81, 79);
            this.m_PictureBoxProfileUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxProfileUser.TabIndex = 4;
            this.m_PictureBoxProfileUser.TabStop = false;
            // 
            // FormLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.MostLikesForm;
            this.ClientSize = new System.Drawing.Size(591, 358);
            this.Controls.Add(this.m_PictureBoxProfileUser);
            this.Controls.Add(this.m_LabelHeaderListBox);
            this.Controls.Add(this.m_ListBoxUserInSameCity);
            this.Controls.Add(this.m_ListBoxAllCities);
            this.Controls.Add(this.m_ButtonFindCities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormLocations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Where my friends live?";
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxProfileUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_ButtonFindCities;
        private System.Windows.Forms.ListBox m_ListBoxAllCities;
        private System.Windows.Forms.ListBox m_ListBoxUserInSameCity;
        private System.Windows.Forms.Label m_LabelHeaderListBox;
        private System.Windows.Forms.PictureBox m_PictureBoxProfileUser;
    }
}