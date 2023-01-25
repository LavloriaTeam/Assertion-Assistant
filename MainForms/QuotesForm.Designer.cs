namespace Assertion_Assistant.MainForms
{
    partial class QuotesForm
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
            this.aloneNotice1 = new ReaLTaiizor.Controls.AloneNotice();
            this.SuspendLayout();
            // 
            // aloneNotice1
            // 
            this.aloneNotice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(232)))));
            this.aloneNotice1.BorderColor = System.Drawing.Color.White;
            this.aloneNotice1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aloneNotice1.Cursor = System.Windows.Forms.Cursors.Default;
            this.aloneNotice1.Enabled = false;
            this.aloneNotice1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            this.aloneNotice1.Location = new System.Drawing.Point(133, 401);
            this.aloneNotice1.Multiline = true;
            this.aloneNotice1.Name = "aloneNotice1";
            this.aloneNotice1.ReadOnly = true;
            this.aloneNotice1.Size = new System.Drawing.Size(536, 32);
            this.aloneNotice1.TabIndex = 1;
            this.aloneNotice1.Text = "The function is imperfect and is under development.";
            // 
            // QuotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.aloneNotice1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuotesForm";
            this.Text = "QuotesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.AloneNotice aloneNotice1;
    }
}