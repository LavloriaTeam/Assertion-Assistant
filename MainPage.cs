using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Assertion_Assistant.MainForms;

namespace Assertion_Assistant
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void MainPage_Load(object sender, EventArgs e)
        {
            if (!File.Exists("userData\\userProfile.json"))
            {
                WelcomeForm wf = new WelcomeForm();
                wf.ShowDialog();

                if (!File.Exists("userData\\userProfile.json"))
                {
                    Application.Exit();
                }
            }

            // load start page
            HomeForm myForm = new HomeForm();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            NotepadForm myForm = new NotepadForm();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            HomeForm myForm = new HomeForm();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            MusicForm myForm = new MusicForm();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ProfileForm myForm = new ProfileForm();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            GoalsForm myForm = new GoalsForm();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel2.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
