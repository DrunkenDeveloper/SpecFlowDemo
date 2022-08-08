using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SpecFlow.Actions.WindowsAppDriver;

namespace WorkingDirTest.SpecFlow.Steps.WindowForm
{
    public class Form : FormElements
    {
        public Form(AppDriver appDriver) : base(appDriver)
        {
        }

        public void ClickButton()
        {
            Button.Click();
        }

        public string GetLableText()
        {
            return Lable.Text;
        }
    }
}
