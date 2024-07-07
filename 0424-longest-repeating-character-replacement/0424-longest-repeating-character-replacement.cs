public class Solution {
    public int CharacterReplacement(string s, int k) {
        int i=0;int j=0;
        Dictionary<char,int>dic = new Dictionary<char,int>();
        int l=0;
        int r=0;
        while(r<s.Length){
            if(!dic.ContainsKey(s[r])){
                dic[s[r]] = 1;
            }
            else{
                dic[s[r]]++;
            }
            int window = (r-l)+1;
            var maxKeyValuePair = dic.Aggregate((x, y) => x.Value > y.Value ? x : y);
            if((window - maxKeyValuePair.Value)<=k){
                r++;
            }
            else{
                dic[s[l]]--;
                l++;
                r++;
            }
        }
        return (r-l);
        
    }
}