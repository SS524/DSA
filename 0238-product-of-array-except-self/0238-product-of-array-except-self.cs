public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[]output = new int[nums.Length];
        //traversing for prefix operation
        int prefix = 1;
        int postfix = 1;
        output[0] = 1;
        for(int i=0;i<nums.Length;i++){
            if(i==nums.Length-1){
                break;
            }
            output[i+1] = prefix*nums[i];
            prefix= prefix*nums[i];

            
        }
         //output[nums.Length-1] = output[nums.Length-1]*postfix;
        for(int j=nums.Length-1;j>=0;j--){
            output[j] = output[j]*postfix;
            postfix = postfix*nums[j];
        }

        return output;
    }
}