using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class SpecialPythagoreanTriplet
    {
        /// <summary>
        /// 蛮力法
        /// </summary>
        public int Solution1(int num)
        {
            //最小的三联体 3,4,5
            int i = 3;
            int j = 4;
            int k = num - i - j;

            int product = -1;
            for (i = 3; i < num; i++)
            {
                for (j = i + 1; j < num; j++)
                {
                    k = 1000 - i - j;
                    if (i * i + j * j == k * k)
                    {
                        product = i * j * k;
                    }
                }
            }

            return product;
        }
    }
}
