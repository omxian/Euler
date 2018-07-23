using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    //找到所有不能被写作两个过剩数之和的所有数字之和
    public class NonAbundantSums
    {
        private List<int> abundantNumList = new List<int>();
        //已知超过28123的数字都能够写作两个过剩数之和
        private int maxNonAbundantNum = 28123;

        public int Find()
        {
            FindAllAbundantNum();
            return GetSumOfNonAbundant();
        }

        //数字是否过剩数
        public bool IsAbundantNum(int num)
        {
            int sum = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }

            return sum > num;
        }


        //找到所有小于等于28123的所有过剩数
        private void FindAllAbundantNum()
        {
            for (int i = 1; i <= maxNonAbundantNum; i++)
            {
                if (IsAbundantNum(i))
                {
                    abundantNumList.Add(i);
                }
            }
        }

        //获得不能够被写作两个过剩数之和的数字之和
        private int GetSumOfNonAbundant()
        {
            int sum = 0;
            for (int targetNum = 1; targetNum <= maxNonAbundantNum; targetNum++)
            {
                bool nonAbundantFlag = false;

                for (int index = 0; index < abundantNumList.Count; index++)
                {
                    int abundantNum = abundantNumList[index];

                    //如果数字小于过剩数，不可以写作两个过剩数之和
                    if (targetNum < abundantNum)
                    {
                        nonAbundantFlag = true;
                        break;
                    }

                    //差如果在过剩数列表中,可以写作两个过剩数之和
                    int sub = targetNum - abundantNum;
                    if (abundantNumList.IndexOf(sub) != -1)
                    {
                        break;
                    }
                }

                if (nonAbundantFlag)
                {
                    sum += targetNum;
                }
            }
            return sum;
        }
    }
}
