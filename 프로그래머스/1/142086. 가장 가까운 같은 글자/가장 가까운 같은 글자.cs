using System;

public class Solution {
    public int[] solution(string s) {
    int[] answer = new int[s.Length];
    answer[0] = -1;
    for(int i = 1; i < s.Length; i ++)
    {
        for (int j = i - 1; j >= 0; j--)
        {
            if (s[i] == s[j])
            {
                answer[i] = i - j;
                break;
            }
            else
            {
                answer[i] = -1;
            }
        }
    }

    return answer;
}
}