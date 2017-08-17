using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class SmallestMultiple
    {
        //key某个数字，value单次分解数量
        Dictionary<int, int> numberDecompose = new Dictionary<int, int>();

        /// <summary>
        /// 朴素的计算方式，没有想到更深入的一层
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public long Solution1(int n)
        {
            for (int current = 2; current <= n; current++)
            {
                CountNumberDictionary(current);
            }

            return GetResult();
        }

        private void CountNumberDictionary(int num)
        {
            int target = num;
            Dictionary<int, int> result = new Dictionary<int, int>();

            while (true)
            {
                for (int i = 2; i <= target; i++)
                {
                    if (target % i == 0)
                    {
                        if (result.ContainsKey(i))
                        {
                            result[i] += 1;
                        }
                        else
                        {
                            result.Add(i, 1);
                        }

                        target = target / i;
                        break;
                    }
                }

                if (target == 1)
                {
                    break;
                }
            }

            foreach (KeyValuePair<int, int> kvp in result)
            {
                if (numberDecompose.ContainsKey(kvp.Key))
                {
                    numberDecompose[kvp.Key] = Math.Max(kvp.Value, numberDecompose[kvp.Key]);
                }
                else
                {
                    numberDecompose.Add(kvp.Key, kvp.Value);
                }
            }
        }

        /// <summary>
        /// 计算结果
        /// </summary>
        private long GetResult()
        {
            long result = 1;
            foreach (KeyValuePair<int, int> kvp in numberDecompose)
            {
                result *= (long)Math.Pow(kvp.Key, kvp.Value);
            }
            return result;
        }


        /// <summary>
        /// 1.先计算出小于等于n的所有素数
        /// 2.计算结果
        /// 结果等于 所有素数的 Math.Pow(pList[i], Math.Floor(Math.Log(n,pList[i])) 乘积
        /// 如 n = 5 则 2^2 * 3^1 * 5^1
        /// n = 5 则 2^4 * 3^2 * 5^1 * 11^1 * ... *19^1;
        /// </summary>
        public long Solution2(int n)
        {
            List<int> pList = new List<int>();
            GetPrimeList(pList,n);

            int result = 1;

            for (int i = 0; i < pList.Count; i++)
            {
                result *= (int)Math.Pow(pList[i], Math.Floor(Math.Log(n,pList[i])));
            }

            return result;
        }

        /// <summary>
        /// 求2->n中的所有素数
        /// </summary>
        private void GetPrimeList(List<int> list,int target)
        {
            for (int number = 2; number <= target; number++)
            {
                for (int divisor = 2; divisor < number; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        goto nextNumber;
                    }
                }
                list.Add(number);
                nextNumber:;
            }
        }
    }
}
