public class Solution {
    public int Trap(int[] height) {
        int totwater = 0;
    
        if(height.Length==1 || height.Length==2){
            return totwater;
        }
        
        int []lmax = new int[height.Length];
        int []rmax = new int[height.Length];
        int []minlr = new int[height.Length];
        
        lmax[0] = 0;
        rmax[height.Length-1] = 0;
        
        for(int i=1;i<height.Length;i++){
            lmax[i] = lmax[i-1]<=height[i-1]?height[i-1]:lmax[i-1];
        }
        for(int j=height.Length-2;j>=0;j--){
            rmax[j] = rmax[j+1]<=height[j+1]?height[j+1]:rmax[j+1];
        }
        
        for(int k=0;k<height.Length;k++){
            minlr[k] = lmax[k]<=rmax[k]?lmax[k]:rmax[k];
        }
        
        for(int w=0;w<height.Length;w++){
            if(minlr[w]>=height[w]){
                totwater+=minlr[w]-height[w];
            }
        }
        
        return totwater;
        
    }
}