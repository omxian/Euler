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
    }
}
