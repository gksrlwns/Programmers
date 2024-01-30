using System;
using System.Collections.Generic;

public class Solution {
    public bool solution(string s) {
        bool answer = true;

        Stack<char> stack = new Stack<char>();

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(') stack.Push(s[i]);
            else
            {
                if(stack.Count == 0) return answer = false;
                else stack.Pop();
            }
        }
        if(stack.Count != 0) return answer = false;
        
        
        return answer;
    }
}