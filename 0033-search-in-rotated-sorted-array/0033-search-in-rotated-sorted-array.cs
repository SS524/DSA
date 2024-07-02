public class Solution {
    public int Search(int[] nums, int target) {
        if(nums.Length==1){
            return BinarySearch(nums,target,0,nums.Length-1);
        }
        else if(nums[0]<nums[nums.Length-1]){
            return BinarySearch(nums,target,0,nums.Length-1);
        }
        else{
            int s=0;
            int e=nums.Length-1;
            int mid = 0;
            while(s!=e){
                mid = (s+e)/2;
                if(nums[mid]>nums[s]){
                    s = mid;
                }
                else{
                    e = mid;
                }
            }
            
            int ls = BinarySearch(nums,target,0,mid);
            int rs = BinarySearch(nums,target,mid+1,nums.Length-1);

            if(ls!=-1 && rs==-1){
                return ls;
            }
            else if(ls==-1 && rs!=-1){
                return rs;
            }
            else{
                return -1;
            }
        }
        
    }
    public static int BinarySearch(int[]arr, int t, int i, int j){
        
        int mid = 0;
        while(i<=j){
            mid = (i+j)/2;
            if(arr[mid]>t){
                j=mid-1;
            }
            else if(arr[mid]<t){
                i=mid+1;
            }
            else{
                return mid;
            }
        }
        return -1;
    }
}