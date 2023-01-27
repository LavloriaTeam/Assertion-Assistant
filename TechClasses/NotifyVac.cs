using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Assertion_Assistant.HelpForms;

namespace Assertion_Assistant.TechClasses
{
    public class NotifyVac
    {
        public void showNotify(string text)
        {
            File.WriteAllText("userData\\notify.txt", text);

            Notify notify = new Notify();
            notify.Show();
        }
    }
}
