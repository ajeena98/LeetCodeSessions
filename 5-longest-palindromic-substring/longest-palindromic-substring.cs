public class Solution {
    //Ajeena
    public string LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s) || s.Length < 1) return "";

        int maxLength = 0;
        string result = "";

        for (int i = 0; i < s.Length; i++) {
            for (int j = s.Length - 1; j >= i; j--) {
                // Check if characters match and length is more than current max
                if (s[i] == s[j] && (j - i + 1) > maxLength) {
                    string substr = s.Substring(i, j - i + 1);

                    if (IsPalindrome(substr)) {
                        result = substr;
                        maxLength = substr.Length;
                    }
                }
            }
        }

        return result;
    }

    private bool IsPalindrome(string str) {
        int left = 0, right = str.Length - 1;

        while (left < right) {
            if (str[left] != str[right]) return false;
            left++;
            right--;
        }

        return true;
    }
}
