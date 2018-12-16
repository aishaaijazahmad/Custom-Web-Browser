namespace CourseworkTrial3
{
    partial class Settings
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
            this.buttonModifyHomepage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonViewHistory = new System.Windows.Forms.Button();
            this.buttonModifyFav = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonModifyHomepage
            // 
            this.buttonModifyHomepage.Location = new System.Drawing.Point(62, 56);
            this.buttonModifyHomepage.Name = "buttonModifyHomepage";
            this.buttonModifyHomepage.Size = new System.Drawing.Size(109, 23);
            this.buttonModifyHomepage.TabIndex = 0;
            this.buttonModifyHomepage.Text = "Modify Homepage";
            this.buttonModifyHomepage.UseVisualStyleBackColor = true;
            this.buttonModifyHomepage.Click += new System.EventHandler(this.buttonModifyHomepage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pick a setting:";
            // 
            // buttonViewHistory
            // 
            this.buttonViewHistory.Location = new System.Drawing.Point(62, 103);
            this.buttonViewHistory.Name = "buttonViewHistory";
            this.buttonViewHistory.Size = new System.Drawing.Size(109, 23);
            this.buttonViewHistory.TabIndex = 2;
            this.buttonViewHistory.Text = "View History";
            this.buttonViewHistory.UseVisualStyleBackColor = true;
            this.buttonViewHistory.Click += new System.EventHandler(this.buttonViewHistory_Click);
            // 
            // buttonModifyFav
            // 
            this.buttonModifyFav.Location = new System.Drawing.Point(62, 147);
            this.buttonModifyFav.Name = "buttonModifyFav";
            this.buttonModifyFav.Size = new System.Drawing.Size(109, 23);
            this.buttonModifyFav.TabIndex = 3;
            this.buttonModifyFav.Text = "Modify Favorites";
            this.buttonModifyFav.UseVisualStyleBackColor = true;
            this.buttonModifyFav.Click += new System.EventHandler(this.buttonModifyFav_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 220);
            this.Controls.Add(this.buttonModifyFav);
            this.Controls.Add(this.buttonViewHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonModifyHomepage);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModifyHomepage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonViewHistory;
        private System.Windows.Forms.Button buttonModifyFav;
    }
}