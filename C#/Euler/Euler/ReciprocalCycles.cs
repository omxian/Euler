using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class ReciprocalCycles
    {
        //denominators 
        public int maxDenominators = int.MinValue;
        public int maxFractionsCount = int.MinValue;
        //指定范围
        private int range = 0;

        //问题分为两步：
        //一是如何构建出高精度的浮点数
        //二是计算出数字循环尾巴有几位
        public int Find(int num)
        {
            range = num * 3;
            for (int i = 3; i < num; i++)
            {
                CreateNumber(i);
            }
            return maxDenominators;
        }
        public void CreateNumber(int d)
        {
            //如果能除尽则返回
            if (IsLimitedNumber(d))
            {
                CompareResult(d, 0);
                return;
            }

            //思路：
            //将位数放大n倍,使用BigInteger计算出尾巴
            BigInteger bigF = BigInteger.Pow(BigInteger.One * 10, range);
            BigInteger bigD = d;
            BigInteger result = bigF / d;

            //根据尾巴计算出循环次数
            CompareNumberCyclesPart(d, result.ToString());
        }

        private void CompareResult(int d,int f)
        {
            if (maxFractionsCount < f)
            {
                maxFractionsCount = f;
                maxDenominators = d;
            }
        }

        //是否能除尽
        //其实看分母除了2,5的因子是否为1或-1
        private bool IsLimitedNumber(int num)
        {
            if (num == 0)
            {
                throw new Exception("Denominator can't be 0");
            }

            while (num % 2 == 0)
            {
                num /= 2;
            }

            while (num % 5 == 0)
            {
                num /= 5;
            }

            return (num == 1 || num == -1);
        }

        //计算出数字循环尾巴有几位
        private void CompareNumberCyclesPart(int d,string numberStr)
        {
            numberStr = Helper.ReverseString(numberStr);
            string compareStr = numberStr[0].ToString();
            while (true)
            {
                int index = numberStr.IndexOf(compareStr, compareStr.Length);
                if (index != -1)
                {
                    compareStr = numberStr.Substring(0, index);

                    bool isCycles = NextStr(numberStr, compareStr, compareStr.Length);

                    if (isCycles)
                    {
                        CompareResult(d, compareStr.Length);
                        break;
                    }
                    else
                    {
                        compareStr = numberStr.Substring(0, index + 1);
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public bool NextStr(string tail, string cycles, int startIndex)
        {
            int index = tail.IndexOf(cycles, startIndex);
            int nextIndex = tail.IndexOf(cycles, index + cycles.Length);
            if (index != -1 && nextIndex != -1 && (nextIndex - index) == cycles.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
