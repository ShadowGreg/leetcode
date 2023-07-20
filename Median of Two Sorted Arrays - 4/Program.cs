using System.Diagnostics.CodeAnalysis;

public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        int[] l1 = { 1, 3 };
        int[] l2 = { 2 }; //[2.00000]
        Console.WriteLine(_solution.FindMedianSortedArrays(l1, l2));

        l1 = new[] { 1, 2 };
        l2 = new[] { 3, 4 }; //[2.50000]
        Console.WriteLine(_solution.FindMedianSortedArrays(l1, l2));
        l1 = new[] { 1, 1 };
        l2 = new[] { 1, 2 }; //[1.000]
        Console.WriteLine(_solution.FindMedianSortedArrays(l1, l2));
    }
}


public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        List<int> list1 = new(nums1);
        List<int> list2 = new(nums2);
        list1.AddRange(list2);
        list1.Sort();
        int length = list1.Count;
        if (length % 2 == 0) {
            return (list1.ElementAt(length / 2) + (double)list1.ElementAt(length / 2 - 1)) / 2;
        }

        return list1.ElementAt(length / 2);
    }
}