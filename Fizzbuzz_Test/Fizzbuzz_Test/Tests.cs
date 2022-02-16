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
        ExpectedFizzbuzz expectedFizzbuzz = new ExpectedFizzbuzz();
        ResultClass resultClass = new ResultClass();
        FizzbuzzPage fizzbuzzPage = new FizzbuzzPage();


        //Webdriver initialization
        //IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            /*
            driver.Manage().Window.Maximize();
            //Navigating to the test application
            driver.Navigate().GoToUrl("https://www.appurl/fizzbuzz");
            //Wait to load the page completely
            common.WaitForPageLoad(driver, 25);
            */
        }

        [Test]
        public void VerifyFizzBuzz()
        {

            resultClass.compareResult(Convert.ToInt32(common.getData("startingNumber")),
                                        Convert.ToInt32(common.getData("limit")));

        }

        [TearDown]
        public void EndTest()
        {
            //driver.Quit();
        }
    }
}
