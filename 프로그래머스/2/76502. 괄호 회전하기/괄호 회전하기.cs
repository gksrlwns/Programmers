using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        List<char> list = s.ToList<char>();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(isRightString(list)) answer++;
            
            char temp = list[0];
            list.RemoveAt(0);
            list.Add(temp);
        }
        return answer;
    }
    public bool isRightString(List<char> list)
    {
        if(list.Count %2 != 0) return false;
        
        Stack<char> stack = new Stack<char>();
        
        foreach(char i in list)
        {
            switch(i)
            {
                case ')':
                    if(stack.Count == 0 || stack.Pop() != '(' ) return false;
                    break;
                case ']':
                    if(stack.Count == 0 || stack.Pop() != '[' ) return false;
                    break;
                case '}':
                    if(stack.Count == 0 || stack.Pop() != '{' ) return false;
                    break;
                default :
                    stack.Push(i);
                    break;
            }
        }
        return true;
    }
}