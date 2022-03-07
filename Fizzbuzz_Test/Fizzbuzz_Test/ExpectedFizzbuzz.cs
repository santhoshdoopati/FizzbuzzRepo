using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;



namespace Fizzbuzz_Test
{
    public class ExpectedFizzbuzz
    {
        //Get Fizzbuzz sequence result as per usecase requirement
        //public string FizzbuzzResult(int startingNumber, int limit)
        //{
        //    IEnumerable<int> sequence = Enumerable.Range(startingNumber, limit);
        //    List<string> resultString = new List<string>();
        //    string r = null;
        //    int i = 0;

        //    foreach (int n in sequence)
        //    {
        //        if(n % 3 == 0 && n % 5 == 0)
        //        {
        //            r = "FIZZBUZZ,'";
        //        }else if(n % 3 == 0)
        //        {
        //            r = "FIZZ,";
        //        }else if(n % 5 == 0)
        //        {
        //            r = "BUZZ,";
        //        }
        //        else
        //        {
        //            r = n.ToString()+ ",";
        //        } 

        //        resultString[i] = r;
        //        i = i + 1;

                
        //    }
        //    return resultString.ToString();
        //}

        public string FizzbuzzResult(int startNum, int limit)
        {
            string fizzBuzz = string.Empty;
            string[] result = new string[(limit - startNum) + 1];
            int x = 0;
            for (int i = startNum; i <= limit; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    result[x] = "FIZZBUZZ";
                }
                else if (i % 3 == 0)
                {
                    result[x] = "FIZZ";
                }
                else if (i % 5 == 0)
                {
                    result[x] = "BUZZ";

                }
                else
                    result[x] = i.ToString();
                x++;
            }
            fizzBuzz = string.Join(",", result);

            if (result == null)
            {
                return "null";
            }
            return fizzBuzz;
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
                    r = "BUZZ,";
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
