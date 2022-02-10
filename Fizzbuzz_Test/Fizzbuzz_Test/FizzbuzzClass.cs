using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Fizzbuzz_Test
{
    public class FizzbuzzClass
    {
        //Get Fizzbuzz sequence result as per usecase requirement
        public string FizzbuzzResult(int startingNumber, int limit)
        {
            IEnumerable<int> sequence = Enumerable.Range(startingNumber, limit);
            IList<string> resultString = null;
            string r = null;
            int i = 0;

            foreach (int n in sequence)
            {
                if(n % 3 == 0 && n % 5 == 0)
                {
                    r = "fizzbuzz,'";
                }else if(n % 3 == 0)
                {
                    r = "fizz,";
                }else if(n % 5 == 0)
                {
                    r = "buzz,";
                }
                else
                {
                    r = n.ToString()+ ",";
                } 

                resultString[i] = r;
                i = i + 1;

                
            }
            return resultString.ToString();
        }

        public string GetBuzzResultOnly(int startingNumber, int limit)
        {
            IEnumerable<int> sequence = Enumerable.Range(startingNumber, limit);
            IList<string> resultString = null;
            string r = null;
            int i = 0;

            foreach (int n in sequence)
            {
                if (n % 5 == 0)
                {
                    r = "buzz,";
                }
                else
                {
                    r = n.ToString() + ",";
                }

                resultString[i] = r;
                i = i + 1;
            }

            //Assuming Buzz part is not implemented completely
            return "";
        }
    }
}
