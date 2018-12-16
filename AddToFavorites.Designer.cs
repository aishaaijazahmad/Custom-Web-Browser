namespace CourseworkTrial3
{
    partial class AddToFavorites
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
            this.buttonAddFav = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.textBoxFavURL = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddFav
            // 
            this.buttonAddFav.Location = new System.Drawing.Point(138, 112);
            this.buttonAddFav.Name = "buttonAddFav";
            this.buttonAddFav.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFav.TabIndex = 0;
            this.buttonAddFav.Text = "Add";
            this.buttonAddFav.UseVisualStyleBackColor = true;
            this.buttonAddFav.Click += new System.EventHandler(this.buttonAddFav_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(51, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name :";
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(133, 28);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(153, 20);
            this.textBoxAddName.TabIndex = 2;
            // 
            // textBoxFavURL
            // 
            this.textBoxFavURL.Location = new System.Drawing.Point(133, 69);
            this.textBoxFavURL.Name = "textBoxFavURL";
            this.textBoxFavURL.Size = new System.Drawing.Size(153, 20);
            this.textBoxFavURL.TabIndex = 4;
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(51, 71);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(35, 13);
            this.labelURL.TabIndex = 3;
            this.labelURL.Text = "URL :";
            // 
            // AddToFavorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 160);
            this.Controls.Add(this.textBoxFavURL);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.textBoxAddName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonAddFav);
            this.Name = "AddToFavorites";
            this.Text = "AddToFavorites";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddFav;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.TextBox textBoxFavURL;
        private System.Windows.Forms.Label labelURL;
    }
}