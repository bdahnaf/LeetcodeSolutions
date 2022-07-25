// See https://aka.ms/new-console-template for more information
using LeetcodeSolutions;

Console.WriteLine("Solved");

P1480 Obj = new P1480();
int[] nums = { 3, 1, 2, 10, 1 };
int[] output = Obj.RunningSum(nums);
foreach (int i in output)
{
    Console.WriteLine(i);
}

