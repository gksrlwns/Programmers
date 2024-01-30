using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        while(s != "1")
        {
            answer[0]++;
            int l = s.Length;
            s = s.Replace("0","");
            answer[1]+= l - s.Length;
            s = Convert.ToString(s.Length,2);
            
        }
        
        return answer;
    }
}