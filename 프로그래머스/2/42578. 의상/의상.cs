using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string[,] clothes) {
        int answer = 1;
        Dictionary<string, int> dic = new Dictionary<string,int>();
        int length = clothes.GetLength(0);
        for(int i = 0; i < length; i++)
        {
            if(!dic.ContainsKey(clothes[i,1]))
            {
                dic.Add(clothes[i,1],1);
            }
            else
            {
                dic[clothes[i,1]]++;
            }
        }
        foreach(var i in dic)
        {
            answer *= (i.Value + 1);
        }
        
        
        return answer-1;
    }
}