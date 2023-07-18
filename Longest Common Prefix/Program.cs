using System.Data;

public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        string[] thomthing = new[] { "flower", "flow", "flight" }; //fl
        Console.WriteLine(_solution.LongestCommonPrefix(thomthing));

        thomthing = new[] { "dog", "racecar", "car" }; //""
        Console.WriteLine(_solution.LongestCommonPrefix(thomthing));

        thomthing = new[] { "flower", "flower", "flower", "flower" }; //flower
        Console.WriteLine(_solution.LongestCommonPrefix(thomthing));

        thomthing = new[] { "c", "acc", "ccc" }; // 
        Console.WriteLine(_solution.LongestCommonPrefix(thomthing));
    }
}

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 1)
            return strs[0];

        string prefixString = "";

        if (strs == null || strs.Length == 0)
            return prefixString;

        for (int i = 0; i < strs[0].Length; i++) {
            foreach (string str in strs) {
                if (i > str.Length - 1)
                    return prefixString;


                if (strs[0][i] != str[i])
                    return prefixString;
            }


            prefixString += strs[0][i];
        }


        return prefixString;
    }
}