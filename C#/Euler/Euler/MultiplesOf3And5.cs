using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class MultiplesOf3And5
    {
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000.

        //简单循环,能直观解决问题，但是效率不高
        public int FindSumNumberSolution1(int below)
        {
            int sum = 0;
            for (int i = 1; i < below; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        //直接计算初结果 
        public int FindSumNumberSolution2(int below)
        {
            int d3 = (below - 1) / 3;
            int d5 = (below - 1) / 5;
            //重复计算的部分
            int d15 = (below - 1) / 15;

            //等差数列求和 
            return 3*(d3+1)*d3/2 + 5*(d5+1)*d5/2 - 15*(d15+1)*d15/2;
        }
    }
}
