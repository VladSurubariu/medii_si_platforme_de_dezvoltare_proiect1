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
            this.computerUserBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerUserBox)).BeginInit();
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
            // computerUserBox
            // 
            this.computerUserBox.Image = global::rock_papers_scissors.Properties.Resources.question;
            this.computerUserBox.Location = new System.Drawing.Point(495, 90);
            this.computerUserBox.Name = "computerUserBox";
            this.computerUserBox.Size = new System.Drawing.Size(125, 125);
            this.computerUserBox.TabIndex = 3;
            this.computerUserBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score: 0-0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.computerUserBox);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.choose_button);
            this.Controls.Add(this.change_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerUserBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Button choose_button;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.PictureBox computerUserBox;
        private System.Windows.Forms.Label label1;
    }
}

