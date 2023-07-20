using System.Diagnostics.CodeAnalysis;

public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        string text = "babad"; //bab
        // Console.WriteLine(_solution.LongestPalindrome(text));
        text = "cbbd"; //bb
        // Console.WriteLine(_solution.LongestPalindrome(text));
        // text = "b"; //b
        // Console.WriteLine(_solution.LongestPalindrome(text));
        // text = "1aba1"; //aba
        // Console.WriteLine(_solution.LongestPalindrome(text));
        // text = "111bab"; //111
        // Console.WriteLine(_solution.LongestPalindrome(text));
        // text = "aacabdkacaa"; //"aca"
        // //     "aacakdbacaa" 
        // Console.WriteLine(_solution.LongestPalindrome(text));
        text = "abcdbbfcba"; //"bb"
        //     "abcfbbdcba" 
        Console.WriteLine(_solution.LongestPalindrome(text));
    }
}


public class Solution {
    public string LongestPalindrome(string s) {
        if (s.Length == 1) {
            return s;
        }

        string temp = string.Join("", s.Reverse());
        int length = s.Length;
        int index = 0;
        string ans = "";
        while (index != length) {
            for (int i = index; i <= length; i++) {
                string tempSub = s[index..i];
                if (!temp.Contains(tempSub)) continue;
                if (s[index..i].Length > ans.Length && IsPalindrome(tempSub)) {
                    ans = s[index..i];
                }
            }

            index++;
        }

        return ans;
    }

    public bool IsPalindrome(string s) {
        return s.Equals(string.Join("", s.Reverse()));
    }
}