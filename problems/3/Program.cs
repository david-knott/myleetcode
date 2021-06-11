using System;
using System.Collections.Generic;

namespace _3 {
    class Program {
        static void Main (string[] args) {
            new Solution ().LengthOfLongestSubstring ("abbc");
            new Solution ().LengthOfLongestSubstring ("abcabcbb");
            new Solution ().LengthOfLongestSubstring ("bbbbb");
            new Solution ().LengthOfLongestSubstring ("pwwkew");
            new Solution ().LengthOfLongestSubstring (" ");
            new Solution ().LengthOfLongestSubstring ("  ");
        }
    }
}

public class Solution {
    public int LengthOfLongestSubstring (string s) {
        int size = 0;
        Dictionary<char, int> dictionary = new Dictionary<char, int> ();
        for (int i = 0; i < s.Length; ++i) { // anchor i
            HashSet<char> visited = new HashSet<char>();
            for(int j = i; j < s.Length; ++j) {
                if(visited.Contains(s[j])) {
                    // found the item
                    break;
                }
                size = Math.Max(size, j - i + 1);
                visited.Add(s[j]);
                Console.WriteLine(i + " " + j + ":" + string.Join(",", visited));
            } 
            visited.Remove(s[i]);
        }

        Console.WriteLine(size);

        return size;
    }
}