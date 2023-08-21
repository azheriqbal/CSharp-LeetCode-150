// See https://aka.ms/new-console-template for more information
using Dsa;
using LeetCode;
using System.Text;
using static LeetCode.LinkedListS;

string s = "a-bC-dEf-ghIj";

char[] sa = s.ToCharArray();

int l = 0;
int r =sa.Length-1;

while(l < r)
{
    if (char.IsLetter(sa[r]) && char.IsLetter(sa[l]))
    {
        char tem = sa[l];
        sa[l] = sa[r];
        sa[r]=tem;
        l++;
        r--;
    }

}

foreach(char c in sa)
{
    Console.WriteLine(c);
}

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