// See https://aka.ms/new-console-template for more information
using LeetcodeSolutions;

Console.WriteLine("Solved");

P1431 Obj = new P1431();
int[] candies = { 4, 2, 1, 1, 2 };
int extraCandies = 1;
IList<bool> output = new List<bool>();
output = Obj.KidsWithCandies(candies, extraCandies);
foreach(object obj in output)
{
    Console.WriteLine(obj);
}
//Console.WriteLine(output);

