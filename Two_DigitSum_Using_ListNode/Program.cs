
// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
Console.WriteLine("Program for Two digit sum using ListNode");
Console.WriteLine("------------------------------------------------------Click on X button or press Ctrl + C close the window");
do
{
    try
    {


        Console.WriteLine("( 1st ListNode ) Enter the numbers by space seperated like 12 23 343 45: ");
        int[] num1 = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

        Console.WriteLine("( 2nd ListNode ) Enter the numbers by space seperated like 12 23 343 45: ");
        int[] num2 = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

        Array.Reverse(num1);
        Array.Reverse(num2);
        ListNode l1 = null;
        ListNode l2 = null;

        foreach (int num in num1)
            l1 = new ListNode(num, l1);

        foreach (int num in num2)
            l2 = new ListNode(num, l2);

        ListNodeSolution solution = new ListNodeSolution();
        ListNode result = solution.AddTwoNumbers(l1, l2);
        PrintList(result);
    }
    catch(Exception ex)
    { Console.WriteLine(ex.ToString()); }

} while (true);



//ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
//ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));



void PrintList(ListNode node)
{
    Console.WriteLine("Sum is : ");
    while (node != null)
    {
        Console.Write(node.val + " ");
        node = node.next;
    }
    Console.WriteLine();
}
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

}

public class ListNodeSolution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummy = new ListNode(0);
        ListNode currentNode = dummy;
        int carry = 0;
        while (l1 != null || l2 != null || carry !=0)
        {
            int sum = carry ;
            if(l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }

            if ((l2!=null))
            {
                sum += l2.val;
                l2 = l2.next;
            }

            carry = sum / 10;
            currentNode.next = new ListNode(sum % 10);
            currentNode = currentNode.next;
            
        }
        
        return dummy.next;
    }
}
