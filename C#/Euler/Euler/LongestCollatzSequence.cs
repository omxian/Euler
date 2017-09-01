using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class LongestCollatzSequence
    {
        //普通循环,暴力计算
        public int Solution1(int target)
        {
            int maxCounter = 0;
            int lastNumber = 0;

            for (int i = 1; i < target; i++)
            {
                long n = i;
                int counter = 1;

                while (n != 1)
                {
                    counter++;
                    n = (n & 1) == 0 ? n / 2 : 3 * n + 1;
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    lastNumber = i;
                }
            }

            return lastNumber;
        }

        private int maxCacheCount = 100000;
        //使用缓存 + 尾调用 性能并没有提高，反而下降了原来1s,现在4s
        private Dictionary<long, int> cache = new Dictionary<long, int>();
        public int Solution2(int target)
        {
            cache.Add(1, 1);
            int max = -1;
            int num = -1;

            for (int i = 1; i < target; i++)
            {
                int currentChainNumber = FindChainNumber(i,0);
                if (max < currentChainNumber)
                {
                    max = currentChainNumber;
                    num = i;
                }
            }

            return num;
        }

        private int FindChainNumber(long num, int count)
        {
            if (!cache.ContainsKey(num))
            {
                if (cache.Count < maxCacheCount)
                {
                    return FindChainNumber((num & 1) == 0 ? num / 2 : 3 * num + 1, count+1);
                }
                else
                {
                    cache.Add(num, FindChainNumber((num & 1) == 0 ? num / 2 : 3 * num + 1, count+1));
                    return cache[num]+count;
                }
            }
            else
            {
                return cache[num]+count;
            }
        }
    }
}
