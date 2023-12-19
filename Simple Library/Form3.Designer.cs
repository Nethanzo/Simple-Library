namespace Simple_Library
{
    partial class delete_dialog
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
            this.delete_label = new System.Windows.Forms.Label();
            this.id_to_remove_box = new System.Windows.Forms.TextBox();
            this.ok_to_remove = new System.Windows.Forms.Button();
            this.cancel_remove = new System.Windows.Forms.Button();
            this.remove_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delete_label
            // 
            this.delete_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_label.Location = new System.Drawing.Point(44, 9);
            this.delete_label.Name = "delete_label";
            this.delete_label.Size = new System.Drawing.Size(258, 23);
            this.delete_label.TabIndex = 0;
            this.delete_label.Text = "Please Enter ID to Remove";
            this.delete_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_to_remove_box
            // 
            this.id_to_remove_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.id_to_remove_box.Font = new System.Drawing.Font("CaskaydiaCove NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_to_remove_box.Location = new System.Drawing.Point(123, 45);
            this.id_to_remove_box.Name = "id_to_remove_box";
            this.id_to_remove_box.Size = new System.Drawing.Size(100, 26);
            this.id_to_remove_box.TabIndex = 1;
            // 
            // ok_to_remove
            // 
            this.ok_to_remove.Location = new System.Drawing.Point(48, 112);
            this.ok_to_remove.Name = "ok_to_remove";
            this.ok_to_remove.Size = new System.Drawing.Size(75, 23);
            this.ok_to_remove.TabIndex = 2;
            this.ok_to_remove.Text = "OK";
            this.ok_to_remove.UseVisualStyleBackColor = true;
            this.ok_to_remove.Click += new System.EventHandler(this.ok_to_remove_Click);
            // 
            // cancel_remove
            // 
            this.cancel_remove.Location = new System.Drawing.Point(227, 112);
            this.cancel_remove.Name = "cancel_remove";
            this.cancel_remove.Size = new System.Drawing.Size(75, 23);
            this.cancel_remove.TabIndex = 3;
            this.cancel_remove.Text = "Cancel";
            this.cancel_remove.UseVisualStyleBackColor = true;
            this.cancel_remove.Click += new System.EventHandler(this.cancel_remove_Click);
            // 
            // remove_status
            // 
            this.remove_status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remove_status.AutoSize = true;
            this.remove_status.Location = new System.Drawing.Point(161, 88);
            this.remove_status.Name = "remove_status";
            this.remove_status.Size = new System.Drawing.Size(0, 13);
            this.remove_status.TabIndex = 0;
            // 
            // delete_dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(341, 147);
            this.Controls.Add(this.remove_status);
            this.Controls.Add(this.cancel_remove);
            this.Controls.Add(this.ok_to_remove);
            this.Controls.Add(this.id_to_remove_box);
            this.Controls.Add(this.delete_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delete_dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label delete_label;
        private System.Windows.Forms.TextBox id_to_remove_box;
        private System.Windows.Forms.Button ok_to_remove;
        private System.Windows.Forms.Button cancel_remove;
        private System.Windows.Forms.Label remove_status;
    }
}