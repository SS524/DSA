public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int[]arr = Enumerable.Range(0,m).Select(k=>matrix[k][n-1]).ToArray();
        int i = 0;
        int j = arr.Length-1;
        int mid = 0;
        while(i<=j){
            mid = (i+j)/2;
            if(arr[mid]==target){
                return true;
            }
            else if(arr[mid]>target){
               if(matrix[mid][0]<=target){
                  break; 
               }
              j = mid -1;
            }
            else{
                i = mid+1;
            }
        }
        
        int[]rowArray = Enumerable.Range(0,n).Select(r=>matrix[mid][r]).ToArray();
        i = 0;
        j = rowArray.Length-1;
        mid = 0;
        
        while(i<=j){
            mid = (i+j)/2;
            if(rowArray[mid]==target){
                return true;
            }
            else if(rowArray[mid]>target){
                j = mid-1;
            }
            else{
                i = mid+1;
            }
        }
        
        return false;
        
    }
}