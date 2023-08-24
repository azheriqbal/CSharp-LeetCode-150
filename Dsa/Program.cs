// See https://aka.ms/new-console-template for more information
using Dsa;
using LeetCode;
using System.Text;
using static LeetCode.LinkedListS;




Recursion.PrintNumber(5);

/*int f = Recursion.Factorial(9);
Console.WriteLine(f);*//*

int[] arr = { 2, 3, 487,1, 10, 40 };

int max = arr[1];
int current = arr[1];

foreach (int i in arr)
{
    current = i;
    max = Math.Min(max, current);
}

Console.WriteLine(max);*/

/*int n = 723421;

if(n % 2 == 0)
{
    Console.WriteLine("The no is Even");
}
else
{
    Console.WriteLine("The no is odd");
}*/

/*LinkedList<int> list = new LinkedList<int>();

list.AddFirst(1);
list.AddFirst(3);
list.AddFirst(34);
list.AddFirst(2);

Console.WriteLine(list.Count);
list.ToArray();*/

/*foreach (int i in list)
{
    Console.WriteLine(i);

}*/

/*int res = 1;

for(int i = 1; i <= 7; i++)
{
    res *=i;
}

Console.WriteLine(res);*/

/*Dictionary<char, int> map = new Dictionary<char, int>();
map['b'] = 23;
map['c'] = 23;
map['d'] = 23;
map['e'] = 23;


Console.WriteLine(map.ContainsValue(03));
Console.WriteLine(map.ContainsKey('c'));

foreach (char c in map.Keys)
{
    int ages = map[c];
    Console.WriteLine(ages);
    Console.WriteLine(c);
}

*/

/*ListNode node1 = new ListNode(1);
ListNode node2 = new ListNode(2);
ListNode node3 = new ListNode(3);
ListNode node4 = new ListNode(4);


// Connecting the nodes to form a linked list
node1.Next = node2;
node2.Next = node3;
node3.Next = node4;

// Creating a cycle by making the last node point to the second node
node4.Next = node2;

// Create an instance of the Solution class

// Call the HasCycle method to check if a cycle exists
bool hasCycle = LinkedListS.HasCycle(node1);

Console.WriteLine("Cycle detected: " + hasCycle);*/


/*int[] arr = { 2, 3, 4, 10, 40 };
int res = SearchAlogs.BinarySearch(arr, 40);
Console.WriteLine(res);*/