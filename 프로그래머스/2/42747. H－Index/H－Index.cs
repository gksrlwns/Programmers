using System;

public class Solution {
    public int solution(int[] citations) {
        int answer = 0;
        Array.Sort(citations);
        
        for (int i = 0;i< citations[citations.Length-1];i++)
        {
            int count = 0;
            
            for(int j = 0; j< citations.Length; j++)
            {
                if(i < citations[j])
                {
                    count++;
                }
            }
            
            if(count >= i)
                answer = count;
        }
        return answer;
    }
}