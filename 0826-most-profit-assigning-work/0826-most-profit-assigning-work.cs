public class Solution {
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker) {
        int maxprofit=0;
        
        for(int i=0;i<worker.Length;i++){
            List<int>ind=new List<int>();
            for(int j=0;j<difficulty.Length;j++){
                if(worker[i]>=difficulty[j]){
                    ind.Add(profit[j]);
                }
            }
            if(ind.Count!=0){
                maxprofit+= ind.Max();
            }
            
        }
        return maxprofit;
    }
}