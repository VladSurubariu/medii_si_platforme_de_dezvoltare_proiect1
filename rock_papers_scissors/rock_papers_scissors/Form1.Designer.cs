namespace rock_papers_scissors
{
    partial class Form1
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
            this.change_button = new System.Windows.Forms.Button();
            this.choose_button = new System.Windows.Forms.Button();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // change_button
            // 
            this.change_button.Location = new System.Drawing.Point(84, 244);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(75, 23);
            this.change_button.TabIndex = 0;
            this.change_button.Text = "Change";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // choose_button
            // 
            this.choose_button.Location = new System.Drawing.Point(165, 244);
            this.choose_button.Name = "choose_button";
            this.choose_button.Size = new System.Drawing.Size(75, 23);
            this.choose_button.TabIndex = 1;
            this.choose_button.Text = "Choose";
            this.choose_button.UseVisualStyleBackColor = true;
            this.choose_button.Click += new System.EventHandler(this.choose_button_Click);
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = global::rock_papers_scissors.Properties.Resources.question;
            this.userPictureBox.Location = new System.Drawing.Point(102, 90);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(125, 125);
            this.userPictureBox.TabIndex = 2;
            this.userPictureBox.TabStop = false;
            this.userPictureBox.Tag = "option";
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.Image = global::rock_papers_scissors.Properties.Resources.question;
            this.computerPictureBox.Location = new System.Drawing.Point(495, 90);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(125, 125);
            this.computerPictureBox.TabIndex = 3;
            this.computerPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 402);
            this.Controls.Add(this.computerPictureBox);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.choose_button);
            this.Controls.Add(this.change_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Button choose_button;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.PictureBox computerPictureBox;
    }
}

