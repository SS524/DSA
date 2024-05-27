public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[]output = new int[2];
        Dictionary<int,int>dict = new Dictionary<int,int>();
        for(int i=0;i<numbers.Length;i++){
            if(!dict.ContainsValue(target-numbers[i])){
                dict.Add(i+1,numbers[i]);
            }
            else{
                output[0] = dict.FirstOrDefault(x=>x.Value==target-numbers[i]).Key;
                output[1] = i+1;
                break;
            }
        }
        return output;
    }
}