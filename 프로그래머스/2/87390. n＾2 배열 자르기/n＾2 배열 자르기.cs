using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n, long left, long right) {
        int[] answer = new int[right-left+1];
        
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = (int)Math.Max(left/n,left%n) + 1;
            left++;
        }
        return answer;
    }
}