public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> st = new Stack<int>();
        foreach (var e in tokens) {
            if (e == "+") {
                int e1 = st.Pop();
                int e2 = st.Pop();
                st.Push(e1+e2);
            } else if (e == "-") {
                int e1 = st.Pop();
                int e2 = st.Pop();
                st.Push(e2-e1);
            } else if (e == "*") {
                int e1 = st.Pop();
                int e2 = st.Pop();
                st.Push(e2*e1);
            }
            else if (e == "/") {
                int e1 = st.Pop();
                int e2 = st.Pop();
                st.Push(e2/e1);
            }
            else {
                st.Push(int.Parse(e));
            }
        }
        return st.Peek();
    }
}