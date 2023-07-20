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
        int overflowLimit = int.MaxValue / 10;

        var negative = x < 0;
        if (negative)
            x = -x;

        int result = 0;
        while (x > 0) {
            if (result > overflowLimit)
                return 0;

            result = 10 * result + x % 10;

            x = x / 10;
        }

        if (negative)
            result = -result;

        return result;
    }
}