using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2] ;
        int sum = brown + yellow;
        for(int i = 1; i < sum; i++)
        {
            if(sum % i != 0) continue;
            int w = sum/i;
            int h = i;
            
            if((w-2) * (h-2) == yellow)
            {
                answer[0] = w; answer[1] = h;
                break;
            }
        }
        
        
        return answer;
    }
}