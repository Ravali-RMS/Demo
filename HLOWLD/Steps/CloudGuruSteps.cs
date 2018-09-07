using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Diagnostics;

namespace HLOWLD.Steps
{
    [Binding]
    public class CloudGuruSteps
    {
        IWebDriver driver;
        [Given(@"I have webpage open ""(.*)""")]
        public void GivenIHaveWebpageOpen(string URL)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);
        }
        [When(@"user enters ""(.*)"" in the textfield")]
        public void WhenUserEntersInTheTextfield(string Text)
        {
            driver.FindElement(By.Id("textbox")).SendKeys(Text);

        }

        [When(@"user presses the Click Me button")]
        public void WhenUserPressesTheClickMeButton()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement button = driver.FindElement(By.XPath("//button[contains(text(),'Click me')]"));
            button.Click();
            Thread.Sleep(1000);

            // Displaying alert message		
            IAlert alert = driver.SwitchTo().Alert();
            // Accepting alert	
            alert.Accept();
        }

        [Then(@"the header displays ""(.*)""")]
        public void ThenTheHeaderDisplays(string Text)
        {
            string Displaytext = Text;
            if (Displaytext.Equals(Text))
                Trace.WriteLine("Test Passed");

            else
                Trace.WriteLine("Test Failed");
            driver.Close();
        }
    }
}
