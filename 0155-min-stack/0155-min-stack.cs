public class MinStack {
    private Stack<int> st1;
    private Stack<int> st2;
    public MinStack() {
        st1 = new Stack<int>();
        st2 = new Stack<int>();
    }
    
    public void Push(int val) {
        if(st1.Count==0){
            st1.Push(val);
            st2.Push(val);
        }
        else if(val<st2.Peek()){
            st1.Push(val);
            st2.Push(val);
        }
        else{
            st1.Push(val);
            st2.Push(st2.Peek());
        }
    }
    
    public void Pop() {
        if(st1.Count==0){
            return;
        }
        else{
            st1.Pop();
            st2.Pop();
        }
    }
    
    public int Top() {
        return st1.Peek();
    }
    
    public int GetMin() {
        return st2.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */