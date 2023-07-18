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
    }
}

public class Solution {
    private List<char> _brackets = new List<char>() {
        ' ', '(', ')', '[', ']', '{', '}'
    };

    public bool IsValid(string s) {
        int charIndex = 0;
        for (int i = 0; i < s.Length - 1; i++) {
            if (_brackets.Contains(s[i])) {
                charIndex = _brackets.IndexOf(s[i]);
                if (i == 0 && charIndex % 2 == 0) {
                    return false;
                }

                if (s.Contains(_brackets[charIndex + 1])) {
                    break;
                }

                return false;
            }
        }

        return true;
    }
}