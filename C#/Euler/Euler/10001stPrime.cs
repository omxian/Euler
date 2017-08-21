using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class _10001stPrime
    {
        //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        //What is the 10 001st prime number?

        public long Solution1(int target)
        {
            long result = -1;
            int count = 0;
            
            for (int i = 2; ; i++)
            {
                if (count == target)
                {
                    break;
                }

                if (Helper.IsPrime(i))
                {
                    result = i;
                    count++;
                }
            }

            return result;
        }
    }
}
