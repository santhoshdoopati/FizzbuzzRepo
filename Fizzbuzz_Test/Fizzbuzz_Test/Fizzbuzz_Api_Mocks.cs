
/*
using System;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using System.Collections.Generic;
using Moq;
using System.Threading.Tasks;

namespace Fizzbuzz_Test
{
    public class FizzBuzz_Api_Mocks
    {

        //Mocks
        public void VerifyBuzz(int startingValue, int limit)
        {
            FizzbuzzPage fizzbuzzPage = new FizzbuzzPage();

            //Assuming GetBuzzResultOnly method is not implemented completly.
            Mock<ExpectedFizzbuzz> mck = new Mock<ExpectedFizzbuzz>();

            //Actual methods returns null
            mck.Setup(t => t.GetBuzzResultOnly(startingValue, limit)).Returns("buzz");

        }

    }
}

*/