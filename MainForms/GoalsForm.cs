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
using Newtonsoft.Json;
using Assertion_Assistant.JsonData;
using Assertion_Assistant.TechForms;

namespace Assertion_Assistant.MainForms
{
    public partial class GoalsForm : Form
    {
        public GoalsForm()
        {
            InitializeComponent();
        }

        private void circleProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void GoalsForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("userData\\userGoal.json"))
            {
                string input = File.ReadAllText("userData\\userGoal.json");
                var output = JsonConvert.DeserializeObject<userGoal>(input);

                hopeRichTextBox1.Text = output.goalText;
                circleProgressBar1.Maximum = output.goalSteps;
                labelEdit1.Text = output.goalName;
            }
            else
            {
                CreateNewGoal cng = new CreateNewGoal();
                cng.ShowDialog();

                if (File.Exists("userData\\userGoal.json"))
                {
                    string input = File.ReadAllText("userData\\userGoal.json");
                    var output = JsonConvert.DeserializeObject<userGoal>(input);

                    hopeRichTextBox1.Text = output.goalText;
                    circleProgressBar1.Maximum = output.goalSteps;
                    labelEdit1.Text = output.goalName;
                    circleProgressBar1.Value = output.activyStep;
                }
                else
                {
                    try
                    { 
                        Close();
                    }
                    catch { }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circleProgressBar1.Value++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            circleProgressBar1.Value--;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists("userData\\userGoal.json"))
            {
               userGoal ug = new userGoal();
                ug.goalText = hopeRichTextBox1.Text;
                ug.activyStep = Convert.ToInt32(circleProgressBar1.Value);

                string output = JsonConvert.SerializeObject(ug);
                File.WriteAllText("userData\\userGoal.json", output);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Delete("userData\\userGoal.json");
            CreateNewGoal cng = new CreateNewGoal();
            cng.ShowDialog();
        }
    }
}
