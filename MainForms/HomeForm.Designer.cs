namespace Assertion_Assistant.MainForms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.dungeonRichTextBox1 = new ReaLTaiizor.Controls.DungeonRichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bigLabel1.Location = new System.Drawing.Point(-59, 9);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(857, 32);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "The best affirmation";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bigLabel2
            // 
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 23F);
            this.bigLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.bigLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bigLabel2.Location = new System.Drawing.Point(12, 41);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(708, 132);
            this.bigLabel2.TabIndex = 1;
            this.bigLabel2.Text = "#fa";
            this.bigLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(526, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 174);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bigLabel3
            // 
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.bigLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bigLabel3.Location = new System.Drawing.Point(-141, 228);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(590, 32);
            this.bigLabel3.TabIndex = 3;
            this.bigLabel3.Text = "This tip can help you";
            this.bigLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dungeonRichTextBox1
            // 
            this.dungeonRichTextBox1.AutoWordSelection = false;
            this.dungeonRichTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonRichTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dungeonRichTextBox1.EdgeColor = System.Drawing.Color.White;
            this.dungeonRichTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dungeonRichTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.dungeonRichTextBox1.Location = new System.Drawing.Point(19, 266);
            this.dungeonRichTextBox1.Name = "dungeonRichTextBox1";
            this.dungeonRichTextBox1.ReadOnly = true;
            this.dungeonRichTextBox1.Size = new System.Drawing.Size(370, 63);
            this.dungeonRichTextBox1.TabIndex = 4;
            this.dungeonRichTextBox1.Text = "advice type";
            this.dungeonRichTextBox1.TextBackColor = System.Drawing.Color.White;
            this.dungeonRichTextBox1.WordWrap = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(12, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 58);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(870, 404);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dungeonRichTextBox1);
            this.Controls.Add(this.bigLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bigLabel2);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.DungeonRichTextBox dungeonRichTextBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}