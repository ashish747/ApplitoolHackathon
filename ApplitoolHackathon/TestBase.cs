using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applitools;
using Applitools.Selenium;

namespace ApplitoolHackathonHelpers
{
    [TestFixture]
    public class TestBase
    {
        public static Browser Browser { get; set; }
        private static EyesRunner runner;
        private static Eyes eyes;
        public static string TestName;
        public bool VerifyWithAppli;

        public TestBase()
        {
            VerifyWithAppli = true;
            

        }

        [SetUp]
        public void SetUp()
        {
            Browser = new Browser();
            runner = new ClassicRunner();
            eyes = new Eyes(runner);
            eyes.ApiKey = "0xw5r102V6gfG1D110oLi9eGjRKjrE8GHipiUfuD50dyZl0110";
            System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12;
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Close();
            eyes.AbortIfNotClosed();

            //Wait and collect all test results
            TestResultsSummary allTestResults = runner.GetAllTestResults();
        }

        public void VerifyApplieye(string label)
        {
            eyes.Open(Browser.driver, "Demo App", label+TestName, new System.Drawing.Size(1024, 800));
            eyes.CheckWindow(label + TestName);
            eyes.CloseAsync();
         }
    }
}

