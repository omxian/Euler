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

            if (number < 2)
            {
                primeCheck.Add(number, false);
                return false;
            }


            for (long i = 2; i <= number / 2; i++)
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
