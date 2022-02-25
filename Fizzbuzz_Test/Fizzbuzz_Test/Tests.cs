using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;


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

            string expected = expectedFizzbuzz.FizzbuzzResult(Convert.ToInt32(common.getData("startingNumber")),
                                        Convert.ToInt32(common.getData("limit")));
            string actual = resultClass.getResponse().ToString();

            if (string.Compare(actual, expected) == 0)
            {
                Assert.Pass();
            }
            else if(actual == "null")
            {
                Assert.Fail();
            }
            else
            {
                Assert.Fail();
            }
        }

        [TearDown]
        public void EndTest()
        {
            //driver.Quit();
        }
    }
}
