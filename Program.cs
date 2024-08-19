using System;
namespace tinhtong{
    class Program{
        static void Main(string[] args){
            int[] nums = new int[5];
            nums[0] = 2;
            nums[1] = 5;
            nums[2] = 9;
            nums[3] = 6;
            nums[4] = 7;

            Console.WriteLine(nums[1]);
            Console.WriteLine(nums[2]);
            Console.WriteLine(nums[4]);

            int total = 0;
            for (int i = 0; i < nums.Length; i++)
                {
                  total = total + nums[i];
                }
            Console.WriteLine(total.ToString());
        }
    }
}
