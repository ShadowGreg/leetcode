namespace Palindrome_Number_9;

public class Program {
    private static Solution _solution;

    public static void Main() {
        Solution sol = new Solution();
        Console.WriteLine($"{sol.IsPalindrome(121)} must be true ");
        Console.WriteLine($"{sol.IsPalindrome(-121)} must be false ");
        Console.WriteLine($"{sol.IsPalindrome(10)} must be false ");
        Console.WriteLine($"{sol.IsPalindrome(2222)} must be true ");
    }
}

public class Solution {
    public bool IsPalindrome(int x) {
        switch (x) {
            case < 0:
                return false;
            case 0:
                return true;
        }

        int head = 0;
        
        int tail = (int)Math.Floor(Math.Log10(Math.Abs(x)) + 1) - 1;
        int temp = x;
        while (tail - head >= 0) {
            string chars = temp.ToString();
            if (chars[head] != chars[tail]) return false;
            head++;
            tail--;
        }

        return true;
    }
}