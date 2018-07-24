using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class LexicographicPermutations
    {
        //排列的问题
        //优先级0123456789
        //9! = 362880, 1000000/362880 ≈ 2.7, 2
        //8! = 40320, 274240/40320 ≈ 6.8, 7
        //7! = 5040, 32320/5040 ≈ 6.4, 8
        //6! = 720, 2080/720 ≈ 2.8, 3
        //5! = 120, 640/120 ≈ 5.3, 9
        //4! = 24, 40/24 ≈ 1.6, 1
        //3! = 6, 16/6 ≈ 2.6, 5
        //2! = 2, 4/2 = 2, 4
        //这里的意思是说4种可能性的第二个
        //按照文法顺序,可能性有406,460,604,640(0在第一的可能性已经在上面处理了)
        //答案为2783915460
        //验证想法的时候直接通过了- -
        public string Find()
        {
            return "2783915460";
        }

        //使用蛮力法遍历
        public string Traversal()
        {
            int target = 1000000;
            for (int i = 0; i < target-1; i++)
            {
                GetNextNum();
            }
            return GetNextNum();
        }

        private string currentNum = string.Empty;
        private string GetNextNum()
        {
            if (currentNum == string.Empty)
            {
                currentNum = "0123456789";
                return currentNum;
            }

            ///TODO: 理论上是有算法计算出下一个值的
            return currentNum;
        }
    }
}
