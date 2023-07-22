public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        int[] height = { 1, 2, 4, 3 };
        Console.WriteLine(_solution.MaxArea(height));
        Console.WriteLine();
    }
}

public class Solution {
    public int MaxArea(int[] height) {
        int length = 0,
            heightLength = height.Length - 1,
            maxArea = 0;
        while (length < heightLength) {
            int currentMax = (heightLength - length) * Math.Min(height[length], height[heightLength]);
            if (currentMax > maxArea)
                maxArea = currentMax;

            if (height[length] <= height[heightLength])
                length++;
            else
                heightLength--;
        }

        return maxArea;
    }
}