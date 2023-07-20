using System.Diagnostics.CodeAnalysis;

public class Program {
    private static Solution _solution;

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
        while (answer.next != null) {
            Console.WriteLine(answer.val);
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
    public int val { get; }
    public ListNode? next { get; }

    public ListNode(int val = 0, ListNode? next = null) {
        val = val;
        next = next;
    }
}

public class Solution {
    public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2, int carry = 0) {
        if (l1 == null && l2 == null && carry == 0) return null;

        int total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
        carry = total / 10;
        return new ListNode(total % 10, AddTwoNumbers(l1?.next, l2?.next, carry));
    }
}