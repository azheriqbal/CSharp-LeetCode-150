// See https://aka.ms/new-console-template for more information
using Dsa;
using LeetCode;
using System.Text;
using static LeetCode.LinkedListS;


int[] a = { 1, 2, 3, 4 };
int[] r =Product.ProductExceptSelf_1(a);

foreach (int i in r)
{
    Console.WriteLine(i);
}


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