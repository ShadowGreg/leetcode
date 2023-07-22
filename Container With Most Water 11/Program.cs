public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        string haystack = "weqrwerq";
        string needle = "sad";
        Console.WriteLine(_solution.StrStr(haystack, needle));
        Console.WriteLine();
    }
}

public class Solution {
    public int StrStr(string haystack, string needle) {
        return haystack.IndexOf(needle, StringComparison.Ordinal);
    }
}