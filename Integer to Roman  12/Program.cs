using System.Text;

namespace Integer_to_Roman__12;

public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        Console.WriteLine(_solution.IntToRoman(3) + " должно быть III  \n Explanation: 3 is represented as 3 ones.");
        Console.WriteLine(_solution.IntToRoman(58) + " должно быть LVIII\n Explanation: L = 50, V = 5, III = 3.");
        Console.WriteLine(_solution.IntToRoman(1994) +
                          "должно быть MCMXCIV \n Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.");
        Console.WriteLine(_solution.IntToRoman(3) + " должно быть III ");
    }
}

public class Solution {
    public string IntToRoman(int num) {
        var result = new StringBuilder();
        Dictionary<int, string> map = new() {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };

        foreach (KeyValuePair<int, string> kv in map) {
            while (num >= kv.Key) {
                num -= kv.Key;
                result.Append(kv.Value);
            }
        }

        return result.ToString();
    }
}