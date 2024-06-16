public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[]answers=new int[temperatures.Length];
        Stack<string>st=new Stack<string>();
        int ind = 0;
        for(int i=0;i<temperatures.Length;i++){
            if(st.Count==0){
                st.Push(temperatures[i].ToString()+"_"+i.ToString());
            }
            else{
                while(st.Count!=0 && temperatures[i]>Convert.ToInt32(st.Peek().Split("_")[0])){
                    ind = Convert.ToInt32(st.Peek().Split("_")[1]);
                    answers[ind] = i-ind;
                    st.Pop();
                    
                }
                
                st.Push(temperatures[i].ToString()+"_"+i.ToString());
                
            }
        }
        return answers;
    }
}