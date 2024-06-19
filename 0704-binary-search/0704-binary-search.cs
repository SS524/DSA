public class Solution {
    public int Search(int[] nums, int target) {
        int i=0;
        int mid = 0;
        int j = nums.Length-1;
        while(i<=j){
            mid = (i+j)/2;
            if(nums[mid]==target){
                return mid;
            }
            else if(nums[mid]>target){
                j = mid-1;
            }
            else{
                i = mid +1;
            }
        }
        return -1;
    }
}