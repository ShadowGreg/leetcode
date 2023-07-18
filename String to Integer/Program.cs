using System.Data;

public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        string thomthing = "42"; //42
        Console.WriteLine(_solution.MyAtoi(thomthing));

        thomthing = "   -42"; //-42
        Console.WriteLine(_solution.MyAtoi(thomthing));

        thomthing = "4193 with words"; //4193
        Console.WriteLine(_solution.MyAtoi(thomthing));
    }
}

public class Solution {
    public int MyAtoi(string s) {
        int index = 0;
        int sign = 1;
        int result = 0;
        // Ignore leading whitespace
        while (index < s.Length && s[index] == ' ') {
            index++;
        }

        // Check for sign
        if (index < s.Length && (s[index] == '+' || s[index] == '-')) {
            sign = (s[index] == '-') ? -1 : 1;
            index++;
        }

        // Convert digits to integer
        while (index < s.Length && char.IsDigit(s[index])) {
            int digit = s[index] - '0';
            // Check for overflow
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > int.MaxValue % 10)) {
                return (sign == -1) ? int.MinValue : int.MaxValue;
            }

            result = result * 10 + digit;
            index++;
        }

        return result * sign;
    }
}