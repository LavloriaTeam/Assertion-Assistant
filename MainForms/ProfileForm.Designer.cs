namespace Assertion_Assistant.MainForms
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            this.airButton1 = new ReaLTaiizor.Controls.AirButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.airButton2 = new ReaLTaiizor.Controls.AirButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.metroLabel1.IsDerivedStyle = true;
            this.metroLabel1.Location = new System.Drawing.Point(192, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(552, 160);
            this.metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "metroLabel1";
            this.metroLabel1.ThemeAuthor = "Taiizor";
            this.metroLabel1.ThemeName = "MetroLight";
            // 
            // airButton1
            // 
            this.airButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.airButton1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.airButton1.Image = null;
            this.airButton1.Location = new System.Drawing.Point(12, 178);
            this.airButton1.Name = "airButton1";
            this.airButton1.NoRounding = false;
            this.airButton1.Size = new System.Drawing.Size(174, 30);
            this.airButton1.TabIndex = 2;
            this.airButton1.Text = "Edit Profile Avatar";
            this.airButton1.Transparent = false;
            this.airButton1.Click += new System.EventHandler(this.airButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // airButton2
            // 
            this.airButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.airButton2.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.airButton2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.airButton2.Image = null;
            this.airButton2.Location = new System.Drawing.Point(12, 214);
            this.airButton2.Name = "airButton2";
            this.airButton2.NoRounding = false;
            this.airButton2.Size = new System.Drawing.Size(174, 30);
            this.airButton2.TabIndex = 3;
            this.airButton2.Text = "Change Settings";
            this.airButton2.Transparent = false;
            this.airButton2.Click += new System.EventHandler(this.airButton2_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 347);
            this.Controls.Add(this.airButton2);
            this.Controls.Add(this.airButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private ReaLTaiizor.Controls.AirButton airButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ReaLTaiizor.Controls.AirButton airButton2;
    }
}