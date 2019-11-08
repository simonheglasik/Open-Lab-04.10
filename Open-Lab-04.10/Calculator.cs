using System;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            float b = 0;
            foreach(int a in nums)
            {
                b = b + a;
            }
            return b / nums.Length;
        }
    }
}
