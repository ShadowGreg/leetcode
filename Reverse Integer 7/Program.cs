public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        int num = -123_00_000; //321
        Console.WriteLine(_solution.Reverse(num));
    }
}


public class Solution {
    public int Reverse(int x) {
        string temp = ("" + x);
        string output = new(temp.Reverse().ToArray());
        if (x < 0) {
            return -IntegerParse(output);
        }

        return IntegerParse(output);
    }

    int IntegerParse(string text) {
        int value;
        int.TryParse(string.Join("", text.Where(c => char.IsDigit(c))), out value);
        return value;
    }
}