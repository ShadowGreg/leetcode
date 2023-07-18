public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        string thomthing = "abcabcbb"; //3
        // Console.WriteLine(_solution.LengthOfLongestSubstring(thomthing));
        //
        // thomthing = "bbbbb"; //1
        // Console.WriteLine(_solution.LengthOfLongestSubstring(thomthing));

        thomthing = "pwwkew"; //3
        Console.WriteLine(_solution.LengthOfLongestSubstring(thomthing));
    }
}

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }

        HashSet<char> hSet = new();
        int max = 0;
        int i = 0;
        int j = 0;

        while (i < s.Length) {
            if (!hSet.Contains(s[i])) {
                hSet.Add(s[i]);
                i++;
            }
            else {
                max = Math.Max(max, hSet.Count);
                hSet.Remove(s[j]);
                j++;
            }
        }

        max = Math.Max(max, hSet.Count);
        return max;
    }
}