public class Solution {
    public bool DetectCapitalUse(string word) {
        if (word == word.ToUpper()) {
            return true;
        }
        
        // Case 2: All letters are lowercase letters
        if (word == word.ToLower()) {
            return true;
        }
        
        // Case 3: Only the first letter is uppercase, rest are lowercase
        if (char.IsUpper(word[0]) && word.Substring(1) == word.Substring(1).ToLower()) {
            return true;
        }
        
        return false;
    }
}
