using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class SumSquareDifference
    {
        /// <summary>
        /// 这是比较粗暴的计算方式
        /// 在targetNumber很大的情况下会很慢
        /// </summary>
        /// <param name="targetNumber"></param>
        /// <returns></returns>
        public long Solution1(int targetNumber)
        {
            //加->平方
            long sumSquare = 0;
            //平方->加
            long squareSum = 0;

            for (int i = 1; i <= targetNumber; i++)
            {
                squareSum += i * i;
                sumSquare += i;
            }

            return (long)Math.Pow(sumSquare,2) - squareSum;
        }

        /// <summary>
        /// 使用公式直接计算
        /// </summary>
        public long Solution2(int targetNumber)
        {
            //等差数列求和 -> 平方
            long sumSquare = targetNumber*(targetNumber+1)/2;
            sumSquare *= sumSquare;
            //平方和公式
            long squareSum = ((2*targetNumber+1) * (targetNumber +1) * targetNumber)/6;

            return sumSquare - squareSum;
        }
    }
}
