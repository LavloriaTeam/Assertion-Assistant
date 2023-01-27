using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assertion_Assistant.HelpForms
{
    public partial class Notify : Form
    {
        public Notify()
        {
            InitializeComponent();
        }

        private void airForm1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Notify_Load(object sender, EventArgs e)
        {
            materialLabel1.Text = File.ReadAllText("userData\\notify.txt");
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
