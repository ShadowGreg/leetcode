using System.Diagnostics.CodeAnalysis;

public class Program {
    private static Solution _solution;

    [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: ListNode")]
    public static void Main() {
        _solution = new Solution();

        int[] l1 = { 2, 4, 3 };
        int[] l2 = { 5, 6, 4 }; //[7,0,8]
        ListNode? ln1 = GetNode(l1);
        ListNode? ln2 = GetNode(l2);
        ListNode? answer = null;
        // Console.WriteLine(_solution.AddTwoNumbers(ln1, ln2));
        //
        // l1 = new[] { 0 };
        // l2 = new[] { 0 }; //[0]
        // ln1 = GetNode(l1);
        // ln1 = GetNode(l2);
        // Console.WriteLine(_solution.AddTwoNumbers(ln1, ln2));

        // l1 = new[] { 9, 9, 9, 9, 9, 9, 9 };
        // l2 = new[] { 9, 9, 9, 9 }; //[8,9,9,9,0,0,0,1]
        l1 = new[] { 9, 9 };
        l2 = new[] { 9, }; //[8,9,9,9,0,0,0,1]
        ln1 = GetNode(l1);
        ln2 = GetNode(l2);
        answer = _solution.AddTwoNumbers(ln1, ln2);
        while (answer.Next != null) {
            Console.WriteLine(answer.Val);
        }
    }

    private static ListNode? GetNode(int[] array) {
        ListNode? getNode = null;
        for (int i = array.Length - 1; i >= 0; i--) {
            getNode = new ListNode(array[i], getNode);
        }

        return getNode;
    }
}

public class ListNode {
    public int Val { get; }
    public ListNode? Next { get; }

    public ListNode(int val = 0, ListNode? next = null) {
        Val = val;
        Next = next;
    }
}

public class Solution {
    public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2) {
        ListNode? output = null;
        int temp = 0;
        int sum = 0;
        while (l1.Next != null ^ l2.Next != null) {
            if (l1.Next != null ^ l2.Next != null) {
                if (l1.Next == null && l2.Next != null) {
                    sum = temp + l2.Val;
                }
                else if (l2.Next == null && l1.Next != null) {
                    sum = temp + l1.Val;
                }
                else if (l1.Next == null && l1.Next == null) {
                    break;
                }
            }
            else {
                sum = temp;
            }

            if (sum >= 10) {
                int tempSum = sum / 10;
                sum %= 10;
                temp = tempSum;
                tempSum = 0;
            }

            output = new ListNode(sum, output);
        }

        return output;
    }
}