namespace Word_Article_Writer
{
    partial class articleWriter
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
            this.postTitleLbl = new System.Windows.Forms.Label();
            this.writerSpaceGb = new System.Windows.Forms.GroupBox();
            this.postTitleTb = new System.Windows.Forms.TextBox();
            this.imagePathLbl = new System.Windows.Forms.Label();
            this.imagePathTb = new System.Windows.Forms.TextBox();
            this.articleLbl = new System.Windows.Forms.Label();
            this.articleRtb = new System.Windows.Forms.RichTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.writerSpaceGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // postTitleLbl
            // 
            this.postTitleLbl.AutoSize = true;
            this.postTitleLbl.Location = new System.Drawing.Point(23, 58);
            this.postTitleLbl.Name = "postTitleLbl";
            this.postTitleLbl.Size = new System.Drawing.Size(75, 17);
            this.postTitleLbl.TabIndex = 0;
            this.postTitleLbl.Text = "Post Title :";
            this.postTitleLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // writerSpaceGb
            // 
            this.writerSpaceGb.Controls.Add(this.saveBtn);
            this.writerSpaceGb.Controls.Add(this.articleRtb);
            this.writerSpaceGb.Controls.Add(this.articleLbl);
            this.writerSpaceGb.Controls.Add(this.imagePathTb);
            this.writerSpaceGb.Controls.Add(this.imagePathLbl);
            this.writerSpaceGb.Controls.Add(this.postTitleTb);
            this.writerSpaceGb.Controls.Add(this.postTitleLbl);
            this.writerSpaceGb.Location = new System.Drawing.Point(29, 20);
            this.writerSpaceGb.Name = "writerSpaceGb";
            this.writerSpaceGb.Size = new System.Drawing.Size(813, 460);
            this.writerSpaceGb.TabIndex = 1;
            this.writerSpaceGb.TabStop = false;
            this.writerSpaceGb.Text = "Writer Space";
            // 
            // postTitleTb
            // 
            this.postTitleTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postTitleTb.Location = new System.Drawing.Point(119, 52);
            this.postTitleTb.Name = "postTitleTb";
            this.postTitleTb.Size = new System.Drawing.Size(217, 27);
            this.postTitleTb.TabIndex = 1;
            // 
            // imagePathLbl
            // 
            this.imagePathLbl.AutoSize = true;
            this.imagePathLbl.Location = new System.Drawing.Point(23, 106);
            this.imagePathLbl.Name = "imagePathLbl";
            this.imagePathLbl.Size = new System.Drawing.Size(87, 17);
            this.imagePathLbl.TabIndex = 2;
            this.imagePathLbl.Text = "Image Path :";
            // 
            // imagePathTb
            // 
            this.imagePathTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePathTb.Location = new System.Drawing.Point(119, 100);
            this.imagePathTb.Name = "imagePathTb";
            this.imagePathTb.Size = new System.Drawing.Size(217, 27);
            this.imagePathTb.TabIndex = 3;
            // 
            // articleLbl
            // 
            this.articleLbl.AutoSize = true;
            this.articleLbl.Location = new System.Drawing.Point(26, 188);
            this.articleLbl.Name = "articleLbl";
            this.articleLbl.Size = new System.Drawing.Size(55, 17);
            this.articleLbl.TabIndex = 4;
            this.articleLbl.Text = "Article :";
            // 
            // articleRtb
            // 
            this.articleRtb.Location = new System.Drawing.Point(87, 188);
            this.articleRtb.Name = "articleRtb";
            this.articleRtb.Size = new System.Drawing.Size(420, 236);
            this.articleRtb.TabIndex = 5;
            this.articleRtb.Text = "";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(592, 381);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(134, 43);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // articleWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 511);
            this.Controls.Add(this.writerSpaceGb);
            this.Name = "articleWriter";
            this.Text = "Artie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.articleWriter_FormClosing);
            this.writerSpaceGb.ResumeLayout(false);
            this.writerSpaceGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label postTitleLbl;
        private System.Windows.Forms.GroupBox writerSpaceGb;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.RichTextBox articleRtb;
        private System.Windows.Forms.Label articleLbl;
        private System.Windows.Forms.TextBox imagePathTb;
        private System.Windows.Forms.Label imagePathLbl;
        private System.Windows.Forms.TextBox postTitleTb;
    }
}

