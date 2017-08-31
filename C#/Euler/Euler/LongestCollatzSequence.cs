using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class LongestCollatzSequence
    {
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

                    if (n % 2 == 0)
                    {
                        n /= 2;
                    }
                    else
                    {
                        n = 3 * n + 1;
                    }
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    lastNumber = i;
                }
            }

            //最后需要输出数字，而不是计数
            //醉了折腾半小时- -，英语不好真是硬伤
            return lastNumber;
        }
    }
}
