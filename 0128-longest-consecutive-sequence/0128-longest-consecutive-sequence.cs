public class Solution {
    public int LongestConsecutive(int[] nums) {
        Array.Sort(nums);
        if(nums.Length==0){
            return 0;
        }
        int maxseq = 1;
        int seq = 1;
        for(int i=0;i<nums.Length-1;i++){
            if(nums[i+1]-nums[i]==1){
                seq++;
                
            }
            if(nums[i+1]==nums[i]){
                continue;
            }
            else if(seq>1 && nums[i+1]-nums[i]>1){
                
                if(seq>maxseq){
                    maxseq = seq;
                }
                seq = 1;
            }
        }
        if(seq>maxseq){
            maxseq = seq;
        }
        return maxseq;
    }
}