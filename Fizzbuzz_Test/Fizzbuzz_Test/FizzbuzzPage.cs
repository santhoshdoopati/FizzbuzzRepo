using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace Fizzbuzz_Test
{
    public class FizzbuzzPage
    {
        //Enter values in the page and click submit
        public void EnterValues(string startingNumber, string Limit, IWebDriver driver)
        {
            IWebElement startingNum = driver.FindElement(By.XPath("")); //Xpath value as per the application structure
            IWebElement limit = driver.FindElement(By.XPath("")); //Xpath value as per the application structure
            IWebElement submit = driver.FindElement(By.XPath("")); //Xpath value as per the application structure

            startingNum.SendKeys(startingNumber.ToString());
            limit.SendKeys(Limit.ToString());
            submit.Click();

        }

        //Read app generated Fizzbuzz result
        public string GetResultValue(IWebDriver driver)
        {
            IWebElement outputText = driver.FindElement(By.XPath("")); //Xpath value as per the application structure

            return outputText.GetAttribute("value");
        }
    }
}
