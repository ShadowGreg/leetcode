namespace Integer_to_Roman__12;

public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        Console.WriteLine(_solution.IntToRoman(3) + "должно быть III  \n Explanation: 3 is represented as 3 ones.");
        Console.WriteLine(_solution.IntToRoman(58) + "должно быть LVIII\n Explanation: L = 50, V = 5, III = 3.");
        Console.WriteLine(_solution.IntToRoman(1994) +
                          "должно быть MCMXCIV \n Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.");
        Console.WriteLine(_solution.IntToRoman(3) + "должно быть III ");
    }
}

public class Solution {
    public string IntToRoman(int num) {
        ///TODO доделать
        return "";
    }
}