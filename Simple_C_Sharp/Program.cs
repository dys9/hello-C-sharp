using System;
using System.Linq;

namespace Simple_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] nums;
            nums = new int[100];

            for (var i = 0; i < 100; i++)
            {
                nums[i] = i - 50;
            }
            foreach(var i in nums)
            {
                Console.WriteLine(i);
            }

            Array.Reverse(nums);

            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
