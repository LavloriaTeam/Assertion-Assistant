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
using Assertion_Assistant.Translations;
using System.IO;
using System.Diagnostics;
using Assertion_Assistant.JsonData;

namespace Assertion_Assistant
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void button1_Click(object sender, EventArgs e)
        {
            // Serialization 
            if (dungeonTextBox1.Text != "" && aloneComboBox1.Text != "" && aloneComboBox2.Text != "" && aloneComboBox3.Text != "")
            {
                NewProfileRegisration();
            }

            // Load Programm
            Process.Start("startApp.bat");
            Application.Exit();
        }

        void NewProfileRegisration()
        {
            userProfile newuser = new userProfile();
            newuser.Name = dungeonTextBox1.Text;
            newuser.Age = aloneComboBox3.Text;
            newuser.Mood = aloneComboBox1.Text;
            newuser.Goal = aloneComboBox2.Text;

            string output = JsonConvert.SerializeObject(newuser);

            if (!Directory.Exists("userData"))
            {
                Directory.CreateDirectory("userData");
            }

            File.WriteAllText("userData\\userProfile.json", output);
        }
    }
}
