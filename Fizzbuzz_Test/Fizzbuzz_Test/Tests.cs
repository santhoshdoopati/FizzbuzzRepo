using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System;


namespace Fizzbuzz_Test
{
    public class Tests
    {
        CommonFunctions common = new CommonFunctions();
        FizzbuzzClass fizzbuzz = new FizzbuzzClass();
        FizzbuzzPage fizzbuzzPage = new FizzbuzzPage();

        //Webdriver initialization
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            driver.Manage().Window.Maximize();
            //Navigating to the test application
            driver.Navigate().GoToUrl("https://www.appurl/fizzbuzz");
            //Wait to load the page completely
            common.WaitForPageLoad(driver, 25);
        }

        [Test]
        public void VerifyFizzBuzz()
        {
            //Get data and enter values
            fizzbuzzPage.EnterValues(common.getData("startingNumber"), common.getData("limit"), driver);

            //Get result string from the application
            string resultFromApp = fizzbuzzPage.GetResultValue(driver);

            //Actual result string as per usecase requirement
            string actualResult = fizzbuzz.FizzbuzzResult(Convert.ToInt32(common.getData("startingNumber")), Convert.ToInt32(common.getData("limit")));

            if(string.Compare(resultFromApp, actualResult) == 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail("Fizzbuzz sequence series is not as per the requirement");
            }
            
        }

        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
