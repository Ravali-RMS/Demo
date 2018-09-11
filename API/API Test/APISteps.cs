using TechTalk.SpecFlow;
using RestSharp;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace API_Test
{
    [Binding]
    public class APISteps:Configuration
    {
        IWebDriver driver;
        private RestClient restClient;
        private RestRequest restRequest;
        private IRestResponse restResponse;

        [Given(@"I have HTTP Url '(.*)'")]
        public void GivenIHaveHTTPUrl(string requestUrl)
        {
            restClient = new RestClient(APIBASEURL);
            restClient = new RestClient(APIPOSTURL);
            restClient = new RestClient(RatesAPIBASEURL);
            restRequest = new RestRequest(requestUrl, Method.GET);
            restRequest = new RestRequest(requestUrl, Method.POST);
            
        }


        [Given(@"I have Url ""(.*)""")]
        public void GivenIHaveUrl(string Url)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();

        }

        [When(@"I execute GET request")]
        public void WhenIExecuteGETRequest()
        {
            restResponse = restClient.Execute(restRequest);
        }

        [When(@"I Post the body '(.*)'")]
        public void WhenIPostTheBody(string body)
        {
            restResponse = restClient.Execute(restRequest);
        }

        [When(@"I fill in username with ""(.*)""")]
        public void WhenIFillInUsernameWith(string Username)
        {
            driver.FindElement(By.Id("login-form-username")).SendKeys(Username);
        }

        [When(@"I fill in password with ""(.*)""")]
        public void WhenIFillInPasswordWith(string Password)
        {
            driver.FindElement(By.Id("login-form-password")).SendKeys(Password);
        }

        [When(@"I press ""(.*)""")]
        public void WhenIPress(string p0)
        {
            driver.FindElement(By.Id("login")).Click();
        }
        [Then(@"the response code is (.*)")]
        public void ThenTheResponseCodeIs(string responseCode)
        {
            Assert.AreEqual( "200" , responseCode);
        }
        [Then(@"the acquirerId is '(.*)'")]
        public void ThenTheAcquirerIdIs(string acquirerId)
        {
            Assert.AreEqual("EMS.UK", acquirerId);
        }

        [Then(@"the title is '(.*)'")]
        public void ThenTheTitleIs(string title)
        {
            Assert.AreEqual("Elavon UK", title);
        }

        [Then(@"the acquirerCode is '(.*)'")]
        public void ThenTheAcquirerCodeIs(string acquirerCode)
        {
            Assert.AreEqual("EMS", acquirerCode);
        }

        [Then(@"the countryCode is '(.*)'")]
        public void ThenTheCountryCodeIs(string countryCode)
        {
            Assert.AreEqual("UK", countryCode);
        }

        [Then(@"the currencyCode is '(.*)'")]
        public void ThenTheCurrencyCodeIs(string currencyCode)
        {
            Assert.AreEqual("GBP", currencyCode);
        }
                  
        [Then(@"the response is '(.*)'")]
        public void ThenTheResponseIs(string response)
        {
            Assert.AreEqual("SEEMLESS ONBOARDING", response);
            TestContext.WriteLine("response, Passed");
        }

        [Then(@"I should see ""(.*)"" highlighted in the home page")]
        public void ThenIShouldSeeHighlightedInTheHomePage(string Create)
        {
            Thread.Sleep(1000);
            driver.FindElement(By.Id("create-menu")).Click();
            driver.Close();
        }
                       

    }
}
