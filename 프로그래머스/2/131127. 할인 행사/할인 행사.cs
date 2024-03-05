using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;
        
        for(int i = 0; i < discount.Length-9; i++)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for(int j = 0; j<number.Length; j++)
            {
                dict[want[j]] = number[j];
            }
            
            for(int k = i; k < i + 10; k++)
            {
                if(dict.ContainsKey(discount[k])) dict[discount[k]]--;
            }
            bool isClear = true;
            foreach(int count in dict.Values)
            {
                if(count != 0)
                {
                    isClear = false;
                    break;
                }
            }
            if(isClear == true) answer++;
        }
        
        
        
        return answer;
    }
}