using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using System.Collections.Generic;

namespace Fizzbuzz_Test
{
    public class ResultClass : ExpectedFizzbuzz
    {
        public async void compareResult(int startingNumber, int limit)
        {
            var expectedFizzbuzz = new ExpectedFizzbuzz();
            var uri = "https://apiurl/";
            var input = new Dictionary<string, string> { { "Startingnumber", startingNumber.ToString() }, { "limit", limit.ToString() } };

            var host = new WebHostBuilder().UseContentRoot(uri);
            TestServer server = new TestServer(host);
            HttpClient client = server.CreateClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri) { Content = new FormUrlEncodedContent(input) };
            var response = await client.SendAsync(request);
            //Get expected fizzbuzz
            string expectedResult = expectedFizzbuzz.FizzbuzzResult(startingNumber, limit);

            if (string.Compare(response.ToString(), expectedResult) == 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail("Fizzbuzz sequence series is not as per the requirement");
            }

        }
    }
}
