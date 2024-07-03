public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] res = nums1.Concat(nums2).ToArray();
        Array.Sort(res);
        if(res.Length%2!=0){
            return (double)res[(res.Length-1)/2];
        }
        else{
            double med = ((double)res[(res.Length-1)/2] + (double)res[((res.Length-1)/2)+1])/2;
            return med;
        }
    }
}