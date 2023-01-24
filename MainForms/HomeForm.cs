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
using Assertion_Assistant.Dictionary;
using Assertion_Assistant.JsonData;

namespace Assertion_Assistant.MainForms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        void HomeForm_Load(object sender, EventArgs e)
        {
            // Loading
            bigLabel2.Text = LoadAffirmation();
            dungeonRichTextBox1.Text = LoadAdvice();
            LoadImage();
            //
        }

        string LoadAffirmation()
        {
            // Load Affirmation 
            Affirmations afir = new Affirmations();
            string output = afir.GiveAffirmation();
            return output;
        }

        void LoadImage()
        {
            // deserialization 
            string input = File.ReadAllText("userData\\userProfile.json");
            var profile = JsonConvert.DeserializeObject<userProfile>(input);
            
            // select image 
            string imagePath = $@"Data\Resources\Icons\Moods\{profile.Goal}.png";
            // load image
            pictureBox1.BackgroundImage = Image.FromFile(imagePath);
        }

        string LoadAdvice()
        {
            Advices advices = new Advices();
            return advices.GiveAdvice();
        }
    }
}
