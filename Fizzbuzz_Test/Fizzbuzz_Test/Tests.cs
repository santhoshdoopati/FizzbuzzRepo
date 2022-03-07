using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using Moq;
using System.Threading.Tasks;




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

           
            Mock<ResultClass> mck = new Mock<ResultClass>();
            mck.Setup(t => t.getResponse()).Returns(common.returnValue());
            bool flag = common.compareResult(expected, mck.Object.ToString());

            if (flag)
            {
                Assert.Pass();
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
