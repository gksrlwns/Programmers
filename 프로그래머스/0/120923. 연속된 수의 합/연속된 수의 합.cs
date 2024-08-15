using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int num, int total) {
        List<int> answer = new List<int>();
        int temp = total/num;
        int temp2 = 0;
        if(num % 2 != 0) temp2 = num/2;
        else temp2 = temp2 = num/2 -1;
        temp -= temp2;
        for(int i = 0; i <num; i++)
        {
            answer.Add(temp+i);
        }
        
        return answer.ToArray();
    }
}