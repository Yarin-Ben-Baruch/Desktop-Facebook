
namespace BasicFacebookFeatures
{
    partial class FormLocations
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_ButtonFindCities
            // 
            this.m_ButtonFindCities.Location = new System.Drawing.Point(54, 46);
            this.m_ButtonFindCities.Name = "m_ButtonFindCities";
            this.m_ButtonFindCities.Size = new System.Drawing.Size(214, 50);
            this.m_ButtonFindCities.TabIndex = 0;
            this.m_ButtonFindCities.Text = "Find all cities";
            this.m_ButtonFindCities.UseVisualStyleBackColor = true;
            this.m_ButtonFindCities.Click += new System.EventHandler(this.buttonFindCities_Click);
            // 
            // m_ListBoxAllCities
            // 
            this.m_ListBoxAllCities.FormattingEnabled = true;
            this.m_ListBoxAllCities.ItemHeight = 25;
            this.m_ListBoxAllCities.Location = new System.Drawing.Point(26, 126);
            this.m_ListBoxAllCities.Name = "m_ListBoxAllCities";
            this.m_ListBoxAllCities.Size = new System.Drawing.Size(273, 329);
            this.m_ListBoxAllCities.TabIndex = 1;
            this.m_ListBoxAllCities.SelectedIndexChanged += new System.EventHandler(this.listBoxAllCities_SelectedIndexChanged);
            // 
            // m_ListBoxUserInSameCity
            // 
            this.m_ListBoxUserInSameCity.FormattingEnabled = true;
            this.m_ListBoxUserInSameCity.ItemHeight = 25;
            this.m_ListBoxUserInSameCity.Location = new System.Drawing.Point(524, 126);
            this.m_ListBoxUserInSameCity.Name = "m_ListBoxUserInSameCity";
            this.m_ListBoxUserInSameCity.Size = new System.Drawing.Size(273, 329);
            this.m_ListBoxUserInSameCity.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Who live with him";
            // 
            // FormLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_ListBoxUserInSameCity);
            this.Controls.Add(this.m_ListBoxAllCities);
            this.Controls.Add(this.m_ButtonFindCities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLocations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLocations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_ButtonFindCities;
        private System.Windows.Forms.ListBox m_ListBoxAllCities;
        private System.Windows.Forms.ListBox m_ListBoxUserInSameCity;
        private System.Windows.Forms.Label label1;
    }
}