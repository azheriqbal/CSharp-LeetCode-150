// See https://aka.ms/new-console-template for more information
using Dsa;

Console.WriteLine("Hello, World!");

int[] nums = { 1, 1, 2 };
RemoveDuplicate.RemoveDuplicates(nums);
foreach(var i  in nums)
{
    Console.WriteLine(i);
}
/*int m = 3;
int n = 3;
int[] num2 = { 2,5,6};

MergeArrays.MergeSorted(num1, num2, m, n);

foreach (var i in num1)
{
    Console.WriteLine(i);
}*/



