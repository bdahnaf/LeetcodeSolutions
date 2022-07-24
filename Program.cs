// See https://aka.ms/new-console-template for more information
using LeetcodeSolutions;

Console.WriteLine("Solved");

P1773 Obj = new P1773();

IList<IList<string>> items = new List<IList<string>>()
{
    new List<string>()
    {
        "phone","blue","pixel"
    },
    new List<string>()
    {
        "computer","silver","lenovo"
    },
    new List<string>()
    {
        "phone","gold","iphone"
    }
};
string ruleKey = "color";
string ruleValue = "silver";

int output = Obj.CountMatches(items, ruleKey, ruleValue);
Console.WriteLine(output);
//foreach (int i in output)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine(output);
//Console.WriteLine(output[0]);

