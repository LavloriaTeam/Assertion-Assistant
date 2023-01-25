using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Assertion_Assistant.JsonData;
using System.Diagnostics;

namespace Assertion_Assistant.MainForms
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            // DeSearilization
            string input = File.ReadAllText("userData\\userProfile.json");
            var profile = JsonConvert.DeserializeObject<userProfile>(input);

            metroLabel1.Text = $"Name: {profile.Name}\nAge: {profile.Age}\nMood: {profile.Mood}\nGoal: {profile.Goal}";

            // load image

            if (File.Exists("userData\\userImage.json"))
            {
                string input2 = File.ReadAllText("userData\\userImage.json");
                var Images = JsonConvert.DeserializeObject<userImage>(input2);

                pictureBox1.BackgroundImage = Image.FromFile(Images.PhotoUser);
            }

        }

        private void airButton1_Click(object sender, EventArgs e)
        {
            string pathImage = "";
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Image";
            
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pathImage = opf.FileName;
            }

            pictureBox1.BackgroundImage = Image.FromFile(pathImage);  

            userImage us = new userImage();
            us.PhotoUser = pathImage;
            string output = JsonConvert.SerializeObject(us);
            File.WriteAllText("userData\\userImage.json", output);
        }

        private void airButton2_Click(object sender, EventArgs e)
        {
            File.Delete("userData\\userProfile.json");
            Process.Start("startApp.bat");
            Application.Exit();
        }
    }
}
