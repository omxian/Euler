namespace Euler
{
    public class AmicableNumbers
    {
        //存储数据的位置
        int[] sumArr;

        //计算小于目标的友好数之和
        public int CountAmicableNumbersSum(int target)
        {
            sumArr = new int[target];
            GetAllSumOfProperDivisors(target);
            return CountArrAmicableNumSum();
        }

        //计算所有因子的和到数组中
        private void GetAllSumOfProperDivisors(int target)
        {
            //为了计算方便从1开始
            for (int i = 1; i < target; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }

                    //j已经超过i的一半
                    if (i / j < 2)
                    {
                        break;
                    }
                }
                sumArr[i] = sum;
            }
        }

        //计算数组中友好数之和
        private int CountArrAmicableNumSum()
        {
            int amicableNumSum = 0;
            for (int i = 0; i < sumArr.Length; i++)
            {
                if (IsAmicableNum(i))
                {
                    amicableNumSum += i;
                    amicableNumSum += sumArr[i];
                    sumArr[i] = 0;
                    sumArr[sumArr[i]] = 0;
                }
            }
            return amicableNumSum;
        }

        private bool IsAmicableNum(int i)
        {
            bool isLegalNum = sumArr[i] != 0 && sumArr[i] < sumArr.Length;
            //数字合法的前提下
            return isLegalNum && i != sumArr[i] && i == sumArr[sumArr[i]];
        }
    }
}
