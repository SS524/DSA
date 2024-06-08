public class Solution {
    public bool IsValid(string s) {
        Dictionary<char,char>dict = new Dictionary<char,char>();
        dict.Add(')','(');
        dict.Add('}','{');
        dict.Add(']','[');
        if(s.Length==0){
            return true;
        }
        
        Stack<char>mystack = new Stack<char>();
        
        
        for(int i=0;i<s.Length;i++){
            if(s[i]=='(' || s[i]=='{' || s[i]=='['){
                mystack.Push(s[i]);
            }
            else if((s[i]==')' || s[i]=='}' || s[i]==']') && mystack.Count==0){
                return false;
            }
            else{
                if(mystack.Peek()==dict[s[i]]){
                    mystack.Pop();
                }
                else{
                    return false;
                }
            }
        }
        return mystack.Count==0?true:false;
        
    }
}