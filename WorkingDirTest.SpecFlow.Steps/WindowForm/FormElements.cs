using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

using SpecFlow.Actions.WindowsAppDriver;

namespace WorkingDirTest.SpecFlow.Steps.WindowForm
{
    public class FormElements
    {
        #region AutomaticAppiumConfiguratrion_DoesntWork

        //AppDriver _appDriver;
        //public FormElements(AppDriver appDriver)
        //{
        //    _appDriver = appDriver;
        //}

        //public WindowsElement Button =>
        //    _appDriver.Current.FindElementByAccessibilityId("Test");

        //public WindowsElement Lable =>
        //    _appDriver.Current.FindElementByAccessibilityId("Test_Lable");

        #endregion AutomaticAppiumConfiguratrion_DoesntWork

        #region ManuelAppiumConfiguration_Works

        Dictionary<string, string> appiumCapabilties = new Dictionary<string, string>()
        {
            { "platformName", "windows"},
            { "automationName", "windows" },
            { "app", "../../../../WorkingDirTest/bin/Debug/net6.0-windows/WorkingDirTest.exe" },
            { "appWorkingDir", "../../../../WorkingDirTest/bin/Debug/net6.0-windows" }

        };

        WindowsDriver<WindowsElement> _windowsElements;
        public FormElements(AppDriver _)
        {

            var options = new AppiumOptions();

            foreach (var capability in appiumCapabilties)
            {
                if (string.Equals(capability.Key, "app", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(capability.Key, "appWorkingDir", StringComparison.OrdinalIgnoreCase))
                {
                    options.AddAdditionalCapability(capability.Key, GetFullPath(capability.Value));
                }
                else
                {
                    options.AddAdditionalCapability(capability.Key, capability.Value);
                }
            }

            _windowsElements = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
        }

        private static string GetFullPath(string path)
        {
            if (Path.IsPathFullyQualified(path))
                return path;
            return Path.Combine(Directory.GetCurrentDirectory(), path);

        }

        public WindowsElement Button =>
            _windowsElements.FindElementByAccessibilityId("Test");

        public WindowsElement Lable =>
            _windowsElements.FindElementByAccessibilityId("Test_Lable");

        #endregion ManuelAppiumConfiguration_Works
    }
}