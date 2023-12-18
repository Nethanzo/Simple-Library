namespace Simple_Library
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
            this.Wlcm_text = new System.Windows.Forms.Label();
            this.uname_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.username_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.Credits = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.login_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Wlcm_text
            // 
            this.Wlcm_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Wlcm_text.BackColor = System.Drawing.Color.Transparent;
            this.Wlcm_text.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Wlcm_text.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlcm_text.Location = new System.Drawing.Point(12, 94);
            this.Wlcm_text.Name = "Wlcm_text";
            this.Wlcm_text.Size = new System.Drawing.Size(311, 43);
            this.Wlcm_text.TabIndex = 0;
            this.Wlcm_text.Text = "Welcome to Simple Library";
            this.Wlcm_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Wlcm_text.Click += new System.EventHandler(this.Wlcm_text_Click);
            // 
            // uname_label
            // 
            this.uname_label.AutoSize = true;
            this.uname_label.BackColor = System.Drawing.Color.Transparent;
            this.uname_label.Font = new System.Drawing.Font("CaskaydiaCove NFM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname_label.Location = new System.Drawing.Point(22, 185);
            this.uname_label.Name = "uname_label";
            this.uname_label.Size = new System.Drawing.Size(90, 19);
            this.uname_label.TabIndex = 1;
            this.uname_label.Text = "Username:";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.BackColor = System.Drawing.Color.Transparent;
            this.pass_label.Font = new System.Drawing.Font("CaskaydiaCove NFM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_label.Location = new System.Drawing.Point(22, 225);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(90, 19);
            this.pass_label.TabIndex = 1;
            this.pass_label.Text = "Password:";
            // 
            // username_box
            // 
            this.username_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_box.Font = new System.Drawing.Font("CaskaydiaCove NFM", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_box.Location = new System.Drawing.Point(135, 185);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(185, 22);
            this.username_box.TabIndex = 1;
            // 
            // pass_box
            // 
            this.pass_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_box.Font = new System.Drawing.Font("CaskaydiaCove NFM", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_box.Location = new System.Drawing.Point(135, 225);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(185, 22);
            this.pass_box.TabIndex = 2;
            this.pass_box.UseSystemPasswordChar = true;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Lime;
            this.login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(122, 274);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 40);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.BackColor = System.Drawing.Color.Transparent;
            this.Credits.Font = new System.Drawing.Font("Prestige Elite Std", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credits.Location = new System.Drawing.Point(12, 426);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(117, 12);
            this.Credits.TabIndex = 0;
            this.Credits.Text = "By: Ali Esmaeeli";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Lime;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(122, 319);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(100, 40);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // login_status
            // 
            this.login_status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_status.BackColor = System.Drawing.Color.Transparent;
            this.login_status.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_status.ForeColor = System.Drawing.Color.Black;
            this.login_status.Location = new System.Drawing.Point(40, 381);
            this.login_status.Name = "login_status";
            this.login_status.Size = new System.Drawing.Size(280, 18);
            this.login_status.TabIndex = 0;
            this.login_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_status.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simple_Library.Properties.Resources.abstract_blue_background_768x1024;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.login_status);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.uname_label);
            this.Controls.Add(this.Wlcm_text);
            this.Font = new System.Drawing.Font("CaskaydiaCove NFM", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Wlcm_text;
        private System.Windows.Forms.Label uname_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label Credits;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label login_status;
    }
}

