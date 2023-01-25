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

namespace Assertion_Assistant.TechForms
{
    public partial class CreateNewGoal : Form
    {
        public CreateNewGoal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (moonTextBox1.Text != "" && moonTextBox2.Text != "")
            {
                userGoal us = new userGoal();
                us.goalName = moonTextBox1.Text;
                us.goalSteps = Convert.ToInt32(moonTextBox2.Text);
                us.goalText = "New Goal";

                string input = JsonConvert.SerializeObject(us);
                File.WriteAllText("userData\\userGoal.json", input);
                Close();
            }
        }
    }
}
