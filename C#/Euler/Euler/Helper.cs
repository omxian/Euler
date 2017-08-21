using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class Helper
    {
        /// <summary>
        /// 是否为偶数
        /// </summary>
        public static bool IsEven(long num)
        {
            return (num & 1) == 0;
        }

        /// <summary>
        /// 反转字符串
        /// </summary>
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        //缓存数据减少计算量
        private static Dictionary<long, bool> primeCheck = new Dictionary<long, bool>();
        //素数检查
        public static bool IsPrime(long number)
        {
            if (primeCheck.ContainsKey(number))
            {
                return primeCheck[number];
            }

            if (number < 2) // 负数，0，1 false
            {
                primeCheck.Add(number, false);
                return false;
            }
            else if (number < 4) // 2,3 true
            {
                primeCheck.Add(number, true);
                return true;
            }
            else if (number % 2 == 0) //能被2整除 false
            {
                primeCheck.Add(number, false);
                return false;
            }
            else if (number < 9) // 已经排除 4,6,8 true
            {
                primeCheck.Add(number, true);
                return true;
            }
            else if (number % 3 == 0) //能被3整出 false
            {
                primeCheck.Add(number, false);
                return false;
            }
            else
            {
                for (long i = 5; i <= Math.Sqrt(number) ; i = i + 2) //没有必要计算到n，没有必要计算偶数
                {
                    if (number % i == 0)
                    {
                        primeCheck.Add(number, false);
                        return false;
                    }
                }

                primeCheck.Add(number, true);
                return true;
            }
        }
    }
}
