public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        int[] num = { 1, 1, 2 };
        Console.WriteLine(_solution.RemoveDuplicates(num));
    }
}


public class Solution {
    public int RemoveDuplicates(int[] nums) {
        SortedSet<int> temp = new SortedSet<int>(nums);
        nums = null;
        nums = temp.ToArray();
        return temp.Count;
    }
}