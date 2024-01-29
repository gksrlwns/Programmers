using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string s) {
        string answer = "";
        
        char[] chars = s.ToLower().ToCharArray();
        
        for(int i = 0; i<chars.Length; i++)
        {
            if(i == 0 && chars[i]!=' ') chars[i] = Char.ToUpper(chars[i]);
            if(chars[i] == ' '&& i != (chars.Length-1))
            {
                chars[i+1] = Char.ToUpper(chars[i+1]);
            }
        }
        answer = new String(chars);
        
        return answer;
    }
}