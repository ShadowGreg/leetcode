﻿using System.Data;

public class Program {
    private static Solution _solution;

    public static void Main() {
        _solution = new Solution();

        string thomthing = "()"; //true
        Console.WriteLine(_solution.IsValid(thomthing));

        thomthing = "()[]{}"; //true
        Console.WriteLine(_solution.IsValid(thomthing));

        thomthing = "(]"; //false
        Console.WriteLine(_solution.IsValid(thomthing));

        thomthing = "([)]"; //false
        Console.WriteLine(_solution.IsValid(thomthing));

        thomthing = "{[]}"; //true
        Console.WriteLine(_solution.IsValid(thomthing));

        thomthing = "(){}}{"; //false
        Console.WriteLine(_solution.IsValid(thomthing));
    }
}

public class Solution {
    public bool IsValid(string s) {
        // Get ready initial state (enforce element type)
        var k = new Stack<char>();
        // Evaluate each character for potential mismatch 
        foreach (char c in s)
        { // Push closing round bracket onto the stack
          if (c == '(')
          { k.Push(')');
            continue; }

          // Push closing curly bracket onto the stack
          if (c == '{')
          { k.Push('}');
            continue; }

          // Push closing square bracket onto the stack
          if (c == '[')
          { k.Push(']');
            continue; }

          // Look out for imbalanced strings or mismatches
          if (k.Count == 0 || c != k.Pop()) return false; }

        // Empty stack means string is valid and invalid otherwise
        return k.Count == 0;
    }
}