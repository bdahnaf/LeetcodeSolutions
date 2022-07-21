// See https://aka.ms/new-console-template for more information
using LeetcodeSolutions;

Console.WriteLine("Solved");

P1929 Obj = new P1929();
int[] arg = { 0, 2, 1, 5, 3, 4 };
int[] output = Obj.GetConcatenation(arg);
foreach (var item in output)
{
    Console.WriteLine(item);
}
Console.WriteLine(output[0]);

