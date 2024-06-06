public class Solution {
    public int MaxArea(int[] height) {
        int i=0;
        int j=height.Length-1;
        int area=0;
        int maxarea=0;

        while(i<j){
            area = height[i]<=height[j]?height[i]*(j-i):height[j]*(j-i);
            if(area>maxarea){
                maxarea = area;
            }
            if(height[i]<height[j]){
                i++;
            }
            else if(height[i]>height[j]){
                j--;
            }
            else{
                i++;
            }
        }
        return maxarea;
    }
}