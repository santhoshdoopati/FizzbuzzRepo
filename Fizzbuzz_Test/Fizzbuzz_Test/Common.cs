using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Linq;
using System.Xml;
using System.Threading.Tasks;

namespace Fizzbuzz_Test
{
    public class CommonFunctions
    {

        //Wait to load the page completely
        public void WaitForPageLoad(IWebDriver driver, int waitTimeInSec)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string script = "return document.readystate()";

            if (js.ExecuteScript(script).ToString().Equals("complete"))
            {
                return;
            }
            else
            {
                for(int i=0; i< waitTimeInSec; i++)
                {
                    Thread.Sleep(1000);

                    if (js.ExecuteScript(script).ToString().Equals("complete"))
                    {
                        break;
                    }
                }

                try
                {

                }catch (Exception ex)
                {
                    Assert.Fail("Page could not be loaded. Exception details: " + ex);
                }
                
            }
        }

        //Get data from Test file
        public string getData(string TagName)
        {
            //string directoryPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            //string path = directoryPath + "Testdata\\Testdata.xml";
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory.Replace("/bin/Debug/netcoreapp3.1", "");
            string path = directoryPath + "Testdata/Testdata.xml";
            string text = System.IO.File.ReadAllText(path);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(text);
            XmlNodeList nodeList = xmlDocument.SelectNodes("/Testdata");
            string value = null;
            foreach (XmlNode xnode in nodeList)
            {
                value = xnode[TagName].InnerText;
            }
            return value;
        }

        public async Task<string> returnValue()
        {
            return getData("mockReturnValue");
        }

        public bool compareResult(string expected, string actual)
        {
            if (string.Compare(actual, expected) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
