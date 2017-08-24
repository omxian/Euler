using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class SummationOfPrimes
    {
        public long Solution1(long number)
        {
            long result = 0;
            for (long i = 2; i < number; i++)
            {
                if (Helper.IsPrime(i))
                {
                    result += i;
                }
            }
            return result;
        }
    }
}
