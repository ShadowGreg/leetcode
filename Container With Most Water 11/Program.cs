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
        int leftBorder = 0,
            rightBorder = height.Length - 1,
            maxArea = 0;
        while (leftBorder < rightBorder) {
            int currentArea = (rightBorder - leftBorder) * Math.Min(height[leftBorder], height[rightBorder]);
            if (currentArea > maxArea)
                maxArea = currentArea;

            if (height[leftBorder] <= height[rightBorder])
                leftBorder++;
            else
                rightBorder--;
        }

        return maxArea;
        /// TODO повторить решение самому
    }
}