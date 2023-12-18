namespace Simple_Library
{
    partial class manual_add_book
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
            this.add_book_caption = new System.Windows.Forms.Label();
            this.add_book_button = new System.Windows.Forms.Button();
            this.add_book_crawl_button = new System.Windows.Forms.Button();
            this.cancel_adding_button = new System.Windows.Forms.Button();
            this.enter_bookname_label = new System.Windows.Forms.Label();
            this.enter_title_txtbx = new System.Windows.Forms.TextBox();
            this.authorname_label = new System.Windows.Forms.Label();
            this.enter_author_txtbx = new System.Windows.Forms.TextBox();
            this.isbn_label = new System.Windows.Forms.Label();
            this.enter_isbn_txtbx = new System.Windows.Forms.TextBox();
            this.publisher_label = new System.Windows.Forms.Label();
            this.publish_date_label = new System.Windows.Forms.Label();
            this.enter_pub_txtbx = new System.Windows.Forms.TextBox();
            this.enter_pubdate_txtbx = new System.Windows.Forms.TextBox();
            this.add_book_status_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_book_caption
            // 
            this.add_book_caption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_book_caption.AutoSize = true;
            this.add_book_caption.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_book_caption.Location = new System.Drawing.Point(167, 9);
            this.add_book_caption.Name = "add_book_caption";
            this.add_book_caption.Size = new System.Drawing.Size(260, 31);
            this.add_book_caption.TabIndex = 0;
            this.add_book_caption.Text = "Add Book to Library";
            // 
            // add_book_button
            // 
            this.add_book_button.Location = new System.Drawing.Point(12, 331);
            this.add_book_button.Name = "add_book_button";
            this.add_book_button.Size = new System.Drawing.Size(75, 23);
            this.add_book_button.TabIndex = 6;
            this.add_book_button.Text = "Confirm";
            this.add_book_button.UseVisualStyleBackColor = true;
            this.add_book_button.Click += new System.EventHandler(this.add_book_button_Click);
            // 
            // add_book_crawl_button
            // 
            this.add_book_crawl_button.Enabled = false;
            this.add_book_crawl_button.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.add_book_crawl_button.Location = new System.Drawing.Point(93, 331);
            this.add_book_crawl_button.Name = "add_book_crawl_button";
            this.add_book_crawl_button.Size = new System.Drawing.Size(119, 23);
            this.add_book_crawl_button.TabIndex = 0;
            this.add_book_crawl_button.Text = "Download Metadata";
            this.add_book_crawl_button.UseVisualStyleBackColor = true;
            // 
            // cancel_adding_button
            // 
            this.cancel_adding_button.Location = new System.Drawing.Point(218, 331);
            this.cancel_adding_button.Name = "cancel_adding_button";
            this.cancel_adding_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_adding_button.TabIndex = 7;
            this.cancel_adding_button.Text = "Cancel";
            this.cancel_adding_button.UseVisualStyleBackColor = true;
            this.cancel_adding_button.Click += new System.EventHandler(this.cancel_adding_button_Click);
            // 
            // enter_bookname_label
            // 
            this.enter_bookname_label.AutoSize = true;
            this.enter_bookname_label.Font = new System.Drawing.Font("CaskaydiaCove NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_bookname_label.Location = new System.Drawing.Point(8, 79);
            this.enter_bookname_label.Name = "enter_bookname_label";
            this.enter_bookname_label.Size = new System.Drawing.Size(63, 19);
            this.enter_bookname_label.TabIndex = 2;
            this.enter_bookname_label.Text = "Title:";
            // 
            // enter_title_txtbx
            // 
            this.enter_title_txtbx.Font = new System.Drawing.Font("CaskaydiaCove NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_title_txtbx.Location = new System.Drawing.Point(89, 80);
            this.enter_title_txtbx.Name = "enter_title_txtbx";
            this.enter_title_txtbx.Size = new System.Drawing.Size(259, 21);
            this.enter_title_txtbx.TabIndex = 1;
            // 
            // authorname_label
            // 
            this.authorname_label.AutoSize = true;
            this.authorname_label.Font = new System.Drawing.Font("CaskaydiaCove NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorname_label.Location = new System.Drawing.Point(8, 119);
            this.authorname_label.Name = "authorname_label";
            this.authorname_label.Size = new System.Drawing.Size(72, 19);
            this.authorname_label.TabIndex = 2;
            this.authorname_label.Text = "Author:";
            // 
            // enter_author_txtbx
            // 
            this.enter_author_txtbx.Font = new System.Drawing.Font("CaskaydiaCove NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_author_txtbx.Location = new System.Drawing.Point(89, 115);
            this.enter_author_txtbx.Name = "enter_author_txtbx";
            this.enter_author_txtbx.Size = new System.Drawing.Size(259, 21);
            this.enter_author_txtbx.TabIndex = 2;
            // 
            // isbn_label
            // 
            this.isbn_label.AutoSize = true;
            this.isbn_label.Font = new System.Drawing.Font("CaskaydiaCove NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn_label.Location = new System.Drawing.Point(8, 159);
            this.isbn_label.Name = "isbn_label";
            this.isbn_label.Size = new System.Drawing.Size(54, 19);
            this.isbn_label.TabIndex = 2;
            this.isbn_label.Text = "ISBN:";
            // 
            // enter_isbn_txtbx
            // 
            this.enter_isbn_txtbx.Font = new System.Drawing.Font("CaskaydiaCove NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_isbn_txtbx.Location = new System.Drawing.Point(89, 155);
            this.enter_isbn_txtbx.Name = "enter_isbn_txtbx";
            this.enter_isbn_txtbx.Size = new System.Drawing.Size(259, 21);
            this.enter_isbn_txtbx.TabIndex = 3;
            // 
            // publisher_label
            // 
            this.publisher_label.AutoSize = true;
            this.publisher_label.Font = new System.Drawing.Font("CaskaydiaCove NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisher_label.Location = new System.Drawing.Point(8, 197);
            this.publisher_label.Name = "publisher_label";
            this.publisher_label.Size = new System.Drawing.Size(99, 19);
            this.publisher_label.TabIndex = 2;
            this.publisher_label.Text = "Publisher:";
            // 
            // publish_date_label
            // 
            this.publish_date_label.AutoSize = true;
            this.publish_date_label.Font = new System.Drawing.Font("CaskaydiaCove NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publish_date_label.Location = new System.Drawing.Point(8, 233);
            this.publish_date_label.Name = "publish_date_label";
            this.publish_date_label.Size = new System.Drawing.Size(99, 19);
            this.publish_date_label.TabIndex = 2;
            this.publish_date_label.Text = "Pub. Date:";
            // 
            // enter_pub_txtbx
            // 
            this.enter_pub_txtbx.Font = new System.Drawing.Font("CaskaydiaCove NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_pub_txtbx.Location = new System.Drawing.Point(113, 192);
            this.enter_pub_txtbx.Name = "enter_pub_txtbx";
            this.enter_pub_txtbx.Size = new System.Drawing.Size(235, 21);
            this.enter_pub_txtbx.TabIndex = 4;
            // 
            // enter_pubdate_txtbx
            // 
            this.enter_pubdate_txtbx.Font = new System.Drawing.Font("CaskaydiaCove NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_pubdate_txtbx.Location = new System.Drawing.Point(113, 230);
            this.enter_pubdate_txtbx.Name = "enter_pubdate_txtbx";
            this.enter_pubdate_txtbx.Size = new System.Drawing.Size(235, 21);
            this.enter_pubdate_txtbx.TabIndex = 5;
            // 
            // add_book_status_label
            // 
            this.add_book_status_label.AutoSize = true;
            this.add_book_status_label.Location = new System.Drawing.Point(9, 270);
            this.add_book_status_label.Name = "add_book_status_label";
            this.add_book_status_label.Size = new System.Drawing.Size(0, 13);
            this.add_book_status_label.TabIndex = 4;
            // 
            // manual_add_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::Simple_Library.Properties.Resources.ADDBOOK;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.add_book_status_label);
            this.Controls.Add(this.enter_pubdate_txtbx);
            this.Controls.Add(this.enter_pub_txtbx);
            this.Controls.Add(this.enter_isbn_txtbx);
            this.Controls.Add(this.enter_author_txtbx);
            this.Controls.Add(this.enter_title_txtbx);
            this.Controls.Add(this.publish_date_label);
            this.Controls.Add(this.publisher_label);
            this.Controls.Add(this.isbn_label);
            this.Controls.Add(this.authorname_label);
            this.Controls.Add(this.enter_bookname_label);
            this.Controls.Add(this.cancel_adding_button);
            this.Controls.Add(this.add_book_crawl_button);
            this.Controls.Add(this.add_book_button);
            this.Controls.Add(this.add_book_caption);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "manual_add_book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_book_caption;
        private System.Windows.Forms.Button add_book_button;
        private System.Windows.Forms.Button add_book_crawl_button;
        private System.Windows.Forms.Button cancel_adding_button;
        private System.Windows.Forms.Label enter_bookname_label;
        private System.Windows.Forms.TextBox enter_title_txtbx;
        private System.Windows.Forms.Label authorname_label;
        private System.Windows.Forms.TextBox enter_author_txtbx;
        private System.Windows.Forms.Label isbn_label;
        private System.Windows.Forms.TextBox enter_isbn_txtbx;
        private System.Windows.Forms.Label publisher_label;
        private System.Windows.Forms.Label publish_date_label;
        private System.Windows.Forms.TextBox enter_pub_txtbx;
        private System.Windows.Forms.TextBox enter_pubdate_txtbx;
        private System.Windows.Forms.Label add_book_status_label;
    }
}