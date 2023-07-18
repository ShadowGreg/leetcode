public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();
        int[] nums = new[] { 3,3 };
        const int target = 6;

        foreach (int item in _solution.TwoSum(nums, target)) {
            Console.Write(item + " ");
        }
    }
}

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> output = new List<int>();
        int firstIndex = 0;
        while (firstIndex != nums.Length ) {
            for (int i = firstIndex + 1; i < nums.Length ; i++) {
                if (target == nums[firstIndex] + nums[i]) {
                    output.Add(firstIndex);
                    output.Add(i);
                    return output.ToArray();
                }
            }

            firstIndex++;
        }

        return output.ToArray();
    }
}