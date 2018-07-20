using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    //思路就是用List来处理大数字，List每一位对应进制
    public class FactorialDigitSum
    {
        private List<int> bigInt = new List<int>() { 1 };

        public int Count(int factorial)
        {
            CountFactorial(factorial);
            return SumIntList();
        }

        //计算出大数阶乘
        private void CountFactorial(int factorial)
        {
            for (int i = factorial; i > 1; i--)
            {
                for (int j = 0; j < bigInt.Count; j++)
                {
                    bigInt[j] *= i;
                }

                ArrangeBigInt();
            }
        }

        //整理BigInt列表，大于等于10的数字就进位
        private void ArrangeBigInt()
        {
            int carry = 0;
            for (int i = 0; i < bigInt.Count; i++)
            {
                if (carry > 0)
                {
                    bigInt[i] += carry;
                    carry = 0;
                }

                if (bigInt[i] > 9)
                {
                    carry = bigInt[i] / 10;
                    bigInt[i] = bigInt[i] % 10;
                }
            }

            //最后需要特殊处理下,确保没有尾巴
            while (carry > 0)
            {
                bigInt.Add(carry % 10);
                carry = carry / 10;
            }
        }

        //加起来
        private int SumIntList()
        {
            int sum = 0;
            for (int i = 0; i < bigInt.Count; i++)
            {
                sum += bigInt[i];
            }
            return sum;
        }
    }
}
