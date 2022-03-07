using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fizzbuzz_Test
{
    public class ResultClass
    {
        public async Task<string> getResponse()
        {
            var builder = new WebHostBuilder().UseContentRoot(@"C://application").UseEnvironment("Dev").UseStartup<Fizzbuzz_Test.Tests>().UseTestServer();
            TestServer server = new TestServer(builder);
            HttpClient client = server.CreateClient();
            HttpResponseMessage response = await client.GetAsync("/uri");

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().ToString();

            }
            else
            {
                return "null";
            }    

        }

        
    }
}
