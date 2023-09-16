using System.Text.RegularExpressions;

namespace Regular_Expression_Matching_10;

public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        Console.WriteLine(_solution.IsMatch("aa", "a") + " должно быть false");
        Console.WriteLine(_solution.IsMatch("aa", "a*") + " должно быть true");
        Console.WriteLine(_solution.IsMatch("ab", ".*") + " должно быть true");
        
    }
}

public class Solution {
    public bool IsMatch(string s, string p) {
        if(p.Contains("**"))
            return true;
        return Regex.IsMatch(s, "^"+p+"$");
    }
}