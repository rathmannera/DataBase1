namespace DataBase1
{
    partial class homePageForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.moreInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Pacifico", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(47, 22);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(875, 85);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to the S.A.N.E  Music Brower!";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.searchButton.Font = new System.Drawing.Font("Quicksand Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(358, 166);
            this.searchButton.Margin = new System.Windows.Forms.Padding(0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(252, 75);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.browseButton.Font = new System.Drawing.Font("Quicksand Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.Color.White;
            this.browseButton.Location = new System.Drawing.Point(358, 257);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(252, 75);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(275, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select an option below.";
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.createButton.Font = new System.Drawing.Font("Quicksand Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(358, 349);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(252, 75);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.deleteButton.Font = new System.Drawing.Font("Quicksand Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(358, 445);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(252, 75);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.exitButton.Font = new System.Drawing.Font("Quicksand Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(33, 514);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(181, 75);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // moreInfoButton
            // 
            this.moreInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.moreInfoButton.Font = new System.Drawing.Font("Quicksand Bold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreInfoButton.ForeColor = System.Drawing.Color.White;
            this.moreInfoButton.Location = new System.Drawing.Point(741, 514);
            this.moreInfoButton.Name = "moreInfoButton";
            this.moreInfoButton.Size = new System.Drawing.Size(181, 75);
            this.moreInfoButton.TabIndex = 7;
            this.moreInfoButton.Text = "More Info on S.A.N.E Music";
            this.moreInfoButton.UseVisualStyleBackColor = false;
            // 
            // homePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(965, 601);
            this.Controls.Add(this.moreInfoButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.welcomeLabel);
            this.Font = new System.Drawing.Font("Quicksand Bold", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "homePageForm";
            this.Text = "Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button moreInfoButton;
    }
}

