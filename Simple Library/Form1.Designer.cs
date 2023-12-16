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
            this.Wlcm_text.Location = new System.Drawing.Point(12, 118);
            this.Wlcm_text.Name = "Wlcm_text";
            this.Wlcm_text.Size = new System.Drawing.Size(310, 23);
            this.Wlcm_text.TabIndex = 0;
            this.Wlcm_text.Text = "Welcome to Simple Library";
            this.Wlcm_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uname_label
            // 
            this.uname_label.AutoSize = true;
            this.uname_label.BackColor = System.Drawing.Color.Transparent;
            this.uname_label.Font = new System.Drawing.Font("CaskaydiaCove NFM", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname_label.Location = new System.Drawing.Point(22, 209);
            this.uname_label.Name = "uname_label";
            this.uname_label.Size = new System.Drawing.Size(89, 17);
            this.uname_label.TabIndex = 1;
            this.uname_label.Text = "Username:";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.BackColor = System.Drawing.Color.Transparent;
            this.pass_label.Font = new System.Drawing.Font("CaskaydiaCove NFM", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_label.Location = new System.Drawing.Point(22, 236);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(89, 17);
            this.pass_label.TabIndex = 1;
            this.pass_label.Text = "Password:";
            // 
            // username_box
            // 
            this.username_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_box.Font = new System.Drawing.Font("CaskaydiaCove NFM", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_box.Location = new System.Drawing.Point(117, 209);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(185, 18);
            this.username_box.TabIndex = 1;
            // 
            // pass_box
            // 
            this.pass_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_box.Font = new System.Drawing.Font("CaskaydiaCove NFM", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_box.Location = new System.Drawing.Point(117, 236);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(185, 18);
            this.pass_box.TabIndex = 2;
            this.pass_box.UseSystemPasswordChar = true;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Lime;
            this.login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_button.Font = new System.Drawing.Font("CaskaydiaCove NFM", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(135, 287);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.BackColor = System.Drawing.Color.Transparent;
            this.Credits.Font = new System.Drawing.Font("CommercialScript BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credits.Location = new System.Drawing.Point(12, 441);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(97, 15);
            this.Credits.TabIndex = 0;
            this.Credits.Text = "By: Ali Esmaeeli";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Lime;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_button.Font = new System.Drawing.Font("CaskaydiaCove NFM", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(135, 316);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simple_Library.Properties.Resources.abstract_blue_background_768x1024;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(339, 465);
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
            this.Opacity = 0.75D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
    }
}

