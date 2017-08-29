using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class HighlyDivisibleTriangularNumber
    {
        // What is the value of the first triangle number to have over five hundred divisors?
        //n为需要查找的因子数
        public long Solution1(int n)
        {
            int triangularNumber = 1;
            int index = 1;
            int factorNumber = 1;
            
            while (n > factorNumber)
            {
                index ++;
                //Next Triangular Number
                triangularNumber = index * (index + 1) / 2;

                factorNumber = FindFactorNumber(triangularNumber);
            }

            return triangularNumber;
        }

        /// <summary>
        /// 返回因子数量，优化了下这个方法就可以计算出来了
        /// </summary>
        private int FindFactorNumber(int n)
        {
            int factorNumber = 0;

            for (int i = 1; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    factorNumber += 2;
                }
            }

            if (Math.Sqrt(n) == (int)Math.Sqrt(n))
            {
                factorNumber -= 1;
            }

            return factorNumber;
        }
    }
}
