public class Solution {
    //Ajeena
    public int LengthOfLongestSubstring(string s) {
       if (s.Length <2){
        return s.Length;
       }
        int variable=0 , maxLen=0 , count=0;

        for(int i=1; i< s.Length; i++){
            for(int j= variable; j< i; j++){
                if(s[i]==s[j]){
                    variable=j+1;
                }
            }
            count=i-variable+1;
            if(count > maxLen){
                maxLen=count;
            }
        }
        return maxLen;
    }
}