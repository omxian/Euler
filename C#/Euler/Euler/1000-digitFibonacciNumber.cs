using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class _1000_digitFibonacciNumber
    {
        public int Solve()
        {
            BigInteger prevVal = new BigInteger(1);
            BigInteger curVal = new BigInteger(1);
            BigInteger temp;
            int curIndex = 2;
            while (BigInteger.Log10(curVal) < 999)
            {
                temp = curVal;
                curVal += prevVal;
                prevVal = temp;
                curIndex++;
            }

            return curIndex;
        }
    }
}
