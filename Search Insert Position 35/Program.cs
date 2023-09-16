namespace Search_Insert_Position_35;

public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        Console.WriteLine(_solution.SearchInsert(new[] { 1, 3, 5, 6 }, 5) + " должно быть Output: 2");
        Console.WriteLine(_solution.SearchInsert(new[] { 1, 3, 5, 6 }, 2) + " должно быть Output: 1");
        Console.WriteLine(_solution.SearchInsert(new[] { 1, 3, 5, 6 }, 7) + " должно быть Output: 4");
    }
}

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        List<int> numsList = new List<int>(nums);
        int outIndex = numsList.BinarySearch(target);
        if (numsList.BinarySearch(target) >= 0) return outIndex;
        numsList.Add(target);
        numsList.Sort();
        outIndex = numsList.BinarySearch(target);

        return outIndex;
    }
}