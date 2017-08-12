using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    //The prime factors of 13195 are 5, 7, 13 and 29.
    //What is the largest prime factor of the number 600851475143 ?
    public class LargestPrimeFactor
    {
        //缓存数据减少计算量
        private Dictionary<long, bool> primeCheck = new Dictionary<long, bool>();
        //素因子列表
        private List<long> primeFactor = new List<long>();

        /// <summary>
        /// 找到数字number的素因子，返回其中最大值
        /// </summary>
        public long Solution1(long number)
        {
            FindPrimeFactor(number);
            return primeFactor.Max();
        }

        private void FindPrimeFactor(long number)
        {
            for (long i = 2; i < number/2; i++)
            {
                long divide = number % i;
                if (divide == 0 && IsPrime(i))
                {
                    primeFactor.Add(i);

                    if (number / i != 1)
                    {
                        FindPrimeFactor(number / i);
                    }
                    return;
                }
            }
            primeFactor.Add(number);
        }


        /// <summary>
        /// 这个思路尝试直接算出最大因子，效率上反而适得其反
        /// 因为IsPrime函数就是一个2->n/2的for循环
        /// 在输入的值很大的时候性能不行
        /// 而且关键是这样子算出来的只是最大素数组成部分，并不是素因子
        /// </summary>
        private long FindMaxFactor(long number)
        {
            for (long i = number / 2; i > 1; i--)
            {
                long divide = number % i;
                if (divide == 0 && IsPrime(i))
                {
                    return i;
                }
            }
            return -1;
        }

        //素数检查
        private bool IsPrime(long number)
        {
            if (primeCheck.ContainsKey(number))
            {
                return primeCheck[number];
            }

            for (long i = 2; i < number/2; i++)
            {
                if (number % i == 0)
                {
                    primeCheck.Add(number,false);
                    return false;
                }
            }
            primeCheck.Add(number,true);
            return true;
        }
    }
}
