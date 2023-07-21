public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();
//TODO перерешать по условиям решения с сайта - когда нибудь
        int[] num = { 1, 1, 2 };
        Console.WriteLine(_solution.RemoveDuplicates(num));
    }
}


public class Solution {
    public int RemoveDuplicates(int[] nums) {
        SortedSet<int> temp = new SortedSet<int>(nums);
        for (int i = temp.Count - 1; i >= 0; i--) {
            nums[i] = temp.Last();
            temp.Remove(nums[i]);
        }

        return temp.Count;
    }
}