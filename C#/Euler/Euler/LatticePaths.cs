using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class LatticePaths
    {
        private int endX;
        private int endY;
        public long Solution1(int width,int height)
        {
            endX = width;
            endY = height;
            return FindPath(0,0);
        }

        public long Solution2(int width, int height)
        {
            return FindPath2(width, height);
        }
        
        /// <summary>
        /// 这个方法可以得出正确答案，但是效率极其低下
        /// 基本思路是从头开始找，找能到终点路径的数量总和
        /// 反面教材
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public long FindPath(int x,int y)
        {
            if(x > endX || y > endY)
            {
                return 0;
            }
            else if(x == endX && y == endY)
            {
                return 1;
            }
            else
            {
                if(x == endX)
                {
                    return FindPath(x, y + 1);
                }
                else if(y == endY)
                {
                    return FindPath(x + 1, y);
                }
                else
                {
                    return FindPath(x + 1, y) + FindPath(x, y + 1);
                }
            }
        }
        /// <summary>
        /// 思路：是从0,0开始，右侧和下侧只有1种来源路径，中间2种来源路径，以此类推。
        /// 见: https://mathschallenge.net/full/random_routes
        /// </summary>
        public long FindPath2(int width,int height)
        {
            long[,] arr = new long[width + 1, height + 1];
            arr[0, 0] = 1;

            for(int i=0; i<width+1;i++)
            {
                for(int j=0; j<height+1; j++)
                {
                    if(i==0 && j ==0)
                    {
                        continue;
                    }
                    if(i==0)
                    {
                        arr[i, j] = arr[i, j - 1];
                    }
                    else if(j==0)
                    {
                        arr[i, j] = arr[i - 1, j];
                    }
                    else
                    {
                        arr[i, j] = arr[i, j - 1] + arr[i - 1, j];
                    }
                }
            }

            return arr[width,height];
        }
    }
}
