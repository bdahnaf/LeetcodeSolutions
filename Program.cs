// See https://aka.ms/new-console-template for more information
using LeetcodeSolutions;

Console.WriteLine("Solved");

P1351 Obj = new P1351();
//int[,] grid = { { 4, 3, 2, -1 }, { 3, 2, 1, -1 }, { 1, 1, -1, -2 }, { -1, -1, -2, -3 } };
int[,] grid = { { 3, 2}, { 1, 0 } };
int[][] grid2 = new int[2][];

int output = Obj.CountNegatives(grid2);
//foreach(object obj in output)
//{
//    Console.WriteLine(obj);
//}
Console.WriteLine(output);

