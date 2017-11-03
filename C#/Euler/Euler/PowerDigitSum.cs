using System;
using System.Numerics;

namespace Euler
{
    public class PowerDigitSum
    {
        public int Solution(int power)
        {
            int result = 0;
            BigInteger bigInt = new BigInteger(Math.Pow(2, power)); 
            
            while(bigInt > 0)
            {
                result += (int)(bigInt % 10);
                bigInt = bigInt / 10;
            }

            return result;
        }
    }
}
