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
    }
}
