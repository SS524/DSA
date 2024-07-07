public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length){
            return false;
        }
        else{
            int ind = 0;
            while(ind<=(s2.Length-s1.Length)){
                string sub = s2.Substring(ind,s1.Length);
                char[]arr1 = sub.ToCharArray();
                Array.Sort(arr1);
                sub = string.Join("",arr1);
                char[]arr2 = s1.ToCharArray();
                Array.Sort(arr2);
                if(sub.Equals(string.Join("",arr2))){
                    return true;
                }
                else{
                    ind++;
                }
                
            }
            return false;
        }
    }
}