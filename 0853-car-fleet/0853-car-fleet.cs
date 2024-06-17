public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        Dictionary<int,int>dc = new Dictionary<int,int>();
        for(int i=0;i<position.Length;i++){
            dc.Add(position[i],speed[i]);
        }
        
        var dcu = dc.OrderByDescending(k=>k.Key).ToDictionary(pair => pair.Key, pair => pair.Value);;
        Stack<int>st = new Stack<int>();
        foreach(KeyValuePair<int,int>item in dcu){
            if(st.Count==0){
                st.Push(item.Key);
            }
            else{
                double t1 = (double)(target - item.Key)/(double)item.Value;
                double t2 = (double)(target - st.Peek())/(double)dcu[st.Peek()];
                if(t1>t2){
                    st.Push(item.Key);
                }
            }
        }
        return st.Count;
        
    }
}