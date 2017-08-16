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

            if (num == 16)
            {
                int f = 14;
            }

            while(true)
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
        /// 根据计算结果
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
    }
}
