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
        int maxLength = 0, startIndex = 0;
        for (int i = 0; i < s.Length; i++) {
            int start = i, end = i;
            
            while (end < s.Length - 1 && s[start] == s[end + 1])
                end++;

            
            while (end < s.Length - 1 && start > 0 && s[start - 1] == s[end + 1]) {
                start--;
                end++;
            }

            if (maxLength < end - start + 1) {
                maxLength = end - start + 1;
                startIndex = start;
            }
        }

        return s.Substring(startIndex, maxLength);
    }
}