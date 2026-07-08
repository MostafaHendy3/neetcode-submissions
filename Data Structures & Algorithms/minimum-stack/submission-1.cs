public class MinStack {
    int[] arr;
    int cap;
    int top = -1;
    public MinStack() {
        cap = 10;
        arr = new int[cap];
    }

    private void Resize() {
        cap *= 2;
        int[] newArr = new int[cap];
        Array.Copy(arr, newArr, arr.Length);
        arr = newArr;
    }

    public void Push(int val) {
        if (top + 1 == cap)
            Resize();
        ++top;
        arr[top] = val;
    }

    public void Pop() {
        top--;
    }

    public int Top() {
        return arr[top];
    }

    public int GetMin() {
        int minElement = int.MaxValue;
        for (int i = 0; i <= top; i++) {
            minElement = Math.Min(arr[i], minElement);
        }
        return minElement;
    }
}