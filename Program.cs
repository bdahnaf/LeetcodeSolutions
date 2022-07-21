// See https://aka.ms/new-console-template for more information
using LeetcodeSolutions;

Console.WriteLine("Solved");

P1920 Obj = new P1920();
int[] arg = { 0, 2, 1, 5, 3, 4 };
int[] output = Obj.BuildArray(arg);
foreach (var item in output)
{
    Console.WriteLine(item);
}
Console.WriteLine(output[0]);

