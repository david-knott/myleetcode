using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            new Solution().Reverse(123);
            new Solution().Reverse(-123);
            new Solution().Reverse(120);
            new Solution().Reverse(0);
            new Solution().Reverse(2147483647);
            new Solution().Reverse(1534236469);
            

        }
    }
}


public class Solution {
    public int Reverse(int x) {
        //given number 1234, return 4321
        long result = 0;
        double mag = Math.Floor(Math.Log10(x));
        while(x != 0) {
            var mod = x % 10;
            x = x / 10;
            // might overflow 
            result = result * 10 + mod;
            if(result > int.MaxValue || result < int.MinValue) {
                return 0;
            }
        }
        return (int)result;
    }
}