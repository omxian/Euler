using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class LargestPalindromeProduct
    {
        //A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        //Find the largest palindrome made from the product of two 3-digit numbers.

        public int Solution1()
        {
            int checkNumber = 999;
            int currentPalindrome = GetPalindrome(checkNumber);

            while (true)
            {
                for (int i = 100; i < 999; i++)
                {
                    if (currentPalindrome % i == 0)
                    {
                        int anotherFactor = currentPalindrome / i;
                        if (anotherFactor > 100 && anotherFactor < 999)
                        {
                            return currentPalindrome;
                        }
                    }
                }

                checkNumber--;
                currentPalindrome = GetPalindrome(checkNumber);
            }
        }

        private int GetPalindrome(long num)
        {
            string numToStr = num.ToString();
            return int.Parse((numToStr + Helper.ReverseString(numToStr)));
        }


        /// <summary>
        /// Solution1很不灵活，只是为了解决问题两个三位数相乘，可以优化为解决两个n位数相乘
        /// 这样也让问题更加抽象，便于理解
        /// </summary>
        /// <param name="n">几位数</param>
        public long Solution2(int n)
        {
            long max = (long)Math.Pow(10,n)-1;
            long min = (long)Math.Pow(10,n-1);

            for (long buildFactor = max; buildFactor >= min; buildFactor--)
            {
                long palindrome = GetPalindrome(buildFactor);
                for (long num = max; num >= min; num--)
                {
                    long anotherFactor = palindrome / num;

                    if (anotherFactor > max || anotherFactor < min)
                    {
                        break;
                    }

                    if (palindrome % num == 0)
                    {
                        return palindrome;
                    }
                }
            }

            //when n = 1 
            return 9;
        }
    }
}
