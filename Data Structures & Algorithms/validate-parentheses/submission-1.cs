public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach (var c in s) {
            if (stack.Count == 0) {
                stack.Push(c);
                continue;
            }
            if (stack.Peek() == '{' && c == '}') {
                stack.Pop();
            } else if (stack.Peek() == '[' && c == ']') {
                stack.Pop();
            }
            else if (stack.Peek() == '(' && c == ')') {
                stack.Pop();
            }
            else {
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
}
