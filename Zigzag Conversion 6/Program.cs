using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        string twxt = "PAYPALISHIRING";
        // Explanation:
        // PIN   "PINALSIGYAHRPI"
        // ALSIG
        // YAHR
        // PI

        Console.WriteLine(_solution.Convert(twxt, 4));
    }
}

public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1)
            return s;

        var result = new StringBuilder();
        var perIter = numRows * 2 - 2;
        for (int row = 0; row < numRows; row++) {
            int i = 0;
            while ((i + row) < s.Length) {
                result.Append(s[i + row]);
                if (row != 0 && row != numRows - 1) {
                    if ((i + perIter - row) < s.Length) {
                        result.Append(s[i + perIter - row]);
                    }
                }

                i += perIter;
            }
        }

//TODO ращобраться в решении алгоритма и реализовать самому.
        return result.ToString();
    }
}