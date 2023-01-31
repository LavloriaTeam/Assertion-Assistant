using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Assertion_Assistant.MainForms;

namespace Assertion_Assistant.TechClasses
{
    internal class CommandLineInput
    {
        public void CheckCmd()
        {
            if (File.Exists("commandline.txt"))
            {
                string tempCmd = File.ReadAllText("commandline.txt");

                switch (tempCmd)
                {
                    case "noExistWelcomeForm":
                        HomeForm hs = new HomeForm();
                        hs.Show();
                        break;
                    case "anonimModeActive":
                        HomeForm hs2 = new HomeForm();
                        hs2.Show();

                        if (File.Exists("userData\\userProfile.json"))
                        {
                            File.Delete("userData\\userProfile.json");
                        }
                        break;
                }
            }
        }
    }
}
