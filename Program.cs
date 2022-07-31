// See https://aka.ms/new-console-template for more information
using LeetcodeSolutions;

Console.WriteLine("Solved");

P1389 Obj = new P1389();
int[] nums = { 0, 1, 2, 3, 4 };
int[] index = { 0, 1, 2, 2, 1 };

int[] output = Obj.CreateTargetArray(nums, index);
foreach(object obj in output)
{
    Console.WriteLine(obj);
}
//Console.WriteLine(output);

