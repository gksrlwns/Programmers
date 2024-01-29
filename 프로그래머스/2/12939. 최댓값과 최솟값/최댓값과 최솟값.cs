using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string s) {
        string answer = "";
        
        List<int> list = new List<int>();
        string[] strs = s.Split(' ');
        foreach(var str in strs)
        {
            list.Add(int.Parse(str));
        }
        
        list.Sort();
        answer += list.Min().ToString();
        answer += " ";
        answer += list.Max().ToString();
        
        return answer;
    }
}