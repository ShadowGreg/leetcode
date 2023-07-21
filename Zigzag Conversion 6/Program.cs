using System.Data;

public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        string twxt = "PAYPALISHIRING"; //true
        Console.WriteLine(_solution.Convert(twxt, 3));
    }
}

public class Solution {
    public string Convert(string s, int numRows) {
        if (s.Length == 1 && numRows == 1 || s.Length < numRows) {
            return s;
        }

        int charIndex = 0;
        int сolumnIndex = 0;
        char[,] zigzag = new char[numRows, s.Length];

        while (s.Length != charIndex) {
            int rowsIndex = 0;

            while (rowsIndex <= numRows) {
                zigzag[сolumnIndex, rowsIndex] = s[charIndex];
                rowsIndex++;
                charIndex++;
            }

            while (rowsIndex >= 0) {
                rowsIndex--;
                сolumnIndex++;
                charIndex++;
            }
        }

        throw new NotImplementedException();
    }


    // Explanation:
    // P     I    N   "PINALSIGYAHRPI"
    // A   L S  I G
    // Y A   H R
    // P     I
}