using System.Data;

public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        int dividend = 10;
        int divisor = 3; //3
        // Console.WriteLine(_solution.Divide(dividend, divisor));
        //
        // dividend = 7;
        // divisor = -3; //-2
        // Console.WriteLine(_solution.Divide(dividend, divisor));
        //
        dividend = 1_000_000_000;
        divisor = 1; //1_000_000_000

        Console.WriteLine(_solution.Divide(dividend, divisor));
    }
}

public class Solution {
    public int Divide(int dividend, int divisor) {
        uint udividend = (uint)dividend;
        uint udivisor = (uint)divisor;
        uint ans = 1;
        if (divisor == 0) {
            throw new Exception("Деление на нуль");
        }

        if (dividend == int.MinValue && divisor == -1) {
            return int.MaxValue;
        }

        if (divisor == 1) {
            return dividend;
        }

        if (dividend < 0 && divisor < 0) {
            udividend = (uint)Math.Sqrt(Math.Pow(dividend, 2));
            udivisor = (uint)Math.Sqrt(Math.Pow(divisor, 2));
        }
        else if (dividend < 0 || divisor < 0) {
            udividend = (uint)Math.Sqrt(Math.Pow(dividend, 2));
            udivisor = (uint)Math.Sqrt(Math.Pow(divisor, 2));
            return (int)-GetInt(udividend, udivisor);
        }

        ans = GetInt(udividend, udivisor);
        return (int)ans;
    }

    private uint GetInt(uint udividend, uint udivisor) {
        return (uint)(Math.Exp(Math.Log(udividend)
                               - Math.Log(udivisor))
                      + 0.0_000_000_001);
    }
}