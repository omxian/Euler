using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class NumberLetterCounts
    {
        int[] number10To100 = new int[] {0,3,6,6,5,5,5,7,6,6};
        int[] number1To20 = new int[] {0,3,3,5,4,4,3,5,5,4,3,6,6,8,8,7,7,9,8,8,6};
        public int Solution(int toNumber)
        {
            int count = 0;
            for(int i=1; i<= toNumber; i++)
            {
                count += Count(i);
            }

            return count;
        }

        public int Count(int num)
        {
            int count = 0;
            if (num <= 999)
            {
                int hun = num / 100;
                int remain = num % 100;
                int ten = remain / 10;
                int one = num % 10;

                if (hun != 0)
                {
                    count += (7 + number1To20[hun]);
                }

                if (remain > 0 && hun != 0)
                {
                    //and
                    count += 3;
                }

                if(remain <= 20)
                {
                    count += number1To20[remain];
                }
                else
                {
                    if (ten != 0)
                    {
                        count += number10To100[ten];
                    }

                    if (one != 0)
                    {
                        count += number1To20[one];
                    }
                }
            }
            else if (num == 1000)
            {
                count += 11;
            }
            return count;
        }
    }
}
