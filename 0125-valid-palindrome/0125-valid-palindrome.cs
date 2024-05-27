using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        Regex rg = new Regex("[^a-zA-Z0-9]");
        string st = rg.Replace(s.ToLower(),"");
        int i = 0;
        int j = st.Length-1;
        while(i<=j){
            if(st[i]!=st[j]){
                return false;
            }
            else{
                i++;
                j--;
            }
        }

        return true;
    }
}