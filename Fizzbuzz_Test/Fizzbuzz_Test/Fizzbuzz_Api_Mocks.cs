using System;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using System.Collections.Generic;
using Moq;

namespace Fizzbuzz_Test
{
    public class FizzBuzz_Api_Mocks
    {
        public async void ApiResponse(int startingNumber, int limit)
        {
            var uri = "https://apiurl/";
            var input = new Dictionary<string, string> { { "Startingnumber", startingNumber.ToString() }, { "limit", limit.ToString() } };

            var host = new WebHostBuilder().UseContentRoot(uri);
            TestServer server = new TestServer(host);
            HttpClient client = server.CreateClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri) { Content = new FormUrlEncodedContent(input) };
            var response = await client.SendAsync(request);
            var responseString = await response.Content.ReadAsStringAsync();
        }

        //Mocks
        public void VerifyBuzz(int startingValue, int limit)
        {
            FizzbuzzPage fizzbuzzPage = new FizzbuzzPage();

            //Assuming GetBuzzResultOnly method is not implemented completly.
            Mock<FizzbuzzClass> mck = new Mock<FizzbuzzClass>();

            //Actual methods returns null
            mck.Setup(t => t.GetBuzzResultOnly(startingValue, limit)).Returns("buzz");

        }

    }
}
