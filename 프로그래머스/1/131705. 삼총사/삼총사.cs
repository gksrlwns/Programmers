using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i < number.Length; i++)
        {
            stack.Push(number[i]);
            for (int j = i+1; j < number.Length; j++)
            {
                stack.Push(number[j]);
                for (int k = j+1; k < number.Length; k++)
                {
                    stack.Push(number[k]);
                    if (stack.Sum() == 0) answer++;
                    
                    stack.Pop();
                }
                stack.Pop();
            }
            stack.Pop();
        }
        return answer;
    }
}